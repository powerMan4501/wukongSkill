using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStAISkillTagsDesc : IMessage<FUStAISkillTagsDesc>, IMessage, IEquatable<FUStAISkillTagsDesc>, IDeepCloneable<FUStAISkillTagsDesc>
{
	private static readonly MessageParser<FUStAISkillTagsDesc> _parser = new MessageParser<FUStAISkillTagsDesc>(() => new FUStAISkillTagsDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo isMappedSkill_;

	private float minRange_;

	private float maxRange_;

	private static readonly FieldCodec<EActionTagType> _repeated_actionTags_codec = FieldCodec.ForEnum(42u, (EActionTagType x) => (int)x, (int x) => (EActionTagType)x);

	private readonly RepeatedField<EActionTagType> actionTags_ = new RepeatedField<EActionTagType>();

	public static MessageParser<FUStAISkillTagsDesc> Parser => _parser;

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

	public EGSYesNo IsMappedSkill
	{
		get
		{
			return isMappedSkill_;
		}
		set
		{
			isMappedSkill_ = value;
		}
	}

	public float MinRange
	{
		get
		{
			return minRange_;
		}
		set
		{
			minRange_ = value;
		}
	}

	public float MaxRange
	{
		get
		{
			return maxRange_;
		}
		set
		{
			maxRange_ = value;
		}
	}

	public RepeatedField<EActionTagType> ActionTags => actionTags_;

	public FUStAISkillTagsDesc()
	{
	}

	public FUStAISkillTagsDesc(FUStAISkillTagsDesc other)
		: this()
	{
		iD_ = other.iD_;
		isMappedSkill_ = other.isMappedSkill_;
		minRange_ = other.minRange_;
		maxRange_ = other.maxRange_;
		actionTags_ = other.actionTags_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAISkillTagsDesc Clone()
	{
		return new FUStAISkillTagsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAISkillTagsDesc);
	}

	public bool Equals(FUStAISkillTagsDesc other)
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
		if (IsMappedSkill != other.IsMappedSkill)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinRange, other.MinRange))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxRange, other.MaxRange))
		{
			return false;
		}
		if (!actionTags_.Equals(other.actionTags_))
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
		if (IsMappedSkill != EGSYesNo.No)
		{
			num ^= IsMappedSkill.GetHashCode();
		}
		if (MinRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinRange);
		}
		if (MaxRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxRange);
		}
		num ^= actionTags_.GetHashCode();
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
		if (IsMappedSkill != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsMappedSkill);
		}
		if (MinRange != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(MinRange);
		}
		if (MaxRange != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(MaxRange);
		}
		actionTags_.WriteTo(output, _repeated_actionTags_codec);
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
		if (IsMappedSkill != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsMappedSkill);
		}
		if (MinRange != 0f)
		{
			num += 5;
		}
		if (MaxRange != 0f)
		{
			num += 5;
		}
		num += actionTags_.CalculateSize(_repeated_actionTags_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAISkillTagsDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IsMappedSkill != EGSYesNo.No)
			{
				IsMappedSkill = other.IsMappedSkill;
			}
			if (other.MinRange != 0f)
			{
				MinRange = other.MinRange;
			}
			if (other.MaxRange != 0f)
			{
				MaxRange = other.MaxRange;
			}
			actionTags_.Add(other.actionTags_);
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
				IsMappedSkill = (EGSYesNo)input.ReadEnum();
				break;
			case 29u:
				MinRange = input.ReadFloat();
				break;
			case 37u:
				MaxRange = input.ReadFloat();
				break;
			case 40u:
			case 42u:
				actionTags_.AddEntriesFrom(input, _repeated_actionTags_codec);
				break;
			}
		}
	}
}
