using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class API_call : MonoBehaviour
{
    // Class attributes:
    public Text my_text;

    // Methods:
    public void ChangeText()
    {
        Request_Object new_request = API_helper.GetNewRequest();
        Debug.Log("made new request");
        my_text.text = new_request.value;
    }
}
