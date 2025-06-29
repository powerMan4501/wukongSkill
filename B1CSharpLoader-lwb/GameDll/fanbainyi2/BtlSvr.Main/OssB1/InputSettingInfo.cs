using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class InputSettingInfo : IMessage<InputSettingInfo>, IMessage, IEquatable<InputSettingInfo>, IDeepCloneable<InputSettingInfo>
{
	private static readonly MessageParser<InputSettingInfo> _parser = new MessageParser<InputSettingInfo>(() => new InputSettingInfo());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private static readonly FieldCodec<MappableKey> _repeated_keyboardMappableKeys_codec = FieldCodec.ForMessage(18u, MappableKey.Parser);

	private readonly RepeatedField<MappableKey> keyboardMappableKeys_ = new RepeatedField<MappableKey>();

	private string gamepadInputType_ = "";

	private static readonly FieldCodec<GamepadDetailSettingInfo> _repeated_gamepadDetailSettingInfo_codec = FieldCodec.ForMessage(34u, OssB1.GamepadDetailSettingInfo.Parser);

	private readonly RepeatedField<GamepadDetailSettingInfo> gamepadDetailSettingInfo_ = new RepeatedField<GamepadDetailSettingInfo>();

	public static MessageParser<InputSettingInfo> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public RepeatedField<MappableKey> KeyboardMappableKeys => keyboardMappableKeys_;

	public string GamepadInputType
	{
		get
		{
			return gamepadInputType_;
		}
		set
		{
			gamepadInputType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<GamepadDetailSettingInfo> GamepadDetailSettingInfo => gamepadDetailSettingInfo_;

	public InputSettingInfo()
	{
	}

	public InputSettingInfo(InputSettingInfo other)
		: this()
	{
		roleId_ = other.roleId_;
		keyboardMappableKeys_ = other.keyboardMappableKeys_.Clone();
		gamepadInputType_ = other.gamepadInputType_;
		gamepadDetailSettingInfo_ = other.gamepadDetailSettingInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public InputSettingInfo Clone()
	{
		return new InputSettingInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as InputSettingInfo);
	}

	public bool Equals(InputSettingInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!keyboardMappableKeys_.Equals(other.keyboardMappableKeys_))
		{
			return false;
		}
		if (GamepadInputType != other.GamepadInputType)
		{
			return false;
		}
		if (!gamepadDetailSettingInfo_.Equals(other.gamepadDetailSettingInfo_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		num ^= keyboardMappableKeys_.GetHashCode();
		if (GamepadInputType.Length != 0)
		{
			num ^= GamepadInputType.GetHashCode();
		}
		num ^= gamepadDetailSettingInfo_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		keyboardMappableKeys_.WriteTo(output, _repeated_keyboardMappableKeys_codec);
		if (GamepadInputType.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(GamepadInputType);
		}
		gamepadDetailSettingInfo_.WriteTo(output, _repeated_gamepadDetailSettingInfo_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		num += keyboardMappableKeys_.CalculateSize(_repeated_keyboardMappableKeys_codec);
		if (GamepadInputType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GamepadInputType);
		}
		num += gamepadDetailSettingInfo_.CalculateSize(_repeated_gamepadDetailSettingInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(InputSettingInfo other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			keyboardMappableKeys_.Add(other.keyboardMappableKeys_);
			if (other.GamepadInputType.Length != 0)
			{
				GamepadInputType = other.GamepadInputType;
			}
			gamepadDetailSettingInfo_.Add(other.gamepadDetailSettingInfo_);
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				keyboardMappableKeys_.AddEntriesFrom(input, _repeated_keyboardMappableKeys_codec);
				break;
			case 26u:
				GamepadInputType = input.ReadString();
				break;
			case 34u:
				gamepadDetailSettingInfo_.AddEntriesFrom(input, _repeated_gamepadDetailSettingInfo_codec);
				break;
			}
		}
	}
}
