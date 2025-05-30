// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.1.1 (commit bc3d453e871c797c17fdab2d772019832cd9b73e).

#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.ClientApi
{
    [SpacetimeDB.Type]
    [DataContract]
    public sealed partial class SubscriptionError
    {
        [DataMember(Name = "total_host_execution_duration_micros")]
        public ulong TotalHostExecutionDurationMicros;
        [DataMember(Name = "request_id")]
        public uint? RequestId;
        [DataMember(Name = "query_id")]
        public uint? QueryId;
        [DataMember(Name = "table_id")]
        public uint? TableId;
        [DataMember(Name = "error")]
        public string Error;

        public SubscriptionError(
            ulong TotalHostExecutionDurationMicros,
            uint? RequestId,
            uint? QueryId,
            uint? TableId,
            string Error
        )
        {
            this.TotalHostExecutionDurationMicros = TotalHostExecutionDurationMicros;
            this.RequestId = RequestId;
            this.QueryId = QueryId;
            this.TableId = TableId;
            this.Error = Error;
        }

        public SubscriptionError()
        {
            this.Error = "";
        }
    }
}
