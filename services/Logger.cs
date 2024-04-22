using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBAtistationOopCalculator.services
{
	internal class Logger : ILogger
	{
		private StringBuilder builder = new StringBuilder();
		public void UpdateLog(string str)
		{
			if (str != "") builder.AppendLine(str);
		}
		public void PrintLog()
		{
            Console.WriteLine(builder);
        }
	}
}
