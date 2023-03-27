using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;

    private spawnappel AppelSpawnen;
    private ObjectGrabbable objectGrabbable;

  private void Update() {
    if (Input.GetKeyDown(KeyCode.E))    {
        if (objectGrabbable == null){
        float pickupDistance = 5f;
        if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance, pickUpLayerMask));{
            if (raycastHit.transform.TryGetComponent(out objectGrabbable)){
                objectGrabbable.Grab(objectGrabPointTransform);
            }       
        }
    } else {
        objectGrabbable.Drop();
        objectGrabbable = null;

    }
  }
   if (Input.GetKeyDown(KeyCode.Q))    {
        float pickupDistance = 5f;
        if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance, pickUpLayerMask));{
            if (raycastHit.transform.TryGetComponent(out AppelSpawnen)){
                Debug.Log("appeltje voor jou");
                AppelSpawnen.SpawnAppel();
            }       
        }
    } 
  }
}

