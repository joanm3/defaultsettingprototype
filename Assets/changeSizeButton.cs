using UnityEngine;
using System.Collections;

public class changeSizeButton : MonoBehaviour
{

    public float sumValue = 0.1f;
    public float min = 0.1f;
    public float max = 2f;
    CapsuleCollider playerCollider;

    void Start()
    {
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<CapsuleCollider>();
    }

    void FixedUpdate()
    {
        transform.localScale = new Vector3(Mathf.Clamp(transform.localScale.x, min, max), Mathf.Clamp(transform.localScale.x, min, max), Mathf.Clamp(transform.localScale.x, min, max));
    }

    void OnTriggerStay(Collider other)
    {
        if (other == playerCollider)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.localScale += new Vector3(sumValue, sumValue, sumValue);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                transform.localScale -= new Vector3(sumValue, sumValue, sumValue);
            }
        }

    }
}
