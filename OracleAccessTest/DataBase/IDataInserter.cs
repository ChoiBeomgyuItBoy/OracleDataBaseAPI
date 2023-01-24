using System.Collections.Generic;

namespace OracleAccessTest.DataBase
{
    public interface IDataInserter
    {
        string GetInsertionQuery();
        IEnumerable<Parameter> GetParameters();
    }
}
