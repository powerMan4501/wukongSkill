using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagGainItemListRes : IMessage<CSMsgBagGainItemListRes>, IMessage, IEquatable<CSMsgBagGainItemListRes>, IDeepCloneable<CSMsgBagGainItemListRes>
{
	private static readonly MessageParser<CSMsgBagGainItemListRes> _parser = new MessageParser<CSMsgBagGainItemListRes>(() => new CSMsgBagGainItemListRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagGainItemListRes> Parser => _parser;

	public CSMsgBagGainItemListRes()
	{
	}

	public CSMsgBagGainItemListRes(CSMsgBagGainItemListRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagGainItemListRes Clone()
	{
		return new CSMsgBagGainItemListRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagGainItemListRes);
	}

	public bool Equals(CSMsgBagGainItemListRes other)
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

	public void MergeFrom(CSMsgBagGainItemListRes other)
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
