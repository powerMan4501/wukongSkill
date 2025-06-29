using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessCustom_State : IMessage<ProcessCustom_State>, IMessage, IEquatable<ProcessCustom_State>, IDeepCloneable<ProcessCustom_State>
{
	private static readonly MessageParser<ProcessCustom_State> _parser = new MessageParser<ProcessCustom_State>(() => new ProcessCustom_State());

	private UnknownFieldSet _unknownFields;

	private string stateName_ = "";

	private string subStateMachinePath_ = "";

	public static MessageParser<ProcessCustom_State> Parser => _parser;

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

	public string SubStateMachinePath
	{
		get
		{
			return subStateMachinePath_;
		}
		set
		{
			subStateMachinePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ProcessCustom_State()
	{
	}

	public ProcessCustom_State(ProcessCustom_State other)
		: this()
	{
		stateName_ = other.stateName_;
		subStateMachinePath_ = other.subStateMachinePath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_State Clone()
	{
		return new ProcessCustom_State(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_State);
	}

	public bool Equals(ProcessCustom_State other)
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
		if (SubStateMachinePath != other.SubStateMachinePath)
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
		if (SubStateMachinePath.Length != 0)
		{
			num ^= SubStateMachinePath.GetHashCode();
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
		if (SubStateMachinePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SubStateMachinePath);
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
		if (SubStateMachinePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SubStateMachinePath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_State other)
	{
		if (other != null)
		{
			if (other.StateName.Length != 0)
			{
				StateName = other.StateName;
			}
			if (other.SubStateMachinePath.Length != 0)
			{
				SubStateMachinePath = other.SubStateMachinePath;
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
			case 10u:
				StateName = input.ReadString();
				break;
			case 18u:
				SubStateMachinePath = input.ReadString();
				break;
			}
		}
	}
}
