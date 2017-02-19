using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2 : MonoBehaviour {
    public InputField passwordInput;
    public Text hint;
    public Text level;
    string CORRECT_ANSWER = "solomon";
    string INCORRECT_ANSWER = "ACCESS DENIED";
    string LEVEL_MESSAGE = "LEVEL";
    string LEVEL_INFOR = "2";

    int interval = 2;
    float nextTime = 0;

    public void OnSubmitButtonClicked()
    {
        if (passwordInput.text.Equals(CORRECT_ANSWER))
        {
            TKSceneManager.ChangeScene("Level3");
        }
       else
        {
            hint.text = INCORRECT_ANSWER;
            hint.color = Color.red;
            passwordInput.text = "";
        }
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad >= nextTime)
        {
            if (level.text.Equals(LEVEL_MESSAGE))
                level.text = LEVEL_INFOR;
            else
                level.text = LEVEL_MESSAGE;
            nextTime += interval;
        }
    }
}
