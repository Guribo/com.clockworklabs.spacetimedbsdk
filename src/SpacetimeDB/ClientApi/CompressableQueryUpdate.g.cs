// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.1.1 (commit bc3d453e871c797c17fdab2d772019832cd9b73e).

#nullable enable

using System;

namespace SpacetimeDB.ClientApi
{
    [SpacetimeDB.Type]
    public partial record CompressableQueryUpdate : SpacetimeDB.TaggedEnum<(
        QueryUpdate Uncompressed,
        System.Collections.Generic.List<byte> Brotli,
        System.Collections.Generic.List<byte> Gzip
    )>;
}
