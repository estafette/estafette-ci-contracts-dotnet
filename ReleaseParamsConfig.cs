// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/release_params_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/release_params_config.proto</summary>
  public static partial class ReleaseParamsConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/release_params_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReleaseParamsConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihjb250cmFjdHMudjEvcmVsZWFzZV9wYXJhbXNfY29uZmlnLnByb3RvEgxj",
            "b250cmFjdHMudjEibQoTUmVsZWFzZVBhcmFtc0NvbmZpZxIUCgxyZWxlYXNl",
            "X25hbWUYASABKAkSEgoKcmVsZWFzZV9pZBgCIAEoAxIWCg5yZWxlYXNlX2Fj",
            "dGlvbhgDIAEoCRIUCgx0cmlnZ2VyZWRfYnkYBCABKAlCQVo/Z2l0aHViLmNv",
            "bS9lc3RhZmV0dGUvZXN0YWZldHRlLWNpLWNvbnRyYWN0cy1nb2xhbmcvY29u",
            "dHJhY3RzX3YxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Contracts.V1.ReleaseParamsConfig), global::Contracts.V1.ReleaseParamsConfig.Parser, new[]{ "ReleaseName", "ReleaseId", "ReleaseAction", "TriggeredBy" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReleaseParamsConfig : pb::IMessage<ReleaseParamsConfig> {
    private static readonly pb::MessageParser<ReleaseParamsConfig> _parser = new pb::MessageParser<ReleaseParamsConfig>(() => new ReleaseParamsConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReleaseParamsConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contracts.V1.ReleaseParamsConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReleaseParamsConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReleaseParamsConfig(ReleaseParamsConfig other) : this() {
      releaseName_ = other.releaseName_;
      releaseId_ = other.releaseId_;
      releaseAction_ = other.releaseAction_;
      triggeredBy_ = other.triggeredBy_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReleaseParamsConfig Clone() {
      return new ReleaseParamsConfig(this);
    }

    /// <summary>Field number for the "release_name" field.</summary>
    public const int ReleaseNameFieldNumber = 1;
    private string releaseName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReleaseName {
      get { return releaseName_; }
      set {
        releaseName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "release_id" field.</summary>
    public const int ReleaseIdFieldNumber = 2;
    private long releaseId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ReleaseId {
      get { return releaseId_; }
      set {
        releaseId_ = value;
      }
    }

    /// <summary>Field number for the "release_action" field.</summary>
    public const int ReleaseActionFieldNumber = 3;
    private string releaseAction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReleaseAction {
      get { return releaseAction_; }
      set {
        releaseAction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "triggered_by" field.</summary>
    public const int TriggeredByFieldNumber = 4;
    private string triggeredBy_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TriggeredBy {
      get { return triggeredBy_; }
      set {
        triggeredBy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReleaseParamsConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReleaseParamsConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReleaseName != other.ReleaseName) return false;
      if (ReleaseId != other.ReleaseId) return false;
      if (ReleaseAction != other.ReleaseAction) return false;
      if (TriggeredBy != other.TriggeredBy) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReleaseName.Length != 0) hash ^= ReleaseName.GetHashCode();
      if (ReleaseId != 0L) hash ^= ReleaseId.GetHashCode();
      if (ReleaseAction.Length != 0) hash ^= ReleaseAction.GetHashCode();
      if (TriggeredBy.Length != 0) hash ^= TriggeredBy.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ReleaseName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ReleaseName);
      }
      if (ReleaseId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ReleaseId);
      }
      if (ReleaseAction.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ReleaseAction);
      }
      if (TriggeredBy.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TriggeredBy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReleaseName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReleaseName);
      }
      if (ReleaseId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ReleaseId);
      }
      if (ReleaseAction.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReleaseAction);
      }
      if (TriggeredBy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TriggeredBy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReleaseParamsConfig other) {
      if (other == null) {
        return;
      }
      if (other.ReleaseName.Length != 0) {
        ReleaseName = other.ReleaseName;
      }
      if (other.ReleaseId != 0L) {
        ReleaseId = other.ReleaseId;
      }
      if (other.ReleaseAction.Length != 0) {
        ReleaseAction = other.ReleaseAction;
      }
      if (other.TriggeredBy.Length != 0) {
        TriggeredBy = other.TriggeredBy;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ReleaseName = input.ReadString();
            break;
          }
          case 16: {
            ReleaseId = input.ReadInt64();
            break;
          }
          case 26: {
            ReleaseAction = input.ReadString();
            break;
          }
          case 34: {
            TriggeredBy = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
