using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove : MonoBehaviour
{
	/*public Transform trans;
    public float speed;
	public float jump;
	public Rigidbody rigid;
	private void Awake()
	{
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * Vector3.left * Time.deltaTime);
        }
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(speed * Vector3.right * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.Space) && Time.time > jump)
		{
			jump = Time.time + 2;
			transform.Translate(speed * Vector3.up * Time.deltaTime);
		}
	}*/

	/*[SerializeField] float jumpCoolTime;
	[SerializeField] Rigidbody rigid;

	private void Update()
	{
		jumpCoolTime += Time.deltaTime;

		if (jumpCoolTime >= 2f && Input.GetKeyDown(KeyCode.Space))
		{
			// 점프를 할 수 없음
			rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
			jumpCoolTime = 0f;

		}

	}*/

	// 2
	/*[SerializeField] float jumpCoolTime;
	[SerializeField] Rigidbody rigid;

	private bool isJumpable;

	private void Update()
	{
		jumpCoolTime += Time.deltaTime;

		if (jumpCoolTime >= 2f && Input.GetKeyDown(KeyCode.Space))
		{
			// 점프를 할 수 없음
			rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
			StartCoroutine(JumpCoolTimeRoutine());
		}

		IEnumerator JumpCoolTimeRoutine()
		{
			isJumpable = false;
			Debug.Log("점프 불가능 설정");
			yield return new WaitForSeconds(jumpCoolTime);
			Debug.Log("점프 가능 설정");
			isJumpable = true;
		}
	}*/

}
