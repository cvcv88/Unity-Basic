using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rigid;
    public float movePower; // 가하는 힘

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) // 누르고 있으면 true 아니면 false
        {
            rigid.AddForce(Vector3.forward * movePower); // 앞 방향(z 앞뒤)
        }
		if (Input.GetKey(KeyCode.S))
		{
			rigid.AddForce(Vector3.back * movePower); // 뒤 방향(z 앞뒤)
		}
		if (Input.GetKey(KeyCode.A))
		{
			rigid.AddForce(Vector3.left * movePower); // 옆, 왼쪽 방향(x 양옆)
		}
		if (Input.GetKey(KeyCode.D))
		{
			rigid.AddForce(Vector3.right * movePower); // 옆, 오른쪽 방향(x 양옆)
		}
	}
}
