using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class GoHereThere : MonoBehaviour
{


    public ParticleSystem Particles;
    public float rainThreshold = 5f;
    public Transform GoHereWhenItRains;
    public Transform GoThereWhenItDoesntRain;




    // Update is called once per frame
    void FixedUpdate()
    {
        Animator animator = GetComponent<Animator>(); 
        NavMeshAgent navMeshAgent = GetComponent<NavMeshAgent>();
        float v = Vector3.Distance(navMeshAgent.destination, transform.position); 
        
        if (Particles.particleCount >= rainThreshold)
        {
            navMeshAgent.SetDestination(GoHereWhenItRains.position);
        }
        else
        {
            navMeshAgent.SetDestination(GoThereWhenItDoesntRain.position);
        }
        animator.SetFloat("Walk", v);

    }
}
