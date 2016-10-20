using UnityEngine;
using System.Collections;

public class ChangeColorButtonPressed : MonoBehaviour
{

    public Vector3 colorsMultiplier;
    public float sumValue;
    public SkinnedMeshRenderer meshRenderer;
    public CapsuleCollider playerCollider;

    // Use this for initialization
    void Start()
    {
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<CapsuleCollider>();
        if (!meshRenderer)
            meshRenderer = GetComponent<SkinnedMeshRenderer>();
        if (!meshRenderer)
            meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        if (!meshRenderer)
            Debug.Log("Material not found");

    }

    void OnTriggerStay(Collider other)
    {

        //Transform _transform = (objectToScale != null) ? objectToScale : this.transform;

        Material material = meshRenderer.material;
        if (other == playerCollider)
        {
            if (Input.GetKey(KeyCode.R))
            {
                material.color += new Color(sumValue * colorsMultiplier.x, sumValue * colorsMultiplier.y, sumValue * colorsMultiplier.z);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                material.color -= new Color(sumValue * colorsMultiplier.x, sumValue * colorsMultiplier.y, sumValue * colorsMultiplier.z);
            }
        }

    }


}
