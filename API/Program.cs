using System;
using RestSharp;
using System.Text.Json;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest pokeRequest = new RestRequest("pokemon/snorlax");
IRestResponse pokeResponse = pokeClient.Get(pokeRequest);

Console.WriteLine(pokeResponse.StatusCode);
Console.WriteLine(pokeResponse.Content);

Pokemon p = JsonSerializer.Deserialize<Pokemon>(pokeResponse.Content);

Console.WriteLine(p.name);

//starwars
//RestClient swClient = new RestClient("https://swapi.dev/api/");
//RestRequest swRequest = new RestRequest("people/1");
//IRestResponse swResponse = swClient.Get(swRequest);

//Console.WriteLine(swResponse.Content);

//Person p = JsonSerializer.Deserialize<Person>(swResponse.Content);

//Console.WriteLine(p.name);

Console.ReadLine();
