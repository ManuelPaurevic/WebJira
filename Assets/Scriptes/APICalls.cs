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

    //[DllImport("__Internal")]
    //private static extern string jsAPICall(string x);



    public void testCall(){
        
        StartCoroutine(JiraCall.EnuJira(input.text ,returnValue => 
        {
            user1 = JsonUtility.FromJson<User>(returnValue);
            //textbox.text = returnValue;
            textbox.text = user1.emailAddress;
        }
        ));
    
        //string token = input.text;
        //textbox.text = jsAPICall(token);
        
    }

    public void testCallB(){
        
        StartCoroutine(JiraCall.EnuJiraB(input.text ,returnValue => 
        {
            user1 = JsonUtility.FromJson<User>(returnValue);
            //textbox.text = returnValue;
            textbox.text = user1.emailAddress;
        }
        ));
    
        //string token = input.text;
        //textbox.text = jsAPICall(token);
        
    }

    public void testCallC(){
        
        StartCoroutine(JiraCall.EnuJiraC(input.text ,returnValue => 
        {
            user1 = JsonUtility.FromJson<User>(returnValue);
            //textbox.text = returnValue;
            textbox.text = user1.emailAddress;
        }
        ));
    
        //string token = input.text;
        //textbox.text = jsAPICall(token);
        
    }

}
