using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class LoadingTipsDesc : IMessage<LoadingTipsDesc>, IMessage, IEquatable<LoadingTipsDesc>, IDeepCloneable<LoadingTipsDesc>
{
	private static readonly MessageParser<LoadingTipsDesc> _parser = new MessageParser<LoadingTipsDesc>(() => new LoadingTipsDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private TipsTriggerType tipsTriggerType_;

	private int keepTime_;

	private string title_ = "";

	private string content_ = "";

	private int imageId_;

	private int coolDownCount_;

	private int priority_;

	private TipsConditionRelationtype relationType_;

	private static readonly FieldCodec<TipsCondition> _repeated_condition_codec = FieldCodec.ForMessage(82u, TipsCondition.Parser);

	private readonly RepeatedField<TipsCondition> condition_ = new RepeatedField<TipsCondition>();

	private int localizationTag_;

	public static MessageParser<LoadingTipsDesc> Parser => _parser;

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

	public TipsTriggerType TipsTriggerType
	{
		get
		{
			return tipsTriggerType_;
		}
		set
		{
			tipsTriggerType_ = value;
		}
	}

	public int KeepTime
	{
		get
		{
			return keepTime_;
		}
		set
		{
			keepTime_ = value;
		}
	}

	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Content
	{
		get
		{
			return content_;
		}
		set
		{
			content_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ImageId
	{
		get
		{
			return imageId_;
		}
		set
		{
			imageId_ = value;
		}
	}

	public int CoolDownCount
	{
		get
		{
			return coolDownCount_;
		}
		set
		{
			coolDownCount_ = value;
		}
	}

	public int Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	public TipsConditionRelationtype RelationType
	{
		get
		{
			return relationType_;
		}
		set
		{
			relationType_ = value;
		}
	}

	public RepeatedField<TipsCondition> Condition => condition_;

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

	public LoadingTipsDesc()
	{
	}

	public LoadingTipsDesc(LoadingTipsDesc other)
		: this()
	{
		id_ = other.id_;
		tipsTriggerType_ = other.tipsTriggerType_;
		keepTime_ = other.keepTime_;
		title_ = other.title_;
		content_ = other.content_;
		imageId_ = other.imageId_;
		coolDownCount_ = other.coolDownCount_;
		priority_ = other.priority_;
		relationType_ = other.relationType_;
		condition_ = other.condition_.Clone();
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LoadingTipsDesc Clone()
	{
		return new LoadingTipsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LoadingTipsDesc);
	}

	public bool Equals(LoadingTipsDesc other)
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
		if (TipsTriggerType != other.TipsTriggerType)
		{
			return false;
		}
		if (KeepTime != other.KeepTime)
		{
			return false;
		}
		if (Title != other.Title)
		{
			return false;
		}
		if (Content != other.Content)
		{
			return false;
		}
		if (ImageId != other.ImageId)
		{
			return false;
		}
		if (CoolDownCount != other.CoolDownCount)
		{
			return false;
		}
		if (Priority != other.Priority)
		{
			return false;
		}
		if (RelationType != other.RelationType)
		{
			return false;
		}
		if (!condition_.Equals(other.condition_))
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
		if (TipsTriggerType != TipsTriggerType.None)
		{
			num ^= TipsTriggerType.GetHashCode();
		}
		if (KeepTime != 0)
		{
			num ^= KeepTime.GetHashCode();
		}
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (Content.Length != 0)
		{
			num ^= Content.GetHashCode();
		}
		if (ImageId != 0)
		{
			num ^= ImageId.GetHashCode();
		}
		if (CoolDownCount != 0)
		{
			num ^= CoolDownCount.GetHashCode();
		}
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
		}
		if (RelationType != TipsConditionRelationtype.And)
		{
			num ^= RelationType.GetHashCode();
		}
		num ^= condition_.GetHashCode();
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
		if (TipsTriggerType != TipsTriggerType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)TipsTriggerType);
		}
		if (KeepTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(KeepTime);
		}
		if (Title.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Title);
		}
		if (Content.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Content);
		}
		if (ImageId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ImageId);
		}
		if (CoolDownCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CoolDownCount);
		}
		if (Priority != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Priority);
		}
		if (RelationType != TipsConditionRelationtype.And)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)RelationType);
		}
		condition_.WriteTo(output, _repeated_condition_codec);
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
		if (TipsTriggerType != TipsTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TipsTriggerType);
		}
		if (KeepTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KeepTime);
		}
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (Content.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Content);
		}
		if (ImageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ImageId);
		}
		if (CoolDownCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CoolDownCount);
		}
		if (Priority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Priority);
		}
		if (RelationType != TipsConditionRelationtype.And)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RelationType);
		}
		num += condition_.CalculateSize(_repeated_condition_codec);
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

	public void MergeFrom(LoadingTipsDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TipsTriggerType != TipsTriggerType.None)
			{
				TipsTriggerType = other.TipsTriggerType;
			}
			if (other.KeepTime != 0)
			{
				KeepTime = other.KeepTime;
			}
			if (other.Title.Length != 0)
			{
				Title = other.Title;
			}
			if (other.Content.Length != 0)
			{
				Content = other.Content;
			}
			if (other.ImageId != 0)
			{
				ImageId = other.ImageId;
			}
			if (other.CoolDownCount != 0)
			{
				CoolDownCount = other.CoolDownCount;
			}
			if (other.Priority != 0)
			{
				Priority = other.Priority;
			}
			if (other.RelationType != TipsConditionRelationtype.And)
			{
				RelationType = other.RelationType;
			}
			condition_.Add(other.condition_);
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
			case 16u:
				TipsTriggerType = (TipsTriggerType)input.ReadEnum();
				break;
			case 24u:
				KeepTime = input.ReadInt32();
				break;
			case 34u:
				Title = input.ReadString();
				break;
			case 42u:
				Content = input.ReadString();
				break;
			case 48u:
				ImageId = input.ReadInt32();
				break;
			case 56u:
				CoolDownCount = input.ReadInt32();
				break;
			case 64u:
				Priority = input.ReadInt32();
				break;
			case 72u:
				RelationType = (TipsConditionRelationtype)input.ReadEnum();
				break;
			case 82u:
				condition_.AddEntriesFrom(input, _repeated_condition_codec);
				break;
			case 88u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
