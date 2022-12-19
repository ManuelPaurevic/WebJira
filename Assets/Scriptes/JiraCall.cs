
using UnityEngine.Networking;
using System.IO;
using System.Text;
using UnityEngine;
using System.Collections;


public static class JiraCall
{
    public static IEnumerator EnuJira(System.Action<string> callback = null){
        string email = "manuel.paurevic@oasisdigital.com";
        string token = "bWFudWVsLnBhdXJldmljQG9hc2lzZGlnaXRhbC5jb206eWlNZ1BnSzlQZ3d2Rnp5RUY3c2I0NzM4";
        string authCache = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(email + ":" + token));

        UnityWebRequest request = UnityWebRequest.Get("https://oasisintern.atlassian.net/rest/api/latest/myself");
        request.SetRequestHeader("Authorization", "Basic " + token);
        
        
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

    public static IEnumerator GetFromProxy(System.Action<string> callback = null){
        UnityWebRequest request = UnityWebRequest.Get("http://localhost:5000");
        
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
