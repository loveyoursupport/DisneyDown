﻿using Newtonsoft.Json;

namespace DisneyDown.Common.API.Schemas.MediaSchemas.DmcVideoBundleSchemaContainer
{
    public partial class VideoArtMediaMetadata
    {
        [JsonProperty("urls")]
        public Url[] Urls { get; set; }
    }
}