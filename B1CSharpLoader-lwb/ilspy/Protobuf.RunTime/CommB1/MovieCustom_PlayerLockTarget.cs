using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PlayerLockTarget : IMessage<MovieCustom_PlayerLockTarget>, IMessage, IEquatable<MovieCustom_PlayerLockTarget>, IDeepCloneable<MovieCustom_PlayerLockTarget>
{
	private static readonly MessageParser<MovieCustom_PlayerLockTarget> _parser = new MessageParser<MovieCustom_PlayerLockTarget>(() => new MovieCustom_PlayerLockTarget());

	private UnknownFieldSet _unknownFields;

	private string targetGuid_ = "";

	private bool isUnlock_;

	public static MessageParser<MovieCustom_PlayerLockTarget> Parser => _parser;

	public string TargetGuid
	{
		get
		{
			return targetGuid_;
		}
		set
		{
			targetGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsUnlock
	{
		get
		{
			return isUnlock_;
		}
		set
		{
			isUnlock_ = value;
		}
	}

	public MovieCustom_PlayerLockTarget()
	{
	}

	public MovieCustom_PlayerLockTarget(MovieCustom_PlayerLockTarget other)
		: this()
	{
		targetGuid_ = other.targetGuid_;
		isUnlock_ = other.isUnlock_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PlayerLockTarget Clone()
	{
		return new MovieCustom_PlayerLockTarget(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PlayerLockTarget);
	}

	public bool Equals(MovieCustom_PlayerLockTarget other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetGuid != other.TargetGuid)
		{
			return false;
		}
		if (IsUnlock != other.IsUnlock)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TargetGuid.Length != 0)
		{
			num ^= TargetGuid.GetHashCode();
		}
		if (IsUnlock)
		{
			num ^= IsUnlock.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TargetGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(TargetGuid);
		}
		if (IsUnlock)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsUnlock);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TargetGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TargetGuid);
		}
		if (IsUnlock)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PlayerLockTarget other)
	{
		if (other != null)
		{
			if (other.TargetGuid.Length != 0)
			{
				TargetGuid = other.TargetGuid;
			}
			if (other.IsUnlock)
			{
				IsUnlock = other.IsUnlock;
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
			case 10u:
				TargetGuid = input.ReadString();
				break;
			case 16u:
				IsUnlock = input.ReadBool();
				break;
			}
		}
	}
}
