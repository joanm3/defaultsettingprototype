using UnityEngine;
using System.Collections;

public class ChangeLightEmission : MonoBehaviour
{

    public float sumValue = 1;
    public int min = 0;
    public int max = 10;
    public Light[] lights;
    public CapsuleCollider playerCollider;

    void Start()
    {
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<CapsuleCollider>();
        //lights = GetComponentInChildren<ParticleSystem>();
    }

    void FixedUpdate()
    {
        sumValue = Mathf.Clamp(sumValue, min, max);
    }

    void OnTriggerStay(Collider other)
    {
        if (other == playerCollider)
        {
            if (Input.GetKey(KeyCode.R))
            {
                foreach (Light light in lights)
                {
                    light.intensity += sumValue;

                }
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                foreach (Light light in lights)
                {
                    light.intensity -= sumValue;
                }

            }
        }

    }
}
