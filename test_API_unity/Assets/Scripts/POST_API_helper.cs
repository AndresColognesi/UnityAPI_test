using UnityEngine;
using System.Net; //for http web responses
using System.IO; //for stream reader
using System.Text; //for encoding

public static class POST_API_helper
{
    // POST:
    public static string PostNewRequest()
    {
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.funtranslations.com/translate/yoda.json");
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            string json = "{\"text\": \"Master Obiwan has lost a planet.\"}";

            streamWriter.Write(json);
        }

        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            return streamReader.ReadToEnd();
        }
    }
}
