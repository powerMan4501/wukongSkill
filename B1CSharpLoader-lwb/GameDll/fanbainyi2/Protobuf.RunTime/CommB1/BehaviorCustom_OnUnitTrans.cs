using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_OnUnitTrans : IMessage<BehaviorCustom_OnUnitTrans>, IMessage, IEquatable<BehaviorCustom_OnUnitTrans>, IDeepCloneable<BehaviorCustom_OnUnitTrans>
{
	private static readonly MessageParser<BehaviorCustom_OnUnitTrans> _parser = new MessageParser<BehaviorCustom_OnUnitTrans>(() => new BehaviorCustom_OnUnitTrans());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private string smartUnitGuid_ = "";

	private int transType_;

	public static MessageParser<BehaviorCustom_OnUnitTrans> Parser => _parser;

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

	public int TransType
	{
		get
		{
			return transType_;
		}
		set
		{
			transType_ = value;
		}
	}

	public BehaviorCustom_OnUnitTrans()
	{
	}

	public BehaviorCustom_OnUnitTrans(BehaviorCustom_OnUnitTrans other)
		: this()
	{
		unitType_ = other.unitType_;
		smartUnitGuid_ = other.smartUnitGuid_;
		transType_ = other.transType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_OnUnitTrans Clone()
	{
		return new BehaviorCustom_OnUnitTrans(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_OnUnitTrans);
	}

	public bool Equals(BehaviorCustom_OnUnitTrans other)
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
		if (TransType != other.TransType)
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
		if (TransType != 0)
		{
			num ^= TransType.GetHashCode();
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
		if (TransType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TransType);
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
		if (TransType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TransType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_OnUnitTrans other)
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
			if (other.TransType != 0)
			{
				TransType = other.TransType;
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
			case 24u:
				TransType = input.ReadInt32();
				break;
			}
		}
	}
}
