namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository{

        private readonly IDistributedCache _redisCache;
        public BasketRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

    }

}