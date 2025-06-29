using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStBeAttackedFXMapDesc : IMessage<FUStBeAttackedFXMapDesc>, IMessage, IEquatable<FUStBeAttackedFXMapDesc>, IDeepCloneable<FUStBeAttackedFXMapDesc>
{
	private static readonly MessageParser<FUStBeAttackedFXMapDesc> _parser = new MessageParser<FUStBeAttackedFXMapDesc>(() => new FUStBeAttackedFXMapDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int unitResID_;

	private ESkillDamageType skillDamageType_;

	private EHitItemFXType hitItemFXType_;

	private EHitPerformFXEventType hitPerformFXEventType_;

	private int fXWeight_;

	private EGSYesNo isUseDispConfig_;

	private string beHitFXPath_ = "";

	private string beHitFXPathAttachVer_ = "";

	public static MessageParser<FUStBeAttackedFXMapDesc> Parser => _parser;

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

	public int UnitResID
	{
		get
		{
			return unitResID_;
		}
		set
		{
			unitResID_ = value;
		}
	}

	public ESkillDamageType SkillDamageType
	{
		get
		{
			return skillDamageType_;
		}
		set
		{
			skillDamageType_ = value;
		}
	}

	public EHitItemFXType HitItemFXType
	{
		get
		{
			return hitItemFXType_;
		}
		set
		{
			hitItemFXType_ = value;
		}
	}

	public EHitPerformFXEventType HitPerformFXEventType
	{
		get
		{
			return hitPerformFXEventType_;
		}
		set
		{
			hitPerformFXEventType_ = value;
		}
	}

	public int FXWeight
	{
		get
		{
			return fXWeight_;
		}
		set
		{
			fXWeight_ = value;
		}
	}

	public EGSYesNo IsUseDispConfig
	{
		get
		{
			return isUseDispConfig_;
		}
		set
		{
			isUseDispConfig_ = value;
		}
	}

	public string BeHitFXPath
	{
		get
		{
			return beHitFXPath_;
		}
		set
		{
			beHitFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BeHitFXPathAttachVer
	{
		get
		{
			return beHitFXPathAttachVer_;
		}
		set
		{
			beHitFXPathAttachVer_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStBeAttackedFXMapDesc()
	{
	}

	public FUStBeAttackedFXMapDesc(FUStBeAttackedFXMapDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitResID_ = other.unitResID_;
		skillDamageType_ = other.skillDamageType_;
		hitItemFXType_ = other.hitItemFXType_;
		hitPerformFXEventType_ = other.hitPerformFXEventType_;
		fXWeight_ = other.fXWeight_;
		isUseDispConfig_ = other.isUseDispConfig_;
		beHitFXPath_ = other.beHitFXPath_;
		beHitFXPathAttachVer_ = other.beHitFXPathAttachVer_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBeAttackedFXMapDesc Clone()
	{
		return new FUStBeAttackedFXMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBeAttackedFXMapDesc);
	}

	public bool Equals(FUStBeAttackedFXMapDesc other)
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
		if (UnitResID != other.UnitResID)
		{
			return false;
		}
		if (SkillDamageType != other.SkillDamageType)
		{
			return false;
		}
		if (HitItemFXType != other.HitItemFXType)
		{
			return false;
		}
		if (HitPerformFXEventType != other.HitPerformFXEventType)
		{
			return false;
		}
		if (FXWeight != other.FXWeight)
		{
			return false;
		}
		if (IsUseDispConfig != other.IsUseDispConfig)
		{
			return false;
		}
		if (BeHitFXPath != other.BeHitFXPath)
		{
			return false;
		}
		if (BeHitFXPathAttachVer != other.BeHitFXPathAttachVer)
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
		if (UnitResID != 0)
		{
			num ^= UnitResID.GetHashCode();
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			num ^= SkillDamageType.GetHashCode();
		}
		if (HitItemFXType != EHitItemFXType.NormalBody)
		{
			num ^= HitItemFXType.GetHashCode();
		}
		if (HitPerformFXEventType != EHitPerformFXEventType.None)
		{
			num ^= HitPerformFXEventType.GetHashCode();
		}
		if (FXWeight != 0)
		{
			num ^= FXWeight.GetHashCode();
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			num ^= IsUseDispConfig.GetHashCode();
		}
		if (BeHitFXPath.Length != 0)
		{
			num ^= BeHitFXPath.GetHashCode();
		}
		if (BeHitFXPathAttachVer.Length != 0)
		{
			num ^= BeHitFXPathAttachVer.GetHashCode();
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
		if (UnitResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UnitResID);
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)SkillDamageType);
		}
		if (HitItemFXType != EHitItemFXType.NormalBody)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)HitItemFXType);
		}
		if (HitPerformFXEventType != EHitPerformFXEventType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)HitPerformFXEventType);
		}
		if (FXWeight != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(FXWeight);
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IsUseDispConfig);
		}
		if (BeHitFXPath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(BeHitFXPath);
		}
		if (BeHitFXPathAttachVer.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(BeHitFXPathAttachVer);
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
		if (UnitResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitResID);
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkillDamageType);
		}
		if (HitItemFXType != EHitItemFXType.NormalBody)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitItemFXType);
		}
		if (HitPerformFXEventType != EHitPerformFXEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitPerformFXEventType);
		}
		if (FXWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FXWeight);
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsUseDispConfig);
		}
		if (BeHitFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeHitFXPath);
		}
		if (BeHitFXPathAttachVer.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeHitFXPathAttachVer);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBeAttackedFXMapDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitResID != 0)
			{
				UnitResID = other.UnitResID;
			}
			if (other.SkillDamageType != ESkillDamageType.NoneEffectAtk)
			{
				SkillDamageType = other.SkillDamageType;
			}
			if (other.HitItemFXType != EHitItemFXType.NormalBody)
			{
				HitItemFXType = other.HitItemFXType;
			}
			if (other.HitPerformFXEventType != EHitPerformFXEventType.None)
			{
				HitPerformFXEventType = other.HitPerformFXEventType;
			}
			if (other.FXWeight != 0)
			{
				FXWeight = other.FXWeight;
			}
			if (other.IsUseDispConfig != EGSYesNo.No)
			{
				IsUseDispConfig = other.IsUseDispConfig;
			}
			if (other.BeHitFXPath.Length != 0)
			{
				BeHitFXPath = other.BeHitFXPath;
			}
			if (other.BeHitFXPathAttachVer.Length != 0)
			{
				BeHitFXPathAttachVer = other.BeHitFXPathAttachVer;
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
			case 16u:
				UnitResID = input.ReadInt32();
				break;
			case 24u:
				SkillDamageType = (ESkillDamageType)input.ReadEnum();
				break;
			case 32u:
				HitItemFXType = (EHitItemFXType)input.ReadEnum();
				break;
			case 40u:
				HitPerformFXEventType = (EHitPerformFXEventType)input.ReadEnum();
				break;
			case 48u:
				FXWeight = input.ReadInt32();
				break;
			case 56u:
				IsUseDispConfig = (EGSYesNo)input.ReadEnum();
				break;
			case 66u:
				BeHitFXPath = input.ReadString();
				break;
			case 74u:
				BeHitFXPathAttachVer = input.ReadString();
				break;
			}
		}
	}
}
