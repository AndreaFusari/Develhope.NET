/*Create a Console Application, the application should prompt the user for a URL. 
 * After the URL is supplied, the application should print out the response headers and content.*/
using System.Net;

Console.WriteLine("Inserisci un URL");

var url = Console.ReadLine() ?? throw new Exception("Null Value") ;


    await Retrieve(url); 


    async Task<string> Retrieve(string url)
    {
        HttpClient client = new();
        var uri = new Uri(url);
        var response = await client.GetAsync(uri);
  
        Console.WriteLine("===========RESPONSE==================");
        Console.WriteLine("Response Status : \n "+ response.StatusCode);
        Console.WriteLine($"Response Headers :\n {response.Headers}");
        Console.WriteLine($"Response Content :\n {await response.Content.ReadAsStringAsync()} ");

        return string.Empty;

    }

