using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_ActiveUnit : IMessage<ProcessStateCustom_ActiveUnit>, IMessage, IEquatable<ProcessStateCustom_ActiveUnit>, IDeepCloneable<ProcessStateCustom_ActiveUnit>
{
	private static readonly MessageParser<ProcessStateCustom_ActiveUnit> _parser = new MessageParser<ProcessStateCustom_ActiveUnit>(() => new ProcessStateCustom_ActiveUnit());

	private UnknownFieldSet _unknownFields;

	private string unitGuid_ = "";

	public static MessageParser<ProcessStateCustom_ActiveUnit> Parser => _parser;

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

	public ProcessStateCustom_ActiveUnit()
	{
	}

	public ProcessStateCustom_ActiveUnit(ProcessStateCustom_ActiveUnit other)
		: this()
	{
		unitGuid_ = other.unitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_ActiveUnit Clone()
	{
		return new ProcessStateCustom_ActiveUnit(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_ActiveUnit);
	}

	public bool Equals(ProcessStateCustom_ActiveUnit other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_ActiveUnit other)
	{
		if (other != null)
		{
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
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
				UnitGuid = input.ReadString();
			}
		}
	}
}
