using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform follow;
    public Vector3 offset; // ��ŭ �Ÿ��� �ΰ� ���󰡾� �ϴ���, ����

	private void LateUpdate() // ������ �׳� Update ���� LateUpdate���� ī�޶� �������ִ� ���� ����
	{
		transform.position = follow.position + offset;
		transform.LookAt(follow.position);
	}

}
