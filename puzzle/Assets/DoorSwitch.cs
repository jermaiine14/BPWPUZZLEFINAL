using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    bool isOpened = false;

   
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
              if(!isOpened){
        isOpened = true;
        door.transform.position += new Vector3 (0,4,0);
        }
        }
    }

      void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
             if (isOpened)
        {
            isOpened = false;
            door.transform.position -= new Vector3(0, 4, 0);
        }
        }
    }

}
