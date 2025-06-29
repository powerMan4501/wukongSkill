using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkErrCodeTupleWrapper : IMessage<GssdkErrCodeTupleWrapper>, IMessage, IEquatable<GssdkErrCodeTupleWrapper>, IDeepCloneable<GssdkErrCodeTupleWrapper>
{
	private static readonly MessageParser<GssdkErrCodeTupleWrapper> _parser = new MessageParser<GssdkErrCodeTupleWrapper>(() => new GssdkErrCodeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private GssdkErrCode item1_;

	private GssdkErrCode item2_;

	public static MessageParser<GssdkErrCodeTupleWrapper> Parser => _parser;

	public GssdkErrCode Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public GssdkErrCode Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public GssdkErrCodeTupleWrapper()
	{
	}

	public GssdkErrCodeTupleWrapper(GssdkErrCodeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkErrCodeTupleWrapper Clone()
	{
		return new GssdkErrCodeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkErrCodeTupleWrapper);
	}

	public bool Equals(GssdkErrCodeTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != GssdkErrCode.Success)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != GssdkErrCode.Success)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != GssdkErrCode.Success)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != GssdkErrCode.Success)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != GssdkErrCode.Success)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != GssdkErrCode.Success)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkErrCodeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != GssdkErrCode.Success)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != GssdkErrCode.Success)
			{
				Item2 = other.Item2;
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
				Item1 = (GssdkErrCode)input.ReadEnum();
				break;
			case 16u:
				Item2 = (GssdkErrCode)input.ReadEnum();
				break;
			}
		}
	}
}
