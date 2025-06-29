using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ItemOne : IMessage<ItemOne>, IMessage, IEquatable<ItemOne>, IDeepCloneable<ItemOne>
{
	private static readonly MessageParser<ItemOne> _parser = new MessageParser<ItemOne>(() => new ItemOne());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int num_;

	public static MessageParser<ItemOne> Parser => _parser;

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

	public int Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	public ItemOne()
	{
	}

	public ItemOne(ItemOne other)
		: this()
	{
		id_ = other.id_;
		num_ = other.num_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ItemOne Clone()
	{
		return new ItemOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ItemOne);
	}

	public bool Equals(ItemOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Num != other.Num)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Num != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Num);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Num);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ItemOne other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				Num = input.ReadInt32();
				break;
			}
		}
	}
}
