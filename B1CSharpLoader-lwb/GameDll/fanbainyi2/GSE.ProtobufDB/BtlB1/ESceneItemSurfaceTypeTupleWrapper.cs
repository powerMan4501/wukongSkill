using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ESceneItemSurfaceTypeTupleWrapper : IMessage<ESceneItemSurfaceTypeTupleWrapper>, IMessage, IEquatable<ESceneItemSurfaceTypeTupleWrapper>, IDeepCloneable<ESceneItemSurfaceTypeTupleWrapper>
{
	private static readonly MessageParser<ESceneItemSurfaceTypeTupleWrapper> _parser = new MessageParser<ESceneItemSurfaceTypeTupleWrapper>(() => new ESceneItemSurfaceTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESceneItemSurfaceType item1_;

	private ESceneItemSurfaceType item2_;

	public static MessageParser<ESceneItemSurfaceTypeTupleWrapper> Parser => _parser;

	public ESceneItemSurfaceType Item1
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

	public ESceneItemSurfaceType Item2
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

	public ESceneItemSurfaceTypeTupleWrapper()
	{
	}

	public ESceneItemSurfaceTypeTupleWrapper(ESceneItemSurfaceTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESceneItemSurfaceTypeTupleWrapper Clone()
	{
		return new ESceneItemSurfaceTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESceneItemSurfaceTypeTupleWrapper);
	}

	public bool Equals(ESceneItemSurfaceTypeTupleWrapper other)
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
		if (Item1 != ESceneItemSurfaceType.DefaultSurface)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESceneItemSurfaceType.DefaultSurface)
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
		if (Item1 != ESceneItemSurfaceType.DefaultSurface)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESceneItemSurfaceType.DefaultSurface)
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
		if (Item1 != ESceneItemSurfaceType.DefaultSurface)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESceneItemSurfaceType.DefaultSurface)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESceneItemSurfaceTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESceneItemSurfaceType.DefaultSurface)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESceneItemSurfaceType.DefaultSurface)
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
				Item1 = (ESceneItemSurfaceType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESceneItemSurfaceType)input.ReadEnum();
				break;
			}
		}
	}
}
