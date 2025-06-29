using System;
using Google.Protobuf;

namespace ResB1;

public sealed class RandomWeight : IMessage<RandomWeight>, IMessage, IEquatable<RandomWeight>, IDeepCloneable<RandomWeight>
{
	private static readonly MessageParser<RandomWeight> _parser = new MessageParser<RandomWeight>(() => new RandomWeight());

	private UnknownFieldSet _unknownFields;

	private int num_;

	private int weight_;

	public static MessageParser<RandomWeight> Parser => _parser;

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

	public int Weight
	{
		get
		{
			return weight_;
		}
		set
		{
			weight_ = value;
		}
	}

	public RandomWeight()
	{
	}

	public RandomWeight(RandomWeight other)
		: this()
	{
		num_ = other.num_;
		weight_ = other.weight_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RandomWeight Clone()
	{
		return new RandomWeight(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RandomWeight);
	}

	public bool Equals(RandomWeight other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (Weight != other.Weight)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (Weight != 0)
		{
			num ^= Weight.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Num != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Num);
		}
		if (Weight != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Weight);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Num);
		}
		if (Weight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Weight);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RandomWeight other)
	{
		if (other != null)
		{
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.Weight != 0)
			{
				Weight = other.Weight;
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
				Num = input.ReadInt32();
				break;
			case 16u:
				Weight = input.ReadInt32();
				break;
			}
		}
	}
}
