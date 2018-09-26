﻿using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Bindings;
using MongoDB.Driver.Core.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MilkTea_app.DAL
{
    public static class MongoEvalExtensions
    {
        /// <summary>
        /// Evaluates the specified javascript within a MongoDb database
        /// </summary>
        /// <param name="database">MongoDb Database to execute the javascript</param>
        /// <param name="javascript">Javascript to execute</param>
        /// <returns>A BsonValue result</returns>
        public static async Task<BsonValue> EvalAsync(this IMongoDatabase database, string javascript)
        {
            var client = database.Client as MongoClient;

            if (client == null)
                throw new ArgumentException("Client is not a MongoClient");

            var function = new BsonJavaScript(javascript);
            var op = new EvalOperation(database.DatabaseNamespace, function, null);

            using (var writeBinding = new WritableServerBinding(client.Cluster, new CoreSessionHandle(NoCoreSession.Instance)))
            {
                return await op.ExecuteAsync(writeBinding, CancellationToken.None);
            }
        }
    }
}
