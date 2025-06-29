using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPhaseSpawnWaveConfig : IMessage<FUStPhaseSpawnWaveConfig>, IMessage, IEquatable<FUStPhaseSpawnWaveConfig>, IDeepCloneable<FUStPhaseSpawnWaveConfig>
{
	private static readonly MessageParser<FUStPhaseSpawnWaveConfig> _parser = new MessageParser<FUStPhaseSpawnWaveConfig>(() => new FUStPhaseSpawnWaveConfig());

	private UnknownFieldSet _unknownFields;

	private float thresholds_;

	private float secondWaveChance_;

	public static MessageParser<FUStPhaseSpawnWaveConfig> Parser => _parser;

	public float Thresholds
	{
		get
		{
			return thresholds_;
		}
		set
		{
			thresholds_ = value;
		}
	}

	public float SecondWaveChance
	{
		get
		{
			return secondWaveChance_;
		}
		set
		{
			secondWaveChance_ = value;
		}
	}

	public FUStPhaseSpawnWaveConfig()
	{
	}

	public FUStPhaseSpawnWaveConfig(FUStPhaseSpawnWaveConfig other)
		: this()
	{
		thresholds_ = other.thresholds_;
		secondWaveChance_ = other.secondWaveChance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPhaseSpawnWaveConfig Clone()
	{
		return new FUStPhaseSpawnWaveConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPhaseSpawnWaveConfig);
	}

	public bool Equals(FUStPhaseSpawnWaveConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Thresholds, other.Thresholds))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SecondWaveChance, other.SecondWaveChance))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Thresholds != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Thresholds);
		}
		if (SecondWaveChance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SecondWaveChance);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Thresholds != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(Thresholds);
		}
		if (SecondWaveChance != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(SecondWaveChance);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Thresholds != 0f)
		{
			num += 5;
		}
		if (SecondWaveChance != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPhaseSpawnWaveConfig other)
	{
		if (other != null)
		{
			if (other.Thresholds != 0f)
			{
				Thresholds = other.Thresholds;
			}
			if (other.SecondWaveChance != 0f)
			{
				SecondWaveChance = other.SecondWaveChance;
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
			case 13u:
				Thresholds = input.ReadFloat();
				break;
			case 21u:
				SecondWaveChance = input.ReadFloat();
				break;
			}
		}
	}
}
