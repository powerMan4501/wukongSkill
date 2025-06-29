using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class ListDeltaMsgBindListEntity : IMessage<ListDeltaMsgBindListEntity>, IMessage, IEquatable<ListDeltaMsgBindListEntity>, IDeepCloneable<ListDeltaMsgBindListEntity>
{
	private static readonly MessageParser<ListDeltaMsgBindListEntity> _parser = new MessageParser<ListDeltaMsgBindListEntity>(() => new ListDeltaMsgBindListEntity());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<uint> _repeated_value_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> value_ = new RepeatedField<uint>();

	public static MessageParser<ListDeltaMsgBindListEntity> Parser => _parser;

	public RepeatedField<uint> Value => value_;

	public ListDeltaMsgBindListEntity()
	{
	}

	public ListDeltaMsgBindListEntity(ListDeltaMsgBindListEntity other)
		: this()
	{
		value_ = other.value_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgBindListEntity Clone()
	{
		return new ListDeltaMsgBindListEntity(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgBindListEntity);
	}

	public bool Equals(ListDeltaMsgBindListEntity other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!value_.Equals(other.value_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= value_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		value_.WriteTo(output, _repeated_value_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += value_.CalculateSize(_repeated_value_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgBindListEntity other)
	{
		if (other != null)
		{
			value_.Add(other.value_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				value_.AddEntriesFrom(input, _repeated_value_codec);
			}
		}
	}
}
