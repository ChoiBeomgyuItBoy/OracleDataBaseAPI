using System.Collections.Generic;

namespace OracleAccessTest.DataBase
{
    public interface IDataModifier
    {
        string GetModifierQuery();
        IEnumerable<Parameter> GetModifiers();
    }
}
