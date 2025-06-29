using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStTalentLvUpCfgDesc : IMessage<FUStTalentLvUpCfgDesc>, IMessage, IEquatable<FUStTalentLvUpCfgDesc>, IDeepCloneable<FUStTalentLvUpCfgDesc>
{
	private static readonly MessageParser<FUStTalentLvUpCfgDesc> _parser = new MessageParser<FUStTalentLvUpCfgDesc>(() => new FUStTalentLvUpCfgDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int base_;

	private int lvFactor_;

	private int max_;

	public static MessageParser<FUStTalentLvUpCfgDesc> Parser => _parser;

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

	public int Base
	{
		get
		{
			return base_;
		}
		set
		{
			base_ = value;
		}
	}

	public int LvFactor
	{
		get
		{
			return lvFactor_;
		}
		set
		{
			lvFactor_ = value;
		}
	}

	public int Max
	{
		get
		{
			return max_;
		}
		set
		{
			max_ = value;
		}
	}

	public FUStTalentLvUpCfgDesc()
	{
	}

	public FUStTalentLvUpCfgDesc(FUStTalentLvUpCfgDesc other)
		: this()
	{
		iD_ = other.iD_;
		base_ = other.base_;
		lvFactor_ = other.lvFactor_;
		max_ = other.max_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTalentLvUpCfgDesc Clone()
	{
		return new FUStTalentLvUpCfgDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTalentLvUpCfgDesc);
	}

	public bool Equals(FUStTalentLvUpCfgDesc other)
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
		if (Base != other.Base)
		{
			return false;
		}
		if (LvFactor != other.LvFactor)
		{
			return false;
		}
		if (Max != other.Max)
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
		if (Base != 0)
		{
			num ^= Base.GetHashCode();
		}
		if (LvFactor != 0)
		{
			num ^= LvFactor.GetHashCode();
		}
		if (Max != 0)
		{
			num ^= Max.GetHashCode();
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
		if (Base != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Base);
		}
		if (LvFactor != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LvFactor);
		}
		if (Max != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Max);
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
		if (Base != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Base);
		}
		if (LvFactor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LvFactor);
		}
		if (Max != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Max);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTalentLvUpCfgDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Base != 0)
			{
				Base = other.Base;
			}
			if (other.LvFactor != 0)
			{
				LvFactor = other.LvFactor;
			}
			if (other.Max != 0)
			{
				Max = other.Max;
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
				Base = input.ReadInt32();
				break;
			case 24u:
				LvFactor = input.ReadInt32();
				break;
			case 32u:
				Max = input.ReadInt32();
				break;
			}
		}
	}
}
