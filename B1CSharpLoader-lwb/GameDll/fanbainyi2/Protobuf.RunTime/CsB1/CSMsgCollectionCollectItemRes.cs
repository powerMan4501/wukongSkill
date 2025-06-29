using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgCollectionCollectItemRes : IMessage<CSMsgCollectionCollectItemRes>, IMessage, IEquatable<CSMsgCollectionCollectItemRes>, IDeepCloneable<CSMsgCollectionCollectItemRes>
{
	private static readonly MessageParser<CSMsgCollectionCollectItemRes> _parser = new MessageParser<CSMsgCollectionCollectItemRes>(() => new CSMsgCollectionCollectItemRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgCollectionCollectItemRes> Parser => _parser;

	public CSMsgCollectionCollectItemRes()
	{
	}

	public CSMsgCollectionCollectItemRes(CSMsgCollectionCollectItemRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgCollectionCollectItemRes Clone()
	{
		return new CSMsgCollectionCollectItemRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgCollectionCollectItemRes);
	}

	public bool Equals(CSMsgCollectionCollectItemRes other)
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

	public void MergeFrom(CSMsgCollectionCollectItemRes other)
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
