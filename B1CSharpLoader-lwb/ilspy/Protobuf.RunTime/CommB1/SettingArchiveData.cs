using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class SettingArchiveData : IMessage<SettingArchiveData>, IMessage, IEquatable<SettingArchiveData>, IDeepCloneable<SettingArchiveData>
{
	private static readonly MessageParser<SettingArchiveData> _parser = new MessageParser<SettingArchiveData>(() => new SettingArchiveData());

	private UnknownFieldSet _unknownFields;

	private UISettingConfigType settingKey_;

	private string settingValue_ = "";

	public static MessageParser<SettingArchiveData> Parser => _parser;

	public UISettingConfigType SettingKey
	{
		get
		{
			return settingKey_;
		}
		set
		{
			settingKey_ = value;
		}
	}

	public string SettingValue
	{
		get
		{
			return settingValue_;
		}
		set
		{
			settingValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public SettingArchiveData()
	{
	}

	public SettingArchiveData(SettingArchiveData other)
		: this()
	{
		settingKey_ = other.settingKey_;
		settingValue_ = other.settingValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SettingArchiveData Clone()
	{
		return new SettingArchiveData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SettingArchiveData);
	}

	public bool Equals(SettingArchiveData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SettingKey != other.SettingKey)
		{
			return false;
		}
		if (SettingValue != other.SettingValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SettingKey != UISettingConfigType.Min)
		{
			num ^= SettingKey.GetHashCode();
		}
		if (SettingValue.Length != 0)
		{
			num ^= SettingValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SettingKey != UISettingConfigType.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)SettingKey);
		}
		if (SettingValue.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SettingValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SettingKey != UISettingConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SettingKey);
		}
		if (SettingValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SettingValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SettingArchiveData other)
	{
		if (other != null)
		{
			if (other.SettingKey != UISettingConfigType.Min)
			{
				SettingKey = other.SettingKey;
			}
			if (other.SettingValue.Length != 0)
			{
				SettingValue = other.SettingValue;
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
				SettingKey = (UISettingConfigType)input.ReadEnum();
				break;
			case 18u:
				SettingValue = input.ReadString();
				break;
			}
		}
	}
}
