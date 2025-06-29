using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class EnhancedInputSettingData : IMessage<EnhancedInputSettingData>, IMessage, IEquatable<EnhancedInputSettingData>, IDeepCloneable<EnhancedInputSettingData>
{
	private static readonly MessageParser<EnhancedInputSettingData> _parser = new MessageParser<EnhancedInputSettingData>(() => new EnhancedInputSettingData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<MappableKey> _repeated_keyboardMappableKeys_codec = FieldCodec.ForMessage(10u, MappableKey.Parser);

	private readonly RepeatedField<MappableKey> keyboardMappableKeys_ = new RepeatedField<MappableKey>();

	private ECustomizedInputType customizedInputType_;

	private static readonly FieldCodec<GamepadMappableKey> _repeated_gamepadMappableKey_codec = FieldCodec.ForMessage(26u, CommB1.GamepadMappableKey.Parser);

	private readonly RepeatedField<GamepadMappableKey> gamepadMappableKey_ = new RepeatedField<GamepadMappableKey>();

	public static MessageParser<EnhancedInputSettingData> Parser => _parser;

	public RepeatedField<MappableKey> KeyboardMappableKeys => keyboardMappableKeys_;

	public ECustomizedInputType CustomizedInputType
	{
		get
		{
			return customizedInputType_;
		}
		set
		{
			customizedInputType_ = value;
		}
	}

	public RepeatedField<GamepadMappableKey> GamepadMappableKey => gamepadMappableKey_;

	public EnhancedInputSettingData()
	{
	}

	public EnhancedInputSettingData(EnhancedInputSettingData other)
		: this()
	{
		keyboardMappableKeys_ = other.keyboardMappableKeys_.Clone();
		customizedInputType_ = other.customizedInputType_;
		gamepadMappableKey_ = other.gamepadMappableKey_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EnhancedInputSettingData Clone()
	{
		return new EnhancedInputSettingData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EnhancedInputSettingData);
	}

	public bool Equals(EnhancedInputSettingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!keyboardMappableKeys_.Equals(other.keyboardMappableKeys_))
		{
			return false;
		}
		if (CustomizedInputType != other.CustomizedInputType)
		{
			return false;
		}
		if (!gamepadMappableKey_.Equals(other.gamepadMappableKey_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= keyboardMappableKeys_.GetHashCode();
		if (CustomizedInputType != ECustomizedInputType.None)
		{
			num ^= CustomizedInputType.GetHashCode();
		}
		num ^= gamepadMappableKey_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		keyboardMappableKeys_.WriteTo(output, _repeated_keyboardMappableKeys_codec);
		if (CustomizedInputType != ECustomizedInputType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)CustomizedInputType);
		}
		gamepadMappableKey_.WriteTo(output, _repeated_gamepadMappableKey_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += keyboardMappableKeys_.CalculateSize(_repeated_keyboardMappableKeys_codec);
		if (CustomizedInputType != ECustomizedInputType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CustomizedInputType);
		}
		num += gamepadMappableKey_.CalculateSize(_repeated_gamepadMappableKey_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EnhancedInputSettingData other)
	{
		if (other != null)
		{
			keyboardMappableKeys_.Add(other.keyboardMappableKeys_);
			if (other.CustomizedInputType != ECustomizedInputType.None)
			{
				CustomizedInputType = other.CustomizedInputType;
			}
			gamepadMappableKey_.Add(other.gamepadMappableKey_);
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
				keyboardMappableKeys_.AddEntriesFrom(input, _repeated_keyboardMappableKeys_codec);
				break;
			case 16u:
				CustomizedInputType = (ECustomizedInputType)input.ReadEnum();
				break;
			case 26u:
				gamepadMappableKey_.AddEntriesFrom(input, _repeated_gamepadMappableKey_codec);
				break;
			}
		}
	}
}
