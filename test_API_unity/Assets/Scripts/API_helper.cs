using UnityEngine;
using System.Net; //for http web responses
using System.IO; //for stream reader

public static class API_helper
{
    // GET:
    public static Request_Object GetNewRequest()
    {
        // Create http request:
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.chucknorris.io/jokes/random");
        // Make the request:
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        // Create stream reader for our response:
        StreamReader reader = new StreamReader(response.GetResponseStream());
        // Get json response as string:
        string json = reader.ReadToEnd();
        // Return converted string to Request_Object using json handlers:
        return JsonUtility.FromJson<Request_Object>(json);
    }
}
