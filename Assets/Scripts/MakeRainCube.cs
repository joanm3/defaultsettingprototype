using UnityEngine;
using System.Collections;

public class MakeRainCube : MonoBehaviour {

    public int sumValue = 1;
    public int min =0;
    public int max = 10;
    ParticleSystem particles; 
    public CapsuleCollider playerCollider;

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
            if (Input.GetKey(KeyCode.R))
            {
                particles.emissionRate += sumValue; 
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                particles.emissionRate -= sumValue;

            }
        }

    }
}
