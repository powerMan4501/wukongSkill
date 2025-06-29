using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleChangeNameRes : IMessage<CSMsgRoleChangeNameRes>, IMessage, IEquatable<CSMsgRoleChangeNameRes>, IDeepCloneable<CSMsgRoleChangeNameRes>
{
	private static readonly MessageParser<CSMsgRoleChangeNameRes> _parser = new MessageParser<CSMsgRoleChangeNameRes>(() => new CSMsgRoleChangeNameRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgRoleChangeNameRes> Parser => _parser;

	public CSMsgRoleChangeNameRes()
	{
	}

	public CSMsgRoleChangeNameRes(CSMsgRoleChangeNameRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleChangeNameRes Clone()
	{
		return new CSMsgRoleChangeNameRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleChangeNameRes);
	}

	public bool Equals(CSMsgRoleChangeNameRes other)
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

	public void MergeFrom(CSMsgRoleChangeNameRes other)
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
