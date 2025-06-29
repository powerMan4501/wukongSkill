using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAttackHitFXMapDesc : IMessage<FUStAttackHitFXMapDesc>, IMessage, IEquatable<FUStAttackHitFXMapDesc>, IDeepCloneable<FUStAttackHitFXMapDesc>
{
	private static readonly MessageParser<FUStAttackHitFXMapDesc> _parser = new MessageParser<FUStAttackHitFXMapDesc>(() => new FUStAttackHitFXMapDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int unitResID_;

	private int fXWeight_;

	private ESkillDamageType skillDamageType_;

	private EHitPerformFXEventType hitPerformFXEventType_;

	private EGSYesNo isUseDispConfig_;

	private string hitFXPath_ = "";

	private string directionalFXPath_ = "";

	private string promptEffectMPCPath_ = "";

	private string blurLocMPCParamName_ = "";

	private static readonly FieldCodec<FUStMPCParamWithCurve> _repeated_mPCParamWithCurve_codec = FieldCodec.ForMessage(90u, FUStMPCParamWithCurve.Parser);

	private readonly RepeatedField<FUStMPCParamWithCurve> mPCParamWithCurve_ = new RepeatedField<FUStMPCParamWithCurve>();

	private float cameraShakeGap_;

	private string cameraShake_ = "";

	public static MessageParser<FUStAttackHitFXMapDesc> Parser => _parser;

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

	public string HitFXPath
	{
		get
		{
			return hitFXPath_;
		}
		set
		{
			hitFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DirectionalFXPath
	{
		get
		{
			return directionalFXPath_;
		}
		set
		{
			directionalFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PromptEffectMPCPath
	{
		get
		{
			return promptEffectMPCPath_;
		}
		set
		{
			promptEffectMPCPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BlurLocMPCParamName
	{
		get
		{
			return blurLocMPCParamName_;
		}
		set
		{
			blurLocMPCParamName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<FUStMPCParamWithCurve> MPCParamWithCurve => mPCParamWithCurve_;

	public float CameraShakeGap
	{
		get
		{
			return cameraShakeGap_;
		}
		set
		{
			cameraShakeGap_ = value;
		}
	}

	public string CameraShake
	{
		get
		{
			return cameraShake_;
		}
		set
		{
			cameraShake_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStAttackHitFXMapDesc()
	{
	}

	public FUStAttackHitFXMapDesc(FUStAttackHitFXMapDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitResID_ = other.unitResID_;
		fXWeight_ = other.fXWeight_;
		skillDamageType_ = other.skillDamageType_;
		hitPerformFXEventType_ = other.hitPerformFXEventType_;
		isUseDispConfig_ = other.isUseDispConfig_;
		hitFXPath_ = other.hitFXPath_;
		directionalFXPath_ = other.directionalFXPath_;
		promptEffectMPCPath_ = other.promptEffectMPCPath_;
		blurLocMPCParamName_ = other.blurLocMPCParamName_;
		mPCParamWithCurve_ = other.mPCParamWithCurve_.Clone();
		cameraShakeGap_ = other.cameraShakeGap_;
		cameraShake_ = other.cameraShake_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAttackHitFXMapDesc Clone()
	{
		return new FUStAttackHitFXMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAttackHitFXMapDesc);
	}

	public bool Equals(FUStAttackHitFXMapDesc other)
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
		if (FXWeight != other.FXWeight)
		{
			return false;
		}
		if (SkillDamageType != other.SkillDamageType)
		{
			return false;
		}
		if (HitPerformFXEventType != other.HitPerformFXEventType)
		{
			return false;
		}
		if (IsUseDispConfig != other.IsUseDispConfig)
		{
			return false;
		}
		if (HitFXPath != other.HitFXPath)
		{
			return false;
		}
		if (DirectionalFXPath != other.DirectionalFXPath)
		{
			return false;
		}
		if (PromptEffectMPCPath != other.PromptEffectMPCPath)
		{
			return false;
		}
		if (BlurLocMPCParamName != other.BlurLocMPCParamName)
		{
			return false;
		}
		if (!mPCParamWithCurve_.Equals(other.mPCParamWithCurve_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraShakeGap, other.CameraShakeGap))
		{
			return false;
		}
		if (CameraShake != other.CameraShake)
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
		if (FXWeight != 0)
		{
			num ^= FXWeight.GetHashCode();
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			num ^= SkillDamageType.GetHashCode();
		}
		if (HitPerformFXEventType != EHitPerformFXEventType.None)
		{
			num ^= HitPerformFXEventType.GetHashCode();
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			num ^= IsUseDispConfig.GetHashCode();
		}
		if (HitFXPath.Length != 0)
		{
			num ^= HitFXPath.GetHashCode();
		}
		if (DirectionalFXPath.Length != 0)
		{
			num ^= DirectionalFXPath.GetHashCode();
		}
		if (PromptEffectMPCPath.Length != 0)
		{
			num ^= PromptEffectMPCPath.GetHashCode();
		}
		if (BlurLocMPCParamName.Length != 0)
		{
			num ^= BlurLocMPCParamName.GetHashCode();
		}
		num ^= mPCParamWithCurve_.GetHashCode();
		if (CameraShakeGap != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraShakeGap);
		}
		if (CameraShake.Length != 0)
		{
			num ^= CameraShake.GetHashCode();
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
		if (FXWeight != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(FXWeight);
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)SkillDamageType);
		}
		if (HitPerformFXEventType != EHitPerformFXEventType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)HitPerformFXEventType);
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)IsUseDispConfig);
		}
		if (HitFXPath.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(HitFXPath);
		}
		if (DirectionalFXPath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(DirectionalFXPath);
		}
		if (PromptEffectMPCPath.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(PromptEffectMPCPath);
		}
		if (BlurLocMPCParamName.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(BlurLocMPCParamName);
		}
		mPCParamWithCurve_.WriteTo(output, _repeated_mPCParamWithCurve_codec);
		if (CameraShakeGap != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(CameraShakeGap);
		}
		if (CameraShake.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(CameraShake);
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
		if (FXWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FXWeight);
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkillDamageType);
		}
		if (HitPerformFXEventType != EHitPerformFXEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitPerformFXEventType);
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsUseDispConfig);
		}
		if (HitFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HitFXPath);
		}
		if (DirectionalFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DirectionalFXPath);
		}
		if (PromptEffectMPCPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PromptEffectMPCPath);
		}
		if (BlurLocMPCParamName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BlurLocMPCParamName);
		}
		num += mPCParamWithCurve_.CalculateSize(_repeated_mPCParamWithCurve_codec);
		if (CameraShakeGap != 0f)
		{
			num += 5;
		}
		if (CameraShake.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CameraShake);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAttackHitFXMapDesc other)
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
			if (other.FXWeight != 0)
			{
				FXWeight = other.FXWeight;
			}
			if (other.SkillDamageType != ESkillDamageType.NoneEffectAtk)
			{
				SkillDamageType = other.SkillDamageType;
			}
			if (other.HitPerformFXEventType != EHitPerformFXEventType.None)
			{
				HitPerformFXEventType = other.HitPerformFXEventType;
			}
			if (other.IsUseDispConfig != EGSYesNo.No)
			{
				IsUseDispConfig = other.IsUseDispConfig;
			}
			if (other.HitFXPath.Length != 0)
			{
				HitFXPath = other.HitFXPath;
			}
			if (other.DirectionalFXPath.Length != 0)
			{
				DirectionalFXPath = other.DirectionalFXPath;
			}
			if (other.PromptEffectMPCPath.Length != 0)
			{
				PromptEffectMPCPath = other.PromptEffectMPCPath;
			}
			if (other.BlurLocMPCParamName.Length != 0)
			{
				BlurLocMPCParamName = other.BlurLocMPCParamName;
			}
			mPCParamWithCurve_.Add(other.mPCParamWithCurve_);
			if (other.CameraShakeGap != 0f)
			{
				CameraShakeGap = other.CameraShakeGap;
			}
			if (other.CameraShake.Length != 0)
			{
				CameraShake = other.CameraShake;
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
				FXWeight = input.ReadInt32();
				break;
			case 32u:
				SkillDamageType = (ESkillDamageType)input.ReadEnum();
				break;
			case 40u:
				HitPerformFXEventType = (EHitPerformFXEventType)input.ReadEnum();
				break;
			case 48u:
				IsUseDispConfig = (EGSYesNo)input.ReadEnum();
				break;
			case 58u:
				HitFXPath = input.ReadString();
				break;
			case 66u:
				DirectionalFXPath = input.ReadString();
				break;
			case 74u:
				PromptEffectMPCPath = input.ReadString();
				break;
			case 82u:
				BlurLocMPCParamName = input.ReadString();
				break;
			case 90u:
				mPCParamWithCurve_.AddEntriesFrom(input, _repeated_mPCParamWithCurve_codec);
				break;
			case 101u:
				CameraShakeGap = input.ReadFloat();
				break;
			case 106u:
				CameraShake = input.ReadString();
				break;
			}
		}
	}
}
