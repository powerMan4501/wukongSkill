using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class BossRushDamageInfoSyncWrapper : IMessage<BossRushDamageInfoSyncWrapper>, IMessage, IEquatable<BossRushDamageInfoSyncWrapper>, IDeepCloneable<BossRushDamageInfoSyncWrapper>
{
	private static readonly MessageParser<BossRushDamageInfoSyncWrapper> _parser = new MessageParser<BossRushDamageInfoSyncWrapper>(() => new BossRushDamageInfoSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private FloatSyncWrapper totalDamage_;

	private FloatSyncWrapper hightestDamage_;

	private FloatSyncWrapper criticalDmgRate_;

	private FloatSyncWrapper totalBeDamaged_;

	private FloatSyncWrapper criticalDmgTotal_;

	private FloatSyncWrapper elemDotDmgTotal_;

	private FloatSyncWrapper elemDotDmgRate_;

	public static MessageParser<BossRushDamageInfoSyncWrapper> Parser => _parser;

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

	public FloatSyncWrapper TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	public FloatSyncWrapper HightestDamage
	{
		get
		{
			return hightestDamage_;
		}
		set
		{
			hightestDamage_ = value;
		}
	}

	public FloatSyncWrapper CriticalDmgRate
	{
		get
		{
			return criticalDmgRate_;
		}
		set
		{
			criticalDmgRate_ = value;
		}
	}

	public FloatSyncWrapper TotalBeDamaged
	{
		get
		{
			return totalBeDamaged_;
		}
		set
		{
			totalBeDamaged_ = value;
		}
	}

	public FloatSyncWrapper CriticalDmgTotal
	{
		get
		{
			return criticalDmgTotal_;
		}
		set
		{
			criticalDmgTotal_ = value;
		}
	}

	public FloatSyncWrapper ElemDotDmgTotal
	{
		get
		{
			return elemDotDmgTotal_;
		}
		set
		{
			elemDotDmgTotal_ = value;
		}
	}

	public FloatSyncWrapper ElemDotDmgRate
	{
		get
		{
			return elemDotDmgRate_;
		}
		set
		{
			elemDotDmgRate_ = value;
		}
	}

	public BossRushDamageInfoSyncWrapper()
	{
	}

	public BossRushDamageInfoSyncWrapper(BossRushDamageInfoSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		totalDamage_ = ((other.totalDamage_ != null) ? other.totalDamage_.Clone() : null);
		hightestDamage_ = ((other.hightestDamage_ != null) ? other.hightestDamage_.Clone() : null);
		criticalDmgRate_ = ((other.criticalDmgRate_ != null) ? other.criticalDmgRate_.Clone() : null);
		totalBeDamaged_ = ((other.totalBeDamaged_ != null) ? other.totalBeDamaged_.Clone() : null);
		criticalDmgTotal_ = ((other.criticalDmgTotal_ != null) ? other.criticalDmgTotal_.Clone() : null);
		elemDotDmgTotal_ = ((other.elemDotDmgTotal_ != null) ? other.elemDotDmgTotal_.Clone() : null);
		elemDotDmgRate_ = ((other.elemDotDmgRate_ != null) ? other.elemDotDmgRate_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushDamageInfoSyncWrapper Clone()
	{
		return new BossRushDamageInfoSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushDamageInfoSyncWrapper);
	}

	public bool Equals(BossRushDamageInfoSyncWrapper other)
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
		if (!object.Equals(TotalDamage, other.TotalDamage))
		{
			return false;
		}
		if (!object.Equals(HightestDamage, other.HightestDamage))
		{
			return false;
		}
		if (!object.Equals(CriticalDmgRate, other.CriticalDmgRate))
		{
			return false;
		}
		if (!object.Equals(TotalBeDamaged, other.TotalBeDamaged))
		{
			return false;
		}
		if (!object.Equals(CriticalDmgTotal, other.CriticalDmgTotal))
		{
			return false;
		}
		if (!object.Equals(ElemDotDmgTotal, other.ElemDotDmgTotal))
		{
			return false;
		}
		if (!object.Equals(ElemDotDmgRate, other.ElemDotDmgRate))
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
		if (totalDamage_ != null)
		{
			num ^= TotalDamage.GetHashCode();
		}
		if (hightestDamage_ != null)
		{
			num ^= HightestDamage.GetHashCode();
		}
		if (criticalDmgRate_ != null)
		{
			num ^= CriticalDmgRate.GetHashCode();
		}
		if (totalBeDamaged_ != null)
		{
			num ^= TotalBeDamaged.GetHashCode();
		}
		if (criticalDmgTotal_ != null)
		{
			num ^= CriticalDmgTotal.GetHashCode();
		}
		if (elemDotDmgTotal_ != null)
		{
			num ^= ElemDotDmgTotal.GetHashCode();
		}
		if (elemDotDmgRate_ != null)
		{
			num ^= ElemDotDmgRate.GetHashCode();
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
		if (totalDamage_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TotalDamage);
		}
		if (hightestDamage_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(HightestDamage);
		}
		if (criticalDmgRate_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CriticalDmgRate);
		}
		if (totalBeDamaged_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(TotalBeDamaged);
		}
		if (criticalDmgTotal_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(CriticalDmgTotal);
		}
		if (elemDotDmgTotal_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ElemDotDmgTotal);
		}
		if (elemDotDmgRate_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ElemDotDmgRate);
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
		if (totalDamage_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TotalDamage);
		}
		if (hightestDamage_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HightestDamage);
		}
		if (criticalDmgRate_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CriticalDmgRate);
		}
		if (totalBeDamaged_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TotalBeDamaged);
		}
		if (criticalDmgTotal_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CriticalDmgTotal);
		}
		if (elemDotDmgTotal_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ElemDotDmgTotal);
		}
		if (elemDotDmgRate_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ElemDotDmgRate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushDamageInfoSyncWrapper other)
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
		if (other.totalDamage_ != null)
		{
			if (totalDamage_ == null)
			{
				TotalDamage = new FloatSyncWrapper();
			}
			TotalDamage.MergeFrom(other.TotalDamage);
		}
		if (other.hightestDamage_ != null)
		{
			if (hightestDamage_ == null)
			{
				HightestDamage = new FloatSyncWrapper();
			}
			HightestDamage.MergeFrom(other.HightestDamage);
		}
		if (other.criticalDmgRate_ != null)
		{
			if (criticalDmgRate_ == null)
			{
				CriticalDmgRate = new FloatSyncWrapper();
			}
			CriticalDmgRate.MergeFrom(other.CriticalDmgRate);
		}
		if (other.totalBeDamaged_ != null)
		{
			if (totalBeDamaged_ == null)
			{
				TotalBeDamaged = new FloatSyncWrapper();
			}
			TotalBeDamaged.MergeFrom(other.TotalBeDamaged);
		}
		if (other.criticalDmgTotal_ != null)
		{
			if (criticalDmgTotal_ == null)
			{
				CriticalDmgTotal = new FloatSyncWrapper();
			}
			CriticalDmgTotal.MergeFrom(other.CriticalDmgTotal);
		}
		if (other.elemDotDmgTotal_ != null)
		{
			if (elemDotDmgTotal_ == null)
			{
				ElemDotDmgTotal = new FloatSyncWrapper();
			}
			ElemDotDmgTotal.MergeFrom(other.ElemDotDmgTotal);
		}
		if (other.elemDotDmgRate_ != null)
		{
			if (elemDotDmgRate_ == null)
			{
				ElemDotDmgRate = new FloatSyncWrapper();
			}
			ElemDotDmgRate.MergeFrom(other.ElemDotDmgRate);
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
				if (totalDamage_ == null)
				{
					TotalDamage = new FloatSyncWrapper();
				}
				input.ReadMessage(TotalDamage);
				break;
			case 34u:
				if (hightestDamage_ == null)
				{
					HightestDamage = new FloatSyncWrapper();
				}
				input.ReadMessage(HightestDamage);
				break;
			case 42u:
				if (criticalDmgRate_ == null)
				{
					CriticalDmgRate = new FloatSyncWrapper();
				}
				input.ReadMessage(CriticalDmgRate);
				break;
			case 50u:
				if (totalBeDamaged_ == null)
				{
					TotalBeDamaged = new FloatSyncWrapper();
				}
				input.ReadMessage(TotalBeDamaged);
				break;
			case 58u:
				if (criticalDmgTotal_ == null)
				{
					CriticalDmgTotal = new FloatSyncWrapper();
				}
				input.ReadMessage(CriticalDmgTotal);
				break;
			case 66u:
				if (elemDotDmgTotal_ == null)
				{
					ElemDotDmgTotal = new FloatSyncWrapper();
				}
				input.ReadMessage(ElemDotDmgTotal);
				break;
			case 74u:
				if (elemDotDmgRate_ == null)
				{
					ElemDotDmgRate = new FloatSyncWrapper();
				}
				input.ReadMessage(ElemDotDmgRate);
				break;
			}
		}
	}
}
