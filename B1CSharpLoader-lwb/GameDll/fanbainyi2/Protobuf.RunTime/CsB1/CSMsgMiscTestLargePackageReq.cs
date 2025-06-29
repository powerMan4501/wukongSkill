using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class CSMsgMiscTestLargePackageReq : IMessage<CSMsgMiscTestLargePackageReq>, IMessage, IEquatable<CSMsgMiscTestLargePackageReq>, IDeepCloneable<CSMsgMiscTestLargePackageReq>
{
	private static readonly MessageParser<CSMsgMiscTestLargePackageReq> _parser = new MessageParser<CSMsgMiscTestLargePackageReq>(() => new CSMsgMiscTestLargePackageReq());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ItemOne> _repeated_itemList_codec = FieldCodec.ForMessage(10u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> itemList_ = new RepeatedField<ItemOne>();

	public static MessageParser<CSMsgMiscTestLargePackageReq> Parser => _parser;

	public RepeatedField<ItemOne> ItemList => itemList_;

	public CSMsgMiscTestLargePackageReq()
	{
	}

	public CSMsgMiscTestLargePackageReq(CSMsgMiscTestLargePackageReq other)
		: this()
	{
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscTestLargePackageReq Clone()
	{
		return new CSMsgMiscTestLargePackageReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscTestLargePackageReq);
	}

	public bool Equals(CSMsgMiscTestLargePackageReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= itemList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMiscTestLargePackageReq other)
	{
		if (other != null)
		{
			itemList_.Add(other.itemList_);
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
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
			}
		}
	}
}
