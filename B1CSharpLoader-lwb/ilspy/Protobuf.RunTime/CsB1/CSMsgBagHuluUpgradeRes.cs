using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagHuluUpgradeRes : IMessage<CSMsgBagHuluUpgradeRes>, IMessage, IEquatable<CSMsgBagHuluUpgradeRes>, IDeepCloneable<CSMsgBagHuluUpgradeRes>
{
	private static readonly MessageParser<CSMsgBagHuluUpgradeRes> _parser = new MessageParser<CSMsgBagHuluUpgradeRes>(() => new CSMsgBagHuluUpgradeRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagHuluUpgradeRes> Parser => _parser;

	public CSMsgBagHuluUpgradeRes()
	{
	}

	public CSMsgBagHuluUpgradeRes(CSMsgBagHuluUpgradeRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagHuluUpgradeRes Clone()
	{
		return new CSMsgBagHuluUpgradeRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagHuluUpgradeRes);
	}

	public bool Equals(CSMsgBagHuluUpgradeRes other)
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

	public void MergeFrom(CSMsgBagHuluUpgradeRes other)
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
