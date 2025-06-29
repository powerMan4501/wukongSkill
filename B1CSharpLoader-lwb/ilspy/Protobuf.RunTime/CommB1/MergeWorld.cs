using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MergeWorld : IMessage<MergeWorld>, IMessage, IEquatable<MergeWorld>, IDeepCloneable<MergeWorld>
{
	private static readonly MessageParser<MergeWorld> _parser = new MessageParser<MergeWorld>(() => new MergeWorld());

	private UnknownFieldSet _unknownFields;

	private uint lastLoginWorld_;

	private uint lastMergeTime_;

	public static MessageParser<MergeWorld> Parser => _parser;

	public uint LastLoginWorld
	{
		get
		{
			return lastLoginWorld_;
		}
		set
		{
			lastLoginWorld_ = value;
		}
	}

	public uint LastMergeTime
	{
		get
		{
			return lastMergeTime_;
		}
		set
		{
			lastMergeTime_ = value;
		}
	}

	public MergeWorld()
	{
	}

	public MergeWorld(MergeWorld other)
		: this()
	{
		lastLoginWorld_ = other.lastLoginWorld_;
		lastMergeTime_ = other.lastMergeTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MergeWorld Clone()
	{
		return new MergeWorld(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MergeWorld);
	}

	public bool Equals(MergeWorld other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LastLoginWorld != other.LastLoginWorld)
		{
			return false;
		}
		if (LastMergeTime != other.LastMergeTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LastLoginWorld != 0)
		{
			num ^= LastLoginWorld.GetHashCode();
		}
		if (LastMergeTime != 0)
		{
			num ^= LastMergeTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LastLoginWorld != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LastLoginWorld);
		}
		if (LastMergeTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LastMergeTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LastLoginWorld != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LastLoginWorld);
		}
		if (LastMergeTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LastMergeTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MergeWorld other)
	{
		if (other != null)
		{
			if (other.LastLoginWorld != 0)
			{
				LastLoginWorld = other.LastLoginWorld;
			}
			if (other.LastMergeTime != 0)
			{
				LastMergeTime = other.LastMergeTime;
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
				LastLoginWorld = input.ReadUInt32();
				break;
			case 16u:
				LastMergeTime = input.ReadUInt32();
				break;
			}
		}
	}
}
