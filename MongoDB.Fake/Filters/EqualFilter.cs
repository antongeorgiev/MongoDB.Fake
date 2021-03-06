﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace MongoDB.Fake.Filters
{
    internal class EqualFilter : IFilter
    {
        private readonly BsonValue _specifiedValue;

        public EqualFilter(BsonValue specifiedValue)
        {
            _specifiedValue = specifiedValue;
        }

        public bool Filter(BsonValue value)
        {
            return value.Equals(_specifiedValue);
        }
    }
}
