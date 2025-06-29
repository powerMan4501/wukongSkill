using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgNotifyRemoveReq : IMessage<CSMsgAwolMsgNotifyRemoveReq>, IMessage, IEquatable<CSMsgAwolMsgNotifyRemoveReq>, IDeepCloneable<CSMsgAwolMsgNotifyRemoveReq>
{
	private static readonly MessageParser<CSMsgAwolMsgNotifyRemoveReq> _parser = new MessageParser<CSMsgAwolMsgNotifyRemoveReq>(() => new CSMsgAwolMsgNotifyRemoveReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAwolMsgNotifyRemoveReq> Parser => _parser;

	public CSMsgAwolMsgNotifyRemoveReq()
	{
	}

	public CSMsgAwolMsgNotifyRemoveReq(CSMsgAwolMsgNotifyRemoveReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgNotifyRemoveReq Clone()
	{
		return new CSMsgAwolMsgNotifyRemoveReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgNotifyRemoveReq);
	}

	public bool Equals(CSMsgAwolMsgNotifyRemoveReq other)
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

	public void MergeFrom(CSMsgAwolMsgNotifyRemoveReq other)
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
