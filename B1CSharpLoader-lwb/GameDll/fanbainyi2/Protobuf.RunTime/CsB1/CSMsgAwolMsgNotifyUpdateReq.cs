using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgNotifyUpdateReq : IMessage<CSMsgAwolMsgNotifyUpdateReq>, IMessage, IEquatable<CSMsgAwolMsgNotifyUpdateReq>, IDeepCloneable<CSMsgAwolMsgNotifyUpdateReq>
{
	private static readonly MessageParser<CSMsgAwolMsgNotifyUpdateReq> _parser = new MessageParser<CSMsgAwolMsgNotifyUpdateReq>(() => new CSMsgAwolMsgNotifyUpdateReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAwolMsgNotifyUpdateReq> Parser => _parser;

	public CSMsgAwolMsgNotifyUpdateReq()
	{
	}

	public CSMsgAwolMsgNotifyUpdateReq(CSMsgAwolMsgNotifyUpdateReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgNotifyUpdateReq Clone()
	{
		return new CSMsgAwolMsgNotifyUpdateReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgNotifyUpdateReq);
	}

	public bool Equals(CSMsgAwolMsgNotifyUpdateReq other)
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

	public void MergeFrom(CSMsgAwolMsgNotifyUpdateReq other)
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
