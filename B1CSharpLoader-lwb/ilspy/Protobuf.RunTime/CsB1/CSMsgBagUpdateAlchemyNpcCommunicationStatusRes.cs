using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagUpdateAlchemyNpcCommunicationStatusRes : IMessage<CSMsgBagUpdateAlchemyNpcCommunicationStatusRes>, IMessage, IEquatable<CSMsgBagUpdateAlchemyNpcCommunicationStatusRes>, IDeepCloneable<CSMsgBagUpdateAlchemyNpcCommunicationStatusRes>
{
	private static readonly MessageParser<CSMsgBagUpdateAlchemyNpcCommunicationStatusRes> _parser = new MessageParser<CSMsgBagUpdateAlchemyNpcCommunicationStatusRes>(() => new CSMsgBagUpdateAlchemyNpcCommunicationStatusRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagUpdateAlchemyNpcCommunicationStatusRes> Parser => _parser;

	public CSMsgBagUpdateAlchemyNpcCommunicationStatusRes()
	{
	}

	public CSMsgBagUpdateAlchemyNpcCommunicationStatusRes(CSMsgBagUpdateAlchemyNpcCommunicationStatusRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagUpdateAlchemyNpcCommunicationStatusRes Clone()
	{
		return new CSMsgBagUpdateAlchemyNpcCommunicationStatusRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagUpdateAlchemyNpcCommunicationStatusRes);
	}

	public bool Equals(CSMsgBagUpdateAlchemyNpcCommunicationStatusRes other)
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

	public void MergeFrom(CSMsgBagUpdateAlchemyNpcCommunicationStatusRes other)
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
