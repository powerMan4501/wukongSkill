using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class BossRushContinuousFightRecordSyncWrapper : IMessage<BossRushContinuousFightRecordSyncWrapper>, IMessage, IEquatable<BossRushContinuousFightRecordSyncWrapper>, IDeepCloneable<BossRushContinuousFightRecordSyncWrapper>
{
	private static readonly MessageParser<BossRushContinuousFightRecordSyncWrapper> _parser = new MessageParser<BossRushContinuousFightRecordSyncWrapper>(() => new BossRushContinuousFightRecordSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint64SyncWrapper battleId_;

	private BossRushBattleDataSyncWrapper battleData_;

	public static MessageParser<BossRushContinuousFightRecordSyncWrapper> Parser => _parser;

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

	public Uint64SyncWrapper BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	public BossRushBattleDataSyncWrapper BattleData
	{
		get
		{
			return battleData_;
		}
		set
		{
			battleData_ = value;
		}
	}

	public BossRushContinuousFightRecordSyncWrapper()
	{
	}

	public BossRushContinuousFightRecordSyncWrapper(BossRushContinuousFightRecordSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		battleId_ = ((other.battleId_ != null) ? other.battleId_.Clone() : null);
		battleData_ = ((other.battleData_ != null) ? other.battleData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushContinuousFightRecordSyncWrapper Clone()
	{
		return new BossRushContinuousFightRecordSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushContinuousFightRecordSyncWrapper);
	}

	public bool Equals(BossRushContinuousFightRecordSyncWrapper other)
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
		if (!object.Equals(BattleId, other.BattleId))
		{
			return false;
		}
		if (!object.Equals(BattleData, other.BattleData))
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
		if (battleId_ != null)
		{
			num ^= BattleId.GetHashCode();
		}
		if (battleData_ != null)
		{
			num ^= BattleData.GetHashCode();
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
		if (battleId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BattleId);
		}
		if (battleData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BattleData);
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
		if (battleId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleId);
		}
		if (battleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushContinuousFightRecordSyncWrapper other)
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
		if (other.battleId_ != null)
		{
			if (battleId_ == null)
			{
				BattleId = new Uint64SyncWrapper();
			}
			BattleId.MergeFrom(other.BattleId);
		}
		if (other.battleData_ != null)
		{
			if (battleData_ == null)
			{
				BattleData = new BossRushBattleDataSyncWrapper();
			}
			BattleData.MergeFrom(other.BattleData);
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
				if (battleId_ == null)
				{
					BattleId = new Uint64SyncWrapper();
				}
				input.ReadMessage(BattleId);
				break;
			case 34u:
				if (battleData_ == null)
				{
					BattleData = new BossRushBattleDataSyncWrapper();
				}
				input.ReadMessage(BattleData);
				break;
			}
		}
	}
}
