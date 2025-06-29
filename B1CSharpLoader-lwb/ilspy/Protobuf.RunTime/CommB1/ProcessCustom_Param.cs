using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessCustom_Param : IMessage<ProcessCustom_Param>, IMessage, IEquatable<ProcessCustom_Param>, IDeepCloneable<ProcessCustom_Param>
{
	private static readonly MessageParser<ProcessCustom_Param> _parser = new MessageParser<ProcessCustom_Param>(() => new ProcessCustom_Param());

	private UnknownFieldSet _unknownFields;

	private int paramType_;

	private string paramGuid_ = "";

	private string paramString_ = "";

	private int paramInt_;

	private string paramLinkInt_ = "";

	private string paramLinkString_ = "";

	private string paramAliasName_ = "";

	private static readonly FieldCodec<ProcessCustom_SubParam> _repeated_paramSubList_codec = FieldCodec.ForMessage(66u, ProcessCustom_SubParam.Parser);

	private readonly RepeatedField<ProcessCustom_SubParam> paramSubList_ = new RepeatedField<ProcessCustom_SubParam>();

	public static MessageParser<ProcessCustom_Param> Parser => _parser;

	public int ParamType
	{
		get
		{
			return paramType_;
		}
		set
		{
			paramType_ = value;
		}
	}

	public string ParamGuid
	{
		get
		{
			return paramGuid_;
		}
		set
		{
			paramGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ParamString
	{
		get
		{
			return paramString_;
		}
		set
		{
			paramString_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ParamInt
	{
		get
		{
			return paramInt_;
		}
		set
		{
			paramInt_ = value;
		}
	}

	public string ParamLinkInt
	{
		get
		{
			return paramLinkInt_;
		}
		set
		{
			paramLinkInt_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ParamLinkString
	{
		get
		{
			return paramLinkString_;
		}
		set
		{
			paramLinkString_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ParamAliasName
	{
		get
		{
			return paramAliasName_;
		}
		set
		{
			paramAliasName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<ProcessCustom_SubParam> ParamSubList => paramSubList_;

	public ProcessCustom_Param()
	{
	}

	public ProcessCustom_Param(ProcessCustom_Param other)
		: this()
	{
		paramType_ = other.paramType_;
		paramGuid_ = other.paramGuid_;
		paramString_ = other.paramString_;
		paramInt_ = other.paramInt_;
		paramLinkInt_ = other.paramLinkInt_;
		paramLinkString_ = other.paramLinkString_;
		paramAliasName_ = other.paramAliasName_;
		paramSubList_ = other.paramSubList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_Param Clone()
	{
		return new ProcessCustom_Param(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_Param);
	}

	public bool Equals(ProcessCustom_Param other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ParamType != other.ParamType)
		{
			return false;
		}
		if (ParamGuid != other.ParamGuid)
		{
			return false;
		}
		if (ParamString != other.ParamString)
		{
			return false;
		}
		if (ParamInt != other.ParamInt)
		{
			return false;
		}
		if (ParamLinkInt != other.ParamLinkInt)
		{
			return false;
		}
		if (ParamLinkString != other.ParamLinkString)
		{
			return false;
		}
		if (ParamAliasName != other.ParamAliasName)
		{
			return false;
		}
		if (!paramSubList_.Equals(other.paramSubList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ParamType != 0)
		{
			num ^= ParamType.GetHashCode();
		}
		if (ParamGuid.Length != 0)
		{
			num ^= ParamGuid.GetHashCode();
		}
		if (ParamString.Length != 0)
		{
			num ^= ParamString.GetHashCode();
		}
		if (ParamInt != 0)
		{
			num ^= ParamInt.GetHashCode();
		}
		if (ParamLinkInt.Length != 0)
		{
			num ^= ParamLinkInt.GetHashCode();
		}
		if (ParamLinkString.Length != 0)
		{
			num ^= ParamLinkString.GetHashCode();
		}
		if (ParamAliasName.Length != 0)
		{
			num ^= ParamAliasName.GetHashCode();
		}
		num ^= paramSubList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ParamType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ParamType);
		}
		if (ParamGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ParamGuid);
		}
		if (ParamString.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ParamString);
		}
		if (ParamInt != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ParamInt);
		}
		if (ParamLinkInt.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ParamLinkInt);
		}
		if (ParamLinkString.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(ParamLinkString);
		}
		if (ParamAliasName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(ParamAliasName);
		}
		paramSubList_.WriteTo(output, _repeated_paramSubList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ParamType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ParamType);
		}
		if (ParamGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamGuid);
		}
		if (ParamString.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamString);
		}
		if (ParamInt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ParamInt);
		}
		if (ParamLinkInt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamLinkInt);
		}
		if (ParamLinkString.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamLinkString);
		}
		if (ParamAliasName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamAliasName);
		}
		num += paramSubList_.CalculateSize(_repeated_paramSubList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_Param other)
	{
		if (other != null)
		{
			if (other.ParamType != 0)
			{
				ParamType = other.ParamType;
			}
			if (other.ParamGuid.Length != 0)
			{
				ParamGuid = other.ParamGuid;
			}
			if (other.ParamString.Length != 0)
			{
				ParamString = other.ParamString;
			}
			if (other.ParamInt != 0)
			{
				ParamInt = other.ParamInt;
			}
			if (other.ParamLinkInt.Length != 0)
			{
				ParamLinkInt = other.ParamLinkInt;
			}
			if (other.ParamLinkString.Length != 0)
			{
				ParamLinkString = other.ParamLinkString;
			}
			if (other.ParamAliasName.Length != 0)
			{
				ParamAliasName = other.ParamAliasName;
			}
			paramSubList_.Add(other.paramSubList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				ParamType = input.ReadInt32();
				break;
			case 18u:
				ParamGuid = input.ReadString();
				break;
			case 26u:
				ParamString = input.ReadString();
				break;
			case 32u:
				ParamInt = input.ReadInt32();
				break;
			case 42u:
				ParamLinkInt = input.ReadString();
				break;
			case 50u:
				ParamLinkString = input.ReadString();
				break;
			case 58u:
				ParamAliasName = input.ReadString();
				break;
			case 66u:
				paramSubList_.AddEntriesFrom(input, _repeated_paramSubList_codec);
				break;
			}
		}
	}
}
