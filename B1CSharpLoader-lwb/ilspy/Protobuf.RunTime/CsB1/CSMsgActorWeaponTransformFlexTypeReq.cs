using System;
using ArchiveB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorWeaponTransformFlexTypeReq : IMessage<CSMsgActorWeaponTransformFlexTypeReq>, IMessage, IEquatable<CSMsgActorWeaponTransformFlexTypeReq>, IDeepCloneable<CSMsgActorWeaponTransformFlexTypeReq>
{
	private static readonly MessageParser<CSMsgActorWeaponTransformFlexTypeReq> _parser = new MessageParser<CSMsgActorWeaponTransformFlexTypeReq>(() => new CSMsgActorWeaponTransformFlexTypeReq());

	private UnknownFieldSet _unknownFields;

	private Stance stance_;

	public static MessageParser<CSMsgActorWeaponTransformFlexTypeReq> Parser => _parser;

	public Stance Stance
	{
		get
		{
			return stance_;
		}
		set
		{
			stance_ = value;
		}
	}

	public CSMsgActorWeaponTransformFlexTypeReq()
	{
	}

	public CSMsgActorWeaponTransformFlexTypeReq(CSMsgActorWeaponTransformFlexTypeReq other)
		: this()
	{
		stance_ = other.stance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorWeaponTransformFlexTypeReq Clone()
	{
		return new CSMsgActorWeaponTransformFlexTypeReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorWeaponTransformFlexTypeReq);
	}

	public bool Equals(CSMsgActorWeaponTransformFlexTypeReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Stance != other.Stance)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Stance != Stance.Heavy)
		{
			num ^= Stance.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Stance != Stance.Heavy)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Stance);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Stance != Stance.Heavy)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Stance);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorWeaponTransformFlexTypeReq other)
	{
		if (other != null)
		{
			if (other.Stance != Stance.Heavy)
			{
				Stance = other.Stance;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Stance = (Stance)input.ReadEnum();
			}
		}
	}
}
