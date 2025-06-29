using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMiscCreateRoleRes : IMessage<CSMsgMiscCreateRoleRes>, IMessage, IEquatable<CSMsgMiscCreateRoleRes>, IDeepCloneable<CSMsgMiscCreateRoleRes>
{
	private static readonly MessageParser<CSMsgMiscCreateRoleRes> _parser = new MessageParser<CSMsgMiscCreateRoleRes>(() => new CSMsgMiscCreateRoleRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgMiscCreateRoleRes> Parser => _parser;

	public CSMsgMiscCreateRoleRes()
	{
	}

	public CSMsgMiscCreateRoleRes(CSMsgMiscCreateRoleRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscCreateRoleRes Clone()
	{
		return new CSMsgMiscCreateRoleRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscCreateRoleRes);
	}

	public bool Equals(CSMsgMiscCreateRoleRes other)
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

	public void MergeFrom(CSMsgMiscCreateRoleRes other)
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
