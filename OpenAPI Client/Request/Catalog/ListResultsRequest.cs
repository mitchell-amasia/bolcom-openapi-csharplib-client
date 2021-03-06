﻿using Bol.OpenAPI.Request.Common;
using System;

namespace Bol.OpenAPI.Request.Catalog
{
    public class ListResultsRequest
    {
        public ListResultsRequest() { }

        public EnumTypes.ListType? Type { get; set; } 
        public string CategoryId { get; set; }
        public string[] RefinementIds { get; set; }
        public string ListId { get; set; }
        public Boolean? IncludeAttributes { get; set; }
        public EnumTypes.DataOutputType[] DataOutputs { get; set; }
        public EnumTypes.OfferType[] Offers { get; set; }
        public EnumTypes.SortingMethod? Sort { get; set; }
        public Int64? Offset { get; set; }
        public Int32? Limit { get; set; }   
    }
}
