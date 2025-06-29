using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class CSMsgMiscTestLargePackageRes : IMessage<CSMsgMiscTestLargePackageRes>, IMessage, IEquatable<CSMsgMiscTestLargePackageRes>, IDeepCloneable<CSMsgMiscTestLargePackageRes>
{
	private static readonly MessageParser<CSMsgMiscTestLargePackageRes> _parser = new MessageParser<CSMsgMiscTestLargePackageRes>(() => new CSMsgMiscTestLargePackageRes());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ItemOne> _repeated_itemList_codec = FieldCodec.ForMessage(10u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> itemList_ = new RepeatedField<ItemOne>();

	public static MessageParser<CSMsgMiscTestLargePackageRes> Parser => _parser;

	public RepeatedField<ItemOne> ItemList => itemList_;

	public CSMsgMiscTestLargePackageRes()
	{
	}

	public CSMsgMiscTestLargePackageRes(CSMsgMiscTestLargePackageRes other)
		: this()
	{
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscTestLargePackageRes Clone()
	{
		return new CSMsgMiscTestLargePackageRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscTestLargePackageRes);
	}

	public bool Equals(CSMsgMiscTestLargePackageRes other)
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

	public void MergeFrom(CSMsgMiscTestLargePackageRes other)
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
