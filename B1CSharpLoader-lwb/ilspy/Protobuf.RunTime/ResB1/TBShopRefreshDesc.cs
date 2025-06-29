using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBShopRefreshDesc : IMessage<TBShopRefreshDesc>, IMessage, IEquatable<TBShopRefreshDesc>, IDeepCloneable<TBShopRefreshDesc>
{
	private static readonly MessageParser<TBShopRefreshDesc> _parser = new MessageParser<TBShopRefreshDesc>(() => new TBShopRefreshDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ShopRefreshDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, ShopRefreshDesc.Parser);

	private readonly RepeatedField<ShopRefreshDesc> list_ = new RepeatedField<ShopRefreshDesc>();

	public static MessageParser<TBShopRefreshDesc> Parser => _parser;

	public RepeatedField<ShopRefreshDesc> List => list_;

	public TBShopRefreshDesc()
	{
	}

	public TBShopRefreshDesc(TBShopRefreshDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBShopRefreshDesc Clone()
	{
		return new TBShopRefreshDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBShopRefreshDesc);
	}

	public bool Equals(TBShopRefreshDesc other)
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

	public void MergeFrom(TBShopRefreshDesc other)
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
