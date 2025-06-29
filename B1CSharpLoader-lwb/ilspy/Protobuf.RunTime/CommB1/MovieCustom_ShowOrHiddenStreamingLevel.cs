using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_ShowOrHiddenStreamingLevel : IMessage<MovieCustom_ShowOrHiddenStreamingLevel>, IMessage, IEquatable<MovieCustom_ShowOrHiddenStreamingLevel>, IDeepCloneable<MovieCustom_ShowOrHiddenStreamingLevel>
{
	private static readonly MessageParser<MovieCustom_ShowOrHiddenStreamingLevel> _parser = new MessageParser<MovieCustom_ShowOrHiddenStreamingLevel>(() => new MovieCustom_ShowOrHiddenStreamingLevel());

	private UnknownFieldSet _unknownFields;

	private string streamingLevelName_ = "";

	private bool isVisible_;

	public static MessageParser<MovieCustom_ShowOrHiddenStreamingLevel> Parser => _parser;

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

	public bool IsVisible
	{
		get
		{
			return isVisible_;
		}
		set
		{
			isVisible_ = value;
		}
	}

	public MovieCustom_ShowOrHiddenStreamingLevel()
	{
	}

	public MovieCustom_ShowOrHiddenStreamingLevel(MovieCustom_ShowOrHiddenStreamingLevel other)
		: this()
	{
		streamingLevelName_ = other.streamingLevelName_;
		isVisible_ = other.isVisible_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_ShowOrHiddenStreamingLevel Clone()
	{
		return new MovieCustom_ShowOrHiddenStreamingLevel(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_ShowOrHiddenStreamingLevel);
	}

	public bool Equals(MovieCustom_ShowOrHiddenStreamingLevel other)
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
		if (IsVisible != other.IsVisible)
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
		if (IsVisible)
		{
			num ^= IsVisible.GetHashCode();
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
		if (IsVisible)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsVisible);
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
		if (IsVisible)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_ShowOrHiddenStreamingLevel other)
	{
		if (other != null)
		{
			if (other.StreamingLevelName.Length != 0)
			{
				StreamingLevelName = other.StreamingLevelName;
			}
			if (other.IsVisible)
			{
				IsVisible = other.IsVisible;
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
				IsVisible = input.ReadBool();
				break;
			}
		}
	}
}
