using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkRet : IMessage<GssdkRet>, IMessage, IEquatable<GssdkRet>, IDeepCloneable<GssdkRet>
{
	private static readonly MessageParser<GssdkRet> _parser = new MessageParser<GssdkRet>(() => new GssdkRet());

	private UnknownFieldSet _unknownFields;

	private GssdkErrCode code_;

	private int subCode_;

	private string msg_ = "";

	public static MessageParser<GssdkRet> Parser => _parser;

	public GssdkErrCode Code
	{
		get
		{
			return code_;
		}
		set
		{
			code_ = value;
		}
	}

	public int SubCode
	{
		get
		{
			return subCode_;
		}
		set
		{
			subCode_ = value;
		}
	}

	public string Msg
	{
		get
		{
			return msg_;
		}
		set
		{
			msg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkRet()
	{
	}

	public GssdkRet(GssdkRet other)
		: this()
	{
		code_ = other.code_;
		subCode_ = other.subCode_;
		msg_ = other.msg_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkRet Clone()
	{
		return new GssdkRet(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkRet);
	}

	public bool Equals(GssdkRet other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Code != other.Code)
		{
			return false;
		}
		if (SubCode != other.SubCode)
		{
			return false;
		}
		if (Msg != other.Msg)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Code != GssdkErrCode.Success)
		{
			num ^= Code.GetHashCode();
		}
		if (SubCode != 0)
		{
			num ^= SubCode.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Code != GssdkErrCode.Success)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Code);
		}
		if (SubCode != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SubCode);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Msg);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Code != GssdkErrCode.Success)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Code);
		}
		if (SubCode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubCode);
		}
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkRet other)
	{
		if (other != null)
		{
			if (other.Code != GssdkErrCode.Success)
			{
				Code = other.Code;
			}
			if (other.SubCode != 0)
			{
				SubCode = other.SubCode;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
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
			case 8u:
				Code = (GssdkErrCode)input.ReadEnum();
				break;
			case 16u:
				SubCode = input.ReadInt32();
				break;
			case 26u:
				Msg = input.ReadString();
				break;
			}
		}
	}
}
