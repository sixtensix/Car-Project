﻿using Car_Project.Domain.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project.Domain.Models.Vehicle
{
	public interface IVehicle
	{
		string RegistrationNumber { get; }
		string Model { get; }
		string Brand { get; }
		float Weight { get; }
		DateTime FirstTimeInTraffic { get; }
		IVehicleService BookedService { get; }
		List<IVehicleService> ServiceHistory { get; }
		float YearlyCost { get; }
	}
}
