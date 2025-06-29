using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPassiveSkillDesc : IMessage<FUStPassiveSkillDesc>, IMessage, IEquatable<FUStPassiveSkillDesc>, IDeepCloneable<FUStPassiveSkillDesc>
{
	private static readonly MessageParser<FUStPassiveSkillDesc> _parser = new MessageParser<FUStPassiveSkillDesc>(() => new FUStPassiveSkillDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int passiveSkillID_;

	private int passiveSkillMappingIndexID_;

	private EModifyMethod modifyMethod_;

	private EValOp valOp_;

	private float baseValue_;

	private float multiplier_;

	private float maxValue_;

	private float minValue_;

	private string mainID_ = "";

	private int subID_;

	private int subID2_;

	public static MessageParser<FUStPassiveSkillDesc> Parser => _parser;

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

	public int PassiveSkillID
	{
		get
		{
			return passiveSkillID_;
		}
		set
		{
			passiveSkillID_ = value;
		}
	}

	public int PassiveSkillMappingIndexID
	{
		get
		{
			return passiveSkillMappingIndexID_;
		}
		set
		{
			passiveSkillMappingIndexID_ = value;
		}
	}

	public EModifyMethod ModifyMethod
	{
		get
		{
			return modifyMethod_;
		}
		set
		{
			modifyMethod_ = value;
		}
	}

	public EValOp ValOp
	{
		get
		{
			return valOp_;
		}
		set
		{
			valOp_ = value;
		}
	}

	public float BaseValue
	{
		get
		{
			return baseValue_;
		}
		set
		{
			baseValue_ = value;
		}
	}

	public float Multiplier
	{
		get
		{
			return multiplier_;
		}
		set
		{
			multiplier_ = value;
		}
	}

	public float MaxValue
	{
		get
		{
			return maxValue_;
		}
		set
		{
			maxValue_ = value;
		}
	}

	public float MinValue
	{
		get
		{
			return minValue_;
		}
		set
		{
			minValue_ = value;
		}
	}

	public string MainID
	{
		get
		{
			return mainID_;
		}
		set
		{
			mainID_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SubID
	{
		get
		{
			return subID_;
		}
		set
		{
			subID_ = value;
		}
	}

	public int SubID2
	{
		get
		{
			return subID2_;
		}
		set
		{
			subID2_ = value;
		}
	}

	public FUStPassiveSkillDesc()
	{
	}

	public FUStPassiveSkillDesc(FUStPassiveSkillDesc other)
		: this()
	{
		iD_ = other.iD_;
		passiveSkillID_ = other.passiveSkillID_;
		passiveSkillMappingIndexID_ = other.passiveSkillMappingIndexID_;
		modifyMethod_ = other.modifyMethod_;
		valOp_ = other.valOp_;
		baseValue_ = other.baseValue_;
		multiplier_ = other.multiplier_;
		maxValue_ = other.maxValue_;
		minValue_ = other.minValue_;
		mainID_ = other.mainID_;
		subID_ = other.subID_;
		subID2_ = other.subID2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPassiveSkillDesc Clone()
	{
		return new FUStPassiveSkillDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPassiveSkillDesc);
	}

	public bool Equals(FUStPassiveSkillDesc other)
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
		if (PassiveSkillID != other.PassiveSkillID)
		{
			return false;
		}
		if (PassiveSkillMappingIndexID != other.PassiveSkillMappingIndexID)
		{
			return false;
		}
		if (ModifyMethod != other.ModifyMethod)
		{
			return false;
		}
		if (ValOp != other.ValOp)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BaseValue, other.BaseValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Multiplier, other.Multiplier))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxValue, other.MaxValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinValue, other.MinValue))
		{
			return false;
		}
		if (MainID != other.MainID)
		{
			return false;
		}
		if (SubID != other.SubID)
		{
			return false;
		}
		if (SubID2 != other.SubID2)
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
		if (PassiveSkillID != 0)
		{
			num ^= PassiveSkillID.GetHashCode();
		}
		if (PassiveSkillMappingIndexID != 0)
		{
			num ^= PassiveSkillMappingIndexID.GetHashCode();
		}
		if (ModifyMethod != EModifyMethod.SkillCooldown)
		{
			num ^= ModifyMethod.GetHashCode();
		}
		if (ValOp != EValOp.Add)
		{
			num ^= ValOp.GetHashCode();
		}
		if (BaseValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BaseValue);
		}
		if (Multiplier != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Multiplier);
		}
		if (MaxValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxValue);
		}
		if (MinValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinValue);
		}
		if (MainID.Length != 0)
		{
			num ^= MainID.GetHashCode();
		}
		if (SubID != 0)
		{
			num ^= SubID.GetHashCode();
		}
		if (SubID2 != 0)
		{
			num ^= SubID2.GetHashCode();
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
		if (PassiveSkillID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PassiveSkillID);
		}
		if (PassiveSkillMappingIndexID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PassiveSkillMappingIndexID);
		}
		if (ModifyMethod != EModifyMethod.SkillCooldown)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ModifyMethod);
		}
		if (ValOp != EValOp.Add)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ValOp);
		}
		if (BaseValue != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(BaseValue);
		}
		if (Multiplier != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(Multiplier);
		}
		if (MaxValue != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(MaxValue);
		}
		if (MinValue != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(MinValue);
		}
		if (MainID.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(MainID);
		}
		if (SubID != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(SubID);
		}
		if (SubID2 != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(SubID2);
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
		if (PassiveSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassiveSkillID);
		}
		if (PassiveSkillMappingIndexID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassiveSkillMappingIndexID);
		}
		if (ModifyMethod != EModifyMethod.SkillCooldown)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ModifyMethod);
		}
		if (ValOp != EValOp.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ValOp);
		}
		if (BaseValue != 0f)
		{
			num += 5;
		}
		if (Multiplier != 0f)
		{
			num += 5;
		}
		if (MaxValue != 0f)
		{
			num += 5;
		}
		if (MinValue != 0f)
		{
			num += 5;
		}
		if (MainID.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MainID);
		}
		if (SubID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubID);
		}
		if (SubID2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubID2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPassiveSkillDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.PassiveSkillID != 0)
			{
				PassiveSkillID = other.PassiveSkillID;
			}
			if (other.PassiveSkillMappingIndexID != 0)
			{
				PassiveSkillMappingIndexID = other.PassiveSkillMappingIndexID;
			}
			if (other.ModifyMethod != EModifyMethod.SkillCooldown)
			{
				ModifyMethod = other.ModifyMethod;
			}
			if (other.ValOp != EValOp.Add)
			{
				ValOp = other.ValOp;
			}
			if (other.BaseValue != 0f)
			{
				BaseValue = other.BaseValue;
			}
			if (other.Multiplier != 0f)
			{
				Multiplier = other.Multiplier;
			}
			if (other.MaxValue != 0f)
			{
				MaxValue = other.MaxValue;
			}
			if (other.MinValue != 0f)
			{
				MinValue = other.MinValue;
			}
			if (other.MainID.Length != 0)
			{
				MainID = other.MainID;
			}
			if (other.SubID != 0)
			{
				SubID = other.SubID;
			}
			if (other.SubID2 != 0)
			{
				SubID2 = other.SubID2;
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
				PassiveSkillID = input.ReadInt32();
				break;
			case 24u:
				PassiveSkillMappingIndexID = input.ReadInt32();
				break;
			case 32u:
				ModifyMethod = (EModifyMethod)input.ReadEnum();
				break;
			case 40u:
				ValOp = (EValOp)input.ReadEnum();
				break;
			case 53u:
				BaseValue = input.ReadFloat();
				break;
			case 61u:
				Multiplier = input.ReadFloat();
				break;
			case 69u:
				MaxValue = input.ReadFloat();
				break;
			case 77u:
				MinValue = input.ReadFloat();
				break;
			case 82u:
				MainID = input.ReadString();
				break;
			case 88u:
				SubID = input.ReadInt32();
				break;
			case 96u:
				SubID2 = input.ReadInt32();
				break;
			}
		}
	}
}
