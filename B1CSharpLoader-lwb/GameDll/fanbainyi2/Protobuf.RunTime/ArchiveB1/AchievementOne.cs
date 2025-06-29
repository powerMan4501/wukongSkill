using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class AchievementOne : IMessage<AchievementOne>, IMessage, IEquatable<AchievementOne>, IDeepCloneable<AchievementOne>
{
	private static readonly MessageParser<AchievementOne> _parser = new MessageParser<AchievementOne>(() => new AchievementOne());

	private UnknownFieldSet _unknownFields;

	private AchievementConfig config_;

	private static readonly FieldCodec<int> _repeated_completeRequirementList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> completeRequirementList_ = new RepeatedField<int>();

	private bool isComplete_;

	private static readonly FieldCodec<string> _repeated_completeRequirementGuidList_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> completeRequirementGuidList_ = new RepeatedField<string>();

	public static MessageParser<AchievementOne> Parser => _parser;

	public AchievementConfig Config
	{
		get
		{
			return config_;
		}
		set
		{
			config_ = value;
		}
	}

	public RepeatedField<int> CompleteRequirementList => completeRequirementList_;

	public bool IsComplete
	{
		get
		{
			return isComplete_;
		}
		set
		{
			isComplete_ = value;
		}
	}

	public RepeatedField<string> CompleteRequirementGuidList => completeRequirementGuidList_;

	public AchievementOne()
	{
	}

	public AchievementOne(AchievementOne other)
		: this()
	{
		config_ = ((other.config_ != null) ? other.config_.Clone() : null);
		completeRequirementList_ = other.completeRequirementList_.Clone();
		isComplete_ = other.isComplete_;
		completeRequirementGuidList_ = other.completeRequirementGuidList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementOne Clone()
	{
		return new AchievementOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementOne);
	}

	public bool Equals(AchievementOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Config, other.Config))
		{
			return false;
		}
		if (!completeRequirementList_.Equals(other.completeRequirementList_))
		{
			return false;
		}
		if (IsComplete != other.IsComplete)
		{
			return false;
		}
		if (!completeRequirementGuidList_.Equals(other.completeRequirementGuidList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (config_ != null)
		{
			num ^= Config.GetHashCode();
		}
		num ^= completeRequirementList_.GetHashCode();
		if (IsComplete)
		{
			num ^= IsComplete.GetHashCode();
		}
		num ^= completeRequirementGuidList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (config_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Config);
		}
		completeRequirementList_.WriteTo(output, _repeated_completeRequirementList_codec);
		if (IsComplete)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsComplete);
		}
		completeRequirementGuidList_.WriteTo(output, _repeated_completeRequirementGuidList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (config_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Config);
		}
		num += completeRequirementList_.CalculateSize(_repeated_completeRequirementList_codec);
		if (IsComplete)
		{
			num += 2;
		}
		num += completeRequirementGuidList_.CalculateSize(_repeated_completeRequirementGuidList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementOne other)
	{
		if (other == null)
		{
			return;
		}
		if (other.config_ != null)
		{
			if (config_ == null)
			{
				Config = new AchievementConfig();
			}
			Config.MergeFrom(other.Config);
		}
		completeRequirementList_.Add(other.completeRequirementList_);
		if (other.IsComplete)
		{
			IsComplete = other.IsComplete;
		}
		completeRequirementGuidList_.Add(other.completeRequirementGuidList_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (config_ == null)
				{
					Config = new AchievementConfig();
				}
				input.ReadMessage(Config);
				break;
			case 16u:
			case 18u:
				completeRequirementList_.AddEntriesFrom(input, _repeated_completeRequirementList_codec);
				break;
			case 24u:
				IsComplete = input.ReadBool();
				break;
			case 34u:
				completeRequirementGuidList_.AddEntriesFrom(input, _repeated_completeRequirementGuidList_codec);
				break;
			}
		}
	}
}
