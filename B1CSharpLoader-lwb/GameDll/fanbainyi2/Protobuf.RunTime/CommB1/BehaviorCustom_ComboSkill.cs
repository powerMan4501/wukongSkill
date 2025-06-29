using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_ComboSkill : IMessage<BehaviorCustom_ComboSkill>, IMessage, IEquatable<BehaviorCustom_ComboSkill>, IDeepCloneable<BehaviorCustom_ComboSkill>
{
	private static readonly MessageParser<BehaviorCustom_ComboSkill> _parser = new MessageParser<BehaviorCustom_ComboSkill>(() => new BehaviorCustom_ComboSkill());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_skillId_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> skillId_ = new RepeatedField<int>();

	public static MessageParser<BehaviorCustom_ComboSkill> Parser => _parser;

	public RepeatedField<int> SkillId => skillId_;

	public BehaviorCustom_ComboSkill()
	{
	}

	public BehaviorCustom_ComboSkill(BehaviorCustom_ComboSkill other)
		: this()
	{
		skillId_ = other.skillId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_ComboSkill Clone()
	{
		return new BehaviorCustom_ComboSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_ComboSkill);
	}

	public bool Equals(BehaviorCustom_ComboSkill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!skillId_.Equals(other.skillId_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= skillId_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		skillId_.WriteTo(output, _repeated_skillId_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += skillId_.CalculateSize(_repeated_skillId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_ComboSkill other)
	{
		if (other != null)
		{
			skillId_.Add(other.skillId_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				skillId_.AddEntriesFrom(input, _repeated_skillId_codec);
			}
		}
	}
}
