using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_GainItem : IMessage<CalliopeCustom_GainItem>, IMessage, IEquatable<CalliopeCustom_GainItem>, IDeepCloneable<CalliopeCustom_GainItem>
{
	private static readonly MessageParser<CalliopeCustom_GainItem> _parser = new MessageParser<CalliopeCustom_GainItem>(() => new CalliopeCustom_GainItem());

	private UnknownFieldSet _unknownFields;

	private int itemId_;

	private int itemCount_;

	public static MessageParser<CalliopeCustom_GainItem> Parser => _parser;

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

	public int ItemCount
	{
		get
		{
			return itemCount_;
		}
		set
		{
			itemCount_ = value;
		}
	}

	public CalliopeCustom_GainItem()
	{
	}

	public CalliopeCustom_GainItem(CalliopeCustom_GainItem other)
		: this()
	{
		itemId_ = other.itemId_;
		itemCount_ = other.itemCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_GainItem Clone()
	{
		return new CalliopeCustom_GainItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_GainItem);
	}

	public bool Equals(CalliopeCustom_GainItem other)
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
		if (ItemCount != other.ItemCount)
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
		if (ItemCount != 0)
		{
			num ^= ItemCount.GetHashCode();
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
		if (ItemCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemCount);
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
		if (ItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_GainItem other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				ItemCount = other.ItemCount;
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
				ItemCount = input.ReadInt32();
				break;
			}
		}
	}
}
