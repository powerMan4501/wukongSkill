using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStGroupAISDesc : IMessage<FUStGroupAISDesc>, IMessage, IEquatable<FUStGroupAISDesc>, IDeepCloneable<FUStGroupAISDesc>
{
	private static readonly MessageParser<FUStGroupAISDesc> _parser = new MessageParser<FUStGroupAISDesc>(() => new FUStGroupAISDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo defaultCanJoinGroupAI_;

	private EGroupAIAttackBias groupAIAttackBias_;

	private float groupAIShortDisPrioWeight_;

	private float groupAIMiddleDisPrioWeight_;

	private float groupAILongDisPrioWeight_;

	private int groupAIAtkRequestTokenNum_;

	private int groupAIPriorityNumInSameScore_;

	private EGroupAIMoveType moveToPointType_;

	private EGroupAIMoveType moveToTargetType_;

	public static MessageParser<FUStGroupAISDesc> Parser => _parser;

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

	public EGSYesNo DefaultCanJoinGroupAI
	{
		get
		{
			return defaultCanJoinGroupAI_;
		}
		set
		{
			defaultCanJoinGroupAI_ = value;
		}
	}

	public EGroupAIAttackBias GroupAIAttackBias
	{
		get
		{
			return groupAIAttackBias_;
		}
		set
		{
			groupAIAttackBias_ = value;
		}
	}

	public float GroupAIShortDisPrioWeight
	{
		get
		{
			return groupAIShortDisPrioWeight_;
		}
		set
		{
			groupAIShortDisPrioWeight_ = value;
		}
	}

	public float GroupAIMiddleDisPrioWeight
	{
		get
		{
			return groupAIMiddleDisPrioWeight_;
		}
		set
		{
			groupAIMiddleDisPrioWeight_ = value;
		}
	}

	public float GroupAILongDisPrioWeight
	{
		get
		{
			return groupAILongDisPrioWeight_;
		}
		set
		{
			groupAILongDisPrioWeight_ = value;
		}
	}

	public int GroupAIAtkRequestTokenNum
	{
		get
		{
			return groupAIAtkRequestTokenNum_;
		}
		set
		{
			groupAIAtkRequestTokenNum_ = value;
		}
	}

	public int GroupAIPriorityNumInSameScore
	{
		get
		{
			return groupAIPriorityNumInSameScore_;
		}
		set
		{
			groupAIPriorityNumInSameScore_ = value;
		}
	}

	public EGroupAIMoveType MoveToPointType
	{
		get
		{
			return moveToPointType_;
		}
		set
		{
			moveToPointType_ = value;
		}
	}

	public EGroupAIMoveType MoveToTargetType
	{
		get
		{
			return moveToTargetType_;
		}
		set
		{
			moveToTargetType_ = value;
		}
	}

	public FUStGroupAISDesc()
	{
	}

	public FUStGroupAISDesc(FUStGroupAISDesc other)
		: this()
	{
		iD_ = other.iD_;
		defaultCanJoinGroupAI_ = other.defaultCanJoinGroupAI_;
		groupAIAttackBias_ = other.groupAIAttackBias_;
		groupAIShortDisPrioWeight_ = other.groupAIShortDisPrioWeight_;
		groupAIMiddleDisPrioWeight_ = other.groupAIMiddleDisPrioWeight_;
		groupAILongDisPrioWeight_ = other.groupAILongDisPrioWeight_;
		groupAIAtkRequestTokenNum_ = other.groupAIAtkRequestTokenNum_;
		groupAIPriorityNumInSameScore_ = other.groupAIPriorityNumInSameScore_;
		moveToPointType_ = other.moveToPointType_;
		moveToTargetType_ = other.moveToTargetType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGroupAISDesc Clone()
	{
		return new FUStGroupAISDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGroupAISDesc);
	}

	public bool Equals(FUStGroupAISDesc other)
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
		if (DefaultCanJoinGroupAI != other.DefaultCanJoinGroupAI)
		{
			return false;
		}
		if (GroupAIAttackBias != other.GroupAIAttackBias)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GroupAIShortDisPrioWeight, other.GroupAIShortDisPrioWeight))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GroupAIMiddleDisPrioWeight, other.GroupAIMiddleDisPrioWeight))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GroupAILongDisPrioWeight, other.GroupAILongDisPrioWeight))
		{
			return false;
		}
		if (GroupAIAtkRequestTokenNum != other.GroupAIAtkRequestTokenNum)
		{
			return false;
		}
		if (GroupAIPriorityNumInSameScore != other.GroupAIPriorityNumInSameScore)
		{
			return false;
		}
		if (MoveToPointType != other.MoveToPointType)
		{
			return false;
		}
		if (MoveToTargetType != other.MoveToTargetType)
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
		if (DefaultCanJoinGroupAI != EGSYesNo.No)
		{
			num ^= DefaultCanJoinGroupAI.GetHashCode();
		}
		if (GroupAIAttackBias != EGroupAIAttackBias.None)
		{
			num ^= GroupAIAttackBias.GetHashCode();
		}
		if (GroupAIShortDisPrioWeight != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GroupAIShortDisPrioWeight);
		}
		if (GroupAIMiddleDisPrioWeight != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GroupAIMiddleDisPrioWeight);
		}
		if (GroupAILongDisPrioWeight != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GroupAILongDisPrioWeight);
		}
		if (GroupAIAtkRequestTokenNum != 0)
		{
			num ^= GroupAIAtkRequestTokenNum.GetHashCode();
		}
		if (GroupAIPriorityNumInSameScore != 0)
		{
			num ^= GroupAIPriorityNumInSameScore.GetHashCode();
		}
		if (MoveToPointType != EGroupAIMoveType.UseDefault)
		{
			num ^= MoveToPointType.GetHashCode();
		}
		if (MoveToTargetType != EGroupAIMoveType.UseDefault)
		{
			num ^= MoveToTargetType.GetHashCode();
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
		if (DefaultCanJoinGroupAI != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DefaultCanJoinGroupAI);
		}
		if (GroupAIAttackBias != EGroupAIAttackBias.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)GroupAIAttackBias);
		}
		if (GroupAIShortDisPrioWeight != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(GroupAIShortDisPrioWeight);
		}
		if (GroupAIMiddleDisPrioWeight != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(GroupAIMiddleDisPrioWeight);
		}
		if (GroupAILongDisPrioWeight != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(GroupAILongDisPrioWeight);
		}
		if (GroupAIAtkRequestTokenNum != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GroupAIAtkRequestTokenNum);
		}
		if (GroupAIPriorityNumInSameScore != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(GroupAIPriorityNumInSameScore);
		}
		if (MoveToPointType != EGroupAIMoveType.UseDefault)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)MoveToPointType);
		}
		if (MoveToTargetType != EGroupAIMoveType.UseDefault)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)MoveToTargetType);
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
		if (DefaultCanJoinGroupAI != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DefaultCanJoinGroupAI);
		}
		if (GroupAIAttackBias != EGroupAIAttackBias.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GroupAIAttackBias);
		}
		if (GroupAIShortDisPrioWeight != 0f)
		{
			num += 5;
		}
		if (GroupAIMiddleDisPrioWeight != 0f)
		{
			num += 5;
		}
		if (GroupAILongDisPrioWeight != 0f)
		{
			num += 5;
		}
		if (GroupAIAtkRequestTokenNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupAIAtkRequestTokenNum);
		}
		if (GroupAIPriorityNumInSameScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupAIPriorityNumInSameScore);
		}
		if (MoveToPointType != EGroupAIMoveType.UseDefault)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MoveToPointType);
		}
		if (MoveToTargetType != EGroupAIMoveType.UseDefault)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MoveToTargetType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGroupAISDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DefaultCanJoinGroupAI != EGSYesNo.No)
			{
				DefaultCanJoinGroupAI = other.DefaultCanJoinGroupAI;
			}
			if (other.GroupAIAttackBias != EGroupAIAttackBias.None)
			{
				GroupAIAttackBias = other.GroupAIAttackBias;
			}
			if (other.GroupAIShortDisPrioWeight != 0f)
			{
				GroupAIShortDisPrioWeight = other.GroupAIShortDisPrioWeight;
			}
			if (other.GroupAIMiddleDisPrioWeight != 0f)
			{
				GroupAIMiddleDisPrioWeight = other.GroupAIMiddleDisPrioWeight;
			}
			if (other.GroupAILongDisPrioWeight != 0f)
			{
				GroupAILongDisPrioWeight = other.GroupAILongDisPrioWeight;
			}
			if (other.GroupAIAtkRequestTokenNum != 0)
			{
				GroupAIAtkRequestTokenNum = other.GroupAIAtkRequestTokenNum;
			}
			if (other.GroupAIPriorityNumInSameScore != 0)
			{
				GroupAIPriorityNumInSameScore = other.GroupAIPriorityNumInSameScore;
			}
			if (other.MoveToPointType != EGroupAIMoveType.UseDefault)
			{
				MoveToPointType = other.MoveToPointType;
			}
			if (other.MoveToTargetType != EGroupAIMoveType.UseDefault)
			{
				MoveToTargetType = other.MoveToTargetType;
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
				DefaultCanJoinGroupAI = (EGSYesNo)input.ReadEnum();
				break;
			case 24u:
				GroupAIAttackBias = (EGroupAIAttackBias)input.ReadEnum();
				break;
			case 37u:
				GroupAIShortDisPrioWeight = input.ReadFloat();
				break;
			case 45u:
				GroupAIMiddleDisPrioWeight = input.ReadFloat();
				break;
			case 53u:
				GroupAILongDisPrioWeight = input.ReadFloat();
				break;
			case 56u:
				GroupAIAtkRequestTokenNum = input.ReadInt32();
				break;
			case 64u:
				GroupAIPriorityNumInSameScore = input.ReadInt32();
				break;
			case 72u:
				MoveToPointType = (EGroupAIMoveType)input.ReadEnum();
				break;
			case 80u:
				MoveToTargetType = (EGroupAIMoveType)input.ReadEnum();
				break;
			}
		}
	}
}
