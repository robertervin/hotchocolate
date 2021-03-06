﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarshmallowPie.Repositories
{
    public interface ISchemaRepository
    {
        IQueryable<Schema> GetSchemas();

        Task<Schema> GetSchemaAsync(
            Guid id,
            CancellationToken cancellationToken = default);

        Task<Schema?> GetSchemaAsync(
            string name,
            CancellationToken cancellationToken = default);

        Task<IReadOnlyDictionary<Guid, Schema>> GetSchemasAsync(
            IReadOnlyList<Guid> ids,
            CancellationToken cancellationToken = default);

        Task<IReadOnlyDictionary<string, Schema>> GetSchemasAsync(
            IReadOnlyList<string> names,
            CancellationToken cancellationToken = default);

        Task AddSchemaAsync(
            Schema schema,
            CancellationToken cancellationToken = default);

        Task UpdateSchemaAsync(
            Schema schema,
            CancellationToken cancellationToken = default);

        IQueryable<SchemaVersion> GetSchemaVersions();

        Task<SchemaVersion?> GetSchemaVersionAsync(
            string hash,
            CancellationToken cancellationToken = default);

        Task<IReadOnlyDictionary<Guid, SchemaVersion>> GetSchemaVersionsAsync(
            IReadOnlyList<Guid> ids,
            CancellationToken cancellationToken = default);

        Task AddSchemaVersionAsync(
            SchemaVersion schemaVersion,
            CancellationToken cancellationToken = default);

        Task UpdateSchemaVersionAsync(
            SchemaVersion schemaVersion,
            CancellationToken cancellationToken = default);

        IQueryable<SchemaPublishReport> GetPublishReports();

        Task<SchemaPublishReport?> GetPublishReportAsync(
            Guid schemaVersionId,
            Guid environmentId,
            CancellationToken cancellationToken = default);

        Task<IReadOnlyDictionary<Guid, SchemaPublishReport>> GetPublishReportsAsync(
            IReadOnlyList<Guid> ids,
            CancellationToken cancellationToken = default);

        Task AddPublishReportAsync(
            SchemaPublishReport publishReport,
            CancellationToken cancellationToken = default);

        Task UpdatePublishReportAsync(
            SchemaPublishReport publishReport,
            CancellationToken cancellationToken = default);
    }
}
