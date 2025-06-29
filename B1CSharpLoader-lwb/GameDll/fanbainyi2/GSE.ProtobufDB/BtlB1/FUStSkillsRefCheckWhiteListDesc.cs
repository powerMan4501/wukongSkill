using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStSkillsRefCheckWhiteListDesc : IMessage<FUStSkillsRefCheckWhiteListDesc>, IMessage, IEquatable<FUStSkillsRefCheckWhiteListDesc>, IDeepCloneable<FUStSkillsRefCheckWhiteListDesc>
{
	private static readonly MessageParser<FUStSkillsRefCheckWhiteListDesc> _parser = new MessageParser<FUStSkillsRefCheckWhiteListDesc>(() => new FUStSkillsRefCheckWhiteListDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private ESkillsRefIDType iDType_;

	private int whiteListID_;

	private int skillID_;

	private ESkillsRefWhiteListType whiteListType_;

	public static MessageParser<FUStSkillsRefCheckWhiteListDesc> Parser => _parser;

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

	public ESkillsRefIDType IDType
	{
		get
		{
			return iDType_;
		}
		set
		{
			iDType_ = value;
		}
	}

	public int WhiteListID
	{
		get
		{
			return whiteListID_;
		}
		set
		{
			whiteListID_ = value;
		}
	}

	public int SkillID
	{
		get
		{
			return skillID_;
		}
		set
		{
			skillID_ = value;
		}
	}

	public ESkillsRefWhiteListType WhiteListType
	{
		get
		{
			return whiteListType_;
		}
		set
		{
			whiteListType_ = value;
		}
	}

	public FUStSkillsRefCheckWhiteListDesc()
	{
	}

	public FUStSkillsRefCheckWhiteListDesc(FUStSkillsRefCheckWhiteListDesc other)
		: this()
	{
		iD_ = other.iD_;
		iDType_ = other.iDType_;
		whiteListID_ = other.whiteListID_;
		skillID_ = other.skillID_;
		whiteListType_ = other.whiteListType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSkillsRefCheckWhiteListDesc Clone()
	{
		return new FUStSkillsRefCheckWhiteListDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSkillsRefCheckWhiteListDesc);
	}

	public bool Equals(FUStSkillsRefCheckWhiteListDesc other)
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
		if (IDType != other.IDType)
		{
			return false;
		}
		if (WhiteListID != other.WhiteListID)
		{
			return false;
		}
		if (SkillID != other.SkillID)
		{
			return false;
		}
		if (WhiteListType != other.WhiteListType)
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
		if (IDType != ESkillsRefIDType.Effect)
		{
			num ^= IDType.GetHashCode();
		}
		if (WhiteListID != 0)
		{
			num ^= WhiteListID.GetHashCode();
		}
		if (SkillID != 0)
		{
			num ^= SkillID.GetHashCode();
		}
		if (WhiteListType != ESkillsRefWhiteListType.Ignore)
		{
			num ^= WhiteListType.GetHashCode();
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
		if (IDType != ESkillsRefIDType.Effect)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IDType);
		}
		if (WhiteListID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(WhiteListID);
		}
		if (SkillID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SkillID);
		}
		if (WhiteListType != ESkillsRefWhiteListType.Ignore)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)WhiteListType);
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
		if (IDType != ESkillsRefIDType.Effect)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IDType);
		}
		if (WhiteListID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WhiteListID);
		}
		if (SkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillID);
		}
		if (WhiteListType != ESkillsRefWhiteListType.Ignore)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)WhiteListType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSkillsRefCheckWhiteListDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IDType != ESkillsRefIDType.Effect)
			{
				IDType = other.IDType;
			}
			if (other.WhiteListID != 0)
			{
				WhiteListID = other.WhiteListID;
			}
			if (other.SkillID != 0)
			{
				SkillID = other.SkillID;
			}
			if (other.WhiteListType != ESkillsRefWhiteListType.Ignore)
			{
				WhiteListType = other.WhiteListType;
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
				IDType = (ESkillsRefIDType)input.ReadEnum();
				break;
			case 24u:
				WhiteListID = input.ReadInt32();
				break;
			case 32u:
				SkillID = input.ReadInt32();
				break;
			case 40u:
				WhiteListType = (ESkillsRefWhiteListType)input.ReadEnum();
				break;
			}
		}
	}
}
