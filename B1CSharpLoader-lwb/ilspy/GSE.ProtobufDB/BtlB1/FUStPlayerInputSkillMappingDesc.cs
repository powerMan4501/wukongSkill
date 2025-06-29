using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStPlayerInputSkillMappingDesc : IMessage<FUStPlayerInputSkillMappingDesc>, IMessage, IEquatable<FUStPlayerInputSkillMappingDesc>, IDeepCloneable<FUStPlayerInputSkillMappingDesc>
{
	private static readonly MessageParser<FUStPlayerInputSkillMappingDesc> _parser = new MessageParser<FUStPlayerInputSkillMappingDesc>(() => new FUStPlayerInputSkillMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int dodgeStartSkillID_;

	private int preciseDodgeStartSkillID_;

	public static MessageParser<FUStPlayerInputSkillMappingDesc> Parser => _parser;

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

	public int DodgeStartSkillID
	{
		get
		{
			return dodgeStartSkillID_;
		}
		set
		{
			dodgeStartSkillID_ = value;
		}
	}

	public int PreciseDodgeStartSkillID
	{
		get
		{
			return preciseDodgeStartSkillID_;
		}
		set
		{
			preciseDodgeStartSkillID_ = value;
		}
	}

	public FUStPlayerInputSkillMappingDesc()
	{
	}

	public FUStPlayerInputSkillMappingDesc(FUStPlayerInputSkillMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		dodgeStartSkillID_ = other.dodgeStartSkillID_;
		preciseDodgeStartSkillID_ = other.preciseDodgeStartSkillID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPlayerInputSkillMappingDesc Clone()
	{
		return new FUStPlayerInputSkillMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPlayerInputSkillMappingDesc);
	}

	public bool Equals(FUStPlayerInputSkillMappingDesc other)
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
		if (DodgeStartSkillID != other.DodgeStartSkillID)
		{
			return false;
		}
		if (PreciseDodgeStartSkillID != other.PreciseDodgeStartSkillID)
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
		if (DodgeStartSkillID != 0)
		{
			num ^= DodgeStartSkillID.GetHashCode();
		}
		if (PreciseDodgeStartSkillID != 0)
		{
			num ^= PreciseDodgeStartSkillID.GetHashCode();
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
		if (DodgeStartSkillID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DodgeStartSkillID);
		}
		if (PreciseDodgeStartSkillID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PreciseDodgeStartSkillID);
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
		if (DodgeStartSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DodgeStartSkillID);
		}
		if (PreciseDodgeStartSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PreciseDodgeStartSkillID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPlayerInputSkillMappingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DodgeStartSkillID != 0)
			{
				DodgeStartSkillID = other.DodgeStartSkillID;
			}
			if (other.PreciseDodgeStartSkillID != 0)
			{
				PreciseDodgeStartSkillID = other.PreciseDodgeStartSkillID;
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
				DodgeStartSkillID = input.ReadInt32();
				break;
			case 24u:
				PreciseDodgeStartSkillID = input.ReadInt32();
				break;
			}
		}
	}
}
