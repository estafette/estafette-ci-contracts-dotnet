// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contracts.v1/trusted_image_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Contracts.V1 {

  /// <summary>Holder for reflection information generated from contracts.v1/trusted_image_config.proto</summary>
  public static partial class TrustedImageConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for contracts.v1/trusted_image_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrustedImageConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidjb250cmFjdHMudjEvdHJ1c3RlZF9pbWFnZV9jb25maWcucHJvdG8SDGNv",
            "bnRyYWN0cy52MSKPAQoSVHJ1c3RlZEltYWdlQ29uZmlnEhIKCmltYWdlX3Bh",
            "dGgYASABKAkSFgoOcnVuX3ByaXZpbGVnZWQYAiABKAgSEgoKcnVuX2RvY2tl",
            "chgDIAEoCBIWCg5hbGxvd19jb21tYW5kcxgEIAEoCBIhChlpbmplY3RlZF9j",
            "cmVkZW50aWFsX3R5cGVzGAUgAygJQkFaP2dpdGh1Yi5jb20vZXN0YWZldHRl",
            "L2VzdGFmZXR0ZS1jaS1jb250cmFjdHMtZ29sYW5nL2NvbnRyYWN0c192MWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Contracts.V1.TrustedImageConfig), global::Contracts.V1.TrustedImageConfig.Parser, new[]{ "ImagePath", "RunPrivileged", "RunDocker", "AllowCommands", "InjectedCredentialTypes" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TrustedImageConfig : pb::IMessage<TrustedImageConfig> {
    private static readonly pb::MessageParser<TrustedImageConfig> _parser = new pb::MessageParser<TrustedImageConfig>(() => new TrustedImageConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TrustedImageConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contracts.V1.TrustedImageConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrustedImageConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrustedImageConfig(TrustedImageConfig other) : this() {
      imagePath_ = other.imagePath_;
      runPrivileged_ = other.runPrivileged_;
      runDocker_ = other.runDocker_;
      allowCommands_ = other.allowCommands_;
      injectedCredentialTypes_ = other.injectedCredentialTypes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrustedImageConfig Clone() {
      return new TrustedImageConfig(this);
    }

    /// <summary>Field number for the "image_path" field.</summary>
    public const int ImagePathFieldNumber = 1;
    private string imagePath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImagePath {
      get { return imagePath_; }
      set {
        imagePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "run_privileged" field.</summary>
    public const int RunPrivilegedFieldNumber = 2;
    private bool runPrivileged_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RunPrivileged {
      get { return runPrivileged_; }
      set {
        runPrivileged_ = value;
      }
    }

    /// <summary>Field number for the "run_docker" field.</summary>
    public const int RunDockerFieldNumber = 3;
    private bool runDocker_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RunDocker {
      get { return runDocker_; }
      set {
        runDocker_ = value;
      }
    }

    /// <summary>Field number for the "allow_commands" field.</summary>
    public const int AllowCommandsFieldNumber = 4;
    private bool allowCommands_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AllowCommands {
      get { return allowCommands_; }
      set {
        allowCommands_ = value;
      }
    }

    /// <summary>Field number for the "injected_credential_types" field.</summary>
    public const int InjectedCredentialTypesFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_injectedCredentialTypes_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> injectedCredentialTypes_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> InjectedCredentialTypes {
      get { return injectedCredentialTypes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TrustedImageConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TrustedImageConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ImagePath != other.ImagePath) return false;
      if (RunPrivileged != other.RunPrivileged) return false;
      if (RunDocker != other.RunDocker) return false;
      if (AllowCommands != other.AllowCommands) return false;
      if(!injectedCredentialTypes_.Equals(other.injectedCredentialTypes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ImagePath.Length != 0) hash ^= ImagePath.GetHashCode();
      if (RunPrivileged != false) hash ^= RunPrivileged.GetHashCode();
      if (RunDocker != false) hash ^= RunDocker.GetHashCode();
      if (AllowCommands != false) hash ^= AllowCommands.GetHashCode();
      hash ^= injectedCredentialTypes_.GetHashCode();
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
      if (ImagePath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ImagePath);
      }
      if (RunPrivileged != false) {
        output.WriteRawTag(16);
        output.WriteBool(RunPrivileged);
      }
      if (RunDocker != false) {
        output.WriteRawTag(24);
        output.WriteBool(RunDocker);
      }
      if (AllowCommands != false) {
        output.WriteRawTag(32);
        output.WriteBool(AllowCommands);
      }
      injectedCredentialTypes_.WriteTo(output, _repeated_injectedCredentialTypes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ImagePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImagePath);
      }
      if (RunPrivileged != false) {
        size += 1 + 1;
      }
      if (RunDocker != false) {
        size += 1 + 1;
      }
      if (AllowCommands != false) {
        size += 1 + 1;
      }
      size += injectedCredentialTypes_.CalculateSize(_repeated_injectedCredentialTypes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TrustedImageConfig other) {
      if (other == null) {
        return;
      }
      if (other.ImagePath.Length != 0) {
        ImagePath = other.ImagePath;
      }
      if (other.RunPrivileged != false) {
        RunPrivileged = other.RunPrivileged;
      }
      if (other.RunDocker != false) {
        RunDocker = other.RunDocker;
      }
      if (other.AllowCommands != false) {
        AllowCommands = other.AllowCommands;
      }
      injectedCredentialTypes_.Add(other.injectedCredentialTypes_);
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
            ImagePath = input.ReadString();
            break;
          }
          case 16: {
            RunPrivileged = input.ReadBool();
            break;
          }
          case 24: {
            RunDocker = input.ReadBool();
            break;
          }
          case 32: {
            AllowCommands = input.ReadBool();
            break;
          }
          case 42: {
            injectedCredentialTypes_.AddEntriesFrom(input, _repeated_injectedCredentialTypes_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
