using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFunction : MonoBehaviour
{
	[Header("This")]
	public GameObject thisGameObject;
	public string thisName;
	public bool thisActive;
	public string thisTag;
	public int thisLayer;

	public new Rigidbody rigidbody;
	// ���̵�
	// ������ �Ⱦ��� rigidbody ������ �̹� �������־ ���� �ߴ� ��, new ���� ���� ��������.
	// �ٵ� GetComponent<Rigidbody> �������

	[Header("GameObejct")]
	public GameObject newGameObject;
	public GameObject destroyGameObject;
	public GameObject findWithName;
	public GameObject findWithTag;

	[Header("Component")]
	public Component newComponent;
	public Component addComponent;
	public Component destoryComponent;
	public Component getComponent;
	public Component findComponent;

	private void Start()
	{
		//ThisFunction();
		//GameObejctFuntion();
		ComponentFunction();
	}
	private void ThisFunction()
	{
		// <���� ���ӿ�����Ʈ ����>
		// ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� Component�� ������ gameObject �Ӽ��� �̿��Ͽ� ���� ����
		thisGameObject = gameObject;        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
		thisName = gameObject.name;         // ���ӿ�����Ʈ�� �̸�
		thisActive = gameObject.activeSelf; // ���ӿ�����Ʈ�� Ȱ��ȭ ����(activeInHierarchy : ���Ӿ����� Ȱ��ȭ) 
											// ���� ���� hierarchy â���� active �� ���

		// thisActive = gameObject.activeInHierarchy // �θ� active false�� ���
		// hierarchy â������ true���� �θ� false���� �Ⱥ��̴� ���
		thisTag = gameObject.tag;           // ���ӿ�����Ʈ�� �±�
		thisLayer = gameObject.layer;       // ���ӿ�����Ʈ�� ���̾�
	}

	private void GameObejctFuntion()
	{
		// <���ӿ�����Ʈ ����>
		newGameObject = new GameObject("NewGameObejct");

		// <���ӿ�����Ʈ ����>
		if(destroyGameObject != null)
		{
			Destroy(destroyGameObject);		// �׳� ����
			Destroy(destroyGameObject, 3f);	// �� �� �ڿ� ���� ����
											// Missing ���·� �ٲ� == null
		}

		// <���ӿ�����Ʈ Ž��>
		findWithName = GameObject.Find("Main Camera");			// �̸����� ã��
		findWithTag = GameObject.FindWithTag("MainCamera");	// �±׷� ã��


	}

	private void ComponentFunction()
	{
		// <������Ʈ �߰�>
		addComponent = gameObject.AddComponent<Rigidbody>();
		// newComponent = new Rigidbody(); // �ǹ̾���, ������Ʈ�� ���� ������Ʈ�� �����Ǿ� ������ �� �ǹ� ����
		// ������Ʈ ��ü�� ����� ���ӿ�����Ʈ�� ���̴� �� �ƴ�.

		// <������Ʈ ����>
		if(destoryComponent != null)
		{
			Destroy(destoryComponent);
		}

		// <������Ʈ Ž��>
		// 1 ������ ã��
		getComponent = gameObject.GetComponent<Collider>();

		// 2 ���� ���� ������Ʈ���� ã��
		findComponent = GameObject.FindObjectOfType<Camera>();
	}
}

