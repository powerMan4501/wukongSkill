using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSkillSMappingDesc : IMessage<FUStSkillSMappingDesc>, IMessage, IEquatable<FUStSkillSMappingDesc>, IDeepCloneable<FUStSkillSMappingDesc>
{
	private static readonly MessageParser<FUStSkillSMappingDesc> _parser = new MessageParser<FUStSkillSMappingDesc>(() => new FUStSkillSMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo canCyclicMapping_;

	private ESkillMappingResultRull resultRull_;

	private static readonly FieldCodec<SkillMappingConfig> _repeated_mappingConfigList_codec = FieldCodec.ForMessage(34u, SkillMappingConfig.Parser);

	private readonly RepeatedField<SkillMappingConfig> mappingConfigList_ = new RepeatedField<SkillMappingConfig>();

	public static MessageParser<FUStSkillSMappingDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EGSYesNo CanCyclicMapping
	{
		get
		{
			return canCyclicMapping_;
		}
		set
		{
			canCyclicMapping_ = value;
		}
	}

	public ESkillMappingResultRull ResultRull
	{
		get
		{
			return resultRull_;
		}
		set
		{
			resultRull_ = value;
		}
	}

	public RepeatedField<SkillMappingConfig> MappingConfigList => mappingConfigList_;

	public FUStSkillSMappingDesc()
	{
	}

	public FUStSkillSMappingDesc(FUStSkillSMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		canCyclicMapping_ = other.canCyclicMapping_;
		resultRull_ = other.resultRull_;
		mappingConfigList_ = other.mappingConfigList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSkillSMappingDesc Clone()
	{
		return new FUStSkillSMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSkillSMappingDesc);
	}

	public bool Equals(FUStSkillSMappingDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (CanCyclicMapping != other.CanCyclicMapping)
		{
			return false;
		}
		if (ResultRull != other.ResultRull)
		{
			return false;
		}
		if (!mappingConfigList_.Equals(other.mappingConfigList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (CanCyclicMapping != EGSYesNo.No)
		{
			num ^= CanCyclicMapping.GetHashCode();
		}
		if (ResultRull != ESkillMappingResultRull.PseudoRandom)
		{
			num ^= ResultRull.GetHashCode();
		}
		num ^= mappingConfigList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (CanCyclicMapping != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)CanCyclicMapping);
		}
		if (ResultRull != ESkillMappingResultRull.PseudoRandom)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ResultRull);
		}
		mappingConfigList_.WriteTo(output, _repeated_mappingConfigList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (CanCyclicMapping != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanCyclicMapping);
		}
		if (ResultRull != ESkillMappingResultRull.PseudoRandom)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResultRull);
		}
		num += mappingConfigList_.CalculateSize(_repeated_mappingConfigList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSkillSMappingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.CanCyclicMapping != EGSYesNo.No)
			{
				CanCyclicMapping = other.CanCyclicMapping;
			}
			if (other.ResultRull != ESkillMappingResultRull.PseudoRandom)
			{
				ResultRull = other.ResultRull;
			}
			mappingConfigList_.Add(other.mappingConfigList_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				CanCyclicMapping = (EGSYesNo)input.ReadEnum();
				break;
			case 24u:
				ResultRull = (ESkillMappingResultRull)input.ReadEnum();
				break;
			case 34u:
				mappingConfigList_.AddEntriesFrom(input, _repeated_mappingConfigList_codec);
				break;
			}
		}
	}
}
