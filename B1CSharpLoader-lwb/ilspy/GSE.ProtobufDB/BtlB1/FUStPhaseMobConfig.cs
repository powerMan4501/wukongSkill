using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPhaseMobConfig : IMessage<FUStPhaseMobConfig>, IMessage, IEquatable<FUStPhaseMobConfig>, IDeepCloneable<FUStPhaseMobConfig>
{
	private static readonly MessageParser<FUStPhaseMobConfig> _parser = new MessageParser<FUStPhaseMobConfig>(() => new FUStPhaseMobConfig());

	private UnknownFieldSet _unknownFields;

	private EMobStrengthLevel strengthTag_;

	private int startPhase_;

	private float baseChance_;

	private float chanceIncrement_;

	private float marginChance_;

	public static MessageParser<FUStPhaseMobConfig> Parser => _parser;

	public EMobStrengthLevel StrengthTag
	{
		get
		{
			return strengthTag_;
		}
		set
		{
			strengthTag_ = value;
		}
	}

	public int StartPhase
	{
		get
		{
			return startPhase_;
		}
		set
		{
			startPhase_ = value;
		}
	}

	public float BaseChance
	{
		get
		{
			return baseChance_;
		}
		set
		{
			baseChance_ = value;
		}
	}

	public float ChanceIncrement
	{
		get
		{
			return chanceIncrement_;
		}
		set
		{
			chanceIncrement_ = value;
		}
	}

	public float MarginChance
	{
		get
		{
			return marginChance_;
		}
		set
		{
			marginChance_ = value;
		}
	}

	public FUStPhaseMobConfig()
	{
	}

	public FUStPhaseMobConfig(FUStPhaseMobConfig other)
		: this()
	{
		strengthTag_ = other.strengthTag_;
		startPhase_ = other.startPhase_;
		baseChance_ = other.baseChance_;
		chanceIncrement_ = other.chanceIncrement_;
		marginChance_ = other.marginChance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPhaseMobConfig Clone()
	{
		return new FUStPhaseMobConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPhaseMobConfig);
	}

	public bool Equals(FUStPhaseMobConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StrengthTag != other.StrengthTag)
		{
			return false;
		}
		if (StartPhase != other.StartPhase)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BaseChance, other.BaseChance))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ChanceIncrement, other.ChanceIncrement))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MarginChance, other.MarginChance))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StrengthTag != EMobStrengthLevel.LevelWeak)
		{
			num ^= StrengthTag.GetHashCode();
		}
		if (StartPhase != 0)
		{
			num ^= StartPhase.GetHashCode();
		}
		if (BaseChance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BaseChance);
		}
		if (ChanceIncrement != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ChanceIncrement);
		}
		if (MarginChance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MarginChance);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StrengthTag != EMobStrengthLevel.LevelWeak)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)StrengthTag);
		}
		if (StartPhase != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(StartPhase);
		}
		if (BaseChance != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(BaseChance);
		}
		if (ChanceIncrement != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(ChanceIncrement);
		}
		if (MarginChance != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(MarginChance);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StrengthTag != EMobStrengthLevel.LevelWeak)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)StrengthTag);
		}
		if (StartPhase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StartPhase);
		}
		if (BaseChance != 0f)
		{
			num += 5;
		}
		if (ChanceIncrement != 0f)
		{
			num += 5;
		}
		if (MarginChance != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPhaseMobConfig other)
	{
		if (other != null)
		{
			if (other.StrengthTag != EMobStrengthLevel.LevelWeak)
			{
				StrengthTag = other.StrengthTag;
			}
			if (other.StartPhase != 0)
			{
				StartPhase = other.StartPhase;
			}
			if (other.BaseChance != 0f)
			{
				BaseChance = other.BaseChance;
			}
			if (other.ChanceIncrement != 0f)
			{
				ChanceIncrement = other.ChanceIncrement;
			}
			if (other.MarginChance != 0f)
			{
				MarginChance = other.MarginChance;
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
				StrengthTag = (EMobStrengthLevel)input.ReadEnum();
				break;
			case 16u:
				StartPhase = input.ReadInt32();
				break;
			case 29u:
				BaseChance = input.ReadFloat();
				break;
			case 37u:
				ChanceIncrement = input.ReadFloat();
				break;
			case 45u:
				MarginChance = input.ReadFloat();
				break;
			}
		}
	}
}
