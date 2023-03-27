using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnappel : MonoBehaviour
{

    public GameObject appel;
    public Transform SpawnPoint;
    
    // Update is called once per frame
    public void SpawnAppel()
    { 
            Instantiate(appel, SpawnPoint.position, Quaternion.identity);
    }
}
