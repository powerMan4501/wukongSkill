using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnWearAccessoryReq : IMessage<CSMsgActorUnWearAccessoryReq>, IMessage, IEquatable<CSMsgActorUnWearAccessoryReq>, IDeepCloneable<CSMsgActorUnWearAccessoryReq>
{
	private static readonly MessageParser<CSMsgActorUnWearAccessoryReq> _parser = new MessageParser<CSMsgActorUnWearAccessoryReq>(() => new CSMsgActorUnWearAccessoryReq());

	private UnknownFieldSet _unknownFields;

	private int pos_;

	private ulong uid_;

	public static MessageParser<CSMsgActorUnWearAccessoryReq> Parser => _parser;

	public int Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	public ulong Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	public CSMsgActorUnWearAccessoryReq()
	{
	}

	public CSMsgActorUnWearAccessoryReq(CSMsgActorUnWearAccessoryReq other)
		: this()
	{
		pos_ = other.pos_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnWearAccessoryReq Clone()
	{
		return new CSMsgActorUnWearAccessoryReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnWearAccessoryReq);
	}

	public bool Equals(CSMsgActorUnWearAccessoryReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (Uid != 0L)
		{
			num ^= Uid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Pos != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Pos);
		}
		if (Uid != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Uid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Pos);
		}
		if (Uid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorUnWearAccessoryReq other)
	{
		if (other != null)
		{
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.Uid != 0L)
			{
				Uid = other.Uid;
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
				Pos = input.ReadInt32();
				break;
			case 16u:
				Uid = input.ReadUInt64();
				break;
			}
		}
	}
}
