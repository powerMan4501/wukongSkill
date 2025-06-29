using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class PlayerInfoRole : IMessage<PlayerInfoRole>, IMessage, IEquatable<PlayerInfoRole>, IDeepCloneable<PlayerInfoRole>
{
	private static readonly MessageParser<PlayerInfoRole> _parser = new MessageParser<PlayerInfoRole>(() => new PlayerInfoRole());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<Item> _repeated_items_codec = FieldCodec.ForMessage(10u, Item.Parser);

	private readonly RepeatedField<Item> items_ = new RepeatedField<Item>();

	private static readonly FieldCodec<RecLen> _repeated_recs_codec = FieldCodec.ForMessage(18u, RecLen.Parser);

	private readonly RepeatedField<RecLen> recs_ = new RepeatedField<RecLen>();

	public static MessageParser<PlayerInfoRole> Parser => _parser;

	public RepeatedField<Item> Items => items_;

	public RepeatedField<RecLen> Recs => recs_;

	public PlayerInfoRole()
	{
	}

	public PlayerInfoRole(PlayerInfoRole other)
		: this()
	{
		items_ = other.items_.Clone();
		recs_ = other.recs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerInfoRole Clone()
	{
		return new PlayerInfoRole(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerInfoRole);
	}

	public bool Equals(PlayerInfoRole other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!items_.Equals(other.items_))
		{
			return false;
		}
		if (!recs_.Equals(other.recs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= items_.GetHashCode();
		num ^= recs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		items_.WriteTo(output, _repeated_items_codec);
		recs_.WriteTo(output, _repeated_recs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += items_.CalculateSize(_repeated_items_codec);
		num += recs_.CalculateSize(_repeated_recs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerInfoRole other)
	{
		if (other != null)
		{
			items_.Add(other.items_);
			recs_.Add(other.recs_);
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
				items_.AddEntriesFrom(input, _repeated_items_codec);
				break;
			case 18u:
				recs_.AddEntriesFrom(input, _repeated_recs_codec);
				break;
			}
		}
	}
}
