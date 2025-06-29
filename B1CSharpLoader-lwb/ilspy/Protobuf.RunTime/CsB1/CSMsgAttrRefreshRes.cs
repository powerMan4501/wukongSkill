using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAttrRefreshRes : IMessage<CSMsgAttrRefreshRes>, IMessage, IEquatable<CSMsgAttrRefreshRes>, IDeepCloneable<CSMsgAttrRefreshRes>
{
	private static readonly MessageParser<CSMsgAttrRefreshRes> _parser = new MessageParser<CSMsgAttrRefreshRes>(() => new CSMsgAttrRefreshRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAttrRefreshRes> Parser => _parser;

	public CSMsgAttrRefreshRes()
	{
	}

	public CSMsgAttrRefreshRes(CSMsgAttrRefreshRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAttrRefreshRes Clone()
	{
		return new CSMsgAttrRefreshRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAttrRefreshRes);
	}

	public bool Equals(CSMsgAttrRefreshRes other)
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

	public void MergeFrom(CSMsgAttrRefreshRes other)
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
