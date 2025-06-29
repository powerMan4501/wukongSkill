using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_SimpleState : IMessage<BehaviorCustom_SimpleState>, IMessage, IEquatable<BehaviorCustom_SimpleState>, IDeepCloneable<BehaviorCustom_SimpleState>
{
	private static readonly MessageParser<BehaviorCustom_SimpleState> _parser = new MessageParser<BehaviorCustom_SimpleState>(() => new BehaviorCustom_SimpleState());

	private UnknownFieldSet _unknownFields;

	private int simpleState_;

	private bool isAdd_;

	public static MessageParser<BehaviorCustom_SimpleState> Parser => _parser;

	public int SimpleState
	{
		get
		{
			return simpleState_;
		}
		set
		{
			simpleState_ = value;
		}
	}

	public bool IsAdd
	{
		get
		{
			return isAdd_;
		}
		set
		{
			isAdd_ = value;
		}
	}

	public BehaviorCustom_SimpleState()
	{
	}

	public BehaviorCustom_SimpleState(BehaviorCustom_SimpleState other)
		: this()
	{
		simpleState_ = other.simpleState_;
		isAdd_ = other.isAdd_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_SimpleState Clone()
	{
		return new BehaviorCustom_SimpleState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_SimpleState);
	}

	public bool Equals(BehaviorCustom_SimpleState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SimpleState != other.SimpleState)
		{
			return false;
		}
		if (IsAdd != other.IsAdd)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SimpleState != 0)
		{
			num ^= SimpleState.GetHashCode();
		}
		if (IsAdd)
		{
			num ^= IsAdd.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SimpleState != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SimpleState);
		}
		if (IsAdd)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsAdd);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SimpleState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SimpleState);
		}
		if (IsAdd)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_SimpleState other)
	{
		if (other != null)
		{
			if (other.SimpleState != 0)
			{
				SimpleState = other.SimpleState;
			}
			if (other.IsAdd)
			{
				IsAdd = other.IsAdd;
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
				SimpleState = input.ReadInt32();
				break;
			case 16u:
				IsAdd = input.ReadBool();
				break;
			}
		}
	}
}
