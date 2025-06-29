using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PlayFromMarkedFrame : IMessage<MovieCustom_PlayFromMarkedFrame>, IMessage, IEquatable<MovieCustom_PlayFromMarkedFrame>, IDeepCloneable<MovieCustom_PlayFromMarkedFrame>
{
	private static readonly MessageParser<MovieCustom_PlayFromMarkedFrame> _parser = new MessageParser<MovieCustom_PlayFromMarkedFrame>(() => new MovieCustom_PlayFromMarkedFrame());

	private UnknownFieldSet _unknownFields;

	private string markedFrameLabel_ = "";

	public static MessageParser<MovieCustom_PlayFromMarkedFrame> Parser => _parser;

	public string MarkedFrameLabel
	{
		get
		{
			return markedFrameLabel_;
		}
		set
		{
			markedFrameLabel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MovieCustom_PlayFromMarkedFrame()
	{
	}

	public MovieCustom_PlayFromMarkedFrame(MovieCustom_PlayFromMarkedFrame other)
		: this()
	{
		markedFrameLabel_ = other.markedFrameLabel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PlayFromMarkedFrame Clone()
	{
		return new MovieCustom_PlayFromMarkedFrame(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PlayFromMarkedFrame);
	}

	public bool Equals(MovieCustom_PlayFromMarkedFrame other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MarkedFrameLabel != other.MarkedFrameLabel)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MarkedFrameLabel.Length != 0)
		{
			num ^= MarkedFrameLabel.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MarkedFrameLabel.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(MarkedFrameLabel);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MarkedFrameLabel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MarkedFrameLabel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PlayFromMarkedFrame other)
	{
		if (other != null)
		{
			if (other.MarkedFrameLabel.Length != 0)
			{
				MarkedFrameLabel = other.MarkedFrameLabel;
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
				MarkedFrameLabel = input.ReadString();
			}
		}
	}
}
