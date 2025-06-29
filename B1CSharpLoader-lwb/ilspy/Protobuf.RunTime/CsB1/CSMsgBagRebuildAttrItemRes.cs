using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagRebuildAttrItemRes : IMessage<CSMsgBagRebuildAttrItemRes>, IMessage, IEquatable<CSMsgBagRebuildAttrItemRes>, IDeepCloneable<CSMsgBagRebuildAttrItemRes>
{
	private static readonly MessageParser<CSMsgBagRebuildAttrItemRes> _parser = new MessageParser<CSMsgBagRebuildAttrItemRes>(() => new CSMsgBagRebuildAttrItemRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagRebuildAttrItemRes> Parser => _parser;

	public CSMsgBagRebuildAttrItemRes()
	{
	}

	public CSMsgBagRebuildAttrItemRes(CSMsgBagRebuildAttrItemRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagRebuildAttrItemRes Clone()
	{
		return new CSMsgBagRebuildAttrItemRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagRebuildAttrItemRes);
	}

	public bool Equals(CSMsgBagRebuildAttrItemRes other)
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

	public void MergeFrom(CSMsgBagRebuildAttrItemRes other)
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
