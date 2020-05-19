using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog.Infrastructure.AzureTable
{
    public class BatchOperationOptions
    {
        public BatchInsertMethod BatchInsertMethod { get; set; }
    }

    public enum BatchInsertMethod
    {
        Insert,
        InsertOrReplace,
        InsertOrMerge
    }
}
