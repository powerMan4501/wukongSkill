using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_BattlePaceWaveConfig : IMessage<CalliopeCustom_BattlePaceWaveConfig>, IMessage, IEquatable<CalliopeCustom_BattlePaceWaveConfig>, IDeepCloneable<CalliopeCustom_BattlePaceWaveConfig>
{
	private static readonly MessageParser<CalliopeCustom_BattlePaceWaveConfig> _parser = new MessageParser<CalliopeCustom_BattlePaceWaveConfig>(() => new CalliopeCustom_BattlePaceWaveConfig());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CalliopeCustom_BattleWaveUnitSpawnConfig> _repeated_unitSpawnConfigs_codec = FieldCodec.ForMessage(10u, CalliopeCustom_BattleWaveUnitSpawnConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_BattleWaveUnitSpawnConfig> unitSpawnConfigs_ = new RepeatedField<CalliopeCustom_BattleWaveUnitSpawnConfig>();

	public static MessageParser<CalliopeCustom_BattlePaceWaveConfig> Parser => _parser;

	public RepeatedField<CalliopeCustom_BattleWaveUnitSpawnConfig> UnitSpawnConfigs => unitSpawnConfigs_;

	public CalliopeCustom_BattlePaceWaveConfig()
	{
	}

	public CalliopeCustom_BattlePaceWaveConfig(CalliopeCustom_BattlePaceWaveConfig other)
		: this()
	{
		unitSpawnConfigs_ = other.unitSpawnConfigs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_BattlePaceWaveConfig Clone()
	{
		return new CalliopeCustom_BattlePaceWaveConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_BattlePaceWaveConfig);
	}

	public bool Equals(CalliopeCustom_BattlePaceWaveConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!unitSpawnConfigs_.Equals(other.unitSpawnConfigs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= unitSpawnConfigs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		unitSpawnConfigs_.WriteTo(output, _repeated_unitSpawnConfigs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += unitSpawnConfigs_.CalculateSize(_repeated_unitSpawnConfigs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_BattlePaceWaveConfig other)
	{
		if (other != null)
		{
			unitSpawnConfigs_.Add(other.unitSpawnConfigs_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				unitSpawnConfigs_.AddEntriesFrom(input, _repeated_unitSpawnConfigs_codec);
			}
		}
	}
}
