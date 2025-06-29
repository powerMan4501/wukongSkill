using System;
using BtlB1;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class SpellItem : IMessage<SpellItem>, IMessage, IEquatable<SpellItem>, IDeepCloneable<SpellItem>
{
	private static readonly MessageParser<SpellItem> _parser = new MessageParser<SpellItem>(() => new SpellItem());

	private UnknownFieldSet _unknownFields;

	private SpellType type_;

	private int spellId_;

	public static MessageParser<SpellItem> Parser => _parser;

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

	public int SpellId
	{
		get
		{
			return spellId_;
		}
		set
		{
			spellId_ = value;
		}
	}

	public SpellItem()
	{
	}

	public SpellItem(SpellItem other)
		: this()
	{
		type_ = other.type_;
		spellId_ = other.spellId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SpellItem Clone()
	{
		return new SpellItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SpellItem);
	}

	public bool Equals(SpellItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (SpellId != other.SpellId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Type != SpellType.Min)
		{
			num ^= Type.GetHashCode();
		}
		if (SpellId != 0)
		{
			num ^= SpellId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Type != SpellType.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (SpellId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SpellId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Type != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (SpellId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpellId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SpellItem other)
	{
		if (other != null)
		{
			if (other.Type != SpellType.Min)
			{
				Type = other.Type;
			}
			if (other.SpellId != 0)
			{
				SpellId = other.SpellId;
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
				Type = (SpellType)input.ReadEnum();
				break;
			case 16u:
				SpellId = input.ReadInt32();
				break;
			}
		}
	}
}
