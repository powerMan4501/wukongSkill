using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class SessionAdvertiseTypeTupleWrapper : IMessage<SessionAdvertiseTypeTupleWrapper>, IMessage, IEquatable<SessionAdvertiseTypeTupleWrapper>, IDeepCloneable<SessionAdvertiseTypeTupleWrapper>
{
	private static readonly MessageParser<SessionAdvertiseTypeTupleWrapper> _parser = new MessageParser<SessionAdvertiseTypeTupleWrapper>(() => new SessionAdvertiseTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private SessionAdvertiseType item1_;

	private SessionAdvertiseType item2_;

	public static MessageParser<SessionAdvertiseTypeTupleWrapper> Parser => _parser;

	public SessionAdvertiseType Item1
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

	public SessionAdvertiseType Item2
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

	public SessionAdvertiseTypeTupleWrapper()
	{
	}

	public SessionAdvertiseTypeTupleWrapper(SessionAdvertiseTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionAdvertiseTypeTupleWrapper Clone()
	{
		return new SessionAdvertiseTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionAdvertiseTypeTupleWrapper);
	}

	public bool Equals(SessionAdvertiseTypeTupleWrapper other)
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
		if (Item1 != SessionAdvertiseType.Private)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != SessionAdvertiseType.Private)
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
		if (Item1 != SessionAdvertiseType.Private)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != SessionAdvertiseType.Private)
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
		if (Item1 != SessionAdvertiseType.Private)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != SessionAdvertiseType.Private)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionAdvertiseTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != SessionAdvertiseType.Private)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != SessionAdvertiseType.Private)
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
				Item1 = (SessionAdvertiseType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (SessionAdvertiseType)input.ReadEnum();
				break;
			}
		}
	}
}
