using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadButton : MonoBehaviour
{
    //The input field 
    public GameObject inputFieldGameObject;

    // the inputfield button 
    public InputFieldButton inputFieldButton;
    void Awake()
    {
        // Get a reference to the button component attached to this game object
        Button bttn = this.GetComponent<Button>();
        bttn.onClick.AddListener(click);
    }

    // This function will be called when the button is clicked

    private void click()
    {
        //sets the input field to active and sets the button to load mode 
        inputFieldGameObject.SetActive(true);
        inputFieldButton.setting = true;

        inputFieldButton.IsSavingOrLoading = true;    
    }
}
