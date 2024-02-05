using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Script : MonoBehaviour
{
    public Rigidbody rigid;
    public float movePower = 5;
	public float jumpPower = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid.AddForce(Vector3.forward * movePower);
        }
		if (Input.GetKey(KeyCode.DownArrow))
		{
			rigid.AddForce(Vector3.back * movePower);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rigid.AddForce(Vector3.left * movePower);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			rigid.AddForce(Vector3.right * movePower);
		}
		if (Input.GetKey(KeyCode.Space))
		{
			rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
		}

	}
}
