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
        moveDir.x = inputDir.x; // ������ ����
        moveDir.z = inputDir.y; // �� ��
	}
    private void Move()
    {
		Vector3 forceDir = transform.forward * moveDir.z;
		// ���� ���� �ִ� �� �������� z �Է��� ��ŭ
		rigid.AddForce(forceDir * movePower, ForceMode.Force);
		// ������ ó���ϱ� Update���� FixedUpdate�� �ֱ�
        transform.Translate(0, 0, moveDir.z * movePower * Time.deltaTime, Space.Self); // Translate, Rotate : 3����, ��ǥ : 2����

		if(rigid.velocity.magnitude > maxSpeed) // �ְ� �ӵ� �ѱ� ��� / magnitude ũ�� ���� �ӵ��� ũ�Ⱑ �ְ� �ӵ����� Ŭ��
		{
			rigid.velocity = rigid.velocity.normalized * maxSpeed; // ��������(ũ��� 1, ���⸸ �����ϴ� ����) * maxSpeed�� �ӵ� ���߱�
			// normalized : �������ͷ� �����
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
		Debug.Log("�߻�");
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
		Debug.Log("�Ҹ�");
	}
	IEnumerator FireCoroutine()
	{
		Debug.Log("�ڷ�ƾ ����");
		bulletForce = 5f;
		float start = Time.time;
		yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.LeftControl));
		float end = Time.time;
		bulletForce += bulletForce + (end - start) * 3;
		Debug.Log("�ڷ�ƾ ����");
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