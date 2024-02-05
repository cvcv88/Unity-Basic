using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TurretControll : MonoBehaviour
{
    public float rotateAngle;

    Vector3 moveDir;
	private void Start()
	{
        Debug.Log("start");
	}

	void Update()
    {
        Angle();
    }
    private void OnAngle(InputValue value)
    {
        Debug.Log("OnAngle");
        Vector2 inputDir = value.Get<Vector2>();
        moveDir.y = inputDir.x; // ÁÂ¿ì
        moveDir.x = inputDir.y; // À§¾Æ·¡
        Debug.Log($"x : {moveDir.x} y : {moveDir.y}");
    }
    private void Angle()
    {
		//transform.Rotate(Vector3.right, 30, Space.Self);
		transform.Rotate(moveDir * rotateAngle * Time.deltaTime, Space.Self);
		
	}
}
