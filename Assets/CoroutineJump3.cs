using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineJump3 : MonoBehaviour
{
	public Rigidbody rigid;
	IEnumerator SubRoutine()
	{
		yield return new WaitForSeconds(2);
		rigid.AddForce(Vector3.up * 3f, ForceMode.Impulse);
		yield return new WaitForSeconds(2);
		rigid.AddForce(Vector3.up * 3f, ForceMode.Impulse);
		yield return new WaitForSeconds(2);
		rigid.AddForce(Vector3.up * 3f, ForceMode.Impulse);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(SubRoutine());
		}
	}

	/*
	 public Rigidbody rigid;
	IEnumerator JumpRoutine()
	{
		yield return new WaitForSeconds(3f);
		Jump();
		yield return new WaitForSeconds(3f);
		Jump();
		yield return new WaitForSeconds(3f);
		Jump();
		// for문 쓰기
		for(int i = 0; i < 5; i++)
		{
			yield return new WaitForSeconds(3f);
			Jump();
		}
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rigid.AddForce(Vector3.up * 3f, ForceMode.Impulse);
		}
	}

	private void Jump()
	{
		Debug.Log("점프");
		rigid.AddForce(Vector3.up * 3f, ForceMode.Impulse);
	}
	 */

}
