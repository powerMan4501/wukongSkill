using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleKickReq : IMessage<CSMsgRoleKickReq>, IMessage, IEquatable<CSMsgRoleKickReq>, IDeepCloneable<CSMsgRoleKickReq>
{
	private static readonly MessageParser<CSMsgRoleKickReq> _parser = new MessageParser<CSMsgRoleKickReq>(() => new CSMsgRoleKickReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoleKickReq> Parser => _parser;

	public CSMsgRoleKickReq()
	{
	}

	public CSMsgRoleKickReq(CSMsgRoleKickReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleKickReq Clone()
	{
		return new CSMsgRoleKickReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleKickReq);
	}

	public bool Equals(CSMsgRoleKickReq other)
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

	public void MergeFrom(CSMsgRoleKickReq other)
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
