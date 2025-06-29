using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgSendRes : IMessage<CSMsgAwolMsgSendRes>, IMessage, IEquatable<CSMsgAwolMsgSendRes>, IDeepCloneable<CSMsgAwolMsgSendRes>
{
	private static readonly MessageParser<CSMsgAwolMsgSendRes> _parser = new MessageParser<CSMsgAwolMsgSendRes>(() => new CSMsgAwolMsgSendRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAwolMsgSendRes> Parser => _parser;

	public CSMsgAwolMsgSendRes()
	{
	}

	public CSMsgAwolMsgSendRes(CSMsgAwolMsgSendRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgSendRes Clone()
	{
		return new CSMsgAwolMsgSendRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgSendRes);
	}

	public bool Equals(CSMsgAwolMsgSendRes other)
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

	public void MergeFrom(CSMsgAwolMsgSendRes other)
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
