﻿namespace MongoDB.Fake.Tests.Filters
{
    public class GreaterThanFilterTests : FilterTestBase<GreaterThanFilterTests, SimpleTestDocument>
    {
        public GreaterThanFilterTests(MongoCollectionProviderFixture<SimpleTestDocument> mongoCollectionProvider)
            : base(mongoCollectionProvider)
        {
        }
    }
}
