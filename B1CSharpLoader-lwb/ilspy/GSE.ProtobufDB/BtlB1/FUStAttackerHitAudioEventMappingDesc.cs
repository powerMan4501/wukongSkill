using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAttackerHitAudioEventMappingDesc : IMessage<FUStAttackerHitAudioEventMappingDesc>, IMessage, IEquatable<FUStAttackerHitAudioEventMappingDesc>, IDeepCloneable<FUStAttackerHitAudioEventMappingDesc>
{
	private static readonly MessageParser<FUStAttackerHitAudioEventMappingDesc> _parser = new MessageParser<FUStAttackerHitAudioEventMappingDesc>(() => new FUStAttackerHitAudioEventMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int attackerResID_;

	private int victimResID_;

	private EHitPerformAudioMappingCondition mappingCondition_;

	private EHitPerformAudioEventType conditionEventType_;

	private EHitPerformAudioEventType mappingHitPerformType_;

	private string guard_ = "";

	public static MessageParser<FUStAttackerHitAudioEventMappingDesc> Parser => _parser;

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

	public int AttackerResID
	{
		get
		{
			return attackerResID_;
		}
		set
		{
			attackerResID_ = value;
		}
	}

	public int VictimResID
	{
		get
		{
			return victimResID_;
		}
		set
		{
			victimResID_ = value;
		}
	}

	public EHitPerformAudioMappingCondition MappingCondition
	{
		get
		{
			return mappingCondition_;
		}
		set
		{
			mappingCondition_ = value;
		}
	}

	public EHitPerformAudioEventType ConditionEventType
	{
		get
		{
			return conditionEventType_;
		}
		set
		{
			conditionEventType_ = value;
		}
	}

	public EHitPerformAudioEventType MappingHitPerformType
	{
		get
		{
			return mappingHitPerformType_;
		}
		set
		{
			mappingHitPerformType_ = value;
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

	public FUStAttackerHitAudioEventMappingDesc()
	{
	}

	public FUStAttackerHitAudioEventMappingDesc(FUStAttackerHitAudioEventMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		attackerResID_ = other.attackerResID_;
		victimResID_ = other.victimResID_;
		mappingCondition_ = other.mappingCondition_;
		conditionEventType_ = other.conditionEventType_;
		mappingHitPerformType_ = other.mappingHitPerformType_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAttackerHitAudioEventMappingDesc Clone()
	{
		return new FUStAttackerHitAudioEventMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAttackerHitAudioEventMappingDesc);
	}

	public bool Equals(FUStAttackerHitAudioEventMappingDesc other)
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
		if (AttackerResID != other.AttackerResID)
		{
			return false;
		}
		if (VictimResID != other.VictimResID)
		{
			return false;
		}
		if (MappingCondition != other.MappingCondition)
		{
			return false;
		}
		if (ConditionEventType != other.ConditionEventType)
		{
			return false;
		}
		if (MappingHitPerformType != other.MappingHitPerformType)
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
		if (AttackerResID != 0)
		{
			num ^= AttackerResID.GetHashCode();
		}
		if (VictimResID != 0)
		{
			num ^= VictimResID.GetHashCode();
		}
		if (MappingCondition != EHitPerformAudioMappingCondition.Lower)
		{
			num ^= MappingCondition.GetHashCode();
		}
		if (ConditionEventType != EHitPerformAudioEventType.None)
		{
			num ^= ConditionEventType.GetHashCode();
		}
		if (MappingHitPerformType != EHitPerformAudioEventType.None)
		{
			num ^= MappingHitPerformType.GetHashCode();
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
		if (AttackerResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttackerResID);
		}
		if (VictimResID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(VictimResID);
		}
		if (MappingCondition != EHitPerformAudioMappingCondition.Lower)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)MappingCondition);
		}
		if (ConditionEventType != EHitPerformAudioEventType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ConditionEventType);
		}
		if (MappingHitPerformType != EHitPerformAudioEventType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)MappingHitPerformType);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(58);
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
		if (AttackerResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackerResID);
		}
		if (VictimResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VictimResID);
		}
		if (MappingCondition != EHitPerformAudioMappingCondition.Lower)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MappingCondition);
		}
		if (ConditionEventType != EHitPerformAudioEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionEventType);
		}
		if (MappingHitPerformType != EHitPerformAudioEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MappingHitPerformType);
		}
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAttackerHitAudioEventMappingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.AttackerResID != 0)
			{
				AttackerResID = other.AttackerResID;
			}
			if (other.VictimResID != 0)
			{
				VictimResID = other.VictimResID;
			}
			if (other.MappingCondition != EHitPerformAudioMappingCondition.Lower)
			{
				MappingCondition = other.MappingCondition;
			}
			if (other.ConditionEventType != EHitPerformAudioEventType.None)
			{
				ConditionEventType = other.ConditionEventType;
			}
			if (other.MappingHitPerformType != EHitPerformAudioEventType.None)
			{
				MappingHitPerformType = other.MappingHitPerformType;
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
				AttackerResID = input.ReadInt32();
				break;
			case 24u:
				VictimResID = input.ReadInt32();
				break;
			case 32u:
				MappingCondition = (EHitPerformAudioMappingCondition)input.ReadEnum();
				break;
			case 40u:
				ConditionEventType = (EHitPerformAudioEventType)input.ReadEnum();
				break;
			case 48u:
				MappingHitPerformType = (EHitPerformAudioEventType)input.ReadEnum();
				break;
			case 58u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
