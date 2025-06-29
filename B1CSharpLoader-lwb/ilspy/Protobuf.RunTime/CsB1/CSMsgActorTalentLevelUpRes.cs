using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorTalentLevelUpRes : IMessage<CSMsgActorTalentLevelUpRes>, IMessage, IEquatable<CSMsgActorTalentLevelUpRes>, IDeepCloneable<CSMsgActorTalentLevelUpRes>
{
	private static readonly MessageParser<CSMsgActorTalentLevelUpRes> _parser = new MessageParser<CSMsgActorTalentLevelUpRes>(() => new CSMsgActorTalentLevelUpRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorTalentLevelUpRes> Parser => _parser;

	public CSMsgActorTalentLevelUpRes()
	{
	}

	public CSMsgActorTalentLevelUpRes(CSMsgActorTalentLevelUpRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorTalentLevelUpRes Clone()
	{
		return new CSMsgActorTalentLevelUpRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorTalentLevelUpRes);
	}

	public bool Equals(CSMsgActorTalentLevelUpRes other)
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

	public void MergeFrom(CSMsgActorTalentLevelUpRes other)
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
