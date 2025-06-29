using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ResourceTypeTupleWrapper : IMessage<ResourceTypeTupleWrapper>, IMessage, IEquatable<ResourceTypeTupleWrapper>, IDeepCloneable<ResourceTypeTupleWrapper>
{
	private static readonly MessageParser<ResourceTypeTupleWrapper> _parser = new MessageParser<ResourceTypeTupleWrapper>(() => new ResourceTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ResourceType item1_;

	private ResourceType item2_;

	public static MessageParser<ResourceTypeTupleWrapper> Parser => _parser;

	public ResourceType Item1
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

	public ResourceType Item2
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

	public ResourceTypeTupleWrapper()
	{
	}

	public ResourceTypeTupleWrapper(ResourceTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ResourceTypeTupleWrapper Clone()
	{
		return new ResourceTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ResourceTypeTupleWrapper);
	}

	public bool Equals(ResourceTypeTupleWrapper other)
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
		if (Item1 != ResourceType.Seq)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ResourceType.Seq)
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
		if (Item1 != ResourceType.Seq)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ResourceType.Seq)
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
		if (Item1 != ResourceType.Seq)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ResourceType.Seq)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ResourceTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ResourceType.Seq)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ResourceType.Seq)
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
				Item1 = (ResourceType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ResourceType)input.ReadEnum();
				break;
			}
		}
	}
}
