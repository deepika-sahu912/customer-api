using System;
using Application.Contracts;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Application.Customer.Command.UpdateCustomer
{
        public class UpdateCustomerHandler : ControllerBase, IRequestHandler<UpdateCustomerReqDto, IActionResult>
        {
            private readonly IBaseRepository<Customers> _baseRepository;
            private readonly ILogger _logger;

        public UpdateCustomerHandler(IBaseRepository<Customers> baseRepository, ILogger logger)
            {
                _baseRepository = baseRepository;
                _logger = logger;
            }

        public async Task<IActionResult> Handle(UpdateCustomerReqDto request, CancellationToken cancellationToken)
            {
                if (request != null)
                {
                    _logger.Information("Process to Update Customer has started at {0}", DateTime.Now);
                    var result = await _baseRepository.UpdateAsync(request.customer);
                    return Ok(result);
                }
                else
                {
                    _logger.Fatal("Process to Update Customer has failed due to Invalid request {0}", request);
                    return BadRequest("Invalid Request");
                }

            }
        }
    }


