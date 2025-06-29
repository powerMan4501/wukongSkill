using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkJsonConfigTypeTupleWrapper : IMessage<GssdkJsonConfigTypeTupleWrapper>, IMessage, IEquatable<GssdkJsonConfigTypeTupleWrapper>, IDeepCloneable<GssdkJsonConfigTypeTupleWrapper>
{
	private static readonly MessageParser<GssdkJsonConfigTypeTupleWrapper> _parser = new MessageParser<GssdkJsonConfigTypeTupleWrapper>(() => new GssdkJsonConfigTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private GssdkJsonConfigType item1_;

	private GssdkJsonConfigType item2_;

	public static MessageParser<GssdkJsonConfigTypeTupleWrapper> Parser => _parser;

	public GssdkJsonConfigType Item1
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

	public GssdkJsonConfigType Item2
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

	public GssdkJsonConfigTypeTupleWrapper()
	{
	}

	public GssdkJsonConfigTypeTupleWrapper(GssdkJsonConfigTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkJsonConfigTypeTupleWrapper Clone()
	{
		return new GssdkJsonConfigTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkJsonConfigTypeTupleWrapper);
	}

	public bool Equals(GssdkJsonConfigTypeTupleWrapper other)
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
		if (Item1 != GssdkJsonConfigType.GcctGlobal)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != GssdkJsonConfigType.GcctGlobal)
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
		if (Item1 != GssdkJsonConfigType.GcctGlobal)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != GssdkJsonConfigType.GcctGlobal)
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
		if (Item1 != GssdkJsonConfigType.GcctGlobal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != GssdkJsonConfigType.GcctGlobal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkJsonConfigTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != GssdkJsonConfigType.GcctGlobal)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != GssdkJsonConfigType.GcctGlobal)
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
				Item1 = (GssdkJsonConfigType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (GssdkJsonConfigType)input.ReadEnum();
				break;
			}
		}
	}
}
