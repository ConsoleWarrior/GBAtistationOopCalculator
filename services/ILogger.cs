﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBAtistationOopCalculator.services
{
	internal interface ILogger
	{
		public void UpdateLog(string str);
		public void PrintLog();
	}
}
