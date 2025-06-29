using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStMagicConfInfo : IMessage<FUStMagicConfInfo>, IMessage, IEquatable<FUStMagicConfInfo>, IDeepCloneable<FUStMagicConfInfo>
{
	private static readonly MessageParser<FUStMagicConfInfo> _parser = new MessageParser<FUStMagicConfInfo>(() => new FUStMagicConfInfo());

	private UnknownFieldSet _unknownFields;

	private int spellID_;

	private SpellType type_;

	public static MessageParser<FUStMagicConfInfo> Parser => _parser;

	public int SpellID
	{
		get
		{
			return spellID_;
		}
		set
		{
			spellID_ = value;
		}
	}

	public SpellType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public FUStMagicConfInfo()
	{
	}

	public FUStMagicConfInfo(FUStMagicConfInfo other)
		: this()
	{
		spellID_ = other.spellID_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMagicConfInfo Clone()
	{
		return new FUStMagicConfInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMagicConfInfo);
	}

	public bool Equals(FUStMagicConfInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SpellID != other.SpellID)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SpellID != 0)
		{
			num ^= SpellID.GetHashCode();
		}
		if (Type != SpellType.Min)
		{
			num ^= Type.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SpellID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SpellID);
		}
		if (Type != SpellType.Min)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SpellID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpellID);
		}
		if (Type != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMagicConfInfo other)
	{
		if (other != null)
		{
			if (other.SpellID != 0)
			{
				SpellID = other.SpellID;
			}
			if (other.Type != SpellType.Min)
			{
				Type = other.Type;
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
				SpellID = input.ReadInt32();
				break;
			case 16u:
				Type = (SpellType)input.ReadEnum();
				break;
			}
		}
	}
}
