using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    private float dist;
    public Transform player;
    private bool Appel;
    

    public float howclose;

    // Start is called before the first frame update
    void Start()
    {
        //Appel = false;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);
        if (dist <= howclose)
        {
            Appel = true;
            
            if (Appel == true){ 
        enemy.SetDestination(player.position);
            }
        }

    }

    void OnCollisionStay (Collision other)
    {
        if (other.gameObject.CompareTag("pickupobj"))
        {
            Appel = false;
            enemy.speed = 0;
            Debug.Log("tja");
        }
    }

    void OnCollisionExit (Collision other)
    {
        if (other.gameObject.CompareTag("pickupobj"))
        {
            Appel = true;
            enemy.speed = 2;
            Debug.Log("yay");
        }
    }


}

