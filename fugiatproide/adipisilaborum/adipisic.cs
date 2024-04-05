using System;
using System.Net;
using System.IO;

class WebRequestExample
{
    static void Main()
    {
        // Create a request for the specified URL.
        WebRequest request = WebRequest.Create("http://www.example.com");
        
        // If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultCredentials;
        
        // Get the response.
        WebResponse response = request.GetResponse();
        
        // Display the status.
        Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        
        // Get the stream containing content returned by the server.
        // The using block ensures the stream is automatically closed.
        using (Stream dataStream = response.GetResponseStream())
        {
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            
            // Display the content.
            Console.WriteLine(responseFromServer);
        }
        
        // Clean up the response.
        response.Close();
    }
}
