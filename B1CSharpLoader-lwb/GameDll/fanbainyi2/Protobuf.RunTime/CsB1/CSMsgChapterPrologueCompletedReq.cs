using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterPrologueCompletedReq : IMessage<CSMsgChapterPrologueCompletedReq>, IMessage, IEquatable<CSMsgChapterPrologueCompletedReq>, IDeepCloneable<CSMsgChapterPrologueCompletedReq>
{
	private static readonly MessageParser<CSMsgChapterPrologueCompletedReq> _parser = new MessageParser<CSMsgChapterPrologueCompletedReq>(() => new CSMsgChapterPrologueCompletedReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterPrologueCompletedReq> Parser => _parser;

	public CSMsgChapterPrologueCompletedReq()
	{
	}

	public CSMsgChapterPrologueCompletedReq(CSMsgChapterPrologueCompletedReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterPrologueCompletedReq Clone()
	{
		return new CSMsgChapterPrologueCompletedReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterPrologueCompletedReq);
	}

	public bool Equals(CSMsgChapterPrologueCompletedReq other)
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

	public void MergeFrom(CSMsgChapterPrologueCompletedReq other)
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
