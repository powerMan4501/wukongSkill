using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class WearAccessory : IMessage<WearAccessory>, IMessage, IEquatable<WearAccessory>, IDeepCloneable<WearAccessory>
{
	private static readonly MessageParser<WearAccessory> _parser = new MessageParser<WearAccessory>(() => new WearAccessory());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<AccessoryProp> _repeated_accessorylist_codec = FieldCodec.ForMessage(18u, AccessoryProp.Parser);

	private readonly RepeatedField<AccessoryProp> accessorylist_ = new RepeatedField<AccessoryProp>();

	public static MessageParser<WearAccessory> Parser => _parser;

	public RepeatedField<AccessoryProp> Accessorylist => accessorylist_;

	public WearAccessory()
	{
	}

	public WearAccessory(WearAccessory other)
		: this()
	{
		accessorylist_ = other.accessorylist_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WearAccessory Clone()
	{
		return new WearAccessory(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WearAccessory);
	}

	public bool Equals(WearAccessory other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!accessorylist_.Equals(other.accessorylist_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= accessorylist_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		accessorylist_.WriteTo(output, _repeated_accessorylist_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += accessorylist_.CalculateSize(_repeated_accessorylist_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WearAccessory other)
	{
		if (other != null)
		{
			accessorylist_.Add(other.accessorylist_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				accessorylist_.AddEntriesFrom(input, _repeated_accessorylist_codec);
			}
		}
	}
}
