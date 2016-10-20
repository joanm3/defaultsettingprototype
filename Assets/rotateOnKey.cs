using UnityEngine;
using System.Collections;

public class rotateOnKey : MonoBehaviour
{

    public static rotateOnKey Ins;
    public float rotationSum = 1f;
    // Use this for initialization
    void Start()
    {
        Ins = this;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.localEulerAngles += new Vector3(0, 0, rotationSum);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.localEulerAngles -= new Vector3(0, 0, rotationSum);

        }

    }
}
