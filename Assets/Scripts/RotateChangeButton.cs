using UnityEngine;
using System.Collections;

public class RotateChangeButton : MonoBehaviour {

    public float sumValue = 1f;


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.R))
        {
            transform.eulerAngles += new Vector3(0, 0, sumValue);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.eulerAngles -= new Vector3(0, 0, sumValue);


        }
       
    }
}
