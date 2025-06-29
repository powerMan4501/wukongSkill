using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSealingSpellSkillConfigDesc : IMessage<FUStSealingSpellSkillConfigDesc>, IMessage, IEquatable<FUStSealingSpellSkillConfigDesc>, IDeepCloneable<FUStSealingSpellSkillConfigDesc>
{
	private static readonly MessageParser<FUStSealingSpellSkillConfigDesc> _parser = new MessageParser<FUStSealingSpellSkillConfigDesc>(() => new FUStSealingSpellSkillConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private int durationMs_;

	private static readonly FieldCodec<int> _repeated_triggerBeginBuffIDs_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> triggerBeginBuffIDs_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_triggerLoppBuffIDs_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> triggerLoppBuffIDs_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_triggerSkillEffectIDs_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> triggerSkillEffectIDs_ = new RepeatedField<int>();

	public static MessageParser<FUStSealingSpellSkillConfigDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public int DurationMs
	{
		get
		{
			return durationMs_;
		}
		set
		{
			durationMs_ = value;
		}
	}

	public RepeatedField<int> TriggerBeginBuffIDs => triggerBeginBuffIDs_;

	public RepeatedField<int> TriggerLoppBuffIDs => triggerLoppBuffIDs_;

	public RepeatedField<int> TriggerSkillEffectIDs => triggerSkillEffectIDs_;

	public FUStSealingSpellSkillConfigDesc()
	{
	}

	public FUStSealingSpellSkillConfigDesc(FUStSealingSpellSkillConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		durationMs_ = other.durationMs_;
		triggerBeginBuffIDs_ = other.triggerBeginBuffIDs_.Clone();
		triggerLoppBuffIDs_ = other.triggerLoppBuffIDs_.Clone();
		triggerSkillEffectIDs_ = other.triggerSkillEffectIDs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSealingSpellSkillConfigDesc Clone()
	{
		return new FUStSealingSpellSkillConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSealingSpellSkillConfigDesc);
	}

	public bool Equals(FUStSealingSpellSkillConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (ResID != other.ResID)
		{
			return false;
		}
		if (DurationMs != other.DurationMs)
		{
			return false;
		}
		if (!triggerBeginBuffIDs_.Equals(other.triggerBeginBuffIDs_))
		{
			return false;
		}
		if (!triggerLoppBuffIDs_.Equals(other.triggerLoppBuffIDs_))
		{
			return false;
		}
		if (!triggerSkillEffectIDs_.Equals(other.triggerSkillEffectIDs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (DurationMs != 0)
		{
			num ^= DurationMs.GetHashCode();
		}
		num ^= triggerBeginBuffIDs_.GetHashCode();
		num ^= triggerLoppBuffIDs_.GetHashCode();
		num ^= triggerSkillEffectIDs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (ResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResID);
		}
		if (DurationMs != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DurationMs);
		}
		triggerBeginBuffIDs_.WriteTo(output, _repeated_triggerBeginBuffIDs_codec);
		triggerLoppBuffIDs_.WriteTo(output, _repeated_triggerLoppBuffIDs_codec);
		triggerSkillEffectIDs_.WriteTo(output, _repeated_triggerSkillEffectIDs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (DurationMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DurationMs);
		}
		num += triggerBeginBuffIDs_.CalculateSize(_repeated_triggerBeginBuffIDs_codec);
		num += triggerLoppBuffIDs_.CalculateSize(_repeated_triggerLoppBuffIDs_codec);
		num += triggerSkillEffectIDs_.CalculateSize(_repeated_triggerSkillEffectIDs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSealingSpellSkillConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.DurationMs != 0)
			{
				DurationMs = other.DurationMs;
			}
			triggerBeginBuffIDs_.Add(other.triggerBeginBuffIDs_);
			triggerLoppBuffIDs_.Add(other.triggerLoppBuffIDs_);
			triggerSkillEffectIDs_.Add(other.triggerSkillEffectIDs_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				ResID = input.ReadInt32();
				break;
			case 24u:
				DurationMs = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				triggerBeginBuffIDs_.AddEntriesFrom(input, _repeated_triggerBeginBuffIDs_codec);
				break;
			case 40u:
			case 42u:
				triggerLoppBuffIDs_.AddEntriesFrom(input, _repeated_triggerLoppBuffIDs_codec);
				break;
			case 48u:
			case 50u:
				triggerSkillEffectIDs_.AddEntriesFrom(input, _repeated_triggerSkillEffectIDs_codec);
				break;
			}
		}
	}
}
