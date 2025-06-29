using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterPreviewAwardReq : IMessage<CSMsgChapterPreviewAwardReq>, IMessage, IEquatable<CSMsgChapterPreviewAwardReq>, IDeepCloneable<CSMsgChapterPreviewAwardReq>
{
	private static readonly MessageParser<CSMsgChapterPreviewAwardReq> _parser = new MessageParser<CSMsgChapterPreviewAwardReq>(() => new CSMsgChapterPreviewAwardReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterPreviewAwardReq> Parser => _parser;

	public CSMsgChapterPreviewAwardReq()
	{
	}

	public CSMsgChapterPreviewAwardReq(CSMsgChapterPreviewAwardReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterPreviewAwardReq Clone()
	{
		return new CSMsgChapterPreviewAwardReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterPreviewAwardReq);
	}

	public bool Equals(CSMsgChapterPreviewAwardReq other)
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

	public void MergeFrom(CSMsgChapterPreviewAwardReq other)
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
