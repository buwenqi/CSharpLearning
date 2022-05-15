using System;
using Newtonsoft.Json;

public class Address
{
	public Address(string country, string city)
	{
		this.Country = country;
		this.City = city;
	}

	public string Country { get; set; }

	public string City { get; set; }
}
