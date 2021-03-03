using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxParent : MonoBehaviour
{
    //public string bType;

    public float boxHeight;

    public bool boxPickedUp;

    public bool addWeight;

    public Transform player;

    public static float BoxCount;

    public static float TotalWeight;

    // Start is called before the first frame update
    void Start()
    {
        boxPickedUp = false;

        addWeight = false;

        BoxCount = 1;

        TotalWeight = 0;
    }

    public virtual void Perameters(string type, float weight)
    {
        Debug.Log(type + " Weight = " + weight);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(TotalWeight);
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("TriggerEnter");
        if (Input.GetKey(KeyCode.E))
        {
            boxPickedUp = true;
            addWeight = true;
            BCountAdd();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //BoxCount += 1f;
    }

    public void BCountAdd()
    {
        BoxCount += 1f;
    }
    public void BCountSub()
    {
        BoxCount -= 1f;
    }
    public void WeightAddA()
    {
        TotalWeight += 1;
    }
    public void WeightSubA()
    {
        TotalWeight -= 1;
    }
    public void WeightAddB()
    {
        TotalWeight += 2;
    }
    public void WeightSubB()
    {
        TotalWeight -= 2;
    }
    public void WeightAddC()
    {
        TotalWeight += 3;
    }
    public void WeightSubC()
    {
        TotalWeight -= 3;
    }

}
