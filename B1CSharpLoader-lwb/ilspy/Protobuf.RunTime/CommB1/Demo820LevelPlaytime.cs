using System;
using Google.Protobuf;

namespace CommB1;

public sealed class Demo820LevelPlaytime : IMessage<Demo820LevelPlaytime>, IMessage, IEquatable<Demo820LevelPlaytime>, IDeepCloneable<Demo820LevelPlaytime>
{
	private static readonly MessageParser<Demo820LevelPlaytime> _parser = new MessageParser<Demo820LevelPlaytime>(() => new Demo820LevelPlaytime());

	private UnknownFieldSet _unknownFields;

	private int levelIndex_;

	private int playTime_;

	public static MessageParser<Demo820LevelPlaytime> Parser => _parser;

	public int LevelIndex
	{
		get
		{
			return levelIndex_;
		}
		set
		{
			levelIndex_ = value;
		}
	}

	public int PlayTime
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

	public Demo820LevelPlaytime()
	{
	}

	public Demo820LevelPlaytime(Demo820LevelPlaytime other)
		: this()
	{
		levelIndex_ = other.levelIndex_;
		playTime_ = other.playTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Demo820LevelPlaytime Clone()
	{
		return new Demo820LevelPlaytime(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Demo820LevelPlaytime);
	}

	public bool Equals(Demo820LevelPlaytime other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelIndex != other.LevelIndex)
		{
			return false;
		}
		if (PlayTime != other.PlayTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelIndex != 0)
		{
			num ^= LevelIndex.GetHashCode();
		}
		if (PlayTime != 0)
		{
			num ^= PlayTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelIndex != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LevelIndex);
		}
		if (PlayTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PlayTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelIndex);
		}
		if (PlayTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Demo820LevelPlaytime other)
	{
		if (other != null)
		{
			if (other.LevelIndex != 0)
			{
				LevelIndex = other.LevelIndex;
			}
			if (other.PlayTime != 0)
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
				LevelIndex = input.ReadInt32();
				break;
			case 16u:
				PlayTime = input.ReadInt32();
				break;
			}
		}
	}
}
