using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagRebuildAttrItemReq : IMessage<CSMsgBagRebuildAttrItemReq>, IMessage, IEquatable<CSMsgBagRebuildAttrItemReq>, IDeepCloneable<CSMsgBagRebuildAttrItemReq>
{
	private static readonly MessageParser<CSMsgBagRebuildAttrItemReq> _parser = new MessageParser<CSMsgBagRebuildAttrItemReq>(() => new CSMsgBagRebuildAttrItemReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagRebuildAttrItemReq> Parser => _parser;

	public CSMsgBagRebuildAttrItemReq()
	{
	}

	public CSMsgBagRebuildAttrItemReq(CSMsgBagRebuildAttrItemReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagRebuildAttrItemReq Clone()
	{
		return new CSMsgBagRebuildAttrItemReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagRebuildAttrItemReq);
	}

	public bool Equals(CSMsgBagRebuildAttrItemReq other)
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

	public void MergeFrom(CSMsgBagRebuildAttrItemReq other)
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
