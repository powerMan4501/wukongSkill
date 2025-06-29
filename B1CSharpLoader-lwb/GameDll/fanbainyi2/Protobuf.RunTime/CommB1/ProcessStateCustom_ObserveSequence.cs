using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_ObserveSequence : IMessage<ProcessStateCustom_ObserveSequence>, IMessage, IEquatable<ProcessStateCustom_ObserveSequence>, IDeepCloneable<ProcessStateCustom_ObserveSequence>
{
	private static readonly MessageParser<ProcessStateCustom_ObserveSequence> _parser = new MessageParser<ProcessStateCustom_ObserveSequence>(() => new ProcessStateCustom_ObserveSequence());

	private UnknownFieldSet _unknownFields;

	private int sequenceId_;

	private int successLimit_;

	public static MessageParser<ProcessStateCustom_ObserveSequence> Parser => _parser;

	public int SequenceId
	{
		get
		{
			return sequenceId_;
		}
		set
		{
			sequenceId_ = value;
		}
	}

	public int SuccessLimit
	{
		get
		{
			return successLimit_;
		}
		set
		{
			successLimit_ = value;
		}
	}

	public ProcessStateCustom_ObserveSequence()
	{
	}

	public ProcessStateCustom_ObserveSequence(ProcessStateCustom_ObserveSequence other)
		: this()
	{
		sequenceId_ = other.sequenceId_;
		successLimit_ = other.successLimit_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_ObserveSequence Clone()
	{
		return new ProcessStateCustom_ObserveSequence(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_ObserveSequence);
	}

	public bool Equals(ProcessStateCustom_ObserveSequence other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SequenceId != other.SequenceId)
		{
			return false;
		}
		if (SuccessLimit != other.SuccessLimit)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SequenceId != 0)
		{
			num ^= SequenceId.GetHashCode();
		}
		if (SuccessLimit != 0)
		{
			num ^= SuccessLimit.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SequenceId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SequenceId);
		}
		if (SuccessLimit != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SuccessLimit);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SequenceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SequenceId);
		}
		if (SuccessLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuccessLimit);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_ObserveSequence other)
	{
		if (other != null)
		{
			if (other.SequenceId != 0)
			{
				SequenceId = other.SequenceId;
			}
			if (other.SuccessLimit != 0)
			{
				SuccessLimit = other.SuccessLimit;
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
				SequenceId = input.ReadInt32();
				break;
			case 16u:
				SuccessLimit = input.ReadInt32();
				break;
			}
		}
	}
}
