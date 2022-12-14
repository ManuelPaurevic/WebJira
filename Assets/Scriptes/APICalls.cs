using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//
using UnityEngine.Networking;
using System.IO;
using System.Text;


public class APICalls : MonoBehaviour
{

    public TMP_Text textbox;
    public TMP_InputField input;
    public User user1;

    public void testCall(){
        StartCoroutine(JiraCall.EnuJira(input.text ,returnValue => 
        {
            user1 = JsonUtility.FromJson<User>(returnValue);
            //textbox.text = returnValue;
            textbox.text = user1.emailAddress;
        }
        ));

    }

}
