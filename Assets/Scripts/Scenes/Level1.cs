﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : MonoBehaviour {
    public InputField passwordInput;
    public Text hint;
    string CORRECT_ANSWER = "kabul";
    string INCORRECT_ANSWER = "ACCESS DENIED";

    public void OnSubmitButtonClicked()
    {
        if (passwordInput.text.Equals(CORRECT_ANSWER)) {
            TKSceneManager.ChangeScene("Level2");
        } else {
            hint.text = INCORRECT_ANSWER;
            hint.color = Color.red;
            passwordInput.text = "";
        }
    }

}
