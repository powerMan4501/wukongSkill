using System;
using Google.Protobuf;

namespace OssB1;

public sealed class InteractTypeTupleWrapper : IMessage<InteractTypeTupleWrapper>, IMessage, IEquatable<InteractTypeTupleWrapper>, IDeepCloneable<InteractTypeTupleWrapper>
{
	private static readonly MessageParser<InteractTypeTupleWrapper> _parser = new MessageParser<InteractTypeTupleWrapper>(() => new InteractTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private InteractType item1_;

	private InteractType item2_;

	public static MessageParser<InteractTypeTupleWrapper> Parser => _parser;

	public InteractType Item1
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

	public InteractType Item2
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

	public InteractTypeTupleWrapper()
	{
	}

	public InteractTypeTupleWrapper(InteractTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public InteractTypeTupleWrapper Clone()
	{
		return new InteractTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as InteractTypeTupleWrapper);
	}

	public bool Equals(InteractTypeTupleWrapper other)
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
		if (Item1 != InteractType.RevivePoint)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != InteractType.RevivePoint)
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
		if (Item1 != InteractType.RevivePoint)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != InteractType.RevivePoint)
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
		if (Item1 != InteractType.RevivePoint)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != InteractType.RevivePoint)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(InteractTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != InteractType.RevivePoint)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != InteractType.RevivePoint)
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
				Item1 = (InteractType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (InteractType)input.ReadEnum();
				break;
			}
		}
	}
}
