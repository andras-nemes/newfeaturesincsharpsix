using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///The Address object has a street name and a street number
///The Workplace object has an Address
///The Person object has a Workplace
///The Person object is retrieved from some service
/// </summary>
namespace NewFeatures.NullChecking
{
	public class Address
	{
		public string Street { get; }
		public int Number { get; }

		public Address(string street, int number)
		{
			Street = street;
			Number = number;
		}
	}

	public class Workplace
	{
		public Address Address { get; }

		public Workplace(Address address)
		{
			Address = address;
		}
	}

	public class Person
	{
		public Workplace Workplace { get; }

		public Person(Workplace workplace)
		{
			Workplace = workplace;
		}
	}

	public class GetPersonResponse
	{
		public Person Person { get; }

		public GetPersonResponse(Person person)
		{
			Person = person;
		}
	}
}
