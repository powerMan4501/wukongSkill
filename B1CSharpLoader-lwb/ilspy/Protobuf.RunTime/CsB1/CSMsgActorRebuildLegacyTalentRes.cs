using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorRebuildLegacyTalentRes : IMessage<CSMsgActorRebuildLegacyTalentRes>, IMessage, IEquatable<CSMsgActorRebuildLegacyTalentRes>, IDeepCloneable<CSMsgActorRebuildLegacyTalentRes>
{
	private static readonly MessageParser<CSMsgActorRebuildLegacyTalentRes> _parser = new MessageParser<CSMsgActorRebuildLegacyTalentRes>(() => new CSMsgActorRebuildLegacyTalentRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorRebuildLegacyTalentRes> Parser => _parser;

	public CSMsgActorRebuildLegacyTalentRes()
	{
	}

	public CSMsgActorRebuildLegacyTalentRes(CSMsgActorRebuildLegacyTalentRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorRebuildLegacyTalentRes Clone()
	{
		return new CSMsgActorRebuildLegacyTalentRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorRebuildLegacyTalentRes);
	}

	public bool Equals(CSMsgActorRebuildLegacyTalentRes other)
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

	public void MergeFrom(CSMsgActorRebuildLegacyTalentRes other)
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
