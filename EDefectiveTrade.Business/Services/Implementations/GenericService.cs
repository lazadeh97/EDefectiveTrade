using AutoMapper;
using EDefectiveTrade.Business.DTOs.Common;
using EDefectiveTrade.Business.Exceptions;
using EDefectiveTrade.Business.Services.Interfaces;
using EDefectiveTrade.Core.Entities;
using EDefectiveTrade.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDefectiveTrade.Business.Services.Implementations
{
    public class GenericService<TDTO, TEntity> : IGenericService<TDTO, TEntity> where TDTO : BaseDTO where TEntity : BaseEntity, new()
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        private readonly IMapper _mapper;
        public GenericService(IGenericRepository<TEntity> genericRepository, IMapper mapper, ILogger<GenericService<DTOs.ProductCategory.ProductCategoryDTO, ProductCategory>> logger)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public async Task<TDTO> Create(TDTO entity)
        {
            var newentity = _mapper.Map<TEntity>(entity);
            var addedEntity = await _genericRepository.Create(newentity);
            return _mapper.Map<TDTO>(addedEntity);

        }
        public async Task<TDTO> Update(TDTO entity)
        {
            var existingEntity = await _genericRepository.GetByIdAsync(entity.Id.ToString());
            var updatedEntity = _mapper.Map<TEntity>(entity);
            updatedEntity.UpdatedDate = existingEntity.UpdatedDate;

            //if (existingEntity == null)
            //{
            //    throw new EntityNotFoundException("Entity not found.");
            //}

            await _genericRepository.Update(updatedEntity);

            return _mapper.Map<TDTO>(entity);
        }


        public async Task<TDTO> DeleteByIdAsync(Guid id)
        {
            var deletedItem = await _genericRepository.DeleteByIdAsync(id.ToString());
            return _mapper.Map<TDTO>(deletedItem);
        }

        public async Task<IEnumerable<TDTO>> GetAllAsync()
        {
            var entitylist = await _genericRepository.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<TDTO>>(entitylist);
        }

        public async Task<TDTO> GetByIdAsync(Guid id)
        {
            var exsitingEntity = await _genericRepository.GetByIdAsync(id.ToString());
            return _mapper.Map<TDTO>(exsitingEntity);
        }

        //public async Task<TDto> AddAsync(TDto item)
        //{
        //    try
        //    {
        //        TEntity entity = _mapper.Map<TEntity>(item);
        //        TEntity dbEntity = await _genericRepository.AddAsync(entity);
        //        return _mapper.Map<TDto>(dbEntity);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        _logger.LogError(ex.StackTrace);
        //        //throw  new YourCustomException();
        //        throw new CustomException("BLL də əlavə edillərkən xəta yarandı. Xahiş olunur adminsitrator ilə əlaqə saxla.");
        //    }

        //}
    }
}
