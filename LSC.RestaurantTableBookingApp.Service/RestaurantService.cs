using LSC.RestaurantTableBookingApp.Core.ViewModels;
using LSC.RestaurantTableBookingApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.RestaurantTableBookingApp.Service
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRespository _restaurantRespository;
        public RestaurantService(IRestaurantRespository restaurantRespository)
        {
            this._restaurantRespository = restaurantRespository;
        }
        public async Task<List<RestaurantModel>> GetAllRestaurantsAsync()
        {
            return await _restaurantRespository.GetAllRestaurantAsync();
        }

        public async Task<IEnumerable<RestaurantBranchModel>> GetRestaurantBranchsByRestaurantIdAsync(int restaurantId)
        {
            return await _restaurantRespository.GetRestaurantBranchsByRestaurantIdAsync(restaurantId);
        }
        public async Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId, DateTime date)
        {
            return await _restaurantRespository.GetDiningTablesByBranchAsync(branchId, date);
        }
        public async Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId)
        {
            return await _restaurantRespository.GetDiningTablesByBranchAsync(branchId);
        }



    }
}
