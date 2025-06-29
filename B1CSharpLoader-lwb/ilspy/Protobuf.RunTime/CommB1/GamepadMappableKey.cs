using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class GamepadMappableKey : IMessage<GamepadMappableKey>, IMessage, IEquatable<GamepadMappableKey>, IDeepCloneable<GamepadMappableKey>
{
	private static readonly MessageParser<GamepadMappableKey> _parser = new MessageParser<GamepadMappableKey>(() => new GamepadMappableKey());

	private UnknownFieldSet _unknownFields;

	private ECustomizedInputType customizedInputType_;

	private static readonly FieldCodec<MappableKey> _repeated_mappableKeys_codec = FieldCodec.ForMessage(18u, MappableKey.Parser);

	private readonly RepeatedField<MappableKey> mappableKeys_ = new RepeatedField<MappableKey>();

	public static MessageParser<GamepadMappableKey> Parser => _parser;

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

	public RepeatedField<MappableKey> MappableKeys => mappableKeys_;

	public GamepadMappableKey()
	{
	}

	public GamepadMappableKey(GamepadMappableKey other)
		: this()
	{
		customizedInputType_ = other.customizedInputType_;
		mappableKeys_ = other.mappableKeys_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GamepadMappableKey Clone()
	{
		return new GamepadMappableKey(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GamepadMappableKey);
	}

	public bool Equals(GamepadMappableKey other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CustomizedInputType != other.CustomizedInputType)
		{
			return false;
		}
		if (!mappableKeys_.Equals(other.mappableKeys_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CustomizedInputType != ECustomizedInputType.None)
		{
			num ^= CustomizedInputType.GetHashCode();
		}
		num ^= mappableKeys_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CustomizedInputType != ECustomizedInputType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)CustomizedInputType);
		}
		mappableKeys_.WriteTo(output, _repeated_mappableKeys_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CustomizedInputType != ECustomizedInputType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CustomizedInputType);
		}
		num += mappableKeys_.CalculateSize(_repeated_mappableKeys_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GamepadMappableKey other)
	{
		if (other != null)
		{
			if (other.CustomizedInputType != ECustomizedInputType.None)
			{
				CustomizedInputType = other.CustomizedInputType;
			}
			mappableKeys_.Add(other.mappableKeys_);
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
				CustomizedInputType = (ECustomizedInputType)input.ReadEnum();
				break;
			case 18u:
				mappableKeys_.AddEntriesFrom(input, _repeated_mappableKeys_codec);
				break;
			}
		}
	}
}
