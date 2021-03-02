using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;
    public float moveSpeed;
    private float YRot;
    private float rotSpeed;
    public static float staticSpeed;
    public static float staticThrust;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.01f;
        rotSpeed = 1f;
        thrust = 4;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //OLD WAY
        //staticSpeed = moveSpeed;

        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //transform.rotation = Quaternion.Euler(transform.rotation.x, YRot , transform.rotation.z);

        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveSpeed);
        //    moveSpeed = 0.01f;
        //}

        //else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    YRot -= rotSpeed;
        //}

        //else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - moveSpeed);
        //    moveSpeed = 0.01f;
        //}

        //else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    YRot += rotSpeed;
        //}

        //else
        //{
        //    moveSpeed = 0f;
        //}

        staticThrust = thrust;

        if (Input.GetMouseButton(0))
        {
            Debug.Log("FORWARD");
            rb.AddForce(transform.forward * thrust);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

            Debug.Log("FORWARD");
            rb.AddForce(transform.forward * thrust);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);

            rb.AddForce(transform.forward * thrust);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

            rb.AddForce(transform.forward * thrust);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);

            rb.AddForce(transform.forward * thrust);
        }

        //if(Input.GetAxis("Horizontal"))
        //{

        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
