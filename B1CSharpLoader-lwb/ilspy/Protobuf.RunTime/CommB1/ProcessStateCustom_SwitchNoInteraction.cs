using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_SwitchNoInteraction : IMessage<ProcessStateCustom_SwitchNoInteraction>, IMessage, IEquatable<ProcessStateCustom_SwitchNoInteraction>, IDeepCloneable<ProcessStateCustom_SwitchNoInteraction>
{
	private static readonly MessageParser<ProcessStateCustom_SwitchNoInteraction> _parser = new MessageParser<ProcessStateCustom_SwitchNoInteraction>(() => new ProcessStateCustom_SwitchNoInteraction());

	private UnknownFieldSet _unknownFields;

	private string unitGuid_ = "";

	private bool isRecover_;

	public static MessageParser<ProcessStateCustom_SwitchNoInteraction> Parser => _parser;

	public string UnitGuid
	{
		get
		{
			return unitGuid_;
		}
		set
		{
			unitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsRecover
	{
		get
		{
			return isRecover_;
		}
		set
		{
			isRecover_ = value;
		}
	}

	public ProcessStateCustom_SwitchNoInteraction()
	{
	}

	public ProcessStateCustom_SwitchNoInteraction(ProcessStateCustom_SwitchNoInteraction other)
		: this()
	{
		unitGuid_ = other.unitGuid_;
		isRecover_ = other.isRecover_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_SwitchNoInteraction Clone()
	{
		return new ProcessStateCustom_SwitchNoInteraction(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_SwitchNoInteraction);
	}

	public bool Equals(ProcessStateCustom_SwitchNoInteraction other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (IsRecover != other.IsRecover)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (IsRecover)
		{
			num ^= IsRecover.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(UnitGuid);
		}
		if (IsRecover)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsRecover);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (IsRecover)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_SwitchNoInteraction other)
	{
		if (other != null)
		{
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.IsRecover)
			{
				IsRecover = other.IsRecover;
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
				UnitGuid = input.ReadString();
				break;
			case 16u:
				IsRecover = input.ReadBool();
				break;
			}
		}
	}
}
