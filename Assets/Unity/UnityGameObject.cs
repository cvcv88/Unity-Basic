using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityGameObject : MonoBehaviour
{
    /*
     * 게임오브젝트(GameObject)
     * 
     * 씬을 구성하는 모든 오브젝트의 기본클래스
     * 게임오브젝트만으로는 독자적인 기능이 없음. 실질적인 기능은 컴포넌트들이 수행
     * 게임오브젝트는 컴포넌트들을 가지기 위한 컨테이너
     */

    GameObject gameObj;

	// <게임오브젝트 구성요소>
	// name : 게임오브젝트의 이름
	// active : 게임오브젝트의 활성화 여부, 비활성화인 경우 씬에 없는 게임오브젝트로 취급됨
	// tag : 게임오브젝트의 태그, 게임오브젝트를 특정하기 위한 수단으로 사용
	// layer : 게임오브젝트의 레이어, 게임오브젝트들의 분류를 구분하기 위한 수단으로 사용
	// static : 게임오브젝트의 정적상태 여부, 런타임 당시 변경되지 않은 데이터를 지정하여 최적화

	// component	: 게임오브젝트에 포함된 기능모듈, 게임오브젝트는 컴포넌트를 담기위한 컨테이너 역할
}
