using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationObject : MonoBehaviour
{   
    private static GameObject draggedItem;
    private static bool isAdding = false;
    public Renderer rend;

    
    void Update() {
        if (!draggedItem) {
            rend.material.color = Color.grey;
            isAdding = false;
        }
    }

    void OnTriggerEnter(Collider other) {
         if (this.gameObject.name == "WashingMachine" && other.tag == "Detergent") {
            SetObjectColor(Color.red, true);
        } else if (this.gameObject.name == "Dryer" && other.tag == "Clothes") {
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

    public bool GetIsAdding() {
        return isAdding;
    }

    public void SetItem(GameObject currentObject) {
        draggedItem = currentObject;
    }
    
}
