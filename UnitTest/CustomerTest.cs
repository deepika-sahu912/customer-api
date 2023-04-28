using System;
using Xunit;
using Application.Customer.Command;
using AutoFixture;
using Moq;
using Api.Controllers;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace UnitTest
{
	public class CreateCustomerTest : ControllerBase
	{
		///private readonly Fixture _fixture;
		private readonly CustomerController testController;
        //private readonly Mock<ILogger<CustomerController>> _logger;

        private readonly Mock<IMediator> _mediator;


        public CreateCustomerTest()
		{
			_mediator = new Mock<IMediator>();
            testController = new CustomerController(_mediator.Object);

		}

		[Fact]
		public async void CreateCustomer()
		{
			//Arrange
			_mediator.Setup(x => x.Send(It.IsAny<CreateCustomerReqDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(Ok);
			CreateCustomerReqDto inputReq = new CreateCustomerReqDto();
			// Act
			var result = await testController.CreateCustomer(inputReq);

			//Assert
			Assert.IsType<OkResult>(result);
		}
	}
}

