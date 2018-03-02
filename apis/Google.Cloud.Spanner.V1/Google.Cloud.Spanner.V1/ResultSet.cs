// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/spanner/v1/result_set.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Spanner.V1 {

  /// <summary>Holder for reflection information generated from google/spanner/v1/result_set.proto</summary>
  public static partial class ResultSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/spanner/v1/result_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResultSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJnb29nbGUvc3Bhbm5lci92MS9yZXN1bHRfc2V0LnByb3RvEhFnb29nbGUu",
            "c3Bhbm5lci52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxocZ29v",
            "Z2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxoiZ29vZ2xlL3NwYW5uZXIvdjEv",
            "cXVlcnlfcGxhbi5wcm90bxojZ29vZ2xlL3NwYW5uZXIvdjEvdHJhbnNhY3Rp",
            "b24ucHJvdG8aHGdvb2dsZS9zcGFubmVyL3YxL3R5cGUucHJvdG8inwEKCVJl",
            "c3VsdFNldBI2CghtZXRhZGF0YRgBIAEoCzIkLmdvb2dsZS5zcGFubmVyLnYx",
            "LlJlc3VsdFNldE1ldGFkYXRhEigKBHJvd3MYAiADKAsyGi5nb29nbGUucHJv",
            "dG9idWYuTGlzdFZhbHVlEjAKBXN0YXRzGAMgASgLMiEuZ29vZ2xlLnNwYW5u",
            "ZXIudjEuUmVzdWx0U2V0U3RhdHMi0QEKEFBhcnRpYWxSZXN1bHRTZXQSNgoI",
            "bWV0YWRhdGEYASABKAsyJC5nb29nbGUuc3Bhbm5lci52MS5SZXN1bHRTZXRN",
            "ZXRhZGF0YRImCgZ2YWx1ZXMYAiADKAsyFi5nb29nbGUucHJvdG9idWYuVmFs",
            "dWUSFQoNY2h1bmtlZF92YWx1ZRgDIAEoCBIUCgxyZXN1bWVfdG9rZW4YBCAB",
            "KAwSMAoFc3RhdHMYBSABKAsyIS5nb29nbGUuc3Bhbm5lci52MS5SZXN1bHRT",
            "ZXRTdGF0cyJ5ChFSZXN1bHRTZXRNZXRhZGF0YRIvCghyb3dfdHlwZRgBIAEo",
            "CzIdLmdvb2dsZS5zcGFubmVyLnYxLlN0cnVjdFR5cGUSMwoLdHJhbnNhY3Rp",
            "b24YAiABKAsyHi5nb29nbGUuc3Bhbm5lci52MS5UcmFuc2FjdGlvbiJwCg5S",
            "ZXN1bHRTZXRTdGF0cxIwCgpxdWVyeV9wbGFuGAEgASgLMhwuZ29vZ2xlLnNw",
            "YW5uZXIudjEuUXVlcnlQbGFuEiwKC3F1ZXJ5X3N0YXRzGAIgASgLMhcuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cnVjdEKaAQoVY29tLmdvb2dsZS5zcGFubmVyLnYx",
            "Qg5SZXN1bHRTZXRQcm90b1ABWjhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL3NwYW5uZXIvdjE7c3Bhbm5lcvgBAaoCF0dvb2dsZS5D",
            "bG91ZC5TcGFubmVyLlYxygIXR29vZ2xlXENsb3VkXFNwYW5uZXJcVjFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Cloud.Spanner.V1.QueryPlanReflection.Descriptor, global::Google.Cloud.Spanner.V1.TransactionReflection.Descriptor, global::Google.Cloud.Spanner.V1.TypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.ResultSet), global::Google.Cloud.Spanner.V1.ResultSet.Parser, new[]{ "Metadata", "Rows", "Stats" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.PartialResultSet), global::Google.Cloud.Spanner.V1.PartialResultSet.Parser, new[]{ "Metadata", "Values", "ChunkedValue", "ResumeToken", "Stats" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.ResultSetMetadata), global::Google.Cloud.Spanner.V1.ResultSetMetadata.Parser, new[]{ "RowType", "Transaction" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.ResultSetStats), global::Google.Cloud.Spanner.V1.ResultSetStats.Parser, new[]{ "QueryPlan", "QueryStats" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Results from [Read][google.spanner.v1.Spanner.Read] or
  /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].
  /// </summary>
  public sealed partial class ResultSet : pb::IMessage<ResultSet> {
    private static readonly pb::MessageParser<ResultSet> _parser = new pb::MessageParser<ResultSet>(() => new ResultSet());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResultSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.V1.ResultSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSet(ResultSet other) : this() {
      Metadata = other.metadata_ != null ? other.Metadata.Clone() : null;
      rows_ = other.rows_.Clone();
      Stats = other.stats_ != null ? other.Stats.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSet Clone() {
      return new ResultSet(this);
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 1;
    private global::Google.Cloud.Spanner.V1.ResultSetMetadata metadata_;
    /// <summary>
    /// Metadata about the result set, such as row type information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.ResultSetMetadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "rows" field.</summary>
    public const int RowsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.ListValue> _repeated_rows_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.ListValue.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.ListValue> rows_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.ListValue>();
    /// <summary>
    /// Each element in `rows` is a row whose format is defined by
    /// [metadata.row_type][google.spanner.v1.ResultSetMetadata.row_type]. The ith element
    /// in each row matches the ith field in
    /// [metadata.row_type][google.spanner.v1.ResultSetMetadata.row_type]. Elements are
    /// encoded based on type as described
    /// [here][google.spanner.v1.TypeCode].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.ListValue> Rows {
      get { return rows_; }
    }

    /// <summary>Field number for the "stats" field.</summary>
    public const int StatsFieldNumber = 3;
    private global::Google.Cloud.Spanner.V1.ResultSetStats stats_;
    /// <summary>
    /// Query plan and execution statistics for the query that produced this
    /// result set. These can be requested by setting
    /// [ExecuteSqlRequest.query_mode][google.spanner.v1.ExecuteSqlRequest.query_mode].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.ResultSetStats Stats {
      get { return stats_; }
      set {
        stats_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResultSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResultSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if(!rows_.Equals(other.rows_)) return false;
      if (!object.Equals(Stats, other.Stats)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      hash ^= rows_.GetHashCode();
      if (stats_ != null) hash ^= Stats.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (metadata_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Metadata);
      }
      rows_.WriteTo(output, _repeated_rows_codec);
      if (stats_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Stats);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      size += rows_.CalculateSize(_repeated_rows_codec);
      if (stats_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stats);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResultSet other) {
      if (other == null) {
        return;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          metadata_ = new global::Google.Cloud.Spanner.V1.ResultSetMetadata();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      rows_.Add(other.rows_);
      if (other.stats_ != null) {
        if (stats_ == null) {
          stats_ = new global::Google.Cloud.Spanner.V1.ResultSetStats();
        }
        Stats.MergeFrom(other.Stats);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (metadata_ == null) {
              metadata_ = new global::Google.Cloud.Spanner.V1.ResultSetMetadata();
            }
            input.ReadMessage(metadata_);
            break;
          }
          case 18: {
            rows_.AddEntriesFrom(input, _repeated_rows_codec);
            break;
          }
          case 26: {
            if (stats_ == null) {
              stats_ = new global::Google.Cloud.Spanner.V1.ResultSetStats();
            }
            input.ReadMessage(stats_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Partial results from a streaming read or SQL query. Streaming reads and
  /// SQL queries better tolerate large result sets, large rows, and large
  /// values, but are a little trickier to consume.
  /// </summary>
  public sealed partial class PartialResultSet : pb::IMessage<PartialResultSet> {
    private static readonly pb::MessageParser<PartialResultSet> _parser = new pb::MessageParser<PartialResultSet>(() => new PartialResultSet());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PartialResultSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.V1.ResultSetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PartialResultSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PartialResultSet(PartialResultSet other) : this() {
      Metadata = other.metadata_ != null ? other.Metadata.Clone() : null;
      values_ = other.values_.Clone();
      chunkedValue_ = other.chunkedValue_;
      resumeToken_ = other.resumeToken_;
      Stats = other.stats_ != null ? other.Stats.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PartialResultSet Clone() {
      return new PartialResultSet(this);
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 1;
    private global::Google.Cloud.Spanner.V1.ResultSetMetadata metadata_;
    /// <summary>
    /// Metadata about the result set, such as row type information.
    /// Only present in the first response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.ResultSetMetadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "values" field.</summary>
    public const int ValuesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Value.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Value> values_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Value>();
    /// <summary>
    /// A streamed result set consists of a stream of values, which might
    /// be split into many `PartialResultSet` messages to accommodate
    /// large rows and/or large values. Every N complete values defines a
    /// row, where N is equal to the number of entries in
    /// [metadata.row_type.fields][google.spanner.v1.StructType.fields].
    ///
    /// Most values are encoded based on type as described
    /// [here][google.spanner.v1.TypeCode].
    ///
    /// It is possible that the last value in values is "chunked",
    /// meaning that the rest of the value is sent in subsequent
    /// `PartialResultSet`(s). This is denoted by the [chunked_value][google.spanner.v1.PartialResultSet.chunked_value]
    /// field. Two or more chunked values can be merged to form a
    /// complete value as follows:
    ///
    ///   * `bool/number/null`: cannot be chunked
    ///   * `string`: concatenate the strings
    ///   * `list`: concatenate the lists. If the last element in a list is a
    ///     `string`, `list`, or `object`, merge it with the first element in
    ///     the next list by applying these rules recursively.
    ///   * `object`: concatenate the (field name, field value) pairs. If a
    ///     field name is duplicated, then apply these rules recursively
    ///     to merge the field values.
    ///
    /// Some examples of merging:
    ///
    ///     # Strings are concatenated.
    ///     "foo", "bar" => "foobar"
    ///
    ///     # Lists of non-strings are concatenated.
    ///     [2, 3], [4] => [2, 3, 4]
    ///
    ///     # Lists are concatenated, but the last and first elements are merged
    ///     # because they are strings.
    ///     ["a", "b"], ["c", "d"] => ["a", "bc", "d"]
    ///
    ///     # Lists are concatenated, but the last and first elements are merged
    ///     # because they are lists. Recursively, the last and first elements
    ///     # of the inner lists are merged because they are strings.
    ///     ["a", ["b", "c"]], [["d"], "e"] => ["a", ["b", "cd"], "e"]
    ///
    ///     # Non-overlapping object fields are combined.
    ///     {"a": "1"}, {"b": "2"} => {"a": "1", "b": 2"}
    ///
    ///     # Overlapping object fields are merged.
    ///     {"a": "1"}, {"a": "2"} => {"a": "12"}
    ///
    ///     # Examples of merging objects containing lists of strings.
    ///     {"a": ["1"]}, {"a": ["2"]} => {"a": ["12"]}
    ///
    /// For a more complete example, suppose a streaming SQL query is
    /// yielding a result set whose rows contain a single string
    /// field. The following `PartialResultSet`s might be yielded:
    ///
    ///     {
    ///       "metadata": { ... }
    ///       "values": ["Hello", "W"]
    ///       "chunked_value": true
    ///       "resume_token": "Af65..."
    ///     }
    ///     {
    ///       "values": ["orl"]
    ///       "chunked_value": true
    ///       "resume_token": "Bqp2..."
    ///     }
    ///     {
    ///       "values": ["d"]
    ///       "resume_token": "Zx1B..."
    ///     }
    ///
    /// This sequence of `PartialResultSet`s encodes two rows, one
    /// containing the field value `"Hello"`, and a second containing the
    /// field value `"World" = "W" + "orl" + "d"`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Value> Values {
      get { return values_; }
    }

    /// <summary>Field number for the "chunked_value" field.</summary>
    public const int ChunkedValueFieldNumber = 3;
    private bool chunkedValue_;
    /// <summary>
    /// If true, then the final value in [values][google.spanner.v1.PartialResultSet.values] is chunked, and must
    /// be combined with more values from subsequent `PartialResultSet`s
    /// to obtain a complete field value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ChunkedValue {
      get { return chunkedValue_; }
      set {
        chunkedValue_ = value;
      }
    }

    /// <summary>Field number for the "resume_token" field.</summary>
    public const int ResumeTokenFieldNumber = 4;
    private pb::ByteString resumeToken_ = pb::ByteString.Empty;
    /// <summary>
    /// Streaming calls might be interrupted for a variety of reasons, such
    /// as TCP connection loss. If this occurs, the stream of results can
    /// be resumed by re-sending the original request and including
    /// `resume_token`. Note that executing any other transaction in the
    /// same session invalidates the token.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ResumeToken {
      get { return resumeToken_; }
      set {
        resumeToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stats" field.</summary>
    public const int StatsFieldNumber = 5;
    private global::Google.Cloud.Spanner.V1.ResultSetStats stats_;
    /// <summary>
    /// Query plan and execution statistics for the query that produced this
    /// streaming result set. These can be requested by setting
    /// [ExecuteSqlRequest.query_mode][google.spanner.v1.ExecuteSqlRequest.query_mode] and are sent
    /// only once with the last response in the stream.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.ResultSetStats Stats {
      get { return stats_; }
      set {
        stats_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PartialResultSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PartialResultSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if(!values_.Equals(other.values_)) return false;
      if (ChunkedValue != other.ChunkedValue) return false;
      if (ResumeToken != other.ResumeToken) return false;
      if (!object.Equals(Stats, other.Stats)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      hash ^= values_.GetHashCode();
      if (ChunkedValue != false) hash ^= ChunkedValue.GetHashCode();
      if (ResumeToken.Length != 0) hash ^= ResumeToken.GetHashCode();
      if (stats_ != null) hash ^= Stats.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (metadata_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Metadata);
      }
      values_.WriteTo(output, _repeated_values_codec);
      if (ChunkedValue != false) {
        output.WriteRawTag(24);
        output.WriteBool(ChunkedValue);
      }
      if (ResumeToken.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(ResumeToken);
      }
      if (stats_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Stats);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      size += values_.CalculateSize(_repeated_values_codec);
      if (ChunkedValue != false) {
        size += 1 + 1;
      }
      if (ResumeToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ResumeToken);
      }
      if (stats_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stats);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PartialResultSet other) {
      if (other == null) {
        return;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          metadata_ = new global::Google.Cloud.Spanner.V1.ResultSetMetadata();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      values_.Add(other.values_);
      if (other.ChunkedValue != false) {
        ChunkedValue = other.ChunkedValue;
      }
      if (other.ResumeToken.Length != 0) {
        ResumeToken = other.ResumeToken;
      }
      if (other.stats_ != null) {
        if (stats_ == null) {
          stats_ = new global::Google.Cloud.Spanner.V1.ResultSetStats();
        }
        Stats.MergeFrom(other.Stats);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (metadata_ == null) {
              metadata_ = new global::Google.Cloud.Spanner.V1.ResultSetMetadata();
            }
            input.ReadMessage(metadata_);
            break;
          }
          case 18: {
            values_.AddEntriesFrom(input, _repeated_values_codec);
            break;
          }
          case 24: {
            ChunkedValue = input.ReadBool();
            break;
          }
          case 34: {
            ResumeToken = input.ReadBytes();
            break;
          }
          case 42: {
            if (stats_ == null) {
              stats_ = new global::Google.Cloud.Spanner.V1.ResultSetStats();
            }
            input.ReadMessage(stats_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Metadata about a [ResultSet][google.spanner.v1.ResultSet] or [PartialResultSet][google.spanner.v1.PartialResultSet].
  /// </summary>
  public sealed partial class ResultSetMetadata : pb::IMessage<ResultSetMetadata> {
    private static readonly pb::MessageParser<ResultSetMetadata> _parser = new pb::MessageParser<ResultSetMetadata>(() => new ResultSetMetadata());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResultSetMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.V1.ResultSetReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSetMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSetMetadata(ResultSetMetadata other) : this() {
      RowType = other.rowType_ != null ? other.RowType.Clone() : null;
      Transaction = other.transaction_ != null ? other.Transaction.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSetMetadata Clone() {
      return new ResultSetMetadata(this);
    }

    /// <summary>Field number for the "row_type" field.</summary>
    public const int RowTypeFieldNumber = 1;
    private global::Google.Cloud.Spanner.V1.StructType rowType_;
    /// <summary>
    /// Indicates the field names and types for the rows in the result
    /// set.  For example, a SQL query like `"SELECT UserId, UserName FROM
    /// Users"` could return a `row_type` value like:
    ///
    ///     "fields": [
    ///       { "name": "UserId", "type": { "code": "INT64" } },
    ///       { "name": "UserName", "type": { "code": "STRING" } },
    ///     ]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.StructType RowType {
      get { return rowType_; }
      set {
        rowType_ = value;
      }
    }

    /// <summary>Field number for the "transaction" field.</summary>
    public const int TransactionFieldNumber = 2;
    private global::Google.Cloud.Spanner.V1.Transaction transaction_;
    /// <summary>
    /// If the read or SQL query began a transaction as a side-effect, the
    /// information about the new transaction is yielded here.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.Transaction Transaction {
      get { return transaction_; }
      set {
        transaction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResultSetMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResultSetMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RowType, other.RowType)) return false;
      if (!object.Equals(Transaction, other.Transaction)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rowType_ != null) hash ^= RowType.GetHashCode();
      if (transaction_ != null) hash ^= Transaction.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (rowType_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RowType);
      }
      if (transaction_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Transaction);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rowType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RowType);
      }
      if (transaction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transaction);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResultSetMetadata other) {
      if (other == null) {
        return;
      }
      if (other.rowType_ != null) {
        if (rowType_ == null) {
          rowType_ = new global::Google.Cloud.Spanner.V1.StructType();
        }
        RowType.MergeFrom(other.RowType);
      }
      if (other.transaction_ != null) {
        if (transaction_ == null) {
          transaction_ = new global::Google.Cloud.Spanner.V1.Transaction();
        }
        Transaction.MergeFrom(other.Transaction);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (rowType_ == null) {
              rowType_ = new global::Google.Cloud.Spanner.V1.StructType();
            }
            input.ReadMessage(rowType_);
            break;
          }
          case 18: {
            if (transaction_ == null) {
              transaction_ = new global::Google.Cloud.Spanner.V1.Transaction();
            }
            input.ReadMessage(transaction_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Additional statistics about a [ResultSet][google.spanner.v1.ResultSet] or [PartialResultSet][google.spanner.v1.PartialResultSet].
  /// </summary>
  public sealed partial class ResultSetStats : pb::IMessage<ResultSetStats> {
    private static readonly pb::MessageParser<ResultSetStats> _parser = new pb::MessageParser<ResultSetStats>(() => new ResultSetStats());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResultSetStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.V1.ResultSetReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSetStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSetStats(ResultSetStats other) : this() {
      QueryPlan = other.queryPlan_ != null ? other.QueryPlan.Clone() : null;
      QueryStats = other.queryStats_ != null ? other.QueryStats.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultSetStats Clone() {
      return new ResultSetStats(this);
    }

    /// <summary>Field number for the "query_plan" field.</summary>
    public const int QueryPlanFieldNumber = 1;
    private global::Google.Cloud.Spanner.V1.QueryPlan queryPlan_;
    /// <summary>
    /// [QueryPlan][google.spanner.v1.QueryPlan] for the query associated with this result.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.QueryPlan QueryPlan {
      get { return queryPlan_; }
      set {
        queryPlan_ = value;
      }
    }

    /// <summary>Field number for the "query_stats" field.</summary>
    public const int QueryStatsFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Struct queryStats_;
    /// <summary>
    /// Aggregated statistics from the execution of the query. Only present when
    /// the query is profiled. For example, a query could return the statistics as
    /// follows:
    ///
    ///     {
    ///       "rows_returned": "3",
    ///       "elapsed_time": "1.22 secs",
    ///       "cpu_time": "1.19 secs"
    ///     }
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct QueryStats {
      get { return queryStats_; }
      set {
        queryStats_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResultSetStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResultSetStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(QueryPlan, other.QueryPlan)) return false;
      if (!object.Equals(QueryStats, other.QueryStats)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (queryPlan_ != null) hash ^= QueryPlan.GetHashCode();
      if (queryStats_ != null) hash ^= QueryStats.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (queryPlan_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(QueryPlan);
      }
      if (queryStats_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(QueryStats);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (queryPlan_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QueryPlan);
      }
      if (queryStats_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QueryStats);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResultSetStats other) {
      if (other == null) {
        return;
      }
      if (other.queryPlan_ != null) {
        if (queryPlan_ == null) {
          queryPlan_ = new global::Google.Cloud.Spanner.V1.QueryPlan();
        }
        QueryPlan.MergeFrom(other.QueryPlan);
      }
      if (other.queryStats_ != null) {
        if (queryStats_ == null) {
          queryStats_ = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        QueryStats.MergeFrom(other.QueryStats);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (queryPlan_ == null) {
              queryPlan_ = new global::Google.Cloud.Spanner.V1.QueryPlan();
            }
            input.ReadMessage(queryPlan_);
            break;
          }
          case 18: {
            if (queryStats_ == null) {
              queryStats_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(queryStats_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code