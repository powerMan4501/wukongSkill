using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ShortcutItem : IMessage<ShortcutItem>, IMessage, IEquatable<ShortcutItem>, IDeepCloneable<ShortcutItem>
{
	private static readonly MessageParser<ShortcutItem> _parser = new MessageParser<ShortcutItem>(() => new ShortcutItem());

	private UnknownFieldSet _unknownFields;

	private int itemId_;

	private int position_;

	public static MessageParser<ShortcutItem> Parser => _parser;

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

	public int Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public ShortcutItem()
	{
	}

	public ShortcutItem(ShortcutItem other)
		: this()
	{
		itemId_ = other.itemId_;
		position_ = other.position_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShortcutItem Clone()
	{
		return new ShortcutItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShortcutItem);
	}

	public bool Equals(ShortcutItem other)
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
		if (Position != other.Position)
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
		if (Position != 0)
		{
			num ^= Position.GetHashCode();
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
		if (Position != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Position);
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
		if (Position != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Position);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShortcutItem other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.Position != 0)
			{
				Position = other.Position;
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
				Position = input.ReadInt32();
				break;
			}
		}
	}
}
