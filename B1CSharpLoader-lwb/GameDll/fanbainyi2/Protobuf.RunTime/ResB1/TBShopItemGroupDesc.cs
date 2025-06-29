using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBShopItemGroupDesc : IMessage<TBShopItemGroupDesc>, IMessage, IEquatable<TBShopItemGroupDesc>, IDeepCloneable<TBShopItemGroupDesc>
{
	private static readonly MessageParser<TBShopItemGroupDesc> _parser = new MessageParser<TBShopItemGroupDesc>(() => new TBShopItemGroupDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ShopItemGroupDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, ShopItemGroupDesc.Parser);

	private readonly RepeatedField<ShopItemGroupDesc> list_ = new RepeatedField<ShopItemGroupDesc>();

	public static MessageParser<TBShopItemGroupDesc> Parser => _parser;

	public RepeatedField<ShopItemGroupDesc> List => list_;

	public TBShopItemGroupDesc()
	{
	}

	public TBShopItemGroupDesc(TBShopItemGroupDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBShopItemGroupDesc Clone()
	{
		return new TBShopItemGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBShopItemGroupDesc);
	}

	public bool Equals(TBShopItemGroupDesc other)
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

	public void MergeFrom(TBShopItemGroupDesc other)
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
