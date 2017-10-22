using AFX.Data.Entity.SalverManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFX.Data.IRepository.SalverManager
{
    public interface ISalverRepository : IRepositoryBase<SalverEntity>
    {
        void DeleteForm(int keyValue);
        void SubmitForm(SalverEntity userEntity, int? keyValue);
    }
}
