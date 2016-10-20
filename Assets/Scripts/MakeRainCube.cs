using UnityEngine;
using System.Collections;

public class MakeRainCube : MonoBehaviour {

    public int sumValue = 5;
    public int min =0;
    public int max = 10;
    ParticleSystem particles; 
    CapsuleCollider playerCollider;

    void Start()
    {
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<CapsuleCollider>();
        particles = GetComponentInChildren<ParticleSystem>(); 
    }

    void FixedUpdate()
    {
        sumValue = Mathf.Clamp(sumValue, min, max); 
    }

    void OnTriggerStay(Collider other)
    {
        if (other == playerCollider)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                particles.emissionRate += sumValue; 
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                particles.emissionRate -= sumValue;

            }
        }

    }
}
