using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.ExceptionFiltering
{
	class Sample
	{
		//With 'when' we can put a filter on our catch clauses: catch a certain type of exception, 
		//e.g.IOException, but only if a certain condition is true. 
		//Otherwise continue with the next catch-clause if any.
		public void RunSample()
		{
			try
			{
				throw new IOException("missing");
			}
			catch (IOException ioe) when (ioe.Message == "missing")
			{
				Console.WriteLine("The file is missing");
			}
			catch (IOException ioe) when (ioe.Message == "cannot open")
			{
				Console.WriteLine("The file is read-only");
			}
			catch (IOException ioe)
			{
				Console.WriteLine("Some other IO exception: {0}", ioe.Message);
			}
		}
	}
}
