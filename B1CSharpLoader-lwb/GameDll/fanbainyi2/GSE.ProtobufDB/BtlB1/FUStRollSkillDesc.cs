using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStRollSkillDesc : IMessage<FUStRollSkillDesc>, IMessage, IEquatable<FUStRollSkillDesc>, IDeepCloneable<FUStRollSkillDesc>
{
	private static readonly MessageParser<FUStRollSkillDesc> _parser = new MessageParser<FUStRollSkillDesc>(() => new FUStRollSkillDesc());

	private UnknownFieldSet _unknownFields;

	private EGSYesNo enableSkill_;

	private int iD_;

	private int nextRollSkillID_;

	private EGSYesNo useMultiRoll_;

	private EGSYesNo multiJustInLock_;

	public static MessageParser<FUStRollSkillDesc> Parser => _parser;

	public EGSYesNo EnableSkill
	{
		get
		{
			return enableSkill_;
		}
		set
		{
			enableSkill_ = value;
		}
	}

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

	public int NextRollSkillID
	{
		get
		{
			return nextRollSkillID_;
		}
		set
		{
			nextRollSkillID_ = value;
		}
	}

	public EGSYesNo UseMultiRoll
	{
		get
		{
			return useMultiRoll_;
		}
		set
		{
			useMultiRoll_ = value;
		}
	}

	public EGSYesNo MultiJustInLock
	{
		get
		{
			return multiJustInLock_;
		}
		set
		{
			multiJustInLock_ = value;
		}
	}

	public FUStRollSkillDesc()
	{
	}

	public FUStRollSkillDesc(FUStRollSkillDesc other)
		: this()
	{
		enableSkill_ = other.enableSkill_;
		iD_ = other.iD_;
		nextRollSkillID_ = other.nextRollSkillID_;
		useMultiRoll_ = other.useMultiRoll_;
		multiJustInLock_ = other.multiJustInLock_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStRollSkillDesc Clone()
	{
		return new FUStRollSkillDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStRollSkillDesc);
	}

	public bool Equals(FUStRollSkillDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EnableSkill != other.EnableSkill)
		{
			return false;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (NextRollSkillID != other.NextRollSkillID)
		{
			return false;
		}
		if (UseMultiRoll != other.UseMultiRoll)
		{
			return false;
		}
		if (MultiJustInLock != other.MultiJustInLock)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EnableSkill != EGSYesNo.No)
		{
			num ^= EnableSkill.GetHashCode();
		}
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (NextRollSkillID != 0)
		{
			num ^= NextRollSkillID.GetHashCode();
		}
		if (UseMultiRoll != EGSYesNo.No)
		{
			num ^= UseMultiRoll.GetHashCode();
		}
		if (MultiJustInLock != EGSYesNo.No)
		{
			num ^= MultiJustInLock.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EnableSkill != EGSYesNo.No)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EnableSkill);
		}
		if (ID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ID);
		}
		if (NextRollSkillID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(NextRollSkillID);
		}
		if (UseMultiRoll != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)UseMultiRoll);
		}
		if (MultiJustInLock != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)MultiJustInLock);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EnableSkill != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EnableSkill);
		}
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (NextRollSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextRollSkillID);
		}
		if (UseMultiRoll != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UseMultiRoll);
		}
		if (MultiJustInLock != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MultiJustInLock);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStRollSkillDesc other)
	{
		if (other != null)
		{
			if (other.EnableSkill != EGSYesNo.No)
			{
				EnableSkill = other.EnableSkill;
			}
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.NextRollSkillID != 0)
			{
				NextRollSkillID = other.NextRollSkillID;
			}
			if (other.UseMultiRoll != EGSYesNo.No)
			{
				UseMultiRoll = other.UseMultiRoll;
			}
			if (other.MultiJustInLock != EGSYesNo.No)
			{
				MultiJustInLock = other.MultiJustInLock;
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
				EnableSkill = (EGSYesNo)input.ReadEnum();
				break;
			case 16u:
				ID = input.ReadInt32();
				break;
			case 24u:
				NextRollSkillID = input.ReadInt32();
				break;
			case 32u:
				UseMultiRoll = (EGSYesNo)input.ReadEnum();
				break;
			case 40u:
				MultiJustInLock = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
