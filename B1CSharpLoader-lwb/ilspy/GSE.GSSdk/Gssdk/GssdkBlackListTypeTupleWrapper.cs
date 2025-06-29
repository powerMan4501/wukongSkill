using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkBlackListTypeTupleWrapper : IMessage<GssdkBlackListTypeTupleWrapper>, IMessage, IEquatable<GssdkBlackListTypeTupleWrapper>, IDeepCloneable<GssdkBlackListTypeTupleWrapper>
{
	private static readonly MessageParser<GssdkBlackListTypeTupleWrapper> _parser = new MessageParser<GssdkBlackListTypeTupleWrapper>(() => new GssdkBlackListTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private GssdkBlackListType item1_;

	private GssdkBlackListType item2_;

	public static MessageParser<GssdkBlackListTypeTupleWrapper> Parser => _parser;

	public GssdkBlackListType Item1
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

	public GssdkBlackListType Item2
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

	public GssdkBlackListTypeTupleWrapper()
	{
	}

	public GssdkBlackListTypeTupleWrapper(GssdkBlackListTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkBlackListTypeTupleWrapper Clone()
	{
		return new GssdkBlackListTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkBlackListTypeTupleWrapper);
	}

	public bool Equals(GssdkBlackListTypeTupleWrapper other)
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
		if (Item1 != GssdkBlackListType.Logindir)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != GssdkBlackListType.Logindir)
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
		if (Item1 != GssdkBlackListType.Logindir)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != GssdkBlackListType.Logindir)
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
		if (Item1 != GssdkBlackListType.Logindir)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != GssdkBlackListType.Logindir)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkBlackListTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != GssdkBlackListType.Logindir)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != GssdkBlackListType.Logindir)
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
				Item1 = (GssdkBlackListType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (GssdkBlackListType)input.ReadEnum();
				break;
			}
		}
	}
}
