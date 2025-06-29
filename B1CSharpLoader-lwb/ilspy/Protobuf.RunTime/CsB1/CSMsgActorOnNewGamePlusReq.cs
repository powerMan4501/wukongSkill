using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorOnNewGamePlusReq : IMessage<CSMsgActorOnNewGamePlusReq>, IMessage, IEquatable<CSMsgActorOnNewGamePlusReq>, IDeepCloneable<CSMsgActorOnNewGamePlusReq>
{
	private static readonly MessageParser<CSMsgActorOnNewGamePlusReq> _parser = new MessageParser<CSMsgActorOnNewGamePlusReq>(() => new CSMsgActorOnNewGamePlusReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorOnNewGamePlusReq> Parser => _parser;

	public CSMsgActorOnNewGamePlusReq()
	{
	}

	public CSMsgActorOnNewGamePlusReq(CSMsgActorOnNewGamePlusReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorOnNewGamePlusReq Clone()
	{
		return new CSMsgActorOnNewGamePlusReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorOnNewGamePlusReq);
	}

	public bool Equals(CSMsgActorOnNewGamePlusReq other)
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

	public void MergeFrom(CSMsgActorOnNewGamePlusReq other)
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
