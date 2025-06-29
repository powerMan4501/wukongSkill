using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleLogoutRes : IMessage<CSMsgRoleLogoutRes>, IMessage, IEquatable<CSMsgRoleLogoutRes>, IDeepCloneable<CSMsgRoleLogoutRes>
{
	private static readonly MessageParser<CSMsgRoleLogoutRes> _parser = new MessageParser<CSMsgRoleLogoutRes>(() => new CSMsgRoleLogoutRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoleLogoutRes> Parser => _parser;

	public CSMsgRoleLogoutRes()
	{
	}

	public CSMsgRoleLogoutRes(CSMsgRoleLogoutRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleLogoutRes Clone()
	{
		return new CSMsgRoleLogoutRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleLogoutRes);
	}

	public bool Equals(CSMsgRoleLogoutRes other)
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

	public void MergeFrom(CSMsgRoleLogoutRes other)
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
