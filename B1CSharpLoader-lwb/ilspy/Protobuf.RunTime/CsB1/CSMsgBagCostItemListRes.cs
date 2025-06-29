using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagCostItemListRes : IMessage<CSMsgBagCostItemListRes>, IMessage, IEquatable<CSMsgBagCostItemListRes>, IDeepCloneable<CSMsgBagCostItemListRes>
{
	private static readonly MessageParser<CSMsgBagCostItemListRes> _parser = new MessageParser<CSMsgBagCostItemListRes>(() => new CSMsgBagCostItemListRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagCostItemListRes> Parser => _parser;

	public CSMsgBagCostItemListRes()
	{
	}

	public CSMsgBagCostItemListRes(CSMsgBagCostItemListRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagCostItemListRes Clone()
	{
		return new CSMsgBagCostItemListRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagCostItemListRes);
	}

	public bool Equals(CSMsgBagCostItemListRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagCostItemListRes other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
