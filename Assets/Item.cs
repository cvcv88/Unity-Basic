using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	/*private void OnCollisionEnter(Collision collision)
	{
		// Debug.Log("������ ȹ��");
		// Destroy(gameObject);
		// ���� ���¿����� �÷��̾ �ƴ� ���̶� �ε����� �浹 ������

		if(collision.gameObject.tag == "Player") // CompareTo�� �� ���� ���
		{
			Debug.Log("������ ȹ��");
			Destroy(gameObject);
		}

		TankController controller = collision.gameObject.GetComponent<TankController>();
		if(controller != null)
		{
			// ����
		}
	}*/

	private void OnTriggerEnter(Collider other)
	{
		// Debug.Log("������ ȹ��");
		// Destroy(gameObject);
		// ���� ���¿����� �÷��̾ �ƴ� ���̶� �ε����� �浹 ������

		if (other.gameObject.tag == "Player") // CompareTo�� �� ���� ���
		{
			Debug.Log("������ ȹ��");
			Destroy(gameObject);
		}
	}
	}
