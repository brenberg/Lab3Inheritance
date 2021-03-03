using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;
    public float moveSpeed;
    public static float staticSpeed;
    public static float staticThrust;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.01f;
        thrust = 0.05f;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //MAX WEIGHT
        if (BoxParent.TotalWeight >= 7f)
        {
            thrust = 2f;
        }
        else if (BoxParent.TotalWeight == 6f)
        {
            thrust = 2.5f;
        }
        else if (BoxParent.TotalWeight == 5f)
        {
            thrust = 3f;
        }
        else if (BoxParent.TotalWeight == 4f)
        {
            thrust = 3.5f;
        }
        else if (BoxParent.TotalWeight == 3f)
        {
            thrust = 4f;
        }
        else if (BoxParent.TotalWeight == 2f)
        {
            thrust = 4.5f;
        }
        else if (BoxParent.TotalWeight == 1f)
        {
            thrust = 5f;
        }
        else if (BoxParent.TotalWeight == 0f)
        {
            thrust = 6f;
        }

        if(BoxParent.TotalWeight >= 1)
        {
            anim.SetBool("HoldingCheck", true);
        }

        if (BoxParent.TotalWeight <= 0)
        {
            anim.SetBool("HoldingCheck", false);
        }

        //MOVEMENT

        staticThrust = thrust;

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * thrust);
            anim.SetFloat("WalkSpeed", 1);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -thrust);
            anim.SetFloat("WalkSpeed", 1);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -thrust);
            anim.SetFloat("WalkSpeed", 1);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * thrust);
            anim.SetFloat("WalkSpeed", 1);

        }

        else
        {
            rb.velocity = (Vector3.zero);
            anim.SetFloat("WalkSpeed", 0);
        }
    }
}
