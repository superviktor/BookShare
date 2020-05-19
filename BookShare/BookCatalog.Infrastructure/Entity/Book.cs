﻿using Microsoft.WindowsAzure.Storage.Table;

namespace BookCatalog.Infrastructure.Entity
{
    public class Book : TableEntity
    {
        public string Name { get; private set; }
        public string Annotation { get; private set; }
        public string Status { get; private set; }
    }
}
