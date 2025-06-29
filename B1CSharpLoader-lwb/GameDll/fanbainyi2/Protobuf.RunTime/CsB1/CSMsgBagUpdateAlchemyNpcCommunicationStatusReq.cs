using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagUpdateAlchemyNpcCommunicationStatusReq : IMessage<CSMsgBagUpdateAlchemyNpcCommunicationStatusReq>, IMessage, IEquatable<CSMsgBagUpdateAlchemyNpcCommunicationStatusReq>, IDeepCloneable<CSMsgBagUpdateAlchemyNpcCommunicationStatusReq>
{
	private static readonly MessageParser<CSMsgBagUpdateAlchemyNpcCommunicationStatusReq> _parser = new MessageParser<CSMsgBagUpdateAlchemyNpcCommunicationStatusReq>(() => new CSMsgBagUpdateAlchemyNpcCommunicationStatusReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagUpdateAlchemyNpcCommunicationStatusReq> Parser => _parser;

	public CSMsgBagUpdateAlchemyNpcCommunicationStatusReq()
	{
	}

	public CSMsgBagUpdateAlchemyNpcCommunicationStatusReq(CSMsgBagUpdateAlchemyNpcCommunicationStatusReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagUpdateAlchemyNpcCommunicationStatusReq Clone()
	{
		return new CSMsgBagUpdateAlchemyNpcCommunicationStatusReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagUpdateAlchemyNpcCommunicationStatusReq);
	}

	public bool Equals(CSMsgBagUpdateAlchemyNpcCommunicationStatusReq other)
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

	public void MergeFrom(CSMsgBagUpdateAlchemyNpcCommunicationStatusReq other)
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
