using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterPrologueCompletedRes : IMessage<CSMsgChapterPrologueCompletedRes>, IMessage, IEquatable<CSMsgChapterPrologueCompletedRes>, IDeepCloneable<CSMsgChapterPrologueCompletedRes>
{
	private static readonly MessageParser<CSMsgChapterPrologueCompletedRes> _parser = new MessageParser<CSMsgChapterPrologueCompletedRes>(() => new CSMsgChapterPrologueCompletedRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterPrologueCompletedRes> Parser => _parser;

	public CSMsgChapterPrologueCompletedRes()
	{
	}

	public CSMsgChapterPrologueCompletedRes(CSMsgChapterPrologueCompletedRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterPrologueCompletedRes Clone()
	{
		return new CSMsgChapterPrologueCompletedRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterPrologueCompletedRes);
	}

	public bool Equals(CSMsgChapterPrologueCompletedRes other)
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

	public void MergeFrom(CSMsgChapterPrologueCompletedRes other)
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
