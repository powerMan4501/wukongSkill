using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnitEncounterRes : IMessage<CSMsgActorUnitEncounterRes>, IMessage, IEquatable<CSMsgActorUnitEncounterRes>, IDeepCloneable<CSMsgActorUnitEncounterRes>
{
	private static readonly MessageParser<CSMsgActorUnitEncounterRes> _parser = new MessageParser<CSMsgActorUnitEncounterRes>(() => new CSMsgActorUnitEncounterRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorUnitEncounterRes> Parser => _parser;

	public CSMsgActorUnitEncounterRes()
	{
	}

	public CSMsgActorUnitEncounterRes(CSMsgActorUnitEncounterRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnitEncounterRes Clone()
	{
		return new CSMsgActorUnitEncounterRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnitEncounterRes);
	}

	public bool Equals(CSMsgActorUnitEncounterRes other)
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

	public void MergeFrom(CSMsgActorUnitEncounterRes other)
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
