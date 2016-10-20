using UnityEngine;
using System.Collections;

public class ChangeColorButtonPressed : MonoBehaviour
{

    public Vector3 colorsMultiplier;
    public float sumValue;

    public SkinnedMeshRenderer meshRenderer;

    // Use this for initialization
    void Start()
    {
        if (!meshRenderer)
            meshRenderer = GetComponent<SkinnedMeshRenderer>();
        if (!meshRenderer)
            meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        if (!meshRenderer)
            Debug.Log("Material not found");

    }

    // Update is called once per frame
    void Update()
    {
        Material material = meshRenderer.material;
        if (Input.GetKey(KeyCode.R))
        {
            material.color += new Color(sumValue * colorsMultiplier.x, sumValue * colorsMultiplier.y, sumValue * colorsMultiplier.z);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            material.color -= new Color(sumValue * colorsMultiplier.x, sumValue * colorsMultiplier.y, sumValue * colorsMultiplier.z);

        }
        //material.color = new Color(material.color.r, material.color.g, material.color.b, Mathf.Clamp(material.color.a, min, max));

    }
}
