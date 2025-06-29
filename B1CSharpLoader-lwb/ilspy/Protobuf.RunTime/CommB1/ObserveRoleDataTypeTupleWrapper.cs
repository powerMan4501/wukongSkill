using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ObserveRoleDataTypeTupleWrapper : IMessage<ObserveRoleDataTypeTupleWrapper>, IMessage, IEquatable<ObserveRoleDataTypeTupleWrapper>, IDeepCloneable<ObserveRoleDataTypeTupleWrapper>
{
	private static readonly MessageParser<ObserveRoleDataTypeTupleWrapper> _parser = new MessageParser<ObserveRoleDataTypeTupleWrapper>(() => new ObserveRoleDataTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ObserveRoleDataType item1_;

	private ObserveRoleDataType item2_;

	public static MessageParser<ObserveRoleDataTypeTupleWrapper> Parser => _parser;

	public ObserveRoleDataType Item1
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

	public ObserveRoleDataType Item2
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

	public ObserveRoleDataTypeTupleWrapper()
	{
	}

	public ObserveRoleDataTypeTupleWrapper(ObserveRoleDataTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ObserveRoleDataTypeTupleWrapper Clone()
	{
		return new ObserveRoleDataTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ObserveRoleDataTypeTupleWrapper);
	}

	public bool Equals(ObserveRoleDataTypeTupleWrapper other)
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
		if (Item1 != ObserveRoleDataType.ObserveConsumedItem)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ObserveRoleDataType.ObserveConsumedItem)
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
		if (Item1 != ObserveRoleDataType.ObserveConsumedItem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ObserveRoleDataType.ObserveConsumedItem)
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
		if (Item1 != ObserveRoleDataType.ObserveConsumedItem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ObserveRoleDataType.ObserveConsumedItem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ObserveRoleDataTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ObserveRoleDataType.ObserveConsumedItem)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ObserveRoleDataType.ObserveConsumedItem)
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
				Item1 = (ObserveRoleDataType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ObserveRoleDataType)input.ReadEnum();
				break;
			}
		}
	}
}
