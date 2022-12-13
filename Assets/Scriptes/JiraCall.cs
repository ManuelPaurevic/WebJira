
using UnityEngine.Networking;
using System.IO;
using System.Text;
using UnityEngine;
using System.Collections;

public class JiraCall
{
    public IEnumerator EnuJira(string token){
        string email = "manuel.paurevic@oasisdigital.com";
        string authCache = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(email + ":" + token));

        UnityWebRequest request = UnityWebRequest.Get("https://oasisintern.atlassian.net/rest/api/latest/myself");
        request.SetRequestHeader("Authorization", "Basic " + authCache);
        
        yield return request.SendWebRequest();

        if(request.isNetworkError || request.isHttpError){
            Debug.Log("Error while Receiving: " + request.error);
        }else{
            string result = request.downloadHandler.text;
            Debug.Log(result);
        }
    }





}
