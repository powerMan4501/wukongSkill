using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgCollectionInteractiveUnlockRes : IMessage<CSMsgCollectionInteractiveUnlockRes>, IMessage, IEquatable<CSMsgCollectionInteractiveUnlockRes>, IDeepCloneable<CSMsgCollectionInteractiveUnlockRes>
{
	private static readonly MessageParser<CSMsgCollectionInteractiveUnlockRes> _parser = new MessageParser<CSMsgCollectionInteractiveUnlockRes>(() => new CSMsgCollectionInteractiveUnlockRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgCollectionInteractiveUnlockRes> Parser => _parser;

	public CSMsgCollectionInteractiveUnlockRes()
	{
	}

	public CSMsgCollectionInteractiveUnlockRes(CSMsgCollectionInteractiveUnlockRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgCollectionInteractiveUnlockRes Clone()
	{
		return new CSMsgCollectionInteractiveUnlockRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgCollectionInteractiveUnlockRes);
	}

	public bool Equals(CSMsgCollectionInteractiveUnlockRes other)
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

	public void MergeFrom(CSMsgCollectionInteractiveUnlockRes other)
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
