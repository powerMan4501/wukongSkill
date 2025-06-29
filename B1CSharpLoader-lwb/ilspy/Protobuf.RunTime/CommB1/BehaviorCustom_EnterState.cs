using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_EnterState : IMessage<BehaviorCustom_EnterState>, IMessage, IEquatable<BehaviorCustom_EnterState>, IDeepCloneable<BehaviorCustom_EnterState>
{
	private static readonly MessageParser<BehaviorCustom_EnterState> _parser = new MessageParser<BehaviorCustom_EnterState>(() => new BehaviorCustom_EnterState());

	private UnknownFieldSet _unknownFields;

	private string stateName_ = "";

	public static MessageParser<BehaviorCustom_EnterState> Parser => _parser;

	public string StateName
	{
		get
		{
			return stateName_;
		}
		set
		{
			stateName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_EnterState()
	{
	}

	public BehaviorCustom_EnterState(BehaviorCustom_EnterState other)
		: this()
	{
		stateName_ = other.stateName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_EnterState Clone()
	{
		return new BehaviorCustom_EnterState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_EnterState);
	}

	public bool Equals(BehaviorCustom_EnterState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StateName != other.StateName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StateName.Length != 0)
		{
			num ^= StateName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StateName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(StateName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StateName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StateName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_EnterState other)
	{
		if (other != null)
		{
			if (other.StateName.Length != 0)
			{
				StateName = other.StateName;
			}
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
				StateName = input.ReadString();
			}
		}
	}
}
