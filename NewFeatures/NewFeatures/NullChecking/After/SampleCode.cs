using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.NullChecking.After
{
	public class SampleCode
	{
		public void RunSample()
		{
			GetPersonResponse getPersonResponse = new GetPersonResponse(null);
			if (getPersonResponse?.Person?.Workplace?.Address?.Street != null)
			{
				Console.WriteLine(getPersonResponse.Person.Workplace.Address.Street);
			}

			//can combine with ??
			Console.WriteLine(getPersonResponse?.Person?.Workplace?.Address?.Street ?? "No work address available");
		}
	}
}
