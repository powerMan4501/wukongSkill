using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DSkillData : IMessage<FUStB2DSkillData>, IMessage, IEquatable<FUStB2DSkillData>, IDeepCloneable<FUStB2DSkillData>
{
	private static readonly MessageParser<FUStB2DSkillData> _parser = new MessageParser<FUStB2DSkillData>(() => new FUStB2DSkillData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DSkillStage> _repeated_stageData_codec = FieldCodec.ForMessage(10u, FUStB2DSkillStage.Parser);

	private readonly RepeatedField<FUStB2DSkillStage> stageData_ = new RepeatedField<FUStB2DSkillStage>();

	private static readonly FieldCodec<FUStB2DComboSkill> _repeated_comboData_codec = FieldCodec.ForMessage(18u, FUStB2DComboSkill.Parser);

	private readonly RepeatedField<FUStB2DComboSkill> comboData_ = new RepeatedField<FUStB2DComboSkill>();

	public static MessageParser<FUStB2DSkillData> Parser => _parser;

	public RepeatedField<FUStB2DSkillStage> StageData => stageData_;

	public RepeatedField<FUStB2DComboSkill> ComboData => comboData_;

	public FUStB2DSkillData()
	{
	}

	public FUStB2DSkillData(FUStB2DSkillData other)
		: this()
	{
		stageData_ = other.stageData_.Clone();
		comboData_ = other.comboData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSkillData Clone()
	{
		return new FUStB2DSkillData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSkillData);
	}

	public bool Equals(FUStB2DSkillData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!stageData_.Equals(other.stageData_))
		{
			return false;
		}
		if (!comboData_.Equals(other.comboData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= stageData_.GetHashCode();
		num ^= comboData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		stageData_.WriteTo(output, _repeated_stageData_codec);
		comboData_.WriteTo(output, _repeated_comboData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += stageData_.CalculateSize(_repeated_stageData_codec);
		num += comboData_.CalculateSize(_repeated_comboData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSkillData other)
	{
		if (other != null)
		{
			stageData_.Add(other.stageData_);
			comboData_.Add(other.comboData_);
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
			case 10u:
				stageData_.AddEntriesFrom(input, _repeated_stageData_codec);
				break;
			case 18u:
				comboData_.AddEntriesFrom(input, _repeated_comboData_codec);
				break;
			}
		}
	}
}
