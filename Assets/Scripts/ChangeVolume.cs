using UnityEngine;
using System.Collections;

public class ChangeVolume : MonoBehaviour {

    public float sumValue = 0.1f;
    public float min = 1f;
    public float max = 1f;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            audioSource.volume +=  sumValue;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            audioSource.volume -=  sumValue;

        }
        //audioSource.volume = Mathf.Clamp(audioSource.volume, min, max);
        Debug.Log(audioSource.volume); 
    }
}
