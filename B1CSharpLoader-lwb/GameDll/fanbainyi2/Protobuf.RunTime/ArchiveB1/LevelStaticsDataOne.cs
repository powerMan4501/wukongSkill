using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelStaticsDataOne : IMessage<LevelStaticsDataOne>, IMessage, IEquatable<LevelStaticsDataOne>, IDeepCloneable<LevelStaticsDataOne>
{
	private static readonly MessageParser<LevelStaticsDataOne> _parser = new MessageParser<LevelStaticsDataOne>(() => new LevelStaticsDataOne());

	private UnknownFieldSet _unknownFields;

	private int levelId_;

	private float playTime_;

	public static MessageParser<LevelStaticsDataOne> Parser => _parser;

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public float PlayTime
	{
		get
		{
			return playTime_;
		}
		set
		{
			playTime_ = value;
		}
	}

	public LevelStaticsDataOne()
	{
	}

	public LevelStaticsDataOne(LevelStaticsDataOne other)
		: this()
	{
		levelId_ = other.levelId_;
		playTime_ = other.playTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelStaticsDataOne Clone()
	{
		return new LevelStaticsDataOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelStaticsDataOne);
	}

	public bool Equals(LevelStaticsDataOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayTime, other.PlayTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (PlayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LevelId);
		}
		if (PlayTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(PlayTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (PlayTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelStaticsDataOne other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.PlayTime != 0f)
			{
				PlayTime = other.PlayTime;
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
				LevelId = input.ReadInt32();
				break;
			case 21u:
				PlayTime = input.ReadFloat();
				break;
			}
		}
	}
}
