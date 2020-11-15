using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public Animator DoorPivot;

    void OnTriggerEnter(Collider other) {
        DoorPivot.SetBool("OpenDoor", true);
        Debug.Log("Hello");

    }

    void OnTriggerExit(Collider other) {
        Debug.Log("Hello");
        DoorPivot.SetBool("OpenDoor", false);
        if(!DestinationObject.GetDraggedItem().activeSelf) {
            DoorPivot.SetBool("OpenDoor", false);
        }

    }
}
