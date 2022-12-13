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

    public void testCall(){
        StartCoroutine(EnuJira(input.text ,returnValue => 
        {
            textbox.text = returnValue;
        }
        ));

        
       //textbox.text = StartCoroutine(EnuJira());
    }


    IEnumerator EnuJira(string token, System.Action<string> callback = null){
        string email = "manuel.paurevic@oasisdigital.com";
        string authCache = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(email + ":" + token));

        UnityWebRequest request = UnityWebRequest.Get("https://oasisintern.atlassian.net/rest/api/latest/myself");
        request.SetRequestHeader("Authorization", "Basic " + authCache);

        yield return request.SendWebRequest();

        if(request.isNetworkError || request.isHttpError){
            Debug.Log("Error while Receiving: " + request.error);
            yield return request.error;
            callback.Invoke(request.error);
        }else{
            string result = request.downloadHandler.text;
            callback.Invoke(result);
        }
    }





}
