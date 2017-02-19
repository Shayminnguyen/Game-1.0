using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3 : MonoBehaviour {
    public InputField passwordInput;
    public Text hint;
    public Text level;
    public Image image1;
    public Image image2;
    string CORRECT_ANSWER = "evilcat";
    string INCORRECT_ANSWER = "ACCESS DENIED";
    string LEVEL_MESSAGE = "LEVEL";
    string LEVEL_INFOR = "3";

    int interval = 2;
    float nextTime = 0;

    public void OnSubmitButtonClicked()
    {
        if (passwordInput.text.Equals(CORRECT_ANSWER))
        {
            TKSceneManager.ChangeScene("StartScene");
        }////************************************************************
        else
        {
            hint.text = INCORRECT_ANSWER;
            hint.color = Color.red;
            passwordInput.text = "";
        }
    }

    public void OnPagesButtonClicked()
    {
        image1.enabled = !image1.enabled;
        image2.enabled = !image2.enabled;
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
