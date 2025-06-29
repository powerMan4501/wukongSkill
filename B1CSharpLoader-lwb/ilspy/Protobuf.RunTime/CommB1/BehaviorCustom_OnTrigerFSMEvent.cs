using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_OnTrigerFSMEvent : IMessage<BehaviorCustom_OnTrigerFSMEvent>, IMessage, IEquatable<BehaviorCustom_OnTrigerFSMEvent>, IDeepCloneable<BehaviorCustom_OnTrigerFSMEvent>
{
	private static readonly MessageParser<BehaviorCustom_OnTrigerFSMEvent> _parser = new MessageParser<BehaviorCustom_OnTrigerFSMEvent>(() => new BehaviorCustom_OnTrigerFSMEvent());

	private UnknownFieldSet _unknownFields;

	private string eventName_ = "";

	public static MessageParser<BehaviorCustom_OnTrigerFSMEvent> Parser => _parser;

	public string EventName
	{
		get
		{
			return eventName_;
		}
		set
		{
			eventName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_OnTrigerFSMEvent()
	{
	}

	public BehaviorCustom_OnTrigerFSMEvent(BehaviorCustom_OnTrigerFSMEvent other)
		: this()
	{
		eventName_ = other.eventName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_OnTrigerFSMEvent Clone()
	{
		return new BehaviorCustom_OnTrigerFSMEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_OnTrigerFSMEvent);
	}

	public bool Equals(BehaviorCustom_OnTrigerFSMEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventName != other.EventName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EventName.Length != 0)
		{
			num ^= EventName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EventName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(EventName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EventName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EventName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_OnTrigerFSMEvent other)
	{
		if (other != null)
		{
			if (other.EventName.Length != 0)
			{
				EventName = other.EventName;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				EventName = input.ReadString();
			}
		}
	}
}
