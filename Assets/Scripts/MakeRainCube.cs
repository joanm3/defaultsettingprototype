using UnityEngine;
using System.Collections;

public class MakeRainCube : MonoBehaviour
{

    public int sumValue = 1;
    public int min = 0;
    public int max = 10;
    public ParticleSystem[] particles;
    public CapsuleCollider playerCollider;
    public int numberOfParticles; 

    void Start()
    {
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<CapsuleCollider>();
        //particles = GetComponentInChildren<ParticleSystem>(); 
    }

    void FixedUpdate()
    {
        sumValue = Mathf.Clamp(sumValue, min, max);
        numberOfParticles = particles[0].particleCount; 
    }

    void OnTriggerStay(Collider other)
    {
        if (other == playerCollider)
        {
            if (Input.GetKey(KeyCode.R))
            {
                foreach (ParticleSystem item in particles)
                {
                    item.emissionRate += sumValue;

                }
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                foreach (ParticleSystem item in particles)
                {
                    item.emissionRate -= sumValue;
                }
            }
        }

    }
}
