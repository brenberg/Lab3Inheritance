using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "BoxA")
        {
            TextScript.points += 1;
        }

        if (other.gameObject.name == "BoxB")
        {
            TextScript.points += 3;
        }

        if (other.gameObject.name == "BoxC")
        {
            TextScript.points += 5;
        }
    }
}
