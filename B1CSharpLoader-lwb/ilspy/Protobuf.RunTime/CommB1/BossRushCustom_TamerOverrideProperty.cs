using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BossRushCustom_TamerOverrideProperty : IMessage<BossRushCustom_TamerOverrideProperty>, IMessage, IEquatable<BossRushCustom_TamerOverrideProperty>, IDeepCloneable<BossRushCustom_TamerOverrideProperty>
{
	private static readonly MessageParser<BossRushCustom_TamerOverrideProperty> _parser = new MessageParser<BossRushCustom_TamerOverrideProperty>(() => new BossRushCustom_TamerOverrideProperty());

	private UnknownFieldSet _unknownFields;

	private string unitConfigGuid_ = "";

	private int extendId_;

	public static MessageParser<BossRushCustom_TamerOverrideProperty> Parser => _parser;

	public string UnitConfigGuid
	{
		get
		{
			return unitConfigGuid_;
		}
		set
		{
			unitConfigGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public BossRushCustom_TamerOverrideProperty()
	{
	}

	public BossRushCustom_TamerOverrideProperty(BossRushCustom_TamerOverrideProperty other)
		: this()
	{
		unitConfigGuid_ = other.unitConfigGuid_;
		extendId_ = other.extendId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCustom_TamerOverrideProperty Clone()
	{
		return new BossRushCustom_TamerOverrideProperty(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCustom_TamerOverrideProperty);
	}

	public bool Equals(BossRushCustom_TamerOverrideProperty other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitConfigGuid != other.UnitConfigGuid)
		{
			return false;
		}
		if (ExtendId != other.ExtendId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitConfigGuid.Length != 0)
		{
			num ^= UnitConfigGuid.GetHashCode();
		}
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitConfigGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(UnitConfigGuid);
		}
		if (ExtendId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ExtendId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitConfigGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitConfigGuid);
		}
		if (ExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCustom_TamerOverrideProperty other)
	{
		if (other != null)
		{
			if (other.UnitConfigGuid.Length != 0)
			{
				UnitConfigGuid = other.UnitConfigGuid;
			}
			if (other.ExtendId != 0)
			{
				ExtendId = other.ExtendId;
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
			case 10u:
				UnitConfigGuid = input.ReadString();
				break;
			case 16u:
				ExtendId = input.ReadInt32();
				break;
			}
		}
	}
}
