using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class SoulSkillDropStatusTupleWrapper : IMessage<SoulSkillDropStatusTupleWrapper>, IMessage, IEquatable<SoulSkillDropStatusTupleWrapper>, IDeepCloneable<SoulSkillDropStatusTupleWrapper>
{
	private static readonly MessageParser<SoulSkillDropStatusTupleWrapper> _parser = new MessageParser<SoulSkillDropStatusTupleWrapper>(() => new SoulSkillDropStatusTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private SoulSkillDropStatus item1_;

	private SoulSkillDropStatus item2_;

	public static MessageParser<SoulSkillDropStatusTupleWrapper> Parser => _parser;

	public SoulSkillDropStatus Item1
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

	public SoulSkillDropStatus Item2
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

	public SoulSkillDropStatusTupleWrapper()
	{
	}

	public SoulSkillDropStatusTupleWrapper(SoulSkillDropStatusTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SoulSkillDropStatusTupleWrapper Clone()
	{
		return new SoulSkillDropStatusTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SoulSkillDropStatusTupleWrapper);
	}

	public bool Equals(SoulSkillDropStatusTupleWrapper other)
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
		if (Item1 != SoulSkillDropStatus.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != SoulSkillDropStatus.None)
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
		if (Item1 != SoulSkillDropStatus.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != SoulSkillDropStatus.None)
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
		if (Item1 != SoulSkillDropStatus.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != SoulSkillDropStatus.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SoulSkillDropStatusTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != SoulSkillDropStatus.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != SoulSkillDropStatus.None)
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
				Item1 = (SoulSkillDropStatus)input.ReadEnum();
				break;
			case 16u:
				Item2 = (SoulSkillDropStatus)input.ReadEnum();
				break;
			}
		}
	}
}
