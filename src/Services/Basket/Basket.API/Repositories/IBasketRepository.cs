using Basket.API.Entities;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public class IBasketRepository{

        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);

    }

}