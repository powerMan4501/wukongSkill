using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class BossRushCastCount : IMessage<BossRushCastCount>, IMessage, IEquatable<BossRushCastCount>, IDeepCloneable<BossRushCastCount>
{
	private static readonly MessageParser<BossRushCastCount> _parser = new MessageParser<BossRushCastCount>(() => new BossRushCastCount());

	private UnknownFieldSet _unknownFields;

	private int castId_;

	private int castCount_;

	public static MessageParser<BossRushCastCount> Parser => _parser;

	public int CastId
	{
		get
		{
			return castId_;
		}
		set
		{
			castId_ = value;
		}
	}

	public int CastCount
	{
		get
		{
			return castCount_;
		}
		set
		{
			castCount_ = value;
		}
	}

	public BossRushCastCount()
	{
	}

	public BossRushCastCount(BossRushCastCount other)
		: this()
	{
		castId_ = other.castId_;
		castCount_ = other.castCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCastCount Clone()
	{
		return new BossRushCastCount(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCastCount);
	}

	public bool Equals(BossRushCastCount other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CastId != other.CastId)
		{
			return false;
		}
		if (CastCount != other.CastCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CastId != 0)
		{
			num ^= CastId.GetHashCode();
		}
		if (CastCount != 0)
		{
			num ^= CastCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CastId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CastId);
		}
		if (CastCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CastCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CastId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CastId);
		}
		if (CastCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CastCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCastCount other)
	{
		if (other != null)
		{
			if (other.CastId != 0)
			{
				CastId = other.CastId;
			}
			if (other.CastCount != 0)
			{
				CastCount = other.CastCount;
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
				CastId = input.ReadInt32();
				break;
			case 16u:
				CastCount = input.ReadInt32();
				break;
			}
		}
	}
}
