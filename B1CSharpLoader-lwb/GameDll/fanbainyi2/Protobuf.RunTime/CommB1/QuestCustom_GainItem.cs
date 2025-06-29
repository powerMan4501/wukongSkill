using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_GainItem : IMessage<QuestCustom_GainItem>, IMessage, IEquatable<QuestCustom_GainItem>, IDeepCloneable<QuestCustom_GainItem>
{
	private static readonly MessageParser<QuestCustom_GainItem> _parser = new MessageParser<QuestCustom_GainItem>(() => new QuestCustom_GainItem());

	private UnknownFieldSet _unknownFields;

	private int itemId_;

	private int count_;

	public static MessageParser<QuestCustom_GainItem> Parser => _parser;

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

	public int Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	public QuestCustom_GainItem()
	{
	}

	public QuestCustom_GainItem(QuestCustom_GainItem other)
		: this()
	{
		itemId_ = other.itemId_;
		count_ = other.count_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_GainItem Clone()
	{
		return new QuestCustom_GainItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_GainItem);
	}

	public bool Equals(QuestCustom_GainItem other)
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
		if (Count != other.Count)
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
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
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
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Count);
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
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Count);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_GainItem other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
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
				Count = input.ReadInt32();
				break;
			}
		}
	}
}
