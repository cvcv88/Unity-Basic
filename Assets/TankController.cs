using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    Vector3 moveDir;

	private void OnMove(InputValue value)
	{
		Vector2 inputDir = value.Get<Vector2>();
        moveDir.x = inputDir.x; // ������ ����
        moveDir.z = inputDir.y; // �� ��
	}
    private void Move()
    {
        transform.Translate(0, 0, moveDir.z * 10f * Time.deltaTime, Space.Self); // Translate, Rotate : 3����, ��ǥ : 2����
		transform.Rotate(0, moveDir.x * 30f * Time.deltaTime, 0, Space.Self);
		// transform.Rotate(Vector3.up, moveDir.x * 30f * Time.deltaTime, Space.Self);
    }
	private void Update()
    {
		Move();
	}

}