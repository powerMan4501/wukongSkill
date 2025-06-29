using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_Random : IMessage<BehaviorCustom_Random>, IMessage, IEquatable<BehaviorCustom_Random>, IDeepCloneable<BehaviorCustom_Random>
{
	private static readonly MessageParser<BehaviorCustom_Random> _parser = new MessageParser<BehaviorCustom_Random>(() => new BehaviorCustom_Random());

	private UnknownFieldSet _unknownFields;

	private bool isReverseCondition_;

	private float successRate_;

	public static MessageParser<BehaviorCustom_Random> Parser => _parser;

	public bool IsReverseCondition
	{
		get
		{
			return isReverseCondition_;
		}
		set
		{
			isReverseCondition_ = value;
		}
	}

	public float SuccessRate
	{
		get
		{
			return successRate_;
		}
		set
		{
			successRate_ = value;
		}
	}

	public BehaviorCustom_Random()
	{
	}

	public BehaviorCustom_Random(BehaviorCustom_Random other)
		: this()
	{
		isReverseCondition_ = other.isReverseCondition_;
		successRate_ = other.successRate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_Random Clone()
	{
		return new BehaviorCustom_Random(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_Random);
	}

	public bool Equals(BehaviorCustom_Random other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SuccessRate, other.SuccessRate))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (SuccessRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SuccessRate);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsReverseCondition)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsReverseCondition);
		}
		if (SuccessRate != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(SuccessRate);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (SuccessRate != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_Random other)
	{
		if (other != null)
		{
			if (other.IsReverseCondition)
			{
				IsReverseCondition = other.IsReverseCondition;
			}
			if (other.SuccessRate != 0f)
			{
				SuccessRate = other.SuccessRate;
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
				IsReverseCondition = input.ReadBool();
				break;
			case 21u:
				SuccessRate = input.ReadFloat();
				break;
			}
		}
	}
}
