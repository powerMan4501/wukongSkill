using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_ChildActorDestruct : IMessage<BehaviorCustom_ChildActorDestruct>, IMessage, IEquatable<BehaviorCustom_ChildActorDestruct>, IDeepCloneable<BehaviorCustom_ChildActorDestruct>
{
	private static readonly MessageParser<BehaviorCustom_ChildActorDestruct> _parser = new MessageParser<BehaviorCustom_ChildActorDestruct>(() => new BehaviorCustom_ChildActorDestruct());

	private UnknownFieldSet _unknownFields;

	private bool isDestructed_;

	private ByteString matchInfo_ = ByteString.Empty;

	public static MessageParser<BehaviorCustom_ChildActorDestruct> Parser => _parser;

	public bool IsDestructed
	{
		get
		{
			return isDestructed_;
		}
		set
		{
			isDestructed_ = value;
		}
	}

	public ByteString MatchInfo
	{
		get
		{
			return matchInfo_;
		}
		set
		{
			matchInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_ChildActorDestruct()
	{
	}

	public BehaviorCustom_ChildActorDestruct(BehaviorCustom_ChildActorDestruct other)
		: this()
	{
		isDestructed_ = other.isDestructed_;
		matchInfo_ = other.matchInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_ChildActorDestruct Clone()
	{
		return new BehaviorCustom_ChildActorDestruct(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_ChildActorDestruct);
	}

	public bool Equals(BehaviorCustom_ChildActorDestruct other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsDestructed != other.IsDestructed)
		{
			return false;
		}
		if (MatchInfo != other.MatchInfo)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsDestructed)
		{
			num ^= IsDestructed.GetHashCode();
		}
		if (MatchInfo.Length != 0)
		{
			num ^= MatchInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsDestructed)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsDestructed);
		}
		if (MatchInfo.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(MatchInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsDestructed)
		{
			num += 2;
		}
		if (MatchInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(MatchInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_ChildActorDestruct other)
	{
		if (other != null)
		{
			if (other.IsDestructed)
			{
				IsDestructed = other.IsDestructed;
			}
			if (other.MatchInfo.Length != 0)
			{
				MatchInfo = other.MatchInfo;
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
				IsDestructed = input.ReadBool();
				break;
			case 18u:
				MatchInfo = input.ReadBytes();
				break;
			}
		}
	}
}
