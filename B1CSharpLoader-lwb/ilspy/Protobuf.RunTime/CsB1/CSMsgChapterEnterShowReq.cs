using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterEnterShowReq : IMessage<CSMsgChapterEnterShowReq>, IMessage, IEquatable<CSMsgChapterEnterShowReq>, IDeepCloneable<CSMsgChapterEnterShowReq>
{
	private static readonly MessageParser<CSMsgChapterEnterShowReq> _parser = new MessageParser<CSMsgChapterEnterShowReq>(() => new CSMsgChapterEnterShowReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterEnterShowReq> Parser => _parser;

	public CSMsgChapterEnterShowReq()
	{
	}

	public CSMsgChapterEnterShowReq(CSMsgChapterEnterShowReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterEnterShowReq Clone()
	{
		return new CSMsgChapterEnterShowReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterEnterShowReq);
	}

	public bool Equals(CSMsgChapterEnterShowReq other)
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

	public void MergeFrom(CSMsgChapterEnterShowReq other)
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
