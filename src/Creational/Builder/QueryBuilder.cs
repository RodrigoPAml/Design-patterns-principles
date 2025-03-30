using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public abstract class QueryBuilder
    {
        protected StringBuilder query = new StringBuilder();

        public abstract QueryBuilder Select(params string[] columns);

        public abstract QueryBuilder From(string table);

        public abstract QueryBuilder Where(string condition);

        public abstract string Build();
    }
}
