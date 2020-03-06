// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: estafette/ci/contracts/v1/build_log_step_docker_image.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.Ci.Contracts.V1 {

  /// <summary>Holder for reflection information generated from estafette/ci/contracts/v1/build_log_step_docker_image.proto</summary>
  public static partial class BuildLogStepDockerImageReflection {

    #region Descriptor
    /// <summary>File descriptor for estafette/ci/contracts/v1/build_log_step_docker_image.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildLogStepDockerImageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtlc3RhZmV0dGUvY2kvY29udHJhY3RzL3YxL2J1aWxkX2xvZ19zdGVwX2Rv",
            "Y2tlcl9pbWFnZS5wcm90bxIZZXN0YWZldHRlLmNpLmNvbnRyYWN0cy52MRoe",
            "Z29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9uLnByb3RvIrABChdCdWlsZExvZ1N0",
            "ZXBEb2NrZXJJbWFnZRIMCgRuYW1lGAEgASgJEgsKA3RhZxgCIAEoCRIRCglp",
            "c19wdWxsZWQYAyABKAgSEgoKaW1hZ2Vfc2l6ZRgEIAEoAxIwCg1wdWxsX2R1",
            "cmF0aW9uGAUgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0aW9uEg0KBWVy",
            "cm9yGAYgASgJEhIKCmlzX3RydXN0ZWQYByABKAhCewodY29tLmVzdGFmZXR0",
            "ZS5jaS5jb250cmFjdHMudjFQAVo8Z2l0aHViLmNvbS9lc3RhZmV0dGUvZXN0",
            "YWZldHRlLWNpLXByb3Rvcy1nb2xhbmcvY29udHJhY3RzL3YxqgIZRXN0YWZl",
            "dHRlLkNpLkNvbnRyYWN0cy5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.Ci.Contracts.V1.BuildLogStepDockerImage), global::Estafette.Ci.Contracts.V1.BuildLogStepDockerImage.Parser, new[]{ "Name", "Tag", "IsPulled", "ImageSize", "PullDuration", "Error", "IsTrusted" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BuildLogStepDockerImage : pb::IMessage<BuildLogStepDockerImage> {
    private static readonly pb::MessageParser<BuildLogStepDockerImage> _parser = new pb::MessageParser<BuildLogStepDockerImage>(() => new BuildLogStepDockerImage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildLogStepDockerImage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.Ci.Contracts.V1.BuildLogStepDockerImageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildLogStepDockerImage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildLogStepDockerImage(BuildLogStepDockerImage other) : this() {
      name_ = other.name_;
      tag_ = other.tag_;
      isPulled_ = other.isPulled_;
      imageSize_ = other.imageSize_;
      pullDuration_ = other.pullDuration_ != null ? other.pullDuration_.Clone() : null;
      error_ = other.error_;
      isTrusted_ = other.isTrusted_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildLogStepDockerImage Clone() {
      return new BuildLogStepDockerImage(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 2;
    private string tag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_pulled" field.</summary>
    public const int IsPulledFieldNumber = 3;
    private bool isPulled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsPulled {
      get { return isPulled_; }
      set {
        isPulled_ = value;
      }
    }

    /// <summary>Field number for the "image_size" field.</summary>
    public const int ImageSizeFieldNumber = 4;
    private long imageSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ImageSize {
      get { return imageSize_; }
      set {
        imageSize_ = value;
      }
    }

    /// <summary>Field number for the "pull_duration" field.</summary>
    public const int PullDurationFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Duration pullDuration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration PullDuration {
      get { return pullDuration_; }
      set {
        pullDuration_ = value;
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 6;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_trusted" field.</summary>
    public const int IsTrustedFieldNumber = 7;
    private bool isTrusted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsTrusted {
      get { return isTrusted_; }
      set {
        isTrusted_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildLogStepDockerImage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildLogStepDockerImage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Tag != other.Tag) return false;
      if (IsPulled != other.IsPulled) return false;
      if (ImageSize != other.ImageSize) return false;
      if (!object.Equals(PullDuration, other.PullDuration)) return false;
      if (Error != other.Error) return false;
      if (IsTrusted != other.IsTrusted) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (IsPulled != false) hash ^= IsPulled.GetHashCode();
      if (ImageSize != 0L) hash ^= ImageSize.GetHashCode();
      if (pullDuration_ != null) hash ^= PullDuration.GetHashCode();
      if (Error.Length != 0) hash ^= Error.GetHashCode();
      if (IsTrusted != false) hash ^= IsTrusted.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Tag);
      }
      if (IsPulled != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsPulled);
      }
      if (ImageSize != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ImageSize);
      }
      if (pullDuration_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PullDuration);
      }
      if (Error.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Error);
      }
      if (IsTrusted != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsTrusted);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (IsPulled != false) {
        size += 1 + 1;
      }
      if (ImageSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ImageSize);
      }
      if (pullDuration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PullDuration);
      }
      if (Error.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (IsTrusted != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildLogStepDockerImage other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.IsPulled != false) {
        IsPulled = other.IsPulled;
      }
      if (other.ImageSize != 0L) {
        ImageSize = other.ImageSize;
      }
      if (other.pullDuration_ != null) {
        if (pullDuration_ == null) {
          PullDuration = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        PullDuration.MergeFrom(other.PullDuration);
      }
      if (other.Error.Length != 0) {
        Error = other.Error;
      }
      if (other.IsTrusted != false) {
        IsTrusted = other.IsTrusted;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Tag = input.ReadString();
            break;
          }
          case 24: {
            IsPulled = input.ReadBool();
            break;
          }
          case 32: {
            ImageSize = input.ReadInt64();
            break;
          }
          case 42: {
            if (pullDuration_ == null) {
              PullDuration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(PullDuration);
            break;
          }
          case 50: {
            Error = input.ReadString();
            break;
          }
          case 56: {
            IsTrusted = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
