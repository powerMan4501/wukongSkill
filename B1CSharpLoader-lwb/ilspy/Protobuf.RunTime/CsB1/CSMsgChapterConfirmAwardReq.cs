using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterConfirmAwardReq : IMessage<CSMsgChapterConfirmAwardReq>, IMessage, IEquatable<CSMsgChapterConfirmAwardReq>, IDeepCloneable<CSMsgChapterConfirmAwardReq>
{
	private static readonly MessageParser<CSMsgChapterConfirmAwardReq> _parser = new MessageParser<CSMsgChapterConfirmAwardReq>(() => new CSMsgChapterConfirmAwardReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterConfirmAwardReq> Parser => _parser;

	public CSMsgChapterConfirmAwardReq()
	{
	}

	public CSMsgChapterConfirmAwardReq(CSMsgChapterConfirmAwardReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterConfirmAwardReq Clone()
	{
		return new CSMsgChapterConfirmAwardReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterConfirmAwardReq);
	}

	public bool Equals(CSMsgChapterConfirmAwardReq other)
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

	public void MergeFrom(CSMsgChapterConfirmAwardReq other)
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
