using System.Collections;
using System;
using UnityEngine;
using UnityEngine.Networking;



public static class WebRequests
{
    private class WebRequestsMonoBehaviour :MonoBehaviour{}
    private static WebRequestsMonoBehaviour webRequestsMonoBehaviour;

    private static void Init()
    {
        if(webRequestsMonoBehaviour == null)
        {
            GameObject gameObject = new GameObject("WebRequests");
            webRequestsMonoBehaviour = gameObject.AddComponent<WebRequestsMonoBehaviour>();
        }
    }

    public static void GetTexture(string url, Action<string> onError, Action<Texture2D> onSuccess)
    {
        Init();
        webRequestsMonoBehaviour.StartCoroutine(GetTextureCoroutine(url, onError, onSuccess));
    }

    private static IEnumerator GetTextureCoroutine(string url, Action<string> onError, Action<Texture2D> onSuccess)
    {
        using (UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(url))
        {
            yield return unityWebRequest.SendWebRequest();
            if(unityWebRequest.result == UnityWebRequest.Result.ConnectionError
                || unityWebRequest.result == UnityWebRequest.Result.ProtocolError)

            {
                onError (unityWebRequest.error);
                
            }
            else
            {
                DownloadHandlerTexture downloadHandlerTexture = unityWebRequest.downloadHandler
                    as DownloadHandlerTexture;
                onSuccess(downloadHandlerTexture.texture);
            }
        }
    }

}
