using System;
using Google.Protobuf;

namespace ResB1;

public sealed class SettingLockInfoEx : IMessage<SettingLockInfoEx>, IMessage, IEquatable<SettingLockInfoEx>, IDeepCloneable<SettingLockInfoEx>
{
	private static readonly MessageParser<SettingLockInfoEx> _parser = new MessageParser<SettingLockInfoEx>(() => new SettingLockInfoEx());

	private UnknownFieldSet _unknownFields;

	private SettingBanConditionType conditionType_;

	private string lockDesc_ = "";

	public static MessageParser<SettingLockInfoEx> Parser => _parser;

	public SettingBanConditionType ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	public string LockDesc
	{
		get
		{
			return lockDesc_;
		}
		set
		{
			lockDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public SettingLockInfoEx()
	{
	}

	public SettingLockInfoEx(SettingLockInfoEx other)
		: this()
	{
		conditionType_ = other.conditionType_;
		lockDesc_ = other.lockDesc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SettingLockInfoEx Clone()
	{
		return new SettingLockInfoEx(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SettingLockInfoEx);
	}

	public bool Equals(SettingLockInfoEx other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (LockDesc != other.LockDesc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionType != SettingBanConditionType.Dontban)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (LockDesc.Length != 0)
		{
			num ^= LockDesc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionType != SettingBanConditionType.Dontban)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ConditionType);
		}
		if (LockDesc.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(LockDesc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionType != SettingBanConditionType.Dontban)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionType);
		}
		if (LockDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LockDesc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SettingLockInfoEx other)
	{
		if (other != null)
		{
			if (other.ConditionType != SettingBanConditionType.Dontban)
			{
				ConditionType = other.ConditionType;
			}
			if (other.LockDesc.Length != 0)
			{
				LockDesc = other.LockDesc;
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
				ConditionType = (SettingBanConditionType)input.ReadEnum();
				break;
			case 18u:
				LockDesc = input.ReadString();
				break;
			}
		}
	}
}
