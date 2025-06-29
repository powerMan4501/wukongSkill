using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_HasBuff : IMessage<CalliopeCustom_DetectCondition_HasBuff>, IMessage, IEquatable<CalliopeCustom_DetectCondition_HasBuff>, IDeepCloneable<CalliopeCustom_DetectCondition_HasBuff>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_HasBuff> _parser = new MessageParser<CalliopeCustom_DetectCondition_HasBuff>(() => new CalliopeCustom_DetectCondition_HasBuff());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int buffId_;

	public static MessageParser<CalliopeCustom_DetectCondition_HasBuff> Parser => _parser;

	public int BuffId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return buffId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			buffId_ = value;
		}
	}

	public bool HasBuffId => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_HasBuff()
	{
	}

	public CalliopeCustom_DetectCondition_HasBuff(CalliopeCustom_DetectCondition_HasBuff other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_HasBuff Clone()
	{
		return new CalliopeCustom_DetectCondition_HasBuff(this);
	}

	public void ClearBuffId()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_HasBuff);
	}

	public bool Equals(CalliopeCustom_DetectCondition_HasBuff other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasBuffId)
		{
			num ^= BuffId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasBuffId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasBuffId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_HasBuff other)
	{
		if (other != null)
		{
			if (other.HasBuffId)
			{
				BuffId = other.BuffId;
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
				BuffId = input.ReadInt32();
			}
		}
	}
}
