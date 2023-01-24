using System.Data.OracleClient;

namespace OracleAccessTest.DataBase
{
    /// <summary>
    /// Contains each parameter info from a SQL Developer procedure
    /// </summary>
    public class Parameter
    {
        public string name;
        public object value;
        public OracleType type;

        public Parameter(string name, object value, OracleType type)
        {
            this.name = name;
            this.value = value;
            this.type = type;
        }
    }
}
