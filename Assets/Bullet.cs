using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rigid;
    public float force = 10;

    void Start()
    {
        Destroy(gameObject, 5f); // 삭제 예약
        rigid.AddForce(transform.forward * force, ForceMode.Impulse);
        // 생성되자마자 앞으로 날아가야 bullet의 역할
    }




}
