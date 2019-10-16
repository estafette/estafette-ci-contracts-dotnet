// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_event.proto</summary>
  public static partial class EstafetteEventReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFtYW5pZmVzdC52MS9lc3RhZmV0dGVfZXZlbnQucHJvdG8SC21hbmlmZXN0",
            "LnYxGiptYW5pZmVzdC52MS9lc3RhZmV0dGVfcGlwZWxpbmVfZXZlbnQucHJv",
            "dG8aKW1hbmlmZXN0LnYxL2VzdGFmZXR0ZV9yZWxlYXNlX2V2ZW50LnByb3Rv",
            "GiVtYW5pZmVzdC52MS9lc3RhZmV0dGVfZ2l0X2V2ZW50LnByb3RvGihtYW5p",
            "ZmVzdC52MS9lc3RhZmV0dGVfZG9ja2VyX2V2ZW50LnByb3RvGiZtYW5pZmVz",
            "dC52MS9lc3RhZmV0dGVfY3Jvbl9ldmVudC5wcm90bxopbWFuaWZlc3QudjEv",
            "ZXN0YWZldHRlX3B1Yl9zdWJfZXZlbnQucHJvdG8aKG1hbmlmZXN0LnYxL2Vz",
            "dGFmZXR0ZV9tYW51YWxfZXZlbnQucHJvdG8i8gIKDkVzdGFmZXR0ZUV2ZW50",
            "EjUKCHBpcGVsaW5lGAEgASgLMiMubWFuaWZlc3QudjEuRXN0YWZldHRlUGlw",
            "ZWxpbmVFdmVudBIzCgdyZWxlYXNlGAIgASgLMiIubWFuaWZlc3QudjEuRXN0",
            "YWZldHRlUmVsZWFzZUV2ZW50EisKA2dpdBgDIAEoCzIeLm1hbmlmZXN0LnYx",
            "LkVzdGFmZXR0ZUdpdEV2ZW50EjEKBmRvY2tlchgEIAEoCzIhLm1hbmlmZXN0",
            "LnYxLkVzdGFmZXR0ZURvY2tlckV2ZW50Ei0KBGNyb24YBSABKAsyHy5tYW5p",
            "ZmVzdC52MS5Fc3RhZmV0dGVDcm9uRXZlbnQSMgoHcHViX3N1YhgGIAEoCzIh",
            "Lm1hbmlmZXN0LnYxLkVzdGFmZXR0ZVB1YlN1YkV2ZW50EjEKBm1hbnVhbBgH",
            "IAEoCzIhLm1hbmlmZXN0LnYxLkVzdGFmZXR0ZU1hbnVhbEV2ZW50QkBaPmdp",
            "dGh1Yi5jb20vZXN0YWZldHRlL2VzdGFmZXR0ZS1jaS1jb250cmFjdHMtZ29s",
            "YW5nL21hbmlmZXN0X3YxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Manifest.V1.EstafettePipelineEventReflection.Descriptor, global::Manifest.V1.EstafetteReleaseEventReflection.Descriptor, global::Manifest.V1.EstafetteGitEventReflection.Descriptor, global::Manifest.V1.EstafetteDockerEventReflection.Descriptor, global::Manifest.V1.EstafetteCronEventReflection.Descriptor, global::Manifest.V1.EstafettePubSubEventReflection.Descriptor, global::Manifest.V1.EstafetteManualEventReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Manifest.V1.EstafetteEvent), global::Manifest.V1.EstafetteEvent.Parser, new[]{ "Pipeline", "Release", "Git", "Docker", "Cron", "PubSub", "Manual" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteEvent : pb::IMessage<EstafetteEvent> {
    private static readonly pb::MessageParser<EstafetteEvent> _parser = new pb::MessageParser<EstafetteEvent>(() => new EstafetteEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Manifest.V1.EstafetteEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteEvent(EstafetteEvent other) : this() {
      pipeline_ = other.pipeline_ != null ? other.pipeline_.Clone() : null;
      release_ = other.release_ != null ? other.release_.Clone() : null;
      git_ = other.git_ != null ? other.git_.Clone() : null;
      docker_ = other.docker_ != null ? other.docker_.Clone() : null;
      cron_ = other.cron_ != null ? other.cron_.Clone() : null;
      pubSub_ = other.pubSub_ != null ? other.pubSub_.Clone() : null;
      manual_ = other.manual_ != null ? other.manual_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteEvent Clone() {
      return new EstafetteEvent(this);
    }

    /// <summary>Field number for the "pipeline" field.</summary>
    public const int PipelineFieldNumber = 1;
    private global::Manifest.V1.EstafettePipelineEvent pipeline_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Manifest.V1.EstafettePipelineEvent Pipeline {
      get { return pipeline_; }
      set {
        pipeline_ = value;
      }
    }

    /// <summary>Field number for the "release" field.</summary>
    public const int ReleaseFieldNumber = 2;
    private global::Manifest.V1.EstafetteReleaseEvent release_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Manifest.V1.EstafetteReleaseEvent Release {
      get { return release_; }
      set {
        release_ = value;
      }
    }

    /// <summary>Field number for the "git" field.</summary>
    public const int GitFieldNumber = 3;
    private global::Manifest.V1.EstafetteGitEvent git_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Manifest.V1.EstafetteGitEvent Git {
      get { return git_; }
      set {
        git_ = value;
      }
    }

    /// <summary>Field number for the "docker" field.</summary>
    public const int DockerFieldNumber = 4;
    private global::Manifest.V1.EstafetteDockerEvent docker_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Manifest.V1.EstafetteDockerEvent Docker {
      get { return docker_; }
      set {
        docker_ = value;
      }
    }

    /// <summary>Field number for the "cron" field.</summary>
    public const int CronFieldNumber = 5;
    private global::Manifest.V1.EstafetteCronEvent cron_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Manifest.V1.EstafetteCronEvent Cron {
      get { return cron_; }
      set {
        cron_ = value;
      }
    }

    /// <summary>Field number for the "pub_sub" field.</summary>
    public const int PubSubFieldNumber = 6;
    private global::Manifest.V1.EstafettePubSubEvent pubSub_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Manifest.V1.EstafettePubSubEvent PubSub {
      get { return pubSub_; }
      set {
        pubSub_ = value;
      }
    }

    /// <summary>Field number for the "manual" field.</summary>
    public const int ManualFieldNumber = 7;
    private global::Manifest.V1.EstafetteManualEvent manual_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Manifest.V1.EstafetteManualEvent Manual {
      get { return manual_; }
      set {
        manual_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pipeline, other.Pipeline)) return false;
      if (!object.Equals(Release, other.Release)) return false;
      if (!object.Equals(Git, other.Git)) return false;
      if (!object.Equals(Docker, other.Docker)) return false;
      if (!object.Equals(Cron, other.Cron)) return false;
      if (!object.Equals(PubSub, other.PubSub)) return false;
      if (!object.Equals(Manual, other.Manual)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pipeline_ != null) hash ^= Pipeline.GetHashCode();
      if (release_ != null) hash ^= Release.GetHashCode();
      if (git_ != null) hash ^= Git.GetHashCode();
      if (docker_ != null) hash ^= Docker.GetHashCode();
      if (cron_ != null) hash ^= Cron.GetHashCode();
      if (pubSub_ != null) hash ^= PubSub.GetHashCode();
      if (manual_ != null) hash ^= Manual.GetHashCode();
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
      if (pipeline_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pipeline);
      }
      if (release_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Release);
      }
      if (git_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Git);
      }
      if (docker_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Docker);
      }
      if (cron_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Cron);
      }
      if (pubSub_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PubSub);
      }
      if (manual_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Manual);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pipeline_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pipeline);
      }
      if (release_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Release);
      }
      if (git_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Git);
      }
      if (docker_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Docker);
      }
      if (cron_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cron);
      }
      if (pubSub_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PubSub);
      }
      if (manual_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Manual);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteEvent other) {
      if (other == null) {
        return;
      }
      if (other.pipeline_ != null) {
        if (pipeline_ == null) {
          pipeline_ = new global::Manifest.V1.EstafettePipelineEvent();
        }
        Pipeline.MergeFrom(other.Pipeline);
      }
      if (other.release_ != null) {
        if (release_ == null) {
          release_ = new global::Manifest.V1.EstafetteReleaseEvent();
        }
        Release.MergeFrom(other.Release);
      }
      if (other.git_ != null) {
        if (git_ == null) {
          git_ = new global::Manifest.V1.EstafetteGitEvent();
        }
        Git.MergeFrom(other.Git);
      }
      if (other.docker_ != null) {
        if (docker_ == null) {
          docker_ = new global::Manifest.V1.EstafetteDockerEvent();
        }
        Docker.MergeFrom(other.Docker);
      }
      if (other.cron_ != null) {
        if (cron_ == null) {
          cron_ = new global::Manifest.V1.EstafetteCronEvent();
        }
        Cron.MergeFrom(other.Cron);
      }
      if (other.pubSub_ != null) {
        if (pubSub_ == null) {
          pubSub_ = new global::Manifest.V1.EstafettePubSubEvent();
        }
        PubSub.MergeFrom(other.PubSub);
      }
      if (other.manual_ != null) {
        if (manual_ == null) {
          manual_ = new global::Manifest.V1.EstafetteManualEvent();
        }
        Manual.MergeFrom(other.Manual);
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
            if (pipeline_ == null) {
              pipeline_ = new global::Manifest.V1.EstafettePipelineEvent();
            }
            input.ReadMessage(pipeline_);
            break;
          }
          case 18: {
            if (release_ == null) {
              release_ = new global::Manifest.V1.EstafetteReleaseEvent();
            }
            input.ReadMessage(release_);
            break;
          }
          case 26: {
            if (git_ == null) {
              git_ = new global::Manifest.V1.EstafetteGitEvent();
            }
            input.ReadMessage(git_);
            break;
          }
          case 34: {
            if (docker_ == null) {
              docker_ = new global::Manifest.V1.EstafetteDockerEvent();
            }
            input.ReadMessage(docker_);
            break;
          }
          case 42: {
            if (cron_ == null) {
              cron_ = new global::Manifest.V1.EstafetteCronEvent();
            }
            input.ReadMessage(cron_);
            break;
          }
          case 50: {
            if (pubSub_ == null) {
              pubSub_ = new global::Manifest.V1.EstafettePubSubEvent();
            }
            input.ReadMessage(pubSub_);
            break;
          }
          case 58: {
            if (manual_ == null) {
              manual_ = new global::Manifest.V1.EstafetteManualEvent();
            }
            input.ReadMessage(manual_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
