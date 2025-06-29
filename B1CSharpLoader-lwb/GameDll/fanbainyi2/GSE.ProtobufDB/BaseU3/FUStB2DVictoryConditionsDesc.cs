using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BaseU3;

public sealed class FUStB2DVictoryConditionsDesc : IMessage<FUStB2DVictoryConditionsDesc>, IMessage, IEquatable<FUStB2DVictoryConditionsDesc>, IDeepCloneable<FUStB2DVictoryConditionsDesc>
{
	private static readonly MessageParser<FUStB2DVictoryConditionsDesc> _parser = new MessageParser<FUStB2DVictoryConditionsDesc>(() => new FUStB2DVictoryConditionsDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private BattleVictoryConditions victoryConditions_;

	private static readonly FieldCodec<int> _repeated_effectParam_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> effectParam_ = new RepeatedField<int>();

	private string efxPath_ = "";

	public static MessageParser<FUStB2DVictoryConditionsDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public BattleVictoryConditions VictoryConditions
	{
		get
		{
			return victoryConditions_;
		}
		set
		{
			victoryConditions_ = value;
		}
	}

	public RepeatedField<int> EffectParam => effectParam_;

	public string EfxPath
	{
		get
		{
			return efxPath_;
		}
		set
		{
			efxPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStB2DVictoryConditionsDesc()
	{
	}

	public FUStB2DVictoryConditionsDesc(FUStB2DVictoryConditionsDesc other)
		: this()
	{
		id_ = other.id_;
		victoryConditions_ = other.victoryConditions_;
		effectParam_ = other.effectParam_.Clone();
		efxPath_ = other.efxPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DVictoryConditionsDesc Clone()
	{
		return new FUStB2DVictoryConditionsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DVictoryConditionsDesc);
	}

	public bool Equals(FUStB2DVictoryConditionsDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (VictoryConditions != other.VictoryConditions)
		{
			return false;
		}
		if (!effectParam_.Equals(other.effectParam_))
		{
			return false;
		}
		if (EfxPath != other.EfxPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (VictoryConditions != BattleVictoryConditions.AllEnemyDie)
		{
			num ^= VictoryConditions.GetHashCode();
		}
		num ^= effectParam_.GetHashCode();
		if (EfxPath.Length != 0)
		{
			num ^= EfxPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (VictoryConditions != BattleVictoryConditions.AllEnemyDie)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)VictoryConditions);
		}
		effectParam_.WriteTo(output, _repeated_effectParam_codec);
		if (EfxPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(EfxPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (VictoryConditions != BattleVictoryConditions.AllEnemyDie)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)VictoryConditions);
		}
		num += effectParam_.CalculateSize(_repeated_effectParam_codec);
		if (EfxPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EfxPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DVictoryConditionsDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.VictoryConditions != BattleVictoryConditions.AllEnemyDie)
			{
				VictoryConditions = other.VictoryConditions;
			}
			effectParam_.Add(other.effectParam_);
			if (other.EfxPath.Length != 0)
			{
				EfxPath = other.EfxPath;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				VictoryConditions = (BattleVictoryConditions)input.ReadEnum();
				break;
			case 24u:
			case 26u:
				effectParam_.AddEntriesFrom(input, _repeated_effectParam_codec);
				break;
			case 34u:
				EfxPath = input.ReadString();
				break;
			}
		}
	}
}
