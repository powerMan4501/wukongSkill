using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorSetSoulSkillRes : IMessage<CSMsgActorSetSoulSkillRes>, IMessage, IEquatable<CSMsgActorSetSoulSkillRes>, IDeepCloneable<CSMsgActorSetSoulSkillRes>
{
	private static readonly MessageParser<CSMsgActorSetSoulSkillRes> _parser = new MessageParser<CSMsgActorSetSoulSkillRes>(() => new CSMsgActorSetSoulSkillRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorSetSoulSkillRes> Parser => _parser;

	public CSMsgActorSetSoulSkillRes()
	{
	}

	public CSMsgActorSetSoulSkillRes(CSMsgActorSetSoulSkillRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorSetSoulSkillRes Clone()
	{
		return new CSMsgActorSetSoulSkillRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorSetSoulSkillRes);
	}

	public bool Equals(CSMsgActorSetSoulSkillRes other)
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

	public void MergeFrom(CSMsgActorSetSoulSkillRes other)
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
