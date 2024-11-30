using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomScript : MonoBehaviour {
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Text outputText;
    public int randomValue;

    private void GenerRandomValue(){
        randomValue = Random.Range(0,101);
    }

    public void OnButton(){
        int userEnterValue = ReadIntFromInputField(inputField);
        if (userEnterValue == randomValue) {
            outputText.text = "Ты угадал!";
            GenerRandomValue();
        } else if (randomValue > userEnterValue) {
            outputText.text = "Твоё число меньше!";
        } else {
            outputText.text = "Твоё число больше!";
        }
    }

    private int ReadIntFromInputField(TMP_InputField inputField) {
        string str = inputField.text;
        if (str != null && str.Length > 0) {
            if (int.TryParse(str, out int intValue)) {
                return intValue;
            }
        }
        return 0;
    }
}