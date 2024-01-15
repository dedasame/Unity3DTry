using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFall : MonoBehaviour
{
    //Waypointlere göre nesneleri haraket ettirmek için bir script

    [SerializeField] GameObject[] waypoints; //birden çok nesne koyulabilir
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {
        //hangi waypointte oldugunu tutmasi için
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position)< .1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position,speed*Time.deltaTime);

    }
}
