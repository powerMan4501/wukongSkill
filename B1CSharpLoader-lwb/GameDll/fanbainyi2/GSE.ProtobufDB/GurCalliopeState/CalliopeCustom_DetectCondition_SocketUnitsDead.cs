using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_SocketUnitsDead : IMessage<CalliopeCustom_DetectCondition_SocketUnitsDead>, IMessage, IEquatable<CalliopeCustom_DetectCondition_SocketUnitsDead>, IDeepCloneable<CalliopeCustom_DetectCondition_SocketUnitsDead>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_SocketUnitsDead> _parser = new MessageParser<CalliopeCustom_DetectCondition_SocketUnitsDead>(() => new CalliopeCustom_DetectCondition_SocketUnitsDead());

	private UnknownFieldSet _unknownFields;

	private CalliopeCustom_FTamerFamilyMatchChildInfo matchInfo_;

	public static MessageParser<CalliopeCustom_DetectCondition_SocketUnitsDead> Parser => _parser;

	public CalliopeCustom_FTamerFamilyMatchChildInfo MatchInfo
	{
		get
		{
			return matchInfo_;
		}
		set
		{
			matchInfo_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_SocketUnitsDead()
	{
	}

	public CalliopeCustom_DetectCondition_SocketUnitsDead(CalliopeCustom_DetectCondition_SocketUnitsDead other)
		: this()
	{
		matchInfo_ = ((other.matchInfo_ != null) ? other.matchInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_SocketUnitsDead Clone()
	{
		return new CalliopeCustom_DetectCondition_SocketUnitsDead(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_SocketUnitsDead);
	}

	public bool Equals(CalliopeCustom_DetectCondition_SocketUnitsDead other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MatchInfo, other.MatchInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (matchInfo_ != null)
		{
			num ^= MatchInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (matchInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MatchInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (matchInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MatchInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_SocketUnitsDead other)
	{
		if (other == null)
		{
			return;
		}
		if (other.matchInfo_ != null)
		{
			if (matchInfo_ == null)
			{
				MatchInfo = new CalliopeCustom_FTamerFamilyMatchChildInfo();
			}
			MatchInfo.MergeFrom(other.MatchInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (matchInfo_ == null)
			{
				MatchInfo = new CalliopeCustom_FTamerFamilyMatchChildInfo();
			}
			input.ReadMessage(MatchInfo);
		}
	}
}
