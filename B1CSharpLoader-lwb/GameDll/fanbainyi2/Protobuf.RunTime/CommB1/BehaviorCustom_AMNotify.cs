using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_AMNotify : IMessage<BehaviorCustom_AMNotify>, IMessage, IEquatable<BehaviorCustom_AMNotify>, IDeepCloneable<BehaviorCustom_AMNotify>
{
	private static readonly MessageParser<BehaviorCustom_AMNotify> _parser = new MessageParser<BehaviorCustom_AMNotify>(() => new BehaviorCustom_AMNotify());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private string smartUnitGuid_ = "";

	private string notifyTag_ = "";

	public static MessageParser<BehaviorCustom_AMNotify> Parser => _parser;

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

	public string NotifyTag
	{
		get
		{
			return notifyTag_;
		}
		set
		{
			notifyTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_AMNotify()
	{
	}

	public BehaviorCustom_AMNotify(BehaviorCustom_AMNotify other)
		: this()
	{
		unitType_ = other.unitType_;
		smartUnitGuid_ = other.smartUnitGuid_;
		notifyTag_ = other.notifyTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_AMNotify Clone()
	{
		return new BehaviorCustom_AMNotify(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_AMNotify);
	}

	public bool Equals(BehaviorCustom_AMNotify other)
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
		if (NotifyTag != other.NotifyTag)
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
		if (NotifyTag.Length != 0)
		{
			num ^= NotifyTag.GetHashCode();
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
		if (NotifyTag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(NotifyTag);
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
		if (NotifyTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NotifyTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_AMNotify other)
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
			if (other.NotifyTag.Length != 0)
			{
				NotifyTag = other.NotifyTag;
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
			case 26u:
				NotifyTag = input.ReadString();
				break;
			}
		}
	}
}
