using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class WinePartner : IMessage<WinePartner>, IMessage, IEquatable<WinePartner>, IDeepCloneable<WinePartner>
{
	private static readonly MessageParser<WinePartner> _parser = new MessageParser<WinePartner>(() => new WinePartner());

	private UnknownFieldSet _unknownFields;

	private int pos_;

	private int itemId_;

	public static MessageParser<WinePartner> Parser => _parser;

	public int Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	public WinePartner()
	{
	}

	public WinePartner(WinePartner other)
		: this()
	{
		pos_ = other.pos_;
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WinePartner Clone()
	{
		return new WinePartner(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WinePartner);
	}

	public bool Equals(WinePartner other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Pos != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Pos);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Pos);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WinePartner other)
	{
		if (other != null)
		{
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
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
				Pos = input.ReadInt32();
				break;
			case 16u:
				ItemId = input.ReadInt32();
				break;
			}
		}
	}
}
