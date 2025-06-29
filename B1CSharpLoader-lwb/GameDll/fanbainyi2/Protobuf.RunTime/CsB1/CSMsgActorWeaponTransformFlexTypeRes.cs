using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorWeaponTransformFlexTypeRes : IMessage<CSMsgActorWeaponTransformFlexTypeRes>, IMessage, IEquatable<CSMsgActorWeaponTransformFlexTypeRes>, IDeepCloneable<CSMsgActorWeaponTransformFlexTypeRes>
{
	private static readonly MessageParser<CSMsgActorWeaponTransformFlexTypeRes> _parser = new MessageParser<CSMsgActorWeaponTransformFlexTypeRes>(() => new CSMsgActorWeaponTransformFlexTypeRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorWeaponTransformFlexTypeRes> Parser => _parser;

	public CSMsgActorWeaponTransformFlexTypeRes()
	{
	}

	public CSMsgActorWeaponTransformFlexTypeRes(CSMsgActorWeaponTransformFlexTypeRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorWeaponTransformFlexTypeRes Clone()
	{
		return new CSMsgActorWeaponTransformFlexTypeRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorWeaponTransformFlexTypeRes);
	}

	public bool Equals(CSMsgActorWeaponTransformFlexTypeRes other)
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

	public void MergeFrom(CSMsgActorWeaponTransformFlexTypeRes other)
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
