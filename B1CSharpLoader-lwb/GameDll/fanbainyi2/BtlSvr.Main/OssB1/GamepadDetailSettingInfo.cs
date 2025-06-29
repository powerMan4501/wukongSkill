using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class GamepadDetailSettingInfo : IMessage<GamepadDetailSettingInfo>, IMessage, IEquatable<GamepadDetailSettingInfo>, IDeepCloneable<GamepadDetailSettingInfo>
{
	private static readonly MessageParser<GamepadDetailSettingInfo> _parser = new MessageParser<GamepadDetailSettingInfo>(() => new GamepadDetailSettingInfo());

	private UnknownFieldSet _unknownFields;

	private string inputDetailType_ = "";

	private static readonly FieldCodec<MappableKey> _repeated_detailMappableKeys_codec = FieldCodec.ForMessage(18u, MappableKey.Parser);

	private readonly RepeatedField<MappableKey> detailMappableKeys_ = new RepeatedField<MappableKey>();

	public static MessageParser<GamepadDetailSettingInfo> Parser => _parser;

	public string InputDetailType
	{
		get
		{
			return inputDetailType_;
		}
		set
		{
			inputDetailType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<MappableKey> DetailMappableKeys => detailMappableKeys_;

	public GamepadDetailSettingInfo()
	{
	}

	public GamepadDetailSettingInfo(GamepadDetailSettingInfo other)
		: this()
	{
		inputDetailType_ = other.inputDetailType_;
		detailMappableKeys_ = other.detailMappableKeys_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GamepadDetailSettingInfo Clone()
	{
		return new GamepadDetailSettingInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GamepadDetailSettingInfo);
	}

	public bool Equals(GamepadDetailSettingInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InputDetailType != other.InputDetailType)
		{
			return false;
		}
		if (!detailMappableKeys_.Equals(other.detailMappableKeys_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (InputDetailType.Length != 0)
		{
			num ^= InputDetailType.GetHashCode();
		}
		num ^= detailMappableKeys_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (InputDetailType.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(InputDetailType);
		}
		detailMappableKeys_.WriteTo(output, _repeated_detailMappableKeys_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (InputDetailType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InputDetailType);
		}
		num += detailMappableKeys_.CalculateSize(_repeated_detailMappableKeys_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GamepadDetailSettingInfo other)
	{
		if (other != null)
		{
			if (other.InputDetailType.Length != 0)
			{
				InputDetailType = other.InputDetailType;
			}
			detailMappableKeys_.Add(other.detailMappableKeys_);
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
				InputDetailType = input.ReadString();
				break;
			case 18u:
				detailMappableKeys_.AddEntriesFrom(input, _repeated_detailMappableKeys_codec);
				break;
			}
		}
	}
}
