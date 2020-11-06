using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tasks : MonoBehaviour
{
    public GameObject clothes, firstDetergent, secondDetergent, thirdDetergent;
    public Image detergentTask, washTask, dryTask;

    void Update() {
        if (!firstDetergent || !secondDetergent || !thirdDetergent) {
            detergentTask.GetComponent<Image>().color = Color.green;
        }
    }
}
