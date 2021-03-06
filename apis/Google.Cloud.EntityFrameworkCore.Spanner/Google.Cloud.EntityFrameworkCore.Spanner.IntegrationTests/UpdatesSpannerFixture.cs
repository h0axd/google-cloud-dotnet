﻿// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestModels.UpdatesModel;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class UpdatesSpannerFixture : UpdatesFixtureBase<SpannerTestStore>
    {
        private readonly IServiceProvider _serviceProvider;

        public UpdatesSpannerFixture() => _serviceProvider = new ServiceCollection()
            .AddEntityFrameworkSpanner()
            .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
            .BuildServiceProvider();

        protected virtual string DatabaseName => "partialupdatespannertest";

        public override SpannerTestStore CreateTestStore()
            => SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
            {
                var optionsBuilder = new DbContextOptionsBuilder()
                    .UseSpanner(SpannerTestStore.CreateConnectionString(DatabaseName), b => b.ApplyConfiguration())
                    .UseInternalServiceProvider(_serviceProvider);

                using (var context = new UpdatesContext(optionsBuilder.Options))
                {
                    context.Database.EnsureCreated();
                    UpdatesModelInitializer.Seed(context);
                }
            });

        public override UpdatesContext CreateContext(SpannerTestStore testStore)
        {
            var optionsBuilder = new DbContextOptionsBuilder()
                .UseSpanner(testStore.Connection, b => b.ApplyConfiguration())
                .UseInternalServiceProvider(_serviceProvider);

            var context = new UpdatesContext(optionsBuilder.Options);
            context.Database.UseTransaction(testStore.Transaction);
            return context;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}