using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStSwitchMagicConfInfo : IMessage<FUStSwitchMagicConfInfo>, IMessage, IEquatable<FUStSwitchMagicConfInfo>, IDeepCloneable<FUStSwitchMagicConfInfo>
{
	private static readonly MessageParser<FUStSwitchMagicConfInfo> _parser = new MessageParser<FUStSwitchMagicConfInfo>(() => new FUStSwitchMagicConfInfo());

	private UnknownFieldSet _unknownFields;

	private SpellType findType_;

	private int findSpellID_;

	private SpellType setType_;

	private int setSpellID_;

	public static MessageParser<FUStSwitchMagicConfInfo> Parser => _parser;

	public SpellType FindType
	{
		get
		{
			return findType_;
		}
		set
		{
			findType_ = value;
		}
	}

	public int FindSpellID
	{
		get
		{
			return findSpellID_;
		}
		set
		{
			findSpellID_ = value;
		}
	}

	public SpellType SetType
	{
		get
		{
			return setType_;
		}
		set
		{
			setType_ = value;
		}
	}

	public int SetSpellID
	{
		get
		{
			return setSpellID_;
		}
		set
		{
			setSpellID_ = value;
		}
	}

	public FUStSwitchMagicConfInfo()
	{
	}

	public FUStSwitchMagicConfInfo(FUStSwitchMagicConfInfo other)
		: this()
	{
		findType_ = other.findType_;
		findSpellID_ = other.findSpellID_;
		setType_ = other.setType_;
		setSpellID_ = other.setSpellID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSwitchMagicConfInfo Clone()
	{
		return new FUStSwitchMagicConfInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSwitchMagicConfInfo);
	}

	public bool Equals(FUStSwitchMagicConfInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FindType != other.FindType)
		{
			return false;
		}
		if (FindSpellID != other.FindSpellID)
		{
			return false;
		}
		if (SetType != other.SetType)
		{
			return false;
		}
		if (SetSpellID != other.SetSpellID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (FindType != SpellType.Min)
		{
			num ^= FindType.GetHashCode();
		}
		if (FindSpellID != 0)
		{
			num ^= FindSpellID.GetHashCode();
		}
		if (SetType != SpellType.Min)
		{
			num ^= SetType.GetHashCode();
		}
		if (SetSpellID != 0)
		{
			num ^= SetSpellID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (FindType != SpellType.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)FindType);
		}
		if (FindSpellID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(FindSpellID);
		}
		if (SetType != SpellType.Min)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)SetType);
		}
		if (SetSpellID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SetSpellID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (FindType != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FindType);
		}
		if (FindSpellID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FindSpellID);
		}
		if (SetType != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SetType);
		}
		if (SetSpellID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SetSpellID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSwitchMagicConfInfo other)
	{
		if (other != null)
		{
			if (other.FindType != SpellType.Min)
			{
				FindType = other.FindType;
			}
			if (other.FindSpellID != 0)
			{
				FindSpellID = other.FindSpellID;
			}
			if (other.SetType != SpellType.Min)
			{
				SetType = other.SetType;
			}
			if (other.SetSpellID != 0)
			{
				SetSpellID = other.SetSpellID;
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
				FindType = (SpellType)input.ReadEnum();
				break;
			case 16u:
				FindSpellID = input.ReadInt32();
				break;
			case 24u:
				SetType = (SpellType)input.ReadEnum();
				break;
			case 32u:
				SetSpellID = input.ReadInt32();
				break;
			}
		}
	}
}
