
using UnityEngine.Networking;
using System.IO;
using System.Text;
using UnityEngine;
using System.Collections;

public static class JiraCall
{
    public static IEnumerator EnuJira(string token, System.Action<string> callback = null){
        string email = "manuel.paurevic@oasisdigital.com";
        string authCache = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(email + ":" + token));

        UnityWebRequest request = UnityWebRequest.Get("https://oasisintern.atlassian.net/rest/api/latest/myself");
        request.SetRequestHeader("Authorization", "Basic " + authCache);
        request.SetRequestHeader("Access-Control-Allow-Origin", "*");
        
        yield return request.SendWebRequest();

        if(request.result == UnityWebRequest.Result.ProtocolError){
            Debug.Log("Error while Receiving: " + request.error);
            string result = request.downloadHandler.text;
            callback.Invoke(result);
            //yield return request.error;
            //callback.Invoke(request.error);
        }else{
            string result = request.downloadHandler.text;
            callback.Invoke(result);
        }
    }


    public static IEnumerator EnuJiraB(string token, System.Action<string> callback = null){
        string email = "manuel.paurevic@oasisdigital.com";
        string authCache = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(email + ":" + token));

        UnityWebRequest request = UnityWebRequest.Get("https://oasisintern.atlassian.net/rest/api/latest/myself");
        request.SetRequestHeader("Authorization", "Basic " + authCache);
        request.SetRequestHeader("Access-Control-Allow-Origin", "https://manuelpaurevic.github.io/WebJira/");
        
        yield return request.SendWebRequest();

        if(request.result == UnityWebRequest.Result.ProtocolError){
            Debug.Log("Error while Receiving: " + request.error);
            string result = request.downloadHandler.text;
            callback.Invoke(result);
            //yield return request.error;
            //callback.Invoke(request.error);
        }else{
            string result = request.downloadHandler.text;
            callback.Invoke(result);
        }
    }

    public static IEnumerator EnuJiraC(string token, System.Action<string> callback = null){
        string email = "manuel.paurevic@oasisdigital.com";
        string authCache = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(email + ":" + token));

        UnityWebRequest request = UnityWebRequest.Get("https://oasisintern.atlassian.net/rest/api/latest/myself");
        request.SetRequestHeader("Authorization", "Basic " + authCache);
        request.SetRequestHeader("Access-Control-Allow-Origin", "https://oasisintern.atlassian.net/rest/api/latest/myself");
        
        yield return request.SendWebRequest();

        if(request.result == UnityWebRequest.Result.ProtocolError){
            Debug.Log("Error while Receiving: " + request.error);
            string result = request.downloadHandler.text;
            callback.Invoke(result);
            //yield return request.error;
            //callback.Invoke(request.error);
        }else{
            string result = request.downloadHandler.text;
            callback.Invoke(result);
        }
    }

}
