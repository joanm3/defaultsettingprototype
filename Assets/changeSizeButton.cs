using UnityEngine;
using System.Collections;

public class changeSizeButton : MonoBehaviour
{

    public float sumValue = 0.1f;
    public float min = 0.1f;
    public float max = 2f;
    public Transform objectToScale;
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

        Transform _transform = (objectToScale != null) ? objectToScale: this.transform; 

        if (other == playerCollider)
        {
            if (Input.GetKey(KeyCode.R))
            {
                if (_transform.localScale.x > max)
                    _transform.localScale = new Vector3(max, max, max);
                else
                    _transform.localScale += new Vector3(sumValue, sumValue, sumValue);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                if (_transform.localScale.x < min)
                    _transform.localScale = new Vector3(min, min, min);
                else
                    _transform.localScale -= new Vector3(sumValue, sumValue, sumValue);
            }
        }

    }
}
