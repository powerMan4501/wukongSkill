using System;
using ArchiveB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class BossRushBattleParam : IMessage<BossRushBattleParam>, IMessage, IEquatable<BossRushBattleParam>, IDeepCloneable<BossRushBattleParam>
{
	private static readonly MessageParser<BossRushBattleParam> _parser = new MessageParser<BossRushBattleParam>(() => new BossRushBattleParam());

	private UnknownFieldSet _unknownFields;

	private EBossRushType bossRushType_;

	private int targetId_;

	private EReChallengeLevel challengeLevel_;

	private static readonly FieldCodec<int> _repeated_debuffList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> debuffList_ = new RepeatedField<int>();

	private bool enableCooperation_;

	public static MessageParser<BossRushBattleParam> Parser => _parser;

	public EBossRushType BossRushType
	{
		get
		{
			return bossRushType_;
		}
		set
		{
			bossRushType_ = value;
		}
	}

	public int TargetId
	{
		get
		{
			return targetId_;
		}
		set
		{
			targetId_ = value;
		}
	}

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

	public RepeatedField<int> DebuffList => debuffList_;

	public bool EnableCooperation
	{
		get
		{
			return enableCooperation_;
		}
		set
		{
			enableCooperation_ = value;
		}
	}

	public BossRushBattleParam()
	{
	}

	public BossRushBattleParam(BossRushBattleParam other)
		: this()
	{
		bossRushType_ = other.bossRushType_;
		targetId_ = other.targetId_;
		challengeLevel_ = other.challengeLevel_;
		debuffList_ = other.debuffList_.Clone();
		enableCooperation_ = other.enableCooperation_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushBattleParam Clone()
	{
		return new BossRushBattleParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushBattleParam);
	}

	public bool Equals(BossRushBattleParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BossRushType != other.BossRushType)
		{
			return false;
		}
		if (TargetId != other.TargetId)
		{
			return false;
		}
		if (ChallengeLevel != other.ChallengeLevel)
		{
			return false;
		}
		if (!debuffList_.Equals(other.debuffList_))
		{
			return false;
		}
		if (EnableCooperation != other.EnableCooperation)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BossRushType != EBossRushType.None)
		{
			num ^= BossRushType.GetHashCode();
		}
		if (TargetId != 0)
		{
			num ^= TargetId.GetHashCode();
		}
		if (ChallengeLevel != EReChallengeLevel.Default)
		{
			num ^= ChallengeLevel.GetHashCode();
		}
		num ^= debuffList_.GetHashCode();
		if (EnableCooperation)
		{
			num ^= EnableCooperation.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BossRushType != EBossRushType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)BossRushType);
		}
		if (TargetId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TargetId);
		}
		if (ChallengeLevel != EReChallengeLevel.Default)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ChallengeLevel);
		}
		debuffList_.WriteTo(output, _repeated_debuffList_codec);
		if (EnableCooperation)
		{
			output.WriteRawTag(40);
			output.WriteBool(EnableCooperation);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BossRushType != EBossRushType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BossRushType);
		}
		if (TargetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetId);
		}
		if (ChallengeLevel != EReChallengeLevel.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ChallengeLevel);
		}
		num += debuffList_.CalculateSize(_repeated_debuffList_codec);
		if (EnableCooperation)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushBattleParam other)
	{
		if (other != null)
		{
			if (other.BossRushType != EBossRushType.None)
			{
				BossRushType = other.BossRushType;
			}
			if (other.TargetId != 0)
			{
				TargetId = other.TargetId;
			}
			if (other.ChallengeLevel != EReChallengeLevel.Default)
			{
				ChallengeLevel = other.ChallengeLevel;
			}
			debuffList_.Add(other.debuffList_);
			if (other.EnableCooperation)
			{
				EnableCooperation = other.EnableCooperation;
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
				BossRushType = (EBossRushType)input.ReadEnum();
				break;
			case 16u:
				TargetId = input.ReadInt32();
				break;
			case 24u:
				ChallengeLevel = (EReChallengeLevel)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				debuffList_.AddEntriesFrom(input, _repeated_debuffList_codec);
				break;
			case 40u:
				EnableCooperation = input.ReadBool();
				break;
			}
		}
	}
}
