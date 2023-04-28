using System;
using Application.Contracts;
using Application.Customer.Command;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Application.Customer.Query
{
	  public class GetCustomerHandler : ControllerBase, IRequestHandler<GetCustomerReqDto, IActionResult>
        {
        private readonly IBaseRepository<Customers> _baseRepository;
        private readonly ILogger _logger;

        public GetCustomerHandler(IBaseRepository<Customers> baseRepository, ILogger logger)
            {
                _baseRepository = baseRepository;
                _logger = logger;
            }
        public async Task<IActionResult> Handle(GetCustomerReqDto request, CancellationToken cancellationToken)
            {
                if (request != null)
                {
                    _logger.Information("Process to Get Customer has started at {0}", DateTime.Now);
                    var result = await _baseRepository.GetAsync();

                    if (result.Count == 0)
                    {
                       _logger.Information("No Customer record is found at {0}", DateTime.Now);
                        return Ok("No Customer record is found");
                    }
                    else
                    {
                        return Ok(result);
                    }
                }
                else
                {

                    _logger.Fatal("Process to Update Customer has failed due to Invalid request {0}", request);
                     return BadRequest("Invalid Request");
                }

            }
        }
    }


