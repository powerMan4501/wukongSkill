using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_ResetDetect : IMessage<ProcessStateCustom_ResetDetect>, IMessage, IEquatable<ProcessStateCustom_ResetDetect>, IDeepCloneable<ProcessStateCustom_ResetDetect>
{
	private static readonly MessageParser<ProcessStateCustom_ResetDetect> _parser = new MessageParser<ProcessStateCustom_ResetDetect>(() => new ProcessStateCustom_ResetDetect());

	private UnknownFieldSet _unknownFields;

	private string detectCondition_ = "";

	public static MessageParser<ProcessStateCustom_ResetDetect> Parser => _parser;

	public string DetectCondition
	{
		get
		{
			return detectCondition_;
		}
		set
		{
			detectCondition_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ProcessStateCustom_ResetDetect()
	{
	}

	public ProcessStateCustom_ResetDetect(ProcessStateCustom_ResetDetect other)
		: this()
	{
		detectCondition_ = other.detectCondition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_ResetDetect Clone()
	{
		return new ProcessStateCustom_ResetDetect(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_ResetDetect);
	}

	public bool Equals(ProcessStateCustom_ResetDetect other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DetectCondition != other.DetectCondition)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DetectCondition.Length != 0)
		{
			num ^= DetectCondition.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DetectCondition.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(DetectCondition);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DetectCondition.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DetectCondition);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_ResetDetect other)
	{
		if (other != null)
		{
			if (other.DetectCondition.Length != 0)
			{
				DetectCondition = other.DetectCondition;
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
				DetectCondition = input.ReadString();
			}
		}
	}
}
