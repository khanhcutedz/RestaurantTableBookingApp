using LSC.RestaurantTableBookingApp.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.RestaurantTableBookingApp.Data
{
    public interface IRestaurantRespository
    {
        Task<List<RestaurantModel>> GetAllRestaurantAsync();
        Task<IEnumerable<RestaurantBranchModel>> GetRestaurantBranchsByRestaurantIdAsync(int restaurantId);

        Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync (int branchId, DateTime date);
        Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync (int branchId);

    }
}
