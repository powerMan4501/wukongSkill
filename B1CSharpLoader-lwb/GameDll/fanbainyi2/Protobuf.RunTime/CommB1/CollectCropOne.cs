using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CollectCropOne : IMessage<CollectCropOne>, IMessage, IEquatable<CollectCropOne>, IDeepCloneable<CollectCropOne>
{
	private static readonly MessageParser<CollectCropOne> _parser = new MessageParser<CollectCropOne>(() => new CollectCropOne());

	private UnknownFieldSet _unknownFields;

	private int seedId_;

	private int outputId_;

	private int collectNum_;

	public static MessageParser<CollectCropOne> Parser => _parser;

	public int SeedId
	{
		get
		{
			return seedId_;
		}
		set
		{
			seedId_ = value;
		}
	}

	public int OutputId
	{
		get
		{
			return outputId_;
		}
		set
		{
			outputId_ = value;
		}
	}

	public int CollectNum
	{
		get
		{
			return collectNum_;
		}
		set
		{
			collectNum_ = value;
		}
	}

	public CollectCropOne()
	{
	}

	public CollectCropOne(CollectCropOne other)
		: this()
	{
		seedId_ = other.seedId_;
		outputId_ = other.outputId_;
		collectNum_ = other.collectNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CollectCropOne Clone()
	{
		return new CollectCropOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CollectCropOne);
	}

	public bool Equals(CollectCropOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SeedId != other.SeedId)
		{
			return false;
		}
		if (OutputId != other.OutputId)
		{
			return false;
		}
		if (CollectNum != other.CollectNum)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SeedId != 0)
		{
			num ^= SeedId.GetHashCode();
		}
		if (OutputId != 0)
		{
			num ^= OutputId.GetHashCode();
		}
		if (CollectNum != 0)
		{
			num ^= CollectNum.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SeedId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SeedId);
		}
		if (OutputId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OutputId);
		}
		if (CollectNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CollectNum);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SeedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeedId);
		}
		if (OutputId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OutputId);
		}
		if (CollectNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CollectCropOne other)
	{
		if (other != null)
		{
			if (other.SeedId != 0)
			{
				SeedId = other.SeedId;
			}
			if (other.OutputId != 0)
			{
				OutputId = other.OutputId;
			}
			if (other.CollectNum != 0)
			{
				CollectNum = other.CollectNum;
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
				SeedId = input.ReadInt32();
				break;
			case 16u:
				OutputId = input.ReadInt32();
				break;
			case 24u:
				CollectNum = input.ReadInt32();
				break;
			}
		}
	}
}
