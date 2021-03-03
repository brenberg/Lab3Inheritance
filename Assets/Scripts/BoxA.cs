using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxA : BoxParent
{
    private Rigidbody rb;
    private bool throwB;
    private float i;

    private void Awake()
    {
        base.Perameters("BoxA", 1f);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        throwB = false;
    }

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime;

        if (boxPickedUp == false)
        {
            boxHeight = BoxCount * 2f + 1f;
        }

        if (boxPickedUp == true)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x, boxHeight, player.transform.position.z);
            gameObject.transform.rotation = player.transform.rotation;

            rb.isKinematic = true;
            rb.useGravity = false;  
        }

        if(addWeight == true)
        {
            WeightAddA();
            addWeight = false;
        }

        if (boxPickedUp == true && Input.GetKeyDown(KeyCode.Space))
        {
            i = 0;
            throwB = true;
            boxPickedUp = false;
            rb.isKinematic = false;
            rb.useGravity = true;

            BCountSub();
            WeightSubA();
        }

        if(throwB == true)
        {
            rb.AddForce(transform.forward * 250);
            if (i <= 3)
            {
                throwB = false;
            }
        }
    }
}
