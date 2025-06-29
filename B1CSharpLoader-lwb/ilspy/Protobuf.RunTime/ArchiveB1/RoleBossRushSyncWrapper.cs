using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class RoleBossRushSyncWrapper : IMessage<RoleBossRushSyncWrapper>, IMessage, IEquatable<RoleBossRushSyncWrapper>, IDeepCloneable<RoleBossRushSyncWrapper>
{
	private static readonly MessageParser<RoleBossRushSyncWrapper> _parser = new MessageParser<RoleBossRushSyncWrapper>(() => new RoleBossRushSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private BossRushRefightSyncWrapper refight_;

	private BossRushContinuousFightSyncWrapper continuousFight_;

	private Uint64SyncWrapper battleCount_;

	public static MessageParser<RoleBossRushSyncWrapper> Parser => _parser;

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

	public BossRushRefightSyncWrapper Refight
	{
		get
		{
			return refight_;
		}
		set
		{
			refight_ = value;
		}
	}

	public BossRushContinuousFightSyncWrapper ContinuousFight
	{
		get
		{
			return continuousFight_;
		}
		set
		{
			continuousFight_ = value;
		}
	}

	public Uint64SyncWrapper BattleCount
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

	public RoleBossRushSyncWrapper()
	{
	}

	public RoleBossRushSyncWrapper(RoleBossRushSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		refight_ = ((other.refight_ != null) ? other.refight_.Clone() : null);
		continuousFight_ = ((other.continuousFight_ != null) ? other.continuousFight_.Clone() : null);
		battleCount_ = ((other.battleCount_ != null) ? other.battleCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBossRushSyncWrapper Clone()
	{
		return new RoleBossRushSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBossRushSyncWrapper);
	}

	public bool Equals(RoleBossRushSyncWrapper other)
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
		if (!object.Equals(Refight, other.Refight))
		{
			return false;
		}
		if (!object.Equals(ContinuousFight, other.ContinuousFight))
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
		if (refight_ != null)
		{
			num ^= Refight.GetHashCode();
		}
		if (continuousFight_ != null)
		{
			num ^= ContinuousFight.GetHashCode();
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
		if (refight_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Refight);
		}
		if (continuousFight_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ContinuousFight);
		}
		if (battleCount_ != null)
		{
			output.WriteRawTag(42);
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
		if (refight_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Refight);
		}
		if (continuousFight_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ContinuousFight);
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

	public void MergeFrom(RoleBossRushSyncWrapper other)
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
		if (other.refight_ != null)
		{
			if (refight_ == null)
			{
				Refight = new BossRushRefightSyncWrapper();
			}
			Refight.MergeFrom(other.Refight);
		}
		if (other.continuousFight_ != null)
		{
			if (continuousFight_ == null)
			{
				ContinuousFight = new BossRushContinuousFightSyncWrapper();
			}
			ContinuousFight.MergeFrom(other.ContinuousFight);
		}
		if (other.battleCount_ != null)
		{
			if (battleCount_ == null)
			{
				BattleCount = new Uint64SyncWrapper();
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
				if (refight_ == null)
				{
					Refight = new BossRushRefightSyncWrapper();
				}
				input.ReadMessage(Refight);
				break;
			case 34u:
				if (continuousFight_ == null)
				{
					ContinuousFight = new BossRushContinuousFightSyncWrapper();
				}
				input.ReadMessage(ContinuousFight);
				break;
			case 42u:
				if (battleCount_ == null)
				{
					BattleCount = new Uint64SyncWrapper();
				}
				input.ReadMessage(BattleCount);
				break;
			}
		}
	}
}
