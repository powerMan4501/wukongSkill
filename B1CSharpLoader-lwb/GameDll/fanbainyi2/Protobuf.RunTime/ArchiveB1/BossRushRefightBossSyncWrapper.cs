using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class BossRushRefightBossSyncWrapper : IMessage<BossRushRefightBossSyncWrapper>, IMessage, IEquatable<BossRushRefightBossSyncWrapper>, IDeepCloneable<BossRushRefightBossSyncWrapper>
{
	private static readonly MessageParser<BossRushRefightBossSyncWrapper> _parser = new MessageParser<BossRushRefightBossSyncWrapper>(() => new BossRushRefightBossSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper bossId_;

	private EReChallengeLevelSyncWrapper passedMaxLevel_;

	private EReChallengeLevelSyncWrapper lastChallengeLevel_;

	private static readonly FieldCodec<BossRushRefightRecordSyncWrapper> _repeated_bestRecords_codec = FieldCodec.ForMessage(50u, BossRushRefightRecordSyncWrapper.Parser);

	private readonly RepeatedField<BossRushRefightRecordSyncWrapper> bestRecords_ = new RepeatedField<BossRushRefightRecordSyncWrapper>();

	private ECooperativeStatusSyncWrapper cooperativeStatus_;

	private static readonly FieldCodec<RefightStatisticsSyncWrapper> _repeated_refightStatisticsList_codec = FieldCodec.ForMessage(66u, RefightStatisticsSyncWrapper.Parser);

	private readonly RepeatedField<RefightStatisticsSyncWrapper> refightStatisticsList_ = new RepeatedField<RefightStatisticsSyncWrapper>();

	public static MessageParser<BossRushRefightBossSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper BossId
	{
		get
		{
			return bossId_;
		}
		set
		{
			bossId_ = value;
		}
	}

	public EReChallengeLevelSyncWrapper PassedMaxLevel
	{
		get
		{
			return passedMaxLevel_;
		}
		set
		{
			passedMaxLevel_ = value;
		}
	}

	public EReChallengeLevelSyncWrapper LastChallengeLevel
	{
		get
		{
			return lastChallengeLevel_;
		}
		set
		{
			lastChallengeLevel_ = value;
		}
	}

	public RepeatedField<BossRushRefightRecordSyncWrapper> BestRecords => bestRecords_;

	public ECooperativeStatusSyncWrapper CooperativeStatus
	{
		get
		{
			return cooperativeStatus_;
		}
		set
		{
			cooperativeStatus_ = value;
		}
	}

	public RepeatedField<RefightStatisticsSyncWrapper> RefightStatisticsList => refightStatisticsList_;

	public BossRushRefightBossSyncWrapper()
	{
	}

	public BossRushRefightBossSyncWrapper(BossRushRefightBossSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		bossId_ = ((other.bossId_ != null) ? other.bossId_.Clone() : null);
		passedMaxLevel_ = ((other.passedMaxLevel_ != null) ? other.passedMaxLevel_.Clone() : null);
		lastChallengeLevel_ = ((other.lastChallengeLevel_ != null) ? other.lastChallengeLevel_.Clone() : null);
		bestRecords_ = other.bestRecords_.Clone();
		cooperativeStatus_ = ((other.cooperativeStatus_ != null) ? other.cooperativeStatus_.Clone() : null);
		refightStatisticsList_ = other.refightStatisticsList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushRefightBossSyncWrapper Clone()
	{
		return new BossRushRefightBossSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushRefightBossSyncWrapper);
	}

	public bool Equals(BossRushRefightBossSyncWrapper other)
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
		if (!object.Equals(BossId, other.BossId))
		{
			return false;
		}
		if (!object.Equals(PassedMaxLevel, other.PassedMaxLevel))
		{
			return false;
		}
		if (!object.Equals(LastChallengeLevel, other.LastChallengeLevel))
		{
			return false;
		}
		if (!bestRecords_.Equals(other.bestRecords_))
		{
			return false;
		}
		if (!object.Equals(CooperativeStatus, other.CooperativeStatus))
		{
			return false;
		}
		if (!refightStatisticsList_.Equals(other.refightStatisticsList_))
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
		if (bossId_ != null)
		{
			num ^= BossId.GetHashCode();
		}
		if (passedMaxLevel_ != null)
		{
			num ^= PassedMaxLevel.GetHashCode();
		}
		if (lastChallengeLevel_ != null)
		{
			num ^= LastChallengeLevel.GetHashCode();
		}
		num ^= bestRecords_.GetHashCode();
		if (cooperativeStatus_ != null)
		{
			num ^= CooperativeStatus.GetHashCode();
		}
		num ^= refightStatisticsList_.GetHashCode();
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
		if (bossId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BossId);
		}
		if (passedMaxLevel_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PassedMaxLevel);
		}
		if (lastChallengeLevel_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(LastChallengeLevel);
		}
		bestRecords_.WriteTo(output, _repeated_bestRecords_codec);
		if (cooperativeStatus_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(CooperativeStatus);
		}
		refightStatisticsList_.WriteTo(output, _repeated_refightStatisticsList_codec);
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
		if (bossId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BossId);
		}
		if (passedMaxLevel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PassedMaxLevel);
		}
		if (lastChallengeLevel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastChallengeLevel);
		}
		num += bestRecords_.CalculateSize(_repeated_bestRecords_codec);
		if (cooperativeStatus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CooperativeStatus);
		}
		num += refightStatisticsList_.CalculateSize(_repeated_refightStatisticsList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushRefightBossSyncWrapper other)
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
		if (other.bossId_ != null)
		{
			if (bossId_ == null)
			{
				BossId = new Int32SyncWrapper();
			}
			BossId.MergeFrom(other.BossId);
		}
		if (other.passedMaxLevel_ != null)
		{
			if (passedMaxLevel_ == null)
			{
				PassedMaxLevel = new EReChallengeLevelSyncWrapper();
			}
			PassedMaxLevel.MergeFrom(other.PassedMaxLevel);
		}
		if (other.lastChallengeLevel_ != null)
		{
			if (lastChallengeLevel_ == null)
			{
				LastChallengeLevel = new EReChallengeLevelSyncWrapper();
			}
			LastChallengeLevel.MergeFrom(other.LastChallengeLevel);
		}
		bestRecords_.Add(other.bestRecords_);
		if (other.cooperativeStatus_ != null)
		{
			if (cooperativeStatus_ == null)
			{
				CooperativeStatus = new ECooperativeStatusSyncWrapper();
			}
			CooperativeStatus.MergeFrom(other.CooperativeStatus);
		}
		refightStatisticsList_.Add(other.refightStatisticsList_);
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
				if (bossId_ == null)
				{
					BossId = new Int32SyncWrapper();
				}
				input.ReadMessage(BossId);
				break;
			case 34u:
				if (passedMaxLevel_ == null)
				{
					PassedMaxLevel = new EReChallengeLevelSyncWrapper();
				}
				input.ReadMessage(PassedMaxLevel);
				break;
			case 42u:
				if (lastChallengeLevel_ == null)
				{
					LastChallengeLevel = new EReChallengeLevelSyncWrapper();
				}
				input.ReadMessage(LastChallengeLevel);
				break;
			case 50u:
				bestRecords_.AddEntriesFrom(input, _repeated_bestRecords_codec);
				break;
			case 58u:
				if (cooperativeStatus_ == null)
				{
					CooperativeStatus = new ECooperativeStatusSyncWrapper();
				}
				input.ReadMessage(CooperativeStatus);
				break;
			case 66u:
				refightStatisticsList_.AddEntriesFrom(input, _repeated_refightStatisticsList_codec);
				break;
			}
		}
	}
}
