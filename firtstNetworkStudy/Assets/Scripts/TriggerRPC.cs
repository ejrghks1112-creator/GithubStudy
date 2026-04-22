using System;
using Unity.Netcode;
using UnityEngine;

public class TriggerRPC : NetworkBehaviour
{
    private Collider _collider;
    [SerializeField] private int damage;

    public override void OnNetworkSpawn()
    {
        _collider = GetComponent<Collider>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(!IsOwner) return;
        
        if (other.CompareTag("Player"))
        {
            Debug.Log($"{other.name} get damage {damage}");
            // RequestServerRpc(other, damage);
            RequestServerRpc(damage);
        }
    }

    [ServerRpc]
    private void RequestServerRpc(int damage)
    {
        Debug.Log($"{OwnerClientId} get damage {damage}");
        NotifyClientRpc(OwnerClientId , damage);
    }

    [ClientRpc]
    private void NotifyClientRpc(ulong clientId , int damage)
    {
        Debug.Log($"{clientId} get damage {damage}");
    }
}
