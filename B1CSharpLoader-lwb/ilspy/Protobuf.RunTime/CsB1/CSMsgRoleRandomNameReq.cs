using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleRandomNameReq : IMessage<CSMsgRoleRandomNameReq>, IMessage, IEquatable<CSMsgRoleRandomNameReq>, IDeepCloneable<CSMsgRoleRandomNameReq>
{
	private static readonly MessageParser<CSMsgRoleRandomNameReq> _parser = new MessageParser<CSMsgRoleRandomNameReq>(() => new CSMsgRoleRandomNameReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoleRandomNameReq> Parser => _parser;

	public CSMsgRoleRandomNameReq()
	{
	}

	public CSMsgRoleRandomNameReq(CSMsgRoleRandomNameReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleRandomNameReq Clone()
	{
		return new CSMsgRoleRandomNameReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleRandomNameReq);
	}

	public bool Equals(CSMsgRoleRandomNameReq other)
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

	public void MergeFrom(CSMsgRoleRandomNameReq other)
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
