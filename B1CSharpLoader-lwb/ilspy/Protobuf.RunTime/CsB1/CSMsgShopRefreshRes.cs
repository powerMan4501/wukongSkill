using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgShopRefreshRes : IMessage<CSMsgShopRefreshRes>, IMessage, IEquatable<CSMsgShopRefreshRes>, IDeepCloneable<CSMsgShopRefreshRes>
{
	private static readonly MessageParser<CSMsgShopRefreshRes> _parser = new MessageParser<CSMsgShopRefreshRes>(() => new CSMsgShopRefreshRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgShopRefreshRes> Parser => _parser;

	public CSMsgShopRefreshRes()
	{
	}

	public CSMsgShopRefreshRes(CSMsgShopRefreshRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgShopRefreshRes Clone()
	{
		return new CSMsgShopRefreshRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgShopRefreshRes);
	}

	public bool Equals(CSMsgShopRefreshRes other)
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

	public void MergeFrom(CSMsgShopRefreshRes other)
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
