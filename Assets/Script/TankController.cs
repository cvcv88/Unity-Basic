using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TankController : MonoBehaviour
{
	public Rigidbody rigid;
	public Transform headTranform;
	public Transform firePoint;
	// public GameObject bulletPrefab;
	public Bullet bulletPrefab;

	public float movePower;
	public float rotateSpeed;
	public float bulletForce = 10f;
	public float maxSpeed;

	Vector3 moveDir;

	public CinemachineVirtualCamera normalCamera;
	public CinemachineVirtualCamera zoomCamera;

	public AudioSource shootSound;

	private void Update()
	{
		// Move();
		Rotate();
		// Head();
	}

	private void FixedUpdate()
	{
		Move();
	}

	private void OnMove(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
        moveDir.x = inputDir.x; // 오른쪽 왼쪽
        moveDir.z = inputDir.y; // 앞 뒤
	}
    private void Move()
    {
		Vector3 forceDir = transform.forward * moveDir.z;
		// 내가 보고 있는 앞 방향으로 z 입력한 만큼
		rigid.AddForce(forceDir * movePower, ForceMode.Force);
		// 물리적 처리니까 Update말고 FixedUpdate에 넣기
        transform.Translate(0, 0, moveDir.z * movePower * Time.deltaTime, Space.Self); // Translate, Rotate : 3차원, 좌표 : 2차원

		if(rigid.velocity.magnitude > maxSpeed) // 최고 속도 넘긴 경우 / magnitude 크기 현재 속도의 크기가 최고 속도보다 클때
		{
			rigid.velocity = rigid.velocity.normalized * maxSpeed; // 단위벡터(크기는 1, 방향만 존재하는 벡터) * maxSpeed로 속도 맞추기
			// normalized : 단위벡터로 만들기
		}
    }
	private void Rotate()
	{
		transform.Rotate(0, moveDir.x * rotateSpeed * Time.deltaTime, 0, Space.Self);
		// transform.Rotate(Vector3.up, moveDir.x * 30f * Time.deltaTime, Space.Self);
	}
	
	private void OnFire(InputValue value)
	{
		// Fire();
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
	private void OnFire2(InputValue value)
	{
		Debug.Log("발사");
		// Fire();
		StartCoroutine(FireCoroutine());
		shootSound.Play();
	}
	private void Fire()
	{
		//Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		/*GameObject bulletObject = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletObject.GetComponent<Bullet>();*/

		/*Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		bullet.force = bulletForce;*/
		Debug.Log(bulletForce);
		Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		bullet.force = bulletForce;

		shootSound.Play();
		Debug.Log("소리");
	}
	IEnumerator FireCoroutine()
	{
		Debug.Log("코루틴 실행");
		bulletForce = 5f;
		float start = Time.time;
		yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.LeftControl));
		float end = Time.time;
		bulletForce += bulletForce + (end - start) * 3;
		Debug.Log("코루틴 종료");
		Fire();
	}

	private void OnZoom(InputValue value)
	{
		if(value.isPressed)
		{
			Debug.Log("Zoom On");
			zoomCamera.Priority = 50;
		}
        else
        {
			Debug.Log("Zoom Off");
			zoomCamera.Priority = 1;
        }
    }


}