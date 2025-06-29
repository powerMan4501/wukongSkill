using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class PS_Transaction_TransactionTask : IMessage<PS_Transaction_TransactionTask>, IMessage, IEquatable<PS_Transaction_TransactionTask>, IDeepCloneable<PS_Transaction_TransactionTask>
{
	private static readonly MessageParser<PS_Transaction_TransactionTask> _parser = new MessageParser<PS_Transaction_TransactionTask>(() => new PS_Transaction_TransactionTask());

	private UnknownFieldSet _unknownFields;

	private int transactionTaskType_;

	public static MessageParser<PS_Transaction_TransactionTask> Parser => _parser;

	public int TransactionTaskType
	{
		get
		{
			return transactionTaskType_;
		}
		set
		{
			transactionTaskType_ = value;
		}
	}

	public PS_Transaction_TransactionTask()
	{
	}

	public PS_Transaction_TransactionTask(PS_Transaction_TransactionTask other)
		: this()
	{
		transactionTaskType_ = other.transactionTaskType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PS_Transaction_TransactionTask Clone()
	{
		return new PS_Transaction_TransactionTask(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PS_Transaction_TransactionTask);
	}

	public bool Equals(PS_Transaction_TransactionTask other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TransactionTaskType != other.TransactionTaskType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TransactionTaskType != 0)
		{
			num ^= TransactionTaskType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TransactionTaskType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TransactionTaskType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TransactionTaskType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TransactionTaskType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PS_Transaction_TransactionTask other)
	{
		if (other != null)
		{
			if (other.TransactionTaskType != 0)
			{
				TransactionTaskType = other.TransactionTaskType;
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
				TransactionTaskType = input.ReadInt32();
			}
		}
	}
}
