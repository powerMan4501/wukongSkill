using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RefightStatistics : IMessage<RefightStatistics>, IMessage, IEquatable<RefightStatistics>, IDeepCloneable<RefightStatistics>
{
	private static readonly MessageParser<RefightStatistics> _parser = new MessageParser<RefightStatistics>(() => new RefightStatistics());

	private UnknownFieldSet _unknownFields;

	private EReChallengeLevel challengeLevel_;

	private uint battleCount_;

	public static MessageParser<RefightStatistics> Parser => _parser;

	public EReChallengeLevel ChallengeLevel
	{
		get
		{
			return challengeLevel_;
		}
		set
		{
			challengeLevel_ = value;
		}
	}

	public uint BattleCount
	{
		get
		{
			return battleCount_;
		}
		set
		{
			battleCount_ = value;
		}
	}

	public RefightStatistics()
	{
	}

	public RefightStatistics(RefightStatistics other)
		: this()
	{
		challengeLevel_ = other.challengeLevel_;
		battleCount_ = other.battleCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RefightStatistics Clone()
	{
		return new RefightStatistics(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RefightStatistics);
	}

	public bool Equals(RefightStatistics other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChallengeLevel != other.ChallengeLevel)
		{
			return false;
		}
		if (BattleCount != other.BattleCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ChallengeLevel != EReChallengeLevel.Default)
		{
			num ^= ChallengeLevel.GetHashCode();
		}
		if (BattleCount != 0)
		{
			num ^= BattleCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ChallengeLevel != EReChallengeLevel.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ChallengeLevel);
		}
		if (BattleCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BattleCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ChallengeLevel != EReChallengeLevel.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ChallengeLevel);
		}
		if (BattleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RefightStatistics other)
	{
		if (other != null)
		{
			if (other.ChallengeLevel != EReChallengeLevel.Default)
			{
				ChallengeLevel = other.ChallengeLevel;
			}
			if (other.BattleCount != 0)
			{
				BattleCount = other.BattleCount;
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
				ChallengeLevel = (EReChallengeLevel)input.ReadEnum();
				break;
			case 16u:
				BattleCount = input.ReadUInt32();
				break;
			}
		}
	}
}
