using System;
using Google.Protobuf;

namespace OssB1;

public sealed class AccessorySlot : IMessage<AccessorySlot>, IMessage, IEquatable<AccessorySlot>, IDeepCloneable<AccessorySlot>
{
	private static readonly MessageParser<AccessorySlot> _parser = new MessageParser<AccessorySlot>(() => new AccessorySlot());

	private UnknownFieldSet _unknownFields;

	private int slotIndex_;

	private int id_;

	public static MessageParser<AccessorySlot> Parser => _parser;

	public int SlotIndex
	{
		get
		{
			return slotIndex_;
		}
		set
		{
			slotIndex_ = value;
		}
	}

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public AccessorySlot()
	{
	}

	public AccessorySlot(AccessorySlot other)
		: this()
	{
		slotIndex_ = other.slotIndex_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AccessorySlot Clone()
	{
		return new AccessorySlot(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AccessorySlot);
	}

	public bool Equals(AccessorySlot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SlotIndex != other.SlotIndex)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SlotIndex != 0)
		{
			num ^= SlotIndex.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SlotIndex != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SlotIndex);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SlotIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SlotIndex);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AccessorySlot other)
	{
		if (other != null)
		{
			if (other.SlotIndex != 0)
			{
				SlotIndex = other.SlotIndex;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
				SlotIndex = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			}
		}
	}
}
