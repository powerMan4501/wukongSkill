using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgChapterEnterNextRes : IMessage<CSMsgChapterEnterNextRes>, IMessage, IEquatable<CSMsgChapterEnterNextRes>, IDeepCloneable<CSMsgChapterEnterNextRes>
{
	private static readonly MessageParser<CSMsgChapterEnterNextRes> _parser = new MessageParser<CSMsgChapterEnterNextRes>(() => new CSMsgChapterEnterNextRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgChapterEnterNextRes> Parser => _parser;

	public CSMsgChapterEnterNextRes()
	{
	}

	public CSMsgChapterEnterNextRes(CSMsgChapterEnterNextRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgChapterEnterNextRes Clone()
	{
		return new CSMsgChapterEnterNextRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgChapterEnterNextRes);
	}

	public bool Equals(CSMsgChapterEnterNextRes other)
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

	public void MergeFrom(CSMsgChapterEnterNextRes other)
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
