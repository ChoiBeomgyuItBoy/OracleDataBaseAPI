using System.Collections.Generic;

namespace OracleAccessTest.DataBase
{
    public interface IDataInserter
    {
        string GetInsertionTableName();
        string GetInsertionWhereClause();
        Dictionary<string, object> GetInsertionData();
    }
}
