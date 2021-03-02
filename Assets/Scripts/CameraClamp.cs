using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    public Transform playerTransform;
    public float cameraHeight;
    private float XPos;
    private float ZPos;
    private float YRot;
    public float posSpeed;
    public float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cameraHeight = 0;
        posSpeed = 0.01f;
        rotSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);

        //OLD WAY----------------
        //transform.position = new Vector3(XPos, cameraHeight, ZPos);

        //if (playerTransform.transform.position.x - gameObject.transform.position.x >= 5f)
        //{
        //    XPos += PlayerScript.staticSpeed;
        //}

        //if (playerTransform.transform.position.x - gameObject.transform.position.x <= -5f)
        //{
        //    XPos -= PlayerScript.staticSpeed;
        //}

        //if (playerTransform.transform.position.z - gameObject.transform.position.z >= 5f)
        //{
        //    ZPos += PlayerScript.staticSpeed;
        //}

        //if (playerTransform.transform.position.z - gameObject.transform.position.z <= -1f)
        //{
        //    ZPos -= PlayerScript.staticSpeed;
        //}


        //NEW WAY-------------
        //transform.position = new Vector3(XPos, 0, ZPos);

        //transform.rotation = Quaternion.Euler(0, YRot, 0);

        //Position
        //if (transform.position.x < playerTransform.position.x)
        //{
        //    XPos += posSpeed;
        //}

        //if (transform.position.x > playerTransform.position.x)
        //{
        //    XPos += -posSpeed;
        //}

        //if (transform.position.z < playerTransform.position.z)
        //{
        //    ZPos += posSpeed;
        //}

        //if (transform.position.z > playerTransform.position.z)
        //{
        //    ZPos += -posSpeed;
        //}

        //Rotation

        //if (transform.rotation.y < playerTransform.rotation.y)
        //{
        //    YRot += -rotSpeed;
        //}

        //if (transform.rotation.y > playerTransform.rotation.y)
        //{
        //    YRot += rotSpeed;
        //}
    }
}
