using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBItemRecipeDesc : IMessage<TBItemRecipeDesc>, IMessage, IEquatable<TBItemRecipeDesc>, IDeepCloneable<TBItemRecipeDesc>
{
	private static readonly MessageParser<TBItemRecipeDesc> _parser = new MessageParser<TBItemRecipeDesc>(() => new TBItemRecipeDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ItemRecipeDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, ItemRecipeDesc.Parser);

	private readonly RepeatedField<ItemRecipeDesc> list_ = new RepeatedField<ItemRecipeDesc>();

	public static MessageParser<TBItemRecipeDesc> Parser => _parser;

	public RepeatedField<ItemRecipeDesc> List => list_;

	public TBItemRecipeDesc()
	{
	}

	public TBItemRecipeDesc(TBItemRecipeDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBItemRecipeDesc Clone()
	{
		return new TBItemRecipeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBItemRecipeDesc);
	}

	public bool Equals(TBItemRecipeDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!list_.Equals(other.list_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= list_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		list_.WriteTo(output, _repeated_list_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += list_.CalculateSize(_repeated_list_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TBItemRecipeDesc other)
	{
		if (other != null)
		{
			list_.Add(other.list_);
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
				list_.AddEntriesFrom(input, _repeated_list_codec);
			}
		}
	}
}
