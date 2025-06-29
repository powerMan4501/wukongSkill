using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_OnValidAttackStateEnded : IMessage<BehaviorCustom_OnValidAttackStateEnded>, IMessage, IEquatable<BehaviorCustom_OnValidAttackStateEnded>, IDeepCloneable<BehaviorCustom_OnValidAttackStateEnded>
{
	private static readonly MessageParser<BehaviorCustom_OnValidAttackStateEnded> _parser = new MessageParser<BehaviorCustom_OnValidAttackStateEnded>(() => new BehaviorCustom_OnValidAttackStateEnded());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private string smartUnitGuid_ = "";

	public static MessageParser<BehaviorCustom_OnValidAttackStateEnded> Parser => _parser;

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

	public string SmartUnitGuid
	{
		get
		{
			return smartUnitGuid_;
		}
		set
		{
			smartUnitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_OnValidAttackStateEnded()
	{
	}

	public BehaviorCustom_OnValidAttackStateEnded(BehaviorCustom_OnValidAttackStateEnded other)
		: this()
	{
		unitType_ = other.unitType_;
		smartUnitGuid_ = other.smartUnitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_OnValidAttackStateEnded Clone()
	{
		return new BehaviorCustom_OnValidAttackStateEnded(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_OnValidAttackStateEnded);
	}

	public bool Equals(BehaviorCustom_OnValidAttackStateEnded other)
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
		if (SmartUnitGuid != other.SmartUnitGuid)
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
		if (SmartUnitGuid.Length != 0)
		{
			num ^= SmartUnitGuid.GetHashCode();
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
		if (SmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SmartUnitGuid);
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
		if (SmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SmartUnitGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_OnValidAttackStateEnded other)
	{
		if (other != null)
		{
			if (other.UnitType != 0)
			{
				UnitType = other.UnitType;
			}
			if (other.SmartUnitGuid.Length != 0)
			{
				SmartUnitGuid = other.SmartUnitGuid;
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
			case 18u:
				SmartUnitGuid = input.ReadString();
				break;
			}
		}
	}
}
