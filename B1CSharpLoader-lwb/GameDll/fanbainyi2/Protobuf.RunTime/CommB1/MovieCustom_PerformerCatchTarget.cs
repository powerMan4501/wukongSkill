using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PerformerCatchTarget : IMessage<MovieCustom_PerformerCatchTarget>, IMessage, IEquatable<MovieCustom_PerformerCatchTarget>, IDeepCloneable<MovieCustom_PerformerCatchTarget>
{
	private static readonly MessageParser<MovieCustom_PerformerCatchTarget> _parser = new MessageParser<MovieCustom_PerformerCatchTarget>(() => new MovieCustom_PerformerCatchTarget());

	private UnknownFieldSet _unknownFields;

	private string performerGuid_ = "";

	public static MessageParser<MovieCustom_PerformerCatchTarget> Parser => _parser;

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

	public MovieCustom_PerformerCatchTarget()
	{
	}

	public MovieCustom_PerformerCatchTarget(MovieCustom_PerformerCatchTarget other)
		: this()
	{
		performerGuid_ = other.performerGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PerformerCatchTarget Clone()
	{
		return new MovieCustom_PerformerCatchTarget(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PerformerCatchTarget);
	}

	public bool Equals(MovieCustom_PerformerCatchTarget other)
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

	public void MergeFrom(MovieCustom_PerformerCatchTarget other)
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
