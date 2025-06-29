using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStMontagePathWithWeight : IMessage<FUStMontagePathWithWeight>, IMessage, IEquatable<FUStMontagePathWithWeight>, IDeepCloneable<FUStMontagePathWithWeight>
{
	private static readonly MessageParser<FUStMontagePathWithWeight> _parser = new MessageParser<FUStMontagePathWithWeight>(() => new FUStMontagePathWithWeight());

	private UnknownFieldSet _unknownFields;

	private string rollMontagePath_ = "";

	private int weight_;

	public static MessageParser<FUStMontagePathWithWeight> Parser => _parser;

	public string RollMontagePath
	{
		get
		{
			return rollMontagePath_;
		}
		set
		{
			rollMontagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public FUStMontagePathWithWeight()
	{
	}

	public FUStMontagePathWithWeight(FUStMontagePathWithWeight other)
		: this()
	{
		rollMontagePath_ = other.rollMontagePath_;
		weight_ = other.weight_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMontagePathWithWeight Clone()
	{
		return new FUStMontagePathWithWeight(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMontagePathWithWeight);
	}

	public bool Equals(FUStMontagePathWithWeight other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RollMontagePath != other.RollMontagePath)
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
		if (RollMontagePath.Length != 0)
		{
			num ^= RollMontagePath.GetHashCode();
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
		if (RollMontagePath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(RollMontagePath);
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
		if (RollMontagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RollMontagePath);
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

	public void MergeFrom(FUStMontagePathWithWeight other)
	{
		if (other != null)
		{
			if (other.RollMontagePath.Length != 0)
			{
				RollMontagePath = other.RollMontagePath;
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
			case 10u:
				RollMontagePath = input.ReadString();
				break;
			case 16u:
				Weight = input.ReadInt32();
				break;
			}
		}
	}
}
