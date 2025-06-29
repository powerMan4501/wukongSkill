using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterGameCompleteReq : IMessage<CSMsgChapterGameCompleteReq>, IMessage, IEquatable<CSMsgChapterGameCompleteReq>, IDeepCloneable<CSMsgChapterGameCompleteReq>
{
	private static readonly MessageParser<CSMsgChapterGameCompleteReq> _parser = new MessageParser<CSMsgChapterGameCompleteReq>(() => new CSMsgChapterGameCompleteReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterGameCompleteReq> Parser => _parser;

	public CSMsgChapterGameCompleteReq()
	{
	}

	public CSMsgChapterGameCompleteReq(CSMsgChapterGameCompleteReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterGameCompleteReq Clone()
	{
		return new CSMsgChapterGameCompleteReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterGameCompleteReq);
	}

	public bool Equals(CSMsgChapterGameCompleteReq other)
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

	public void MergeFrom(CSMsgChapterGameCompleteReq other)
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
