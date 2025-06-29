using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgNotifyAddReq : IMessage<CSMsgAwolMsgNotifyAddReq>, IMessage, IEquatable<CSMsgAwolMsgNotifyAddReq>, IDeepCloneable<CSMsgAwolMsgNotifyAddReq>
{
	private static readonly MessageParser<CSMsgAwolMsgNotifyAddReq> _parser = new MessageParser<CSMsgAwolMsgNotifyAddReq>(() => new CSMsgAwolMsgNotifyAddReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAwolMsgNotifyAddReq> Parser => _parser;

	public CSMsgAwolMsgNotifyAddReq()
	{
	}

	public CSMsgAwolMsgNotifyAddReq(CSMsgAwolMsgNotifyAddReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgNotifyAddReq Clone()
	{
		return new CSMsgAwolMsgNotifyAddReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgNotifyAddReq);
	}

	public bool Equals(CSMsgAwolMsgNotifyAddReq other)
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

	public void MergeFrom(CSMsgAwolMsgNotifyAddReq other)
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
