using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class AchievementDesc : IMessage<AchievementDesc>, IMessage, IEquatable<AchievementDesc>, IDeepCloneable<AchievementDesc>
{
	private static readonly MessageParser<AchievementDesc> _parser = new MessageParser<AchievementDesc>(() => new AchievementDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private string achiDesc_ = "";

	private YesNoType isProgress_;

	private int localizationTag_;

	private YesNoType isResetOnGameplus_;

	private AchievementUnlockRequirement requirementType_;

	private RequirementHitType requirementHitType_;

	private static readonly FieldCodec<string> _repeated_requirementGuid_codec = FieldCodec.ForString(74u);

	private readonly RepeatedField<string> requirementGuid_ = new RepeatedField<string>();

	private static readonly FieldCodec<int> _repeated_requirementId_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> requirementId_ = new RepeatedField<int>();

	public static MessageParser<AchievementDesc> Parser => _parser;

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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AchiDesc
	{
		get
		{
			return achiDesc_;
		}
		set
		{
			achiDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public YesNoType IsProgress
	{
		get
		{
			return isProgress_;
		}
		set
		{
			isProgress_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public YesNoType IsResetOnGameplus
	{
		get
		{
			return isResetOnGameplus_;
		}
		set
		{
			isResetOnGameplus_ = value;
		}
	}

	public AchievementUnlockRequirement RequirementType
	{
		get
		{
			return requirementType_;
		}
		set
		{
			requirementType_ = value;
		}
	}

	public RequirementHitType RequirementHitType
	{
		get
		{
			return requirementHitType_;
		}
		set
		{
			requirementHitType_ = value;
		}
	}

	public RepeatedField<string> RequirementGuid => requirementGuid_;

	public RepeatedField<int> RequirementId => requirementId_;

	public AchievementDesc()
	{
	}

	public AchievementDesc(AchievementDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		achiDesc_ = other.achiDesc_;
		isProgress_ = other.isProgress_;
		localizationTag_ = other.localizationTag_;
		isResetOnGameplus_ = other.isResetOnGameplus_;
		requirementType_ = other.requirementType_;
		requirementHitType_ = other.requirementHitType_;
		requirementGuid_ = other.requirementGuid_.Clone();
		requirementId_ = other.requirementId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementDesc Clone()
	{
		return new AchievementDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementDesc);
	}

	public bool Equals(AchievementDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (AchiDesc != other.AchiDesc)
		{
			return false;
		}
		if (IsProgress != other.IsProgress)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (IsResetOnGameplus != other.IsResetOnGameplus)
		{
			return false;
		}
		if (RequirementType != other.RequirementType)
		{
			return false;
		}
		if (RequirementHitType != other.RequirementHitType)
		{
			return false;
		}
		if (!requirementGuid_.Equals(other.requirementGuid_))
		{
			return false;
		}
		if (!requirementId_.Equals(other.requirementId_))
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (AchiDesc.Length != 0)
		{
			num ^= AchiDesc.GetHashCode();
		}
		if (IsProgress != YesNoType.No)
		{
			num ^= IsProgress.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (IsResetOnGameplus != YesNoType.No)
		{
			num ^= IsResetOnGameplus.GetHashCode();
		}
		if (RequirementType != AchievementUnlockRequirement.None)
		{
			num ^= RequirementType.GetHashCode();
		}
		if (RequirementHitType != RequirementHitType.All)
		{
			num ^= RequirementHitType.GetHashCode();
		}
		num ^= requirementGuid_.GetHashCode();
		num ^= requirementId_.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (AchiDesc.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AchiDesc);
		}
		if (IsProgress != YesNoType.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)IsProgress);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(LocalizationTag);
		}
		if (IsResetOnGameplus != YesNoType.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)IsResetOnGameplus);
		}
		if (RequirementType != AchievementUnlockRequirement.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)RequirementType);
		}
		if (RequirementHitType != RequirementHitType.All)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)RequirementHitType);
		}
		requirementGuid_.WriteTo(output, _repeated_requirementGuid_codec);
		requirementId_.WriteTo(output, _repeated_requirementId_codec);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (AchiDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AchiDesc);
		}
		if (IsProgress != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsProgress);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (IsResetOnGameplus != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsResetOnGameplus);
		}
		if (RequirementType != AchievementUnlockRequirement.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RequirementType);
		}
		if (RequirementHitType != RequirementHitType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RequirementHitType);
		}
		num += requirementGuid_.CalculateSize(_repeated_requirementGuid_codec);
		num += requirementId_.CalculateSize(_repeated_requirementId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.AchiDesc.Length != 0)
			{
				AchiDesc = other.AchiDesc;
			}
			if (other.IsProgress != YesNoType.No)
			{
				IsProgress = other.IsProgress;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.IsResetOnGameplus != YesNoType.No)
			{
				IsResetOnGameplus = other.IsResetOnGameplus;
			}
			if (other.RequirementType != AchievementUnlockRequirement.None)
			{
				RequirementType = other.RequirementType;
			}
			if (other.RequirementHitType != RequirementHitType.All)
			{
				RequirementHitType = other.RequirementHitType;
			}
			requirementGuid_.Add(other.requirementGuid_);
			requirementId_.Add(other.requirementId_);
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
			case 18u:
				Name = input.ReadString();
				break;
			case 26u:
				AchiDesc = input.ReadString();
				break;
			case 32u:
				IsProgress = (YesNoType)input.ReadEnum();
				break;
			case 40u:
				LocalizationTag = input.ReadInt32();
				break;
			case 48u:
				IsResetOnGameplus = (YesNoType)input.ReadEnum();
				break;
			case 56u:
				RequirementType = (AchievementUnlockRequirement)input.ReadEnum();
				break;
			case 64u:
				RequirementHitType = (RequirementHitType)input.ReadEnum();
				break;
			case 74u:
				requirementGuid_.AddEntriesFrom(input, _repeated_requirementGuid_codec);
				break;
			case 80u:
			case 82u:
				requirementId_.AddEntriesFrom(input, _repeated_requirementId_codec);
				break;
			}
		}
	}
}
