using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgGetListReq : IMessage<CSMsgAwolMsgGetListReq>, IMessage, IEquatable<CSMsgAwolMsgGetListReq>, IDeepCloneable<CSMsgAwolMsgGetListReq>
{
	private static readonly MessageParser<CSMsgAwolMsgGetListReq> _parser = new MessageParser<CSMsgAwolMsgGetListReq>(() => new CSMsgAwolMsgGetListReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAwolMsgGetListReq> Parser => _parser;

	public CSMsgAwolMsgGetListReq()
	{
	}

	public CSMsgAwolMsgGetListReq(CSMsgAwolMsgGetListReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgGetListReq Clone()
	{
		return new CSMsgAwolMsgGetListReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgGetListReq);
	}

	public bool Equals(CSMsgAwolMsgGetListReq other)
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

	public void MergeFrom(CSMsgAwolMsgGetListReq other)
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
