using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgCollectionReadCardStoryRes : IMessage<CSMsgCollectionReadCardStoryRes>, IMessage, IEquatable<CSMsgCollectionReadCardStoryRes>, IDeepCloneable<CSMsgCollectionReadCardStoryRes>
{
	private static readonly MessageParser<CSMsgCollectionReadCardStoryRes> _parser = new MessageParser<CSMsgCollectionReadCardStoryRes>(() => new CSMsgCollectionReadCardStoryRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgCollectionReadCardStoryRes> Parser => _parser;

	public CSMsgCollectionReadCardStoryRes()
	{
	}

	public CSMsgCollectionReadCardStoryRes(CSMsgCollectionReadCardStoryRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgCollectionReadCardStoryRes Clone()
	{
		return new CSMsgCollectionReadCardStoryRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgCollectionReadCardStoryRes);
	}

	public bool Equals(CSMsgCollectionReadCardStoryRes other)
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

	public void MergeFrom(CSMsgCollectionReadCardStoryRes other)
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
