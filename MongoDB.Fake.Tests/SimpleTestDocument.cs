﻿using System;

namespace MongoDB.Fake.Tests
{
    public class SimpleTestDocument
    {
        public Guid Id { get; set; }
        public String StringField { get; set; }
        public Int32 IntField { get; set; }
    }
}