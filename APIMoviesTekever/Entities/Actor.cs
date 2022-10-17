using System;
using System.Collections.Generic;

namespace APIMoviesTekever.Entities
{
    public partial class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
    }
}
