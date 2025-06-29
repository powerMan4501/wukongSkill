using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStPlayerTransAttrDesc : IMessage<FUStPlayerTransAttrDesc>, IMessage, IEquatable<FUStPlayerTransAttrDesc>, IDeepCloneable<FUStPlayerTransAttrDesc>
{
	private static readonly MessageParser<FUStPlayerTransAttrDesc> _parser = new MessageParser<FUStPlayerTransAttrDesc>(() => new FUStPlayerTransAttrDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int hpBase_;

	private int atkBase_;

	private int defBase_;

	private int critRateBase_;

	private int critMultiplierBase_;

	private int critRateDefBase_;

	private int critDmgMulDefBase_;

	private int dmgAdditionBase_;

	private int dmgDefBase_;

	private int freezeAtkBase_;

	private int burnAtkBase_;

	private int poisonAtkBase_;

	private int thunderAtkBase_;

	private int freezeDefBase_;

	private int burnDefBase_;

	private int poisonDefBase_;

	private int thunderDefBase_;

	private int tenacityBase_;

	private int specialEnergyBase_;

	private int hpMul_;

	private int atkMul_;

	private int defMul_;

	private int critRateMul_;

	private int critMultiplierMul_;

	private int critRateDefMul_;

	private int critDmgMulDefMul_;

	private int dmgAdditionMul_;

	private int dmgDefMul_;

	private int freezeAtkMul_;

	private int burnAtkMul_;

	private int poisonAtkMul_;

	private int thunderAtkMul_;

	private int freezeDefMul_;

	private int burnDefMul_;

	private int poisonDefMul_;

	private int thunderDefMul_;

	private int blindSlotMul_;

	private int earPlugMul_;

	private int tenacityMul_;

	private string actorTag_ = "";

	private EGSYesNo inheritCurHp_;

	private int pELevelMul_;

	private int transBackPELevelMul_;

	private EPELevelInheritedType pELevelInheritedType_;

	public static MessageParser<FUStPlayerTransAttrDesc> Parser => _parser;

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

	public int HpBase
	{
		get
		{
			return hpBase_;
		}
		set
		{
			hpBase_ = value;
		}
	}

	public int AtkBase
	{
		get
		{
			return atkBase_;
		}
		set
		{
			atkBase_ = value;
		}
	}

	public int DefBase
	{
		get
		{
			return defBase_;
		}
		set
		{
			defBase_ = value;
		}
	}

	public int CritRateBase
	{
		get
		{
			return critRateBase_;
		}
		set
		{
			critRateBase_ = value;
		}
	}

	public int CritMultiplierBase
	{
		get
		{
			return critMultiplierBase_;
		}
		set
		{
			critMultiplierBase_ = value;
		}
	}

	public int CritRateDefBase
	{
		get
		{
			return critRateDefBase_;
		}
		set
		{
			critRateDefBase_ = value;
		}
	}

	public int CritDmgMulDefBase
	{
		get
		{
			return critDmgMulDefBase_;
		}
		set
		{
			critDmgMulDefBase_ = value;
		}
	}

	public int DmgAdditionBase
	{
		get
		{
			return dmgAdditionBase_;
		}
		set
		{
			dmgAdditionBase_ = value;
		}
	}

	public int DmgDefBase
	{
		get
		{
			return dmgDefBase_;
		}
		set
		{
			dmgDefBase_ = value;
		}
	}

	public int FreezeAtkBase
	{
		get
		{
			return freezeAtkBase_;
		}
		set
		{
			freezeAtkBase_ = value;
		}
	}

	public int BurnAtkBase
	{
		get
		{
			return burnAtkBase_;
		}
		set
		{
			burnAtkBase_ = value;
		}
	}

	public int PoisonAtkBase
	{
		get
		{
			return poisonAtkBase_;
		}
		set
		{
			poisonAtkBase_ = value;
		}
	}

	public int ThunderAtkBase
	{
		get
		{
			return thunderAtkBase_;
		}
		set
		{
			thunderAtkBase_ = value;
		}
	}

	public int FreezeDefBase
	{
		get
		{
			return freezeDefBase_;
		}
		set
		{
			freezeDefBase_ = value;
		}
	}

	public int BurnDefBase
	{
		get
		{
			return burnDefBase_;
		}
		set
		{
			burnDefBase_ = value;
		}
	}

	public int PoisonDefBase
	{
		get
		{
			return poisonDefBase_;
		}
		set
		{
			poisonDefBase_ = value;
		}
	}

	public int ThunderDefBase
	{
		get
		{
			return thunderDefBase_;
		}
		set
		{
			thunderDefBase_ = value;
		}
	}

	public int TenacityBase
	{
		get
		{
			return tenacityBase_;
		}
		set
		{
			tenacityBase_ = value;
		}
	}

	public int SpecialEnergyBase
	{
		get
		{
			return specialEnergyBase_;
		}
		set
		{
			specialEnergyBase_ = value;
		}
	}

	public int HpMul
	{
		get
		{
			return hpMul_;
		}
		set
		{
			hpMul_ = value;
		}
	}

	public int AtkMul
	{
		get
		{
			return atkMul_;
		}
		set
		{
			atkMul_ = value;
		}
	}

	public int DefMul
	{
		get
		{
			return defMul_;
		}
		set
		{
			defMul_ = value;
		}
	}

	public int CritRateMul
	{
		get
		{
			return critRateMul_;
		}
		set
		{
			critRateMul_ = value;
		}
	}

	public int CritMultiplierMul
	{
		get
		{
			return critMultiplierMul_;
		}
		set
		{
			critMultiplierMul_ = value;
		}
	}

	public int CritRateDefMul
	{
		get
		{
			return critRateDefMul_;
		}
		set
		{
			critRateDefMul_ = value;
		}
	}

	public int CritDmgMulDefMul
	{
		get
		{
			return critDmgMulDefMul_;
		}
		set
		{
			critDmgMulDefMul_ = value;
		}
	}

	public int DmgAdditionMul
	{
		get
		{
			return dmgAdditionMul_;
		}
		set
		{
			dmgAdditionMul_ = value;
		}
	}

	public int DmgDefMul
	{
		get
		{
			return dmgDefMul_;
		}
		set
		{
			dmgDefMul_ = value;
		}
	}

	public int FreezeAtkMul
	{
		get
		{
			return freezeAtkMul_;
		}
		set
		{
			freezeAtkMul_ = value;
		}
	}

	public int BurnAtkMul
	{
		get
		{
			return burnAtkMul_;
		}
		set
		{
			burnAtkMul_ = value;
		}
	}

	public int PoisonAtkMul
	{
		get
		{
			return poisonAtkMul_;
		}
		set
		{
			poisonAtkMul_ = value;
		}
	}

	public int ThunderAtkMul
	{
		get
		{
			return thunderAtkMul_;
		}
		set
		{
			thunderAtkMul_ = value;
		}
	}

	public int FreezeDefMul
	{
		get
		{
			return freezeDefMul_;
		}
		set
		{
			freezeDefMul_ = value;
		}
	}

	public int BurnDefMul
	{
		get
		{
			return burnDefMul_;
		}
		set
		{
			burnDefMul_ = value;
		}
	}

	public int PoisonDefMul
	{
		get
		{
			return poisonDefMul_;
		}
		set
		{
			poisonDefMul_ = value;
		}
	}

	public int ThunderDefMul
	{
		get
		{
			return thunderDefMul_;
		}
		set
		{
			thunderDefMul_ = value;
		}
	}

	public int BlindSlotMul
	{
		get
		{
			return blindSlotMul_;
		}
		set
		{
			blindSlotMul_ = value;
		}
	}

	public int EarPlugMul
	{
		get
		{
			return earPlugMul_;
		}
		set
		{
			earPlugMul_ = value;
		}
	}

	public int TenacityMul
	{
		get
		{
			return tenacityMul_;
		}
		set
		{
			tenacityMul_ = value;
		}
	}

	public string ActorTag
	{
		get
		{
			return actorTag_;
		}
		set
		{
			actorTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo InheritCurHp
	{
		get
		{
			return inheritCurHp_;
		}
		set
		{
			inheritCurHp_ = value;
		}
	}

	public int PELevelMul
	{
		get
		{
			return pELevelMul_;
		}
		set
		{
			pELevelMul_ = value;
		}
	}

	public int TransBackPELevelMul
	{
		get
		{
			return transBackPELevelMul_;
		}
		set
		{
			transBackPELevelMul_ = value;
		}
	}

	public EPELevelInheritedType PELevelInheritedType
	{
		get
		{
			return pELevelInheritedType_;
		}
		set
		{
			pELevelInheritedType_ = value;
		}
	}

	public FUStPlayerTransAttrDesc()
	{
	}

	public FUStPlayerTransAttrDesc(FUStPlayerTransAttrDesc other)
		: this()
	{
		iD_ = other.iD_;
		hpBase_ = other.hpBase_;
		atkBase_ = other.atkBase_;
		defBase_ = other.defBase_;
		critRateBase_ = other.critRateBase_;
		critMultiplierBase_ = other.critMultiplierBase_;
		critRateDefBase_ = other.critRateDefBase_;
		critDmgMulDefBase_ = other.critDmgMulDefBase_;
		dmgAdditionBase_ = other.dmgAdditionBase_;
		dmgDefBase_ = other.dmgDefBase_;
		freezeAtkBase_ = other.freezeAtkBase_;
		burnAtkBase_ = other.burnAtkBase_;
		poisonAtkBase_ = other.poisonAtkBase_;
		thunderAtkBase_ = other.thunderAtkBase_;
		freezeDefBase_ = other.freezeDefBase_;
		burnDefBase_ = other.burnDefBase_;
		poisonDefBase_ = other.poisonDefBase_;
		thunderDefBase_ = other.thunderDefBase_;
		tenacityBase_ = other.tenacityBase_;
		specialEnergyBase_ = other.specialEnergyBase_;
		hpMul_ = other.hpMul_;
		atkMul_ = other.atkMul_;
		defMul_ = other.defMul_;
		critRateMul_ = other.critRateMul_;
		critMultiplierMul_ = other.critMultiplierMul_;
		critRateDefMul_ = other.critRateDefMul_;
		critDmgMulDefMul_ = other.critDmgMulDefMul_;
		dmgAdditionMul_ = other.dmgAdditionMul_;
		dmgDefMul_ = other.dmgDefMul_;
		freezeAtkMul_ = other.freezeAtkMul_;
		burnAtkMul_ = other.burnAtkMul_;
		poisonAtkMul_ = other.poisonAtkMul_;
		thunderAtkMul_ = other.thunderAtkMul_;
		freezeDefMul_ = other.freezeDefMul_;
		burnDefMul_ = other.burnDefMul_;
		poisonDefMul_ = other.poisonDefMul_;
		thunderDefMul_ = other.thunderDefMul_;
		blindSlotMul_ = other.blindSlotMul_;
		earPlugMul_ = other.earPlugMul_;
		tenacityMul_ = other.tenacityMul_;
		actorTag_ = other.actorTag_;
		inheritCurHp_ = other.inheritCurHp_;
		pELevelMul_ = other.pELevelMul_;
		transBackPELevelMul_ = other.transBackPELevelMul_;
		pELevelInheritedType_ = other.pELevelInheritedType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPlayerTransAttrDesc Clone()
	{
		return new FUStPlayerTransAttrDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPlayerTransAttrDesc);
	}

	public bool Equals(FUStPlayerTransAttrDesc other)
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
		if (HpBase != other.HpBase)
		{
			return false;
		}
		if (AtkBase != other.AtkBase)
		{
			return false;
		}
		if (DefBase != other.DefBase)
		{
			return false;
		}
		if (CritRateBase != other.CritRateBase)
		{
			return false;
		}
		if (CritMultiplierBase != other.CritMultiplierBase)
		{
			return false;
		}
		if (CritRateDefBase != other.CritRateDefBase)
		{
			return false;
		}
		if (CritDmgMulDefBase != other.CritDmgMulDefBase)
		{
			return false;
		}
		if (DmgAdditionBase != other.DmgAdditionBase)
		{
			return false;
		}
		if (DmgDefBase != other.DmgDefBase)
		{
			return false;
		}
		if (FreezeAtkBase != other.FreezeAtkBase)
		{
			return false;
		}
		if (BurnAtkBase != other.BurnAtkBase)
		{
			return false;
		}
		if (PoisonAtkBase != other.PoisonAtkBase)
		{
			return false;
		}
		if (ThunderAtkBase != other.ThunderAtkBase)
		{
			return false;
		}
		if (FreezeDefBase != other.FreezeDefBase)
		{
			return false;
		}
		if (BurnDefBase != other.BurnDefBase)
		{
			return false;
		}
		if (PoisonDefBase != other.PoisonDefBase)
		{
			return false;
		}
		if (ThunderDefBase != other.ThunderDefBase)
		{
			return false;
		}
		if (TenacityBase != other.TenacityBase)
		{
			return false;
		}
		if (SpecialEnergyBase != other.SpecialEnergyBase)
		{
			return false;
		}
		if (HpMul != other.HpMul)
		{
			return false;
		}
		if (AtkMul != other.AtkMul)
		{
			return false;
		}
		if (DefMul != other.DefMul)
		{
			return false;
		}
		if (CritRateMul != other.CritRateMul)
		{
			return false;
		}
		if (CritMultiplierMul != other.CritMultiplierMul)
		{
			return false;
		}
		if (CritRateDefMul != other.CritRateDefMul)
		{
			return false;
		}
		if (CritDmgMulDefMul != other.CritDmgMulDefMul)
		{
			return false;
		}
		if (DmgAdditionMul != other.DmgAdditionMul)
		{
			return false;
		}
		if (DmgDefMul != other.DmgDefMul)
		{
			return false;
		}
		if (FreezeAtkMul != other.FreezeAtkMul)
		{
			return false;
		}
		if (BurnAtkMul != other.BurnAtkMul)
		{
			return false;
		}
		if (PoisonAtkMul != other.PoisonAtkMul)
		{
			return false;
		}
		if (ThunderAtkMul != other.ThunderAtkMul)
		{
			return false;
		}
		if (FreezeDefMul != other.FreezeDefMul)
		{
			return false;
		}
		if (BurnDefMul != other.BurnDefMul)
		{
			return false;
		}
		if (PoisonDefMul != other.PoisonDefMul)
		{
			return false;
		}
		if (ThunderDefMul != other.ThunderDefMul)
		{
			return false;
		}
		if (BlindSlotMul != other.BlindSlotMul)
		{
			return false;
		}
		if (EarPlugMul != other.EarPlugMul)
		{
			return false;
		}
		if (TenacityMul != other.TenacityMul)
		{
			return false;
		}
		if (ActorTag != other.ActorTag)
		{
			return false;
		}
		if (InheritCurHp != other.InheritCurHp)
		{
			return false;
		}
		if (PELevelMul != other.PELevelMul)
		{
			return false;
		}
		if (TransBackPELevelMul != other.TransBackPELevelMul)
		{
			return false;
		}
		if (PELevelInheritedType != other.PELevelInheritedType)
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
		if (HpBase != 0)
		{
			num ^= HpBase.GetHashCode();
		}
		if (AtkBase != 0)
		{
			num ^= AtkBase.GetHashCode();
		}
		if (DefBase != 0)
		{
			num ^= DefBase.GetHashCode();
		}
		if (CritRateBase != 0)
		{
			num ^= CritRateBase.GetHashCode();
		}
		if (CritMultiplierBase != 0)
		{
			num ^= CritMultiplierBase.GetHashCode();
		}
		if (CritRateDefBase != 0)
		{
			num ^= CritRateDefBase.GetHashCode();
		}
		if (CritDmgMulDefBase != 0)
		{
			num ^= CritDmgMulDefBase.GetHashCode();
		}
		if (DmgAdditionBase != 0)
		{
			num ^= DmgAdditionBase.GetHashCode();
		}
		if (DmgDefBase != 0)
		{
			num ^= DmgDefBase.GetHashCode();
		}
		if (FreezeAtkBase != 0)
		{
			num ^= FreezeAtkBase.GetHashCode();
		}
		if (BurnAtkBase != 0)
		{
			num ^= BurnAtkBase.GetHashCode();
		}
		if (PoisonAtkBase != 0)
		{
			num ^= PoisonAtkBase.GetHashCode();
		}
		if (ThunderAtkBase != 0)
		{
			num ^= ThunderAtkBase.GetHashCode();
		}
		if (FreezeDefBase != 0)
		{
			num ^= FreezeDefBase.GetHashCode();
		}
		if (BurnDefBase != 0)
		{
			num ^= BurnDefBase.GetHashCode();
		}
		if (PoisonDefBase != 0)
		{
			num ^= PoisonDefBase.GetHashCode();
		}
		if (ThunderDefBase != 0)
		{
			num ^= ThunderDefBase.GetHashCode();
		}
		if (TenacityBase != 0)
		{
			num ^= TenacityBase.GetHashCode();
		}
		if (SpecialEnergyBase != 0)
		{
			num ^= SpecialEnergyBase.GetHashCode();
		}
		if (HpMul != 0)
		{
			num ^= HpMul.GetHashCode();
		}
		if (AtkMul != 0)
		{
			num ^= AtkMul.GetHashCode();
		}
		if (DefMul != 0)
		{
			num ^= DefMul.GetHashCode();
		}
		if (CritRateMul != 0)
		{
			num ^= CritRateMul.GetHashCode();
		}
		if (CritMultiplierMul != 0)
		{
			num ^= CritMultiplierMul.GetHashCode();
		}
		if (CritRateDefMul != 0)
		{
			num ^= CritRateDefMul.GetHashCode();
		}
		if (CritDmgMulDefMul != 0)
		{
			num ^= CritDmgMulDefMul.GetHashCode();
		}
		if (DmgAdditionMul != 0)
		{
			num ^= DmgAdditionMul.GetHashCode();
		}
		if (DmgDefMul != 0)
		{
			num ^= DmgDefMul.GetHashCode();
		}
		if (FreezeAtkMul != 0)
		{
			num ^= FreezeAtkMul.GetHashCode();
		}
		if (BurnAtkMul != 0)
		{
			num ^= BurnAtkMul.GetHashCode();
		}
		if (PoisonAtkMul != 0)
		{
			num ^= PoisonAtkMul.GetHashCode();
		}
		if (ThunderAtkMul != 0)
		{
			num ^= ThunderAtkMul.GetHashCode();
		}
		if (FreezeDefMul != 0)
		{
			num ^= FreezeDefMul.GetHashCode();
		}
		if (BurnDefMul != 0)
		{
			num ^= BurnDefMul.GetHashCode();
		}
		if (PoisonDefMul != 0)
		{
			num ^= PoisonDefMul.GetHashCode();
		}
		if (ThunderDefMul != 0)
		{
			num ^= ThunderDefMul.GetHashCode();
		}
		if (BlindSlotMul != 0)
		{
			num ^= BlindSlotMul.GetHashCode();
		}
		if (EarPlugMul != 0)
		{
			num ^= EarPlugMul.GetHashCode();
		}
		if (TenacityMul != 0)
		{
			num ^= TenacityMul.GetHashCode();
		}
		if (ActorTag.Length != 0)
		{
			num ^= ActorTag.GetHashCode();
		}
		if (InheritCurHp != EGSYesNo.No)
		{
			num ^= InheritCurHp.GetHashCode();
		}
		if (PELevelMul != 0)
		{
			num ^= PELevelMul.GetHashCode();
		}
		if (TransBackPELevelMul != 0)
		{
			num ^= TransBackPELevelMul.GetHashCode();
		}
		if (PELevelInheritedType != EPELevelInheritedType.None)
		{
			num ^= PELevelInheritedType.GetHashCode();
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
		if (HpBase != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(HpBase);
		}
		if (AtkBase != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AtkBase);
		}
		if (DefBase != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DefBase);
		}
		if (CritRateBase != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CritRateBase);
		}
		if (CritMultiplierBase != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CritMultiplierBase);
		}
		if (CritRateDefBase != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CritRateDefBase);
		}
		if (CritDmgMulDefBase != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(CritDmgMulDefBase);
		}
		if (DmgAdditionBase != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(DmgAdditionBase);
		}
		if (DmgDefBase != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(DmgDefBase);
		}
		if (FreezeAtkBase != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(FreezeAtkBase);
		}
		if (BurnAtkBase != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(BurnAtkBase);
		}
		if (PoisonAtkBase != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PoisonAtkBase);
		}
		if (ThunderAtkBase != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(ThunderAtkBase);
		}
		if (FreezeDefBase != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(FreezeDefBase);
		}
		if (BurnDefBase != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(BurnDefBase);
		}
		if (PoisonDefBase != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(PoisonDefBase);
		}
		if (ThunderDefBase != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(ThunderDefBase);
		}
		if (TenacityBase != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(TenacityBase);
		}
		if (SpecialEnergyBase != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(SpecialEnergyBase);
		}
		if (HpMul != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(HpMul);
		}
		if (AtkMul != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(AtkMul);
		}
		if (DefMul != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(DefMul);
		}
		if (CritRateMul != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(CritRateMul);
		}
		if (CritMultiplierMul != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(CritMultiplierMul);
		}
		if (CritRateDefMul != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(CritRateDefMul);
		}
		if (CritDmgMulDefMul != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(CritDmgMulDefMul);
		}
		if (DmgAdditionMul != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(DmgAdditionMul);
		}
		if (DmgDefMul != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(DmgDefMul);
		}
		if (FreezeAtkMul != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(FreezeAtkMul);
		}
		if (BurnAtkMul != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(BurnAtkMul);
		}
		if (PoisonAtkMul != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(PoisonAtkMul);
		}
		if (ThunderAtkMul != 0)
		{
			output.WriteRawTag(136, 2);
			output.WriteInt32(ThunderAtkMul);
		}
		if (FreezeDefMul != 0)
		{
			output.WriteRawTag(144, 2);
			output.WriteInt32(FreezeDefMul);
		}
		if (BurnDefMul != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteInt32(BurnDefMul);
		}
		if (PoisonDefMul != 0)
		{
			output.WriteRawTag(160, 2);
			output.WriteInt32(PoisonDefMul);
		}
		if (ThunderDefMul != 0)
		{
			output.WriteRawTag(168, 2);
			output.WriteInt32(ThunderDefMul);
		}
		if (BlindSlotMul != 0)
		{
			output.WriteRawTag(176, 2);
			output.WriteInt32(BlindSlotMul);
		}
		if (EarPlugMul != 0)
		{
			output.WriteRawTag(184, 2);
			output.WriteInt32(EarPlugMul);
		}
		if (TenacityMul != 0)
		{
			output.WriteRawTag(192, 2);
			output.WriteInt32(TenacityMul);
		}
		if (ActorTag.Length != 0)
		{
			output.WriteRawTag(202, 2);
			output.WriteString(ActorTag);
		}
		if (InheritCurHp != EGSYesNo.No)
		{
			output.WriteRawTag(208, 2);
			output.WriteEnum((int)InheritCurHp);
		}
		if (PELevelMul != 0)
		{
			output.WriteRawTag(216, 2);
			output.WriteInt32(PELevelMul);
		}
		if (TransBackPELevelMul != 0)
		{
			output.WriteRawTag(224, 2);
			output.WriteInt32(TransBackPELevelMul);
		}
		if (PELevelInheritedType != EPELevelInheritedType.None)
		{
			output.WriteRawTag(232, 2);
			output.WriteEnum((int)PELevelInheritedType);
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
		if (HpBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HpBase);
		}
		if (AtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AtkBase);
		}
		if (DefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefBase);
		}
		if (CritRateBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritRateBase);
		}
		if (CritMultiplierBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritMultiplierBase);
		}
		if (CritRateDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritRateDefBase);
		}
		if (CritDmgMulDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritDmgMulDefBase);
		}
		if (DmgAdditionBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgAdditionBase);
		}
		if (DmgDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgDefBase);
		}
		if (FreezeAtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreezeAtkBase);
		}
		if (BurnAtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BurnAtkBase);
		}
		if (PoisonAtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PoisonAtkBase);
		}
		if (ThunderAtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ThunderAtkBase);
		}
		if (FreezeDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreezeDefBase);
		}
		if (BurnDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BurnDefBase);
		}
		if (PoisonDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PoisonDefBase);
		}
		if (ThunderDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ThunderDefBase);
		}
		if (TenacityBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TenacityBase);
		}
		if (SpecialEnergyBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpecialEnergyBase);
		}
		if (HpMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HpMul);
		}
		if (AtkMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AtkMul);
		}
		if (DefMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefMul);
		}
		if (CritRateMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CritRateMul);
		}
		if (CritMultiplierMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CritMultiplierMul);
		}
		if (CritRateDefMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CritRateDefMul);
		}
		if (CritDmgMulDefMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CritDmgMulDefMul);
		}
		if (DmgAdditionMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DmgAdditionMul);
		}
		if (DmgDefMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DmgDefMul);
		}
		if (FreezeAtkMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FreezeAtkMul);
		}
		if (BurnAtkMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BurnAtkMul);
		}
		if (PoisonAtkMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PoisonAtkMul);
		}
		if (ThunderAtkMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ThunderAtkMul);
		}
		if (FreezeDefMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FreezeDefMul);
		}
		if (BurnDefMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BurnDefMul);
		}
		if (PoisonDefMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PoisonDefMul);
		}
		if (ThunderDefMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ThunderDefMul);
		}
		if (BlindSlotMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BlindSlotMul);
		}
		if (EarPlugMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EarPlugMul);
		}
		if (TenacityMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TenacityMul);
		}
		if (ActorTag.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ActorTag);
		}
		if (InheritCurHp != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)InheritCurHp);
		}
		if (PELevelMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PELevelMul);
		}
		if (TransBackPELevelMul != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TransBackPELevelMul);
		}
		if (PELevelInheritedType != EPELevelInheritedType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)PELevelInheritedType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPlayerTransAttrDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.HpBase != 0)
			{
				HpBase = other.HpBase;
			}
			if (other.AtkBase != 0)
			{
				AtkBase = other.AtkBase;
			}
			if (other.DefBase != 0)
			{
				DefBase = other.DefBase;
			}
			if (other.CritRateBase != 0)
			{
				CritRateBase = other.CritRateBase;
			}
			if (other.CritMultiplierBase != 0)
			{
				CritMultiplierBase = other.CritMultiplierBase;
			}
			if (other.CritRateDefBase != 0)
			{
				CritRateDefBase = other.CritRateDefBase;
			}
			if (other.CritDmgMulDefBase != 0)
			{
				CritDmgMulDefBase = other.CritDmgMulDefBase;
			}
			if (other.DmgAdditionBase != 0)
			{
				DmgAdditionBase = other.DmgAdditionBase;
			}
			if (other.DmgDefBase != 0)
			{
				DmgDefBase = other.DmgDefBase;
			}
			if (other.FreezeAtkBase != 0)
			{
				FreezeAtkBase = other.FreezeAtkBase;
			}
			if (other.BurnAtkBase != 0)
			{
				BurnAtkBase = other.BurnAtkBase;
			}
			if (other.PoisonAtkBase != 0)
			{
				PoisonAtkBase = other.PoisonAtkBase;
			}
			if (other.ThunderAtkBase != 0)
			{
				ThunderAtkBase = other.ThunderAtkBase;
			}
			if (other.FreezeDefBase != 0)
			{
				FreezeDefBase = other.FreezeDefBase;
			}
			if (other.BurnDefBase != 0)
			{
				BurnDefBase = other.BurnDefBase;
			}
			if (other.PoisonDefBase != 0)
			{
				PoisonDefBase = other.PoisonDefBase;
			}
			if (other.ThunderDefBase != 0)
			{
				ThunderDefBase = other.ThunderDefBase;
			}
			if (other.TenacityBase != 0)
			{
				TenacityBase = other.TenacityBase;
			}
			if (other.SpecialEnergyBase != 0)
			{
				SpecialEnergyBase = other.SpecialEnergyBase;
			}
			if (other.HpMul != 0)
			{
				HpMul = other.HpMul;
			}
			if (other.AtkMul != 0)
			{
				AtkMul = other.AtkMul;
			}
			if (other.DefMul != 0)
			{
				DefMul = other.DefMul;
			}
			if (other.CritRateMul != 0)
			{
				CritRateMul = other.CritRateMul;
			}
			if (other.CritMultiplierMul != 0)
			{
				CritMultiplierMul = other.CritMultiplierMul;
			}
			if (other.CritRateDefMul != 0)
			{
				CritRateDefMul = other.CritRateDefMul;
			}
			if (other.CritDmgMulDefMul != 0)
			{
				CritDmgMulDefMul = other.CritDmgMulDefMul;
			}
			if (other.DmgAdditionMul != 0)
			{
				DmgAdditionMul = other.DmgAdditionMul;
			}
			if (other.DmgDefMul != 0)
			{
				DmgDefMul = other.DmgDefMul;
			}
			if (other.FreezeAtkMul != 0)
			{
				FreezeAtkMul = other.FreezeAtkMul;
			}
			if (other.BurnAtkMul != 0)
			{
				BurnAtkMul = other.BurnAtkMul;
			}
			if (other.PoisonAtkMul != 0)
			{
				PoisonAtkMul = other.PoisonAtkMul;
			}
			if (other.ThunderAtkMul != 0)
			{
				ThunderAtkMul = other.ThunderAtkMul;
			}
			if (other.FreezeDefMul != 0)
			{
				FreezeDefMul = other.FreezeDefMul;
			}
			if (other.BurnDefMul != 0)
			{
				BurnDefMul = other.BurnDefMul;
			}
			if (other.PoisonDefMul != 0)
			{
				PoisonDefMul = other.PoisonDefMul;
			}
			if (other.ThunderDefMul != 0)
			{
				ThunderDefMul = other.ThunderDefMul;
			}
			if (other.BlindSlotMul != 0)
			{
				BlindSlotMul = other.BlindSlotMul;
			}
			if (other.EarPlugMul != 0)
			{
				EarPlugMul = other.EarPlugMul;
			}
			if (other.TenacityMul != 0)
			{
				TenacityMul = other.TenacityMul;
			}
			if (other.ActorTag.Length != 0)
			{
				ActorTag = other.ActorTag;
			}
			if (other.InheritCurHp != EGSYesNo.No)
			{
				InheritCurHp = other.InheritCurHp;
			}
			if (other.PELevelMul != 0)
			{
				PELevelMul = other.PELevelMul;
			}
			if (other.TransBackPELevelMul != 0)
			{
				TransBackPELevelMul = other.TransBackPELevelMul;
			}
			if (other.PELevelInheritedType != EPELevelInheritedType.None)
			{
				PELevelInheritedType = other.PELevelInheritedType;
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
				HpBase = input.ReadInt32();
				break;
			case 24u:
				AtkBase = input.ReadInt32();
				break;
			case 32u:
				DefBase = input.ReadInt32();
				break;
			case 40u:
				CritRateBase = input.ReadInt32();
				break;
			case 48u:
				CritMultiplierBase = input.ReadInt32();
				break;
			case 56u:
				CritRateDefBase = input.ReadInt32();
				break;
			case 64u:
				CritDmgMulDefBase = input.ReadInt32();
				break;
			case 72u:
				DmgAdditionBase = input.ReadInt32();
				break;
			case 80u:
				DmgDefBase = input.ReadInt32();
				break;
			case 88u:
				FreezeAtkBase = input.ReadInt32();
				break;
			case 96u:
				BurnAtkBase = input.ReadInt32();
				break;
			case 104u:
				PoisonAtkBase = input.ReadInt32();
				break;
			case 112u:
				ThunderAtkBase = input.ReadInt32();
				break;
			case 120u:
				FreezeDefBase = input.ReadInt32();
				break;
			case 128u:
				BurnDefBase = input.ReadInt32();
				break;
			case 136u:
				PoisonDefBase = input.ReadInt32();
				break;
			case 144u:
				ThunderDefBase = input.ReadInt32();
				break;
			case 152u:
				TenacityBase = input.ReadInt32();
				break;
			case 160u:
				SpecialEnergyBase = input.ReadInt32();
				break;
			case 168u:
				HpMul = input.ReadInt32();
				break;
			case 176u:
				AtkMul = input.ReadInt32();
				break;
			case 184u:
				DefMul = input.ReadInt32();
				break;
			case 192u:
				CritRateMul = input.ReadInt32();
				break;
			case 200u:
				CritMultiplierMul = input.ReadInt32();
				break;
			case 208u:
				CritRateDefMul = input.ReadInt32();
				break;
			case 216u:
				CritDmgMulDefMul = input.ReadInt32();
				break;
			case 224u:
				DmgAdditionMul = input.ReadInt32();
				break;
			case 232u:
				DmgDefMul = input.ReadInt32();
				break;
			case 240u:
				FreezeAtkMul = input.ReadInt32();
				break;
			case 248u:
				BurnAtkMul = input.ReadInt32();
				break;
			case 256u:
				PoisonAtkMul = input.ReadInt32();
				break;
			case 264u:
				ThunderAtkMul = input.ReadInt32();
				break;
			case 272u:
				FreezeDefMul = input.ReadInt32();
				break;
			case 280u:
				BurnDefMul = input.ReadInt32();
				break;
			case 288u:
				PoisonDefMul = input.ReadInt32();
				break;
			case 296u:
				ThunderDefMul = input.ReadInt32();
				break;
			case 304u:
				BlindSlotMul = input.ReadInt32();
				break;
			case 312u:
				EarPlugMul = input.ReadInt32();
				break;
			case 320u:
				TenacityMul = input.ReadInt32();
				break;
			case 330u:
				ActorTag = input.ReadString();
				break;
			case 336u:
				InheritCurHp = (EGSYesNo)input.ReadEnum();
				break;
			case 344u:
				PELevelMul = input.ReadInt32();
				break;
			case 352u:
				TransBackPELevelMul = input.ReadInt32();
				break;
			case 360u:
				PELevelInheritedType = (EPELevelInheritedType)input.ReadEnum();
				break;
			}
		}
	}
}
