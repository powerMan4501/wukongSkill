using System;
using Google.Protobuf;

namespace ResB1;

public sealed class SeedCollectionAwardDesc : IMessage<SeedCollectionAwardDesc>, IMessage, IEquatable<SeedCollectionAwardDesc>, IDeepCloneable<SeedCollectionAwardDesc>
{
	private static readonly MessageParser<SeedCollectionAwardDesc> _parser = new MessageParser<SeedCollectionAwardDesc>(() => new SeedCollectionAwardDesc());

	private UnknownFieldSet _unknownFields;

	private int dropId_;

	private int collectNum_;

	private string animMontagePath_ = "";

	public static MessageParser<SeedCollectionAwardDesc> Parser => _parser;

	public int DropId
	{
		get
		{
			return dropId_;
		}
		set
		{
			dropId_ = value;
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

	public string AnimMontagePath
	{
		get
		{
			return animMontagePath_;
		}
		set
		{
			animMontagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public SeedCollectionAwardDesc()
	{
	}

	public SeedCollectionAwardDesc(SeedCollectionAwardDesc other)
		: this()
	{
		dropId_ = other.dropId_;
		collectNum_ = other.collectNum_;
		animMontagePath_ = other.animMontagePath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SeedCollectionAwardDesc Clone()
	{
		return new SeedCollectionAwardDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SeedCollectionAwardDesc);
	}

	public bool Equals(SeedCollectionAwardDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DropId != other.DropId)
		{
			return false;
		}
		if (CollectNum != other.CollectNum)
		{
			return false;
		}
		if (AnimMontagePath != other.AnimMontagePath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DropId != 0)
		{
			num ^= DropId.GetHashCode();
		}
		if (CollectNum != 0)
		{
			num ^= CollectNum.GetHashCode();
		}
		if (AnimMontagePath.Length != 0)
		{
			num ^= AnimMontagePath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DropId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DropId);
		}
		if (CollectNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CollectNum);
		}
		if (AnimMontagePath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AnimMontagePath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropId);
		}
		if (CollectNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectNum);
		}
		if (AnimMontagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AnimMontagePath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SeedCollectionAwardDesc other)
	{
		if (other != null)
		{
			if (other.DropId != 0)
			{
				DropId = other.DropId;
			}
			if (other.CollectNum != 0)
			{
				CollectNum = other.CollectNum;
			}
			if (other.AnimMontagePath.Length != 0)
			{
				AnimMontagePath = other.AnimMontagePath;
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
				DropId = input.ReadInt32();
				break;
			case 16u:
				CollectNum = input.ReadInt32();
				break;
			case 26u:
				AnimMontagePath = input.ReadString();
				break;
			}
		}
	}
}
