// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/git_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/git_config.proto</summary>
  public static partial class GitConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/git_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GitConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1jb250cmFjdHMudjEvZ2l0X2NvbmZpZy5wcm90bxIMY29udHJhY3RzLnYx",
            "InMKCUdpdENvbmZpZxITCgtyZXBvX3NvdXJjZRgBIAEoCRISCgpyZXBvX293",
            "bmVyGAIgASgJEhEKCXJlcG9fbmFtZRgDIAEoCRITCgtyZXBvX2JyYW5jaBgE",
            "IAEoCRIVCg1yZXBvX3JldmlzaW9uGAUgASgJQkFaP2dpdGh1Yi5jb20vZXN0",
            "YWZldHRlL2VzdGFmZXR0ZS1jaS1jb250cmFjdHMtZ29sYW5nL2NvbnRyYWN0",
            "c192MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Contracts.V1.GitConfig), global::Contracts.V1.GitConfig.Parser, new[]{ "RepoSource", "RepoOwner", "RepoName", "RepoBranch", "RepoRevision" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GitConfig : pb::IMessage<GitConfig> {
    private static readonly pb::MessageParser<GitConfig> _parser = new pb::MessageParser<GitConfig>(() => new GitConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GitConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contracts.V1.GitConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GitConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GitConfig(GitConfig other) : this() {
      repoSource_ = other.repoSource_;
      repoOwner_ = other.repoOwner_;
      repoName_ = other.repoName_;
      repoBranch_ = other.repoBranch_;
      repoRevision_ = other.repoRevision_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GitConfig Clone() {
      return new GitConfig(this);
    }

    /// <summary>Field number for the "repo_source" field.</summary>
    public const int RepoSourceFieldNumber = 1;
    private string repoSource_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoSource {
      get { return repoSource_; }
      set {
        repoSource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_owner" field.</summary>
    public const int RepoOwnerFieldNumber = 2;
    private string repoOwner_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoOwner {
      get { return repoOwner_; }
      set {
        repoOwner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_name" field.</summary>
    public const int RepoNameFieldNumber = 3;
    private string repoName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoName {
      get { return repoName_; }
      set {
        repoName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_branch" field.</summary>
    public const int RepoBranchFieldNumber = 4;
    private string repoBranch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoBranch {
      get { return repoBranch_; }
      set {
        repoBranch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_revision" field.</summary>
    public const int RepoRevisionFieldNumber = 5;
    private string repoRevision_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoRevision {
      get { return repoRevision_; }
      set {
        repoRevision_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GitConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GitConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RepoSource != other.RepoSource) return false;
      if (RepoOwner != other.RepoOwner) return false;
      if (RepoName != other.RepoName) return false;
      if (RepoBranch != other.RepoBranch) return false;
      if (RepoRevision != other.RepoRevision) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RepoSource.Length != 0) hash ^= RepoSource.GetHashCode();
      if (RepoOwner.Length != 0) hash ^= RepoOwner.GetHashCode();
      if (RepoName.Length != 0) hash ^= RepoName.GetHashCode();
      if (RepoBranch.Length != 0) hash ^= RepoBranch.GetHashCode();
      if (RepoRevision.Length != 0) hash ^= RepoRevision.GetHashCode();
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
      if (RepoSource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RepoSource);
      }
      if (RepoOwner.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RepoOwner);
      }
      if (RepoName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RepoName);
      }
      if (RepoBranch.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RepoBranch);
      }
      if (RepoRevision.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RepoRevision);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RepoSource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoSource);
      }
      if (RepoOwner.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoOwner);
      }
      if (RepoName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoName);
      }
      if (RepoBranch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoBranch);
      }
      if (RepoRevision.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepoRevision);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GitConfig other) {
      if (other == null) {
        return;
      }
      if (other.RepoSource.Length != 0) {
        RepoSource = other.RepoSource;
      }
      if (other.RepoOwner.Length != 0) {
        RepoOwner = other.RepoOwner;
      }
      if (other.RepoName.Length != 0) {
        RepoName = other.RepoName;
      }
      if (other.RepoBranch.Length != 0) {
        RepoBranch = other.RepoBranch;
      }
      if (other.RepoRevision.Length != 0) {
        RepoRevision = other.RepoRevision;
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
            RepoSource = input.ReadString();
            break;
          }
          case 18: {
            RepoOwner = input.ReadString();
            break;
          }
          case 26: {
            RepoName = input.ReadString();
            break;
          }
          case 34: {
            RepoBranch = input.ReadString();
            break;
          }
          case 42: {
            RepoRevision = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
