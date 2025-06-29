using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetWaitReq : IMessage<UxNetWaitReq>, IMessage, IEquatable<UxNetWaitReq>, IDeepCloneable<UxNetWaitReq>
{
	private static readonly MessageParser<UxNetWaitReq> _parser = new MessageParser<UxNetWaitReq>(() => new UxNetWaitReq());

	private UnknownFieldSet _unknownFields;

	private uint dummy_;

	public static MessageParser<UxNetWaitReq> Parser => _parser;

	public uint Dummy
	{
		get
		{
			return dummy_;
		}
		set
		{
			dummy_ = value;
		}
	}

	public UxNetWaitReq()
	{
	}

	public UxNetWaitReq(UxNetWaitReq other)
		: this()
	{
		dummy_ = other.dummy_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetWaitReq Clone()
	{
		return new UxNetWaitReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetWaitReq);
	}

	public bool Equals(UxNetWaitReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Dummy != other.Dummy)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Dummy != 0)
		{
			num ^= Dummy.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Dummy != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Dummy);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Dummy != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Dummy);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetWaitReq other)
	{
		if (other != null)
		{
			if (other.Dummy != 0)
			{
				Dummy = other.Dummy;
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
				Dummy = input.ReadUInt32();
			}
		}
	}
}
