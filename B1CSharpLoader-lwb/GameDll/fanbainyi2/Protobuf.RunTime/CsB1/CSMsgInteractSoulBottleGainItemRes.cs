using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgInteractSoulBottleGainItemRes : IMessage<CSMsgInteractSoulBottleGainItemRes>, IMessage, IEquatable<CSMsgInteractSoulBottleGainItemRes>, IDeepCloneable<CSMsgInteractSoulBottleGainItemRes>
{
	private static readonly MessageParser<CSMsgInteractSoulBottleGainItemRes> _parser = new MessageParser<CSMsgInteractSoulBottleGainItemRes>(() => new CSMsgInteractSoulBottleGainItemRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgInteractSoulBottleGainItemRes> Parser => _parser;

	public CSMsgInteractSoulBottleGainItemRes()
	{
	}

	public CSMsgInteractSoulBottleGainItemRes(CSMsgInteractSoulBottleGainItemRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgInteractSoulBottleGainItemRes Clone()
	{
		return new CSMsgInteractSoulBottleGainItemRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgInteractSoulBottleGainItemRes);
	}

	public bool Equals(CSMsgInteractSoulBottleGainItemRes other)
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

	public void MergeFrom(CSMsgInteractSoulBottleGainItemRes other)
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
