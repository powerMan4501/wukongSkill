using System;
using Google.Protobuf;

namespace ResB1;

public sealed class PS5ActivityDesc : IMessage<PS5ActivityDesc>, IMessage, IEquatable<PS5ActivityDesc>, IDeepCloneable<PS5ActivityDesc>
{
	private static readonly MessageParser<PS5ActivityDesc> _parser = new MessageParser<PS5ActivityDesc>(() => new PS5ActivityDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private PS5ActivityCategory category_;

	private string description_ = "";

	private int estimatedPlayTime_;

	private YesNoType isRequiredForCompletion_;

	private YesNoType isAvaliableByDefault_;

	private YesNoType isHidden_;

	private int chapterId_;

	private int levelId_;

	private int localizationTag_;

	public static MessageParser<PS5ActivityDesc> Parser => _parser;

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

	public PS5ActivityCategory Category
	{
		get
		{
			return category_;
		}
		set
		{
			category_ = value;
		}
	}

	public string Description
	{
		get
		{
			return description_;
		}
		set
		{
			description_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int EstimatedPlayTime
	{
		get
		{
			return estimatedPlayTime_;
		}
		set
		{
			estimatedPlayTime_ = value;
		}
	}

	public YesNoType IsRequiredForCompletion
	{
		get
		{
			return isRequiredForCompletion_;
		}
		set
		{
			isRequiredForCompletion_ = value;
		}
	}

	public YesNoType IsAvaliableByDefault
	{
		get
		{
			return isAvaliableByDefault_;
		}
		set
		{
			isAvaliableByDefault_ = value;
		}
	}

	public YesNoType IsHidden
	{
		get
		{
			return isHidden_;
		}
		set
		{
			isHidden_ = value;
		}
	}

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
		}
	}

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
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

	public PS5ActivityDesc()
	{
	}

	public PS5ActivityDesc(PS5ActivityDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		category_ = other.category_;
		description_ = other.description_;
		estimatedPlayTime_ = other.estimatedPlayTime_;
		isRequiredForCompletion_ = other.isRequiredForCompletion_;
		isAvaliableByDefault_ = other.isAvaliableByDefault_;
		isHidden_ = other.isHidden_;
		chapterId_ = other.chapterId_;
		levelId_ = other.levelId_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PS5ActivityDesc Clone()
	{
		return new PS5ActivityDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PS5ActivityDesc);
	}

	public bool Equals(PS5ActivityDesc other)
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
		if (Category != other.Category)
		{
			return false;
		}
		if (Description != other.Description)
		{
			return false;
		}
		if (EstimatedPlayTime != other.EstimatedPlayTime)
		{
			return false;
		}
		if (IsRequiredForCompletion != other.IsRequiredForCompletion)
		{
			return false;
		}
		if (IsAvaliableByDefault != other.IsAvaliableByDefault)
		{
			return false;
		}
		if (IsHidden != other.IsHidden)
		{
			return false;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (Category != PS5ActivityCategory.Progress)
		{
			num ^= Category.GetHashCode();
		}
		if (Description.Length != 0)
		{
			num ^= Description.GetHashCode();
		}
		if (EstimatedPlayTime != 0)
		{
			num ^= EstimatedPlayTime.GetHashCode();
		}
		if (IsRequiredForCompletion != YesNoType.No)
		{
			num ^= IsRequiredForCompletion.GetHashCode();
		}
		if (IsAvaliableByDefault != YesNoType.No)
		{
			num ^= IsAvaliableByDefault.GetHashCode();
		}
		if (IsHidden != YesNoType.No)
		{
			num ^= IsHidden.GetHashCode();
		}
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Category != PS5ActivityCategory.Progress)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Category);
		}
		if (Description.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Description);
		}
		if (EstimatedPlayTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EstimatedPlayTime);
		}
		if (IsRequiredForCompletion != YesNoType.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)IsRequiredForCompletion);
		}
		if (IsAvaliableByDefault != YesNoType.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IsAvaliableByDefault);
		}
		if (IsHidden != YesNoType.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)IsHidden);
		}
		if (ChapterId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ChapterId);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(LevelId);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(LocalizationTag);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Category != PS5ActivityCategory.Progress)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Category);
		}
		if (Description.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Description);
		}
		if (EstimatedPlayTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EstimatedPlayTime);
		}
		if (IsRequiredForCompletion != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsRequiredForCompletion);
		}
		if (IsAvaliableByDefault != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsAvaliableByDefault);
		}
		if (IsHidden != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsHidden);
		}
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PS5ActivityDesc other)
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
			if (other.Category != PS5ActivityCategory.Progress)
			{
				Category = other.Category;
			}
			if (other.Description.Length != 0)
			{
				Description = other.Description;
			}
			if (other.EstimatedPlayTime != 0)
			{
				EstimatedPlayTime = other.EstimatedPlayTime;
			}
			if (other.IsRequiredForCompletion != YesNoType.No)
			{
				IsRequiredForCompletion = other.IsRequiredForCompletion;
			}
			if (other.IsAvaliableByDefault != YesNoType.No)
			{
				IsAvaliableByDefault = other.IsAvaliableByDefault;
			}
			if (other.IsHidden != YesNoType.No)
			{
				IsHidden = other.IsHidden;
			}
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				Category = (PS5ActivityCategory)input.ReadEnum();
				break;
			case 34u:
				Description = input.ReadString();
				break;
			case 40u:
				EstimatedPlayTime = input.ReadInt32();
				break;
			case 48u:
				IsRequiredForCompletion = (YesNoType)input.ReadEnum();
				break;
			case 56u:
				IsAvaliableByDefault = (YesNoType)input.ReadEnum();
				break;
			case 64u:
				IsHidden = (YesNoType)input.ReadEnum();
				break;
			case 72u:
				ChapterId = input.ReadInt32();
				break;
			case 80u:
				LevelId = input.ReadInt32();
				break;
			case 88u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
