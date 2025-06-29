using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ECollectionInteractTypeTupleWrapper : IMessage<ECollectionInteractTypeTupleWrapper>, IMessage, IEquatable<ECollectionInteractTypeTupleWrapper>, IDeepCloneable<ECollectionInteractTypeTupleWrapper>
{
	private static readonly MessageParser<ECollectionInteractTypeTupleWrapper> _parser = new MessageParser<ECollectionInteractTypeTupleWrapper>(() => new ECollectionInteractTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ECollectionInteractType item1_;

	private ECollectionInteractType item2_;

	public static MessageParser<ECollectionInteractTypeTupleWrapper> Parser => _parser;

	public ECollectionInteractType Item1
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

	public ECollectionInteractType Item2
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

	public ECollectionInteractTypeTupleWrapper()
	{
	}

	public ECollectionInteractTypeTupleWrapper(ECollectionInteractTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ECollectionInteractTypeTupleWrapper Clone()
	{
		return new ECollectionInteractTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ECollectionInteractTypeTupleWrapper);
	}

	public bool Equals(ECollectionInteractTypeTupleWrapper other)
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
		if (Item1 != ECollectionInteractType.Item)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ECollectionInteractType.Item)
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
		if (Item1 != ECollectionInteractType.Item)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ECollectionInteractType.Item)
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
		if (Item1 != ECollectionInteractType.Item)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ECollectionInteractType.Item)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ECollectionInteractTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ECollectionInteractType.Item)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ECollectionInteractType.Item)
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
				Item1 = (ECollectionInteractType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ECollectionInteractType)input.ReadEnum();
				break;
			}
		}
	}
}
