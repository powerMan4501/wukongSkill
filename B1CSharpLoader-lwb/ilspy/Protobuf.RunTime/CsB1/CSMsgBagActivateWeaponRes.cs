using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagActivateWeaponRes : IMessage<CSMsgBagActivateWeaponRes>, IMessage, IEquatable<CSMsgBagActivateWeaponRes>, IDeepCloneable<CSMsgBagActivateWeaponRes>
{
	private static readonly MessageParser<CSMsgBagActivateWeaponRes> _parser = new MessageParser<CSMsgBagActivateWeaponRes>(() => new CSMsgBagActivateWeaponRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagActivateWeaponRes> Parser => _parser;

	public CSMsgBagActivateWeaponRes()
	{
	}

	public CSMsgBagActivateWeaponRes(CSMsgBagActivateWeaponRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagActivateWeaponRes Clone()
	{
		return new CSMsgBagActivateWeaponRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagActivateWeaponRes);
	}

	public bool Equals(CSMsgBagActivateWeaponRes other)
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

	public void MergeFrom(CSMsgBagActivateWeaponRes other)
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
