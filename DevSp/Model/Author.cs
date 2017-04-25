using System;
using System.Collections.Generic;

namespace DevSp.Domain.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Resume { get; set; }
        public Dictionary<SocialMedia, string> SocialMedia { get; set; }        
    }
}
