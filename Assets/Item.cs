using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	/*private void OnCollisionEnter(Collision collision)
	{
		// Debug.Log("아이템 획득");
		// Destroy(gameObject);
		// 지금 상태에서는 플레이어가 아닌 땅이랑 부딪혀도 충돌 판정됨

		if(collision.gameObject.tag == "Player") // CompareTo가 더 좋은 방법
		{
			Debug.Log("아이템 획득");
			Destroy(gameObject);
		}

		TankController controller = collision.gameObject.GetComponent<TankController>();
		if(controller != null)
		{
			// 내용
		}
	}*/

	private void OnTriggerEnter(Collider other)
	{
		// Debug.Log("아이템 획득");
		// Destroy(gameObject);
		// 지금 상태에서는 플레이어가 아닌 땅이랑 부딪혀도 충돌 판정됨

		if (other.gameObject.tag == "Player") // CompareTo가 더 좋은 방법
		{
			Debug.Log("아이템 획득");
			Destroy(gameObject);
		}
	}
	}
