using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class SessionLauncher : NetworkBehaviour
{
    private const int MIN_PLAYERS_TO_START = 2;

    private bool _gameStarted;

    public override void OnNetworkSpawn()
    {
        if (!IsServer) return;
        NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
    }

    public override void OnNetworkDespawn()
    {
        if (!IsServer) return;
        if (NetworkManager.Singleton == null) return;
        NetworkManager.Singleton.OnClientConnectedCallback -= OnClientConnected;
    }

    private void OnClientConnected(ulong clientId)
    {
        if (_gameStarted) return;

        int count = NetworkManager.Singleton.ConnectedClientsIds.Count;
        Debug.Log($"[Session] 현재 접속자: {count}/{MIN_PLAYERS_TO_START}");

        if (count >= MIN_PLAYERS_TO_START)
        {
            _gameStarted = true;
            NetworkManager.Singleton.SceneManager.LoadScene(
                "GameScene", LoadSceneMode.Single);
        }
    }
}

