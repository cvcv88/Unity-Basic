using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rigid;
    public float force = 10;

    public GameObject explosionEffect; // 폭발 효과

    void Start()
    {
        Destroy(gameObject, 5f); // 삭제 예약
        rigid.AddForce(transform.forward * force, ForceMode.Impulse);
        // 생성되자마자 앞으로 날아가야 bullet의 역할
    }

	// 물리엔진이 충돌했음을 알려주기 위해서는 Message brodcasting 방식 쓴다
	private void OnCollisionEnter(Collision collision)
	{
		Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
	}
}
