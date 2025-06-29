using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterGameCompleteRes : IMessage<CSMsgChapterGameCompleteRes>, IMessage, IEquatable<CSMsgChapterGameCompleteRes>, IDeepCloneable<CSMsgChapterGameCompleteRes>
{
	private static readonly MessageParser<CSMsgChapterGameCompleteRes> _parser = new MessageParser<CSMsgChapterGameCompleteRes>(() => new CSMsgChapterGameCompleteRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterGameCompleteRes> Parser => _parser;

	public CSMsgChapterGameCompleteRes()
	{
	}

	public CSMsgChapterGameCompleteRes(CSMsgChapterGameCompleteRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterGameCompleteRes Clone()
	{
		return new CSMsgChapterGameCompleteRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterGameCompleteRes);
	}

	public bool Equals(CSMsgChapterGameCompleteRes other)
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

	public void MergeFrom(CSMsgChapterGameCompleteRes other)
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
