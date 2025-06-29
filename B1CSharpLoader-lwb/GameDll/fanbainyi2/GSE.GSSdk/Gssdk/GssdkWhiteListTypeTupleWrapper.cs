using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkWhiteListTypeTupleWrapper : IMessage<GssdkWhiteListTypeTupleWrapper>, IMessage, IEquatable<GssdkWhiteListTypeTupleWrapper>, IDeepCloneable<GssdkWhiteListTypeTupleWrapper>
{
	private static readonly MessageParser<GssdkWhiteListTypeTupleWrapper> _parser = new MessageParser<GssdkWhiteListTypeTupleWrapper>(() => new GssdkWhiteListTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private GssdkWhiteListType item1_;

	private GssdkWhiteListType item2_;

	public static MessageParser<GssdkWhiteListTypeTupleWrapper> Parser => _parser;

	public GssdkWhiteListType Item1
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

	public GssdkWhiteListType Item2
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

	public GssdkWhiteListTypeTupleWrapper()
	{
	}

	public GssdkWhiteListTypeTupleWrapper(GssdkWhiteListTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkWhiteListTypeTupleWrapper Clone()
	{
		return new GssdkWhiteListTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkWhiteListTypeTupleWrapper);
	}

	public bool Equals(GssdkWhiteListTypeTupleWrapper other)
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
		if (Item1 != GssdkWhiteListType.Logindir)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != GssdkWhiteListType.Logindir)
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
		if (Item1 != GssdkWhiteListType.Logindir)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != GssdkWhiteListType.Logindir)
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
		if (Item1 != GssdkWhiteListType.Logindir)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != GssdkWhiteListType.Logindir)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkWhiteListTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != GssdkWhiteListType.Logindir)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != GssdkWhiteListType.Logindir)
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
				Item1 = (GssdkWhiteListType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (GssdkWhiteListType)input.ReadEnum();
				break;
			}
		}
	}
}
