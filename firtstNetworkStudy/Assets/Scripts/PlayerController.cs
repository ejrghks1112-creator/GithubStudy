using System;
using UnityEngine;
using Unity.Netcode;

public class PlayerController : NetworkBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public override void OnNetworkSpawn()
    {
        if (!IsOwner) return;
        // 소유자 전용 입력 바인딩 등 초기화
    }

    private void Update()
    {
        // if (!IsOwner) return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0f, v).normalized ;
        
        
        if (move.magnitude >= 0.1)
        {
            transform.position += move * _moveSpeed * Time.deltaTime;
            _anim.SetFloat("Move",1f);
        }
        else
        {
            _anim.SetFloat("Move",0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<NetworkObject>().Despawn(true);
        }
    }
    
}