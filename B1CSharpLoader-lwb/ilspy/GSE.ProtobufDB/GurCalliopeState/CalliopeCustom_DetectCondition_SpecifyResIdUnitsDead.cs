using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead : IMessage<CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead>, IMessage, IEquatable<CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead>, IDeepCloneable<CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead> _parser = new MessageParser<CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead>(() => new CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int resId_;

	public static MessageParser<CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead> Parser => _parser;

	public int ResId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return resId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			resId_ = value;
		}
	}

	public bool HasResId => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead()
	{
	}

	public CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead(CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		resId_ = other.resId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead Clone()
	{
		return new CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead(this);
	}

	public void ClearResId()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead);
	}

	public bool Equals(CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ResId != other.ResId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasResId)
		{
			num ^= ResId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasResId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ResId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasResId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead other)
	{
		if (other != null)
		{
			if (other.HasResId)
			{
				ResId = other.ResId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				ResId = input.ReadInt32();
			}
		}
	}
}
