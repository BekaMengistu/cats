﻿

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Cats.Data.UnitWork;
using Cats.Models;


namespace DRMFSS.BLL.Services
{

    public class ReliefRequisitionDetailService : IReliefRequisitionDetailService
    {
        private readonly IUnitOfWork _unitOfWork;


        public ReliefRequisitionDetailService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        #region Default Service Implementation
        public bool AddReliefRequisitionDetail(ReliefRequisitionDetail reliefRequisitionDetail)
        {
            _unitOfWork.ReliefRequisitionDetailRepository.Add(reliefRequisitionDetail);
            _unitOfWork.Save();
            return true;

        }
        public bool EditReliefRequisitionDetail(ReliefRequisitionDetail reliefRequisitionDetail)
        {
            _unitOfWork.ReliefRequisitionDetailRepository.Edit(reliefRequisitionDetail);
            _unitOfWork.Save();
            return true;

        }
        public bool DeleteReliefRequisitionDetail(ReliefRequisitionDetail reliefRequisitionDetail)
        {
            if (reliefRequisitionDetail == null) return false;
            _unitOfWork.ReliefRequisitionDetailRepository.Delete(reliefRequisitionDetail);
            _unitOfWork.Save();
            return true;
        }
        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.ReliefRequisitionDetailRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.ReliefRequisitionDetailRepository.Delete(entity);
            _unitOfWork.Save();
            return true;
        }
        public List<ReliefRequisitionDetail> GetAllReliefRequisitionDetail()
        {
            return _unitOfWork.ReliefRequisitionDetailRepository.GetAll();
        }
        public ReliefRequisitionDetail FindById(int id)
        {
            return _unitOfWork.ReliefRequisitionDetailRepository.FindById(id);
        }
        public List<ReliefRequisitionDetail> FindBy(Expression<Func<ReliefRequisitionDetail, bool>> predicate)
        {
            return _unitOfWork.ReliefRequisitionDetailRepository.FindBy(predicate);
        }
        #endregion

        public void Dispose()
        {
            _unitOfWork.Dispose();

        }

    }
}


