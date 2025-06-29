using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class Accessory : IMessage<Accessory>, IMessage, IEquatable<Accessory>, IDeepCloneable<Accessory>
{
	private static readonly MessageParser<Accessory> _parser = new MessageParser<Accessory>(() => new Accessory());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<AccessorySlot> _repeated_accessorySlot_codec = FieldCodec.ForMessage(10u, OssB1.AccessorySlot.Parser);

	private readonly RepeatedField<AccessorySlot> accessorySlot_ = new RepeatedField<AccessorySlot>();

	public static MessageParser<Accessory> Parser => _parser;

	public RepeatedField<AccessorySlot> AccessorySlot => accessorySlot_;

	public Accessory()
	{
	}

	public Accessory(Accessory other)
		: this()
	{
		accessorySlot_ = other.accessorySlot_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Accessory Clone()
	{
		return new Accessory(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Accessory);
	}

	public bool Equals(Accessory other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!accessorySlot_.Equals(other.accessorySlot_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= accessorySlot_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		accessorySlot_.WriteTo(output, _repeated_accessorySlot_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += accessorySlot_.CalculateSize(_repeated_accessorySlot_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Accessory other)
	{
		if (other != null)
		{
			accessorySlot_.Add(other.accessorySlot_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				accessorySlot_.AddEntriesFrom(input, _repeated_accessorySlot_codec);
			}
		}
	}
}
