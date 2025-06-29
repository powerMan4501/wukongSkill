using System;
using Google.Protobuf;

namespace OssB1;

public sealed class WinePartnerSlot : IMessage<WinePartnerSlot>, IMessage, IEquatable<WinePartnerSlot>, IDeepCloneable<WinePartnerSlot>
{
	private static readonly MessageParser<WinePartnerSlot> _parser = new MessageParser<WinePartnerSlot>(() => new WinePartnerSlot());

	private UnknownFieldSet _unknownFields;

	private int slotIndex_;

	private int id_;

	public static MessageParser<WinePartnerSlot> Parser => _parser;

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

	public WinePartnerSlot()
	{
	}

	public WinePartnerSlot(WinePartnerSlot other)
		: this()
	{
		slotIndex_ = other.slotIndex_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WinePartnerSlot Clone()
	{
		return new WinePartnerSlot(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WinePartnerSlot);
	}

	public bool Equals(WinePartnerSlot other)
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

	public void MergeFrom(WinePartnerSlot other)
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
