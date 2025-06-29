using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_Transformation : IMessage<MovieCustom_Transformation>, IMessage, IEquatable<MovieCustom_Transformation>, IDeepCloneable<MovieCustom_Transformation>
{
	private static readonly MessageParser<MovieCustom_Transformation> _parser = new MessageParser<MovieCustom_Transformation>(() => new MovieCustom_Transformation());

	private UnknownFieldSet _unknownFields;

	private int resId_;

	public static MessageParser<MovieCustom_Transformation> Parser => _parser;

	public int ResId
	{
		get
		{
			return resId_;
		}
		set
		{
			resId_ = value;
		}
	}

	public MovieCustom_Transformation()
	{
	}

	public MovieCustom_Transformation(MovieCustom_Transformation other)
		: this()
	{
		resId_ = other.resId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_Transformation Clone()
	{
		return new MovieCustom_Transformation(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_Transformation);
	}

	public bool Equals(MovieCustom_Transformation other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ResId != other.ResId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ResId != 0)
		{
			num ^= ResId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ResId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ResId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ResId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_Transformation other)
	{
		if (other != null)
		{
			if (other.ResId != 0)
			{
				ResId = other.ResId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				ResId = input.ReadInt32();
			}
		}
	}
}
