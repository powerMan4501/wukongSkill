using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_ControlChildActor : IMessage<BehaviorCustom_ControlChildActor>, IMessage, IEquatable<BehaviorCustom_ControlChildActor>, IDeepCloneable<BehaviorCustom_ControlChildActor>
{
	private static readonly MessageParser<BehaviorCustom_ControlChildActor> _parser = new MessageParser<BehaviorCustom_ControlChildActor>(() => new BehaviorCustom_ControlChildActor());

	private UnknownFieldSet _unknownFields;

	private ByteString action_ = ByteString.Empty;

	private ByteString matchInfo_ = ByteString.Empty;

	public static MessageParser<BehaviorCustom_ControlChildActor> Parser => _parser;

	public ByteString Action
	{
		get
		{
			return action_;
		}
		set
		{
			action_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public BehaviorCustom_ControlChildActor()
	{
	}

	public BehaviorCustom_ControlChildActor(BehaviorCustom_ControlChildActor other)
		: this()
	{
		action_ = other.action_;
		matchInfo_ = other.matchInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_ControlChildActor Clone()
	{
		return new BehaviorCustom_ControlChildActor(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_ControlChildActor);
	}

	public bool Equals(BehaviorCustom_ControlChildActor other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Action != other.Action)
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
		if (Action.Length != 0)
		{
			num ^= Action.GetHashCode();
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
		if (Action.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(Action);
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
		if (Action.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Action);
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

	public void MergeFrom(BehaviorCustom_ControlChildActor other)
	{
		if (other != null)
		{
			if (other.Action.Length != 0)
			{
				Action = other.Action;
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
			case 10u:
				Action = input.ReadBytes();
				break;
			case 18u:
				MatchInfo = input.ReadBytes();
				break;
			}
		}
	}
}
