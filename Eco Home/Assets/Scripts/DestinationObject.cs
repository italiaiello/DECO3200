using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationObject : MonoBehaviour
{   
    private static GameObject draggedItem;
    private static bool isAdding = false;
    private static string wetClothesDestination;
    public GameObject currentObject;
    public Renderer rend;

    
    void Update() {
        if (draggedItem && !draggedItem.activeSelf) {
            rend.material.color = Color.grey;
            isAdding = false;
        }
    }

    void OnTriggerEnter(Collider other) {
         if (currentObject.name == "WashingMachine" && other.tag == "Detergent") {
            SetObjectColor(Color.red, true);
        } else if ((currentObject.name == "Dryer" || currentObject.name == "Clothesline") && other.tag == "Clothes") {
            SetObjectColor(Color.red, true);
            SetWetClothesDestination(currentObject.name);
        }
       
    }
    
    void OnTriggerExit(Collider other) {
        SetObjectColor(Color.grey, false);
    }

    void SetObjectColor(Color color, bool isGoingToAdd) {
        rend.material.color = color;
        isAdding = isGoingToAdd;
    }

    void SetWetClothesDestination(string name) {
        wetClothesDestination = name;
    }

    public static bool GetIsAdding() {
        return isAdding;
    }

    public static GameObject GetDraggedItem() {
        return draggedItem;
    }

    public static GameObject GetCurrentObject() {
        DestinationObject destination = new DestinationObject();
        return destination.currentObject;
    }

    public static string GetWetClothesDestination() {
        return wetClothesDestination;
    }

    public static void SetItem(GameObject currObject) {
        draggedItem = currObject;
    }
    
}
