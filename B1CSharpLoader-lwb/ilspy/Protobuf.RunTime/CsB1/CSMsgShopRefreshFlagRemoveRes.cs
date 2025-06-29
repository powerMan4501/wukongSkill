using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgShopRefreshFlagRemoveRes : IMessage<CSMsgShopRefreshFlagRemoveRes>, IMessage, IEquatable<CSMsgShopRefreshFlagRemoveRes>, IDeepCloneable<CSMsgShopRefreshFlagRemoveRes>
{
	private static readonly MessageParser<CSMsgShopRefreshFlagRemoveRes> _parser = new MessageParser<CSMsgShopRefreshFlagRemoveRes>(() => new CSMsgShopRefreshFlagRemoveRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgShopRefreshFlagRemoveRes> Parser => _parser;

	public CSMsgShopRefreshFlagRemoveRes()
	{
	}

	public CSMsgShopRefreshFlagRemoveRes(CSMsgShopRefreshFlagRemoveRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgShopRefreshFlagRemoveRes Clone()
	{
		return new CSMsgShopRefreshFlagRemoveRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgShopRefreshFlagRemoveRes);
	}

	public bool Equals(CSMsgShopRefreshFlagRemoveRes other)
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

	public void MergeFrom(CSMsgShopRefreshFlagRemoveRes other)
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
