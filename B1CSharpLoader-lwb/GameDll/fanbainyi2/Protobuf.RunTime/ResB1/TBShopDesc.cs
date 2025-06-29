using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBShopDesc : IMessage<TBShopDesc>, IMessage, IEquatable<TBShopDesc>, IDeepCloneable<TBShopDesc>
{
	private static readonly MessageParser<TBShopDesc> _parser = new MessageParser<TBShopDesc>(() => new TBShopDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ShopDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, ShopDesc.Parser);

	private readonly RepeatedField<ShopDesc> list_ = new RepeatedField<ShopDesc>();

	public static MessageParser<TBShopDesc> Parser => _parser;

	public RepeatedField<ShopDesc> List => list_;

	public TBShopDesc()
	{
	}

	public TBShopDesc(TBShopDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBShopDesc Clone()
	{
		return new TBShopDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBShopDesc);
	}

	public bool Equals(TBShopDesc other)
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

	public void MergeFrom(TBShopDesc other)
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
