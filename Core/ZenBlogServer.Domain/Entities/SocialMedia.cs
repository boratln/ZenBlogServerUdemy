using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlogServer.Domain.Entities.Common;

namespace ZenBlogServer.Domain.Entities
{
    public class SocialMedia:BaseEntity
    {
        public string Title {  get; set; }
        public string Icon {  get; set; }
        public string Url {  get; set; }
    }
}
