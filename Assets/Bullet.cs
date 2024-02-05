using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rigid;
    public float force = 10;

    public GameObject explosionEffect; // ���� ȿ��

    void Start()
    {
        Destroy(gameObject, 5f); // ���� ����
        rigid.AddForce(transform.forward * force, ForceMode.Impulse);
        // �������ڸ��� ������ ���ư��� bullet�� ����
    }

	// ���������� �浹������ �˷��ֱ� ���ؼ��� Message brodcasting ��� ����
	private void OnCollisionEnter(Collision collision)
	{
		Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
	}
}
