using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples
{
    public interface IDataAccess
    {
        void Save();
        void Update();
        void Read();
        void Delete();
    }

    public class DataAccess : IDataAccess
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    public class BusinessLogic
    {
        protected readonly IDataAccess _dataAccess;
        public BusinessLogic(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }


    }    
}
