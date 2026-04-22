
using UnityEngine;
using Unity.Netcode;

public class RpcPractice : NetworkBehaviour
{
    [SerializeField] private Renderer _renderer;
    private int _score;

    public override void OnNetworkSpawn()
    {
        _renderer = GetComponentInChildren<Renderer>();
    }

    private void Update()
    {
        if (!IsOwner) return;

        // E 키: 서버에 점수 추가 요청 (ServerRpc)
        if (Input.GetKeyDown(KeyCode.E))
        {
            RequestAddScoreServerRpc(10);
        }

        // Q 키: 서버에 색상 변경 요청 (ServerRpc → ClientRpc 조합)
        if (Input.GetKeyDown(KeyCode.Q))
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            RequestChangeColorServerRpc(r, g, b);
        }
    }

    // --- ServerRpc ---

    // 점수 추가 요청 (클라이언트 → 서버)
    [ServerRpc]
    private void RequestAddScoreServerRpc(int amount)
    {
        // 서버에서 점수 처리
        _score += amount;
        Debug.Log($"[Server] {OwnerClientId} 번 플레이어 점수: {_score}");

        // 모든 클라이언트에게 결과 알림
        NotifyScoreUpdatedClientRpc(OwnerClientId, _score);
    }

    // 색상 변경 요청 (클라이언트 → 서버)
    [ServerRpc]
    private void RequestChangeColorServerRpc(float r, float g, float b)
    {
        // 서버가 검증 후 모든 클라이언트에 색상 변경 지시
        ApplyColorClientRpc(r, g, b);
    }

    // --- ClientRPC ---

    // 점수 갱신 알림 (서버 → 모든 클라이언트)
    [ClientRpc]
    private void NotifyScoreUpdatedClientRpc(ulong clientId, int newScore)
    {
        Debug.Log($"[Client] {clientId} 번 플레이어 점수가 {newScore} 으로 변경되었습니다.");
    }

    // 색상 적용 (서버 → 모든 클라이언트)
    [ClientRpc]
    private void ApplyColorClientRpc(float r, float g, float b)
    {
        if (_renderer == null) return;
        _renderer.material.color = new Color(r, g, b);
    }
}

