using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
//
using UnityEngine.Networking;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

public class APICalls : MonoBehaviour
{

    public TMP_Text textbox;
    public TMP_InputField input;
    public User user1;

    /*
    [DllImport("__Internal")]
    private static extern string jsAPICall(string x);

    [DllImport("__Internal")]
    private static extern void Hello();
    */



    public void testCall(){
        StartCoroutine(JiraCall.GetFromProxy(returnValue => 
        {
            user1 = JsonUtility.FromJson<User>(returnValue);
            //textbox.text = returnValue;
            textbox.text = user1.emailAddress;
        }
        ));
    }

}
