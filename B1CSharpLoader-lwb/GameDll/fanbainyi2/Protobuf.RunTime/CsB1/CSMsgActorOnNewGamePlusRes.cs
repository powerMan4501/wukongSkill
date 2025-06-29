using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorOnNewGamePlusRes : IMessage<CSMsgActorOnNewGamePlusRes>, IMessage, IEquatable<CSMsgActorOnNewGamePlusRes>, IDeepCloneable<CSMsgActorOnNewGamePlusRes>
{
	private static readonly MessageParser<CSMsgActorOnNewGamePlusRes> _parser = new MessageParser<CSMsgActorOnNewGamePlusRes>(() => new CSMsgActorOnNewGamePlusRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorOnNewGamePlusRes> Parser => _parser;

	public CSMsgActorOnNewGamePlusRes()
	{
	}

	public CSMsgActorOnNewGamePlusRes(CSMsgActorOnNewGamePlusRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorOnNewGamePlusRes Clone()
	{
		return new CSMsgActorOnNewGamePlusRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorOnNewGamePlusRes);
	}

	public bool Equals(CSMsgActorOnNewGamePlusRes other)
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

	public void MergeFrom(CSMsgActorOnNewGamePlusRes other)
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
