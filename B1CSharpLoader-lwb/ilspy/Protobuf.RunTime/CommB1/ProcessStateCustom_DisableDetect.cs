using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_DisableDetect : IMessage<ProcessStateCustom_DisableDetect>, IMessage, IEquatable<ProcessStateCustom_DisableDetect>, IDeepCloneable<ProcessStateCustom_DisableDetect>
{
	private static readonly MessageParser<ProcessStateCustom_DisableDetect> _parser = new MessageParser<ProcessStateCustom_DisableDetect>(() => new ProcessStateCustom_DisableDetect());

	private UnknownFieldSet _unknownFields;

	private string detectCondition_ = "";

	public static MessageParser<ProcessStateCustom_DisableDetect> Parser => _parser;

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

	public ProcessStateCustom_DisableDetect()
	{
	}

	public ProcessStateCustom_DisableDetect(ProcessStateCustom_DisableDetect other)
		: this()
	{
		detectCondition_ = other.detectCondition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_DisableDetect Clone()
	{
		return new ProcessStateCustom_DisableDetect(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_DisableDetect);
	}

	public bool Equals(ProcessStateCustom_DisableDetect other)
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

	public void MergeFrom(ProcessStateCustom_DisableDetect other)
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
