using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStUnitBattleInfoExtendDesc : IMessage<FUStUnitBattleInfoExtendDesc>, IMessage, IEquatable<FUStUnitBattleInfoExtendDesc>, IDeepCloneable<FUStUnitBattleInfoExtendDesc>
{
	private static readonly MessageParser<FUStUnitBattleInfoExtendDesc> _parser = new MessageParser<FUStUnitBattleInfoExtendDesc>(() => new FUStUnitBattleInfoExtendDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string unitName_ = "";

	private EUnitQualityType qualityType_;

	private int levelNumericalStrength_;

	private int hPFixedDM_;

	private float trueDamageRatio_;

	private float immobilityHPRadio_;

	private EBGUBloodBarType bloodBarType_;

	private EGSYesNo canFindInvisibleUnit_;

	private static readonly FieldCodec<int> _repeated_dropRule_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> dropRule_ = new RepeatedField<int>();

	private EGSYesNo noDropExpAndSprit_;

	private float defaultFreezeDefValue_;

	private float defaultBurnDefValue_;

	private float defaultPoisonDefValue_;

	private float defaultThunderDefValue_;

	private int hatredQuality_;

	private int localizationTag_;

	private string foliageFadeScaleCurve_ = "";

	private EUnitDefeatedType unitDefeatedType_;

	private EGSYesNo manuallyEnableVigourDrop_;

	private int vigourDropId_;

	private int vigourDroperDispBuff_;

	private int vigourDroperEnhancedBuff_;

	private int vigourDroperBattleBuff_;

	private ELockCamMode lockCamMode_;

	private int defaultCamID_;

	private EGSYesNo blockCollapseArmorIsShowInUI_;

	private float maxBlockCollapseArmorValue_;

	private int hatredPerceptionXYDistance_;

	private int hatredPerceptionZDistance_;

	private int searchAOTargetXYDistance_;

	private int searchAOTargetZDistance_;

	private int leaveAOTargetXYDistance_;

	private int leaveAOTargetZDistance_;

	private EGSYesNo gameCountNotUpdateAttr_;

	private int beImmoblizedConfigIndex_;

	private int abnormalDispAttackerID_;

	private int abnormalDispVictimID_;

	private EGSYesNo canSuicideDeadDropItem_;

	private EGSYesNo beHitFXAttach_;

	private string guard_ = "";

	public static MessageParser<FUStUnitBattleInfoExtendDesc> Parser => _parser;

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

	public string UnitName
	{
		get
		{
			return unitName_;
		}
		set
		{
			unitName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EUnitQualityType QualityType
	{
		get
		{
			return qualityType_;
		}
		set
		{
			qualityType_ = value;
		}
	}

	public int LevelNumericalStrength
	{
		get
		{
			return levelNumericalStrength_;
		}
		set
		{
			levelNumericalStrength_ = value;
		}
	}

	public int HPFixedDM
	{
		get
		{
			return hPFixedDM_;
		}
		set
		{
			hPFixedDM_ = value;
		}
	}

	public float TrueDamageRatio
	{
		get
		{
			return trueDamageRatio_;
		}
		set
		{
			trueDamageRatio_ = value;
		}
	}

	public float ImmobilityHPRadio
	{
		get
		{
			return immobilityHPRadio_;
		}
		set
		{
			immobilityHPRadio_ = value;
		}
	}

	public EBGUBloodBarType BloodBarType
	{
		get
		{
			return bloodBarType_;
		}
		set
		{
			bloodBarType_ = value;
		}
	}

	public EGSYesNo CanFindInvisibleUnit
	{
		get
		{
			return canFindInvisibleUnit_;
		}
		set
		{
			canFindInvisibleUnit_ = value;
		}
	}

	public RepeatedField<int> DropRule => dropRule_;

	public EGSYesNo NoDropExpAndSprit
	{
		get
		{
			return noDropExpAndSprit_;
		}
		set
		{
			noDropExpAndSprit_ = value;
		}
	}

	public float DefaultFreezeDefValue
	{
		get
		{
			return defaultFreezeDefValue_;
		}
		set
		{
			defaultFreezeDefValue_ = value;
		}
	}

	public float DefaultBurnDefValue
	{
		get
		{
			return defaultBurnDefValue_;
		}
		set
		{
			defaultBurnDefValue_ = value;
		}
	}

	public float DefaultPoisonDefValue
	{
		get
		{
			return defaultPoisonDefValue_;
		}
		set
		{
			defaultPoisonDefValue_ = value;
		}
	}

	public float DefaultThunderDefValue
	{
		get
		{
			return defaultThunderDefValue_;
		}
		set
		{
			defaultThunderDefValue_ = value;
		}
	}

	public int HatredQuality
	{
		get
		{
			return hatredQuality_;
		}
		set
		{
			hatredQuality_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public string FoliageFadeScaleCurve
	{
		get
		{
			return foliageFadeScaleCurve_;
		}
		set
		{
			foliageFadeScaleCurve_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EUnitDefeatedType UnitDefeatedType
	{
		get
		{
			return unitDefeatedType_;
		}
		set
		{
			unitDefeatedType_ = value;
		}
	}

	public EGSYesNo ManuallyEnableVigourDrop
	{
		get
		{
			return manuallyEnableVigourDrop_;
		}
		set
		{
			manuallyEnableVigourDrop_ = value;
		}
	}

	public int VigourDropId
	{
		get
		{
			return vigourDropId_;
		}
		set
		{
			vigourDropId_ = value;
		}
	}

	public int VigourDroperDispBuff
	{
		get
		{
			return vigourDroperDispBuff_;
		}
		set
		{
			vigourDroperDispBuff_ = value;
		}
	}

	public int VigourDroperEnhancedBuff
	{
		get
		{
			return vigourDroperEnhancedBuff_;
		}
		set
		{
			vigourDroperEnhancedBuff_ = value;
		}
	}

	public int VigourDroperBattleBuff
	{
		get
		{
			return vigourDroperBattleBuff_;
		}
		set
		{
			vigourDroperBattleBuff_ = value;
		}
	}

	public ELockCamMode LockCamMode
	{
		get
		{
			return lockCamMode_;
		}
		set
		{
			lockCamMode_ = value;
		}
	}

	public int DefaultCamID
	{
		get
		{
			return defaultCamID_;
		}
		set
		{
			defaultCamID_ = value;
		}
	}

	public EGSYesNo BlockCollapseArmorIsShowInUI
	{
		get
		{
			return blockCollapseArmorIsShowInUI_;
		}
		set
		{
			blockCollapseArmorIsShowInUI_ = value;
		}
	}

	public float MaxBlockCollapseArmorValue
	{
		get
		{
			return maxBlockCollapseArmorValue_;
		}
		set
		{
			maxBlockCollapseArmorValue_ = value;
		}
	}

	public int HatredPerceptionXYDistance
	{
		get
		{
			return hatredPerceptionXYDistance_;
		}
		set
		{
			hatredPerceptionXYDistance_ = value;
		}
	}

	public int HatredPerceptionZDistance
	{
		get
		{
			return hatredPerceptionZDistance_;
		}
		set
		{
			hatredPerceptionZDistance_ = value;
		}
	}

	public int SearchAOTargetXYDistance
	{
		get
		{
			return searchAOTargetXYDistance_;
		}
		set
		{
			searchAOTargetXYDistance_ = value;
		}
	}

	public int SearchAOTargetZDistance
	{
		get
		{
			return searchAOTargetZDistance_;
		}
		set
		{
			searchAOTargetZDistance_ = value;
		}
	}

	public int LeaveAOTargetXYDistance
	{
		get
		{
			return leaveAOTargetXYDistance_;
		}
		set
		{
			leaveAOTargetXYDistance_ = value;
		}
	}

	public int LeaveAOTargetZDistance
	{
		get
		{
			return leaveAOTargetZDistance_;
		}
		set
		{
			leaveAOTargetZDistance_ = value;
		}
	}

	public EGSYesNo GameCountNotUpdateAttr
	{
		get
		{
			return gameCountNotUpdateAttr_;
		}
		set
		{
			gameCountNotUpdateAttr_ = value;
		}
	}

	public int BeImmoblizedConfigIndex
	{
		get
		{
			return beImmoblizedConfigIndex_;
		}
		set
		{
			beImmoblizedConfigIndex_ = value;
		}
	}

	public int AbnormalDispAttackerID
	{
		get
		{
			return abnormalDispAttackerID_;
		}
		set
		{
			abnormalDispAttackerID_ = value;
		}
	}

	public int AbnormalDispVictimID
	{
		get
		{
			return abnormalDispVictimID_;
		}
		set
		{
			abnormalDispVictimID_ = value;
		}
	}

	public EGSYesNo CanSuicideDeadDropItem
	{
		get
		{
			return canSuicideDeadDropItem_;
		}
		set
		{
			canSuicideDeadDropItem_ = value;
		}
	}

	public EGSYesNo BeHitFXAttach
	{
		get
		{
			return beHitFXAttach_;
		}
		set
		{
			beHitFXAttach_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitBattleInfoExtendDesc()
	{
	}

	public FUStUnitBattleInfoExtendDesc(FUStUnitBattleInfoExtendDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitName_ = other.unitName_;
		qualityType_ = other.qualityType_;
		levelNumericalStrength_ = other.levelNumericalStrength_;
		hPFixedDM_ = other.hPFixedDM_;
		trueDamageRatio_ = other.trueDamageRatio_;
		immobilityHPRadio_ = other.immobilityHPRadio_;
		bloodBarType_ = other.bloodBarType_;
		canFindInvisibleUnit_ = other.canFindInvisibleUnit_;
		dropRule_ = other.dropRule_.Clone();
		noDropExpAndSprit_ = other.noDropExpAndSprit_;
		defaultFreezeDefValue_ = other.defaultFreezeDefValue_;
		defaultBurnDefValue_ = other.defaultBurnDefValue_;
		defaultPoisonDefValue_ = other.defaultPoisonDefValue_;
		defaultThunderDefValue_ = other.defaultThunderDefValue_;
		hatredQuality_ = other.hatredQuality_;
		localizationTag_ = other.localizationTag_;
		foliageFadeScaleCurve_ = other.foliageFadeScaleCurve_;
		unitDefeatedType_ = other.unitDefeatedType_;
		manuallyEnableVigourDrop_ = other.manuallyEnableVigourDrop_;
		vigourDropId_ = other.vigourDropId_;
		vigourDroperDispBuff_ = other.vigourDroperDispBuff_;
		vigourDroperEnhancedBuff_ = other.vigourDroperEnhancedBuff_;
		vigourDroperBattleBuff_ = other.vigourDroperBattleBuff_;
		lockCamMode_ = other.lockCamMode_;
		defaultCamID_ = other.defaultCamID_;
		blockCollapseArmorIsShowInUI_ = other.blockCollapseArmorIsShowInUI_;
		maxBlockCollapseArmorValue_ = other.maxBlockCollapseArmorValue_;
		hatredPerceptionXYDistance_ = other.hatredPerceptionXYDistance_;
		hatredPerceptionZDistance_ = other.hatredPerceptionZDistance_;
		searchAOTargetXYDistance_ = other.searchAOTargetXYDistance_;
		searchAOTargetZDistance_ = other.searchAOTargetZDistance_;
		leaveAOTargetXYDistance_ = other.leaveAOTargetXYDistance_;
		leaveAOTargetZDistance_ = other.leaveAOTargetZDistance_;
		gameCountNotUpdateAttr_ = other.gameCountNotUpdateAttr_;
		beImmoblizedConfigIndex_ = other.beImmoblizedConfigIndex_;
		abnormalDispAttackerID_ = other.abnormalDispAttackerID_;
		abnormalDispVictimID_ = other.abnormalDispVictimID_;
		canSuicideDeadDropItem_ = other.canSuicideDeadDropItem_;
		beHitFXAttach_ = other.beHitFXAttach_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitBattleInfoExtendDesc Clone()
	{
		return new FUStUnitBattleInfoExtendDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitBattleInfoExtendDesc);
	}

	public bool Equals(FUStUnitBattleInfoExtendDesc other)
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
		if (UnitName != other.UnitName)
		{
			return false;
		}
		if (QualityType != other.QualityType)
		{
			return false;
		}
		if (LevelNumericalStrength != other.LevelNumericalStrength)
		{
			return false;
		}
		if (HPFixedDM != other.HPFixedDM)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TrueDamageRatio, other.TrueDamageRatio))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ImmobilityHPRadio, other.ImmobilityHPRadio))
		{
			return false;
		}
		if (BloodBarType != other.BloodBarType)
		{
			return false;
		}
		if (CanFindInvisibleUnit != other.CanFindInvisibleUnit)
		{
			return false;
		}
		if (!dropRule_.Equals(other.dropRule_))
		{
			return false;
		}
		if (NoDropExpAndSprit != other.NoDropExpAndSprit)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DefaultFreezeDefValue, other.DefaultFreezeDefValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DefaultBurnDefValue, other.DefaultBurnDefValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DefaultPoisonDefValue, other.DefaultPoisonDefValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DefaultThunderDefValue, other.DefaultThunderDefValue))
		{
			return false;
		}
		if (HatredQuality != other.HatredQuality)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (FoliageFadeScaleCurve != other.FoliageFadeScaleCurve)
		{
			return false;
		}
		if (UnitDefeatedType != other.UnitDefeatedType)
		{
			return false;
		}
		if (ManuallyEnableVigourDrop != other.ManuallyEnableVigourDrop)
		{
			return false;
		}
		if (VigourDropId != other.VigourDropId)
		{
			return false;
		}
		if (VigourDroperDispBuff != other.VigourDroperDispBuff)
		{
			return false;
		}
		if (VigourDroperEnhancedBuff != other.VigourDroperEnhancedBuff)
		{
			return false;
		}
		if (VigourDroperBattleBuff != other.VigourDroperBattleBuff)
		{
			return false;
		}
		if (LockCamMode != other.LockCamMode)
		{
			return false;
		}
		if (DefaultCamID != other.DefaultCamID)
		{
			return false;
		}
		if (BlockCollapseArmorIsShowInUI != other.BlockCollapseArmorIsShowInUI)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxBlockCollapseArmorValue, other.MaxBlockCollapseArmorValue))
		{
			return false;
		}
		if (HatredPerceptionXYDistance != other.HatredPerceptionXYDistance)
		{
			return false;
		}
		if (HatredPerceptionZDistance != other.HatredPerceptionZDistance)
		{
			return false;
		}
		if (SearchAOTargetXYDistance != other.SearchAOTargetXYDistance)
		{
			return false;
		}
		if (SearchAOTargetZDistance != other.SearchAOTargetZDistance)
		{
			return false;
		}
		if (LeaveAOTargetXYDistance != other.LeaveAOTargetXYDistance)
		{
			return false;
		}
		if (LeaveAOTargetZDistance != other.LeaveAOTargetZDistance)
		{
			return false;
		}
		if (GameCountNotUpdateAttr != other.GameCountNotUpdateAttr)
		{
			return false;
		}
		if (BeImmoblizedConfigIndex != other.BeImmoblizedConfigIndex)
		{
			return false;
		}
		if (AbnormalDispAttackerID != other.AbnormalDispAttackerID)
		{
			return false;
		}
		if (AbnormalDispVictimID != other.AbnormalDispVictimID)
		{
			return false;
		}
		if (CanSuicideDeadDropItem != other.CanSuicideDeadDropItem)
		{
			return false;
		}
		if (BeHitFXAttach != other.BeHitFXAttach)
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (UnitName.Length != 0)
		{
			num ^= UnitName.GetHashCode();
		}
		if (QualityType != EUnitQualityType.None)
		{
			num ^= QualityType.GetHashCode();
		}
		if (LevelNumericalStrength != 0)
		{
			num ^= LevelNumericalStrength.GetHashCode();
		}
		if (HPFixedDM != 0)
		{
			num ^= HPFixedDM.GetHashCode();
		}
		if (TrueDamageRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TrueDamageRatio);
		}
		if (ImmobilityHPRadio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ImmobilityHPRadio);
		}
		if (BloodBarType != EBGUBloodBarType.None)
		{
			num ^= BloodBarType.GetHashCode();
		}
		if (CanFindInvisibleUnit != EGSYesNo.No)
		{
			num ^= CanFindInvisibleUnit.GetHashCode();
		}
		num ^= dropRule_.GetHashCode();
		if (NoDropExpAndSprit != EGSYesNo.No)
		{
			num ^= NoDropExpAndSprit.GetHashCode();
		}
		if (DefaultFreezeDefValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DefaultFreezeDefValue);
		}
		if (DefaultBurnDefValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DefaultBurnDefValue);
		}
		if (DefaultPoisonDefValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DefaultPoisonDefValue);
		}
		if (DefaultThunderDefValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DefaultThunderDefValue);
		}
		if (HatredQuality != 0)
		{
			num ^= HatredQuality.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (FoliageFadeScaleCurve.Length != 0)
		{
			num ^= FoliageFadeScaleCurve.GetHashCode();
		}
		if (UnitDefeatedType != EUnitDefeatedType.None)
		{
			num ^= UnitDefeatedType.GetHashCode();
		}
		if (ManuallyEnableVigourDrop != EGSYesNo.No)
		{
			num ^= ManuallyEnableVigourDrop.GetHashCode();
		}
		if (VigourDropId != 0)
		{
			num ^= VigourDropId.GetHashCode();
		}
		if (VigourDroperDispBuff != 0)
		{
			num ^= VigourDroperDispBuff.GetHashCode();
		}
		if (VigourDroperEnhancedBuff != 0)
		{
			num ^= VigourDroperEnhancedBuff.GetHashCode();
		}
		if (VigourDroperBattleBuff != 0)
		{
			num ^= VigourDroperBattleBuff.GetHashCode();
		}
		if (LockCamMode != ELockCamMode.Soul)
		{
			num ^= LockCamMode.GetHashCode();
		}
		if (DefaultCamID != 0)
		{
			num ^= DefaultCamID.GetHashCode();
		}
		if (BlockCollapseArmorIsShowInUI != EGSYesNo.No)
		{
			num ^= BlockCollapseArmorIsShowInUI.GetHashCode();
		}
		if (MaxBlockCollapseArmorValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxBlockCollapseArmorValue);
		}
		if (HatredPerceptionXYDistance != 0)
		{
			num ^= HatredPerceptionXYDistance.GetHashCode();
		}
		if (HatredPerceptionZDistance != 0)
		{
			num ^= HatredPerceptionZDistance.GetHashCode();
		}
		if (SearchAOTargetXYDistance != 0)
		{
			num ^= SearchAOTargetXYDistance.GetHashCode();
		}
		if (SearchAOTargetZDistance != 0)
		{
			num ^= SearchAOTargetZDistance.GetHashCode();
		}
		if (LeaveAOTargetXYDistance != 0)
		{
			num ^= LeaveAOTargetXYDistance.GetHashCode();
		}
		if (LeaveAOTargetZDistance != 0)
		{
			num ^= LeaveAOTargetZDistance.GetHashCode();
		}
		if (GameCountNotUpdateAttr != EGSYesNo.No)
		{
			num ^= GameCountNotUpdateAttr.GetHashCode();
		}
		if (BeImmoblizedConfigIndex != 0)
		{
			num ^= BeImmoblizedConfigIndex.GetHashCode();
		}
		if (AbnormalDispAttackerID != 0)
		{
			num ^= AbnormalDispAttackerID.GetHashCode();
		}
		if (AbnormalDispVictimID != 0)
		{
			num ^= AbnormalDispVictimID.GetHashCode();
		}
		if (CanSuicideDeadDropItem != EGSYesNo.No)
		{
			num ^= CanSuicideDeadDropItem.GetHashCode();
		}
		if (BeHitFXAttach != EGSYesNo.No)
		{
			num ^= BeHitFXAttach.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
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
		if (UnitName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UnitName);
		}
		if (QualityType != EUnitQualityType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)QualityType);
		}
		if (LevelNumericalStrength != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LevelNumericalStrength);
		}
		if (HPFixedDM != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(HPFixedDM);
		}
		if (TrueDamageRatio != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(TrueDamageRatio);
		}
		if (ImmobilityHPRadio != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(ImmobilityHPRadio);
		}
		if (BloodBarType != EBGUBloodBarType.None)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)BloodBarType);
		}
		if (CanFindInvisibleUnit != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)CanFindInvisibleUnit);
		}
		dropRule_.WriteTo(output, _repeated_dropRule_codec);
		if (NoDropExpAndSprit != EGSYesNo.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)NoDropExpAndSprit);
		}
		if (DefaultFreezeDefValue != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(DefaultFreezeDefValue);
		}
		if (DefaultBurnDefValue != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(DefaultBurnDefValue);
		}
		if (DefaultPoisonDefValue != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(DefaultPoisonDefValue);
		}
		if (DefaultThunderDefValue != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(DefaultThunderDefValue);
		}
		if (HatredQuality != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(HatredQuality);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(LocalizationTag);
		}
		if (FoliageFadeScaleCurve.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(FoliageFadeScaleCurve);
		}
		if (UnitDefeatedType != EUnitDefeatedType.None)
		{
			output.WriteRawTag(152, 1);
			output.WriteEnum((int)UnitDefeatedType);
		}
		if (ManuallyEnableVigourDrop != EGSYesNo.No)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)ManuallyEnableVigourDrop);
		}
		if (VigourDropId != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(VigourDropId);
		}
		if (VigourDroperDispBuff != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(VigourDroperDispBuff);
		}
		if (VigourDroperEnhancedBuff != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(VigourDroperEnhancedBuff);
		}
		if (VigourDroperBattleBuff != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(VigourDroperBattleBuff);
		}
		if (LockCamMode != ELockCamMode.Soul)
		{
			output.WriteRawTag(200, 1);
			output.WriteEnum((int)LockCamMode);
		}
		if (DefaultCamID != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(DefaultCamID);
		}
		if (BlockCollapseArmorIsShowInUI != EGSYesNo.No)
		{
			output.WriteRawTag(216, 1);
			output.WriteEnum((int)BlockCollapseArmorIsShowInUI);
		}
		if (MaxBlockCollapseArmorValue != 0f)
		{
			output.WriteRawTag(229, 1);
			output.WriteFloat(MaxBlockCollapseArmorValue);
		}
		if (HatredPerceptionXYDistance != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(HatredPerceptionXYDistance);
		}
		if (HatredPerceptionZDistance != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(HatredPerceptionZDistance);
		}
		if (SearchAOTargetXYDistance != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(SearchAOTargetXYDistance);
		}
		if (SearchAOTargetZDistance != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(SearchAOTargetZDistance);
		}
		if (LeaveAOTargetXYDistance != 0)
		{
			output.WriteRawTag(136, 2);
			output.WriteInt32(LeaveAOTargetXYDistance);
		}
		if (LeaveAOTargetZDistance != 0)
		{
			output.WriteRawTag(144, 2);
			output.WriteInt32(LeaveAOTargetZDistance);
		}
		if (GameCountNotUpdateAttr != EGSYesNo.No)
		{
			output.WriteRawTag(152, 2);
			output.WriteEnum((int)GameCountNotUpdateAttr);
		}
		if (BeImmoblizedConfigIndex != 0)
		{
			output.WriteRawTag(160, 2);
			output.WriteInt32(BeImmoblizedConfigIndex);
		}
		if (AbnormalDispAttackerID != 0)
		{
			output.WriteRawTag(168, 2);
			output.WriteInt32(AbnormalDispAttackerID);
		}
		if (AbnormalDispVictimID != 0)
		{
			output.WriteRawTag(176, 2);
			output.WriteInt32(AbnormalDispVictimID);
		}
		if (CanSuicideDeadDropItem != EGSYesNo.No)
		{
			output.WriteRawTag(184, 2);
			output.WriteEnum((int)CanSuicideDeadDropItem);
		}
		if (BeHitFXAttach != EGSYesNo.No)
		{
			output.WriteRawTag(192, 2);
			output.WriteEnum((int)BeHitFXAttach);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(202, 2);
			output.WriteString(Guard);
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
		if (UnitName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitName);
		}
		if (QualityType != EUnitQualityType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)QualityType);
		}
		if (LevelNumericalStrength != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelNumericalStrength);
		}
		if (HPFixedDM != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HPFixedDM);
		}
		if (TrueDamageRatio != 0f)
		{
			num += 5;
		}
		if (ImmobilityHPRadio != 0f)
		{
			num += 5;
		}
		if (BloodBarType != EBGUBloodBarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BloodBarType);
		}
		if (CanFindInvisibleUnit != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanFindInvisibleUnit);
		}
		num += dropRule_.CalculateSize(_repeated_dropRule_codec);
		if (NoDropExpAndSprit != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NoDropExpAndSprit);
		}
		if (DefaultFreezeDefValue != 0f)
		{
			num += 5;
		}
		if (DefaultBurnDefValue != 0f)
		{
			num += 5;
		}
		if (DefaultPoisonDefValue != 0f)
		{
			num += 5;
		}
		if (DefaultThunderDefValue != 0f)
		{
			num += 5;
		}
		if (HatredQuality != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HatredQuality);
		}
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (FoliageFadeScaleCurve.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(FoliageFadeScaleCurve);
		}
		if (UnitDefeatedType != EUnitDefeatedType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)UnitDefeatedType);
		}
		if (ManuallyEnableVigourDrop != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ManuallyEnableVigourDrop);
		}
		if (VigourDropId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(VigourDropId);
		}
		if (VigourDroperDispBuff != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(VigourDroperDispBuff);
		}
		if (VigourDroperEnhancedBuff != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(VigourDroperEnhancedBuff);
		}
		if (VigourDroperBattleBuff != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(VigourDroperBattleBuff);
		}
		if (LockCamMode != ELockCamMode.Soul)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)LockCamMode);
		}
		if (DefaultCamID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultCamID);
		}
		if (BlockCollapseArmorIsShowInUI != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BlockCollapseArmorIsShowInUI);
		}
		if (MaxBlockCollapseArmorValue != 0f)
		{
			num += 6;
		}
		if (HatredPerceptionXYDistance != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HatredPerceptionXYDistance);
		}
		if (HatredPerceptionZDistance != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HatredPerceptionZDistance);
		}
		if (SearchAOTargetXYDistance != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SearchAOTargetXYDistance);
		}
		if (SearchAOTargetZDistance != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SearchAOTargetZDistance);
		}
		if (LeaveAOTargetXYDistance != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LeaveAOTargetXYDistance);
		}
		if (LeaveAOTargetZDistance != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LeaveAOTargetZDistance);
		}
		if (GameCountNotUpdateAttr != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)GameCountNotUpdateAttr);
		}
		if (BeImmoblizedConfigIndex != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BeImmoblizedConfigIndex);
		}
		if (AbnormalDispAttackerID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AbnormalDispAttackerID);
		}
		if (AbnormalDispVictimID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AbnormalDispVictimID);
		}
		if (CanSuicideDeadDropItem != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CanSuicideDeadDropItem);
		}
		if (BeHitFXAttach != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BeHitFXAttach);
		}
		if (Guard.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitBattleInfoExtendDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitName.Length != 0)
			{
				UnitName = other.UnitName;
			}
			if (other.QualityType != EUnitQualityType.None)
			{
				QualityType = other.QualityType;
			}
			if (other.LevelNumericalStrength != 0)
			{
				LevelNumericalStrength = other.LevelNumericalStrength;
			}
			if (other.HPFixedDM != 0)
			{
				HPFixedDM = other.HPFixedDM;
			}
			if (other.TrueDamageRatio != 0f)
			{
				TrueDamageRatio = other.TrueDamageRatio;
			}
			if (other.ImmobilityHPRadio != 0f)
			{
				ImmobilityHPRadio = other.ImmobilityHPRadio;
			}
			if (other.BloodBarType != EBGUBloodBarType.None)
			{
				BloodBarType = other.BloodBarType;
			}
			if (other.CanFindInvisibleUnit != EGSYesNo.No)
			{
				CanFindInvisibleUnit = other.CanFindInvisibleUnit;
			}
			dropRule_.Add(other.dropRule_);
			if (other.NoDropExpAndSprit != EGSYesNo.No)
			{
				NoDropExpAndSprit = other.NoDropExpAndSprit;
			}
			if (other.DefaultFreezeDefValue != 0f)
			{
				DefaultFreezeDefValue = other.DefaultFreezeDefValue;
			}
			if (other.DefaultBurnDefValue != 0f)
			{
				DefaultBurnDefValue = other.DefaultBurnDefValue;
			}
			if (other.DefaultPoisonDefValue != 0f)
			{
				DefaultPoisonDefValue = other.DefaultPoisonDefValue;
			}
			if (other.DefaultThunderDefValue != 0f)
			{
				DefaultThunderDefValue = other.DefaultThunderDefValue;
			}
			if (other.HatredQuality != 0)
			{
				HatredQuality = other.HatredQuality;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.FoliageFadeScaleCurve.Length != 0)
			{
				FoliageFadeScaleCurve = other.FoliageFadeScaleCurve;
			}
			if (other.UnitDefeatedType != EUnitDefeatedType.None)
			{
				UnitDefeatedType = other.UnitDefeatedType;
			}
			if (other.ManuallyEnableVigourDrop != EGSYesNo.No)
			{
				ManuallyEnableVigourDrop = other.ManuallyEnableVigourDrop;
			}
			if (other.VigourDropId != 0)
			{
				VigourDropId = other.VigourDropId;
			}
			if (other.VigourDroperDispBuff != 0)
			{
				VigourDroperDispBuff = other.VigourDroperDispBuff;
			}
			if (other.VigourDroperEnhancedBuff != 0)
			{
				VigourDroperEnhancedBuff = other.VigourDroperEnhancedBuff;
			}
			if (other.VigourDroperBattleBuff != 0)
			{
				VigourDroperBattleBuff = other.VigourDroperBattleBuff;
			}
			if (other.LockCamMode != ELockCamMode.Soul)
			{
				LockCamMode = other.LockCamMode;
			}
			if (other.DefaultCamID != 0)
			{
				DefaultCamID = other.DefaultCamID;
			}
			if (other.BlockCollapseArmorIsShowInUI != EGSYesNo.No)
			{
				BlockCollapseArmorIsShowInUI = other.BlockCollapseArmorIsShowInUI;
			}
			if (other.MaxBlockCollapseArmorValue != 0f)
			{
				MaxBlockCollapseArmorValue = other.MaxBlockCollapseArmorValue;
			}
			if (other.HatredPerceptionXYDistance != 0)
			{
				HatredPerceptionXYDistance = other.HatredPerceptionXYDistance;
			}
			if (other.HatredPerceptionZDistance != 0)
			{
				HatredPerceptionZDistance = other.HatredPerceptionZDistance;
			}
			if (other.SearchAOTargetXYDistance != 0)
			{
				SearchAOTargetXYDistance = other.SearchAOTargetXYDistance;
			}
			if (other.SearchAOTargetZDistance != 0)
			{
				SearchAOTargetZDistance = other.SearchAOTargetZDistance;
			}
			if (other.LeaveAOTargetXYDistance != 0)
			{
				LeaveAOTargetXYDistance = other.LeaveAOTargetXYDistance;
			}
			if (other.LeaveAOTargetZDistance != 0)
			{
				LeaveAOTargetZDistance = other.LeaveAOTargetZDistance;
			}
			if (other.GameCountNotUpdateAttr != EGSYesNo.No)
			{
				GameCountNotUpdateAttr = other.GameCountNotUpdateAttr;
			}
			if (other.BeImmoblizedConfigIndex != 0)
			{
				BeImmoblizedConfigIndex = other.BeImmoblizedConfigIndex;
			}
			if (other.AbnormalDispAttackerID != 0)
			{
				AbnormalDispAttackerID = other.AbnormalDispAttackerID;
			}
			if (other.AbnormalDispVictimID != 0)
			{
				AbnormalDispVictimID = other.AbnormalDispVictimID;
			}
			if (other.CanSuicideDeadDropItem != EGSYesNo.No)
			{
				CanSuicideDeadDropItem = other.CanSuicideDeadDropItem;
			}
			if (other.BeHitFXAttach != EGSYesNo.No)
			{
				BeHitFXAttach = other.BeHitFXAttach;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
			case 18u:
				UnitName = input.ReadString();
				break;
			case 24u:
				QualityType = (EUnitQualityType)input.ReadEnum();
				break;
			case 32u:
				LevelNumericalStrength = input.ReadInt32();
				break;
			case 40u:
				HPFixedDM = input.ReadInt32();
				break;
			case 53u:
				TrueDamageRatio = input.ReadFloat();
				break;
			case 61u:
				ImmobilityHPRadio = input.ReadFloat();
				break;
			case 64u:
				BloodBarType = (EBGUBloodBarType)input.ReadEnum();
				break;
			case 72u:
				CanFindInvisibleUnit = (EGSYesNo)input.ReadEnum();
				break;
			case 80u:
			case 82u:
				dropRule_.AddEntriesFrom(input, _repeated_dropRule_codec);
				break;
			case 88u:
				NoDropExpAndSprit = (EGSYesNo)input.ReadEnum();
				break;
			case 101u:
				DefaultFreezeDefValue = input.ReadFloat();
				break;
			case 109u:
				DefaultBurnDefValue = input.ReadFloat();
				break;
			case 117u:
				DefaultPoisonDefValue = input.ReadFloat();
				break;
			case 125u:
				DefaultThunderDefValue = input.ReadFloat();
				break;
			case 128u:
				HatredQuality = input.ReadInt32();
				break;
			case 136u:
				LocalizationTag = input.ReadInt32();
				break;
			case 146u:
				FoliageFadeScaleCurve = input.ReadString();
				break;
			case 152u:
				UnitDefeatedType = (EUnitDefeatedType)input.ReadEnum();
				break;
			case 160u:
				ManuallyEnableVigourDrop = (EGSYesNo)input.ReadEnum();
				break;
			case 168u:
				VigourDropId = input.ReadInt32();
				break;
			case 176u:
				VigourDroperDispBuff = input.ReadInt32();
				break;
			case 184u:
				VigourDroperEnhancedBuff = input.ReadInt32();
				break;
			case 192u:
				VigourDroperBattleBuff = input.ReadInt32();
				break;
			case 200u:
				LockCamMode = (ELockCamMode)input.ReadEnum();
				break;
			case 208u:
				DefaultCamID = input.ReadInt32();
				break;
			case 216u:
				BlockCollapseArmorIsShowInUI = (EGSYesNo)input.ReadEnum();
				break;
			case 229u:
				MaxBlockCollapseArmorValue = input.ReadFloat();
				break;
			case 232u:
				HatredPerceptionXYDistance = input.ReadInt32();
				break;
			case 240u:
				HatredPerceptionZDistance = input.ReadInt32();
				break;
			case 248u:
				SearchAOTargetXYDistance = input.ReadInt32();
				break;
			case 256u:
				SearchAOTargetZDistance = input.ReadInt32();
				break;
			case 264u:
				LeaveAOTargetXYDistance = input.ReadInt32();
				break;
			case 272u:
				LeaveAOTargetZDistance = input.ReadInt32();
				break;
			case 280u:
				GameCountNotUpdateAttr = (EGSYesNo)input.ReadEnum();
				break;
			case 288u:
				BeImmoblizedConfigIndex = input.ReadInt32();
				break;
			case 296u:
				AbnormalDispAttackerID = input.ReadInt32();
				break;
			case 304u:
				AbnormalDispVictimID = input.ReadInt32();
				break;
			case 312u:
				CanSuicideDeadDropItem = (EGSYesNo)input.ReadEnum();
				break;
			case 320u:
				BeHitFXAttach = (EGSYesNo)input.ReadEnum();
				break;
			case 330u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
