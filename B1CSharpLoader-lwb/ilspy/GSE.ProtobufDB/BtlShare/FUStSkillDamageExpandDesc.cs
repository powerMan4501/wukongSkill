using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStSkillDamageExpandDesc : IMessage<FUStSkillDamageExpandDesc>, IMessage, IEquatable<FUStSkillDamageExpandDesc>, IDeepCloneable<FUStSkillDamageExpandDesc>
{
	private static readonly MessageParser<FUStSkillDamageExpandDesc> _parser = new MessageParser<FUStSkillDamageExpandDesc>(() => new FUStSkillDamageExpandDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo canTriggerScar_;

	private int canTriggerFX_;

	private int canTriggerFightBackCounter_;

	private int damageReason_;

	private int damageImmueLevel_;

	private float critRateAddition_;

	private float critDmgAddition_;

	private EGSYesNo ignoreBeAttacked_;

	private float addTargetCurHpRatio_;

	private float immobilizeHit_;

	private float partDamage_;

	private float pevalueIncrements_;

	private float transIncrements_;

	private EHitWeightGearType hitWeightGearType_;

	private EPillarFormTerminatorType pillarFormTerminatorType_;

	private EGSYesNo brokenFrozenImmediately_;

	private string guard_ = "";

	public static MessageParser<FUStSkillDamageExpandDesc> Parser => _parser;

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

	public EGSYesNo CanTriggerScar
	{
		get
		{
			return canTriggerScar_;
		}
		set
		{
			canTriggerScar_ = value;
		}
	}

	public int CanTriggerFX
	{
		get
		{
			return canTriggerFX_;
		}
		set
		{
			canTriggerFX_ = value;
		}
	}

	public int CanTriggerFightBackCounter
	{
		get
		{
			return canTriggerFightBackCounter_;
		}
		set
		{
			canTriggerFightBackCounter_ = value;
		}
	}

	public int DamageReason
	{
		get
		{
			return damageReason_;
		}
		set
		{
			damageReason_ = value;
		}
	}

	public int DamageImmueLevel
	{
		get
		{
			return damageImmueLevel_;
		}
		set
		{
			damageImmueLevel_ = value;
		}
	}

	public float CritRateAddition
	{
		get
		{
			return critRateAddition_;
		}
		set
		{
			critRateAddition_ = value;
		}
	}

	public float CritDmgAddition
	{
		get
		{
			return critDmgAddition_;
		}
		set
		{
			critDmgAddition_ = value;
		}
	}

	public EGSYesNo IgnoreBeAttacked
	{
		get
		{
			return ignoreBeAttacked_;
		}
		set
		{
			ignoreBeAttacked_ = value;
		}
	}

	public float AddTargetCurHpRatio
	{
		get
		{
			return addTargetCurHpRatio_;
		}
		set
		{
			addTargetCurHpRatio_ = value;
		}
	}

	public float ImmobilizeHit
	{
		get
		{
			return immobilizeHit_;
		}
		set
		{
			immobilizeHit_ = value;
		}
	}

	public float PartDamage
	{
		get
		{
			return partDamage_;
		}
		set
		{
			partDamage_ = value;
		}
	}

	public float PevalueIncrements
	{
		get
		{
			return pevalueIncrements_;
		}
		set
		{
			pevalueIncrements_ = value;
		}
	}

	public float TransIncrements
	{
		get
		{
			return transIncrements_;
		}
		set
		{
			transIncrements_ = value;
		}
	}

	public EHitWeightGearType HitWeightGearType
	{
		get
		{
			return hitWeightGearType_;
		}
		set
		{
			hitWeightGearType_ = value;
		}
	}

	public EPillarFormTerminatorType PillarFormTerminatorType
	{
		get
		{
			return pillarFormTerminatorType_;
		}
		set
		{
			pillarFormTerminatorType_ = value;
		}
	}

	public EGSYesNo BrokenFrozenImmediately
	{
		get
		{
			return brokenFrozenImmediately_;
		}
		set
		{
			brokenFrozenImmediately_ = value;
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

	public FUStSkillDamageExpandDesc()
	{
	}

	public FUStSkillDamageExpandDesc(FUStSkillDamageExpandDesc other)
		: this()
	{
		iD_ = other.iD_;
		canTriggerScar_ = other.canTriggerScar_;
		canTriggerFX_ = other.canTriggerFX_;
		canTriggerFightBackCounter_ = other.canTriggerFightBackCounter_;
		damageReason_ = other.damageReason_;
		damageImmueLevel_ = other.damageImmueLevel_;
		critRateAddition_ = other.critRateAddition_;
		critDmgAddition_ = other.critDmgAddition_;
		ignoreBeAttacked_ = other.ignoreBeAttacked_;
		addTargetCurHpRatio_ = other.addTargetCurHpRatio_;
		immobilizeHit_ = other.immobilizeHit_;
		partDamage_ = other.partDamage_;
		pevalueIncrements_ = other.pevalueIncrements_;
		transIncrements_ = other.transIncrements_;
		hitWeightGearType_ = other.hitWeightGearType_;
		pillarFormTerminatorType_ = other.pillarFormTerminatorType_;
		brokenFrozenImmediately_ = other.brokenFrozenImmediately_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSkillDamageExpandDesc Clone()
	{
		return new FUStSkillDamageExpandDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSkillDamageExpandDesc);
	}

	public bool Equals(FUStSkillDamageExpandDesc other)
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
		if (CanTriggerScar != other.CanTriggerScar)
		{
			return false;
		}
		if (CanTriggerFX != other.CanTriggerFX)
		{
			return false;
		}
		if (CanTriggerFightBackCounter != other.CanTriggerFightBackCounter)
		{
			return false;
		}
		if (DamageReason != other.DamageReason)
		{
			return false;
		}
		if (DamageImmueLevel != other.DamageImmueLevel)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CritRateAddition, other.CritRateAddition))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CritDmgAddition, other.CritDmgAddition))
		{
			return false;
		}
		if (IgnoreBeAttacked != other.IgnoreBeAttacked)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AddTargetCurHpRatio, other.AddTargetCurHpRatio))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ImmobilizeHit, other.ImmobilizeHit))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PartDamage, other.PartDamage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PevalueIncrements, other.PevalueIncrements))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransIncrements, other.TransIncrements))
		{
			return false;
		}
		if (HitWeightGearType != other.HitWeightGearType)
		{
			return false;
		}
		if (PillarFormTerminatorType != other.PillarFormTerminatorType)
		{
			return false;
		}
		if (BrokenFrozenImmediately != other.BrokenFrozenImmediately)
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
		if (CanTriggerScar != EGSYesNo.No)
		{
			num ^= CanTriggerScar.GetHashCode();
		}
		if (CanTriggerFX != 0)
		{
			num ^= CanTriggerFX.GetHashCode();
		}
		if (CanTriggerFightBackCounter != 0)
		{
			num ^= CanTriggerFightBackCounter.GetHashCode();
		}
		if (DamageReason != 0)
		{
			num ^= DamageReason.GetHashCode();
		}
		if (DamageImmueLevel != 0)
		{
			num ^= DamageImmueLevel.GetHashCode();
		}
		if (CritRateAddition != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CritRateAddition);
		}
		if (CritDmgAddition != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CritDmgAddition);
		}
		if (IgnoreBeAttacked != EGSYesNo.No)
		{
			num ^= IgnoreBeAttacked.GetHashCode();
		}
		if (AddTargetCurHpRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AddTargetCurHpRatio);
		}
		if (ImmobilizeHit != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ImmobilizeHit);
		}
		if (PartDamage != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PartDamage);
		}
		if (PevalueIncrements != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PevalueIncrements);
		}
		if (TransIncrements != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransIncrements);
		}
		if (HitWeightGearType != EHitWeightGearType.LowHitWeight)
		{
			num ^= HitWeightGearType.GetHashCode();
		}
		if (PillarFormTerminatorType != EPillarFormTerminatorType.None)
		{
			num ^= PillarFormTerminatorType.GetHashCode();
		}
		if (BrokenFrozenImmediately != EGSYesNo.No)
		{
			num ^= BrokenFrozenImmediately.GetHashCode();
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
		if (CanTriggerScar != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)CanTriggerScar);
		}
		if (CanTriggerFX != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CanTriggerFX);
		}
		if (CanTriggerFightBackCounter != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CanTriggerFightBackCounter);
		}
		if (DamageReason != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DamageReason);
		}
		if (DamageImmueLevel != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DamageImmueLevel);
		}
		if (CritRateAddition != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(CritRateAddition);
		}
		if (CritDmgAddition != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(CritDmgAddition);
		}
		if (IgnoreBeAttacked != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)IgnoreBeAttacked);
		}
		if (AddTargetCurHpRatio != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(AddTargetCurHpRatio);
		}
		if (ImmobilizeHit != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(ImmobilizeHit);
		}
		if (PartDamage != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(PartDamage);
		}
		if (PevalueIncrements != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(PevalueIncrements);
		}
		if (TransIncrements != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(TransIncrements);
		}
		if (HitWeightGearType != EHitWeightGearType.LowHitWeight)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)HitWeightGearType);
		}
		if (PillarFormTerminatorType != EPillarFormTerminatorType.None)
		{
			output.WriteRawTag(128, 1);
			output.WriteEnum((int)PillarFormTerminatorType);
		}
		if (BrokenFrozenImmediately != EGSYesNo.No)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)BrokenFrozenImmediately);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(146, 1);
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
		if (CanTriggerScar != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanTriggerScar);
		}
		if (CanTriggerFX != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CanTriggerFX);
		}
		if (CanTriggerFightBackCounter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CanTriggerFightBackCounter);
		}
		if (DamageReason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DamageReason);
		}
		if (DamageImmueLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DamageImmueLevel);
		}
		if (CritRateAddition != 0f)
		{
			num += 5;
		}
		if (CritDmgAddition != 0f)
		{
			num += 5;
		}
		if (IgnoreBeAttacked != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IgnoreBeAttacked);
		}
		if (AddTargetCurHpRatio != 0f)
		{
			num += 5;
		}
		if (ImmobilizeHit != 0f)
		{
			num += 5;
		}
		if (PartDamage != 0f)
		{
			num += 5;
		}
		if (PevalueIncrements != 0f)
		{
			num += 5;
		}
		if (TransIncrements != 0f)
		{
			num += 5;
		}
		if (HitWeightGearType != EHitWeightGearType.LowHitWeight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitWeightGearType);
		}
		if (PillarFormTerminatorType != EPillarFormTerminatorType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)PillarFormTerminatorType);
		}
		if (BrokenFrozenImmediately != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BrokenFrozenImmediately);
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

	public void MergeFrom(FUStSkillDamageExpandDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.CanTriggerScar != EGSYesNo.No)
			{
				CanTriggerScar = other.CanTriggerScar;
			}
			if (other.CanTriggerFX != 0)
			{
				CanTriggerFX = other.CanTriggerFX;
			}
			if (other.CanTriggerFightBackCounter != 0)
			{
				CanTriggerFightBackCounter = other.CanTriggerFightBackCounter;
			}
			if (other.DamageReason != 0)
			{
				DamageReason = other.DamageReason;
			}
			if (other.DamageImmueLevel != 0)
			{
				DamageImmueLevel = other.DamageImmueLevel;
			}
			if (other.CritRateAddition != 0f)
			{
				CritRateAddition = other.CritRateAddition;
			}
			if (other.CritDmgAddition != 0f)
			{
				CritDmgAddition = other.CritDmgAddition;
			}
			if (other.IgnoreBeAttacked != EGSYesNo.No)
			{
				IgnoreBeAttacked = other.IgnoreBeAttacked;
			}
			if (other.AddTargetCurHpRatio != 0f)
			{
				AddTargetCurHpRatio = other.AddTargetCurHpRatio;
			}
			if (other.ImmobilizeHit != 0f)
			{
				ImmobilizeHit = other.ImmobilizeHit;
			}
			if (other.PartDamage != 0f)
			{
				PartDamage = other.PartDamage;
			}
			if (other.PevalueIncrements != 0f)
			{
				PevalueIncrements = other.PevalueIncrements;
			}
			if (other.TransIncrements != 0f)
			{
				TransIncrements = other.TransIncrements;
			}
			if (other.HitWeightGearType != EHitWeightGearType.LowHitWeight)
			{
				HitWeightGearType = other.HitWeightGearType;
			}
			if (other.PillarFormTerminatorType != EPillarFormTerminatorType.None)
			{
				PillarFormTerminatorType = other.PillarFormTerminatorType;
			}
			if (other.BrokenFrozenImmediately != EGSYesNo.No)
			{
				BrokenFrozenImmediately = other.BrokenFrozenImmediately;
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
			case 16u:
				CanTriggerScar = (EGSYesNo)input.ReadEnum();
				break;
			case 24u:
				CanTriggerFX = input.ReadInt32();
				break;
			case 32u:
				CanTriggerFightBackCounter = input.ReadInt32();
				break;
			case 40u:
				DamageReason = input.ReadInt32();
				break;
			case 48u:
				DamageImmueLevel = input.ReadInt32();
				break;
			case 61u:
				CritRateAddition = input.ReadFloat();
				break;
			case 69u:
				CritDmgAddition = input.ReadFloat();
				break;
			case 72u:
				IgnoreBeAttacked = (EGSYesNo)input.ReadEnum();
				break;
			case 85u:
				AddTargetCurHpRatio = input.ReadFloat();
				break;
			case 93u:
				ImmobilizeHit = input.ReadFloat();
				break;
			case 101u:
				PartDamage = input.ReadFloat();
				break;
			case 109u:
				PevalueIncrements = input.ReadFloat();
				break;
			case 117u:
				TransIncrements = input.ReadFloat();
				break;
			case 120u:
				HitWeightGearType = (EHitWeightGearType)input.ReadEnum();
				break;
			case 128u:
				PillarFormTerminatorType = (EPillarFormTerminatorType)input.ReadEnum();
				break;
			case 136u:
				BrokenFrozenImmediately = (EGSYesNo)input.ReadEnum();
				break;
			case 146u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
