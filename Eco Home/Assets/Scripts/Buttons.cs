using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void ShowStuff() {
        Tasks.ShowNextTask();
        Decisions.AddChoice(this.gameObject.name);
    }
}
