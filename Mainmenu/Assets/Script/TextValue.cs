using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextValue : MonoBehaviour

{
    //the text shown for the user
    public Text helloName;
    //the text that the user typed
    public UnityEngine.UI.InputField name;

    // Update is called once per frame
    public void Buttonaction()
    {
        // assigne eame of the string inside the input field
        string UserName = name.text;
        //make text = the input fild
        helloName.text = "Hello" + UserName;
        
    }
}
