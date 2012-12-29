﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmdbWrapper.Utilities;

namespace TmdbWrapper.Movies
{
    /// <summary>
    /// Genre.
    /// </summary>
    public class Genre : ITmdbObject
    {
        /// <summary>
        /// Id of this genre.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of this genre.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns this instance ToString
        /// </summary>        
        public override string ToString()
        {
            return Name;
        }

        void ITmdbObject.ProcessJson(Windows.Data.Json.JsonObject jsonObject)
        {
            Id = (int)jsonObject.GetNamedValue("id").GetSafeNumber();
            Name = jsonObject.GetNamedValue("name").GetSafeString();
        }
    }
}