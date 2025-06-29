using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessCustom_SubParam : IMessage<ProcessCustom_SubParam>, IMessage, IEquatable<ProcessCustom_SubParam>, IDeepCloneable<ProcessCustom_SubParam>
{
	private static readonly MessageParser<ProcessCustom_SubParam> _parser = new MessageParser<ProcessCustom_SubParam>(() => new ProcessCustom_SubParam());

	private UnknownFieldSet _unknownFields;

	private string paramGuid_ = "";

	private string paramString_ = "";

	private string paramAliasName_ = "";

	public static MessageParser<ProcessCustom_SubParam> Parser => _parser;

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

	public ProcessCustom_SubParam()
	{
	}

	public ProcessCustom_SubParam(ProcessCustom_SubParam other)
		: this()
	{
		paramGuid_ = other.paramGuid_;
		paramString_ = other.paramString_;
		paramAliasName_ = other.paramAliasName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_SubParam Clone()
	{
		return new ProcessCustom_SubParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_SubParam);
	}

	public bool Equals(ProcessCustom_SubParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ParamGuid != other.ParamGuid)
		{
			return false;
		}
		if (ParamString != other.ParamString)
		{
			return false;
		}
		if (ParamAliasName != other.ParamAliasName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ParamGuid.Length != 0)
		{
			num ^= ParamGuid.GetHashCode();
		}
		if (ParamString.Length != 0)
		{
			num ^= ParamString.GetHashCode();
		}
		if (ParamAliasName.Length != 0)
		{
			num ^= ParamAliasName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ParamGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ParamGuid);
		}
		if (ParamString.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ParamString);
		}
		if (ParamAliasName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ParamAliasName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ParamGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamGuid);
		}
		if (ParamString.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamString);
		}
		if (ParamAliasName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParamAliasName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_SubParam other)
	{
		if (other != null)
		{
			if (other.ParamGuid.Length != 0)
			{
				ParamGuid = other.ParamGuid;
			}
			if (other.ParamString.Length != 0)
			{
				ParamString = other.ParamString;
			}
			if (other.ParamAliasName.Length != 0)
			{
				ParamAliasName = other.ParamAliasName;
			}
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
			case 10u:
				ParamGuid = input.ReadString();
				break;
			case 18u:
				ParamString = input.ReadString();
				break;
			case 26u:
				ParamAliasName = input.ReadString();
				break;
			}
		}
	}
}
