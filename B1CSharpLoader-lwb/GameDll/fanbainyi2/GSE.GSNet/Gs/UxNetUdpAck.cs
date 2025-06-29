using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetUdpAck : IMessage<UxNetUdpAck>, IMessage, IEquatable<UxNetUdpAck>, IDeepCloneable<UxNetUdpAck>
{
	private static readonly MessageParser<UxNetUdpAck> _parser = new MessageParser<UxNetUdpAck>(() => new UxNetUdpAck());

	private UnknownFieldSet _unknownFields;

	private int code_;

	public static MessageParser<UxNetUdpAck> Parser => _parser;

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

	public UxNetUdpAck()
	{
	}

	public UxNetUdpAck(UxNetUdpAck other)
		: this()
	{
		code_ = other.code_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetUdpAck Clone()
	{
		return new UxNetUdpAck(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetUdpAck);
	}

	public bool Equals(UxNetUdpAck other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Code != 0)
		{
			num ^= Code.GetHashCode();
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetUdpAck other)
	{
		if (other != null)
		{
			if (other.Code != 0)
			{
				Code = other.Code;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Code = input.ReadInt32();
			}
		}
	}
}
