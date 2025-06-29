using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagGetAlchemyNpcCommunicationAwardReq : IMessage<CSMsgBagGetAlchemyNpcCommunicationAwardReq>, IMessage, IEquatable<CSMsgBagGetAlchemyNpcCommunicationAwardReq>, IDeepCloneable<CSMsgBagGetAlchemyNpcCommunicationAwardReq>
{
	private static readonly MessageParser<CSMsgBagGetAlchemyNpcCommunicationAwardReq> _parser = new MessageParser<CSMsgBagGetAlchemyNpcCommunicationAwardReq>(() => new CSMsgBagGetAlchemyNpcCommunicationAwardReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagGetAlchemyNpcCommunicationAwardReq> Parser => _parser;

	public CSMsgBagGetAlchemyNpcCommunicationAwardReq()
	{
	}

	public CSMsgBagGetAlchemyNpcCommunicationAwardReq(CSMsgBagGetAlchemyNpcCommunicationAwardReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagGetAlchemyNpcCommunicationAwardReq Clone()
	{
		return new CSMsgBagGetAlchemyNpcCommunicationAwardReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagGetAlchemyNpcCommunicationAwardReq);
	}

	public bool Equals(CSMsgBagGetAlchemyNpcCommunicationAwardReq other)
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

	public void MergeFrom(CSMsgBagGetAlchemyNpcCommunicationAwardReq other)
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
