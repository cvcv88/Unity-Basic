using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityScript : MonoBehaviour
{
	/*
     * ������Ʈ (Component)
     *
     *  Ư���� ����� ������ �� �ֵ��� ������ ���� ����� ����
	 * ���ӿ�����Ʈ�� �۵��� ������ ��ǰ
	 * ���ӿ�����Ʈ�� �߰�, �����ϴ� ����� ������ ��ǰ
     */

	/*
     * MonoBehaviour
     * 
     * ������Ʈ�� �⺻Ŭ������ �ϴ� Ŭ������ ����Ƽ ��ũ��Ʈ�� �Ļ��Ǵ� �⺻ Ŭ����
	 * ���� ������Ʈ�� ��ũ��Ʈ�� ������Ʈ�μ� ������ �� �ִ� ������ ����
	 * ��ũ��Ʈ ����ȭ ���, ����Ƽ�޽��� �̺�Ʈ�� �޴� ���, �ڷ�ƾ ����� ������
     */

	// <��ũ��Ʈ ����ȭ ���>
	// �ν����� â���� ������Ʈ�� �ɹ����� ���� Ȯ���ϰų� �����ϴ� ���
	// ������Ʈ�� ������ �����͸� Ȯ���ϰų� ����
	// ������Ʈ�� �������� �����͸� �巡�� �� ��� ������� ����

	// <�ν�����â ����ȭ�� ������ �ڷ���>
	[Header("C# Type")]
	public bool boolValue;
	public int intValue;
	public float floatValue;
	public string stringValue;
	// �� �� �⺻ �ڷ���

	// �⺻ �ڷ����� �����ڷᱸ��
	public int[] array;
	public List<int> list;

	[Header("Unity Type")]
	public Vector3 vector3;
	public Vector3Int vector3Int;
	public Color color;
	public LayerMask layerMask;
	public AnimationCurve curve;
	public Gradient gradient;

	[Header("Unity Reference")]
	public GameObject gameObject1;
	public Transform transform1;
	public Rigidbody rigidbody1;
	public Collider collider1;

	//
	[Header("Unity GameObject")]
	public GameObject obj;

	[Header("Unity Component")]
	public new Transform transform;
	public new Rigidbody rigidbody;
	public new Collider collider;
	//

	[Header("Unity Event")]
	public UnityEvent OnEvent;
	public UnityEvent<int> OnEventInt;

	// <��Ʈ����Ʈ>
	// Ŭ����, ������Ƽ �Ǵ� �Լ� ���� �����Ͽ� Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ

	[Space(30)]

	[Header("Unity Attribute")]
	[SerializeField]
	private int privateValue;
	[HideInInspector]
	public int publicValue;

	[Range(0, 10)]
	public float rangeValue;

	[Range(0, 100f)]
	public float percent;

	[TextArea(3, 5)]
	public string textField;
}