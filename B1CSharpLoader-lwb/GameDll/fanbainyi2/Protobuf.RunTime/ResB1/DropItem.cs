using System;
using Google.Protobuf;

namespace ResB1;

public sealed class DropItem : IMessage<DropItem>, IMessage, IEquatable<DropItem>, IDeepCloneable<DropItem>
{
	private static readonly MessageParser<DropItem> _parser = new MessageParser<DropItem>(() => new DropItem());

	private UnknownFieldSet _unknownFields;

	private int itemId_;

	private int randId_;

	public static MessageParser<DropItem> Parser => _parser;

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

	public int RandId
	{
		get
		{
			return randId_;
		}
		set
		{
			randId_ = value;
		}
	}

	public DropItem()
	{
	}

	public DropItem(DropItem other)
		: this()
	{
		itemId_ = other.itemId_;
		randId_ = other.randId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DropItem Clone()
	{
		return new DropItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DropItem);
	}

	public bool Equals(DropItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (RandId != other.RandId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (RandId != 0)
		{
			num ^= RandId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ItemId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ItemId);
		}
		if (RandId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RandId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (RandId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RandId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DropItem other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.RandId != 0)
			{
				RandId = other.RandId;
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
				ItemId = input.ReadInt32();
				break;
			case 16u:
				RandId = input.ReadInt32();
				break;
			}
		}
	}
}
