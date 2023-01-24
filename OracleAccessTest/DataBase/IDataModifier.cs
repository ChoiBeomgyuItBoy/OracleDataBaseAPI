using System.Collections.Generic;

namespace OracleAccessTest.DataBase
{
    public interface IDataModifier
    {
        string GetModifyingTableName();
        string GetModifyingWhereClause();
        Dictionary<string, object> GetDataToModify();
    }
}
