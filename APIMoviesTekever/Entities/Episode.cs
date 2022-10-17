using System;
using System.Collections.Generic;

namespace APIMoviesTekever.Entities
{
    public partial class Episode
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Temp { get; set; }
        public int Duration { get; set; }
        public string ReleaseDate { get; set; } = null!;
        public int TvshowId { get; set; }
    }
}
