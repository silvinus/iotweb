﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IotWeb.Server;

namespace WebHost.Desktop
{
	class Program
	{
		static void Main(string[] args)
		{
			EchoServer server = new EchoServer();
			server.Start(8000);
		}
	}
}