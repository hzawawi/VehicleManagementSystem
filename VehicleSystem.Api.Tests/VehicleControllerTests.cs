﻿using SpecLight;
using VehicleSystem.Api.Controllers;
using VehicleSystem.Core.Models;
using VehicleSystem.Core.Services;
using Xunit;

namespace VehicleSystem.Api.Tests
{
    public class VehicleControllerTests
    {
        private VehicleController _controller;
        private long _vehicleId;

        [Fact]
        public void CreateVehicleShouldReturnId()
        {
            new Spec("Create a new vehicle")
                .Given(RequestReceived)
                .When(CreateIsCalled)
                .Then(VehicleIsCreated)
                .Execute();
        }

        public void RequestReceived()
        {
            _controller = new VehicleController();
        }

        public void CreateIsCalled()
        {
            _vehicleId = _controller.Create(new VehicleModel
            {
                Make = "TT",
                Longitude = 50,
                Latitude = 30
            });
        }

        public void VehicleIsCreated()
        {
            Assert.True( _vehicleId != 0);
        }
    }
}
