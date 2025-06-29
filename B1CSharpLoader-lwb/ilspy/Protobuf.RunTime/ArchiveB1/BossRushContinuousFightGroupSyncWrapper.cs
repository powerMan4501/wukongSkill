using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class BossRushContinuousFightGroupSyncWrapper : IMessage<BossRushContinuousFightGroupSyncWrapper>, IMessage, IEquatable<BossRushContinuousFightGroupSyncWrapper>, IDeepCloneable<BossRushContinuousFightGroupSyncWrapper>
{
	private static readonly MessageParser<BossRushContinuousFightGroupSyncWrapper> _parser = new MessageParser<BossRushContinuousFightGroupSyncWrapper>(() => new BossRushContinuousFightGroupSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper bossGroupId_;

	private BoolSyncWrapper isPassed_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_lastDebuffList_codec = FieldCodec.ForMessage(42u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> lastDebuffList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<BossRushContinuousFightRecordSyncWrapper> _repeated_bestRecords_codec = FieldCodec.ForMessage(50u, BossRushContinuousFightRecordSyncWrapper.Parser);

	private readonly RepeatedField<BossRushContinuousFightRecordSyncWrapper> bestRecords_ = new RepeatedField<BossRushContinuousFightRecordSyncWrapper>();

	private Int32SyncWrapper encounterBossIndex_;

	private Uint32SyncWrapper battleCount_;

	public static MessageParser<BossRushContinuousFightGroupSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public Int32SyncWrapper BossGroupId
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

	public BoolSyncWrapper IsPassed
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

	public RepeatedField<Int32SyncWrapper> LastDebuffList => lastDebuffList_;

	public RepeatedField<BossRushContinuousFightRecordSyncWrapper> BestRecords => bestRecords_;

	public Int32SyncWrapper EncounterBossIndex
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

	public Uint32SyncWrapper BattleCount
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

	public BossRushContinuousFightGroupSyncWrapper()
	{
	}

	public BossRushContinuousFightGroupSyncWrapper(BossRushContinuousFightGroupSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		bossGroupId_ = ((other.bossGroupId_ != null) ? other.bossGroupId_.Clone() : null);
		isPassed_ = ((other.isPassed_ != null) ? other.isPassed_.Clone() : null);
		lastDebuffList_ = other.lastDebuffList_.Clone();
		bestRecords_ = other.bestRecords_.Clone();
		encounterBossIndex_ = ((other.encounterBossIndex_ != null) ? other.encounterBossIndex_.Clone() : null);
		battleCount_ = ((other.battleCount_ != null) ? other.battleCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushContinuousFightGroupSyncWrapper Clone()
	{
		return new BossRushContinuousFightGroupSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushContinuousFightGroupSyncWrapper);
	}

	public bool Equals(BossRushContinuousFightGroupSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(BossGroupId, other.BossGroupId))
		{
			return false;
		}
		if (!object.Equals(IsPassed, other.IsPassed))
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
		if (!object.Equals(EncounterBossIndex, other.EncounterBossIndex))
		{
			return false;
		}
		if (!object.Equals(BattleCount, other.BattleCount))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (bossGroupId_ != null)
		{
			num ^= BossGroupId.GetHashCode();
		}
		if (isPassed_ != null)
		{
			num ^= IsPassed.GetHashCode();
		}
		num ^= lastDebuffList_.GetHashCode();
		num ^= bestRecords_.GetHashCode();
		if (encounterBossIndex_ != null)
		{
			num ^= EncounterBossIndex.GetHashCode();
		}
		if (battleCount_ != null)
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
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (bossGroupId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BossGroupId);
		}
		if (isPassed_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(IsPassed);
		}
		lastDebuffList_.WriteTo(output, _repeated_lastDebuffList_codec);
		bestRecords_.WriteTo(output, _repeated_bestRecords_codec);
		if (encounterBossIndex_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(EncounterBossIndex);
		}
		if (battleCount_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BattleCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (bossGroupId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BossGroupId);
		}
		if (isPassed_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IsPassed);
		}
		num += lastDebuffList_.CalculateSize(_repeated_lastDebuffList_codec);
		num += bestRecords_.CalculateSize(_repeated_bestRecords_codec);
		if (encounterBossIndex_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EncounterBossIndex);
		}
		if (battleCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushContinuousFightGroupSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.bossGroupId_ != null)
		{
			if (bossGroupId_ == null)
			{
				BossGroupId = new Int32SyncWrapper();
			}
			BossGroupId.MergeFrom(other.BossGroupId);
		}
		if (other.isPassed_ != null)
		{
			if (isPassed_ == null)
			{
				IsPassed = new BoolSyncWrapper();
			}
			IsPassed.MergeFrom(other.IsPassed);
		}
		lastDebuffList_.Add(other.lastDebuffList_);
		bestRecords_.Add(other.bestRecords_);
		if (other.encounterBossIndex_ != null)
		{
			if (encounterBossIndex_ == null)
			{
				EncounterBossIndex = new Int32SyncWrapper();
			}
			EncounterBossIndex.MergeFrom(other.EncounterBossIndex);
		}
		if (other.battleCount_ != null)
		{
			if (battleCount_ == null)
			{
				BattleCount = new Uint32SyncWrapper();
			}
			BattleCount.MergeFrom(other.BattleCount);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (bossGroupId_ == null)
				{
					BossGroupId = new Int32SyncWrapper();
				}
				input.ReadMessage(BossGroupId);
				break;
			case 34u:
				if (isPassed_ == null)
				{
					IsPassed = new BoolSyncWrapper();
				}
				input.ReadMessage(IsPassed);
				break;
			case 42u:
				lastDebuffList_.AddEntriesFrom(input, _repeated_lastDebuffList_codec);
				break;
			case 50u:
				bestRecords_.AddEntriesFrom(input, _repeated_bestRecords_codec);
				break;
			case 58u:
				if (encounterBossIndex_ == null)
				{
					EncounterBossIndex = new Int32SyncWrapper();
				}
				input.ReadMessage(EncounterBossIndex);
				break;
			case 66u:
				if (battleCount_ == null)
				{
					BattleCount = new Uint32SyncWrapper();
				}
				input.ReadMessage(BattleCount);
				break;
			}
		}
	}
}
