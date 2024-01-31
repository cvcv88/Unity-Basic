using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineJump : MonoBehaviour
{
    public Rigidbody rigid;
    IEnumerator SubRoutine()
    {
		yield return new WaitForSeconds(3f);
		rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
	}

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SubRoutine());
        } 
    }

	/*
	 1¹ø Á¤´ä
     public Rigidbody rigid;
	IEnumerator JumpRoutine()
	{
		yield return new WaitForSeconds(3f);
		Jump();
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
		rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
	}
     */
}
