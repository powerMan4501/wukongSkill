using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagWeaponBuildRes : IMessage<CSMsgBagWeaponBuildRes>, IMessage, IEquatable<CSMsgBagWeaponBuildRes>, IDeepCloneable<CSMsgBagWeaponBuildRes>
{
	private static readonly MessageParser<CSMsgBagWeaponBuildRes> _parser = new MessageParser<CSMsgBagWeaponBuildRes>(() => new CSMsgBagWeaponBuildRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagWeaponBuildRes> Parser => _parser;

	public CSMsgBagWeaponBuildRes()
	{
	}

	public CSMsgBagWeaponBuildRes(CSMsgBagWeaponBuildRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagWeaponBuildRes Clone()
	{
		return new CSMsgBagWeaponBuildRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagWeaponBuildRes);
	}

	public bool Equals(CSMsgBagWeaponBuildRes other)
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

	public void MergeFrom(CSMsgBagWeaponBuildRes other)
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
