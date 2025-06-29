using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class InputSettingData : IMessage<InputSettingData>, IMessage, IEquatable<InputSettingData>, IDeepCloneable<InputSettingData>
{
	private static readonly MessageParser<InputSettingData> _parser = new MessageParser<InputSettingData>(() => new InputSettingData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<InputSettingOne> _repeated_keyData_codec = FieldCodec.ForMessage(10u, InputSettingOne.Parser);

	private readonly RepeatedField<InputSettingOne> keyData_ = new RepeatedField<InputSettingOne>();

	private static readonly FieldCodec<GamepadPrefab> _repeated_gamepadKeyData_codec = FieldCodec.ForMessage(18u, GamepadPrefab.Parser);

	private readonly RepeatedField<GamepadPrefab> gamepadKeyData_ = new RepeatedField<GamepadPrefab>();

	public static MessageParser<InputSettingData> Parser => _parser;

	public RepeatedField<InputSettingOne> KeyData => keyData_;

	public RepeatedField<GamepadPrefab> GamepadKeyData => gamepadKeyData_;

	public InputSettingData()
	{
	}

	public InputSettingData(InputSettingData other)
		: this()
	{
		keyData_ = other.keyData_.Clone();
		gamepadKeyData_ = other.gamepadKeyData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public InputSettingData Clone()
	{
		return new InputSettingData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as InputSettingData);
	}

	public bool Equals(InputSettingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!keyData_.Equals(other.keyData_))
		{
			return false;
		}
		if (!gamepadKeyData_.Equals(other.gamepadKeyData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= keyData_.GetHashCode();
		num ^= gamepadKeyData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		keyData_.WriteTo(output, _repeated_keyData_codec);
		gamepadKeyData_.WriteTo(output, _repeated_gamepadKeyData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += keyData_.CalculateSize(_repeated_keyData_codec);
		num += gamepadKeyData_.CalculateSize(_repeated_gamepadKeyData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(InputSettingData other)
	{
		if (other != null)
		{
			keyData_.Add(other.keyData_);
			gamepadKeyData_.Add(other.gamepadKeyData_);
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
				keyData_.AddEntriesFrom(input, _repeated_keyData_codec);
				break;
			case 18u:
				gamepadKeyData_.AddEntriesFrom(input, _repeated_gamepadKeyData_codec);
				break;
			}
		}
	}
}
