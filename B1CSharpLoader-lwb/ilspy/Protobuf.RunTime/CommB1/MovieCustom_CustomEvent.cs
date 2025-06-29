using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_CustomEvent : IMessage<MovieCustom_CustomEvent>, IMessage, IEquatable<MovieCustom_CustomEvent>, IDeepCloneable<MovieCustom_CustomEvent>
{
	private static readonly MessageParser<MovieCustom_CustomEvent> _parser = new MessageParser<MovieCustom_CustomEvent>(() => new MovieCustom_CustomEvent());

	private UnknownFieldSet _unknownFields;

	private string eventName_ = "";

	public static MessageParser<MovieCustom_CustomEvent> Parser => _parser;

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

	public MovieCustom_CustomEvent()
	{
	}

	public MovieCustom_CustomEvent(MovieCustom_CustomEvent other)
		: this()
	{
		eventName_ = other.eventName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_CustomEvent Clone()
	{
		return new MovieCustom_CustomEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_CustomEvent);
	}

	public bool Equals(MovieCustom_CustomEvent other)
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

	public void MergeFrom(MovieCustom_CustomEvent other)
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
