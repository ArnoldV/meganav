﻿using System.Collections.Generic;
using Cogworks.Meganav.Converters;
using Cogworks.Meganav.Enums;
using Newtonsoft.Json;
using Umbraco.Core;
using Umbraco.Core.Models;

namespace Cogworks.Meganav.Models
{
    public class MeganavItem : IMeganavItem
    {
        public int Id { get; set; }
        public GuidUdi Udi { get; set; }
        public string Title { get; set; }

        public string Target { get; set; }

        public string Url { get; set; }
        public string Anchor { get; set; }

        [JsonIgnore]
        public IPublishedContent Content { get; set; }

        [JsonConverter(typeof(DictionaryConverter))]
        public IDictionary<string, object> Properties { get; set; }

        #region Internal

        [JsonConverter(typeof(ChildConverter<MeganavItem>))]
        public IEnumerable<MeganavItem> Children { get; set; }

        [JsonIgnore]
        public ItemType ItemType { get; set; }

        [JsonIgnore]
        public int Level { get; set; }

        #endregion
    }
}