using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagSoulSkillUpgradeRes : IMessage<CSMsgBagSoulSkillUpgradeRes>, IMessage, IEquatable<CSMsgBagSoulSkillUpgradeRes>, IDeepCloneable<CSMsgBagSoulSkillUpgradeRes>
{
	private static readonly MessageParser<CSMsgBagSoulSkillUpgradeRes> _parser = new MessageParser<CSMsgBagSoulSkillUpgradeRes>(() => new CSMsgBagSoulSkillUpgradeRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagSoulSkillUpgradeRes> Parser => _parser;

	public CSMsgBagSoulSkillUpgradeRes()
	{
	}

	public CSMsgBagSoulSkillUpgradeRes(CSMsgBagSoulSkillUpgradeRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagSoulSkillUpgradeRes Clone()
	{
		return new CSMsgBagSoulSkillUpgradeRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagSoulSkillUpgradeRes);
	}

	public bool Equals(CSMsgBagSoulSkillUpgradeRes other)
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

	public void MergeFrom(CSMsgBagSoulSkillUpgradeRes other)
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
