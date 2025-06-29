using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_LoadOrUnloadStreamingLevel : IMessage<MovieCustom_LoadOrUnloadStreamingLevel>, IMessage, IEquatable<MovieCustom_LoadOrUnloadStreamingLevel>, IDeepCloneable<MovieCustom_LoadOrUnloadStreamingLevel>
{
	private static readonly MessageParser<MovieCustom_LoadOrUnloadStreamingLevel> _parser = new MessageParser<MovieCustom_LoadOrUnloadStreamingLevel>(() => new MovieCustom_LoadOrUnloadStreamingLevel());

	private UnknownFieldSet _unknownFields;

	private string streamingLevelName_ = "";

	private bool isLoadOrUnload_;

	private string finishLoadEvent_ = "";

	public static MessageParser<MovieCustom_LoadOrUnloadStreamingLevel> Parser => _parser;

	public string StreamingLevelName
	{
		get
		{
			return streamingLevelName_;
		}
		set
		{
			streamingLevelName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsLoadOrUnload
	{
		get
		{
			return isLoadOrUnload_;
		}
		set
		{
			isLoadOrUnload_ = value;
		}
	}

	public string FinishLoadEvent
	{
		get
		{
			return finishLoadEvent_;
		}
		set
		{
			finishLoadEvent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MovieCustom_LoadOrUnloadStreamingLevel()
	{
	}

	public MovieCustom_LoadOrUnloadStreamingLevel(MovieCustom_LoadOrUnloadStreamingLevel other)
		: this()
	{
		streamingLevelName_ = other.streamingLevelName_;
		isLoadOrUnload_ = other.isLoadOrUnload_;
		finishLoadEvent_ = other.finishLoadEvent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_LoadOrUnloadStreamingLevel Clone()
	{
		return new MovieCustom_LoadOrUnloadStreamingLevel(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_LoadOrUnloadStreamingLevel);
	}

	public bool Equals(MovieCustom_LoadOrUnloadStreamingLevel other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StreamingLevelName != other.StreamingLevelName)
		{
			return false;
		}
		if (IsLoadOrUnload != other.IsLoadOrUnload)
		{
			return false;
		}
		if (FinishLoadEvent != other.FinishLoadEvent)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StreamingLevelName.Length != 0)
		{
			num ^= StreamingLevelName.GetHashCode();
		}
		if (IsLoadOrUnload)
		{
			num ^= IsLoadOrUnload.GetHashCode();
		}
		if (FinishLoadEvent.Length != 0)
		{
			num ^= FinishLoadEvent.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StreamingLevelName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(StreamingLevelName);
		}
		if (IsLoadOrUnload)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsLoadOrUnload);
		}
		if (FinishLoadEvent.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(FinishLoadEvent);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StreamingLevelName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StreamingLevelName);
		}
		if (IsLoadOrUnload)
		{
			num += 2;
		}
		if (FinishLoadEvent.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FinishLoadEvent);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_LoadOrUnloadStreamingLevel other)
	{
		if (other != null)
		{
			if (other.StreamingLevelName.Length != 0)
			{
				StreamingLevelName = other.StreamingLevelName;
			}
			if (other.IsLoadOrUnload)
			{
				IsLoadOrUnload = other.IsLoadOrUnload;
			}
			if (other.FinishLoadEvent.Length != 0)
			{
				FinishLoadEvent = other.FinishLoadEvent;
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
				StreamingLevelName = input.ReadString();
				break;
			case 16u:
				IsLoadOrUnload = input.ReadBool();
				break;
			case 26u:
				FinishLoadEvent = input.ReadString();
				break;
			}
		}
	}
}
