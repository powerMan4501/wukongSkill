using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ManagedSceneObjTypeTupleWrapper : IMessage<ManagedSceneObjTypeTupleWrapper>, IMessage, IEquatable<ManagedSceneObjTypeTupleWrapper>, IDeepCloneable<ManagedSceneObjTypeTupleWrapper>
{
	private static readonly MessageParser<ManagedSceneObjTypeTupleWrapper> _parser = new MessageParser<ManagedSceneObjTypeTupleWrapper>(() => new ManagedSceneObjTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ManagedSceneObjType item1_;

	private ManagedSceneObjType item2_;

	public static MessageParser<ManagedSceneObjTypeTupleWrapper> Parser => _parser;

	public ManagedSceneObjType Item1
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

	public ManagedSceneObjType Item2
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

	public ManagedSceneObjTypeTupleWrapper()
	{
	}

	public ManagedSceneObjTypeTupleWrapper(ManagedSceneObjTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ManagedSceneObjTypeTupleWrapper Clone()
	{
		return new ManagedSceneObjTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ManagedSceneObjTypeTupleWrapper);
	}

	public bool Equals(ManagedSceneObjTypeTupleWrapper other)
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
		if (Item1 != ManagedSceneObjType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ManagedSceneObjType.None)
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
		if (Item1 != ManagedSceneObjType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ManagedSceneObjType.None)
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
		if (Item1 != ManagedSceneObjType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ManagedSceneObjType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ManagedSceneObjTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ManagedSceneObjType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ManagedSceneObjType.None)
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
				Item1 = (ManagedSceneObjType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ManagedSceneObjType)input.ReadEnum();
				break;
			}
		}
	}
}
