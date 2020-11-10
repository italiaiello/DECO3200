using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationObject : MonoBehaviour
{   
    private static GameObject draggedItem;
    private static bool isAdding = false;
    public GameObject currentObject;
    public Renderer rend;

    
    void Update() {
        if (!draggedItem) {
            rend.material.color = Color.grey;
            isAdding = false;
        }
    }

    void OnTriggerEnter(Collider other) {
         if (currentObject.name == "WashingMachine" && other.tag == "Detergent") {
            SetObjectColor(Color.red, true);
        } else if (currentObject.name == "Dryer" && other.tag == "Clothes") {
            SetObjectColor(Color.red, true);
        }
       
    }
    
    void OnTriggerExit(Collider other) {
        SetObjectColor(Color.grey, false);
    }

    void SetObjectColor(Color color, bool isGoingToAdd) {
        rend.material.color = color;
        isAdding = isGoingToAdd;
    }

    public static bool GetIsAdding() {
        return isAdding;
    }

    public static void SetItem(GameObject currentObject) {
        draggedItem = currentObject;
    }
    
}
