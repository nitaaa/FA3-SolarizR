﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solarizr
{
    class Picture
    {
		public Picture()
		{

		}
		public Picture(string path, Appointment appointment)
		{
			
			Path = path;
			Appointment = appointment;
		}

		public int ID { get; set; }
		public string Path { get; set; }

		public Appointment Appointment { get; set; }
	}
}
