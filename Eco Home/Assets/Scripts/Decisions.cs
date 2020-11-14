using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decisions : MonoBehaviour
{
    private static List<string> userChoices = new List<string>();

    // Mapping user choices to feedback - Numbers correspond to which ending is grabbed from Feedback object

    private static Dictionary<string, int> feedback = new Dictionary<string, int>{
        ["BadDetergent, HotWash, LongWash, Dryer, CleanFilter"] = 1,
        ["BadDetergent, HotWash, LongWash, Dryer"] = 2,
        ["BadDetergent, HotWash, LongWash, Clothesline"] = 3,
        ["BadDetergent, HotWash, ShortWash, Dryer, CleanFilter"] = 4,
        ["BadDetergent, HotWash, ShortWash, Dryer"] = 5,
        ["BadDetergent, HotWash, ShortWash, Clothesline"] = 6,
        ["BadDetergent, ColdWash, LongWash, Dryer, CleanFilter"] = 7,
        ["BadDetergent, ColdWash, LongWash, Dryer"] = 8,
        ["BadDetergent, ColdWash, LongWash, Clothesline"] = 9,
        ["BadDetergent, ColdWash, ShortWash, Dryer, CleanFilter"] = 10,
        ["BadDetergent, ColdWash, ShortWash, Dryer"] = 11,
        ["BadDetergent, ColdWash, ShortWash, Clothesline"] = 12,

        ["AvgDetergent, HotWash, LongWash, Dryer, CleanFilter"] = 13,
        ["AvgDetergent, HotWash, LongWash, Dryer"] = 14,
        ["AvgDetergent, HotWash, LongWash, Clothesline"] = 15,
        ["AvgDetergent, HotWash, ShortWash, Dryer, CleanFilter"] = 16,
        ["AvgDetergent, HotWash, ShortWash, Dryer"] = 17,
        ["AvgDetergent, HotWash, ShortWash, Clothesline"] = 18,
        ["AvgDetergent, ColdWash, LongWash, Dryer, CleanFilter"] = 19,
        ["AvgDetergent, ColdWash, LongWash, Dryer"] = 20,
        ["AvgDetergent, ColdWash, LongWash, Clothesline"] = 21,
        ["AvgDetergent, ColdWash, ShortWash, Dryer, CleanFilter"] = 22,
        ["AvgDetergent, ColdWash, ShortWash, Dryer"] = 23,
        ["AvgDetergent, ColdWash, ShortWash, Clothesline"] = 24,

        ["GoodDetergent, HotWash, LongWash, Dryer, CleanFilter"] = 25,
        ["GoodDetergent, HotWash, LongWash, Dryer"] = 26,
        ["GoodDetergent, HotWash, LongWash, Clothesline"] = 27,
        ["GoodDetergent, HotWash, ShortWash, Dryer, CleanFilter"] = 28,
        ["GoodDetergent, HotWash, ShortWash, Dryer"] = 29,
        ["GoodDetergent, HotWash, ShortWash, Clothesline"] = 30,
        ["GoodDetergent, ColdWash, LongWash, Dryer, CleanFilter"] = 31,
        ["GoodDetergent, ColdWash, LongWash, Dryer"] = 32,
        ["GoodDetergent, ColdWash, LongWash, Clothesline"] = 33,
        ["GoodDetergent, ColdWash, ShortWash, Dryer, CleanFilter"] = 34,
        ["GoodDetergent, ColdWash, ShortWash, Dryer"] = 35,
        ["GoodDetergent, ColdWash, ShortWash, Clothesline"] = 36,

    };

    private static Feedback currUserFeedback;

    
    void Start() {
        
        currUserFeedback = ScriptableObject.CreateInstance<Feedback>();
    }

    public static void AddChoice (string choice) {
        userChoices.Add(choice);
    }

    public static string GetFeedback() {
        string[] userChoicesArray = userChoices.ToArray();
        string userChoicesString = string.Join(", ", userChoicesArray);
        Debug.Log(userChoicesString);
        int userFeedbackKey = feedback[userChoicesString];
        // var feedbackValue = feedback[userChoicesString];
        return currUserFeedback.userFeedback[userFeedbackKey];
    }
}
