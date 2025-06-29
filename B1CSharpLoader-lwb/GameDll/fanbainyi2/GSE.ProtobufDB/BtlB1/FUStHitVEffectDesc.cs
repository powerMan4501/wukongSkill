using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStHitVEffectDesc : IMessage<FUStHitVEffectDesc>, IMessage, IEquatable<FUStHitVEffectDesc>, IDeepCloneable<FUStHitVEffectDesc>
{
	private static readonly MessageParser<FUStHitVEffectDesc> _parser = new MessageParser<FUStHitVEffectDesc>(() => new FUStHitVEffectDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float freezeFrameGap_;

	private float freezeFrameTime_;

	private float hitSlowTime_;

	private float hitSlowStartPlayRate_;

	private float hitSlowResumePlayRate_;

	private EHitSlowResumeType hitSlowResumeType_;

	private float critFreezeFrameTime_;

	public static MessageParser<FUStHitVEffectDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public float FreezeFrameGap
	{
		get
		{
			return freezeFrameGap_;
		}
		set
		{
			freezeFrameGap_ = value;
		}
	}

	public float FreezeFrameTime
	{
		get
		{
			return freezeFrameTime_;
		}
		set
		{
			freezeFrameTime_ = value;
		}
	}

	public float HitSlowTime
	{
		get
		{
			return hitSlowTime_;
		}
		set
		{
			hitSlowTime_ = value;
		}
	}

	public float HitSlowStartPlayRate
	{
		get
		{
			return hitSlowStartPlayRate_;
		}
		set
		{
			hitSlowStartPlayRate_ = value;
		}
	}

	public float HitSlowResumePlayRate
	{
		get
		{
			return hitSlowResumePlayRate_;
		}
		set
		{
			hitSlowResumePlayRate_ = value;
		}
	}

	public EHitSlowResumeType HitSlowResumeType
	{
		get
		{
			return hitSlowResumeType_;
		}
		set
		{
			hitSlowResumeType_ = value;
		}
	}

	public float CritFreezeFrameTime
	{
		get
		{
			return critFreezeFrameTime_;
		}
		set
		{
			critFreezeFrameTime_ = value;
		}
	}

	public FUStHitVEffectDesc()
	{
	}

	public FUStHitVEffectDesc(FUStHitVEffectDesc other)
		: this()
	{
		iD_ = other.iD_;
		freezeFrameGap_ = other.freezeFrameGap_;
		freezeFrameTime_ = other.freezeFrameTime_;
		hitSlowTime_ = other.hitSlowTime_;
		hitSlowStartPlayRate_ = other.hitSlowStartPlayRate_;
		hitSlowResumePlayRate_ = other.hitSlowResumePlayRate_;
		hitSlowResumeType_ = other.hitSlowResumeType_;
		critFreezeFrameTime_ = other.critFreezeFrameTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStHitVEffectDesc Clone()
	{
		return new FUStHitVEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStHitVEffectDesc);
	}

	public bool Equals(FUStHitVEffectDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FreezeFrameGap, other.FreezeFrameGap))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FreezeFrameTime, other.FreezeFrameTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HitSlowTime, other.HitSlowTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HitSlowStartPlayRate, other.HitSlowStartPlayRate))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HitSlowResumePlayRate, other.HitSlowResumePlayRate))
		{
			return false;
		}
		if (HitSlowResumeType != other.HitSlowResumeType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CritFreezeFrameTime, other.CritFreezeFrameTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (FreezeFrameGap != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FreezeFrameGap);
		}
		if (FreezeFrameTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FreezeFrameTime);
		}
		if (HitSlowTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HitSlowTime);
		}
		if (HitSlowStartPlayRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HitSlowStartPlayRate);
		}
		if (HitSlowResumePlayRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HitSlowResumePlayRate);
		}
		if (HitSlowResumeType != EHitSlowResumeType.Linear)
		{
			num ^= HitSlowResumeType.GetHashCode();
		}
		if (CritFreezeFrameTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CritFreezeFrameTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (FreezeFrameGap != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(FreezeFrameGap);
		}
		if (FreezeFrameTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(FreezeFrameTime);
		}
		if (HitSlowTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(HitSlowTime);
		}
		if (HitSlowStartPlayRate != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(HitSlowStartPlayRate);
		}
		if (HitSlowResumePlayRate != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(HitSlowResumePlayRate);
		}
		if (HitSlowResumeType != EHitSlowResumeType.Linear)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)HitSlowResumeType);
		}
		if (CritFreezeFrameTime != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(CritFreezeFrameTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (FreezeFrameGap != 0f)
		{
			num += 5;
		}
		if (FreezeFrameTime != 0f)
		{
			num += 5;
		}
		if (HitSlowTime != 0f)
		{
			num += 5;
		}
		if (HitSlowStartPlayRate != 0f)
		{
			num += 5;
		}
		if (HitSlowResumePlayRate != 0f)
		{
			num += 5;
		}
		if (HitSlowResumeType != EHitSlowResumeType.Linear)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitSlowResumeType);
		}
		if (CritFreezeFrameTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStHitVEffectDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.FreezeFrameGap != 0f)
			{
				FreezeFrameGap = other.FreezeFrameGap;
			}
			if (other.FreezeFrameTime != 0f)
			{
				FreezeFrameTime = other.FreezeFrameTime;
			}
			if (other.HitSlowTime != 0f)
			{
				HitSlowTime = other.HitSlowTime;
			}
			if (other.HitSlowStartPlayRate != 0f)
			{
				HitSlowStartPlayRate = other.HitSlowStartPlayRate;
			}
			if (other.HitSlowResumePlayRate != 0f)
			{
				HitSlowResumePlayRate = other.HitSlowResumePlayRate;
			}
			if (other.HitSlowResumeType != EHitSlowResumeType.Linear)
			{
				HitSlowResumeType = other.HitSlowResumeType;
			}
			if (other.CritFreezeFrameTime != 0f)
			{
				CritFreezeFrameTime = other.CritFreezeFrameTime;
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
				ID = input.ReadInt32();
				break;
			case 21u:
				FreezeFrameGap = input.ReadFloat();
				break;
			case 29u:
				FreezeFrameTime = input.ReadFloat();
				break;
			case 37u:
				HitSlowTime = input.ReadFloat();
				break;
			case 45u:
				HitSlowStartPlayRate = input.ReadFloat();
				break;
			case 53u:
				HitSlowResumePlayRate = input.ReadFloat();
				break;
			case 56u:
				HitSlowResumeType = (EHitSlowResumeType)input.ReadEnum();
				break;
			case 69u:
				CritFreezeFrameTime = input.ReadFloat();
				break;
			}
		}
	}
}
