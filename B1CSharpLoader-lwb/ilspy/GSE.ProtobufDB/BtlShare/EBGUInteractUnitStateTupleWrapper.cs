using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBGUInteractUnitStateTupleWrapper : IMessage<EBGUInteractUnitStateTupleWrapper>, IMessage, IEquatable<EBGUInteractUnitStateTupleWrapper>, IDeepCloneable<EBGUInteractUnitStateTupleWrapper>
{
	private static readonly MessageParser<EBGUInteractUnitStateTupleWrapper> _parser = new MessageParser<EBGUInteractUnitStateTupleWrapper>(() => new EBGUInteractUnitStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBGUInteractUnitState item1_;

	private EBGUInteractUnitState item2_;

	public static MessageParser<EBGUInteractUnitStateTupleWrapper> Parser => _parser;

	public EBGUInteractUnitState Item1
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

	public EBGUInteractUnitState Item2
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

	public EBGUInteractUnitStateTupleWrapper()
	{
	}

	public EBGUInteractUnitStateTupleWrapper(EBGUInteractUnitStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBGUInteractUnitStateTupleWrapper Clone()
	{
		return new EBGUInteractUnitStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBGUInteractUnitStateTupleWrapper);
	}

	public bool Equals(EBGUInteractUnitStateTupleWrapper other)
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
		if (Item1 != EBGUInteractUnitState.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBGUInteractUnitState.Default)
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
		if (Item1 != EBGUInteractUnitState.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBGUInteractUnitState.Default)
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
		if (Item1 != EBGUInteractUnitState.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBGUInteractUnitState.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBGUInteractUnitStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBGUInteractUnitState.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBGUInteractUnitState.Default)
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
				Item1 = (EBGUInteractUnitState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBGUInteractUnitState)input.ReadEnum();
				break;
			}
		}
	}
}
