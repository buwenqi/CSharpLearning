using System;
using Newtonsoft.Json;

public class Company
{
	public Company(Address address)
	{
		this.Address = address;
	}

	public Address Address { get; set; }
}
