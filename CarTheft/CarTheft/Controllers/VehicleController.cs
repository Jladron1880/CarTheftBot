using CarTheft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarTheft.Controllers
{
    public class VehicleController : ApiController
    {
        public string Get()
        {
            return "All";
        }
        [HttpGet]
        public VehicleModel[] Get(string licenseplate)
        {
            VehicleModel vehicle1 = new VehicleModel();
            vehicle1.uuid = "001";
            vehicle1.LicensePlate = "MKO879";
            vehicle1.Make = "CHEVROLET";
            vehicle1.Model = "SONIC";
            vehicle1.Year = "2016";
            vehicle1.InsuranceCarrier = "STATEFARM";
            vehicle1.LossDate = "8 August 2017 12:00";
            vehicle1.LossLocation = "19510 NORTHRIDDGE DR, NORTHVILLE, MI 48152";
            vehicle1.RecoveryDate = "";
            vehicle1.RecoveryLocation = "";
            vehicle1.RecoveryType = "";
            vehicle1.VehicleOwner = "Miguel Peres";
            vehicle1.VehicleVin = "012345ABC";

            VehicleModel vehicle2 = new VehicleModel();
            vehicle2.uuid = "002";
            vehicle2.LicensePlate = "PRD345";
            vehicle2.Make = "FORD";
            vehicle2.Model = "FUSION";
            vehicle2.Year = "2017";
            vehicle2.InsuranceCarrier = "GNP";
            vehicle2.LossDate = "8 August 2017 12:00";
            vehicle2.LossLocation = "19510 NORTHRIDDGE DR, NORTHVILLE, MI 48152";
            vehicle2.RecoveryDate = "";
            vehicle2.RecoveryLocation = "";
            vehicle2.RecoveryType = "";
            vehicle2.VehicleOwner = "Juan Hernandez";
            vehicle2.VehicleVin = "67890DEF";

            VehicleModel[] vehicleArray = { vehicle1, vehicle2 };
            return vehicleArray;
        }

        [HttpGet]
        public bool Get(string uuid, string LicensePlate)
        {
            return true;
        }

        public IHttpActionResult Post(VehicleModel vehicle)
        {
            return this.Ok<string>("SQL INSERT into Vehicle(" + vehicle.uuid + ", " + vehicle.LicensePlate + ")");
        }
    }
}
