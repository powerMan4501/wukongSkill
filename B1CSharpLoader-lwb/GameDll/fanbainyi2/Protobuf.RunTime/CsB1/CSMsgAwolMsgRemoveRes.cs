using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgRemoveRes : IMessage<CSMsgAwolMsgRemoveRes>, IMessage, IEquatable<CSMsgAwolMsgRemoveRes>, IDeepCloneable<CSMsgAwolMsgRemoveRes>
{
	private static readonly MessageParser<CSMsgAwolMsgRemoveRes> _parser = new MessageParser<CSMsgAwolMsgRemoveRes>(() => new CSMsgAwolMsgRemoveRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAwolMsgRemoveRes> Parser => _parser;

	public CSMsgAwolMsgRemoveRes()
	{
	}

	public CSMsgAwolMsgRemoveRes(CSMsgAwolMsgRemoveRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgRemoveRes Clone()
	{
		return new CSMsgAwolMsgRemoveRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgRemoveRes);
	}

	public bool Equals(CSMsgAwolMsgRemoveRes other)
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

	public void MergeFrom(CSMsgAwolMsgRemoveRes other)
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
