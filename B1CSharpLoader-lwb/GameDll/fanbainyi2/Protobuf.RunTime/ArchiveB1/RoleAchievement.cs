using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleAchievement : IMessage<RoleAchievement>, IMessage, IEquatable<RoleAchievement>, IDeepCloneable<RoleAchievement>
{
	private static readonly MessageParser<RoleAchievement> _parser = new MessageParser<RoleAchievement>(() => new RoleAchievement());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<AchievementOne> _repeated_achievements_codec = FieldCodec.ForMessage(26u, AchievementOne.Parser);

	private readonly RepeatedField<AchievementOne> achievements_ = new RepeatedField<AchievementOne>();

	private AchievementVersion achievementVersion_;

	public static MessageParser<RoleAchievement> Parser => _parser;

	public RepeatedField<AchievementOne> Achievements => achievements_;

	public AchievementVersion AchievementVersion
	{
		get
		{
			return achievementVersion_;
		}
		set
		{
			achievementVersion_ = value;
		}
	}

	public RoleAchievement()
	{
	}

	public RoleAchievement(RoleAchievement other)
		: this()
	{
		achievements_ = other.achievements_.Clone();
		achievementVersion_ = other.achievementVersion_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleAchievement Clone()
	{
		return new RoleAchievement(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleAchievement);
	}

	public bool Equals(RoleAchievement other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!achievements_.Equals(other.achievements_))
		{
			return false;
		}
		if (AchievementVersion != other.AchievementVersion)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= achievements_.GetHashCode();
		if (AchievementVersion != AchievementVersion.Default)
		{
			num ^= AchievementVersion.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		achievements_.WriteTo(output, _repeated_achievements_codec);
		if (AchievementVersion != AchievementVersion.Default)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)AchievementVersion);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += achievements_.CalculateSize(_repeated_achievements_codec);
		if (AchievementVersion != AchievementVersion.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AchievementVersion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleAchievement other)
	{
		if (other != null)
		{
			achievements_.Add(other.achievements_);
			if (other.AchievementVersion != AchievementVersion.Default)
			{
				AchievementVersion = other.AchievementVersion;
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
			case 26u:
				achievements_.AddEntriesFrom(input, _repeated_achievements_codec);
				break;
			case 32u:
				AchievementVersion = (AchievementVersion)input.ReadEnum();
				break;
			}
		}
	}
}
