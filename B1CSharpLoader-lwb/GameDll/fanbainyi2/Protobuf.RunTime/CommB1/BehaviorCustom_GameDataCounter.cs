using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_GameDataCounter : IMessage<BehaviorCustom_GameDataCounter>, IMessage, IEquatable<BehaviorCustom_GameDataCounter>, IDeepCloneable<BehaviorCustom_GameDataCounter>
{
	private static readonly MessageParser<BehaviorCustom_GameDataCounter> _parser = new MessageParser<BehaviorCustom_GameDataCounter>(() => new BehaviorCustom_GameDataCounter());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private int counterType_;

	private float counterValue_;

	public static MessageParser<BehaviorCustom_GameDataCounter> Parser => _parser;

	public int UnitType
	{
		get
		{
			return unitType_;
		}
		set
		{
			unitType_ = value;
		}
	}

	public int CounterType
	{
		get
		{
			return counterType_;
		}
		set
		{
			counterType_ = value;
		}
	}

	public float CounterValue
	{
		get
		{
			return counterValue_;
		}
		set
		{
			counterValue_ = value;
		}
	}

	public BehaviorCustom_GameDataCounter()
	{
	}

	public BehaviorCustom_GameDataCounter(BehaviorCustom_GameDataCounter other)
		: this()
	{
		unitType_ = other.unitType_;
		counterType_ = other.counterType_;
		counterValue_ = other.counterValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_GameDataCounter Clone()
	{
		return new BehaviorCustom_GameDataCounter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_GameDataCounter);
	}

	public bool Equals(BehaviorCustom_GameDataCounter other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitType != other.UnitType)
		{
			return false;
		}
		if (CounterType != other.CounterType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CounterValue, other.CounterValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitType != 0)
		{
			num ^= UnitType.GetHashCode();
		}
		if (CounterType != 0)
		{
			num ^= CounterType.GetHashCode();
		}
		if (CounterValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CounterValue);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UnitType);
		}
		if (CounterType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CounterType);
		}
		if (CounterValue != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(CounterValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitType);
		}
		if (CounterType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CounterType);
		}
		if (CounterValue != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_GameDataCounter other)
	{
		if (other != null)
		{
			if (other.UnitType != 0)
			{
				UnitType = other.UnitType;
			}
			if (other.CounterType != 0)
			{
				CounterType = other.CounterType;
			}
			if (other.CounterValue != 0f)
			{
				CounterValue = other.CounterValue;
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
				UnitType = input.ReadInt32();
				break;
			case 16u:
				CounterType = input.ReadInt32();
				break;
			case 29u:
				CounterValue = input.ReadFloat();
				break;
			}
		}
	}
}
