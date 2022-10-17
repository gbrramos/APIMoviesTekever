using System;
using System.Collections.Generic;

namespace APIMoviesTekever.Entities
{
    public partial class TvShow
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Genre { get; set; }
        public string Type { get; set; } = null!;
        public int? Favorite { get; set; }
    }
}
