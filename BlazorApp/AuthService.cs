using BlazorApp.Models;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient Http;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        const string _URL = "https://localhost:5001/api/";
        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            Http = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {
            var result = await Http.PostJsonAsync<RegisterResult>(_URL + Controller.login + "/register", registerModel);

            return result;
        }

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            var loginAsJson = JsonSerializer.Serialize(loginModel);
            var loginResult = await Http.PostAsync(_URL + Controller.login, new StringContent(loginAsJson, Encoding.UTF8, "application/json"));
            var result = JsonSerializer.Deserialize<LoginResult>(await loginResult.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            //if (!loginResult.IsSuccessStatusCode)
            //{
                // return result;
                //}

                /*await _localStorage.SetItemAsync("authToken", loginResult.Token);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);

                return loginResult;*/

                //LoginModel loginModel = new LoginModel { Email = login, Password = password };
                //var result = await Http.PostJsonAsync<LoginResult>(_URL + Controller.login, loginModel).;
                if (result.Successful)
                {
                await _localStorage.SetItemAsync("authToken", result.Token);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);
                Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);
                return result;
                }
                return result;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            Http.DefaultRequestHeaders.Authorization = null;
        }
    }

    public interface IAuthService
    {
        Task<LoginResult> Login(Models.LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);

    }
}
