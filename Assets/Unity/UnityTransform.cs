using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UnityTransform : MonoBehaviour
{
	/*
     * 트랜스폼 Transform
     * 게임오브젝트의 위치, 회전, 크기를 저장하는 컴포넌트
	 * 게임오브젝트의 부모-자식 상태를 저장하는 컴포넌트
	 * 게임오브젝트는 반드시 하나의 트랜스폼 컴포넌트를 가지고 있으며 추가 & 제거할 수 없음
	 */

	public Transform thisTranform;
	public float moveSpeed;
	bool IsWorld = false;

	// <트랜스폼 접근>
	/*private void Start()
	{
		thistranform = transform; // 이 게임 오브젝트에 붙은 transform
	}*/

	private void TransformReference()
	{
		thisTranform = transform;
	}

	// <트랜스폼 이동>
	private void Translate()
	{
		// position을 이용한 이동(따로 설정 X, 기본으로 world 기준으로 움직임)
		transform.position += new Vector3(1, 0, 0); // 1

		// 세상(월드)를 기준으로 이동
		transform.Translate(1, 0, 0, Space.World); // 2

		// 자신을 기준으로 이동, 설정 안하면 self 기준
		transform.Translate(1, 0, 0, Space.Self);
	}

	// <트랜스폼 회전>
	private void Rotate()
	{
		// 월드를 기준으로 회전
		transform.Rotate(Vector3.up, 30, Space.World);

		// 자신을 기준으로 회전
		transform.Rotate(Vector3.up, 30, Space.Self);

		// 위치를 기준으로 회전, ex) (0,0,0) 기준으로 회전
		transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30 * Time.deltaTime);

		// 위치를 바라보는 회전, ex) (0,0,0)을 바라보고 회전
		transform.LookAt(new Vector3(0, 0, 0));
	}

	// <트랜스폼 축>
	private void Axis()
	{
		// 트랜스폼의 z축
		transform.forward = Vector3.forward;

		// 트랜스폼의 x축
		transform.right = Vector3.right;

		// 트랜스폼의 y축
		transform.up = Vector3.up;
	}


	// <Quarternion & Euler>
	// Quarternion	: 유니티의 게임오브젝트의 3차원 방향을 저장하고 이를 방향에서 다른 방향으로의 상대 회전으로 정의
	//				  기하학적 회전으로 짐벌락 현상이 발생하지 않음
	// EulerAngle	: 3축을 기준으로 각도법으로 회전시키는 방법
	//				  직관적이지만 짐벌락 현상이 발생하여 회전이 겹치는 축이 생길 수 있음
	// 짐벌락		: 같은 방향으로 오브젝트의 두 회전 축이 겹치는 현상

	// Quarternion을 통해 회전각도를 계산하는 것은 직관적이지 않고 이해하기 어려움
	// 보통의 경우 쿼터니언 -> 오일러각도 -> 연산진행 -> 결과오일러각도 -> 결과쿼터니언 과 같이 연산의 결과 쿼터니언을 사용함
	private void Rotation()
	{
		// 트랜스폼의 회전값은 Euler각도 표현이 아닌 Quaternion을 사용함
		transform.rotation = Quaternion.identity;

		// Euler각도를 Quaternion으로 변환
		transform.rotation = Quaternion.Euler(0, 90, 0);
		Vector3 rotation = transform.rotation.eulerAngles;
	}


	// <트랜스폼 부모-자식 상태>
	// 트랜스폼은 부모 트랜스폼을 가질 수 있음
	// 부모 트랜스폼이 있는 경우 부모 트랜스폼의 위치, 회전, 크기 변경이 같이 적용됨
	// 이를 이용하여 계층적 구조를 정의하는데 유용함 (ex. 팔이 움직이면, 손가락도 같이 움직임)
	// 하이어라키 창 상에서 드래그 & 드롭을 통해 부모-자식 상태를 변경할 수 있음
	private void TransformParent()
	{
		GameObject newGameObject = new GameObject() { name = "NewGameObject" };

		// 부모 지정, 설정해놓으면 알아서 따라다닌다
		transform.parent = newGameObject.transform;

		// 부모를 기준으로한 트랜스폼
		// transform.localPosition	: 부모트랜스폼이 있는 경우 부모를 기준으로 한 위치
		// transform.localRotation	: 부모트랜스폼이 있는 경우 부모를 기준으로 한 회전
		// transform.localScale		: 부모트랜스폼이 있는 경우 부모를 기준으로 한 크기

		// 부모 해제 = 내가 최상위부모다. 월드 기준으로 위치 잡게 바뀜
		transform.parent = null;

		// 월드를 기준으로한 트랜스폼
		// transform.localPosition == transform.position	: 부모트랜스폼이 없는 경우 월드를 기준으로 한 위치
		// transform.localRotation == transform.rotation	: 부모트랜스폼이 없는 경우 월드를 기준으로 한 회전
		// transform.localScale								: 부모트랜스폼이 없는 경우 월드를 기준으로 한 크기
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

		/*// Vector3.forward : 0, 0, 1, transform.forward : 파란색 선 방향으로 앞방향
		sphere.position = transform.position + new Vector3(0, 0, 1); // world
		cube.position = transform.position + transform.forward; // self*/

		// transform.forward = Vector3.right;
	}


}
