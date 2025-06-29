using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterEnterNextReq : IMessage<CSMsgChapterEnterNextReq>, IMessage, IEquatable<CSMsgChapterEnterNextReq>, IDeepCloneable<CSMsgChapterEnterNextReq>
{
	private static readonly MessageParser<CSMsgChapterEnterNextReq> _parser = new MessageParser<CSMsgChapterEnterNextReq>(() => new CSMsgChapterEnterNextReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterEnterNextReq> Parser => _parser;

	public CSMsgChapterEnterNextReq()
	{
	}

	public CSMsgChapterEnterNextReq(CSMsgChapterEnterNextReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterEnterNextReq Clone()
	{
		return new CSMsgChapterEnterNextReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterEnterNextReq);
	}

	public bool Equals(CSMsgChapterEnterNextReq other)
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

	public void MergeFrom(CSMsgChapterEnterNextReq other)
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
