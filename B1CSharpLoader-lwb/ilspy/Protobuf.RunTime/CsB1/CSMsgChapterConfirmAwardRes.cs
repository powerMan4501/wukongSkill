using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterConfirmAwardRes : IMessage<CSMsgChapterConfirmAwardRes>, IMessage, IEquatable<CSMsgChapterConfirmAwardRes>, IDeepCloneable<CSMsgChapterConfirmAwardRes>
{
	private static readonly MessageParser<CSMsgChapterConfirmAwardRes> _parser = new MessageParser<CSMsgChapterConfirmAwardRes>(() => new CSMsgChapterConfirmAwardRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterConfirmAwardRes> Parser => _parser;

	public CSMsgChapterConfirmAwardRes()
	{
	}

	public CSMsgChapterConfirmAwardRes(CSMsgChapterConfirmAwardRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterConfirmAwardRes Clone()
	{
		return new CSMsgChapterConfirmAwardRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterConfirmAwardRes);
	}

	public bool Equals(CSMsgChapterConfirmAwardRes other)
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

	public void MergeFrom(CSMsgChapterConfirmAwardRes other)
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
