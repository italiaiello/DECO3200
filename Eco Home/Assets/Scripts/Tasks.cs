using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tasks : MonoBehaviour
{
    public GameObject clothes, detergents, firstDetergent, secondDetergent, thirdDetergent, wetClothes, popUpPanel;
    public Canvas hotColdWash, longShortWash;
    public Text popUpText;
    public Image detergentTask, washTask, dryTask;

    public Animator fadeInAnim;
    public static bool isAnimationFinished = false;

    private static int taskNumber = 1;

    void Update() {
        if (!isAnimationFinished) {
            if (!firstDetergent.activeSelf || !secondDetergent.activeSelf || !thirdDetergent.activeSelf) {
                detergentTask.GetComponent<Image>().color = Color.green;
                popUpPanel.SetActive(true);
                HandlePanel("You added detergent");
            }
        }

        if (taskNumber > 0 && taskNumber < 5) {

            switch(taskNumber) {
                case 1:
                    ShowHideTasks(true, false, false, false);
                    break;
                case 2:
                    ShowHideTasks(false, true, false, false);
                    break;
                case 3:
                    ShowHideTasks(false, false, true, false);
                    break;
                case 4:
                    ShowHideTasks(false, false, false, true);
                    break;
                default:
                    Debug.Log("Finished Game");
                    break;
            }
        }
    }

    void HandlePanel(string newText) {
        popUpText.text = newText;
        if (!isAnimationFinished && (fadeInAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !fadeInAnim.IsInTransition(0))) {
            popUpPanel.SetActive(false);
            isAnimationFinished = true;
        }
    }

    public static void SetIsAnimationFinished(bool isItFinished) {
        isAnimationFinished = isItFinished;
    }

    public static void ShowNextTask() {
        taskNumber += 1;
        
    }

    void ShowHideTasks(bool showAddDetergent, bool showHotColdWash, bool showWashLength, bool showWetClothes) {
        detergents.SetActive(showAddDetergent);
        hotColdWash.enabled = showHotColdWash;
        longShortWash.enabled = showWashLength;
        wetClothes.SetActive(showWetClothes);
    }
}
