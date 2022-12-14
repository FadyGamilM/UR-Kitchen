using UrKitchen.Application.Common;
using MediatR;
using UrKitchen.Domain.Entities;
namespace UrKitchen.Application.UseCases.User.Queries.GetAllUsers;

public class GetUsersQuery 
   : IRequest<HandlersResponse<IEnumerable<Domain.Entities.User>>>
{  }