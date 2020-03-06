// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: estafette/ci/contracts/v1/git_commit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Estafette.Ci.Contracts.V1 {

  /// <summary>Holder for reflection information generated from estafette/ci/contracts/v1/git_commit.proto</summary>
  public static partial class GitCommitReflection {

    #region Descriptor
    /// <summary>File descriptor for estafette/ci/contracts/v1/git_commit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GitCommitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ciplc3RhZmV0dGUvY2kvY29udHJhY3RzL3YxL2dpdF9jb21taXQucHJvdG8S",
            "GWVzdGFmZXR0ZS5jaS5jb250cmFjdHMudjEaKmVzdGFmZXR0ZS9jaS9jb250",
            "cmFjdHMvdjEvZ2l0X2F1dGhvci5wcm90byJSCglHaXRDb21taXQSDwoHbWVz",
            "c2FnZRgBIAEoCRI0CgZhdXRob3IYAiABKAsyJC5lc3RhZmV0dGUuY2kuY29u",
            "dHJhY3RzLnYxLkdpdEF1dGhvckJ7Ch1jb20uZXN0YWZldHRlLmNpLmNvbnRy",
            "YWN0cy52MVABWjxnaXRodWIuY29tL2VzdGFmZXR0ZS9lc3RhZmV0dGUtY2kt",
            "cHJvdG9zLWdvbGFuZy9jb250cmFjdHMvdjGqAhlFc3RhZmV0dGUuQ2kuQ29u",
            "dHJhY3RzLlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Estafette.Ci.Contracts.V1.GitAuthorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Estafette.Ci.Contracts.V1.GitCommit), global::Estafette.Ci.Contracts.V1.GitCommit.Parser, new[]{ "Message", "Author" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GitCommit : pb::IMessage<GitCommit> {
    private static readonly pb::MessageParser<GitCommit> _parser = new pb::MessageParser<GitCommit>(() => new GitCommit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GitCommit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Estafette.Ci.Contracts.V1.GitCommitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GitCommit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GitCommit(GitCommit other) : this() {
      message_ = other.message_;
      author_ = other.author_ != null ? other.author_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GitCommit Clone() {
      return new GitCommit(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "author" field.</summary>
    public const int AuthorFieldNumber = 2;
    private global::Estafette.Ci.Contracts.V1.GitAuthor author_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Estafette.Ci.Contracts.V1.GitAuthor Author {
      get { return author_; }
      set {
        author_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GitCommit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GitCommit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (!object.Equals(Author, other.Author)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (author_ != null) hash ^= Author.GetHashCode();
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
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (author_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Author);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (author_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Author);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GitCommit other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.author_ != null) {
        if (author_ == null) {
          Author = new global::Estafette.Ci.Contracts.V1.GitAuthor();
        }
        Author.MergeFrom(other.Author);
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
            Message = input.ReadString();
            break;
          }
          case 18: {
            if (author_ == null) {
              Author = new global::Estafette.Ci.Contracts.V1.GitAuthor();
            }
            input.ReadMessage(Author);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
