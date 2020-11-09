using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationObject : MonoBehaviour
{
    private static GameObject item;
    private static bool isAdding = false;
    public Renderer rend;

    void OnTriggerEnter(Collider other) {

        if ((this.gameObject.name == "WashingMachine" && other.tag == "Detergent") || (this.gameObject.name == "Dryer" && other.tag == "Clothes")) {
            rend.material.color = Color.red;
            isAdding = true;
        }
    }
    

    void OnTriggerExit(Collider other) {
        rend.material.color = Color.grey;
        isAdding = false;
    }

    public static void DestroyItem() {
        if (DestinationObject.isAdding == true) {
            Debug.Log("You added some " + item.name);
            // rend.material.color = Color.grey;
            // DestinationObject.isAdding = false;
            Destroy(item);
        }
    }

    public static void SetItem(GameObject currentObject) {
        item = currentObject;
    }

    
}
