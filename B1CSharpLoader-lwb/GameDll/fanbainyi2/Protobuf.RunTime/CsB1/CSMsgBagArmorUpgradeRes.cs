using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagArmorUpgradeRes : IMessage<CSMsgBagArmorUpgradeRes>, IMessage, IEquatable<CSMsgBagArmorUpgradeRes>, IDeepCloneable<CSMsgBagArmorUpgradeRes>
{
	private static readonly MessageParser<CSMsgBagArmorUpgradeRes> _parser = new MessageParser<CSMsgBagArmorUpgradeRes>(() => new CSMsgBagArmorUpgradeRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagArmorUpgradeRes> Parser => _parser;

	public CSMsgBagArmorUpgradeRes()
	{
	}

	public CSMsgBagArmorUpgradeRes(CSMsgBagArmorUpgradeRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagArmorUpgradeRes Clone()
	{
		return new CSMsgBagArmorUpgradeRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagArmorUpgradeRes);
	}

	public bool Equals(CSMsgBagArmorUpgradeRes other)
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

	public void MergeFrom(CSMsgBagArmorUpgradeRes other)
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
