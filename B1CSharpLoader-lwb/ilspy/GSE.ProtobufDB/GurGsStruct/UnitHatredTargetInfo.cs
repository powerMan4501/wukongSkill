using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class UnitHatredTargetInfo : IMessage<UnitHatredTargetInfo>, IMessage, IEquatable<UnitHatredTargetInfo>, IDeepCloneable<UnitHatredTargetInfo>
{
	private static readonly MessageParser<UnitHatredTargetInfo> _parser = new MessageParser<UnitHatredTargetInfo>(() => new UnitHatredTargetInfo());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private uint hatredTargetEntity_;

	private float hatredValueBase_;

	private float hatredValueSkillExtra_;

	private float hatredValueFinal_;

	private float lastTickTimeForCalcBaseValue_;

	private float lastTickTimeForCalcSkillExtraValue_;

	private bool isFarawayFromOwner_;

	private float farawayTimer_;

	private float finalHatredValueWithoutViewWeight_;

	private float qualityCorrection_;

	private float lockCorrection_;

	private float beLockedCorrection_;

	private bool isInView_;

	private float hatredViewWeight_;

	public static MessageParser<UnitHatredTargetInfo> Parser => _parser;

	public uint HatredTargetEntity
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return hatredTargetEntity_;
			}
			return 0u;
		}
		set
		{
			_hasBits0 |= 1;
			hatredTargetEntity_ = value;
		}
	}

	public bool HasHatredTargetEntity => (_hasBits0 & 1) != 0;

	public float HatredValueBase
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return hatredValueBase_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			hatredValueBase_ = value;
		}
	}

	public bool HasHatredValueBase => (_hasBits0 & 2) != 0;

	public float HatredValueSkillExtra
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return hatredValueSkillExtra_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 4;
			hatredValueSkillExtra_ = value;
		}
	}

	public bool HasHatredValueSkillExtra => (_hasBits0 & 4) != 0;

	public float HatredValueFinal
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return hatredValueFinal_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 8;
			hatredValueFinal_ = value;
		}
	}

	public bool HasHatredValueFinal => (_hasBits0 & 8) != 0;

	public float LastTickTimeForCalcBaseValue
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return lastTickTimeForCalcBaseValue_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 16;
			lastTickTimeForCalcBaseValue_ = value;
		}
	}

	public bool HasLastTickTimeForCalcBaseValue => (_hasBits0 & 0x10) != 0;

	public float LastTickTimeForCalcSkillExtraValue
	{
		get
		{
			if ((_hasBits0 & 0x20) != 0)
			{
				return lastTickTimeForCalcSkillExtraValue_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 32;
			lastTickTimeForCalcSkillExtraValue_ = value;
		}
	}

	public bool HasLastTickTimeForCalcSkillExtraValue => (_hasBits0 & 0x20) != 0;

	public bool IsFarawayFromOwner
	{
		get
		{
			if ((_hasBits0 & 0x40) != 0)
			{
				return isFarawayFromOwner_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 64;
			isFarawayFromOwner_ = value;
		}
	}

	public bool HasIsFarawayFromOwner => (_hasBits0 & 0x40) != 0;

	public float FarawayTimer
	{
		get
		{
			if ((_hasBits0 & 0x80) != 0)
			{
				return farawayTimer_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 128;
			farawayTimer_ = value;
		}
	}

	public bool HasFarawayTimer => (_hasBits0 & 0x80) != 0;

	public float FinalHatredValueWithoutViewWeight
	{
		get
		{
			if ((_hasBits0 & 0x100) != 0)
			{
				return finalHatredValueWithoutViewWeight_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 256;
			finalHatredValueWithoutViewWeight_ = value;
		}
	}

	public bool HasFinalHatredValueWithoutViewWeight => (_hasBits0 & 0x100) != 0;

	public float QualityCorrection
	{
		get
		{
			if ((_hasBits0 & 0x200) != 0)
			{
				return qualityCorrection_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 512;
			qualityCorrection_ = value;
		}
	}

	public bool HasQualityCorrection => (_hasBits0 & 0x200) != 0;

	public float LockCorrection
	{
		get
		{
			if ((_hasBits0 & 0x400) != 0)
			{
				return lockCorrection_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1024;
			lockCorrection_ = value;
		}
	}

	public bool HasLockCorrection => (_hasBits0 & 0x400) != 0;

	public float BeLockedCorrection
	{
		get
		{
			if ((_hasBits0 & 0x800) != 0)
			{
				return beLockedCorrection_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2048;
			beLockedCorrection_ = value;
		}
	}

	public bool HasBeLockedCorrection => (_hasBits0 & 0x800) != 0;

	public bool IsInView
	{
		get
		{
			if ((_hasBits0 & 0x1000) != 0)
			{
				return isInView_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 4096;
			isInView_ = value;
		}
	}

	public bool HasIsInView => (_hasBits0 & 0x1000) != 0;

	public float HatredViewWeight
	{
		get
		{
			if ((_hasBits0 & 0x2000) != 0)
			{
				return hatredViewWeight_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 8192;
			hatredViewWeight_ = value;
		}
	}

	public bool HasHatredViewWeight => (_hasBits0 & 0x2000) != 0;

	public UnitHatredTargetInfo()
	{
	}

	public UnitHatredTargetInfo(UnitHatredTargetInfo other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		hatredTargetEntity_ = other.hatredTargetEntity_;
		hatredValueBase_ = other.hatredValueBase_;
		hatredValueSkillExtra_ = other.hatredValueSkillExtra_;
		hatredValueFinal_ = other.hatredValueFinal_;
		lastTickTimeForCalcBaseValue_ = other.lastTickTimeForCalcBaseValue_;
		lastTickTimeForCalcSkillExtraValue_ = other.lastTickTimeForCalcSkillExtraValue_;
		isFarawayFromOwner_ = other.isFarawayFromOwner_;
		farawayTimer_ = other.farawayTimer_;
		finalHatredValueWithoutViewWeight_ = other.finalHatredValueWithoutViewWeight_;
		qualityCorrection_ = other.qualityCorrection_;
		lockCorrection_ = other.lockCorrection_;
		beLockedCorrection_ = other.beLockedCorrection_;
		isInView_ = other.isInView_;
		hatredViewWeight_ = other.hatredViewWeight_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitHatredTargetInfo Clone()
	{
		return new UnitHatredTargetInfo(this);
	}

	public void ClearHatredTargetEntity()
	{
		_hasBits0 &= -2;
	}

	public void ClearHatredValueBase()
	{
		_hasBits0 &= -3;
	}

	public void ClearHatredValueSkillExtra()
	{
		_hasBits0 &= -5;
	}

	public void ClearHatredValueFinal()
	{
		_hasBits0 &= -9;
	}

	public void ClearLastTickTimeForCalcBaseValue()
	{
		_hasBits0 &= -17;
	}

	public void ClearLastTickTimeForCalcSkillExtraValue()
	{
		_hasBits0 &= -33;
	}

	public void ClearIsFarawayFromOwner()
	{
		_hasBits0 &= -65;
	}

	public void ClearFarawayTimer()
	{
		_hasBits0 &= -129;
	}

	public void ClearFinalHatredValueWithoutViewWeight()
	{
		_hasBits0 &= -257;
	}

	public void ClearQualityCorrection()
	{
		_hasBits0 &= -513;
	}

	public void ClearLockCorrection()
	{
		_hasBits0 &= -1025;
	}

	public void ClearBeLockedCorrection()
	{
		_hasBits0 &= -2049;
	}

	public void ClearIsInView()
	{
		_hasBits0 &= -4097;
	}

	public void ClearHatredViewWeight()
	{
		_hasBits0 &= -8193;
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitHatredTargetInfo);
	}

	public bool Equals(UnitHatredTargetInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HatredTargetEntity != other.HatredTargetEntity)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HatredValueBase, other.HatredValueBase))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HatredValueSkillExtra, other.HatredValueSkillExtra))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HatredValueFinal, other.HatredValueFinal))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LastTickTimeForCalcBaseValue, other.LastTickTimeForCalcBaseValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LastTickTimeForCalcSkillExtraValue, other.LastTickTimeForCalcSkillExtraValue))
		{
			return false;
		}
		if (IsFarawayFromOwner != other.IsFarawayFromOwner)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FarawayTimer, other.FarawayTimer))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FinalHatredValueWithoutViewWeight, other.FinalHatredValueWithoutViewWeight))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(QualityCorrection, other.QualityCorrection))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LockCorrection, other.LockCorrection))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BeLockedCorrection, other.BeLockedCorrection))
		{
			return false;
		}
		if (IsInView != other.IsInView)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HatredViewWeight, other.HatredViewWeight))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasHatredTargetEntity)
		{
			num ^= HatredTargetEntity.GetHashCode();
		}
		if (HasHatredValueBase)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HatredValueBase);
		}
		if (HasHatredValueSkillExtra)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HatredValueSkillExtra);
		}
		if (HasHatredValueFinal)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HatredValueFinal);
		}
		if (HasLastTickTimeForCalcBaseValue)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LastTickTimeForCalcBaseValue);
		}
		if (HasLastTickTimeForCalcSkillExtraValue)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LastTickTimeForCalcSkillExtraValue);
		}
		if (HasIsFarawayFromOwner)
		{
			num ^= IsFarawayFromOwner.GetHashCode();
		}
		if (HasFarawayTimer)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FarawayTimer);
		}
		if (HasFinalHatredValueWithoutViewWeight)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FinalHatredValueWithoutViewWeight);
		}
		if (HasQualityCorrection)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(QualityCorrection);
		}
		if (HasLockCorrection)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LockCorrection);
		}
		if (HasBeLockedCorrection)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeLockedCorrection);
		}
		if (HasIsInView)
		{
			num ^= IsInView.GetHashCode();
		}
		if (HasHatredViewWeight)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HatredViewWeight);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasHatredTargetEntity)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HatredTargetEntity);
		}
		if (HasHatredValueBase)
		{
			output.WriteRawTag(21);
			output.WriteFloat(HatredValueBase);
		}
		if (HasHatredValueSkillExtra)
		{
			output.WriteRawTag(29);
			output.WriteFloat(HatredValueSkillExtra);
		}
		if (HasHatredValueFinal)
		{
			output.WriteRawTag(37);
			output.WriteFloat(HatredValueFinal);
		}
		if (HasLastTickTimeForCalcBaseValue)
		{
			output.WriteRawTag(45);
			output.WriteFloat(LastTickTimeForCalcBaseValue);
		}
		if (HasLastTickTimeForCalcSkillExtraValue)
		{
			output.WriteRawTag(53);
			output.WriteFloat(LastTickTimeForCalcSkillExtraValue);
		}
		if (HasIsFarawayFromOwner)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsFarawayFromOwner);
		}
		if (HasFarawayTimer)
		{
			output.WriteRawTag(69);
			output.WriteFloat(FarawayTimer);
		}
		if (HasFinalHatredValueWithoutViewWeight)
		{
			output.WriteRawTag(77);
			output.WriteFloat(FinalHatredValueWithoutViewWeight);
		}
		if (HasQualityCorrection)
		{
			output.WriteRawTag(85);
			output.WriteFloat(QualityCorrection);
		}
		if (HasLockCorrection)
		{
			output.WriteRawTag(93);
			output.WriteFloat(LockCorrection);
		}
		if (HasBeLockedCorrection)
		{
			output.WriteRawTag(101);
			output.WriteFloat(BeLockedCorrection);
		}
		if (HasIsInView)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsInView);
		}
		if (HasHatredViewWeight)
		{
			output.WriteRawTag(117);
			output.WriteFloat(HatredViewWeight);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasHatredTargetEntity)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HatredTargetEntity);
		}
		if (HasHatredValueBase)
		{
			num += 5;
		}
		if (HasHatredValueSkillExtra)
		{
			num += 5;
		}
		if (HasHatredValueFinal)
		{
			num += 5;
		}
		if (HasLastTickTimeForCalcBaseValue)
		{
			num += 5;
		}
		if (HasLastTickTimeForCalcSkillExtraValue)
		{
			num += 5;
		}
		if (HasIsFarawayFromOwner)
		{
			num += 2;
		}
		if (HasFarawayTimer)
		{
			num += 5;
		}
		if (HasFinalHatredValueWithoutViewWeight)
		{
			num += 5;
		}
		if (HasQualityCorrection)
		{
			num += 5;
		}
		if (HasLockCorrection)
		{
			num += 5;
		}
		if (HasBeLockedCorrection)
		{
			num += 5;
		}
		if (HasIsInView)
		{
			num += 2;
		}
		if (HasHatredViewWeight)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitHatredTargetInfo other)
	{
		if (other != null)
		{
			if (other.HasHatredTargetEntity)
			{
				HatredTargetEntity = other.HatredTargetEntity;
			}
			if (other.HasHatredValueBase)
			{
				HatredValueBase = other.HatredValueBase;
			}
			if (other.HasHatredValueSkillExtra)
			{
				HatredValueSkillExtra = other.HatredValueSkillExtra;
			}
			if (other.HasHatredValueFinal)
			{
				HatredValueFinal = other.HatredValueFinal;
			}
			if (other.HasLastTickTimeForCalcBaseValue)
			{
				LastTickTimeForCalcBaseValue = other.LastTickTimeForCalcBaseValue;
			}
			if (other.HasLastTickTimeForCalcSkillExtraValue)
			{
				LastTickTimeForCalcSkillExtraValue = other.LastTickTimeForCalcSkillExtraValue;
			}
			if (other.HasIsFarawayFromOwner)
			{
				IsFarawayFromOwner = other.IsFarawayFromOwner;
			}
			if (other.HasFarawayTimer)
			{
				FarawayTimer = other.FarawayTimer;
			}
			if (other.HasFinalHatredValueWithoutViewWeight)
			{
				FinalHatredValueWithoutViewWeight = other.FinalHatredValueWithoutViewWeight;
			}
			if (other.HasQualityCorrection)
			{
				QualityCorrection = other.QualityCorrection;
			}
			if (other.HasLockCorrection)
			{
				LockCorrection = other.LockCorrection;
			}
			if (other.HasBeLockedCorrection)
			{
				BeLockedCorrection = other.BeLockedCorrection;
			}
			if (other.HasIsInView)
			{
				IsInView = other.IsInView;
			}
			if (other.HasHatredViewWeight)
			{
				HatredViewWeight = other.HatredViewWeight;
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
				HatredTargetEntity = input.ReadUInt32();
				break;
			case 21u:
				HatredValueBase = input.ReadFloat();
				break;
			case 29u:
				HatredValueSkillExtra = input.ReadFloat();
				break;
			case 37u:
				HatredValueFinal = input.ReadFloat();
				break;
			case 45u:
				LastTickTimeForCalcBaseValue = input.ReadFloat();
				break;
			case 53u:
				LastTickTimeForCalcSkillExtraValue = input.ReadFloat();
				break;
			case 56u:
				IsFarawayFromOwner = input.ReadBool();
				break;
			case 69u:
				FarawayTimer = input.ReadFloat();
				break;
			case 77u:
				FinalHatredValueWithoutViewWeight = input.ReadFloat();
				break;
			case 85u:
				QualityCorrection = input.ReadFloat();
				break;
			case 93u:
				LockCorrection = input.ReadFloat();
				break;
			case 101u:
				BeLockedCorrection = input.ReadFloat();
				break;
			case 104u:
				IsInView = input.ReadBool();
				break;
			case 117u:
				HatredViewWeight = input.ReadFloat();
				break;
			}
		}
	}
}
