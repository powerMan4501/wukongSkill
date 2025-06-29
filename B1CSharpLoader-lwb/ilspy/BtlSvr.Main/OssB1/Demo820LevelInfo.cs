using System;
using Google.Protobuf;

namespace OssB1;

public sealed class Demo820LevelInfo : IMessage<Demo820LevelInfo>, IMessage, IEquatable<Demo820LevelInfo>, IDeepCloneable<Demo820LevelInfo>
{
	private static readonly MessageParser<Demo820LevelInfo> _parser = new MessageParser<Demo820LevelInfo>(() => new Demo820LevelInfo());

	private UnknownFieldSet _unknownFields;

	private int levelId_;

	private int levelState_;

	private int playTimeTotal_;

	public static MessageParser<Demo820LevelInfo> Parser => _parser;

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

	public int LevelState
	{
		get
		{
			return levelState_;
		}
		set
		{
			levelState_ = value;
		}
	}

	public int PlayTimeTotal
	{
		get
		{
			return playTimeTotal_;
		}
		set
		{
			playTimeTotal_ = value;
		}
	}

	public Demo820LevelInfo()
	{
	}

	public Demo820LevelInfo(Demo820LevelInfo other)
		: this()
	{
		levelId_ = other.levelId_;
		levelState_ = other.levelState_;
		playTimeTotal_ = other.playTimeTotal_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Demo820LevelInfo Clone()
	{
		return new Demo820LevelInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Demo820LevelInfo);
	}

	public bool Equals(Demo820LevelInfo other)
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
		if (LevelState != other.LevelState)
		{
			return false;
		}
		if (PlayTimeTotal != other.PlayTimeTotal)
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
		if (LevelState != 0)
		{
			num ^= LevelState.GetHashCode();
		}
		if (PlayTimeTotal != 0)
		{
			num ^= PlayTimeTotal.GetHashCode();
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
		if (LevelState != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LevelState);
		}
		if (PlayTimeTotal != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PlayTimeTotal);
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
		if (LevelState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelState);
		}
		if (PlayTimeTotal != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayTimeTotal);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Demo820LevelInfo other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.LevelState != 0)
			{
				LevelState = other.LevelState;
			}
			if (other.PlayTimeTotal != 0)
			{
				PlayTimeTotal = other.PlayTimeTotal;
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
			case 16u:
				LevelState = input.ReadInt32();
				break;
			case 24u:
				PlayTimeTotal = input.ReadInt32();
				break;
			}
		}
	}
}
