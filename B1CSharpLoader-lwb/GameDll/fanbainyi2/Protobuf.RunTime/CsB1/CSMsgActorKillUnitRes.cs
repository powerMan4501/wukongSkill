using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorKillUnitRes : IMessage<CSMsgActorKillUnitRes>, IMessage, IEquatable<CSMsgActorKillUnitRes>, IDeepCloneable<CSMsgActorKillUnitRes>
{
	private static readonly MessageParser<CSMsgActorKillUnitRes> _parser = new MessageParser<CSMsgActorKillUnitRes>(() => new CSMsgActorKillUnitRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorKillUnitRes> Parser => _parser;

	public CSMsgActorKillUnitRes()
	{
	}

	public CSMsgActorKillUnitRes(CSMsgActorKillUnitRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorKillUnitRes Clone()
	{
		return new CSMsgActorKillUnitRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorKillUnitRes);
	}

	public bool Equals(CSMsgActorKillUnitRes other)
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

	public void MergeFrom(CSMsgActorKillUnitRes other)
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
