using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorSetSpellReq : IMessage<CSMsgActorSetSpellReq>, IMessage, IEquatable<CSMsgActorSetSpellReq>, IDeepCloneable<CSMsgActorSetSpellReq>
{
	private static readonly MessageParser<CSMsgActorSetSpellReq> _parser = new MessageParser<CSMsgActorSetSpellReq>(() => new CSMsgActorSetSpellReq());

	private UnknownFieldSet _unknownFields;

	private int spellId_;

	public static MessageParser<CSMsgActorSetSpellReq> Parser => _parser;

	public int SpellId
	{
		get
		{
			return spellId_;
		}
		set
		{
			spellId_ = value;
		}
	}

	public CSMsgActorSetSpellReq()
	{
	}

	public CSMsgActorSetSpellReq(CSMsgActorSetSpellReq other)
		: this()
	{
		spellId_ = other.spellId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorSetSpellReq Clone()
	{
		return new CSMsgActorSetSpellReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorSetSpellReq);
	}

	public bool Equals(CSMsgActorSetSpellReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SpellId != other.SpellId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SpellId != 0)
		{
			num ^= SpellId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SpellId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SpellId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SpellId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpellId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorSetSpellReq other)
	{
		if (other != null)
		{
			if (other.SpellId != 0)
			{
				SpellId = other.SpellId;
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
				SpellId = input.ReadInt32();
			}
		}
	}
}
