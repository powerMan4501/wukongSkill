using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgInteractSoulBottleGainItemReq : IMessage<CSMsgInteractSoulBottleGainItemReq>, IMessage, IEquatable<CSMsgInteractSoulBottleGainItemReq>, IDeepCloneable<CSMsgInteractSoulBottleGainItemReq>
{
	private static readonly MessageParser<CSMsgInteractSoulBottleGainItemReq> _parser = new MessageParser<CSMsgInteractSoulBottleGainItemReq>(() => new CSMsgInteractSoulBottleGainItemReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgInteractSoulBottleGainItemReq> Parser => _parser;

	public CSMsgInteractSoulBottleGainItemReq()
	{
	}

	public CSMsgInteractSoulBottleGainItemReq(CSMsgInteractSoulBottleGainItemReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgInteractSoulBottleGainItemReq Clone()
	{
		return new CSMsgInteractSoulBottleGainItemReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgInteractSoulBottleGainItemReq);
	}

	public bool Equals(CSMsgInteractSoulBottleGainItemReq other)
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

	public void MergeFrom(CSMsgInteractSoulBottleGainItemReq other)
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
