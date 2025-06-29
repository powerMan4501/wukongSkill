using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushContinuousFightGroup : IMessage<BossRushContinuousFightGroup>, IMessage, IEquatable<BossRushContinuousFightGroup>, IDeepCloneable<BossRushContinuousFightGroup>
{
	private static readonly MessageParser<BossRushContinuousFightGroup> _parser = new MessageParser<BossRushContinuousFightGroup>(() => new BossRushContinuousFightGroup());

	private UnknownFieldSet _unknownFields;

	private int bossGroupId_;

	private bool isPassed_;

	private static readonly FieldCodec<int> _repeated_lastDebuffList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> lastDebuffList_ = new RepeatedField<int>();

	private static readonly FieldCodec<BossRushContinuousFightRecord> _repeated_bestRecords_codec = FieldCodec.ForMessage(34u, BossRushContinuousFightRecord.Parser);

	private readonly RepeatedField<BossRushContinuousFightRecord> bestRecords_ = new RepeatedField<BossRushContinuousFightRecord>();

	private int encounterBossIndex_;

	private uint battleCount_;

	public static MessageParser<BossRushContinuousFightGroup> Parser => _parser;

	public int BossGroupId
	{
		get
		{
			return bossGroupId_;
		}
		set
		{
			bossGroupId_ = value;
		}
	}

	public bool IsPassed
	{
		get
		{
			return isPassed_;
		}
		set
		{
			isPassed_ = value;
		}
	}

	public RepeatedField<int> LastDebuffList => lastDebuffList_;

	public RepeatedField<BossRushContinuousFightRecord> BestRecords => bestRecords_;

	public int EncounterBossIndex
	{
		get
		{
			return encounterBossIndex_;
		}
		set
		{
			encounterBossIndex_ = value;
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

	public BossRushContinuousFightGroup()
	{
	}

	public BossRushContinuousFightGroup(BossRushContinuousFightGroup other)
		: this()
	{
		bossGroupId_ = other.bossGroupId_;
		isPassed_ = other.isPassed_;
		lastDebuffList_ = other.lastDebuffList_.Clone();
		bestRecords_ = other.bestRecords_.Clone();
		encounterBossIndex_ = other.encounterBossIndex_;
		battleCount_ = other.battleCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushContinuousFightGroup Clone()
	{
		return new BossRushContinuousFightGroup(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushContinuousFightGroup);
	}

	public bool Equals(BossRushContinuousFightGroup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BossGroupId != other.BossGroupId)
		{
			return false;
		}
		if (IsPassed != other.IsPassed)
		{
			return false;
		}
		if (!lastDebuffList_.Equals(other.lastDebuffList_))
		{
			return false;
		}
		if (!bestRecords_.Equals(other.bestRecords_))
		{
			return false;
		}
		if (EncounterBossIndex != other.EncounterBossIndex)
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
		if (BossGroupId != 0)
		{
			num ^= BossGroupId.GetHashCode();
		}
		if (IsPassed)
		{
			num ^= IsPassed.GetHashCode();
		}
		num ^= lastDebuffList_.GetHashCode();
		num ^= bestRecords_.GetHashCode();
		if (EncounterBossIndex != 0)
		{
			num ^= EncounterBossIndex.GetHashCode();
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
		if (BossGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BossGroupId);
		}
		if (IsPassed)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsPassed);
		}
		lastDebuffList_.WriteTo(output, _repeated_lastDebuffList_codec);
		bestRecords_.WriteTo(output, _repeated_bestRecords_codec);
		if (EncounterBossIndex != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EncounterBossIndex);
		}
		if (BattleCount != 0)
		{
			output.WriteRawTag(48);
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
		if (BossGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossGroupId);
		}
		if (IsPassed)
		{
			num += 2;
		}
		num += lastDebuffList_.CalculateSize(_repeated_lastDebuffList_codec);
		num += bestRecords_.CalculateSize(_repeated_bestRecords_codec);
		if (EncounterBossIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EncounterBossIndex);
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

	public void MergeFrom(BossRushContinuousFightGroup other)
	{
		if (other != null)
		{
			if (other.BossGroupId != 0)
			{
				BossGroupId = other.BossGroupId;
			}
			if (other.IsPassed)
			{
				IsPassed = other.IsPassed;
			}
			lastDebuffList_.Add(other.lastDebuffList_);
			bestRecords_.Add(other.bestRecords_);
			if (other.EncounterBossIndex != 0)
			{
				EncounterBossIndex = other.EncounterBossIndex;
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
				BossGroupId = input.ReadInt32();
				break;
			case 16u:
				IsPassed = input.ReadBool();
				break;
			case 24u:
			case 26u:
				lastDebuffList_.AddEntriesFrom(input, _repeated_lastDebuffList_codec);
				break;
			case 34u:
				bestRecords_.AddEntriesFrom(input, _repeated_bestRecords_codec);
				break;
			case 40u:
				EncounterBossIndex = input.ReadInt32();
				break;
			case 48u:
				BattleCount = input.ReadUInt32();
				break;
			}
		}
	}
}
