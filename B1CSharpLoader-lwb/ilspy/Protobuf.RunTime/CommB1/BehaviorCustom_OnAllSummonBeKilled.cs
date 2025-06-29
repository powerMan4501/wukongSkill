using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_OnAllSummonBeKilled : IMessage<BehaviorCustom_OnAllSummonBeKilled>, IMessage, IEquatable<BehaviorCustom_OnAllSummonBeKilled>, IDeepCloneable<BehaviorCustom_OnAllSummonBeKilled>
{
	private static readonly MessageParser<BehaviorCustom_OnAllSummonBeKilled> _parser = new MessageParser<BehaviorCustom_OnAllSummonBeKilled>(() => new BehaviorCustom_OnAllSummonBeKilled());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private string smartUnitGuid_ = "";

	private static readonly FieldCodec<int> _repeated_summonIds_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> summonIds_ = new RepeatedField<int>();

	public static MessageParser<BehaviorCustom_OnAllSummonBeKilled> Parser => _parser;

	public int UnitType
	{
		get
		{
			return unitType_;
		}
		set
		{
			unitType_ = value;
		}
	}

	public string SmartUnitGuid
	{
		get
		{
			return smartUnitGuid_;
		}
		set
		{
			smartUnitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> SummonIds => summonIds_;

	public BehaviorCustom_OnAllSummonBeKilled()
	{
	}

	public BehaviorCustom_OnAllSummonBeKilled(BehaviorCustom_OnAllSummonBeKilled other)
		: this()
	{
		unitType_ = other.unitType_;
		smartUnitGuid_ = other.smartUnitGuid_;
		summonIds_ = other.summonIds_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_OnAllSummonBeKilled Clone()
	{
		return new BehaviorCustom_OnAllSummonBeKilled(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_OnAllSummonBeKilled);
	}

	public bool Equals(BehaviorCustom_OnAllSummonBeKilled other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitType != other.UnitType)
		{
			return false;
		}
		if (SmartUnitGuid != other.SmartUnitGuid)
		{
			return false;
		}
		if (!summonIds_.Equals(other.summonIds_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitType != 0)
		{
			num ^= UnitType.GetHashCode();
		}
		if (SmartUnitGuid.Length != 0)
		{
			num ^= SmartUnitGuid.GetHashCode();
		}
		num ^= summonIds_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UnitType);
		}
		if (SmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SmartUnitGuid);
		}
		summonIds_.WriteTo(output, _repeated_summonIds_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitType);
		}
		if (SmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SmartUnitGuid);
		}
		num += summonIds_.CalculateSize(_repeated_summonIds_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_OnAllSummonBeKilled other)
	{
		if (other != null)
		{
			if (other.UnitType != 0)
			{
				UnitType = other.UnitType;
			}
			if (other.SmartUnitGuid.Length != 0)
			{
				SmartUnitGuid = other.SmartUnitGuid;
			}
			summonIds_.Add(other.summonIds_);
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
				UnitType = input.ReadInt32();
				break;
			case 18u:
				SmartUnitGuid = input.ReadString();
				break;
			case 24u:
			case 26u:
				summonIds_.AddEntriesFrom(input, _repeated_summonIds_codec);
				break;
			}
		}
	}
}
