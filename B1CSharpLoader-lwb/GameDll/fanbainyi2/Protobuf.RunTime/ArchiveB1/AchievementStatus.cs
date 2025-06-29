using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class AchievementStatus : IMessage<AchievementStatus>, IMessage, IEquatable<AchievementStatus>, IDeepCloneable<AchievementStatus>
{
	private static readonly MessageParser<AchievementStatus> _parser = new MessageParser<AchievementStatus>(() => new AchievementStatus());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private double progress_;

	public static MessageParser<AchievementStatus> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public double Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	public AchievementStatus()
	{
	}

	public AchievementStatus(AchievementStatus other)
		: this()
	{
		id_ = other.id_;
		progress_ = other.progress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementStatus Clone()
	{
		return new AchievementStatus(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementStatus);
	}

	public bool Equals(AchievementStatus other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Progress, other.Progress))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Progress != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Progress);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Progress != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(Progress);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Progress != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementStatus other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Progress != 0.0)
			{
				Progress = other.Progress;
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
				Id = input.ReadInt32();
				break;
			case 17u:
				Progress = input.ReadDouble();
				break;
			}
		}
	}
}
