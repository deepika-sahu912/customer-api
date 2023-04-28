using System;
using Application.Contracts;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Application.Customer.Command
{
	public class DeleteCustomerHandler : ControllerBase, IRequestHandler<DeleteCustomerReqDto, IActionResult>
	{
        private readonly IBaseRepository<Customers> _baseRepository;
        private readonly ILogger _logger;

        public DeleteCustomerHandler(IBaseRepository<Customers> baseRepository, ILogger logger)
		{
            _baseRepository = baseRepository;
            _logger = logger;

        }

        public async Task<IActionResult> Handle(DeleteCustomerReqDto request, CancellationToken cancellationToken)
        {
            _logger.Information("Process to find Customer has started at {0}", DateTime.Now);
            var entity = _baseRepository.FindAsyncById(request.id);
            var result = string.Empty;

            if (entity != null)
            {
                _logger.Information("Process to Delete Customer has started at {0} for Customer Id {1}", DateTime.Now, request.id);
                result = await _baseRepository.DeleteAsync(entity.Result);
            }
            else
            {
                _logger.Information("No Customer is found to delete at {0}", DateTime.Now);

            }
            return Ok(result);

        }
    }
}

