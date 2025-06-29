using System;
using Google.Protobuf;

namespace ResB1;

public sealed class DataSyncFlagTupleWrapper : IMessage<DataSyncFlagTupleWrapper>, IMessage, IEquatable<DataSyncFlagTupleWrapper>, IDeepCloneable<DataSyncFlagTupleWrapper>
{
	private static readonly MessageParser<DataSyncFlagTupleWrapper> _parser = new MessageParser<DataSyncFlagTupleWrapper>(() => new DataSyncFlagTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private DataSyncFlag item1_;

	private DataSyncFlag item2_;

	public static MessageParser<DataSyncFlagTupleWrapper> Parser => _parser;

	public DataSyncFlag Item1
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

	public DataSyncFlag Item2
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

	public DataSyncFlagTupleWrapper()
	{
	}

	public DataSyncFlagTupleWrapper(DataSyncFlagTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DataSyncFlagTupleWrapper Clone()
	{
		return new DataSyncFlagTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DataSyncFlagTupleWrapper);
	}

	public bool Equals(DataSyncFlagTupleWrapper other)
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
		if (Item1 != DataSyncFlag.SyncFlagNone)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != DataSyncFlag.SyncFlagNone)
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
		if (Item1 != DataSyncFlag.SyncFlagNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != DataSyncFlag.SyncFlagNone)
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
		if (Item1 != DataSyncFlag.SyncFlagNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != DataSyncFlag.SyncFlagNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DataSyncFlagTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != DataSyncFlag.SyncFlagNone)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != DataSyncFlag.SyncFlagNone)
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
				Item1 = (DataSyncFlag)input.ReadEnum();
				break;
			case 16u:
				Item2 = (DataSyncFlag)input.ReadEnum();
				break;
			}
		}
	}
}
