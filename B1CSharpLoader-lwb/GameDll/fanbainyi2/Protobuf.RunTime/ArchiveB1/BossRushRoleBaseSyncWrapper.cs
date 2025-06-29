using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class BossRushRoleBaseSyncWrapper : IMessage<BossRushRoleBaseSyncWrapper>, IMessage, IEquatable<BossRushRoleBaseSyncWrapper>, IDeepCloneable<BossRushRoleBaseSyncWrapper>
{
	private static readonly MessageParser<BossRushRoleBaseSyncWrapper> _parser = new MessageParser<BossRushRoleBaseSyncWrapper>(() => new BossRushRoleBaseSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper level_;

	private FloatSyncWrapper atk_;

	private FloatSyncWrapper hpMax_;

	private FloatSyncWrapper staminaMax_;

	private FloatSyncWrapper mpMax_;

	public static MessageParser<BossRushRoleBaseSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public FloatSyncWrapper Atk
	{
		get
		{
			return atk_;
		}
		set
		{
			atk_ = value;
		}
	}

	public FloatSyncWrapper HpMax
	{
		get
		{
			return hpMax_;
		}
		set
		{
			hpMax_ = value;
		}
	}

	public FloatSyncWrapper StaminaMax
	{
		get
		{
			return staminaMax_;
		}
		set
		{
			staminaMax_ = value;
		}
	}

	public FloatSyncWrapper MpMax
	{
		get
		{
			return mpMax_;
		}
		set
		{
			mpMax_ = value;
		}
	}

	public BossRushRoleBaseSyncWrapper()
	{
	}

	public BossRushRoleBaseSyncWrapper(BossRushRoleBaseSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		level_ = ((other.level_ != null) ? other.level_.Clone() : null);
		atk_ = ((other.atk_ != null) ? other.atk_.Clone() : null);
		hpMax_ = ((other.hpMax_ != null) ? other.hpMax_.Clone() : null);
		staminaMax_ = ((other.staminaMax_ != null) ? other.staminaMax_.Clone() : null);
		mpMax_ = ((other.mpMax_ != null) ? other.mpMax_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushRoleBaseSyncWrapper Clone()
	{
		return new BossRushRoleBaseSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushRoleBaseSyncWrapper);
	}

	public bool Equals(BossRushRoleBaseSyncWrapper other)
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
		if (!object.Equals(Level, other.Level))
		{
			return false;
		}
		if (!object.Equals(Atk, other.Atk))
		{
			return false;
		}
		if (!object.Equals(HpMax, other.HpMax))
		{
			return false;
		}
		if (!object.Equals(StaminaMax, other.StaminaMax))
		{
			return false;
		}
		if (!object.Equals(MpMax, other.MpMax))
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
		if (level_ != null)
		{
			num ^= Level.GetHashCode();
		}
		if (atk_ != null)
		{
			num ^= Atk.GetHashCode();
		}
		if (hpMax_ != null)
		{
			num ^= HpMax.GetHashCode();
		}
		if (staminaMax_ != null)
		{
			num ^= StaminaMax.GetHashCode();
		}
		if (mpMax_ != null)
		{
			num ^= MpMax.GetHashCode();
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
		if (level_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Level);
		}
		if (atk_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Atk);
		}
		if (hpMax_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(HpMax);
		}
		if (staminaMax_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(StaminaMax);
		}
		if (mpMax_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(MpMax);
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
		if (level_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Level);
		}
		if (atk_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Atk);
		}
		if (hpMax_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HpMax);
		}
		if (staminaMax_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StaminaMax);
		}
		if (mpMax_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MpMax);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushRoleBaseSyncWrapper other)
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
		if (other.level_ != null)
		{
			if (level_ == null)
			{
				Level = new Int32SyncWrapper();
			}
			Level.MergeFrom(other.Level);
		}
		if (other.atk_ != null)
		{
			if (atk_ == null)
			{
				Atk = new FloatSyncWrapper();
			}
			Atk.MergeFrom(other.Atk);
		}
		if (other.hpMax_ != null)
		{
			if (hpMax_ == null)
			{
				HpMax = new FloatSyncWrapper();
			}
			HpMax.MergeFrom(other.HpMax);
		}
		if (other.staminaMax_ != null)
		{
			if (staminaMax_ == null)
			{
				StaminaMax = new FloatSyncWrapper();
			}
			StaminaMax.MergeFrom(other.StaminaMax);
		}
		if (other.mpMax_ != null)
		{
			if (mpMax_ == null)
			{
				MpMax = new FloatSyncWrapper();
			}
			MpMax.MergeFrom(other.MpMax);
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
				if (level_ == null)
				{
					Level = new Int32SyncWrapper();
				}
				input.ReadMessage(Level);
				break;
			case 34u:
				if (atk_ == null)
				{
					Atk = new FloatSyncWrapper();
				}
				input.ReadMessage(Atk);
				break;
			case 42u:
				if (hpMax_ == null)
				{
					HpMax = new FloatSyncWrapper();
				}
				input.ReadMessage(HpMax);
				break;
			case 50u:
				if (staminaMax_ == null)
				{
					StaminaMax = new FloatSyncWrapper();
				}
				input.ReadMessage(StaminaMax);
				break;
			case 58u:
				if (mpMax_ == null)
				{
					MpMax = new FloatSyncWrapper();
				}
				input.ReadMessage(MpMax);
				break;
			}
		}
	}
}
