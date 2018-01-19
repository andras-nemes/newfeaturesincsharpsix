using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.NullChecking.Before
{
	public class SampleCode
	{
		public void RunSample()
		{
			//getPersonResponse could come from any service or repository
			GetPersonResponse getPersonResponse = new GetPersonResponse(null); 
			//careless code, can throw null reference exception at getPersonResponse, Person, Workplace, Address, Street
			Console.WriteLine(getPersonResponse.Person.Workplace.Address.Street);
			//code with full null checking
			if (getPersonResponse != null && getPersonResponse.Person != null
				&& getPersonResponse.Person.Workplace != null && getPersonResponse.Person.Workplace.Address != null
				&& getPersonResponse.Person.Workplace.Address.Street != null)
			{
				Console.WriteLine(getPersonResponse.Person.Workplace.Address.Street);
			}
			else
			{
				Console.WriteLine("No work address available");
			}
		}
	}
}
