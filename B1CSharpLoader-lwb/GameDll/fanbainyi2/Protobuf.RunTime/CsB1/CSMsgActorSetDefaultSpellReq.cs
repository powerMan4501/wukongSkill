using System;
using BtlB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorSetDefaultSpellReq : IMessage<CSMsgActorSetDefaultSpellReq>, IMessage, IEquatable<CSMsgActorSetDefaultSpellReq>, IDeepCloneable<CSMsgActorSetDefaultSpellReq>
{
	private static readonly MessageParser<CSMsgActorSetDefaultSpellReq> _parser = new MessageParser<CSMsgActorSetDefaultSpellReq>(() => new CSMsgActorSetDefaultSpellReq());

	private UnknownFieldSet _unknownFields;

	private SpellType spellType_;

	public static MessageParser<CSMsgActorSetDefaultSpellReq> Parser => _parser;

	public SpellType SpellType
	{
		get
		{
			return spellType_;
		}
		set
		{
			spellType_ = value;
		}
	}

	public CSMsgActorSetDefaultSpellReq()
	{
	}

	public CSMsgActorSetDefaultSpellReq(CSMsgActorSetDefaultSpellReq other)
		: this()
	{
		spellType_ = other.spellType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorSetDefaultSpellReq Clone()
	{
		return new CSMsgActorSetDefaultSpellReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorSetDefaultSpellReq);
	}

	public bool Equals(CSMsgActorSetDefaultSpellReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SpellType != other.SpellType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SpellType != SpellType.Min)
		{
			num ^= SpellType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SpellType != SpellType.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)SpellType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SpellType != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SpellType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorSetDefaultSpellReq other)
	{
		if (other != null)
		{
			if (other.SpellType != SpellType.Min)
			{
				SpellType = other.SpellType;
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
				SpellType = (SpellType)input.ReadEnum();
			}
		}
	}
}
