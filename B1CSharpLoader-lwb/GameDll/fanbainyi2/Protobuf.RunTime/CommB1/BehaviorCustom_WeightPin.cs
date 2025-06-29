using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_WeightPin : IMessage<BehaviorCustom_WeightPin>, IMessage, IEquatable<BehaviorCustom_WeightPin>, IDeepCloneable<BehaviorCustom_WeightPin>
{
	private static readonly MessageParser<BehaviorCustom_WeightPin> _parser = new MessageParser<BehaviorCustom_WeightPin>(() => new BehaviorCustom_WeightPin());

	private UnknownFieldSet _unknownFields;

	private int weight_;

	private string pinName_ = "";

	public static MessageParser<BehaviorCustom_WeightPin> Parser => _parser;

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

	public string PinName
	{
		get
		{
			return pinName_;
		}
		set
		{
			pinName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_WeightPin()
	{
	}

	public BehaviorCustom_WeightPin(BehaviorCustom_WeightPin other)
		: this()
	{
		weight_ = other.weight_;
		pinName_ = other.pinName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_WeightPin Clone()
	{
		return new BehaviorCustom_WeightPin(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_WeightPin);
	}

	public bool Equals(BehaviorCustom_WeightPin other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Weight != other.Weight)
		{
			return false;
		}
		if (PinName != other.PinName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Weight != 0)
		{
			num ^= Weight.GetHashCode();
		}
		if (PinName.Length != 0)
		{
			num ^= PinName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Weight != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Weight);
		}
		if (PinName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(PinName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Weight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Weight);
		}
		if (PinName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PinName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_WeightPin other)
	{
		if (other != null)
		{
			if (other.Weight != 0)
			{
				Weight = other.Weight;
			}
			if (other.PinName.Length != 0)
			{
				PinName = other.PinName;
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
				Weight = input.ReadInt32();
				break;
			case 18u:
				PinName = input.ReadString();
				break;
			}
		}
	}
}
