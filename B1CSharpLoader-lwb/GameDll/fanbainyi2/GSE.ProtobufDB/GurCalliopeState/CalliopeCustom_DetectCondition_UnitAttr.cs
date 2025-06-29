using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_UnitAttr : IMessage<CalliopeCustom_DetectCondition_UnitAttr>, IMessage, IEquatable<CalliopeCustom_DetectCondition_UnitAttr>, IDeepCloneable<CalliopeCustom_DetectCondition_UnitAttr>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_UnitAttr> _parser = new MessageParser<CalliopeCustom_DetectCondition_UnitAttr>(() => new CalliopeCustom_DetectCondition_UnitAttr());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int attrFloatType_;

	private int compareOperation_;

	private float compareValue_;

	public static MessageParser<CalliopeCustom_DetectCondition_UnitAttr> Parser => _parser;

	public int AttrFloatType
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return attrFloatType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			attrFloatType_ = value;
		}
	}

	public bool HasAttrFloatType => (_hasBits0 & 1) != 0;

	public int CompareOperation
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return compareOperation_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			compareOperation_ = value;
		}
	}

	public bool HasCompareOperation => (_hasBits0 & 2) != 0;

	public float CompareValue
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return compareValue_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 4;
			compareValue_ = value;
		}
	}

	public bool HasCompareValue => (_hasBits0 & 4) != 0;

	public CalliopeCustom_DetectCondition_UnitAttr()
	{
	}

	public CalliopeCustom_DetectCondition_UnitAttr(CalliopeCustom_DetectCondition_UnitAttr other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		attrFloatType_ = other.attrFloatType_;
		compareOperation_ = other.compareOperation_;
		compareValue_ = other.compareValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_UnitAttr Clone()
	{
		return new CalliopeCustom_DetectCondition_UnitAttr(this);
	}

	public void ClearAttrFloatType()
	{
		_hasBits0 &= -2;
	}

	public void ClearCompareOperation()
	{
		_hasBits0 &= -3;
	}

	public void ClearCompareValue()
	{
		_hasBits0 &= -5;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_UnitAttr);
	}

	public bool Equals(CalliopeCustom_DetectCondition_UnitAttr other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AttrFloatType != other.AttrFloatType)
		{
			return false;
		}
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CompareValue, other.CompareValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasAttrFloatType)
		{
			num ^= AttrFloatType.GetHashCode();
		}
		if (HasCompareOperation)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (HasCompareValue)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CompareValue);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasAttrFloatType)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AttrFloatType);
		}
		if (HasCompareOperation)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CompareOperation);
		}
		if (HasCompareValue)
		{
			output.WriteRawTag(29);
			output.WriteFloat(CompareValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasAttrFloatType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrFloatType);
		}
		if (HasCompareOperation)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (HasCompareValue)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_UnitAttr other)
	{
		if (other != null)
		{
			if (other.HasAttrFloatType)
			{
				AttrFloatType = other.AttrFloatType;
			}
			if (other.HasCompareOperation)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.HasCompareValue)
			{
				CompareValue = other.CompareValue;
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
				AttrFloatType = input.ReadInt32();
				break;
			case 16u:
				CompareOperation = input.ReadInt32();
				break;
			case 29u:
				CompareValue = input.ReadFloat();
				break;
			}
		}
	}
}
