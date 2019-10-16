// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: manifest.v1/estafette_builder.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Manifest.V1 {

  /// <summary>Holder for reflection information generated from manifest.v1/estafette_builder.proto</summary>
  public static partial class EstafetteBuilderReflection {

    #region Descriptor
    /// <summary>File descriptor for manifest.v1/estafette_builder.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EstafetteBuilderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNtYW5pZmVzdC52MS9lc3RhZmV0dGVfYnVpbGRlci5wcm90bxILbWFuaWZl",
            "c3QudjEiOwoQRXN0YWZldHRlQnVpbGRlchINCgV0cmFjaxgBIAEoCRIYChBv",
            "cGVyYXRpbmdfc3lzdGVtGAIgASgJQkBaPmdpdGh1Yi5jb20vZXN0YWZldHRl",
            "L2VzdGFmZXR0ZS1jaS1jb250cmFjdHMtZ29sYW5nL21hbmlmZXN0X3YxYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Manifest.V1.EstafetteBuilder), global::Manifest.V1.EstafetteBuilder.Parser, new[]{ "Track", "OperatingSystem" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EstafetteBuilder : pb::IMessage<EstafetteBuilder> {
    private static readonly pb::MessageParser<EstafetteBuilder> _parser = new pb::MessageParser<EstafetteBuilder>(() => new EstafetteBuilder());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EstafetteBuilder> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Manifest.V1.EstafetteBuilderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteBuilder() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteBuilder(EstafetteBuilder other) : this() {
      track_ = other.track_;
      operatingSystem_ = other.operatingSystem_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EstafetteBuilder Clone() {
      return new EstafetteBuilder(this);
    }

    /// <summary>Field number for the "track" field.</summary>
    public const int TrackFieldNumber = 1;
    private string track_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Track {
      get { return track_; }
      set {
        track_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operating_system" field.</summary>
    public const int OperatingSystemFieldNumber = 2;
    private string operatingSystem_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OperatingSystem {
      get { return operatingSystem_; }
      set {
        operatingSystem_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EstafetteBuilder);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EstafetteBuilder other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Track != other.Track) return false;
      if (OperatingSystem != other.OperatingSystem) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Track.Length != 0) hash ^= Track.GetHashCode();
      if (OperatingSystem.Length != 0) hash ^= OperatingSystem.GetHashCode();
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
      if (Track.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Track);
      }
      if (OperatingSystem.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OperatingSystem);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Track.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Track);
      }
      if (OperatingSystem.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OperatingSystem);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EstafetteBuilder other) {
      if (other == null) {
        return;
      }
      if (other.Track.Length != 0) {
        Track = other.Track;
      }
      if (other.OperatingSystem.Length != 0) {
        OperatingSystem = other.OperatingSystem;
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
            Track = input.ReadString();
            break;
          }
          case 18: {
            OperatingSystem = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
