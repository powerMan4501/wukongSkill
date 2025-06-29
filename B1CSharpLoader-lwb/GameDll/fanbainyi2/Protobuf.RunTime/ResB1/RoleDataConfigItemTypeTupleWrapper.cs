using System;
using Google.Protobuf;

namespace ResB1;

public sealed class RoleDataConfigItemTypeTupleWrapper : IMessage<RoleDataConfigItemTypeTupleWrapper>, IMessage, IEquatable<RoleDataConfigItemTypeTupleWrapper>, IDeepCloneable<RoleDataConfigItemTypeTupleWrapper>
{
	private static readonly MessageParser<RoleDataConfigItemTypeTupleWrapper> _parser = new MessageParser<RoleDataConfigItemTypeTupleWrapper>(() => new RoleDataConfigItemTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private RoleDataConfigItemType item1_;

	private RoleDataConfigItemType item2_;

	public static MessageParser<RoleDataConfigItemTypeTupleWrapper> Parser => _parser;

	public RoleDataConfigItemType Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public RoleDataConfigItemType Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public RoleDataConfigItemTypeTupleWrapper()
	{
	}

	public RoleDataConfigItemTypeTupleWrapper(RoleDataConfigItemTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataConfigItemTypeTupleWrapper Clone()
	{
		return new RoleDataConfigItemTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataConfigItemTypeTupleWrapper);
	}

	public bool Equals(RoleDataConfigItemTypeTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != RoleDataConfigItemType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != RoleDataConfigItemType.None)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != RoleDataConfigItemType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != RoleDataConfigItemType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != RoleDataConfigItemType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != RoleDataConfigItemType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataConfigItemTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != RoleDataConfigItemType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != RoleDataConfigItemType.None)
			{
				Item2 = other.Item2;
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
				Item1 = (RoleDataConfigItemType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (RoleDataConfigItemType)input.ReadEnum();
				break;
			}
		}
	}
}
