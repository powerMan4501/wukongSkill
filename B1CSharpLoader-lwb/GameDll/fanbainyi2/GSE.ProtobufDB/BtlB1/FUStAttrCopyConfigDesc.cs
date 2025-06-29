using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAttrCopyConfigDesc : IMessage<FUStAttrCopyConfigDesc>, IMessage, IEquatable<FUStAttrCopyConfigDesc>, IDeepCloneable<FUStAttrCopyConfigDesc>
{
	private static readonly MessageParser<FUStAttrCopyConfigDesc> _parser = new MessageParser<FUStAttrCopyConfigDesc>(() => new FUStAttrCopyConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo isCopyHpCostRatio_;

	private int hPBase_;

	private int hPRatio_;

	private int mPBase_;

	private int mPRatio_;

	private int atkBase_;

	private int atkRatio_;

	private int defBase_;

	private int defRatio_;

	private int dmgAdditionBase_;

	private int dmgAdditionRatio_;

	private int dmgDefBase_;

	private int dmgDefRatio_;

	private int critRateBase_;

	private int critRateRatio_;

	private int critMultiplierBase_;

	private int critMultiplierRatio_;

	private int freezeDefBase_;

	private int freezeDefRatio_;

	private int burnDefBase_;

	private int burnDefRatio_;

	private int poisonDefBase_;

	private int poisonDefRatio_;

	private int thunderDefBase_;

	private int thunderDefRatio_;

	public static MessageParser<FUStAttrCopyConfigDesc> Parser => _parser;

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

	public EGSYesNo IsCopyHpCostRatio
	{
		get
		{
			return isCopyHpCostRatio_;
		}
		set
		{
			isCopyHpCostRatio_ = value;
		}
	}

	public int HPBase
	{
		get
		{
			return hPBase_;
		}
		set
		{
			hPBase_ = value;
		}
	}

	public int HPRatio
	{
		get
		{
			return hPRatio_;
		}
		set
		{
			hPRatio_ = value;
		}
	}

	public int MPBase
	{
		get
		{
			return mPBase_;
		}
		set
		{
			mPBase_ = value;
		}
	}

	public int MPRatio
	{
		get
		{
			return mPRatio_;
		}
		set
		{
			mPRatio_ = value;
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

	public int AtkRatio
	{
		get
		{
			return atkRatio_;
		}
		set
		{
			atkRatio_ = value;
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

	public int DefRatio
	{
		get
		{
			return defRatio_;
		}
		set
		{
			defRatio_ = value;
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

	public int DmgAdditionRatio
	{
		get
		{
			return dmgAdditionRatio_;
		}
		set
		{
			dmgAdditionRatio_ = value;
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

	public int DmgDefRatio
	{
		get
		{
			return dmgDefRatio_;
		}
		set
		{
			dmgDefRatio_ = value;
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

	public int CritRateRatio
	{
		get
		{
			return critRateRatio_;
		}
		set
		{
			critRateRatio_ = value;
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

	public int CritMultiplierRatio
	{
		get
		{
			return critMultiplierRatio_;
		}
		set
		{
			critMultiplierRatio_ = value;
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

	public int FreezeDefRatio
	{
		get
		{
			return freezeDefRatio_;
		}
		set
		{
			freezeDefRatio_ = value;
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

	public int BurnDefRatio
	{
		get
		{
			return burnDefRatio_;
		}
		set
		{
			burnDefRatio_ = value;
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

	public int PoisonDefRatio
	{
		get
		{
			return poisonDefRatio_;
		}
		set
		{
			poisonDefRatio_ = value;
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

	public int ThunderDefRatio
	{
		get
		{
			return thunderDefRatio_;
		}
		set
		{
			thunderDefRatio_ = value;
		}
	}

	public FUStAttrCopyConfigDesc()
	{
	}

	public FUStAttrCopyConfigDesc(FUStAttrCopyConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		isCopyHpCostRatio_ = other.isCopyHpCostRatio_;
		hPBase_ = other.hPBase_;
		hPRatio_ = other.hPRatio_;
		mPBase_ = other.mPBase_;
		mPRatio_ = other.mPRatio_;
		atkBase_ = other.atkBase_;
		atkRatio_ = other.atkRatio_;
		defBase_ = other.defBase_;
		defRatio_ = other.defRatio_;
		dmgAdditionBase_ = other.dmgAdditionBase_;
		dmgAdditionRatio_ = other.dmgAdditionRatio_;
		dmgDefBase_ = other.dmgDefBase_;
		dmgDefRatio_ = other.dmgDefRatio_;
		critRateBase_ = other.critRateBase_;
		critRateRatio_ = other.critRateRatio_;
		critMultiplierBase_ = other.critMultiplierBase_;
		critMultiplierRatio_ = other.critMultiplierRatio_;
		freezeDefBase_ = other.freezeDefBase_;
		freezeDefRatio_ = other.freezeDefRatio_;
		burnDefBase_ = other.burnDefBase_;
		burnDefRatio_ = other.burnDefRatio_;
		poisonDefBase_ = other.poisonDefBase_;
		poisonDefRatio_ = other.poisonDefRatio_;
		thunderDefBase_ = other.thunderDefBase_;
		thunderDefRatio_ = other.thunderDefRatio_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAttrCopyConfigDesc Clone()
	{
		return new FUStAttrCopyConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAttrCopyConfigDesc);
	}

	public bool Equals(FUStAttrCopyConfigDesc other)
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
		if (IsCopyHpCostRatio != other.IsCopyHpCostRatio)
		{
			return false;
		}
		if (HPBase != other.HPBase)
		{
			return false;
		}
		if (HPRatio != other.HPRatio)
		{
			return false;
		}
		if (MPBase != other.MPBase)
		{
			return false;
		}
		if (MPRatio != other.MPRatio)
		{
			return false;
		}
		if (AtkBase != other.AtkBase)
		{
			return false;
		}
		if (AtkRatio != other.AtkRatio)
		{
			return false;
		}
		if (DefBase != other.DefBase)
		{
			return false;
		}
		if (DefRatio != other.DefRatio)
		{
			return false;
		}
		if (DmgAdditionBase != other.DmgAdditionBase)
		{
			return false;
		}
		if (DmgAdditionRatio != other.DmgAdditionRatio)
		{
			return false;
		}
		if (DmgDefBase != other.DmgDefBase)
		{
			return false;
		}
		if (DmgDefRatio != other.DmgDefRatio)
		{
			return false;
		}
		if (CritRateBase != other.CritRateBase)
		{
			return false;
		}
		if (CritRateRatio != other.CritRateRatio)
		{
			return false;
		}
		if (CritMultiplierBase != other.CritMultiplierBase)
		{
			return false;
		}
		if (CritMultiplierRatio != other.CritMultiplierRatio)
		{
			return false;
		}
		if (FreezeDefBase != other.FreezeDefBase)
		{
			return false;
		}
		if (FreezeDefRatio != other.FreezeDefRatio)
		{
			return false;
		}
		if (BurnDefBase != other.BurnDefBase)
		{
			return false;
		}
		if (BurnDefRatio != other.BurnDefRatio)
		{
			return false;
		}
		if (PoisonDefBase != other.PoisonDefBase)
		{
			return false;
		}
		if (PoisonDefRatio != other.PoisonDefRatio)
		{
			return false;
		}
		if (ThunderDefBase != other.ThunderDefBase)
		{
			return false;
		}
		if (ThunderDefRatio != other.ThunderDefRatio)
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
		if (IsCopyHpCostRatio != EGSYesNo.No)
		{
			num ^= IsCopyHpCostRatio.GetHashCode();
		}
		if (HPBase != 0)
		{
			num ^= HPBase.GetHashCode();
		}
		if (HPRatio != 0)
		{
			num ^= HPRatio.GetHashCode();
		}
		if (MPBase != 0)
		{
			num ^= MPBase.GetHashCode();
		}
		if (MPRatio != 0)
		{
			num ^= MPRatio.GetHashCode();
		}
		if (AtkBase != 0)
		{
			num ^= AtkBase.GetHashCode();
		}
		if (AtkRatio != 0)
		{
			num ^= AtkRatio.GetHashCode();
		}
		if (DefBase != 0)
		{
			num ^= DefBase.GetHashCode();
		}
		if (DefRatio != 0)
		{
			num ^= DefRatio.GetHashCode();
		}
		if (DmgAdditionBase != 0)
		{
			num ^= DmgAdditionBase.GetHashCode();
		}
		if (DmgAdditionRatio != 0)
		{
			num ^= DmgAdditionRatio.GetHashCode();
		}
		if (DmgDefBase != 0)
		{
			num ^= DmgDefBase.GetHashCode();
		}
		if (DmgDefRatio != 0)
		{
			num ^= DmgDefRatio.GetHashCode();
		}
		if (CritRateBase != 0)
		{
			num ^= CritRateBase.GetHashCode();
		}
		if (CritRateRatio != 0)
		{
			num ^= CritRateRatio.GetHashCode();
		}
		if (CritMultiplierBase != 0)
		{
			num ^= CritMultiplierBase.GetHashCode();
		}
		if (CritMultiplierRatio != 0)
		{
			num ^= CritMultiplierRatio.GetHashCode();
		}
		if (FreezeDefBase != 0)
		{
			num ^= FreezeDefBase.GetHashCode();
		}
		if (FreezeDefRatio != 0)
		{
			num ^= FreezeDefRatio.GetHashCode();
		}
		if (BurnDefBase != 0)
		{
			num ^= BurnDefBase.GetHashCode();
		}
		if (BurnDefRatio != 0)
		{
			num ^= BurnDefRatio.GetHashCode();
		}
		if (PoisonDefBase != 0)
		{
			num ^= PoisonDefBase.GetHashCode();
		}
		if (PoisonDefRatio != 0)
		{
			num ^= PoisonDefRatio.GetHashCode();
		}
		if (ThunderDefBase != 0)
		{
			num ^= ThunderDefBase.GetHashCode();
		}
		if (ThunderDefRatio != 0)
		{
			num ^= ThunderDefRatio.GetHashCode();
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
		if (IsCopyHpCostRatio != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsCopyHpCostRatio);
		}
		if (HPBase != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(HPBase);
		}
		if (HPRatio != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(HPRatio);
		}
		if (MPBase != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MPBase);
		}
		if (MPRatio != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MPRatio);
		}
		if (AtkBase != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(AtkBase);
		}
		if (AtkRatio != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(AtkRatio);
		}
		if (DefBase != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(DefBase);
		}
		if (DefRatio != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(DefRatio);
		}
		if (DmgAdditionBase != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(DmgAdditionBase);
		}
		if (DmgAdditionRatio != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(DmgAdditionRatio);
		}
		if (DmgDefBase != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(DmgDefBase);
		}
		if (DmgDefRatio != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(DmgDefRatio);
		}
		if (CritRateBase != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(CritRateBase);
		}
		if (CritRateRatio != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(CritRateRatio);
		}
		if (CritMultiplierBase != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(CritMultiplierBase);
		}
		if (CritMultiplierRatio != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(CritMultiplierRatio);
		}
		if (FreezeDefBase != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(FreezeDefBase);
		}
		if (FreezeDefRatio != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(FreezeDefRatio);
		}
		if (BurnDefBase != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(BurnDefBase);
		}
		if (BurnDefRatio != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(BurnDefRatio);
		}
		if (PoisonDefBase != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(PoisonDefBase);
		}
		if (PoisonDefRatio != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(PoisonDefRatio);
		}
		if (ThunderDefBase != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(ThunderDefBase);
		}
		if (ThunderDefRatio != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(ThunderDefRatio);
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
		if (IsCopyHpCostRatio != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsCopyHpCostRatio);
		}
		if (HPBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HPBase);
		}
		if (HPRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HPRatio);
		}
		if (MPBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MPBase);
		}
		if (MPRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MPRatio);
		}
		if (AtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AtkBase);
		}
		if (AtkRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AtkRatio);
		}
		if (DefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefBase);
		}
		if (DefRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefRatio);
		}
		if (DmgAdditionBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgAdditionBase);
		}
		if (DmgAdditionRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgAdditionRatio);
		}
		if (DmgDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgDefBase);
		}
		if (DmgDefRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgDefRatio);
		}
		if (CritRateBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritRateBase);
		}
		if (CritRateRatio != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CritRateRatio);
		}
		if (CritMultiplierBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CritMultiplierBase);
		}
		if (CritMultiplierRatio != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CritMultiplierRatio);
		}
		if (FreezeDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FreezeDefBase);
		}
		if (FreezeDefRatio != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FreezeDefRatio);
		}
		if (BurnDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BurnDefBase);
		}
		if (BurnDefRatio != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BurnDefRatio);
		}
		if (PoisonDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PoisonDefBase);
		}
		if (PoisonDefRatio != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PoisonDefRatio);
		}
		if (ThunderDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ThunderDefBase);
		}
		if (ThunderDefRatio != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ThunderDefRatio);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAttrCopyConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IsCopyHpCostRatio != EGSYesNo.No)
			{
				IsCopyHpCostRatio = other.IsCopyHpCostRatio;
			}
			if (other.HPBase != 0)
			{
				HPBase = other.HPBase;
			}
			if (other.HPRatio != 0)
			{
				HPRatio = other.HPRatio;
			}
			if (other.MPBase != 0)
			{
				MPBase = other.MPBase;
			}
			if (other.MPRatio != 0)
			{
				MPRatio = other.MPRatio;
			}
			if (other.AtkBase != 0)
			{
				AtkBase = other.AtkBase;
			}
			if (other.AtkRatio != 0)
			{
				AtkRatio = other.AtkRatio;
			}
			if (other.DefBase != 0)
			{
				DefBase = other.DefBase;
			}
			if (other.DefRatio != 0)
			{
				DefRatio = other.DefRatio;
			}
			if (other.DmgAdditionBase != 0)
			{
				DmgAdditionBase = other.DmgAdditionBase;
			}
			if (other.DmgAdditionRatio != 0)
			{
				DmgAdditionRatio = other.DmgAdditionRatio;
			}
			if (other.DmgDefBase != 0)
			{
				DmgDefBase = other.DmgDefBase;
			}
			if (other.DmgDefRatio != 0)
			{
				DmgDefRatio = other.DmgDefRatio;
			}
			if (other.CritRateBase != 0)
			{
				CritRateBase = other.CritRateBase;
			}
			if (other.CritRateRatio != 0)
			{
				CritRateRatio = other.CritRateRatio;
			}
			if (other.CritMultiplierBase != 0)
			{
				CritMultiplierBase = other.CritMultiplierBase;
			}
			if (other.CritMultiplierRatio != 0)
			{
				CritMultiplierRatio = other.CritMultiplierRatio;
			}
			if (other.FreezeDefBase != 0)
			{
				FreezeDefBase = other.FreezeDefBase;
			}
			if (other.FreezeDefRatio != 0)
			{
				FreezeDefRatio = other.FreezeDefRatio;
			}
			if (other.BurnDefBase != 0)
			{
				BurnDefBase = other.BurnDefBase;
			}
			if (other.BurnDefRatio != 0)
			{
				BurnDefRatio = other.BurnDefRatio;
			}
			if (other.PoisonDefBase != 0)
			{
				PoisonDefBase = other.PoisonDefBase;
			}
			if (other.PoisonDefRatio != 0)
			{
				PoisonDefRatio = other.PoisonDefRatio;
			}
			if (other.ThunderDefBase != 0)
			{
				ThunderDefBase = other.ThunderDefBase;
			}
			if (other.ThunderDefRatio != 0)
			{
				ThunderDefRatio = other.ThunderDefRatio;
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
				IsCopyHpCostRatio = (EGSYesNo)input.ReadEnum();
				break;
			case 24u:
				HPBase = input.ReadInt32();
				break;
			case 32u:
				HPRatio = input.ReadInt32();
				break;
			case 40u:
				MPBase = input.ReadInt32();
				break;
			case 48u:
				MPRatio = input.ReadInt32();
				break;
			case 56u:
				AtkBase = input.ReadInt32();
				break;
			case 64u:
				AtkRatio = input.ReadInt32();
				break;
			case 72u:
				DefBase = input.ReadInt32();
				break;
			case 80u:
				DefRatio = input.ReadInt32();
				break;
			case 88u:
				DmgAdditionBase = input.ReadInt32();
				break;
			case 96u:
				DmgAdditionRatio = input.ReadInt32();
				break;
			case 104u:
				DmgDefBase = input.ReadInt32();
				break;
			case 112u:
				DmgDefRatio = input.ReadInt32();
				break;
			case 120u:
				CritRateBase = input.ReadInt32();
				break;
			case 128u:
				CritRateRatio = input.ReadInt32();
				break;
			case 136u:
				CritMultiplierBase = input.ReadInt32();
				break;
			case 144u:
				CritMultiplierRatio = input.ReadInt32();
				break;
			case 152u:
				FreezeDefBase = input.ReadInt32();
				break;
			case 160u:
				FreezeDefRatio = input.ReadInt32();
				break;
			case 168u:
				BurnDefBase = input.ReadInt32();
				break;
			case 176u:
				BurnDefRatio = input.ReadInt32();
				break;
			case 184u:
				PoisonDefBase = input.ReadInt32();
				break;
			case 192u:
				PoisonDefRatio = input.ReadInt32();
				break;
			case 200u:
				ThunderDefBase = input.ReadInt32();
				break;
			case 208u:
				ThunderDefRatio = input.ReadInt32();
				break;
			}
		}
	}
}
