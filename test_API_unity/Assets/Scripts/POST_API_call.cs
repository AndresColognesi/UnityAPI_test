using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class POST_API_call : MonoBehaviour
{
    // Class attributes:
    public Text my_text;

    // Methods:
    public void ChangeText()
    {
        string new_request = POST_API_helper.PostNewRequest();
        Debug.Log("made new request");
        my_text.text = new_request;
    }
}
