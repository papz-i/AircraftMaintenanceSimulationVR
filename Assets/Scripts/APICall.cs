using Newtonsoft.Json;
using TMPro;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;

public class GetMethod : MonoBehaviour
{
    public TextMeshProUGUI Text;
    
    public class Fact
    {
        public string fact { get; set; }
        public int length { get; set; }
    }

    private void Start()
    {
        StartCoroutine(GetRequest("https://catfact.ninja/fact"));
    }

    IEnumerator GetRequest(String uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(String.Format("Something went wrong: {0}", webRequest.error));
                    break;
                case UnityWebRequest.Result.Success:
                    
                    Fact fact = JsonConvert.DeserializeObject<Fact>(webRequest.downloadHandler.text);
                    Debug.Log("Scene Key has been fetched");
                    Text.text = fact.fact;
                    break;
            }
        }
    }
}