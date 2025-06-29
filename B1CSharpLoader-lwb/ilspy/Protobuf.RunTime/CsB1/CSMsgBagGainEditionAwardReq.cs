using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagGainEditionAwardReq : IMessage<CSMsgBagGainEditionAwardReq>, IMessage, IEquatable<CSMsgBagGainEditionAwardReq>, IDeepCloneable<CSMsgBagGainEditionAwardReq>
{
	private static readonly MessageParser<CSMsgBagGainEditionAwardReq> _parser = new MessageParser<CSMsgBagGainEditionAwardReq>(() => new CSMsgBagGainEditionAwardReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagGainEditionAwardReq> Parser => _parser;

	public CSMsgBagGainEditionAwardReq()
	{
	}

	public CSMsgBagGainEditionAwardReq(CSMsgBagGainEditionAwardReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagGainEditionAwardReq Clone()
	{
		return new CSMsgBagGainEditionAwardReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagGainEditionAwardReq);
	}

	public bool Equals(CSMsgBagGainEditionAwardReq other)
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

	public void MergeFrom(CSMsgBagGainEditionAwardReq other)
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
