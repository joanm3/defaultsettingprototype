using UnityEngine;
using System.Collections;


public class AddSunMunVelocity : MonoBehaviour
{

    public float standardSpeed = 0.35f;
    public float fastSpeed = 100f;
    public int hourSum = 1;
    public DayNightController dayNight;
    public float distanceToActivate = 5f; 
    public Clock clock;
    public Transform player;
    public float distance; 


    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance > distanceToActivate)
            return; 


        if (dayNight == null)
            return;

        if (Input.GetKey(KeyCode.R))
        {
            dayNight.daySpeedMultiplier = fastSpeed;
            if (clock)
            {
                clock.hour += hourSum;
            }
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            dayNight.daySpeedMultiplier = -fastSpeed;
            if (clock)
            {
                clock.hour -= hourSum;
            }
        }
        else
        {
            dayNight.daySpeedMultiplier = standardSpeed;
        }
    }



}
