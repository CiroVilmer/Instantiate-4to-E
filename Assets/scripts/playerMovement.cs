using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Vector3 playerPosition;
    public float rotationSpeed;
    public float moveSpeed;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        //playerPosition = transform.position + new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0.1f, 0, 0);
        //transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        //transform.localScale += new Vector3(0, 1, 0);

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, -moveSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, moveSpeed, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -moveSpeed, 0);
        }
    }
}
