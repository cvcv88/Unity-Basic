using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TankController : MonoBehaviour
{
	public Transform firePoint;
	// public GameObject bulletPrefab;
	public Bullet bulletPrefab;

	public float moveSpeed;
	public float rotateSpeed;
	public float bulletForce = 10f;

	Vector3 moveDir;

	private void Update()
	{
		Move();
		Rotate();
	}

	private void OnMove(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
        moveDir.x = inputDir.x; // 오른쪽 왼쪽
        moveDir.z = inputDir.y; // 앞 뒤
	}
    private void Move()
    {
        transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime, Space.Self); // Translate, Rotate : 3차원, 좌표 : 2차원
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

}