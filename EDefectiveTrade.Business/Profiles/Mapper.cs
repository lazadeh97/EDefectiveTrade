using AutoMapper;
using EDefectiveTrade.Business.DTOs.Help;
using EDefectiveTrade.Business.DTOs.History;
using EDefectiveTrade.Business.DTOs.Image;
using EDefectiveTrade.Business.DTOs.Product;
using EDefectiveTrade.Business.DTOs.ProductCategory;
using EDefectiveTrade.Business.DTOs.Region;
using EDefectiveTrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Profiles
{
    public class Mapper : Profile
    {
        public Mapper() 
        {
            CreateMap<CityDTO, City>();
            CreateMap<CountryDTO, Country>();
            CreateMap<HelpDTO, Help>();
            CreateMap<ProductDTO, Product>();
            CreateMap<ProductCategoryDTO, ProductCategory>();        
            CreateMap<ProductHistoryDTO, ProductHistory>();
            CreateMap<ProductImageDTO, ProductImage>();
        }
    }
}
