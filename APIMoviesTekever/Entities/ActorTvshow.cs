using System;
using System.Collections.Generic;

namespace APIMoviesTekever.Entities
{
    public partial class ActorTvshow
    {
        public int Id { get; set; }
        public int? ActorId { get; set; }
        public int TvshowId { get; set; }
    }
}
