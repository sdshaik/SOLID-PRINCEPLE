using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class BusinessLogicLayer2
    {
        private readonly IRepositoryLayer DAL;

        public BusinessLogicLayer2(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }

    public interface IRepositoryLayer
    {
        void Save(Object details);
    }

    public class DataAccessLayer2 : IRepositoryLayer
    {
        public void Save(Object details)
        {
            //perform save
        }
    }

}
