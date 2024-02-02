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
	// 하이딩
	// 지금은 안쓰는 rigidbody 변수가 이미 존재해있어서 밑줄 뜨는 것, new 쓰면 밑줄 없어진다.
	// 근데 GetComponent<Rigidbody> 사용하자

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
		// <현재 게임오브젝트 참조>
		// 컴포넌트가 붙어있는 게임오브젝트는 Component에 구현한 gameObject 속성을 이용하여 접근 가능
		thisGameObject = gameObject;        // 컴포넌트가 붙어있는 게임오브젝트
		thisName = gameObject.name;         // 게임오브젝트의 이름
		thisActive = gameObject.activeSelf; // 게임오브젝트의 활성화 여부(activeInHierarchy : 게임씬에서 활성화) 
											// 내가 직접 hierarchy 창에서 active 끈 경우

		// thisActive = gameObject.activeInHierarchy // 부모가 active false인 경우
		// hierarchy 창에서는 true지만 부모가 false여서 안보이는 경우
		thisTag = gameObject.tag;           // 게임오브젝트의 태그
		thisLayer = gameObject.layer;       // 게임오브젝트의 레이어
	}

	private void GameObejctFuntion()
	{
		// <게임오브젝트 생성>
		newGameObject = new GameObject("NewGameObejct");

		// <게임오브젝트 삭제>
		if(destroyGameObject != null)
		{
			Destroy(destroyGameObject);		// 그냥 삭제
			Destroy(destroyGameObject, 3f);	// 몇 초 뒤에 삭제 예약
											// Missing 상태로 바뀜 == null
		}

		// <게임오브젝트 탐색>
		findWithName = GameObject.Find("Main Camera");			// 이름으로 찾기
		findWithTag = GameObject.FindWithTag("MainCamera");	// 태그로 찾기


	}

	private void ComponentFunction()
	{
		// <컴포넌트 추가>
		addComponent = gameObject.AddComponent<Rigidbody>();
		// newComponent = new Rigidbody(); // 의미없다, 컴포넌트는 게임 오브젝트에 부착되어 동작할 때 의미 있음
		// 컴포넌트 자체만 만들고 게임오브젝트에 붙이는 것 아님.

		// <컴포넌트 삭제>
		if(destoryComponent != null)
		{
			Destroy(destoryComponent);
		}

		// <컴포넌트 탐색>
		// 1 씬에서 찾기
		getComponent = gameObject.GetComponent<Collider>();

		// 2 같은 게임 오브젝트에서 찾기
		findComponent = GameObject.FindObjectOfType<Camera>();
	}
}

