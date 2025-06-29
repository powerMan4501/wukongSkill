using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class CSMsgBagGainItemListReq : IMessage<CSMsgBagGainItemListReq>, IMessage, IEquatable<CSMsgBagGainItemListReq>, IDeepCloneable<CSMsgBagGainItemListReq>
{
	private static readonly MessageParser<CSMsgBagGainItemListReq> _parser = new MessageParser<CSMsgBagGainItemListReq>(() => new CSMsgBagGainItemListReq());

	private UnknownFieldSet _unknownFields;

	private OPReason reason_;

	private static readonly FieldCodec<ItemOne> _repeated_itemList_codec = FieldCodec.ForMessage(18u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> itemList_ = new RepeatedField<ItemOne>();

	public static MessageParser<CSMsgBagGainItemListReq> Parser => _parser;

	public OPReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	public RepeatedField<ItemOne> ItemList => itemList_;

	public CSMsgBagGainItemListReq()
	{
	}

	public CSMsgBagGainItemListReq(CSMsgBagGainItemListReq other)
		: this()
	{
		reason_ = other.reason_;
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagGainItemListReq Clone()
	{
		return new CSMsgBagGainItemListReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagGainItemListReq);
	}

	public bool Equals(CSMsgBagGainItemListReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
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
		if (Reason != OPReason.None)
		{
			num ^= Reason.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Reason != OPReason.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Reason);
		}
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Reason != OPReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagGainItemListReq other)
	{
		if (other != null)
		{
			if (other.Reason != OPReason.None)
			{
				Reason = other.Reason;
			}
			itemList_.Add(other.itemList_);
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
			case 8u:
				Reason = (OPReason)input.ReadEnum();
				break;
			case 18u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			}
		}
	}
}
