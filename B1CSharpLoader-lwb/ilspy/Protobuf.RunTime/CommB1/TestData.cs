using System;
using Google.Protobuf;

namespace CommB1;

public sealed class TestData : IMessage<TestData>, IMessage, IEquatable<TestData>, IDeepCloneable<TestData>
{
	private static readonly MessageParser<TestData> _parser = new MessageParser<TestData>(() => new TestData());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private ByteString dataBytes_ = ByteString.Empty;

	public static MessageParser<TestData> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public ByteString DataBytes
	{
		get
		{
			return dataBytes_;
		}
		set
		{
			dataBytes_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public TestData()
	{
	}

	public TestData(TestData other)
		: this()
	{
		id_ = other.id_;
		dataBytes_ = other.dataBytes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TestData Clone()
	{
		return new TestData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TestData);
	}

	public bool Equals(TestData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (DataBytes != other.DataBytes)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (DataBytes.Length != 0)
		{
			num ^= DataBytes.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (DataBytes.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(DataBytes);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (DataBytes.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(DataBytes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TestData other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.DataBytes.Length != 0)
			{
				DataBytes = other.DataBytes;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				DataBytes = input.ReadBytes();
				break;
			}
		}
	}
}
