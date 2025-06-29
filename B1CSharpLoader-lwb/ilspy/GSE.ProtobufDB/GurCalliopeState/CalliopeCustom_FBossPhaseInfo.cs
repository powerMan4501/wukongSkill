using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_FBossPhaseInfo : IMessage<CalliopeCustom_FBossPhaseInfo>, IMessage, IEquatable<CalliopeCustom_FBossPhaseInfo>, IDeepCloneable<CalliopeCustom_FBossPhaseInfo>
{
	private static readonly MessageParser<CalliopeCustom_FBossPhaseInfo> _parser = new MessageParser<CalliopeCustom_FBossPhaseInfo>(() => new CalliopeCustom_FBossPhaseInfo());

	private UnknownFieldSet _unknownFields;

	private bool hasPhasePerformance_;

	public static MessageParser<CalliopeCustom_FBossPhaseInfo> Parser => _parser;

	public bool HasPhasePerformance
	{
		get
		{
			return hasPhasePerformance_;
		}
		set
		{
			hasPhasePerformance_ = value;
		}
	}

	public CalliopeCustom_FBossPhaseInfo()
	{
	}

	public CalliopeCustom_FBossPhaseInfo(CalliopeCustom_FBossPhaseInfo other)
		: this()
	{
		hasPhasePerformance_ = other.hasPhasePerformance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_FBossPhaseInfo Clone()
	{
		return new CalliopeCustom_FBossPhaseInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_FBossPhaseInfo);
	}

	public bool Equals(CalliopeCustom_FBossPhaseInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HasPhasePerformance != other.HasPhasePerformance)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasPhasePerformance)
		{
			num ^= HasPhasePerformance.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasPhasePerformance)
		{
			output.WriteRawTag(8);
			output.WriteBool(HasPhasePerformance);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasPhasePerformance)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_FBossPhaseInfo other)
	{
		if (other != null)
		{
			if (other.HasPhasePerformance)
			{
				HasPhasePerformance = other.HasPhasePerformance;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				HasPhasePerformance = input.ReadBool();
			}
		}
	}
}
