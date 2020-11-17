using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class DragObject : MonoBehaviour

{

    private Vector3 mOffset;

    private float mZCoord;
    

    void OnMouseDown()

    {
        DestinationObject.SetItem(this.gameObject);

        mZCoord = Camera.main.WorldToScreenPoint(

            gameObject.transform.position).z;


        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }

    void OnMouseUp() {
        if (DestinationObject.GetIsAdding() == true) {
            if (this.gameObject.name == "WetClothes") {
                HandleWetClothes();
            } else if (this.gameObject.name == "Clothes") {
                this.gameObject.SetActive(false);
                Tasks.ShowNextTask();
                return;
            } else {
                Decisions.AddChoice(DestinationObject.GetDraggedItem().name);
            }
            this.gameObject.SetActive(false);
            Tasks.ShowNextTask();
        }

        Tasks.SetIsAnimationFinished(false);


    }

    void HandleWetClothes() {
        string destination = DestinationObject.GetWetClothesDestination();
        if (destination == "Dryer") {
            Decisions.AddChoice("Dryer");
        } else if (destination == "Clothesline") {
            Decisions.AddChoice("Clothesline");
        }
    }


    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;


        // z coordinate of game object on screen

        mousePoint.z = mZCoord;


        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }


    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint() + mOffset;

    }

}
