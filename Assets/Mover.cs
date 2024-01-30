using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rigid;
    public float movePower; // ���ϴ� ��

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) // ������ ������ true �ƴϸ� false
        {
            rigid.AddForce(Vector3.forward * movePower); // �� ����(z �յ�)
        }
		if (Input.GetKey(KeyCode.S))
		{
			rigid.AddForce(Vector3.back * movePower); // �� ����(z �յ�)
		}
		if (Input.GetKey(KeyCode.A))
		{
			rigid.AddForce(Vector3.left * movePower); // ��, ���� ����(x �翷)
		}
		if (Input.GetKey(KeyCode.D))
		{
			rigid.AddForce(Vector3.right * movePower); // ��, ������ ����(x �翷)
		}
	}
}
