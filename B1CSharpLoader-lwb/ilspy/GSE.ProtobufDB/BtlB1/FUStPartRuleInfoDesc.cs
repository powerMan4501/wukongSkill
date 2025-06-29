using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPartRuleInfoDesc : IMessage<FUStPartRuleInfoDesc>, IMessage, IEquatable<FUStPartRuleInfoDesc>, IDeepCloneable<FUStPartRuleInfoDesc>
{
	private static readonly MessageParser<FUStPartRuleInfoDesc> _parser = new MessageParser<FUStPartRuleInfoDesc>(() => new FUStPartRuleInfoDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int partRuleID_;

	private int partID_;

	private string partName_ = "";

	private EGSYesNo isActive_;

	private EGSYesNo needShowUI_;

	private EGSYesNo canTriggerAtkRebounding_;

	private EGSYesNo canTriggerBeAttackedBuffEffect_;

	private EGSYesNo immueAbnormalStateAcc_;

	private string canInterruptPartIDs_ = "";

	private EHitPartReduceAttrType hitPartReduceAttrType_;

	private static readonly FieldCodec<float> _repeated_reduceParams_codec = FieldCodec.ForFloat(98u);

	private readonly RepeatedField<float> reduceParams_ = new RepeatedField<float>();

	private EHitPartRuleType hitPartRuleType_;

	private static readonly FieldCodec<string> _repeated_hitPartRuleParam_codec = FieldCodec.ForString(114u);

	private readonly RepeatedField<string> hitPartRuleParam_ = new RepeatedField<string>();

	private int partHitMappingUnitBeAttackedInfoID_;

	private string partHitUnitBeAttackedConfigPath_ = "";

	private string damagedAMDataAssetPath_ = "";

	private static readonly FieldCodec<FUStPartDamagedInfo> _repeated_partDamagedInfoList_codec = FieldCodec.ForMessage(146u, FUStPartDamagedInfo.Parser);

	private readonly RepeatedField<FUStPartDamagedInfo> partDamagedInfoList_ = new RepeatedField<FUStPartDamagedInfo>();

	private int partDamagedStiffLevel_;

	private EGSYesNo isStageInRandomOrder_;

	private static readonly FieldCodec<int> _repeated_buffWithPartActive_codec = FieldCodec.ForInt32(170u);

	private readonly RepeatedField<int> buffWithPartActive_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_cantBreakPartDmgEffectIDList_codec = FieldCodec.ForInt32(178u);

	private readonly RepeatedField<int> cantBreakPartDmgEffectIDList_ = new RepeatedField<int>();

	private string guard_ = "";

	public static MessageParser<FUStPartRuleInfoDesc> Parser => _parser;

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

	public int PartRuleID
	{
		get
		{
			return partRuleID_;
		}
		set
		{
			partRuleID_ = value;
		}
	}

	public int PartID
	{
		get
		{
			return partID_;
		}
		set
		{
			partID_ = value;
		}
	}

	public string PartName
	{
		get
		{
			return partName_;
		}
		set
		{
			partName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo IsActive
	{
		get
		{
			return isActive_;
		}
		set
		{
			isActive_ = value;
		}
	}

	public EGSYesNo NeedShowUI
	{
		get
		{
			return needShowUI_;
		}
		set
		{
			needShowUI_ = value;
		}
	}

	public EGSYesNo CanTriggerAtkRebounding
	{
		get
		{
			return canTriggerAtkRebounding_;
		}
		set
		{
			canTriggerAtkRebounding_ = value;
		}
	}

	public EGSYesNo CanTriggerBeAttackedBuffEffect
	{
		get
		{
			return canTriggerBeAttackedBuffEffect_;
		}
		set
		{
			canTriggerBeAttackedBuffEffect_ = value;
		}
	}

	public EGSYesNo ImmueAbnormalStateAcc
	{
		get
		{
			return immueAbnormalStateAcc_;
		}
		set
		{
			immueAbnormalStateAcc_ = value;
		}
	}

	public string CanInterruptPartIDs
	{
		get
		{
			return canInterruptPartIDs_;
		}
		set
		{
			canInterruptPartIDs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EHitPartReduceAttrType HitPartReduceAttrType
	{
		get
		{
			return hitPartReduceAttrType_;
		}
		set
		{
			hitPartReduceAttrType_ = value;
		}
	}

	public RepeatedField<float> ReduceParams => reduceParams_;

	public EHitPartRuleType HitPartRuleType
	{
		get
		{
			return hitPartRuleType_;
		}
		set
		{
			hitPartRuleType_ = value;
		}
	}

	public RepeatedField<string> HitPartRuleParam => hitPartRuleParam_;

	public int PartHitMappingUnitBeAttackedInfoID
	{
		get
		{
			return partHitMappingUnitBeAttackedInfoID_;
		}
		set
		{
			partHitMappingUnitBeAttackedInfoID_ = value;
		}
	}

	public string PartHitUnitBeAttackedConfigPath
	{
		get
		{
			return partHitUnitBeAttackedConfigPath_;
		}
		set
		{
			partHitUnitBeAttackedConfigPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DamagedAMDataAssetPath
	{
		get
		{
			return damagedAMDataAssetPath_;
		}
		set
		{
			damagedAMDataAssetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<FUStPartDamagedInfo> PartDamagedInfoList => partDamagedInfoList_;

	public int PartDamagedStiffLevel
	{
		get
		{
			return partDamagedStiffLevel_;
		}
		set
		{
			partDamagedStiffLevel_ = value;
		}
	}

	public EGSYesNo IsStageInRandomOrder
	{
		get
		{
			return isStageInRandomOrder_;
		}
		set
		{
			isStageInRandomOrder_ = value;
		}
	}

	public RepeatedField<int> BuffWithPartActive => buffWithPartActive_;

	public RepeatedField<int> CantBreakPartDmgEffectIDList => cantBreakPartDmgEffectIDList_;

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

	public FUStPartRuleInfoDesc()
	{
	}

	public FUStPartRuleInfoDesc(FUStPartRuleInfoDesc other)
		: this()
	{
		iD_ = other.iD_;
		partRuleID_ = other.partRuleID_;
		partID_ = other.partID_;
		partName_ = other.partName_;
		isActive_ = other.isActive_;
		needShowUI_ = other.needShowUI_;
		canTriggerAtkRebounding_ = other.canTriggerAtkRebounding_;
		canTriggerBeAttackedBuffEffect_ = other.canTriggerBeAttackedBuffEffect_;
		immueAbnormalStateAcc_ = other.immueAbnormalStateAcc_;
		canInterruptPartIDs_ = other.canInterruptPartIDs_;
		hitPartReduceAttrType_ = other.hitPartReduceAttrType_;
		reduceParams_ = other.reduceParams_.Clone();
		hitPartRuleType_ = other.hitPartRuleType_;
		hitPartRuleParam_ = other.hitPartRuleParam_.Clone();
		partHitMappingUnitBeAttackedInfoID_ = other.partHitMappingUnitBeAttackedInfoID_;
		partHitUnitBeAttackedConfigPath_ = other.partHitUnitBeAttackedConfigPath_;
		damagedAMDataAssetPath_ = other.damagedAMDataAssetPath_;
		partDamagedInfoList_ = other.partDamagedInfoList_.Clone();
		partDamagedStiffLevel_ = other.partDamagedStiffLevel_;
		isStageInRandomOrder_ = other.isStageInRandomOrder_;
		buffWithPartActive_ = other.buffWithPartActive_.Clone();
		cantBreakPartDmgEffectIDList_ = other.cantBreakPartDmgEffectIDList_.Clone();
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPartRuleInfoDesc Clone()
	{
		return new FUStPartRuleInfoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPartRuleInfoDesc);
	}

	public bool Equals(FUStPartRuleInfoDesc other)
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
		if (PartRuleID != other.PartRuleID)
		{
			return false;
		}
		if (PartID != other.PartID)
		{
			return false;
		}
		if (PartName != other.PartName)
		{
			return false;
		}
		if (IsActive != other.IsActive)
		{
			return false;
		}
		if (NeedShowUI != other.NeedShowUI)
		{
			return false;
		}
		if (CanTriggerAtkRebounding != other.CanTriggerAtkRebounding)
		{
			return false;
		}
		if (CanTriggerBeAttackedBuffEffect != other.CanTriggerBeAttackedBuffEffect)
		{
			return false;
		}
		if (ImmueAbnormalStateAcc != other.ImmueAbnormalStateAcc)
		{
			return false;
		}
		if (CanInterruptPartIDs != other.CanInterruptPartIDs)
		{
			return false;
		}
		if (HitPartReduceAttrType != other.HitPartReduceAttrType)
		{
			return false;
		}
		if (!reduceParams_.Equals(other.reduceParams_))
		{
			return false;
		}
		if (HitPartRuleType != other.HitPartRuleType)
		{
			return false;
		}
		if (!hitPartRuleParam_.Equals(other.hitPartRuleParam_))
		{
			return false;
		}
		if (PartHitMappingUnitBeAttackedInfoID != other.PartHitMappingUnitBeAttackedInfoID)
		{
			return false;
		}
		if (PartHitUnitBeAttackedConfigPath != other.PartHitUnitBeAttackedConfigPath)
		{
			return false;
		}
		if (DamagedAMDataAssetPath != other.DamagedAMDataAssetPath)
		{
			return false;
		}
		if (!partDamagedInfoList_.Equals(other.partDamagedInfoList_))
		{
			return false;
		}
		if (PartDamagedStiffLevel != other.PartDamagedStiffLevel)
		{
			return false;
		}
		if (IsStageInRandomOrder != other.IsStageInRandomOrder)
		{
			return false;
		}
		if (!buffWithPartActive_.Equals(other.buffWithPartActive_))
		{
			return false;
		}
		if (!cantBreakPartDmgEffectIDList_.Equals(other.cantBreakPartDmgEffectIDList_))
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
		if (PartRuleID != 0)
		{
			num ^= PartRuleID.GetHashCode();
		}
		if (PartID != 0)
		{
			num ^= PartID.GetHashCode();
		}
		if (PartName.Length != 0)
		{
			num ^= PartName.GetHashCode();
		}
		if (IsActive != EGSYesNo.No)
		{
			num ^= IsActive.GetHashCode();
		}
		if (NeedShowUI != EGSYesNo.No)
		{
			num ^= NeedShowUI.GetHashCode();
		}
		if (CanTriggerAtkRebounding != EGSYesNo.No)
		{
			num ^= CanTriggerAtkRebounding.GetHashCode();
		}
		if (CanTriggerBeAttackedBuffEffect != EGSYesNo.No)
		{
			num ^= CanTriggerBeAttackedBuffEffect.GetHashCode();
		}
		if (ImmueAbnormalStateAcc != EGSYesNo.No)
		{
			num ^= ImmueAbnormalStateAcc.GetHashCode();
		}
		if (CanInterruptPartIDs.Length != 0)
		{
			num ^= CanInterruptPartIDs.GetHashCode();
		}
		if (HitPartReduceAttrType != EHitPartReduceAttrType.None)
		{
			num ^= HitPartReduceAttrType.GetHashCode();
		}
		num ^= reduceParams_.GetHashCode();
		if (HitPartRuleType != EHitPartRuleType.ByPa)
		{
			num ^= HitPartRuleType.GetHashCode();
		}
		num ^= hitPartRuleParam_.GetHashCode();
		if (PartHitMappingUnitBeAttackedInfoID != 0)
		{
			num ^= PartHitMappingUnitBeAttackedInfoID.GetHashCode();
		}
		if (PartHitUnitBeAttackedConfigPath.Length != 0)
		{
			num ^= PartHitUnitBeAttackedConfigPath.GetHashCode();
		}
		if (DamagedAMDataAssetPath.Length != 0)
		{
			num ^= DamagedAMDataAssetPath.GetHashCode();
		}
		num ^= partDamagedInfoList_.GetHashCode();
		if (PartDamagedStiffLevel != 0)
		{
			num ^= PartDamagedStiffLevel.GetHashCode();
		}
		if (IsStageInRandomOrder != EGSYesNo.No)
		{
			num ^= IsStageInRandomOrder.GetHashCode();
		}
		num ^= buffWithPartActive_.GetHashCode();
		num ^= cantBreakPartDmgEffectIDList_.GetHashCode();
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
		if (PartRuleID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PartRuleID);
		}
		if (PartID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PartID);
		}
		if (PartName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(PartName);
		}
		if (IsActive != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsActive);
		}
		if (NeedShowUI != EGSYesNo.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)NeedShowUI);
		}
		if (CanTriggerAtkRebounding != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)CanTriggerAtkRebounding);
		}
		if (CanTriggerBeAttackedBuffEffect != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)CanTriggerBeAttackedBuffEffect);
		}
		if (ImmueAbnormalStateAcc != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)ImmueAbnormalStateAcc);
		}
		if (CanInterruptPartIDs.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(CanInterruptPartIDs);
		}
		if (HitPartReduceAttrType != EHitPartReduceAttrType.None)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)HitPartReduceAttrType);
		}
		reduceParams_.WriteTo(output, _repeated_reduceParams_codec);
		if (HitPartRuleType != EHitPartRuleType.ByPa)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)HitPartRuleType);
		}
		hitPartRuleParam_.WriteTo(output, _repeated_hitPartRuleParam_codec);
		if (PartHitMappingUnitBeAttackedInfoID != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(PartHitMappingUnitBeAttackedInfoID);
		}
		if (PartHitUnitBeAttackedConfigPath.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(PartHitUnitBeAttackedConfigPath);
		}
		if (DamagedAMDataAssetPath.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(DamagedAMDataAssetPath);
		}
		partDamagedInfoList_.WriteTo(output, _repeated_partDamagedInfoList_codec);
		if (PartDamagedStiffLevel != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(PartDamagedStiffLevel);
		}
		if (IsStageInRandomOrder != EGSYesNo.No)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)IsStageInRandomOrder);
		}
		buffWithPartActive_.WriteTo(output, _repeated_buffWithPartActive_codec);
		cantBreakPartDmgEffectIDList_.WriteTo(output, _repeated_cantBreakPartDmgEffectIDList_codec);
		if (Guard.Length != 0)
		{
			output.WriteRawTag(186, 1);
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
		if (PartRuleID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartRuleID);
		}
		if (PartID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartID);
		}
		if (PartName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PartName);
		}
		if (IsActive != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsActive);
		}
		if (NeedShowUI != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NeedShowUI);
		}
		if (CanTriggerAtkRebounding != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanTriggerAtkRebounding);
		}
		if (CanTriggerBeAttackedBuffEffect != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanTriggerBeAttackedBuffEffect);
		}
		if (ImmueAbnormalStateAcc != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ImmueAbnormalStateAcc);
		}
		if (CanInterruptPartIDs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CanInterruptPartIDs);
		}
		if (HitPartReduceAttrType != EHitPartReduceAttrType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitPartReduceAttrType);
		}
		num += reduceParams_.CalculateSize(_repeated_reduceParams_codec);
		if (HitPartRuleType != EHitPartRuleType.ByPa)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitPartRuleType);
		}
		num += hitPartRuleParam_.CalculateSize(_repeated_hitPartRuleParam_codec);
		if (PartHitMappingUnitBeAttackedInfoID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartHitMappingUnitBeAttackedInfoID);
		}
		if (PartHitUnitBeAttackedConfigPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PartHitUnitBeAttackedConfigPath);
		}
		if (DamagedAMDataAssetPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(DamagedAMDataAssetPath);
		}
		num += partDamagedInfoList_.CalculateSize(_repeated_partDamagedInfoList_codec);
		if (PartDamagedStiffLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PartDamagedStiffLevel);
		}
		if (IsStageInRandomOrder != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsStageInRandomOrder);
		}
		num += buffWithPartActive_.CalculateSize(_repeated_buffWithPartActive_codec);
		num += cantBreakPartDmgEffectIDList_.CalculateSize(_repeated_cantBreakPartDmgEffectIDList_codec);
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

	public void MergeFrom(FUStPartRuleInfoDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.PartRuleID != 0)
			{
				PartRuleID = other.PartRuleID;
			}
			if (other.PartID != 0)
			{
				PartID = other.PartID;
			}
			if (other.PartName.Length != 0)
			{
				PartName = other.PartName;
			}
			if (other.IsActive != EGSYesNo.No)
			{
				IsActive = other.IsActive;
			}
			if (other.NeedShowUI != EGSYesNo.No)
			{
				NeedShowUI = other.NeedShowUI;
			}
			if (other.CanTriggerAtkRebounding != EGSYesNo.No)
			{
				CanTriggerAtkRebounding = other.CanTriggerAtkRebounding;
			}
			if (other.CanTriggerBeAttackedBuffEffect != EGSYesNo.No)
			{
				CanTriggerBeAttackedBuffEffect = other.CanTriggerBeAttackedBuffEffect;
			}
			if (other.ImmueAbnormalStateAcc != EGSYesNo.No)
			{
				ImmueAbnormalStateAcc = other.ImmueAbnormalStateAcc;
			}
			if (other.CanInterruptPartIDs.Length != 0)
			{
				CanInterruptPartIDs = other.CanInterruptPartIDs;
			}
			if (other.HitPartReduceAttrType != EHitPartReduceAttrType.None)
			{
				HitPartReduceAttrType = other.HitPartReduceAttrType;
			}
			reduceParams_.Add(other.reduceParams_);
			if (other.HitPartRuleType != EHitPartRuleType.ByPa)
			{
				HitPartRuleType = other.HitPartRuleType;
			}
			hitPartRuleParam_.Add(other.hitPartRuleParam_);
			if (other.PartHitMappingUnitBeAttackedInfoID != 0)
			{
				PartHitMappingUnitBeAttackedInfoID = other.PartHitMappingUnitBeAttackedInfoID;
			}
			if (other.PartHitUnitBeAttackedConfigPath.Length != 0)
			{
				PartHitUnitBeAttackedConfigPath = other.PartHitUnitBeAttackedConfigPath;
			}
			if (other.DamagedAMDataAssetPath.Length != 0)
			{
				DamagedAMDataAssetPath = other.DamagedAMDataAssetPath;
			}
			partDamagedInfoList_.Add(other.partDamagedInfoList_);
			if (other.PartDamagedStiffLevel != 0)
			{
				PartDamagedStiffLevel = other.PartDamagedStiffLevel;
			}
			if (other.IsStageInRandomOrder != EGSYesNo.No)
			{
				IsStageInRandomOrder = other.IsStageInRandomOrder;
			}
			buffWithPartActive_.Add(other.buffWithPartActive_);
			cantBreakPartDmgEffectIDList_.Add(other.cantBreakPartDmgEffectIDList_);
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
				PartRuleID = input.ReadInt32();
				break;
			case 24u:
				PartID = input.ReadInt32();
				break;
			case 34u:
				PartName = input.ReadString();
				break;
			case 40u:
				IsActive = (EGSYesNo)input.ReadEnum();
				break;
			case 48u:
				NeedShowUI = (EGSYesNo)input.ReadEnum();
				break;
			case 56u:
				CanTriggerAtkRebounding = (EGSYesNo)input.ReadEnum();
				break;
			case 64u:
				CanTriggerBeAttackedBuffEffect = (EGSYesNo)input.ReadEnum();
				break;
			case 72u:
				ImmueAbnormalStateAcc = (EGSYesNo)input.ReadEnum();
				break;
			case 82u:
				CanInterruptPartIDs = input.ReadString();
				break;
			case 88u:
				HitPartReduceAttrType = (EHitPartReduceAttrType)input.ReadEnum();
				break;
			case 98u:
			case 101u:
				reduceParams_.AddEntriesFrom(input, _repeated_reduceParams_codec);
				break;
			case 104u:
				HitPartRuleType = (EHitPartRuleType)input.ReadEnum();
				break;
			case 114u:
				hitPartRuleParam_.AddEntriesFrom(input, _repeated_hitPartRuleParam_codec);
				break;
			case 120u:
				PartHitMappingUnitBeAttackedInfoID = input.ReadInt32();
				break;
			case 130u:
				PartHitUnitBeAttackedConfigPath = input.ReadString();
				break;
			case 138u:
				DamagedAMDataAssetPath = input.ReadString();
				break;
			case 146u:
				partDamagedInfoList_.AddEntriesFrom(input, _repeated_partDamagedInfoList_codec);
				break;
			case 152u:
				PartDamagedStiffLevel = input.ReadInt32();
				break;
			case 160u:
				IsStageInRandomOrder = (EGSYesNo)input.ReadEnum();
				break;
			case 168u:
			case 170u:
				buffWithPartActive_.AddEntriesFrom(input, _repeated_buffWithPartActive_codec);
				break;
			case 176u:
			case 178u:
				cantBreakPartDmgEffectIDList_.AddEntriesFrom(input, _repeated_cantBreakPartDmgEffectIDList_codec);
				break;
			case 186u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
