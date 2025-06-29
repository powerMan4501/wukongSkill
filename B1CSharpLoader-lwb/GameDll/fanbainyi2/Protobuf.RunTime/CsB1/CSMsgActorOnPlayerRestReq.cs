using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorOnPlayerRestReq : IMessage<CSMsgActorOnPlayerRestReq>, IMessage, IEquatable<CSMsgActorOnPlayerRestReq>, IDeepCloneable<CSMsgActorOnPlayerRestReq>
{
	private static readonly MessageParser<CSMsgActorOnPlayerRestReq> _parser = new MessageParser<CSMsgActorOnPlayerRestReq>(() => new CSMsgActorOnPlayerRestReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorOnPlayerRestReq> Parser => _parser;

	public CSMsgActorOnPlayerRestReq()
	{
	}

	public CSMsgActorOnPlayerRestReq(CSMsgActorOnPlayerRestReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorOnPlayerRestReq Clone()
	{
		return new CSMsgActorOnPlayerRestReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorOnPlayerRestReq);
	}

	public bool Equals(CSMsgActorOnPlayerRestReq other)
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

	public void MergeFrom(CSMsgActorOnPlayerRestReq other)
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
