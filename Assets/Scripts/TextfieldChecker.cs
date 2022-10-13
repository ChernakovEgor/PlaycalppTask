using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextfieldChecker : MonoBehaviour
{
    public GameObject distanceTextField;
    public GameObject velocityTextField;
    public GameObject spawnrateTextField;
    public GameObject errorTextBox;

    public GameObject spawnManager;

    public void ReadTextFields() {
        
        var distanceString = distanceTextField.GetComponent<TMP_InputField>().text;
        float distance;
        Debug.Log($"Distance string is {distanceTextField.GetComponent<TMP_InputField>().text}");
        errorTextBox.GetComponent<TMP_Text>().text = distanceTextField.GetComponent<TMP_InputField>().text;
        if (!float.TryParse(distanceString, out distance) || distance < 0) {
            ShowErrorMessege();
            return;
        }
        string velocityString = velocityTextField.GetComponent<TMP_InputField>().text;
        Debug.Log($"Velocity is {velocityString}");
        string spawnrateString = spawnrateTextField.GetComponent<TMP_InputField>().text;
        
        //var spawner = spawnManager.GetComponent<CubeSpawner>();
        
    }

    public void ShowErrorMessege() {
        Debug.Log("Enter correct value");
    }
}
