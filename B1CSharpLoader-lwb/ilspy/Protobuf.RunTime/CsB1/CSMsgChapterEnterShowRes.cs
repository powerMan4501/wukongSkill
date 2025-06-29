using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterEnterShowRes : IMessage<CSMsgChapterEnterShowRes>, IMessage, IEquatable<CSMsgChapterEnterShowRes>, IDeepCloneable<CSMsgChapterEnterShowRes>
{
	private static readonly MessageParser<CSMsgChapterEnterShowRes> _parser = new MessageParser<CSMsgChapterEnterShowRes>(() => new CSMsgChapterEnterShowRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterEnterShowRes> Parser => _parser;

	public CSMsgChapterEnterShowRes()
	{
	}

	public CSMsgChapterEnterShowRes(CSMsgChapterEnterShowRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterEnterShowRes Clone()
	{
		return new CSMsgChapterEnterShowRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterEnterShowRes);
	}

	public bool Equals(CSMsgChapterEnterShowRes other)
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

	public void MergeFrom(CSMsgChapterEnterShowRes other)
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
