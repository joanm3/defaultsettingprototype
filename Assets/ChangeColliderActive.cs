using UnityEngine;
using System.Collections;

public class ChangeColliderActive : MonoBehaviour {

    public MakeRainCube makeRainCube;
    public BoxCollider boxToDesactivate;
    public int numberOfParticlesThreshold = 10; 

    void Update()
    {
            boxToDesactivate.isTrigger = (makeRainCube.numberOfParticles < numberOfParticlesThreshold); 
    }


}
