using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_NotifyExclusiveItem : IMessage<BehaviorCustom_NotifyExclusiveItem>, IMessage, IEquatable<BehaviorCustom_NotifyExclusiveItem>, IDeepCloneable<BehaviorCustom_NotifyExclusiveItem>
{
	private static readonly MessageParser<BehaviorCustom_NotifyExclusiveItem> _parser = new MessageParser<BehaviorCustom_NotifyExclusiveItem>(() => new BehaviorCustom_NotifyExclusiveItem());

	private UnknownFieldSet _unknownFields;

	private string actorTag_ = "";

	private string notifyTag_ = "";

	public static MessageParser<BehaviorCustom_NotifyExclusiveItem> Parser => _parser;

	public string ActorTag
	{
		get
		{
			return actorTag_;
		}
		set
		{
			actorTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NotifyTag
	{
		get
		{
			return notifyTag_;
		}
		set
		{
			notifyTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_NotifyExclusiveItem()
	{
	}

	public BehaviorCustom_NotifyExclusiveItem(BehaviorCustom_NotifyExclusiveItem other)
		: this()
	{
		actorTag_ = other.actorTag_;
		notifyTag_ = other.notifyTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_NotifyExclusiveItem Clone()
	{
		return new BehaviorCustom_NotifyExclusiveItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_NotifyExclusiveItem);
	}

	public bool Equals(BehaviorCustom_NotifyExclusiveItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ActorTag != other.ActorTag)
		{
			return false;
		}
		if (NotifyTag != other.NotifyTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ActorTag.Length != 0)
		{
			num ^= ActorTag.GetHashCode();
		}
		if (NotifyTag.Length != 0)
		{
			num ^= NotifyTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ActorTag.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ActorTag);
		}
		if (NotifyTag.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(NotifyTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ActorTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ActorTag);
		}
		if (NotifyTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NotifyTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_NotifyExclusiveItem other)
	{
		if (other != null)
		{
			if (other.ActorTag.Length != 0)
			{
				ActorTag = other.ActorTag;
			}
			if (other.NotifyTag.Length != 0)
			{
				NotifyTag = other.NotifyTag;
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
				ActorTag = input.ReadString();
				break;
			case 18u:
				NotifyTag = input.ReadString();
				break;
			}
		}
	}
}
