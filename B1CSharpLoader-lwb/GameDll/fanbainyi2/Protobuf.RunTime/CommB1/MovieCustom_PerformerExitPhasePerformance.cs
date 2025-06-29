using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PerformerExitPhasePerformance : IMessage<MovieCustom_PerformerExitPhasePerformance>, IMessage, IEquatable<MovieCustom_PerformerExitPhasePerformance>, IDeepCloneable<MovieCustom_PerformerExitPhasePerformance>
{
	private static readonly MessageParser<MovieCustom_PerformerExitPhasePerformance> _parser = new MessageParser<MovieCustom_PerformerExitPhasePerformance>(() => new MovieCustom_PerformerExitPhasePerformance());

	private UnknownFieldSet _unknownFields;

	private string performerGuid_ = "";

	public static MessageParser<MovieCustom_PerformerExitPhasePerformance> Parser => _parser;

	public string PerformerGuid
	{
		get
		{
			return performerGuid_;
		}
		set
		{
			performerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MovieCustom_PerformerExitPhasePerformance()
	{
	}

	public MovieCustom_PerformerExitPhasePerformance(MovieCustom_PerformerExitPhasePerformance other)
		: this()
	{
		performerGuid_ = other.performerGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PerformerExitPhasePerformance Clone()
	{
		return new MovieCustom_PerformerExitPhasePerformance(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PerformerExitPhasePerformance);
	}

	public bool Equals(MovieCustom_PerformerExitPhasePerformance other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformerGuid != other.PerformerGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PerformerGuid.Length != 0)
		{
			num ^= PerformerGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PerformerGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PerformerGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PerformerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PerformerGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PerformerExitPhasePerformance other)
	{
		if (other != null)
		{
			if (other.PerformerGuid.Length != 0)
			{
				PerformerGuid = other.PerformerGuid;
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
				PerformerGuid = input.ReadString();
			}
		}
	}
}
