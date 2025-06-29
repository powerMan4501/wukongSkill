using System;
using Google.Protobuf;

namespace OssB1;

public sealed class QuitTypeTupleWrapper : IMessage<QuitTypeTupleWrapper>, IMessage, IEquatable<QuitTypeTupleWrapper>, IDeepCloneable<QuitTypeTupleWrapper>
{
	private static readonly MessageParser<QuitTypeTupleWrapper> _parser = new MessageParser<QuitTypeTupleWrapper>(() => new QuitTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private QuitType item1_;

	private QuitType item2_;

	public static MessageParser<QuitTypeTupleWrapper> Parser => _parser;

	public QuitType Item1
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

	public QuitType Item2
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

	public QuitTypeTupleWrapper()
	{
	}

	public QuitTypeTupleWrapper(QuitTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuitTypeTupleWrapper Clone()
	{
		return new QuitTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuitTypeTupleWrapper);
	}

	public bool Equals(QuitTypeTupleWrapper other)
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
		if (Item1 != QuitType.RoleQuit)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != QuitType.RoleQuit)
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
		if (Item1 != QuitType.RoleQuit)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != QuitType.RoleQuit)
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
		if (Item1 != QuitType.RoleQuit)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != QuitType.RoleQuit)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuitTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != QuitType.RoleQuit)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != QuitType.RoleQuit)
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
				Item1 = (QuitType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (QuitType)input.ReadEnum();
				break;
			}
		}
	}
}
