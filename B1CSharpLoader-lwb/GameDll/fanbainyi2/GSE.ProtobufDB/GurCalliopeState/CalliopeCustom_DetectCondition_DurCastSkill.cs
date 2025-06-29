using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_DurCastSkill : IMessage<CalliopeCustom_DetectCondition_DurCastSkill>, IMessage, IEquatable<CalliopeCustom_DetectCondition_DurCastSkill>, IDeepCloneable<CalliopeCustom_DetectCondition_DurCastSkill>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_DurCastSkill> _parser = new MessageParser<CalliopeCustom_DetectCondition_DurCastSkill>(() => new CalliopeCustom_DetectCondition_DurCastSkill());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_skillIdList_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> skillIdList_ = new RepeatedField<int>();

	public static MessageParser<CalliopeCustom_DetectCondition_DurCastSkill> Parser => _parser;

	public RepeatedField<int> SkillIdList => skillIdList_;

	public CalliopeCustom_DetectCondition_DurCastSkill()
	{
	}

	public CalliopeCustom_DetectCondition_DurCastSkill(CalliopeCustom_DetectCondition_DurCastSkill other)
		: this()
	{
		skillIdList_ = other.skillIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_DurCastSkill Clone()
	{
		return new CalliopeCustom_DetectCondition_DurCastSkill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_DurCastSkill);
	}

	public bool Equals(CalliopeCustom_DetectCondition_DurCastSkill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!skillIdList_.Equals(other.skillIdList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= skillIdList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		skillIdList_.WriteTo(output, _repeated_skillIdList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += skillIdList_.CalculateSize(_repeated_skillIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_DurCastSkill other)
	{
		if (other != null)
		{
			skillIdList_.Add(other.skillIdList_);
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
				skillIdList_.AddEntriesFrom(input, _repeated_skillIdList_codec);
			}
		}
	}
}
