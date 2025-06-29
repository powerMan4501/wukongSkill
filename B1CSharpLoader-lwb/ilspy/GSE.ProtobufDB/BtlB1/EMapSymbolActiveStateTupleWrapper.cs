using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EMapSymbolActiveStateTupleWrapper : IMessage<EMapSymbolActiveStateTupleWrapper>, IMessage, IEquatable<EMapSymbolActiveStateTupleWrapper>, IDeepCloneable<EMapSymbolActiveStateTupleWrapper>
{
	private static readonly MessageParser<EMapSymbolActiveStateTupleWrapper> _parser = new MessageParser<EMapSymbolActiveStateTupleWrapper>(() => new EMapSymbolActiveStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EMapSymbolActiveState item1_;

	private EMapSymbolActiveState item2_;

	public static MessageParser<EMapSymbolActiveStateTupleWrapper> Parser => _parser;

	public EMapSymbolActiveState Item1
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

	public EMapSymbolActiveState Item2
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

	public EMapSymbolActiveStateTupleWrapper()
	{
	}

	public EMapSymbolActiveStateTupleWrapper(EMapSymbolActiveStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EMapSymbolActiveStateTupleWrapper Clone()
	{
		return new EMapSymbolActiveStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EMapSymbolActiveStateTupleWrapper);
	}

	public bool Equals(EMapSymbolActiveStateTupleWrapper other)
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
		if (Item1 != EMapSymbolActiveState.Normal)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EMapSymbolActiveState.Normal)
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
		if (Item1 != EMapSymbolActiveState.Normal)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EMapSymbolActiveState.Normal)
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
		if (Item1 != EMapSymbolActiveState.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EMapSymbolActiveState.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EMapSymbolActiveStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EMapSymbolActiveState.Normal)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EMapSymbolActiveState.Normal)
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
				Item1 = (EMapSymbolActiveState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EMapSymbolActiveState)input.ReadEnum();
				break;
			}
		}
	}
}
