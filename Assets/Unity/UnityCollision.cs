using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCollision : MonoBehaviour
{
	/*
     * 충돌체
     * 
     * 물리적 충돌을 위해 게임오브젝트의 모양을 정의
	 * 게임오브젝트의 표현인 메시와 똑같을 필요는 없음
	 * 충돌체가 충돌상황에 있을 경우 유니티 충돌 메시지를 받아 상황을 확인
     */

	// <유니티 충돌 메시지>
	// 충돌에 진입했을 때
	private void OnCollisionEnter(Collision collision) // Collision 충돌한 상대
	{
		GameObject other = collision.gameObject;
		Debug.Log("Enter");
	}

	// 충돌중일 때(계속해서 Debug.Log(); 실행함)
	private void OnCollisionStay(Collision collision)
	{
		Debug.Log("Stay");
	}

	// 충돌에 탈출했을 때
	private void OnCollisionExit(Collision collision) 
	{
		Debug.Log("Exit");
	}



	/*
	 * 트리거 충돌체
	 * 
	 * 하나의 충돌체가 충돌을 일으키지 않고 다른 충돌체의 공간에 들어가는 것을 감지
	 * 트리거가 겹침상황에 있을 경우 유니티 트리거 메시지를 받아 상황을 확인
	 * 
	 * 물리적인 반발력을 발생시키지 않고 collision이 아닌 collider
	 * 통과할 수 있는 경우에는 Trigger 사용하기
	 * ex) 접촉했을때 먹어지는 아이템
	 */

	// <유니티 트리거 메시지>
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("OnTriggerEnter");
	}

	private void OnTriggerStay(Collider other)
	{
		Debug.Log("OnTriggerStay");
	}

	private void OnTriggerExit(Collider other)
	{
		Debug.Log("OnTriggerExit");
	}



	// <레이어기반 충돌 감지>
	// 게임오브젝트의 레이어를 활용하여 충돌체간의 충돌가능 여부를 설정 가능
	// edit -> ProjectSettings -> Physics 에서 설정 가능

	// <충돌체 종류>
	// (1) 정적 충돌체 (Static Collider)
	// Rigidbody가 없는 충돌체, 외부에 힘에 움직이지 않음
	// 절대로 움직이지 않는 지형, 구성요소에 주로 사용(건물 등)

	// (2) 리지드바디 충돌체 (Rigidbody Collider)
	// Rigidbody가 있는 충돌체, 외부에 힘을 받아 움직임
	// 충돌할 수 있으며 물리를 사용하는 게임 내 가장 흔히 사용되는 충돌체에 사용

	// (3) 키네마틱 충돌체 (Kinematic Collider)
	// Kinematic Rigidbody가 있는 충돌체, 외부의 힘에 반응하지 않음
	// 움직이지만 외부 충격에는 밀리지 않는 물체(밀어내는 장애물, 미닫이문 등)등 에 사용(폴가이즈 바닥 장애물 -ㅇ-)
	// kinematic 상태를 활성화/비활성화 하여 움직임 여부를 설정할 경우 사용


	// <충돌체 상호작용 매트릭스>
	// 편의상 정적충돌체(SC), 리지드바디충돌체(RC), 키네마틱충돌체(KC)로 표현
	// 편의상 정적트리거(ST), 리지드바디트리거(RT), 키네마틱트리거(KT)로 표현

	// 충돌시 충돌 메시지가 전송
	//		SC	RC	KC
	// SC		 O	
	// RC	 O	 O	 O
	// KC		 O	

	// 충돌시 트리거 메시지가 전송
	//		SC	RC	KC	ST	RT	KT
	// SC					 O	 O
	// RC				 O	 O	 O
	// KC				 O	 O	 O
	// ST		 O	 O		 O	 O
	// RT	 O	 O	 O	 O	 O	 O
	// KT	 O	 O	 O	 O	 O	 O
}
