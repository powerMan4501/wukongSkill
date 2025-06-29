using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ChapterPlayTime : IMessage<ChapterPlayTime>, IMessage, IEquatable<ChapterPlayTime>, IDeepCloneable<ChapterPlayTime>
{
	private static readonly MessageParser<ChapterPlayTime> _parser = new MessageParser<ChapterPlayTime>(() => new ChapterPlayTime());

	private UnknownFieldSet _unknownFields;

	private int chapterId_;

	private float playTime_;

	public static MessageParser<ChapterPlayTime> Parser => _parser;

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

	public ChapterPlayTime()
	{
	}

	public ChapterPlayTime(ChapterPlayTime other)
		: this()
	{
		chapterId_ = other.chapterId_;
		playTime_ = other.playTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChapterPlayTime Clone()
	{
		return new ChapterPlayTime(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChapterPlayTime);
	}

	public bool Equals(ChapterPlayTime other)
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

	public void MergeFrom(ChapterPlayTime other)
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
