using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UnityTransform : MonoBehaviour
{
	/*
     * Ʈ������ Transform
     * ���ӿ�����Ʈ�� ��ġ, ȸ��, ũ�⸦ �����ϴ� ������Ʈ
	 * ���ӿ�����Ʈ�� �θ�-�ڽ� ���¸� �����ϴ� ������Ʈ
	 * ���ӿ�����Ʈ�� �ݵ�� �ϳ��� Ʈ������ ������Ʈ�� ������ ������ �߰� & ������ �� ����
	 */

	public Transform thisTranform;
	public float moveSpeed;
	bool IsWorld = false;

	// <Ʈ������ ����>
	/*private void Start()
	{
		thistranform = transform; // �� ���� ������Ʈ�� ���� transform
	}*/

	private void TransformReference()
	{
		thisTranform = transform;
	}

	// <Ʈ������ �̵�>
	private void Translate()
	{
		// position�� �̿��� �̵�(���� ���� X, �⺻���� world �������� ������)
		transform.position += new Vector3(1, 0, 0); // 1

		// ����(����)�� �������� �̵�
		transform.Translate(1, 0, 0, Space.World); // 2

		// �ڽ��� �������� �̵�, ���� ���ϸ� self ����
		transform.Translate(1, 0, 0, Space.Self);
	}

	// <Ʈ������ ȸ��>
	private void Rotate()
	{
		// ���带 �������� ȸ��
		transform.Rotate(Vector3.up, 30, Space.World);

		// �ڽ��� �������� ȸ��
		transform.Rotate(Vector3.up, 30, Space.Self);

		// ��ġ�� �������� ȸ��, ex) (0,0,0) �������� ȸ��
		transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30 * Time.deltaTime);

		// ��ġ�� �ٶ󺸴� ȸ��, ex) (0,0,0)�� �ٶ󺸰� ȸ��
		transform.LookAt(new Vector3(0, 0, 0));
	}

	// <Ʈ������ ��>
	private void Axis()
	{
		// Ʈ�������� z��
		transform.forward = Vector3.forward;

		// Ʈ�������� x��
		transform.right = Vector3.right;

		// Ʈ�������� y��
		transform.up = Vector3.up;
	}


	// <Quarternion & Euler>
	// Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
	//				  �������� ȸ������ ������ ������ �߻����� ����
	// EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
	//				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
	// ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����

	// Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
	// ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����
	private void Rotation()
	{
		// Ʈ�������� ȸ������ Euler���� ǥ���� �ƴ� Quaternion�� �����
		transform.rotation = Quaternion.identity;

		// Euler������ Quaternion���� ��ȯ
		transform.rotation = Quaternion.Euler(0, 90, 0);
		Vector3 rotation = transform.rotation.eulerAngles;
	}


	// <Ʈ������ �θ�-�ڽ� ����>
	// Ʈ�������� �θ� Ʈ�������� ���� �� ����
	// �θ� Ʈ�������� �ִ� ��� �θ� Ʈ�������� ��ġ, ȸ��, ũ�� ������ ���� �����
	// �̸� �̿��Ͽ� ������ ������ �����ϴµ� ������ (ex. ���� �����̸�, �հ����� ���� ������)
	// ���̾��Ű â �󿡼� �巡�� & ����� ���� �θ�-�ڽ� ���¸� ������ �� ����
	private void TransformParent()
	{
		GameObject newGameObject = new GameObject() { name = "NewGameObject" };

		// �θ� ����, �����س����� �˾Ƽ� ����ٴѴ�
		transform.parent = newGameObject.transform;

		// �θ� ���������� Ʈ������
		// transform.localPosition	: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ��ġ
		// transform.localRotation	: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ȸ��
		// transform.localScale		: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ũ��

		// �θ� ���� = ���� �ֻ����θ��. ���� �������� ��ġ ��� �ٲ�
		transform.parent = null;

		// ���带 ���������� Ʈ������
		// transform.localPosition == transform.position	: �θ�Ʈ�������� ���� ��� ���带 �������� �� ��ġ
		// transform.localRotation == transform.rotation	: �θ�Ʈ�������� ���� ��� ���带 �������� �� ȸ��
		// transform.localScale								: �θ�Ʈ�������� ���� ��� ���带 �������� �� ũ��
	}

	/*public Transform sphere;
	public Transform cube;*/
	private void Update()
	{
		/*float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");*/

		/*if (IsWorld)
		{
			transform.Translate(x * moveSpeed * Time.deltaTime, 0, y * moveSpeed * Time.deltaTime, Space.World);
		}
		else
		{
			transform.Translate(x * moveSpeed * Time.deltaTime, 0, y * moveSpeed * Time.deltaTime, Space.Self);
		}*/

		/*// Vector3.forward : 0, 0, 1, transform.forward : �Ķ��� �� �������� �չ���
		sphere.position = transform.position + new Vector3(0, 0, 1); // world
		cube.position = transform.position + transform.forward; // self*/

		// transform.forward = Vector3.right;
	}


}
