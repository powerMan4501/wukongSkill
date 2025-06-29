using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_UnitStateTrigger : IMessage<BehaviorCustom_UnitStateTrigger>, IMessage, IEquatable<BehaviorCustom_UnitStateTrigger>, IDeepCloneable<BehaviorCustom_UnitStateTrigger>
{
	private static readonly MessageParser<BehaviorCustom_UnitStateTrigger> _parser = new MessageParser<BehaviorCustom_UnitStateTrigger>(() => new BehaviorCustom_UnitStateTrigger());

	private UnknownFieldSet _unknownFields;

	private int unitStateTrigger_;

	private float time_;

	public static MessageParser<BehaviorCustom_UnitStateTrigger> Parser => _parser;

	public int UnitStateTrigger
	{
		get
		{
			return unitStateTrigger_;
		}
		set
		{
			unitStateTrigger_ = value;
		}
	}

	public float Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	public BehaviorCustom_UnitStateTrigger()
	{
	}

	public BehaviorCustom_UnitStateTrigger(BehaviorCustom_UnitStateTrigger other)
		: this()
	{
		unitStateTrigger_ = other.unitStateTrigger_;
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_UnitStateTrigger Clone()
	{
		return new BehaviorCustom_UnitStateTrigger(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_UnitStateTrigger);
	}

	public bool Equals(BehaviorCustom_UnitStateTrigger other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitStateTrigger != other.UnitStateTrigger)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Time, other.Time))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitStateTrigger != 0)
		{
			num ^= UnitStateTrigger.GetHashCode();
		}
		if (Time != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Time);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitStateTrigger != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UnitStateTrigger);
		}
		if (Time != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Time);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitStateTrigger != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitStateTrigger);
		}
		if (Time != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_UnitStateTrigger other)
	{
		if (other != null)
		{
			if (other.UnitStateTrigger != 0)
			{
				UnitStateTrigger = other.UnitStateTrigger;
			}
			if (other.Time != 0f)
			{
				Time = other.Time;
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
				UnitStateTrigger = input.ReadInt32();
				break;
			case 21u:
				Time = input.ReadFloat();
				break;
			}
		}
	}
}
