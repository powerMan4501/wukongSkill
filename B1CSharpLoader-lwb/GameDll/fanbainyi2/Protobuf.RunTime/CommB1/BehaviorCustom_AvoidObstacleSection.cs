using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_AvoidObstacleSection : IMessage<BehaviorCustom_AvoidObstacleSection>, IMessage, IEquatable<BehaviorCustom_AvoidObstacleSection>, IDeepCloneable<BehaviorCustom_AvoidObstacleSection>
{
	private static readonly MessageParser<BehaviorCustom_AvoidObstacleSection> _parser = new MessageParser<BehaviorCustom_AvoidObstacleSection>(() => new BehaviorCustom_AvoidObstacleSection());

	private UnknownFieldSet _unknownFields;

	private float startAngle_;

	private float endAngle_;

	private static readonly FieldCodec<int> _repeated_skillList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> skillList_ = new RepeatedField<int>();

	public static MessageParser<BehaviorCustom_AvoidObstacleSection> Parser => _parser;

	public float StartAngle
	{
		get
		{
			return startAngle_;
		}
		set
		{
			startAngle_ = value;
		}
	}

	public float EndAngle
	{
		get
		{
			return endAngle_;
		}
		set
		{
			endAngle_ = value;
		}
	}

	public RepeatedField<int> SkillList => skillList_;

	public BehaviorCustom_AvoidObstacleSection()
	{
	}

	public BehaviorCustom_AvoidObstacleSection(BehaviorCustom_AvoidObstacleSection other)
		: this()
	{
		startAngle_ = other.startAngle_;
		endAngle_ = other.endAngle_;
		skillList_ = other.skillList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_AvoidObstacleSection Clone()
	{
		return new BehaviorCustom_AvoidObstacleSection(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_AvoidObstacleSection);
	}

	public bool Equals(BehaviorCustom_AvoidObstacleSection other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StartAngle, other.StartAngle))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EndAngle, other.EndAngle))
		{
			return false;
		}
		if (!skillList_.Equals(other.skillList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StartAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StartAngle);
		}
		if (EndAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EndAngle);
		}
		num ^= skillList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StartAngle != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(StartAngle);
		}
		if (EndAngle != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(EndAngle);
		}
		skillList_.WriteTo(output, _repeated_skillList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StartAngle != 0f)
		{
			num += 5;
		}
		if (EndAngle != 0f)
		{
			num += 5;
		}
		num += skillList_.CalculateSize(_repeated_skillList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_AvoidObstacleSection other)
	{
		if (other != null)
		{
			if (other.StartAngle != 0f)
			{
				StartAngle = other.StartAngle;
			}
			if (other.EndAngle != 0f)
			{
				EndAngle = other.EndAngle;
			}
			skillList_.Add(other.skillList_);
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
			case 13u:
				StartAngle = input.ReadFloat();
				break;
			case 21u:
				EndAngle = input.ReadFloat();
				break;
			case 24u:
			case 26u:
				skillList_.AddEntriesFrom(input, _repeated_skillList_codec);
				break;
			}
		}
	}
}
