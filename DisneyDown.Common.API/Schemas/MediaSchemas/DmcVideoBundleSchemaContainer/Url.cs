﻿using System;
using Newtonsoft.Json;

namespace DisneyDown.Common.API.Schemas.MediaSchemas.DmcVideoBundleSchemaContainer
{
    public partial class Url
    {
        [JsonProperty("url")]
        public Uri UrlUrl { get; set; }
    }
}