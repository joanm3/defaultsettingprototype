using UnityEngine;
using System.Collections;

public class ChangeAlphaButton : MonoBehaviour
{

    public float sumValue = 0.1f;
    public float min = 1f;
    public float max = 1f;
    Material material;

    // Use this for initialization
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            material.color += new Color(0, 0, 0, sumValue);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            material.color -= new Color(0, 0, 0, sumValue);

        }
        material.color = new Color(material.color.r, material.color.g, material.color.b, Mathf.Clamp(material.color.a, min, max)); 
    }
}
