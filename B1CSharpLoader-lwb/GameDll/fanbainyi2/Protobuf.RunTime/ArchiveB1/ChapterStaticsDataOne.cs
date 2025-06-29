using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class ChapterStaticsDataOne : IMessage<ChapterStaticsDataOne>, IMessage, IEquatable<ChapterStaticsDataOne>, IDeepCloneable<ChapterStaticsDataOne>
{
	private static readonly MessageParser<ChapterStaticsDataOne> _parser = new MessageParser<ChapterStaticsDataOne>(() => new ChapterStaticsDataOne());

	private UnknownFieldSet _unknownFields;

	private int chapterId_;

	private float playTime_;

	public static MessageParser<ChapterStaticsDataOne> Parser => _parser;

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
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

	public ChapterStaticsDataOne()
	{
	}

	public ChapterStaticsDataOne(ChapterStaticsDataOne other)
		: this()
	{
		chapterId_ = other.chapterId_;
		playTime_ = other.playTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChapterStaticsDataOne Clone()
	{
		return new ChapterStaticsDataOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChapterStaticsDataOne);
	}

	public bool Equals(ChapterStaticsDataOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChapterId != other.ChapterId)
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
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
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
		if (ChapterId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ChapterId);
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
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
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

	public void MergeFrom(ChapterStaticsDataOne other)
	{
		if (other != null)
		{
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
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
				ChapterId = input.ReadInt32();
				break;
			case 21u:
				PlayTime = input.ReadFloat();
				break;
			}
		}
	}
}
