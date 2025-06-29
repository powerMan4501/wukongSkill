using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagGainEditionAwardRes : IMessage<CSMsgBagGainEditionAwardRes>, IMessage, IEquatable<CSMsgBagGainEditionAwardRes>, IDeepCloneable<CSMsgBagGainEditionAwardRes>
{
	private static readonly MessageParser<CSMsgBagGainEditionAwardRes> _parser = new MessageParser<CSMsgBagGainEditionAwardRes>(() => new CSMsgBagGainEditionAwardRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagGainEditionAwardRes> Parser => _parser;

	public CSMsgBagGainEditionAwardRes()
	{
	}

	public CSMsgBagGainEditionAwardRes(CSMsgBagGainEditionAwardRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagGainEditionAwardRes Clone()
	{
		return new CSMsgBagGainEditionAwardRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagGainEditionAwardRes);
	}

	public bool Equals(CSMsgBagGainEditionAwardRes other)
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

	public void MergeFrom(CSMsgBagGainEditionAwardRes other)
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
