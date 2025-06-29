using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EMobAttackTypeTupleWrapper : IMessage<EMobAttackTypeTupleWrapper>, IMessage, IEquatable<EMobAttackTypeTupleWrapper>, IDeepCloneable<EMobAttackTypeTupleWrapper>
{
	private static readonly MessageParser<EMobAttackTypeTupleWrapper> _parser = new MessageParser<EMobAttackTypeTupleWrapper>(() => new EMobAttackTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EMobAttackType item1_;

	private EMobAttackType item2_;

	public static MessageParser<EMobAttackTypeTupleWrapper> Parser => _parser;

	public EMobAttackType Item1
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

	public EMobAttackType Item2
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

	public EMobAttackTypeTupleWrapper()
	{
	}

	public EMobAttackTypeTupleWrapper(EMobAttackTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EMobAttackTypeTupleWrapper Clone()
	{
		return new EMobAttackTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EMobAttackTypeTupleWrapper);
	}

	public bool Equals(EMobAttackTypeTupleWrapper other)
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
		if (Item1 != EMobAttackType.MeleeAttack)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EMobAttackType.MeleeAttack)
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
		if (Item1 != EMobAttackType.MeleeAttack)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EMobAttackType.MeleeAttack)
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
		if (Item1 != EMobAttackType.MeleeAttack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EMobAttackType.MeleeAttack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EMobAttackTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EMobAttackType.MeleeAttack)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EMobAttackType.MeleeAttack)
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
				Item1 = (EMobAttackType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EMobAttackType)input.ReadEnum();
				break;
			}
		}
	}
}
