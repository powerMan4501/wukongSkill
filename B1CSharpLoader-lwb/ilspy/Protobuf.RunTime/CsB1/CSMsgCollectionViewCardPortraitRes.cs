using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgCollectionViewCardPortraitRes : IMessage<CSMsgCollectionViewCardPortraitRes>, IMessage, IEquatable<CSMsgCollectionViewCardPortraitRes>, IDeepCloneable<CSMsgCollectionViewCardPortraitRes>
{
	private static readonly MessageParser<CSMsgCollectionViewCardPortraitRes> _parser = new MessageParser<CSMsgCollectionViewCardPortraitRes>(() => new CSMsgCollectionViewCardPortraitRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgCollectionViewCardPortraitRes> Parser => _parser;

	public CSMsgCollectionViewCardPortraitRes()
	{
	}

	public CSMsgCollectionViewCardPortraitRes(CSMsgCollectionViewCardPortraitRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgCollectionViewCardPortraitRes Clone()
	{
		return new CSMsgCollectionViewCardPortraitRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgCollectionViewCardPortraitRes);
	}

	public bool Equals(CSMsgCollectionViewCardPortraitRes other)
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

	public void MergeFrom(CSMsgCollectionViewCardPortraitRes other)
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
