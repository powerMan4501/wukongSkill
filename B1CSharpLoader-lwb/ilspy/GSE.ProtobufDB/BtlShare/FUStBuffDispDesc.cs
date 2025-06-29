using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStBuffDispDesc : IMessage<FUStBuffDispDesc>, IMessage, IEquatable<FUStBuffDispDesc>, IDeepCloneable<FUStBuffDispDesc>
{
	private static readonly MessageParser<FUStBuffDispDesc> _parser = new MessageParser<FUStBuffDispDesc>(() => new FUStBuffDispDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int buffID_;

	private int casterResID_;

	private int ownerResID_;

	private EGSYesNo isUseDispConfig_;

	private static readonly FieldCodec<FUStFXSetting> _repeated_enterFX_codec = FieldCodec.ForMessage(50u, FUStFXSetting.Parser);

	private readonly RepeatedField<FUStFXSetting> enterFX_ = new RepeatedField<FUStFXSetting>();

	private static readonly FieldCodec<FUStFloatCurveToParam> _repeated_tickingCurveParam_codec = FieldCodec.ForMessage(58u, FUStFloatCurveToParam.Parser);

	private readonly RepeatedField<FUStFloatCurveToParam> tickingCurveParam_ = new RepeatedField<FUStFloatCurveToParam>();

	private static readonly FieldCodec<FUStFXSetting> _repeated_almostLeaveFX_codec = FieldCodec.ForMessage(66u, FUStFXSetting.Parser);

	private readonly RepeatedField<FUStFXSetting> almostLeaveFX_ = new RepeatedField<FUStFXSetting>();

	private static readonly FieldCodec<FUStFXSetting> _repeated_leaveFX_codec = FieldCodec.ForMessage(74u, FUStFXSetting.Parser);

	private readonly RepeatedField<FUStFXSetting> leaveFX_ = new RepeatedField<FUStFXSetting>();

	private static readonly FieldCodec<FUStFXSetting> _repeated_damageFXSetting_codec = FieldCodec.ForMessage(82u, FUStFXSetting.Parser);

	private readonly RepeatedField<FUStFXSetting> damageFXSetting_ = new RepeatedField<FUStFXSetting>();

	private static readonly FieldCodec<string> _repeated_materialSetting_codec = FieldCodec.ForString(90u);

	private readonly RepeatedField<string> materialSetting_ = new RepeatedField<string>();

	private EGSYesNo forceDisplay_;

	private EGSYesNo allowReplay_;

	public static MessageParser<FUStBuffDispDesc> Parser => _parser;

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

	public int BuffID
	{
		get
		{
			return buffID_;
		}
		set
		{
			buffID_ = value;
		}
	}

	public int CasterResID
	{
		get
		{
			return casterResID_;
		}
		set
		{
			casterResID_ = value;
		}
	}

	public int OwnerResID
	{
		get
		{
			return ownerResID_;
		}
		set
		{
			ownerResID_ = value;
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

	public RepeatedField<FUStFXSetting> EnterFX => enterFX_;

	public RepeatedField<FUStFloatCurveToParam> TickingCurveParam => tickingCurveParam_;

	public RepeatedField<FUStFXSetting> AlmostLeaveFX => almostLeaveFX_;

	public RepeatedField<FUStFXSetting> LeaveFX => leaveFX_;

	public RepeatedField<FUStFXSetting> DamageFXSetting => damageFXSetting_;

	public RepeatedField<string> MaterialSetting => materialSetting_;

	public EGSYesNo ForceDisplay
	{
		get
		{
			return forceDisplay_;
		}
		set
		{
			forceDisplay_ = value;
		}
	}

	public EGSYesNo AllowReplay
	{
		get
		{
			return allowReplay_;
		}
		set
		{
			allowReplay_ = value;
		}
	}

	public FUStBuffDispDesc()
	{
	}

	public FUStBuffDispDesc(FUStBuffDispDesc other)
		: this()
	{
		iD_ = other.iD_;
		buffID_ = other.buffID_;
		casterResID_ = other.casterResID_;
		ownerResID_ = other.ownerResID_;
		isUseDispConfig_ = other.isUseDispConfig_;
		enterFX_ = other.enterFX_.Clone();
		tickingCurveParam_ = other.tickingCurveParam_.Clone();
		almostLeaveFX_ = other.almostLeaveFX_.Clone();
		leaveFX_ = other.leaveFX_.Clone();
		damageFXSetting_ = other.damageFXSetting_.Clone();
		materialSetting_ = other.materialSetting_.Clone();
		forceDisplay_ = other.forceDisplay_;
		allowReplay_ = other.allowReplay_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffDispDesc Clone()
	{
		return new FUStBuffDispDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffDispDesc);
	}

	public bool Equals(FUStBuffDispDesc other)
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
		if (BuffID != other.BuffID)
		{
			return false;
		}
		if (CasterResID != other.CasterResID)
		{
			return false;
		}
		if (OwnerResID != other.OwnerResID)
		{
			return false;
		}
		if (IsUseDispConfig != other.IsUseDispConfig)
		{
			return false;
		}
		if (!enterFX_.Equals(other.enterFX_))
		{
			return false;
		}
		if (!tickingCurveParam_.Equals(other.tickingCurveParam_))
		{
			return false;
		}
		if (!almostLeaveFX_.Equals(other.almostLeaveFX_))
		{
			return false;
		}
		if (!leaveFX_.Equals(other.leaveFX_))
		{
			return false;
		}
		if (!damageFXSetting_.Equals(other.damageFXSetting_))
		{
			return false;
		}
		if (!materialSetting_.Equals(other.materialSetting_))
		{
			return false;
		}
		if (ForceDisplay != other.ForceDisplay)
		{
			return false;
		}
		if (AllowReplay != other.AllowReplay)
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
		if (BuffID != 0)
		{
			num ^= BuffID.GetHashCode();
		}
		if (CasterResID != 0)
		{
			num ^= CasterResID.GetHashCode();
		}
		if (OwnerResID != 0)
		{
			num ^= OwnerResID.GetHashCode();
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			num ^= IsUseDispConfig.GetHashCode();
		}
		num ^= enterFX_.GetHashCode();
		num ^= tickingCurveParam_.GetHashCode();
		num ^= almostLeaveFX_.GetHashCode();
		num ^= leaveFX_.GetHashCode();
		num ^= damageFXSetting_.GetHashCode();
		num ^= materialSetting_.GetHashCode();
		if (ForceDisplay != EGSYesNo.No)
		{
			num ^= ForceDisplay.GetHashCode();
		}
		if (AllowReplay != EGSYesNo.No)
		{
			num ^= AllowReplay.GetHashCode();
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
		if (BuffID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffID);
		}
		if (CasterResID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CasterResID);
		}
		if (OwnerResID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(OwnerResID);
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsUseDispConfig);
		}
		enterFX_.WriteTo(output, _repeated_enterFX_codec);
		tickingCurveParam_.WriteTo(output, _repeated_tickingCurveParam_codec);
		almostLeaveFX_.WriteTo(output, _repeated_almostLeaveFX_codec);
		leaveFX_.WriteTo(output, _repeated_leaveFX_codec);
		damageFXSetting_.WriteTo(output, _repeated_damageFXSetting_codec);
		materialSetting_.WriteTo(output, _repeated_materialSetting_codec);
		if (ForceDisplay != EGSYesNo.No)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)ForceDisplay);
		}
		if (AllowReplay != EGSYesNo.No)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)AllowReplay);
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
		if (BuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffID);
		}
		if (CasterResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CasterResID);
		}
		if (OwnerResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OwnerResID);
		}
		if (IsUseDispConfig != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsUseDispConfig);
		}
		num += enterFX_.CalculateSize(_repeated_enterFX_codec);
		num += tickingCurveParam_.CalculateSize(_repeated_tickingCurveParam_codec);
		num += almostLeaveFX_.CalculateSize(_repeated_almostLeaveFX_codec);
		num += leaveFX_.CalculateSize(_repeated_leaveFX_codec);
		num += damageFXSetting_.CalculateSize(_repeated_damageFXSetting_codec);
		num += materialSetting_.CalculateSize(_repeated_materialSetting_codec);
		if (ForceDisplay != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ForceDisplay);
		}
		if (AllowReplay != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AllowReplay);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffDispDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BuffID != 0)
			{
				BuffID = other.BuffID;
			}
			if (other.CasterResID != 0)
			{
				CasterResID = other.CasterResID;
			}
			if (other.OwnerResID != 0)
			{
				OwnerResID = other.OwnerResID;
			}
			if (other.IsUseDispConfig != EGSYesNo.No)
			{
				IsUseDispConfig = other.IsUseDispConfig;
			}
			enterFX_.Add(other.enterFX_);
			tickingCurveParam_.Add(other.tickingCurveParam_);
			almostLeaveFX_.Add(other.almostLeaveFX_);
			leaveFX_.Add(other.leaveFX_);
			damageFXSetting_.Add(other.damageFXSetting_);
			materialSetting_.Add(other.materialSetting_);
			if (other.ForceDisplay != EGSYesNo.No)
			{
				ForceDisplay = other.ForceDisplay;
			}
			if (other.AllowReplay != EGSYesNo.No)
			{
				AllowReplay = other.AllowReplay;
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
				BuffID = input.ReadInt32();
				break;
			case 24u:
				CasterResID = input.ReadInt32();
				break;
			case 32u:
				OwnerResID = input.ReadInt32();
				break;
			case 40u:
				IsUseDispConfig = (EGSYesNo)input.ReadEnum();
				break;
			case 50u:
				enterFX_.AddEntriesFrom(input, _repeated_enterFX_codec);
				break;
			case 58u:
				tickingCurveParam_.AddEntriesFrom(input, _repeated_tickingCurveParam_codec);
				break;
			case 66u:
				almostLeaveFX_.AddEntriesFrom(input, _repeated_almostLeaveFX_codec);
				break;
			case 74u:
				leaveFX_.AddEntriesFrom(input, _repeated_leaveFX_codec);
				break;
			case 82u:
				damageFXSetting_.AddEntriesFrom(input, _repeated_damageFXSetting_codec);
				break;
			case 90u:
				materialSetting_.AddEntriesFrom(input, _repeated_materialSetting_codec);
				break;
			case 96u:
				ForceDisplay = (EGSYesNo)input.ReadEnum();
				break;
			case 104u:
				AllowReplay = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
