using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class ArchiveStaticsOne : IMessage<ArchiveStaticsOne>, IMessage, IEquatable<ArchiveStaticsOne>, IDeepCloneable<ArchiveStaticsOne>
{
	private static readonly MessageParser<ArchiveStaticsOne> _parser = new MessageParser<ArchiveStaticsOne>(() => new ArchiveStaticsOne());

	private UnknownFieldSet _unknownFields;

	private int gamePlusId_;

	private float gameTotalTime_;

	public static MessageParser<ArchiveStaticsOne> Parser => _parser;

	public int GamePlusId
	{
		get
		{
			return gamePlusId_;
		}
		set
		{
			gamePlusId_ = value;
		}
	}

	public float GameTotalTime
	{
		get
		{
			return gameTotalTime_;
		}
		set
		{
			gameTotalTime_ = value;
		}
	}

	public ArchiveStaticsOne()
	{
	}

	public ArchiveStaticsOne(ArchiveStaticsOne other)
		: this()
	{
		gamePlusId_ = other.gamePlusId_;
		gameTotalTime_ = other.gameTotalTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveStaticsOne Clone()
	{
		return new ArchiveStaticsOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveStaticsOne);
	}

	public bool Equals(ArchiveStaticsOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GamePlusId != other.GamePlusId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GameTotalTime, other.GameTotalTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GamePlusId != 0)
		{
			num ^= GamePlusId.GetHashCode();
		}
		if (GameTotalTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GameTotalTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GamePlusId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GamePlusId);
		}
		if (GameTotalTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(GameTotalTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GamePlusId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GamePlusId);
		}
		if (GameTotalTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveStaticsOne other)
	{
		if (other != null)
		{
			if (other.GamePlusId != 0)
			{
				GamePlusId = other.GamePlusId;
			}
			if (other.GameTotalTime != 0f)
			{
				GameTotalTime = other.GameTotalTime;
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
				GamePlusId = input.ReadInt32();
				break;
			case 21u:
				GameTotalTime = input.ReadFloat();
				break;
			}
		}
	}
}
