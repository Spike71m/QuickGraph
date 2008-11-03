using System;
using System.Diagnostics;

namespace QuickGraph
{
    [Serializable]
    [DebuggerDisplay("{ID}:{Source}->{Target}")]
    public class IdentifiableEdge<TVertex> : 
        Edge<TVertex>, 
        IIdentifiable
    {
        private readonly string id;

        public IdentifiableEdge(TVertex source, TVertex target, string id)
            : base(source, target)
        {
            GraphContracts.AssumeNotNull(id, "id");
            this.id = id;
        }

        public string ID
        {
            get { return this.id; }
        }

        public override string ToString()
        {
            return this.id;
        }
    }
}