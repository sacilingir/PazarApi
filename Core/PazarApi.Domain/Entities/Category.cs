using PazarApi.Domain.Common;

namespace PazarApi.Domain.Entities
{
    public class Category:EntityBase
    {
        public Category()
        {
            
        }
        public Category(int parendId,string name,int priority)
        {
            ParentId = parendId;
            Name = name;
            Priority = priority;
        }
        public int ParentId  { get; set; }
        public string Name  { get; set; }
        public int Priority  { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
