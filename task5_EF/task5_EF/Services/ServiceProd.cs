using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_EF.DAL.Repository;
using AutoMapper;
using task5_EF.DTO;
using task5_EF.DAL.View;
using task5_EF.DAL.Model;

namespace task5_EF.Services
{
    public class ServiceProd
    {

        private UnitOfWork unitOfWork = new UnitOfWork();  //создаем обьект uow


        public List<CategoryDTO> GetCategory_List()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();
            return mapper.Map<List<Category>, List<CategoryDTO>>(unitOfWork.CategoryRepository.Category_List());
        }

        public List<SupplierDTO> GetSupplier_List()
        {
            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Supplier, SupplierDTO>()).CreateMapper();
            return mapper.Map<List<Supplier>, List<SupplierDTO>>(unitOfWork.SupplierRepository.Supplier_List());
        }

        public List<ViewProductDTO> GetListViewProductByCatID(int categoryID)
        {
            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ViewProduct, ViewProductDTO>()).CreateMapper();
            return mapper.Map<List<ViewProduct>, List<ViewProductDTO>>(unitOfWork.ProductRepository.ListViewProductByCatId(categoryID));
        }

        public List<ViewProductDTO> GetListViewProductByPrice(float price)
        {
            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ViewProduct, ViewProductDTO>()).CreateMapper();
            return mapper.Map<List<ViewProduct>, List<ViewProductDTO>>(unitOfWork.ProductRepository.ListViewProductByPrice(price));
        }

        public List<ViewProductDTO> GetListViewProductByIdSup(int supplierID)
        {

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ViewProduct, ViewProductDTO>()).CreateMapper();
            return mapper.Map<List<ViewProduct>, List<ViewProductDTO>>(unitOfWork.SupplierRepository.ListViewProductByIdSup(supplierID));
        }

        public List<ViewSupplierDTO> GetListViewSupByCityName(string CityName)
        {

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ViewSupplier, ViewSupplierDTO>()).CreateMapper();
            return mapper.Map<List<ViewSupplier>, List<ViewSupplierDTO>>(unitOfWork.SupplierRepository.ListViewSupByCityName(CityName));
        }


    }
}
