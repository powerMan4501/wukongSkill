using System;
using Google.Protobuf;

namespace GurGsReplicate;

public sealed class LevelBattleData : IMessage<LevelBattleData>, IMessage, IEquatable<LevelBattleData>, IDeepCloneable<LevelBattleData>
{
	private static readonly MessageParser<LevelBattleData> _parser = new MessageParser<LevelBattleData>(() => new LevelBattleData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int gamePlayerNum_;

	private int difficultBuffId_;

	public static MessageParser<LevelBattleData> Parser => _parser;

	public int GamePlayerNum
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return gamePlayerNum_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			gamePlayerNum_ = value;
		}
	}

	public bool HasGamePlayerNum => (_hasBits0 & 1) != 0;

	public int DifficultBuffId
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return difficultBuffId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			difficultBuffId_ = value;
		}
	}

	public bool HasDifficultBuffId => (_hasBits0 & 2) != 0;

	public LevelBattleData()
	{
	}

	public LevelBattleData(LevelBattleData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		gamePlayerNum_ = other.gamePlayerNum_;
		difficultBuffId_ = other.difficultBuffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelBattleData Clone()
	{
		return new LevelBattleData(this);
	}

	public void ClearGamePlayerNum()
	{
		_hasBits0 &= -2;
	}

	public void ClearDifficultBuffId()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelBattleData);
	}

	public bool Equals(LevelBattleData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GamePlayerNum != other.GamePlayerNum)
		{
			return false;
		}
		if (DifficultBuffId != other.DifficultBuffId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasGamePlayerNum)
		{
			num ^= GamePlayerNum.GetHashCode();
		}
		if (HasDifficultBuffId)
		{
			num ^= DifficultBuffId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasGamePlayerNum)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GamePlayerNum);
		}
		if (HasDifficultBuffId)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DifficultBuffId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasGamePlayerNum)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GamePlayerNum);
		}
		if (HasDifficultBuffId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DifficultBuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelBattleData other)
	{
		if (other != null)
		{
			if (other.HasGamePlayerNum)
			{
				GamePlayerNum = other.GamePlayerNum;
			}
			if (other.HasDifficultBuffId)
			{
				DifficultBuffId = other.DifficultBuffId;
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
				GamePlayerNum = input.ReadInt32();
				break;
			case 16u:
				DifficultBuffId = input.ReadInt32();
				break;
			}
		}
	}
}
