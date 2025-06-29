using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagSellItemRes : IMessage<CSMsgBagSellItemRes>, IMessage, IEquatable<CSMsgBagSellItemRes>, IDeepCloneable<CSMsgBagSellItemRes>
{
	private static readonly MessageParser<CSMsgBagSellItemRes> _parser = new MessageParser<CSMsgBagSellItemRes>(() => new CSMsgBagSellItemRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagSellItemRes> Parser => _parser;

	public CSMsgBagSellItemRes()
	{
	}

	public CSMsgBagSellItemRes(CSMsgBagSellItemRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagSellItemRes Clone()
	{
		return new CSMsgBagSellItemRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagSellItemRes);
	}

	public bool Equals(CSMsgBagSellItemRes other)
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

	public void MergeFrom(CSMsgBagSellItemRes other)
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
