using System;
using Google.Protobuf;

namespace CommB1;

public sealed class TestDataOld : IMessage<TestDataOld>, IMessage, IEquatable<TestDataOld>, IDeepCloneable<TestDataOld>
{
	private static readonly MessageParser<TestDataOld> _parser = new MessageParser<TestDataOld>(() => new TestDataOld());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private PartyData data_;

	public static MessageParser<TestDataOld> Parser => _parser;

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

	public PartyData Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	public TestDataOld()
	{
	}

	public TestDataOld(TestDataOld other)
		: this()
	{
		id_ = other.id_;
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TestDataOld Clone()
	{
		return new TestDataOld(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TestDataOld);
	}

	public bool Equals(TestDataOld other)
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
		if (!object.Equals(Data, other.Data))
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
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
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
		if (data_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Data);
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
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TestDataOld other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new PartyData();
			}
			Data.MergeFrom(other.Data);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (data_ == null)
				{
					Data = new PartyData();
				}
				input.ReadMessage(Data);
				break;
			}
		}
	}
}
