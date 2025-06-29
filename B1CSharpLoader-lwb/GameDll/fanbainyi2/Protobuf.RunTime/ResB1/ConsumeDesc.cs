using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class ConsumeDesc : IMessage<ConsumeDesc>, IMessage, IEquatable<ConsumeDesc>, IDeepCloneable<ConsumeDesc>
{
	private static readonly MessageParser<ConsumeDesc> _parser = new MessageParser<ConsumeDesc>(() => new ConsumeDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private ConsumeType type_;

	private int skillId_;

	private static readonly FieldCodec<ConsumeEffect> _repeated_consumeEffect_codec = FieldCodec.ForMessage(34u, ResB1.ConsumeEffect.Parser);

	private readonly RepeatedField<ConsumeEffect> consumeEffect_ = new RepeatedField<ConsumeEffect>();

	private YesNoType skipAutoWear_;

	private YesNoType isMedicinalMaterials_;

	private int winePartnerTrigger_;

	private int cantUseInBossRoom_;

	public static MessageParser<ConsumeDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public ConsumeType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public int SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	public RepeatedField<ConsumeEffect> ConsumeEffect => consumeEffect_;

	public YesNoType SkipAutoWear
	{
		get
		{
			return skipAutoWear_;
		}
		set
		{
			skipAutoWear_ = value;
		}
	}

	public YesNoType IsMedicinalMaterials
	{
		get
		{
			return isMedicinalMaterials_;
		}
		set
		{
			isMedicinalMaterials_ = value;
		}
	}

	public int WinePartnerTrigger
	{
		get
		{
			return winePartnerTrigger_;
		}
		set
		{
			winePartnerTrigger_ = value;
		}
	}

	public int CantUseInBossRoom
	{
		get
		{
			return cantUseInBossRoom_;
		}
		set
		{
			cantUseInBossRoom_ = value;
		}
	}

	public ConsumeDesc()
	{
	}

	public ConsumeDesc(ConsumeDesc other)
		: this()
	{
		id_ = other.id_;
		type_ = other.type_;
		skillId_ = other.skillId_;
		consumeEffect_ = other.consumeEffect_.Clone();
		skipAutoWear_ = other.skipAutoWear_;
		isMedicinalMaterials_ = other.isMedicinalMaterials_;
		winePartnerTrigger_ = other.winePartnerTrigger_;
		cantUseInBossRoom_ = other.cantUseInBossRoom_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ConsumeDesc Clone()
	{
		return new ConsumeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ConsumeDesc);
	}

	public bool Equals(ConsumeDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (!consumeEffect_.Equals(other.consumeEffect_))
		{
			return false;
		}
		if (SkipAutoWear != other.SkipAutoWear)
		{
			return false;
		}
		if (IsMedicinalMaterials != other.IsMedicinalMaterials)
		{
			return false;
		}
		if (WinePartnerTrigger != other.WinePartnerTrigger)
		{
			return false;
		}
		if (CantUseInBossRoom != other.CantUseInBossRoom)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Type != ConsumeType.None)
		{
			num ^= Type.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		num ^= consumeEffect_.GetHashCode();
		if (SkipAutoWear != YesNoType.No)
		{
			num ^= SkipAutoWear.GetHashCode();
		}
		if (IsMedicinalMaterials != YesNoType.No)
		{
			num ^= IsMedicinalMaterials.GetHashCode();
		}
		if (WinePartnerTrigger != 0)
		{
			num ^= WinePartnerTrigger.GetHashCode();
		}
		if (CantUseInBossRoom != 0)
		{
			num ^= CantUseInBossRoom.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Type != ConsumeType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SkillId);
		}
		consumeEffect_.WriteTo(output, _repeated_consumeEffect_codec);
		if (SkipAutoWear != YesNoType.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)SkipAutoWear);
		}
		if (IsMedicinalMaterials != YesNoType.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)IsMedicinalMaterials);
		}
		if (WinePartnerTrigger != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(WinePartnerTrigger);
		}
		if (CantUseInBossRoom != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(CantUseInBossRoom);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Type != ConsumeType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		num += consumeEffect_.CalculateSize(_repeated_consumeEffect_codec);
		if (SkipAutoWear != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkipAutoWear);
		}
		if (IsMedicinalMaterials != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsMedicinalMaterials);
		}
		if (WinePartnerTrigger != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WinePartnerTrigger);
		}
		if (CantUseInBossRoom != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CantUseInBossRoom);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ConsumeDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Type != ConsumeType.None)
			{
				Type = other.Type;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			consumeEffect_.Add(other.consumeEffect_);
			if (other.SkipAutoWear != YesNoType.No)
			{
				SkipAutoWear = other.SkipAutoWear;
			}
			if (other.IsMedicinalMaterials != YesNoType.No)
			{
				IsMedicinalMaterials = other.IsMedicinalMaterials;
			}
			if (other.WinePartnerTrigger != 0)
			{
				WinePartnerTrigger = other.WinePartnerTrigger;
			}
			if (other.CantUseInBossRoom != 0)
			{
				CantUseInBossRoom = other.CantUseInBossRoom;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
				Type = (ConsumeType)input.ReadEnum();
				break;
			case 24u:
				SkillId = input.ReadInt32();
				break;
			case 34u:
				consumeEffect_.AddEntriesFrom(input, _repeated_consumeEffect_codec);
				break;
			case 40u:
				SkipAutoWear = (YesNoType)input.ReadEnum();
				break;
			case 48u:
				IsMedicinalMaterials = (YesNoType)input.ReadEnum();
				break;
			case 56u:
				WinePartnerTrigger = input.ReadInt32();
				break;
			case 64u:
				CantUseInBossRoom = input.ReadInt32();
				break;
			}
		}
	}
}
