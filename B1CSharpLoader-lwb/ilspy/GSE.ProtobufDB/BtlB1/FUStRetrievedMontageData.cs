using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStRetrievedMontageData : IMessage<FUStRetrievedMontageData>, IMessage, IEquatable<FUStRetrievedMontageData>, IDeepCloneable<FUStRetrievedMontageData>
{
	private static readonly MessageParser<FUStRetrievedMontageData> _parser = new MessageParser<FUStRetrievedMontageData>(() => new FUStRetrievedMontageData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStTriggerEffectData> _repeated_triggerEffectData_codec = FieldCodec.ForMessage(10u, FUStTriggerEffectData.Parser);

	private readonly RepeatedField<FUStTriggerEffectData> triggerEffectData_ = new RepeatedField<FUStTriggerEffectData>();

	private static readonly FieldCodec<FUStAddBuffByIdData> _repeated_addBuffByIdData_codec = FieldCodec.ForMessage(18u, FUStAddBuffByIdData.Parser);

	private readonly RepeatedField<FUStAddBuffByIdData> addBuffByIdData_ = new RepeatedField<FUStAddBuffByIdData>();

	private static readonly FieldCodec<FUStCostAttrBySkillEffectData> _repeated_costAttrBySkillEffectData_codec = FieldCodec.ForMessage(26u, FUStCostAttrBySkillEffectData.Parser);

	private readonly RepeatedField<FUStCostAttrBySkillEffectData> costAttrBySkillEffectData_ = new RepeatedField<FUStCostAttrBySkillEffectData>();

	private static readonly FieldCodec<FUStSpawnBulletsData> _repeated_spawnBulletsData_codec = FieldCodec.ForMessage(34u, FUStSpawnBulletsData.Parser);

	private readonly RepeatedField<FUStSpawnBulletsData> spawnBulletsData_ = new RepeatedField<FUStSpawnBulletsData>();

	public static MessageParser<FUStRetrievedMontageData> Parser => _parser;

	public RepeatedField<FUStTriggerEffectData> TriggerEffectData => triggerEffectData_;

	public RepeatedField<FUStAddBuffByIdData> AddBuffByIdData => addBuffByIdData_;

	public RepeatedField<FUStCostAttrBySkillEffectData> CostAttrBySkillEffectData => costAttrBySkillEffectData_;

	public RepeatedField<FUStSpawnBulletsData> SpawnBulletsData => spawnBulletsData_;

	public FUStRetrievedMontageData()
	{
	}

	public FUStRetrievedMontageData(FUStRetrievedMontageData other)
		: this()
	{
		triggerEffectData_ = other.triggerEffectData_.Clone();
		addBuffByIdData_ = other.addBuffByIdData_.Clone();
		costAttrBySkillEffectData_ = other.costAttrBySkillEffectData_.Clone();
		spawnBulletsData_ = other.spawnBulletsData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStRetrievedMontageData Clone()
	{
		return new FUStRetrievedMontageData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStRetrievedMontageData);
	}

	public bool Equals(FUStRetrievedMontageData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!triggerEffectData_.Equals(other.triggerEffectData_))
		{
			return false;
		}
		if (!addBuffByIdData_.Equals(other.addBuffByIdData_))
		{
			return false;
		}
		if (!costAttrBySkillEffectData_.Equals(other.costAttrBySkillEffectData_))
		{
			return false;
		}
		if (!spawnBulletsData_.Equals(other.spawnBulletsData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= triggerEffectData_.GetHashCode();
		num ^= addBuffByIdData_.GetHashCode();
		num ^= costAttrBySkillEffectData_.GetHashCode();
		num ^= spawnBulletsData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		triggerEffectData_.WriteTo(output, _repeated_triggerEffectData_codec);
		addBuffByIdData_.WriteTo(output, _repeated_addBuffByIdData_codec);
		costAttrBySkillEffectData_.WriteTo(output, _repeated_costAttrBySkillEffectData_codec);
		spawnBulletsData_.WriteTo(output, _repeated_spawnBulletsData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += triggerEffectData_.CalculateSize(_repeated_triggerEffectData_codec);
		num += addBuffByIdData_.CalculateSize(_repeated_addBuffByIdData_codec);
		num += costAttrBySkillEffectData_.CalculateSize(_repeated_costAttrBySkillEffectData_codec);
		num += spawnBulletsData_.CalculateSize(_repeated_spawnBulletsData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStRetrievedMontageData other)
	{
		if (other != null)
		{
			triggerEffectData_.Add(other.triggerEffectData_);
			addBuffByIdData_.Add(other.addBuffByIdData_);
			costAttrBySkillEffectData_.Add(other.costAttrBySkillEffectData_);
			spawnBulletsData_.Add(other.spawnBulletsData_);
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
				triggerEffectData_.AddEntriesFrom(input, _repeated_triggerEffectData_codec);
				break;
			case 18u:
				addBuffByIdData_.AddEntriesFrom(input, _repeated_addBuffByIdData_codec);
				break;
			case 26u:
				costAttrBySkillEffectData_.AddEntriesFrom(input, _repeated_costAttrBySkillEffectData_codec);
				break;
			case 34u:
				spawnBulletsData_.AddEntriesFrom(input, _repeated_spawnBulletsData_codec);
				break;
			}
		}
	}
}
