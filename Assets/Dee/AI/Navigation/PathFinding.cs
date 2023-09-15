using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathFinding : MonoBehaviour
{
    NavMeshAgent agent007;

    //array of different poi's 
    //interger to pick poi

    public Transform[] wayPoint;
    int waypointIndex;
    public Vector3 target;
    public bool bossNav;
    public bool hasDecided;

    // Start is called before the first frame update
    void Start()
    {
        agent007 = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target) < 2)
        {
            chooseWayPoint();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        //choose with randomizer wich waypoint to go to
        target = wayPoint[waypointIndex].transform.position;
        agent007.SetDestination(target); 
    }
    void chooseWayPoint()
    {
        //add descision time. 
        if(bossNav == true)
        {
            waypointIndex = Random.Range(0, wayPoint.Length);
            if (waypointIndex == wayPoint.Length)
            {
                waypointIndex = 0;
            }
        }
        else
        {
            hasDecided = false;
            StartCoroutine(ChooseTime());
            IEnumerator ChooseTime()
            {
                yield return new WaitForSeconds(0.2f);
                hasDecided = true;

                waypointIndex = Random.Range(0, wayPoint.Length);
                if (waypointIndex == wayPoint.Length)
                {
                    waypointIndex = 0;
                }
            }
            //add doubt time with coroutine

        }


    }

}
