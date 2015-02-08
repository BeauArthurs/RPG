using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Vector3 direction;
    [SerializeField]
    private int speed;
	void Start () 
    {
	}
	
	void Update () 
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.W))
            {
                direction = new Vector3(0, 1, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                direction = new Vector3(0, -1, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction = new Vector3(-1, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                direction = new Vector3(1, 0, 0);
            }
            transform.position = transform.position + direction * Time.deltaTime * speed;
        }
	}
}
