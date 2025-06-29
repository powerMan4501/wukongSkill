using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionPatchStatusTupleWrapper : IMessage<VersionPatchStatusTupleWrapper>, IMessage, IEquatable<VersionPatchStatusTupleWrapper>, IDeepCloneable<VersionPatchStatusTupleWrapper>
{
	private static readonly MessageParser<VersionPatchStatusTupleWrapper> _parser = new MessageParser<VersionPatchStatusTupleWrapper>(() => new VersionPatchStatusTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private VersionPatchStatus item1_;

	private VersionPatchStatus item2_;

	public static MessageParser<VersionPatchStatusTupleWrapper> Parser => _parser;

	public VersionPatchStatus Item1
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

	public VersionPatchStatus Item2
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

	public VersionPatchStatusTupleWrapper()
	{
	}

	public VersionPatchStatusTupleWrapper(VersionPatchStatusTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionPatchStatusTupleWrapper Clone()
	{
		return new VersionPatchStatusTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionPatchStatusTupleWrapper);
	}

	public bool Equals(VersionPatchStatusTupleWrapper other)
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
		if (Item1 != VersionPatchStatus.Disabled)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != VersionPatchStatus.Disabled)
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
		if (Item1 != VersionPatchStatus.Disabled)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != VersionPatchStatus.Disabled)
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
		if (Item1 != VersionPatchStatus.Disabled)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != VersionPatchStatus.Disabled)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionPatchStatusTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != VersionPatchStatus.Disabled)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != VersionPatchStatus.Disabled)
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
				Item1 = (VersionPatchStatus)input.ReadEnum();
				break;
			case 16u:
				Item2 = (VersionPatchStatus)input.ReadEnum();
				break;
			}
		}
	}
}
