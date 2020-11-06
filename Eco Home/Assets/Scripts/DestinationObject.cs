using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationObject : MonoBehaviour
{

    private static GameObject item;
    private static bool isAdding = false;
    public Renderer rend;
    void OnMouseOver() {
        rend.material.color = Color.red;
        isAdding = true;
        Debug.Log(isAdding);
    }
    

    void OnMouseExit() {
        rend.material.color = Color.gray;
        isAdding = false;
        Debug.Log(isAdding);
    }

    public static void DestroyItem() {
        if (DestinationObject.isAdding == true) {
            Debug.Log("You added some " + item.name);
            Destroy(item);
        }
    }

    public static void SetItem(GameObject currentObject) {
        item = currentObject;
    }
}
