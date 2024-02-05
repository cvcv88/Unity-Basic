using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutineKeyDownJump : MonoBehaviour
{
	public Rigidbody rigid;

	Coroutine jumpRoutine;
	IEnumerator JumpRoutine()
	{
		while(true)
		{
			yield return new WaitForSeconds(3f);
			Jump();
		}
		/*
		float startTime = Time.time;
		Debug.Log("������ ����");
		yield return new WaitUntil(() => Input.GetKetUp(KeyCode.Space));
		float endTime = Time.time;
		Debug.Log("������ ��");
		rigid.AddForce(Vector3.up * 3 * (endTime - startTime), ForceMode.Impluse);
		*/
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			jumpRoutine = StartCoroutine(JumpRoutine());
		}
		else if(Input.GetKeyUp(KeyCode.Space))
		{
			StopCoroutine(jumpRoutine);
		}
	}

	private void Jump()
	{
		Debug.Log("����");
		rigid.AddForce(Vector3.up * 3f, ForceMode.Impulse);
	}
	 
}
