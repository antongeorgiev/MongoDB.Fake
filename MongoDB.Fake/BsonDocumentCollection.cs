﻿using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson;

namespace MongoDB.Fake
{
    public class BsonDocumentCollection : ICollection<BsonDocument>
    {
        private readonly ICollection<BsonDocument> _collectionImplementation;

        public BsonDocumentCollection()
        {
            _collectionImplementation = new List<BsonDocument>();
        }

        public IEnumerator<BsonDocument> GetEnumerator()
        {
            return _collectionImplementation.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_collectionImplementation).GetEnumerator();
        }

        public void Add(BsonDocument item)
        {
            _collectionImplementation.Add(item);
        }

        public void Clear()
        {
            _collectionImplementation.Clear();
        }

        public Boolean Contains(BsonDocument item)
        {
            return _collectionImplementation.Contains(item);
        }

        public void CopyTo(BsonDocument[] array, Int32 arrayIndex)
        {
            _collectionImplementation.CopyTo(array, arrayIndex);
        }

        public Boolean Remove(BsonDocument item)
        {
            return _collectionImplementation.Remove(item);
        }

        public Int32 Count
        {
            get { return _collectionImplementation.Count; }
        }

        public Boolean IsReadOnly
        {
            get { return _collectionImplementation.IsReadOnly; }
        }
    }
}