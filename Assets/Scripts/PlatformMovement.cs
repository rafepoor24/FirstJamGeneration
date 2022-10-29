using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject[]waypoints;
    private int currentWayPointIndex=0;

    public float speed = 2f;
 
    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWayPointIndex].transform.position, transform.position) < .1f)
        {
            currentWayPointIndex++;
            if (currentWayPointIndex >= waypoints.Length)
            {
                currentWayPointIndex = 0;
            }
        }
        transform.position=Vector2.MoveTowards(transform.position,waypoints[currentWayPointIndex].transform.position,speed*Time.deltaTime);    
    }

}
