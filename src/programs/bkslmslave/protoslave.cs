// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace cmn {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Protoslave {

    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Extensions
    internal static readonly object Descriptor;
    static Protoslave() {
      Descriptor = null;
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ProtoSlaveReply : pb::GeneratedMessageLite<ProtoSlaveReply, ProtoSlaveReply.Builder> {
    private ProtoSlaveReply() { }
    private static readonly ProtoSlaveReply defaultInstance = new ProtoSlaveReply().MakeReadOnly();
    private static readonly string[] _protoSlaveReplyFieldNames = new string[] { "error", "result" };
    private static readonly uint[] _protoSlaveReplyFieldTags = new uint[] { 18, 10 };
    public static ProtoSlaveReply DefaultInstance {
      get { return defaultInstance; }
    }

    public override ProtoSlaveReply DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override ProtoSlaveReply ThisMessage {
      get { return this; }
    }

    public const int ResultFieldNumber = 1;
    private bool hasResult;
    private pb::ByteString result_ = pb::ByteString.Empty;
    public bool HasResult {
      get { return hasResult; }
    }
    public pb::ByteString Result {
      get { return result_; }
    }

    public const int ErrorFieldNumber = 2;
    private bool hasError;
    private pb::ByteString error_ = pb::ByteString.Empty;
    public bool HasError {
      get { return hasError; }
    }
    public pb::ByteString Error {
      get { return error_; }
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _protoSlaveReplyFieldNames;
      if (hasResult) {
        output.WriteBytes(1, field_names[1], Result);
      }
      if (hasError) {
        output.WriteBytes(2, field_names[0], Error);
      }
    }

    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }

    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;

      size = 0;
      if (hasResult) {
        size += pb::CodedOutputStream.ComputeBytesSize(1, Result);
      }
      if (hasError) {
        size += pb::CodedOutputStream.ComputeBytesSize(2, Error);
      }
      memoizedSerializedSize = size;
      return size;
    }
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasResult) hash ^= result_.GetHashCode();
      if (hasError) hash ^= error_.GetHashCode();
      return hash;
    }

    public override bool Equals(object obj) {
      ProtoSlaveReply other = obj as ProtoSlaveReply;
      if (other == null) return false;
      if (hasResult != other.hasResult || (hasResult && !result_.Equals(other.result_))) return false;
      if (hasError != other.hasError || (hasError && !error_.Equals(other.error_))) return false;
      return true;
    }

    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("result", hasResult, result_, writer);
      PrintField("error", hasError, error_, writer);
    }
    #endregion

    public static ProtoSlaveReply ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ProtoSlaveReply ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ProtoSlaveReply ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ProtoSlaveReply ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ProtoSlaveReply ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ProtoSlaveReply ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ProtoSlaveReply ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ProtoSlaveReply ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ProtoSlaveReply ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ProtoSlaveReply ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private ProtoSlaveReply MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ProtoSlaveReply prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilderLite<ProtoSlaveReply, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(ProtoSlaveReply cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private ProtoSlaveReply result;

      private ProtoSlaveReply PrepareBuilder() {
        if (resultIsReadOnly) {
          ProtoSlaveReply original = result;
          result = new ProtoSlaveReply();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override ProtoSlaveReply MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

      public override ProtoSlaveReply DefaultInstanceForType {
        get { return global::cmn.ProtoSlaveReply.DefaultInstance; }
      }

      public override ProtoSlaveReply BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is ProtoSlaveReply) {
          return MergeFrom((ProtoSlaveReply) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(ProtoSlaveReply other) {
        if (other == global::cmn.ProtoSlaveReply.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasResult) {
          Result = other.Result;
        }
        if (other.HasError) {
          Error = other.Error;
        }
        return this;
      }

      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_protoSlaveReplyFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _protoSlaveReplyFieldTags[field_ordinal];
            else {
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasResult = input.ReadBytes(ref result.result_);
              break;
            }
            case 18: {
              result.hasError = input.ReadBytes(ref result.error_);
              break;
            }
          }
        }

        return this;
      }


      public bool HasResult {
        get { return result.hasResult; }
      }
      public pb::ByteString Result {
        get { return result.Result; }
        set { SetResult(value); }
      }
      public Builder SetResult(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasResult = true;
        result.result_ = value;
        return this;
      }
      public Builder ClearResult() {
        PrepareBuilder();
        result.hasResult = false;
        result.result_ = pb::ByteString.Empty;
        return this;
      }

      public bool HasError {
        get { return result.hasError; }
      }
      public pb::ByteString Error {
        get { return result.Error; }
        set { SetError(value); }
      }
      public Builder SetError(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasError = true;
        result.error_ = value;
        return this;
      }
      public Builder ClearError() {
        PrepareBuilder();
        result.hasError = false;
        result.error_ = pb::ByteString.Empty;
        return this;
      }
    }
    static ProtoSlaveReply() {
      object.ReferenceEquals(global::cmn.Protoslave.Descriptor, null);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ProtoSlaveRequest : pb::GeneratedMessageLite<ProtoSlaveRequest, ProtoSlaveRequest.Builder> {
    private ProtoSlaveRequest() { }
    private static readonly ProtoSlaveRequest defaultInstance = new ProtoSlaveRequest().MakeReadOnly();
    private static readonly string[] _protoSlaveRequestFieldNames = new string[] { "function", "output", "parameter" };
    private static readonly uint[] _protoSlaveRequestFieldTags = new uint[] { 10, 16, 26 };
    public static ProtoSlaveRequest DefaultInstance {
      get { return defaultInstance; }
    }

    public override ProtoSlaveRequest DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override ProtoSlaveRequest ThisMessage {
      get { return this; }
    }

    public const int FunctionFieldNumber = 1;
    private bool hasFunction;
    private pb::ByteString function_ = pb::ByteString.Empty;
    public bool HasFunction {
      get { return hasFunction; }
    }
    public pb::ByteString Function {
      get { return function_; }
    }

    public const int OutputFieldNumber = 2;
    private bool hasOutput;
    private bool output_;
    public bool HasOutput {
      get { return hasOutput; }
    }
    public bool Output {
      get { return output_; }
    }

    public const int ParameterFieldNumber = 3;
    private pbc::PopsicleList<pb::ByteString> parameter_ = new pbc::PopsicleList<pb::ByteString>();
    public scg::IList<pb::ByteString> ParameterList {
      get { return pbc::Lists.AsReadOnly(parameter_); }
    }
    public int ParameterCount {
      get { return parameter_.Count; }
    }
    public pb::ByteString GetParameter(int index) {
      return parameter_[index];
    }

    public override bool IsInitialized {
      get {
        if (!hasFunction) return false;
        if (!hasOutput) return false;
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _protoSlaveRequestFieldNames;
      if (hasFunction) {
        output.WriteBytes(1, field_names[0], Function);
      }
      if (hasOutput) {
        output.WriteBool(2, field_names[1], Output);
      }
      if (parameter_.Count > 0) {
        output.WriteBytesArray(3, field_names[2], parameter_);
      }
    }

    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }

    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;

      size = 0;
      if (hasFunction) {
        size += pb::CodedOutputStream.ComputeBytesSize(1, Function);
      }
      if (hasOutput) {
        size += pb::CodedOutputStream.ComputeBoolSize(2, Output);
      }
      {
        int dataSize = 0;
        foreach (pb::ByteString element in ParameterList) {
          dataSize += pb::CodedOutputStream.ComputeBytesSizeNoTag(element);
        }
        size += dataSize;
        size += 1 * parameter_.Count;
      }
      memoizedSerializedSize = size;
      return size;
    }
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasFunction) hash ^= function_.GetHashCode();
      if (hasOutput) hash ^= output_.GetHashCode();
      foreach(pb::ByteString i in parameter_)
        hash ^= i.GetHashCode();
      return hash;
    }

    public override bool Equals(object obj) {
      ProtoSlaveRequest other = obj as ProtoSlaveRequest;
      if (other == null) return false;
      if (hasFunction != other.hasFunction || (hasFunction && !function_.Equals(other.function_))) return false;
      if (hasOutput != other.hasOutput || (hasOutput && !output_.Equals(other.output_))) return false;
      if(parameter_.Count != other.parameter_.Count) return false;
      for(int ix=0; ix < parameter_.Count; ix++)
        if(!parameter_[ix].Equals(other.parameter_[ix])) return false;
      return true;
    }

    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("function", hasFunction, function_, writer);
      PrintField("output", hasOutput, output_, writer);
      PrintField("parameter", parameter_, writer);
    }
    #endregion

    public static ProtoSlaveRequest ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ProtoSlaveRequest ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ProtoSlaveRequest ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ProtoSlaveRequest ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ProtoSlaveRequest ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ProtoSlaveRequest ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ProtoSlaveRequest ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ProtoSlaveRequest ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ProtoSlaveRequest ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ProtoSlaveRequest ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private ProtoSlaveRequest MakeReadOnly() {
      parameter_.MakeReadOnly();
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ProtoSlaveRequest prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilderLite<ProtoSlaveRequest, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(ProtoSlaveRequest cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private ProtoSlaveRequest result;

      private ProtoSlaveRequest PrepareBuilder() {
        if (resultIsReadOnly) {
          ProtoSlaveRequest original = result;
          result = new ProtoSlaveRequest();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override ProtoSlaveRequest MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

      public override ProtoSlaveRequest DefaultInstanceForType {
        get { return global::cmn.ProtoSlaveRequest.DefaultInstance; }
      }

      public override ProtoSlaveRequest BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is ProtoSlaveRequest) {
          return MergeFrom((ProtoSlaveRequest) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(ProtoSlaveRequest other) {
        if (other == global::cmn.ProtoSlaveRequest.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasFunction) {
          Function = other.Function;
        }
        if (other.HasOutput) {
          Output = other.Output;
        }
        if (other.parameter_.Count != 0) {
          result.parameter_.Add(other.parameter_);
        }
        return this;
      }

      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_protoSlaveRequestFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _protoSlaveRequestFieldTags[field_ordinal];
            else {
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasFunction = input.ReadBytes(ref result.function_);
              break;
            }
            case 16: {
              result.hasOutput = input.ReadBool(ref result.output_);
              break;
            }
            case 26: {
              input.ReadBytesArray(tag, field_name, result.parameter_);
              break;
            }
          }
        }

        return this;
      }


      public bool HasFunction {
        get { return result.hasFunction; }
      }
      public pb::ByteString Function {
        get { return result.Function; }
        set { SetFunction(value); }
      }
      public Builder SetFunction(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasFunction = true;
        result.function_ = value;
        return this;
      }
      public Builder ClearFunction() {
        PrepareBuilder();
        result.hasFunction = false;
        result.function_ = pb::ByteString.Empty;
        return this;
      }

      public bool HasOutput {
        get { return result.hasOutput; }
      }
      public bool Output {
        get { return result.Output; }
        set { SetOutput(value); }
      }
      public Builder SetOutput(bool value) {
        PrepareBuilder();
        result.hasOutput = true;
        result.output_ = value;
        return this;
      }
      public Builder ClearOutput() {
        PrepareBuilder();
        result.hasOutput = false;
        result.output_ = false;
        return this;
      }

      public pbc::IPopsicleList<pb::ByteString> ParameterList {
        get { return PrepareBuilder().parameter_; }
      }
      public int ParameterCount {
        get { return result.ParameterCount; }
      }
      public pb::ByteString GetParameter(int index) {
        return result.GetParameter(index);
      }
      public Builder SetParameter(int index, pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.parameter_[index] = value;
        return this;
      }
      public Builder AddParameter(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.parameter_.Add(value);
        return this;
      }
      public Builder AddRangeParameter(scg::IEnumerable<pb::ByteString> values) {
        PrepareBuilder();
        result.parameter_.Add(values);
        return this;
      }
      public Builder ClearParameter() {
        PrepareBuilder();
        result.parameter_.Clear();
        return this;
      }
    }
    static ProtoSlaveRequest() {
      object.ReferenceEquals(global::cmn.Protoslave.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code