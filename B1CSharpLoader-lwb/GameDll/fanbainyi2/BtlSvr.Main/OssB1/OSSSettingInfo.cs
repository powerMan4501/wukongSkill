using System;
using Google.Protobuf;

namespace OssB1;

public sealed class OSSSettingInfo : IMessage<OSSSettingInfo>, IMessage, IEquatable<OSSSettingInfo>, IDeepCloneable<OSSSettingInfo>
{
	private static readonly MessageParser<OSSSettingInfo> _parser = new MessageParser<OSSSettingInfo>(() => new OSSSettingInfo());

	private UnknownFieldSet _unknownFields;

	private string settingId_ = "";

	private ESettingChangeType type_;

	private string oldSettingValue_ = "";

	private string newSettingValue_ = "";

	public static MessageParser<OSSSettingInfo> Parser => _parser;

	public string SettingId
	{
		get
		{
			return settingId_;
		}
		set
		{
			settingId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ESettingChangeType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public string OldSettingValue
	{
		get
		{
			return oldSettingValue_;
		}
		set
		{
			oldSettingValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NewSettingValue
	{
		get
		{
			return newSettingValue_;
		}
		set
		{
			newSettingValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public OSSSettingInfo()
	{
	}

	public OSSSettingInfo(OSSSettingInfo other)
		: this()
	{
		settingId_ = other.settingId_;
		type_ = other.type_;
		oldSettingValue_ = other.oldSettingValue_;
		newSettingValue_ = other.newSettingValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OSSSettingInfo Clone()
	{
		return new OSSSettingInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OSSSettingInfo);
	}

	public bool Equals(OSSSettingInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SettingId != other.SettingId)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (OldSettingValue != other.OldSettingValue)
		{
			return false;
		}
		if (NewSettingValue != other.NewSettingValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SettingId.Length != 0)
		{
			num ^= SettingId.GetHashCode();
		}
		if (Type != ESettingChangeType.Normal)
		{
			num ^= Type.GetHashCode();
		}
		if (OldSettingValue.Length != 0)
		{
			num ^= OldSettingValue.GetHashCode();
		}
		if (NewSettingValue.Length != 0)
		{
			num ^= NewSettingValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SettingId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(SettingId);
		}
		if (Type != ESettingChangeType.Normal)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (OldSettingValue.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(OldSettingValue);
		}
		if (NewSettingValue.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(NewSettingValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SettingId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SettingId);
		}
		if (Type != ESettingChangeType.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (OldSettingValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OldSettingValue);
		}
		if (NewSettingValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NewSettingValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OSSSettingInfo other)
	{
		if (other != null)
		{
			if (other.SettingId.Length != 0)
			{
				SettingId = other.SettingId;
			}
			if (other.Type != ESettingChangeType.Normal)
			{
				Type = other.Type;
			}
			if (other.OldSettingValue.Length != 0)
			{
				OldSettingValue = other.OldSettingValue;
			}
			if (other.NewSettingValue.Length != 0)
			{
				NewSettingValue = other.NewSettingValue;
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
				SettingId = input.ReadString();
				break;
			case 16u:
				Type = (ESettingChangeType)input.ReadEnum();
				break;
			case 26u:
				OldSettingValue = input.ReadString();
				break;
			case 34u:
				NewSettingValue = input.ReadString();
				break;
			}
		}
	}
}
