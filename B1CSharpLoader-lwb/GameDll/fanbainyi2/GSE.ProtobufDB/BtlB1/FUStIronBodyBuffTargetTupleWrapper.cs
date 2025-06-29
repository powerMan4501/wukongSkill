using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStIronBodyBuffTargetTupleWrapper : IMessage<FUStIronBodyBuffTargetTupleWrapper>, IMessage, IEquatable<FUStIronBodyBuffTargetTupleWrapper>, IDeepCloneable<FUStIronBodyBuffTargetTupleWrapper>
{
	private static readonly MessageParser<FUStIronBodyBuffTargetTupleWrapper> _parser = new MessageParser<FUStIronBodyBuffTargetTupleWrapper>(() => new FUStIronBodyBuffTargetTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private FUStIronBodyBuffTarget item1_;

	private FUStIronBodyBuffTarget item2_;

	public static MessageParser<FUStIronBodyBuffTargetTupleWrapper> Parser => _parser;

	public FUStIronBodyBuffTarget Item1
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

	public FUStIronBodyBuffTarget Item2
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

	public FUStIronBodyBuffTargetTupleWrapper()
	{
	}

	public FUStIronBodyBuffTargetTupleWrapper(FUStIronBodyBuffTargetTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStIronBodyBuffTargetTupleWrapper Clone()
	{
		return new FUStIronBodyBuffTargetTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStIronBodyBuffTargetTupleWrapper);
	}

	public bool Equals(FUStIronBodyBuffTargetTupleWrapper other)
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
		if (Item1 != FUStIronBodyBuffTarget.Attacker)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != FUStIronBodyBuffTarget.Attacker)
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
		if (Item1 != FUStIronBodyBuffTarget.Attacker)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != FUStIronBodyBuffTarget.Attacker)
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
		if (Item1 != FUStIronBodyBuffTarget.Attacker)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != FUStIronBodyBuffTarget.Attacker)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStIronBodyBuffTargetTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != FUStIronBodyBuffTarget.Attacker)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != FUStIronBodyBuffTarget.Attacker)
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
				Item1 = (FUStIronBodyBuffTarget)input.ReadEnum();
				break;
			case 16u:
				Item2 = (FUStIronBodyBuffTarget)input.ReadEnum();
				break;
			}
		}
	}
}
