using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class BossRushBattleDataSyncWrapper : IMessage<BossRushBattleDataSyncWrapper>, IMessage, IEquatable<BossRushBattleDataSyncWrapper>, IDeepCloneable<BossRushBattleDataSyncWrapper>
{
	private static readonly MessageParser<BossRushBattleDataSyncWrapper> _parser = new MessageParser<BossRushBattleDataSyncWrapper>(() => new BossRushBattleDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private FloatSyncWrapper totalTime_;

	private Int32SyncWrapper score_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_debuffList_codec = FieldCodec.ForMessage(42u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> debuffList_ = new RepeatedField<Int32SyncWrapper>();

	private Int32SyncWrapper targetId_;

	private Uint64SyncWrapper archiveTime_;

	private BossRushRoleBaseSyncWrapper roleBase_;

	private BossRushBattleStyleSyncWrapper battleStyleInfo_;

	private BossRushDamageInfoSyncWrapper damageInfo_;

	public static MessageParser<BossRushBattleDataSyncWrapper> Parser => _parser;

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

	public FloatSyncWrapper TotalTime
	{
		get
		{
			return totalTime_;
		}
		set
		{
			totalTime_ = value;
		}
	}

	public Int32SyncWrapper Score
	{
		get
		{
			return score_;
		}
		set
		{
			score_ = value;
		}
	}

	public RepeatedField<Int32SyncWrapper> DebuffList => debuffList_;

	public Int32SyncWrapper TargetId
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

	public Uint64SyncWrapper ArchiveTime
	{
		get
		{
			return archiveTime_;
		}
		set
		{
			archiveTime_ = value;
		}
	}

	public BossRushRoleBaseSyncWrapper RoleBase
	{
		get
		{
			return roleBase_;
		}
		set
		{
			roleBase_ = value;
		}
	}

	public BossRushBattleStyleSyncWrapper BattleStyleInfo
	{
		get
		{
			return battleStyleInfo_;
		}
		set
		{
			battleStyleInfo_ = value;
		}
	}

	public BossRushDamageInfoSyncWrapper DamageInfo
	{
		get
		{
			return damageInfo_;
		}
		set
		{
			damageInfo_ = value;
		}
	}

	public BossRushBattleDataSyncWrapper()
	{
	}

	public BossRushBattleDataSyncWrapper(BossRushBattleDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		totalTime_ = ((other.totalTime_ != null) ? other.totalTime_.Clone() : null);
		score_ = ((other.score_ != null) ? other.score_.Clone() : null);
		debuffList_ = other.debuffList_.Clone();
		targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
		archiveTime_ = ((other.archiveTime_ != null) ? other.archiveTime_.Clone() : null);
		roleBase_ = ((other.roleBase_ != null) ? other.roleBase_.Clone() : null);
		battleStyleInfo_ = ((other.battleStyleInfo_ != null) ? other.battleStyleInfo_.Clone() : null);
		damageInfo_ = ((other.damageInfo_ != null) ? other.damageInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushBattleDataSyncWrapper Clone()
	{
		return new BossRushBattleDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushBattleDataSyncWrapper);
	}

	public bool Equals(BossRushBattleDataSyncWrapper other)
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
		if (!object.Equals(TotalTime, other.TotalTime))
		{
			return false;
		}
		if (!object.Equals(Score, other.Score))
		{
			return false;
		}
		if (!debuffList_.Equals(other.debuffList_))
		{
			return false;
		}
		if (!object.Equals(TargetId, other.TargetId))
		{
			return false;
		}
		if (!object.Equals(ArchiveTime, other.ArchiveTime))
		{
			return false;
		}
		if (!object.Equals(RoleBase, other.RoleBase))
		{
			return false;
		}
		if (!object.Equals(BattleStyleInfo, other.BattleStyleInfo))
		{
			return false;
		}
		if (!object.Equals(DamageInfo, other.DamageInfo))
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
		if (totalTime_ != null)
		{
			num ^= TotalTime.GetHashCode();
		}
		if (score_ != null)
		{
			num ^= Score.GetHashCode();
		}
		num ^= debuffList_.GetHashCode();
		if (targetId_ != null)
		{
			num ^= TargetId.GetHashCode();
		}
		if (archiveTime_ != null)
		{
			num ^= ArchiveTime.GetHashCode();
		}
		if (roleBase_ != null)
		{
			num ^= RoleBase.GetHashCode();
		}
		if (battleStyleInfo_ != null)
		{
			num ^= BattleStyleInfo.GetHashCode();
		}
		if (damageInfo_ != null)
		{
			num ^= DamageInfo.GetHashCode();
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
		if (totalTime_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TotalTime);
		}
		if (score_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Score);
		}
		debuffList_.WriteTo(output, _repeated_debuffList_codec);
		if (targetId_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(TargetId);
		}
		if (archiveTime_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ArchiveTime);
		}
		if (roleBase_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(RoleBase);
		}
		if (battleStyleInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(BattleStyleInfo);
		}
		if (damageInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DamageInfo);
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
		if (totalTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TotalTime);
		}
		if (score_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Score);
		}
		num += debuffList_.CalculateSize(_repeated_debuffList_codec);
		if (targetId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetId);
		}
		if (archiveTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ArchiveTime);
		}
		if (roleBase_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleBase);
		}
		if (battleStyleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleStyleInfo);
		}
		if (damageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DamageInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushBattleDataSyncWrapper other)
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
		if (other.totalTime_ != null)
		{
			if (totalTime_ == null)
			{
				TotalTime = new FloatSyncWrapper();
			}
			TotalTime.MergeFrom(other.TotalTime);
		}
		if (other.score_ != null)
		{
			if (score_ == null)
			{
				Score = new Int32SyncWrapper();
			}
			Score.MergeFrom(other.Score);
		}
		debuffList_.Add(other.debuffList_);
		if (other.targetId_ != null)
		{
			if (targetId_ == null)
			{
				TargetId = new Int32SyncWrapper();
			}
			TargetId.MergeFrom(other.TargetId);
		}
		if (other.archiveTime_ != null)
		{
			if (archiveTime_ == null)
			{
				ArchiveTime = new Uint64SyncWrapper();
			}
			ArchiveTime.MergeFrom(other.ArchiveTime);
		}
		if (other.roleBase_ != null)
		{
			if (roleBase_ == null)
			{
				RoleBase = new BossRushRoleBaseSyncWrapper();
			}
			RoleBase.MergeFrom(other.RoleBase);
		}
		if (other.battleStyleInfo_ != null)
		{
			if (battleStyleInfo_ == null)
			{
				BattleStyleInfo = new BossRushBattleStyleSyncWrapper();
			}
			BattleStyleInfo.MergeFrom(other.BattleStyleInfo);
		}
		if (other.damageInfo_ != null)
		{
			if (damageInfo_ == null)
			{
				DamageInfo = new BossRushDamageInfoSyncWrapper();
			}
			DamageInfo.MergeFrom(other.DamageInfo);
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
				if (totalTime_ == null)
				{
					TotalTime = new FloatSyncWrapper();
				}
				input.ReadMessage(TotalTime);
				break;
			case 34u:
				if (score_ == null)
				{
					Score = new Int32SyncWrapper();
				}
				input.ReadMessage(Score);
				break;
			case 42u:
				debuffList_.AddEntriesFrom(input, _repeated_debuffList_codec);
				break;
			case 50u:
				if (targetId_ == null)
				{
					TargetId = new Int32SyncWrapper();
				}
				input.ReadMessage(TargetId);
				break;
			case 58u:
				if (archiveTime_ == null)
				{
					ArchiveTime = new Uint64SyncWrapper();
				}
				input.ReadMessage(ArchiveTime);
				break;
			case 66u:
				if (roleBase_ == null)
				{
					RoleBase = new BossRushRoleBaseSyncWrapper();
				}
				input.ReadMessage(RoleBase);
				break;
			case 74u:
				if (battleStyleInfo_ == null)
				{
					BattleStyleInfo = new BossRushBattleStyleSyncWrapper();
				}
				input.ReadMessage(BattleStyleInfo);
				break;
			case 82u:
				if (damageInfo_ == null)
				{
					DamageInfo = new BossRushDamageInfoSyncWrapper();
				}
				input.ReadMessage(DamageInfo);
				break;
			}
		}
	}
}
