// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: estafette/ci/contracts/v1/build.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.Ci.Contracts.V1 {

  /// <summary>Holder for reflection information generated from estafette/ci/contracts/v1/build.proto</summary>
  public static partial class BuildReflection {

    #region Descriptor
    /// <summary>File descriptor for estafette/ci/contracts/v1/build.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVlc3RhZmV0dGUvY2kvY29udHJhY3RzL3YxL2J1aWxkLnByb3RvEhllc3Rh",
            "ZmV0dGUuY2kuY29udHJhY3RzLnYxGiplc3RhZmV0dGUvY2kvY29udHJhY3Rz",
            "L3YxL2dpdF9jb21taXQucHJvdG8aJWVzdGFmZXR0ZS9jaS9jb250cmFjdHMv",
            "djEvbGFiZWwucHJvdG8aLmVzdGFmZXR0ZS9jaS9jb250cmFjdHMvdjEvcmVs",
            "ZWFzZV90YXJnZXQucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5w",
            "cm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxouZXN0YWZl",
            "dHRlL2NpL21hbmlmZXN0L3YxL2VzdGFmZXR0ZV9ldmVudC5wcm90bxowZXN0",
            "YWZldHRlL2NpL21hbmlmZXN0L3YxL2VzdGFmZXR0ZV90cmlnZ2VyLnByb3Rv",
            "IpYFCgVCdWlsZBIKCgJpZBgBIAEoCRITCgtyZXBvX3NvdXJjZRgCIAEoCRIS",
            "CgpyZXBvX293bmVyGAMgASgJEhEKCXJlcG9fbmFtZRgEIAEoCRITCgtyZXBv",
            "X2JyYW5jaBgFIAEoCRIVCg1yZXBvX3JldmlzaW9uGAYgASgJEhUKDWJ1aWxk",
            "X3ZlcnNpb24YByABKAkSFAoMYnVpbGRfc3RhdHVzGAggASgJEjAKBmxhYmVs",
            "cxgJIAMoCzIgLmVzdGFmZXR0ZS5jaS5jb250cmFjdHMudjEuTGFiZWwSQQoP",
            "cmVsZWFzZV90YXJnZXRzGAogAygLMiguZXN0YWZldHRlLmNpLmNvbnRyYWN0",
            "cy52MS5SZWxlYXNlVGFyZ2V0EhAKCG1hbmlmZXN0GAsgASgJEh4KFm1hbmlm",
            "ZXN0X3dpdGhfZGVmYXVsdHMYDCABKAkSNQoHY29tbWl0cxgNIAMoCzIkLmVz",
            "dGFmZXR0ZS5jaS5jb250cmFjdHMudjEuR2l0Q29tbWl0EjwKCHRyaWdnZXJz",
            "GA4gAygLMiouZXN0YWZldHRlLmNpLm1hbmlmZXN0LnYxLkVzdGFmZXR0ZVRy",
            "aWdnZXISOAoGZXZlbnRzGA8gAygLMiguZXN0YWZldHRlLmNpLm1hbmlmZXN0",
            "LnYxLkVzdGFmZXR0ZUV2ZW50EjQKEGluc2VydGVkX2F0X3RpbWUYECABKAsy",
            "Gi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEjMKD3VwZGF0ZWRfYXRfdGlt",
            "ZRgRIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASKwoIZHVyYXRp",
            "b24YEiABKAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb25CewodY29tLmVz",
            "dGFmZXR0ZS5jaS5jb250cmFjdHMudjFQAVo8Z2l0aHViLmNvbS9lc3RhZmV0",
            "dGUvZXN0YWZldHRlLWNpLXByb3Rvcy1nb2xhbmcvY29udHJhY3RzL3YxqgIZ",
            "RXN0YWZldHRlLkNpLkNvbnRyYWN0cy5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Estafette.Ci.Contracts.V1.GitCommitReflection.Descriptor, global::Estafette.Ci.Contracts.V1.LabelReflection.Descriptor, global::Estafette.Ci.Contracts.V1.ReleaseTargetReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Estafette.Ci.Manifest.V1.EstafetteEventReflection.Descriptor, global::Estafette.Ci.Manifest.V1.EstafetteTriggerReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.Ci.Contracts.V1.Build), global::Estafette.Ci.Contracts.V1.Build.Parser, new[]{ "Id", "RepoSource", "RepoOwner", "RepoName", "RepoBranch", "RepoRevision", "BuildVersion", "BuildStatus", "Labels", "ReleaseTargets", "Manifest", "ManifestWithDefaults", "Commits", "Triggers", "Events", "InsertedAtTime", "UpdatedAtTime", "Duration" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Build : pb::IMessage<Build> {
    private static readonly pb::MessageParser<Build> _parser = new pb::MessageParser<Build>(() => new Build());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Build> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.Ci.Contracts.V1.BuildReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build(Build other) : this() {
      id_ = other.id_;
      repoSource_ = other.repoSource_;
      repoOwner_ = other.repoOwner_;
      repoName_ = other.repoName_;
      repoBranch_ = other.repoBranch_;
      repoRevision_ = other.repoRevision_;
      buildVersion_ = other.buildVersion_;
      buildStatus_ = other.buildStatus_;
      labels_ = other.labels_.Clone();
      releaseTargets_ = other.releaseTargets_.Clone();
      manifest_ = other.manifest_;
      manifestWithDefaults_ = other.manifestWithDefaults_;
      commits_ = other.commits_.Clone();
      triggers_ = other.triggers_.Clone();
      events_ = other.events_.Clone();
      insertedAtTime_ = other.insertedAtTime_ != null ? other.insertedAtTime_.Clone() : null;
      updatedAtTime_ = other.updatedAtTime_ != null ? other.updatedAtTime_.Clone() : null;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build Clone() {
      return new Build(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_source" field.</summary>
    public const int RepoSourceFieldNumber = 2;
    private string repoSource_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoSource {
      get { return repoSource_; }
      set {
        repoSource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_owner" field.</summary>
    public const int RepoOwnerFieldNumber = 3;
    private string repoOwner_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoOwner {
      get { return repoOwner_; }
      set {
        repoOwner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_name" field.</summary>
    public const int RepoNameFieldNumber = 4;
    private string repoName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoName {
      get { return repoName_; }
      set {
        repoName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_branch" field.</summary>
    public const int RepoBranchFieldNumber = 5;
    private string repoBranch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoBranch {
      get { return repoBranch_; }
      set {
        repoBranch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repo_revision" field.</summary>
    public const int RepoRevisionFieldNumber = 6;
    private string repoRevision_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepoRevision {
      get { return repoRevision_; }
      set {
        repoRevision_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_version" field.</summary>
    public const int BuildVersionFieldNumber = 7;
    private string buildVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildVersion {
      get { return buildVersion_; }
      set {
        buildVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_status" field.</summary>
    public const int BuildStatusFieldNumber = 8;
    private string buildStatus_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildStatus {
      get { return buildStatus_; }
      set {
        buildStatus_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Estafette.Ci.Contracts.V1.Label> _repeated_labels_codec
        = pb::FieldCodec.ForMessage(74, global::Estafette.Ci.Contracts.V1.Label.Parser);
    private readonly pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.Label> labels_ = new pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.Label>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.Label> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "release_targets" field.</summary>
    public const int ReleaseTargetsFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Estafette.Ci.Contracts.V1.ReleaseTarget> _repeated_releaseTargets_codec
        = pb::FieldCodec.ForMessage(82, global::Estafette.Ci.Contracts.V1.ReleaseTarget.Parser);
    private readonly pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.ReleaseTarget> releaseTargets_ = new pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.ReleaseTarget>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.ReleaseTarget> ReleaseTargets {
      get { return releaseTargets_; }
    }

    /// <summary>Field number for the "manifest" field.</summary>
    public const int ManifestFieldNumber = 11;
    private string manifest_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Manifest {
      get { return manifest_; }
      set {
        manifest_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manifest_with_defaults" field.</summary>
    public const int ManifestWithDefaultsFieldNumber = 12;
    private string manifestWithDefaults_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ManifestWithDefaults {
      get { return manifestWithDefaults_; }
      set {
        manifestWithDefaults_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "commits" field.</summary>
    public const int CommitsFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Estafette.Ci.Contracts.V1.GitCommit> _repeated_commits_codec
        = pb::FieldCodec.ForMessage(106, global::Estafette.Ci.Contracts.V1.GitCommit.Parser);
    private readonly pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.GitCommit> commits_ = new pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.GitCommit>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.Ci.Contracts.V1.GitCommit> Commits {
      get { return commits_; }
    }

    /// <summary>Field number for the "triggers" field.</summary>
    public const int TriggersFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Estafette.Ci.Manifest.V1.EstafetteTrigger> _repeated_triggers_codec
        = pb::FieldCodec.ForMessage(114, global::Estafette.Ci.Manifest.V1.EstafetteTrigger.Parser);
    private readonly pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteTrigger> triggers_ = new pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteTrigger>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteTrigger> Triggers {
      get { return triggers_; }
    }

    /// <summary>Field number for the "events" field.</summary>
    public const int EventsFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Estafette.Ci.Manifest.V1.EstafetteEvent> _repeated_events_codec
        = pb::FieldCodec.ForMessage(122, global::Estafette.Ci.Manifest.V1.EstafetteEvent.Parser);
    private readonly pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteEvent> events_ = new pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteEvent>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Estafette.Ci.Manifest.V1.EstafetteEvent> Events {
      get { return events_; }
    }

    /// <summary>Field number for the "inserted_at_time" field.</summary>
    public const int InsertedAtTimeFieldNumber = 16;
    private global::Google.Protobuf.WellKnownTypes.Timestamp insertedAtTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp InsertedAtTime {
      get { return insertedAtTime_; }
      set {
        insertedAtTime_ = value;
      }
    }

    /// <summary>Field number for the "updated_at_time" field.</summary>
    public const int UpdatedAtTimeFieldNumber = 17;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updatedAtTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdatedAtTime {
      get { return updatedAtTime_; }
      set {
        updatedAtTime_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 18;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Build);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Build other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (RepoSource != other.RepoSource) return false;
      if (RepoOwner != other.RepoOwner) return false;
      if (RepoName != other.RepoName) return false;
      if (RepoBranch != other.RepoBranch) return false;
      if (RepoRevision != other.RepoRevision) return false;
      if (BuildVersion != other.BuildVersion) return false;
      if (BuildStatus != other.BuildStatus) return false;
      if(!labels_.Equals(other.labels_)) return false;
      if(!releaseTargets_.Equals(other.releaseTargets_)) return false;
      if (Manifest != other.Manifest) return false;
      if (ManifestWithDefaults != other.ManifestWithDefaults) return false;
      if(!commits_.Equals(other.commits_)) return false;
      if(!triggers_.Equals(other.triggers_)) return false;
      if(!events_.Equals(other.events_)) return false;
      if (!object.Equals(InsertedAtTime, other.InsertedAtTime)) return false;
      if (!object.Equals(UpdatedAtTime, other.UpdatedAtTime)) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (RepoSource.Length != 0) hash ^= RepoSource.GetHashCode();
      if (RepoOwner.Length != 0) hash ^= RepoOwner.GetHashCode();
      if (RepoName.Length != 0) hash ^= RepoName.GetHashCode();
      if (RepoBranch.Length != 0) hash ^= RepoBranch.GetHashCode();
      if (RepoRevision.Length != 0) hash ^= RepoRevision.GetHashCode();
      if (BuildVersion.Length != 0) hash ^= BuildVersion.GetHashCode();
      if (BuildStatus.Length != 0) hash ^= BuildStatus.GetHashCode();
      hash ^= labels_.GetHashCode();
      hash ^= releaseTargets_.GetHashCode();
      if (Manifest.Length != 0) hash ^= Manifest.GetHashCode();
      if (ManifestWithDefaults.Length != 0) hash ^= ManifestWithDefaults.GetHashCode();
      hash ^= commits_.GetHashCode();
      hash ^= triggers_.GetHashCode();
      hash ^= events_.GetHashCode();
      if (insertedAtTime_ != null) hash ^= InsertedAtTime.GetHashCode();
      if (updatedAtTime_ != null) hash ^= UpdatedAtTime.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (RepoSource.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RepoSource);
      }
      if (RepoOwner.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RepoOwner);
      }
      if (RepoName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RepoName);
      }
      if (RepoBranch.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RepoBranch);
      }
      if (RepoRevision.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(RepoRevision);
      }
      if (BuildVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(BuildVersion);
      }
      if (BuildStatus.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(BuildStatus);
      }
      labels_.WriteTo(output, _repeated_labels_codec);
      releaseTargets_.WriteTo(output, _repeated_releaseTargets_codec);
      if (Manifest.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Manifest);
      }
      if (ManifestWithDefaults.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(ManifestWithDefaults);
      }
      commits_.WriteTo(output, _repeated_commits_codec);
      triggers_.WriteTo(output, _repeated_triggers_codec);
      events_.WriteTo(output, _repeated_events_codec);
      if (insertedAtTime_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(InsertedAtTime);
      }
      if (updatedAtTime_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(UpdatedAtTime);
      }
      if (duration_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(Duration);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
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
      if (BuildVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildVersion);
      }
      if (BuildStatus.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildStatus);
      }
      size += labels_.CalculateSize(_repeated_labels_codec);
      size += releaseTargets_.CalculateSize(_repeated_releaseTargets_codec);
      if (Manifest.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Manifest);
      }
      if (ManifestWithDefaults.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ManifestWithDefaults);
      }
      size += commits_.CalculateSize(_repeated_commits_codec);
      size += triggers_.CalculateSize(_repeated_triggers_codec);
      size += events_.CalculateSize(_repeated_events_codec);
      if (insertedAtTime_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(InsertedAtTime);
      }
      if (updatedAtTime_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(UpdatedAtTime);
      }
      if (duration_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Build other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
      if (other.BuildVersion.Length != 0) {
        BuildVersion = other.BuildVersion;
      }
      if (other.BuildStatus.Length != 0) {
        BuildStatus = other.BuildStatus;
      }
      labels_.Add(other.labels_);
      releaseTargets_.Add(other.releaseTargets_);
      if (other.Manifest.Length != 0) {
        Manifest = other.Manifest;
      }
      if (other.ManifestWithDefaults.Length != 0) {
        ManifestWithDefaults = other.ManifestWithDefaults;
      }
      commits_.Add(other.commits_);
      triggers_.Add(other.triggers_);
      events_.Add(other.events_);
      if (other.insertedAtTime_ != null) {
        if (insertedAtTime_ == null) {
          insertedAtTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        InsertedAtTime.MergeFrom(other.InsertedAtTime);
      }
      if (other.updatedAtTime_ != null) {
        if (updatedAtTime_ == null) {
          updatedAtTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdatedAtTime.MergeFrom(other.UpdatedAtTime);
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            RepoSource = input.ReadString();
            break;
          }
          case 26: {
            RepoOwner = input.ReadString();
            break;
          }
          case 34: {
            RepoName = input.ReadString();
            break;
          }
          case 42: {
            RepoBranch = input.ReadString();
            break;
          }
          case 50: {
            RepoRevision = input.ReadString();
            break;
          }
          case 58: {
            BuildVersion = input.ReadString();
            break;
          }
          case 66: {
            BuildStatus = input.ReadString();
            break;
          }
          case 74: {
            labels_.AddEntriesFrom(input, _repeated_labels_codec);
            break;
          }
          case 82: {
            releaseTargets_.AddEntriesFrom(input, _repeated_releaseTargets_codec);
            break;
          }
          case 90: {
            Manifest = input.ReadString();
            break;
          }
          case 98: {
            ManifestWithDefaults = input.ReadString();
            break;
          }
          case 106: {
            commits_.AddEntriesFrom(input, _repeated_commits_codec);
            break;
          }
          case 114: {
            triggers_.AddEntriesFrom(input, _repeated_triggers_codec);
            break;
          }
          case 122: {
            events_.AddEntriesFrom(input, _repeated_events_codec);
            break;
          }
          case 130: {
            if (insertedAtTime_ == null) {
              insertedAtTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(insertedAtTime_);
            break;
          }
          case 138: {
            if (updatedAtTime_ == null) {
              updatedAtTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(updatedAtTime_);
            break;
          }
          case 146: {
            if (duration_ == null) {
              duration_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(duration_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
