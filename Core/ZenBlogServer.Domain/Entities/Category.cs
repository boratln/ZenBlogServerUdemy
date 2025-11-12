using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlogServer.Domain.Entities.Common;

namespace ZenBlogServer.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName {  get; set; }
        public IList<Blog> Blogs { get; set; }
    }
}
