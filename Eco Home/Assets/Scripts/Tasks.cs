using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tasks : MonoBehaviour
{
    public GameObject clothes, firstDetergent, secondDetergent, thirdDetergent, popUpPanel;
    public Text popUpText;
    public Image detergentTask, washTask, dryTask;

    public Animator fadeInAnim;
    public static bool isAnimationFinished = false;

    void Update() {
        if (!isAnimationFinished) {
            if (!firstDetergent || !secondDetergent || !thirdDetergent) {
                detergentTask.GetComponent<Image>().color = Color.green;
                popUpPanel.SetActive(true);
                HandlePanel("You added detergent");
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
}
