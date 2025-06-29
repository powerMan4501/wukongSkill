using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TakePhotoConfigTabTupleWrapper : IMessage<TakePhotoConfigTabTupleWrapper>, IMessage, IEquatable<TakePhotoConfigTabTupleWrapper>, IDeepCloneable<TakePhotoConfigTabTupleWrapper>
{
	private static readonly MessageParser<TakePhotoConfigTabTupleWrapper> _parser = new MessageParser<TakePhotoConfigTabTupleWrapper>(() => new TakePhotoConfigTabTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private TakePhotoConfigTab item1_;

	private TakePhotoConfigTab item2_;

	public static MessageParser<TakePhotoConfigTabTupleWrapper> Parser => _parser;

	public TakePhotoConfigTab Item1
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

	public TakePhotoConfigTab Item2
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

	public TakePhotoConfigTabTupleWrapper()
	{
	}

	public TakePhotoConfigTabTupleWrapper(TakePhotoConfigTabTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TakePhotoConfigTabTupleWrapper Clone()
	{
		return new TakePhotoConfigTabTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TakePhotoConfigTabTupleWrapper);
	}

	public bool Equals(TakePhotoConfigTabTupleWrapper other)
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
		if (Item1 != TakePhotoConfigTab.Camera)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != TakePhotoConfigTab.Camera)
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
		if (Item1 != TakePhotoConfigTab.Camera)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != TakePhotoConfigTab.Camera)
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
		if (Item1 != TakePhotoConfigTab.Camera)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != TakePhotoConfigTab.Camera)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TakePhotoConfigTabTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != TakePhotoConfigTab.Camera)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != TakePhotoConfigTab.Camera)
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
				Item1 = (TakePhotoConfigTab)input.ReadEnum();
				break;
			case 16u:
				Item2 = (TakePhotoConfigTab)input.ReadEnum();
				break;
			}
		}
	}
}
