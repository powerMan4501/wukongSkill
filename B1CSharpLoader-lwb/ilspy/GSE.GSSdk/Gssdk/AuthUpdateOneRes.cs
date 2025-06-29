using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthUpdateOneRes : IMessage<AuthUpdateOneRes>, IMessage, IEquatable<AuthUpdateOneRes>, IDeepCloneable<AuthUpdateOneRes>
{
	private static readonly MessageParser<AuthUpdateOneRes> _parser = new MessageParser<AuthUpdateOneRes>(() => new AuthUpdateOneRes());

	private UnknownFieldSet _unknownFields;

	private int code_;

	private string msg_ = "";

	public static MessageParser<AuthUpdateOneRes> Parser => _parser;

	public int Code
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

	public AuthUpdateOneRes()
	{
	}

	public AuthUpdateOneRes(AuthUpdateOneRes other)
		: this()
	{
		code_ = other.code_;
		msg_ = other.msg_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthUpdateOneRes Clone()
	{
		return new AuthUpdateOneRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthUpdateOneRes);
	}

	public bool Equals(AuthUpdateOneRes other)
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
		if (Msg != other.Msg)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Code != 0)
		{
			num ^= Code.GetHashCode();
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
		if (Code != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Code);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag(18);
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
		if (Code != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Code);
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

	public void MergeFrom(AuthUpdateOneRes other)
	{
		if (other != null)
		{
			if (other.Code != 0)
			{
				Code = other.Code;
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
				Code = input.ReadInt32();
				break;
			case 18u:
				Msg = input.ReadString();
				break;
			}
		}
	}
}
