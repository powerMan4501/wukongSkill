using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRedPointRemoveRes : IMessage<CSMsgRedPointRemoveRes>, IMessage, IEquatable<CSMsgRedPointRemoveRes>, IDeepCloneable<CSMsgRedPointRemoveRes>
{
	private static readonly MessageParser<CSMsgRedPointRemoveRes> _parser = new MessageParser<CSMsgRedPointRemoveRes>(() => new CSMsgRedPointRemoveRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRedPointRemoveRes> Parser => _parser;

	public CSMsgRedPointRemoveRes()
	{
	}

	public CSMsgRedPointRemoveRes(CSMsgRedPointRemoveRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRedPointRemoveRes Clone()
	{
		return new CSMsgRedPointRemoveRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRedPointRemoveRes);
	}

	public bool Equals(CSMsgRedPointRemoveRes other)
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

	public void MergeFrom(CSMsgRedPointRemoveRes other)
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
