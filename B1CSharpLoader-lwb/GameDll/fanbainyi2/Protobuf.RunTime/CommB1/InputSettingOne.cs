using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class InputSettingOne : IMessage<InputSettingOne>, IMessage, IEquatable<InputSettingOne>, IDeepCloneable<InputSettingOne>
{
	private static readonly MessageParser<InputSettingOne> _parser = new MessageParser<InputSettingOne>(() => new InputSettingOne());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private string keyMapping_;

	private YesNoType isAxis_;

	private int scale_;

	private string key_;

	public static MessageParser<InputSettingOne> Parser => _parser;

	public string KeyMapping
	{
		get
		{
			return keyMapping_ ?? "";
		}
		set
		{
			keyMapping_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasKeyMapping => keyMapping_ != null;

	public YesNoType IsAxis
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return isAxis_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 1;
			isAxis_ = value;
		}
	}

	public bool HasIsAxis => (_hasBits0 & 1) != 0;

	public int Scale
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return scale_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			scale_ = value;
		}
	}

	public bool HasScale => (_hasBits0 & 2) != 0;

	public string Key
	{
		get
		{
			return key_ ?? "";
		}
		set
		{
			key_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasKey => key_ != null;

	public InputSettingOne()
	{
	}

	public InputSettingOne(InputSettingOne other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		keyMapping_ = other.keyMapping_;
		isAxis_ = other.isAxis_;
		scale_ = other.scale_;
		key_ = other.key_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public InputSettingOne Clone()
	{
		return new InputSettingOne(this);
	}

	public void ClearKeyMapping()
	{
		keyMapping_ = null;
	}

	public void ClearIsAxis()
	{
		_hasBits0 &= -2;
	}

	public void ClearScale()
	{
		_hasBits0 &= -3;
	}

	public void ClearKey()
	{
		key_ = null;
	}

	public override bool Equals(object other)
	{
		return Equals(other as InputSettingOne);
	}

	public bool Equals(InputSettingOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KeyMapping != other.KeyMapping)
		{
			return false;
		}
		if (IsAxis != other.IsAxis)
		{
			return false;
		}
		if (Scale != other.Scale)
		{
			return false;
		}
		if (Key != other.Key)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasKeyMapping)
		{
			num ^= KeyMapping.GetHashCode();
		}
		if (HasIsAxis)
		{
			num ^= IsAxis.GetHashCode();
		}
		if (HasScale)
		{
			num ^= Scale.GetHashCode();
		}
		if (HasKey)
		{
			num ^= Key.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasKeyMapping)
		{
			output.WriteRawTag(10);
			output.WriteString(KeyMapping);
		}
		if (HasIsAxis)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsAxis);
		}
		if (HasScale)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Scale);
		}
		if (HasKey)
		{
			output.WriteRawTag(34);
			output.WriteString(Key);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasKeyMapping)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(KeyMapping);
		}
		if (HasIsAxis)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsAxis);
		}
		if (HasScale)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Scale);
		}
		if (HasKey)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Key);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(InputSettingOne other)
	{
		if (other != null)
		{
			if (other.HasKeyMapping)
			{
				KeyMapping = other.KeyMapping;
			}
			if (other.HasIsAxis)
			{
				IsAxis = other.IsAxis;
			}
			if (other.HasScale)
			{
				Scale = other.Scale;
			}
			if (other.HasKey)
			{
				Key = other.Key;
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
				KeyMapping = input.ReadString();
				break;
			case 16u:
				IsAxis = (YesNoType)input.ReadEnum();
				break;
			case 24u:
				Scale = input.ReadInt32();
				break;
			case 34u:
				Key = input.ReadString();
				break;
			}
		}
	}
}
