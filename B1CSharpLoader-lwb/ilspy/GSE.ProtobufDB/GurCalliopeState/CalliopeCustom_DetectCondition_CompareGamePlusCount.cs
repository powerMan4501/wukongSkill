using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_CompareGamePlusCount : IMessage<CalliopeCustom_DetectCondition_CompareGamePlusCount>, IMessage, IEquatable<CalliopeCustom_DetectCondition_CompareGamePlusCount>, IDeepCloneable<CalliopeCustom_DetectCondition_CompareGamePlusCount>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_CompareGamePlusCount> _parser = new MessageParser<CalliopeCustom_DetectCondition_CompareGamePlusCount>(() => new CalliopeCustom_DetectCondition_CompareGamePlusCount());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int operationType_;

	private int gamePlusCount_;

	public static MessageParser<CalliopeCustom_DetectCondition_CompareGamePlusCount> Parser => _parser;

	public int OperationType
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return operationType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			operationType_ = value;
		}
	}

	public bool HasOperationType => (_hasBits0 & 1) != 0;

	public int GamePlusCount
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return gamePlusCount_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			gamePlusCount_ = value;
		}
	}

	public bool HasGamePlusCount => (_hasBits0 & 2) != 0;

	public CalliopeCustom_DetectCondition_CompareGamePlusCount()
	{
	}

	public CalliopeCustom_DetectCondition_CompareGamePlusCount(CalliopeCustom_DetectCondition_CompareGamePlusCount other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		operationType_ = other.operationType_;
		gamePlusCount_ = other.gamePlusCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_CompareGamePlusCount Clone()
	{
		return new CalliopeCustom_DetectCondition_CompareGamePlusCount(this);
	}

	public void ClearOperationType()
	{
		_hasBits0 &= -2;
	}

	public void ClearGamePlusCount()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_CompareGamePlusCount);
	}

	public bool Equals(CalliopeCustom_DetectCondition_CompareGamePlusCount other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OperationType != other.OperationType)
		{
			return false;
		}
		if (GamePlusCount != other.GamePlusCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasOperationType)
		{
			num ^= OperationType.GetHashCode();
		}
		if (HasGamePlusCount)
		{
			num ^= GamePlusCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasOperationType)
		{
			output.WriteRawTag(8);
			output.WriteInt32(OperationType);
		}
		if (HasGamePlusCount)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GamePlusCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasOperationType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OperationType);
		}
		if (HasGamePlusCount)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GamePlusCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_CompareGamePlusCount other)
	{
		if (other != null)
		{
			if (other.HasOperationType)
			{
				OperationType = other.OperationType;
			}
			if (other.HasGamePlusCount)
			{
				GamePlusCount = other.GamePlusCount;
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
				OperationType = input.ReadInt32();
				break;
			case 16u:
				GamePlusCount = input.ReadInt32();
				break;
			}
		}
	}
}
