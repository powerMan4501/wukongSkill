using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleDataNotifyReq : IMessage<CSMsgRoleDataNotifyReq>, IMessage, IEquatable<CSMsgRoleDataNotifyReq>, IDeepCloneable<CSMsgRoleDataNotifyReq>
{
	private static readonly MessageParser<CSMsgRoleDataNotifyReq> _parser = new MessageParser<CSMsgRoleDataNotifyReq>(() => new CSMsgRoleDataNotifyReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoleDataNotifyReq> Parser => _parser;

	public CSMsgRoleDataNotifyReq()
	{
	}

	public CSMsgRoleDataNotifyReq(CSMsgRoleDataNotifyReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleDataNotifyReq Clone()
	{
		return new CSMsgRoleDataNotifyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleDataNotifyReq);
	}

	public bool Equals(CSMsgRoleDataNotifyReq other)
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

	public void MergeFrom(CSMsgRoleDataNotifyReq other)
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
