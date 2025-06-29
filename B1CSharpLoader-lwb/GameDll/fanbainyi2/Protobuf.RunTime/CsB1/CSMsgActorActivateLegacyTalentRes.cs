using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorActivateLegacyTalentRes : IMessage<CSMsgActorActivateLegacyTalentRes>, IMessage, IEquatable<CSMsgActorActivateLegacyTalentRes>, IDeepCloneable<CSMsgActorActivateLegacyTalentRes>
{
	private static readonly MessageParser<CSMsgActorActivateLegacyTalentRes> _parser = new MessageParser<CSMsgActorActivateLegacyTalentRes>(() => new CSMsgActorActivateLegacyTalentRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorActivateLegacyTalentRes> Parser => _parser;

	public CSMsgActorActivateLegacyTalentRes()
	{
	}

	public CSMsgActorActivateLegacyTalentRes(CSMsgActorActivateLegacyTalentRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorActivateLegacyTalentRes Clone()
	{
		return new CSMsgActorActivateLegacyTalentRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorActivateLegacyTalentRes);
	}

	public bool Equals(CSMsgActorActivateLegacyTalentRes other)
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

	public void MergeFrom(CSMsgActorActivateLegacyTalentRes other)
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
