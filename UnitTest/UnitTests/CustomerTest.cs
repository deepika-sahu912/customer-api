using System;
using Xunit;
using Application.Customer.Command;
using Moq;
using Api.Controllers;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Application.Customer.Command.UpdateCustomer;
using Application.Customer.Query;


    public class CustomerTest : ControllerBase
    {
        ///private readonly Fixture _fixture;
        private readonly CustomerController testController;
        private readonly Mock<IMediator> _mediator;


        public CustomerTest()
        {
            _mediator = new Mock<IMediator>();
            testController = new CustomerController(_mediator.Object);

        }

        [Fact]
        public async void CreateCustomerTest()
        {
            //Arrange
            _mediator.Setup(x => x.Send(It.IsAny<CreateCustomerReqDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(Ok);
            CreateCustomerReqDto inputReq = new CreateCustomerReqDto();
            // Act
            var result = await testController.CreateCustomer(inputReq);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void UpdateCustomerTest()
        {
            //Arrange
            _mediator.Setup(x => x.Send(It.IsAny<UpdateCustomerReqDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(Ok);
            UpdateCustomerReqDto inputReq = new UpdateCustomerReqDto();
            // Act
            var result = await testController.UpdateCustomer(inputReq);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void GetCustomerTest()
        {
            //Arrange
            _mediator.Setup(x => x.Send(It.IsAny<GetCustomerReqDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(Ok);
            GetCustomerReqDto inputReq = new GetCustomerReqDto();
            // Act
            var result = await testController.GetCustomer();

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void DeleteCustomerTest()
        {
            //Arrange
            _mediator.Setup(x => x.Send(It.IsAny<DeleteCustomerReqDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(Ok);
            DeleteCustomerReqDto inputReq = new DeleteCustomerReqDto();
            // Act
            var result = await testController.DeleteCustomer(inputReq);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }


