using System;
using System.Threading.Tasks;
using Firebase.Auth;
using UnityEngine;
using Unity.Services.Authentication;
using Unity.Services.Core;

public class AuthService : MonoBehaviour
{
    private const string FirebaseProviderName = "oidc-firebase";
    public static AuthService Instance { get; private set; }

    private async void Awake()
    {
        SetSingleton();
        await InitializeAsync();
    } 
        
    
    public async Task InitializeAsync()
    {
        try
        {
            await UnityServices.InitializeAsync();
            
            // if (!AuthenticationService.Instance.IsSignedIn)
            // {
            //     await AuthenticationService.Instance.SignInAnonymouslyAsync();
            // }
            // Debug.Log($"[Auth] 로그인 완료: {AuthenticationService.Instance.PlayerId}");

            FirebaseUser user = BackendManager.Auth.CurrentUser;
            string idToken = await user.TokenAsync(false);

            await AuthenticationService.Instance.SignInWithOpenIdConnectAsync(
                FirebaseProviderName, idToken);
            
            Debug.Log($"[Auth] 로그인 완료. Firebase UID: {user.UserId} / UGS PlayerID: {AuthenticationService.Instance.PlayerId}");
        }
        catch (Exception e)
        {
            Debug.LogError($"[Auth] 초기화 실패: {e.Message}");
            throw;
        }
    }
    
    private void SetSingleton()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

