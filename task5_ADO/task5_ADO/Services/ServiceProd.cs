using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5_ADO.DAL.Repository;
using AutoMapper;
using task5_ADO.DTO;
using task5_ADO.DAL.View;
using task5_ADO.DAL.Model;
using task5_ADO.DAL.UOW;

namespace task5_ADO.Services
{
    public class ServiceProd
    {

         private UnitOfWork unitOfWork = new UnitOfWork();  //создаем обьект uow      


        public List<CategoryDTO> GetCategory_List()
        {
            
                // применяем автомаппер для проекции одной коллекции на другую
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();
                return mapper.Map<List<Category>, List<CategoryDTO>>(unitOfWork.CategoryRepository.List_Category().ToList());
            
        }

        public List<SupplierDTO> GetSupplier_List()
        {
            

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Supplier, SupplierDTO>()).CreateMapper();
                return mapper.Map<List<Supplier>, List<SupplierDTO>>(unitOfWork.SupplierRepository.List_Supplier().ToList());
           
        }

        public List<ViewProductDTO> GetListViewProductByCatID(int categoryID)
        {
           

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ViewProduct, ViewProductDTO>()).CreateMapper();
                return mapper.Map<List<ViewProduct>, List<ViewProductDTO>>(unitOfWork.ProductRepository.ListViewProductByCatId(categoryID).ToList());
            
        }

        public List<ViewProductDTO> GetListViewProductByPrice(float price)
        {
            

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ViewProduct, ViewProductDTO>()).CreateMapper();
                return mapper.Map<List<ViewProduct>, List<ViewProductDTO>>(unitOfWork.ProductRepository.ListViewProductByPrice(price).ToList());
            
        }

        public List<ViewProductDTO> GetListViewProductByIdSup(int supplierID)
        {
            
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ViewProduct, ViewProductDTO>()).CreateMapper();
                return mapper.Map<List<ViewProduct>, List<ViewProductDTO>>(unitOfWork.SupplierRepository.ListViewProductByIdSup(supplierID).ToList());
            
        }

        public List<ViewSupplierDTO> GetListViewSupByCityName(string CityName)
        {
            
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ViewSupplier, ViewSupplierDTO>()).CreateMapper();
                return mapper.Map<List<ViewSupplier>, List<ViewSupplierDTO>>(unitOfWork.SupplierRepository.ListViewSupByCityName(CityName).ToList());
            
        }


    }
}
