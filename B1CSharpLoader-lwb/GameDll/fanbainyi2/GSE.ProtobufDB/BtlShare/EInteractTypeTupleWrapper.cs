using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EInteractTypeTupleWrapper : IMessage<EInteractTypeTupleWrapper>, IMessage, IEquatable<EInteractTypeTupleWrapper>, IDeepCloneable<EInteractTypeTupleWrapper>
{
	private static readonly MessageParser<EInteractTypeTupleWrapper> _parser = new MessageParser<EInteractTypeTupleWrapper>(() => new EInteractTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EInteractType item1_;

	private EInteractType item2_;

	public static MessageParser<EInteractTypeTupleWrapper> Parser => _parser;

	public EInteractType Item1
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

	public EInteractType Item2
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

	public EInteractTypeTupleWrapper()
	{
	}

	public EInteractTypeTupleWrapper(EInteractTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EInteractTypeTupleWrapper Clone()
	{
		return new EInteractTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EInteractTypeTupleWrapper);
	}

	public bool Equals(EInteractTypeTupleWrapper other)
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
		if (Item1 != EInteractType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EInteractType.None)
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
		if (Item1 != EInteractType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EInteractType.None)
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
		if (Item1 != EInteractType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EInteractType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EInteractTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EInteractType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EInteractType.None)
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
				Item1 = (EInteractType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EInteractType)input.ReadEnum();
				break;
			}
		}
	}
}
