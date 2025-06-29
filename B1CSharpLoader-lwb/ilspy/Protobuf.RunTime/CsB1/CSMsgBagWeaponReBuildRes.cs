using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagWeaponReBuildRes : IMessage<CSMsgBagWeaponReBuildRes>, IMessage, IEquatable<CSMsgBagWeaponReBuildRes>, IDeepCloneable<CSMsgBagWeaponReBuildRes>
{
	private static readonly MessageParser<CSMsgBagWeaponReBuildRes> _parser = new MessageParser<CSMsgBagWeaponReBuildRes>(() => new CSMsgBagWeaponReBuildRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagWeaponReBuildRes> Parser => _parser;

	public CSMsgBagWeaponReBuildRes()
	{
	}

	public CSMsgBagWeaponReBuildRes(CSMsgBagWeaponReBuildRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagWeaponReBuildRes Clone()
	{
		return new CSMsgBagWeaponReBuildRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagWeaponReBuildRes);
	}

	public bool Equals(CSMsgBagWeaponReBuildRes other)
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

	public void MergeFrom(CSMsgBagWeaponReBuildRes other)
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
