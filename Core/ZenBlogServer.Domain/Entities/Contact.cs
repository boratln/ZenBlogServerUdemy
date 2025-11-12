using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlogServer.Domain.Entities.Common;

namespace ZenBlogServer.Domain.Entities
{
    public class Contact:BaseEntity
    {

        public string Address {  get; set; }
        public string Email {  get; set; }
        public string Phone { get; set; }   
        public string Map {  get; set; }

    }
}
