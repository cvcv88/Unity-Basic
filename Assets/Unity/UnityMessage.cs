using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMessage : MonoBehaviour
{
	/*
	 * 유니티 메시지 함수(엄청 중요함!)
	 * 
	 * 유니티가 보내는 메시지에 반응하는 함수
	 * MonoBehaviour 클래스에 같은 이름의 함수를 포함할 경우 반응
	 * 스크립트는 유니티 엔진이 보내는 메세지에 받아 사건 타이밍을 확인
	 * 메시지 함수에서 자신의 행동을 정의하여 기능을 구성
	 * Awake(), Start(), OnEnable(), OnDisable(), Update(), OnLateUpdate(), OnFixedUpdate() 
	 * 
	 * 
	 * 포함할 경우 유니티메시지에 반응하지만, 포함하지 않을 경우 무시함
	 * 스크립트는 유니티 엔진이 보내는 메시지에 반응하여 자신의 행동을 정의
	 */

	private void Awake()
	{
		// 스크립트가 씬에 포함되었을 때 1회 호출되는 함수
		// 스크립트가 비활성화 되어 있는 경우에도 호출됨

		// 역할 : 스크립트가 필요로 하는 초기화 작업 진행
		//		  (게임상황과 무관한 초기화 작업)
		//        (스크립트만의 초기화 작업, 외부 게임 상황과 무관한 초기화 작업)
		// ex) 데이터 초기화, 컴포넌트 연결
		Debug.Log("Awake");
	}

	private void Start()
	{
		// 스크립트가 씬에 처음으로 Update하기 직전에 1회 호출됨(게임이 돌아가기 직전에 실행된다)
		// -> start 호출? 게임 로직이 실행되기 직전이다.
		// 다른 게임오브젝트의 준비가 필요하다? Start()
		// 스크립트가 비활성화된 경우 호출되지 않음

		// 역할 : 스크립트가 필요로 하는 초기화 작업 진행
		//		  (게임상황이 영향을 줄 수 있는 작업)
		//        (다른 스크립트와의 연관 초기화작업, 외부 게임상황이 필요한 초기화 작업)
		//        
		// ex) 몬스터의 플레이어 타겟선정
		Debug.Log("Start");
	}



	private void OnEnable()
	{
		// 스크립트가 활성화될 때마다 호출

		// 역할 : 스크립트가 활성화 되었을 때 작업 진행
		Debug.Log("OnEnable");
	}
	private void OnDisable()
	{
		// 스크립트가 비활성화될 때마다 호출

		// 역할 : 스크립트가 비활성화 되었을 때 작업 진행
		Debug.Log("OnDisable");
	}




	private void Update()
	{
		// 게임의 프레임마다 호출

		// 역할 : 핵심 게임 로직 구현
		// Debug.Log("Update");
		Debug.Log($"{gameObject.name} Update");
	}

	private void LateUpdate()
	{
		// 씬의 모든 게임오브젝트의 Update가 진행된 후 호출

		// 역할 : 게임 진행 결과가 필요한 후처리(동작이 있는) 기능 구현
		// ex) 플레이어의 위치가 결정된 후에 카메라의 위치 설정
		Debug.Log($"LateUpdate");
	}

	private void FixedUpdate()
	{
		// 유니티의 물리설정 단위시간마다 호출 (기본 1초에 50번)
		// Update와 다르게 프레임당 연산과 단위시간이 일정
		// 단, 게임로직 등, 연산이 많은 작업을 FixedUpdate에 구현하지 않아야 함

		// 역할 : 물리적 처리, 성능과 프레임 드랍에 영향을 받지 않아야 하는 작업
		Debug.Log("FixedUpdate");
	}



	private void OnDestroy()
	{
		// 스크립트가 삭제되었을 경우 호출

		// 역할 : 스크립트의 마무리 진행
		Debug.Log("OnDestory");
	}
}
