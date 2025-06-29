using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_PlayerLeisureOverTime : IMessage<CalliopeCustom_DetectCondition_PlayerLeisureOverTime>, IMessage, IEquatable<CalliopeCustom_DetectCondition_PlayerLeisureOverTime>, IDeepCloneable<CalliopeCustom_DetectCondition_PlayerLeisureOverTime>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_PlayerLeisureOverTime> _parser = new MessageParser<CalliopeCustom_DetectCondition_PlayerLeisureOverTime>(() => new CalliopeCustom_DetectCondition_PlayerLeisureOverTime());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float playerLeisureOverTime_;

	public static MessageParser<CalliopeCustom_DetectCondition_PlayerLeisureOverTime> Parser => _parser;

	public float PlayerLeisureOverTime
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return playerLeisureOverTime_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			playerLeisureOverTime_ = value;
		}
	}

	public bool HasPlayerLeisureOverTime => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_PlayerLeisureOverTime()
	{
	}

	public CalliopeCustom_DetectCondition_PlayerLeisureOverTime(CalliopeCustom_DetectCondition_PlayerLeisureOverTime other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		playerLeisureOverTime_ = other.playerLeisureOverTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_PlayerLeisureOverTime Clone()
	{
		return new CalliopeCustom_DetectCondition_PlayerLeisureOverTime(this);
	}

	public void ClearPlayerLeisureOverTime()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_PlayerLeisureOverTime);
	}

	public bool Equals(CalliopeCustom_DetectCondition_PlayerLeisureOverTime other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerLeisureOverTime, other.PlayerLeisureOverTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasPlayerLeisureOverTime)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerLeisureOverTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasPlayerLeisureOverTime)
		{
			output.WriteRawTag(13);
			output.WriteFloat(PlayerLeisureOverTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasPlayerLeisureOverTime)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_PlayerLeisureOverTime other)
	{
		if (other != null)
		{
			if (other.HasPlayerLeisureOverTime)
			{
				PlayerLeisureOverTime = other.PlayerLeisureOverTime;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 13)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				PlayerLeisureOverTime = input.ReadFloat();
			}
		}
	}
}
