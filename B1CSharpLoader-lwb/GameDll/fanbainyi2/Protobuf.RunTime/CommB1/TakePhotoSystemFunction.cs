using System;
using Google.Protobuf;

namespace CommB1;

public sealed class TakePhotoSystemFunction : IMessage<TakePhotoSystemFunction>, IMessage, IEquatable<TakePhotoSystemFunction>, IDeepCloneable<TakePhotoSystemFunction>
{
	private static readonly MessageParser<TakePhotoSystemFunction> _parser = new MessageParser<TakePhotoSystemFunction>(() => new TakePhotoSystemFunction());

	private UnknownFieldSet _unknownFields;

	private int functionId_;

	private int functionValue_;

	public static MessageParser<TakePhotoSystemFunction> Parser => _parser;

	public int FunctionId
	{
		get
		{
			return functionId_;
		}
		set
		{
			functionId_ = value;
		}
	}

	public int FunctionValue
	{
		get
		{
			return functionValue_;
		}
		set
		{
			functionValue_ = value;
		}
	}

	public TakePhotoSystemFunction()
	{
	}

	public TakePhotoSystemFunction(TakePhotoSystemFunction other)
		: this()
	{
		functionId_ = other.functionId_;
		functionValue_ = other.functionValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TakePhotoSystemFunction Clone()
	{
		return new TakePhotoSystemFunction(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TakePhotoSystemFunction);
	}

	public bool Equals(TakePhotoSystemFunction other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FunctionId != other.FunctionId)
		{
			return false;
		}
		if (FunctionValue != other.FunctionValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (FunctionId != 0)
		{
			num ^= FunctionId.GetHashCode();
		}
		if (FunctionValue != 0)
		{
			num ^= FunctionValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (FunctionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FunctionId);
		}
		if (FunctionValue != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(FunctionValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (FunctionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FunctionId);
		}
		if (FunctionValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FunctionValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TakePhotoSystemFunction other)
	{
		if (other != null)
		{
			if (other.FunctionId != 0)
			{
				FunctionId = other.FunctionId;
			}
			if (other.FunctionValue != 0)
			{
				FunctionValue = other.FunctionValue;
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
				FunctionId = input.ReadInt32();
				break;
			case 16u:
				FunctionValue = input.ReadInt32();
				break;
			}
		}
	}
}
