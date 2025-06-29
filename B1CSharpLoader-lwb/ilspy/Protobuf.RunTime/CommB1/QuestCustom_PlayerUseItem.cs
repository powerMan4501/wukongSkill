using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_PlayerUseItem : IMessage<QuestCustom_PlayerUseItem>, IMessage, IEquatable<QuestCustom_PlayerUseItem>, IDeepCloneable<QuestCustom_PlayerUseItem>
{
	private static readonly MessageParser<QuestCustom_PlayerUseItem> _parser = new MessageParser<QuestCustom_PlayerUseItem>(() => new QuestCustom_PlayerUseItem());

	private UnknownFieldSet _unknownFields;

	private int itemId_;

	public static MessageParser<QuestCustom_PlayerUseItem> Parser => _parser;

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

	public QuestCustom_PlayerUseItem()
	{
	}

	public QuestCustom_PlayerUseItem(QuestCustom_PlayerUseItem other)
		: this()
	{
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayerUseItem Clone()
	{
		return new QuestCustom_PlayerUseItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayerUseItem);
	}

	public bool Equals(QuestCustom_PlayerUseItem other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
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
		if (ItemId != 0)
		{
			output.WriteRawTag(8);
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

	public void MergeFrom(QuestCustom_PlayerUseItem other)
	{
		if (other != null)
		{
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				ItemId = input.ReadInt32();
			}
		}
	}
}
