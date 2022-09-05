using OrderManageApp.Models;

namespace OrderManageApp.Services
{
    public interface ISupplierService
    {
       
        Task<IEnumerable<SupplierModel>> GetSuppliers();
        
    }
}
