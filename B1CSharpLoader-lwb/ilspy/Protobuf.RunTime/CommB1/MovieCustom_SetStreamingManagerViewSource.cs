using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_SetStreamingManagerViewSource : IMessage<MovieCustom_SetStreamingManagerViewSource>, IMessage, IEquatable<MovieCustom_SetStreamingManagerViewSource>, IDeepCloneable<MovieCustom_SetStreamingManagerViewSource>
{
	private static readonly MessageParser<MovieCustom_SetStreamingManagerViewSource> _parser = new MessageParser<MovieCustom_SetStreamingManagerViewSource>(() => new MovieCustom_SetStreamingManagerViewSource());

	private UnknownFieldSet _unknownFields;

	private bool isAlive_;

	private static readonly FieldCodec<float> _repeated_transformX_codec = FieldCodec.ForFloat(18u);

	private readonly RepeatedField<float> transformX_ = new RepeatedField<float>();

	private static readonly FieldCodec<float> _repeated_transformY_codec = FieldCodec.ForFloat(26u);

	private readonly RepeatedField<float> transformY_ = new RepeatedField<float>();

	private static readonly FieldCodec<float> _repeated_transformZ_codec = FieldCodec.ForFloat(34u);

	private readonly RepeatedField<float> transformZ_ = new RepeatedField<float>();

	public static MessageParser<MovieCustom_SetStreamingManagerViewSource> Parser => _parser;

	public bool IsAlive
	{
		get
		{
			return isAlive_;
		}
		set
		{
			isAlive_ = value;
		}
	}

	public RepeatedField<float> TransformX => transformX_;

	public RepeatedField<float> TransformY => transformY_;

	public RepeatedField<float> TransformZ => transformZ_;

	public MovieCustom_SetStreamingManagerViewSource()
	{
	}

	public MovieCustom_SetStreamingManagerViewSource(MovieCustom_SetStreamingManagerViewSource other)
		: this()
	{
		isAlive_ = other.isAlive_;
		transformX_ = other.transformX_.Clone();
		transformY_ = other.transformY_.Clone();
		transformZ_ = other.transformZ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_SetStreamingManagerViewSource Clone()
	{
		return new MovieCustom_SetStreamingManagerViewSource(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_SetStreamingManagerViewSource);
	}

	public bool Equals(MovieCustom_SetStreamingManagerViewSource other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsAlive != other.IsAlive)
		{
			return false;
		}
		if (!transformX_.Equals(other.transformX_))
		{
			return false;
		}
		if (!transformY_.Equals(other.transformY_))
		{
			return false;
		}
		if (!transformZ_.Equals(other.transformZ_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsAlive)
		{
			num ^= IsAlive.GetHashCode();
		}
		num ^= transformX_.GetHashCode();
		num ^= transformY_.GetHashCode();
		num ^= transformZ_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsAlive)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsAlive);
		}
		transformX_.WriteTo(output, _repeated_transformX_codec);
		transformY_.WriteTo(output, _repeated_transformY_codec);
		transformZ_.WriteTo(output, _repeated_transformZ_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsAlive)
		{
			num += 2;
		}
		num += transformX_.CalculateSize(_repeated_transformX_codec);
		num += transformY_.CalculateSize(_repeated_transformY_codec);
		num += transformZ_.CalculateSize(_repeated_transformZ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_SetStreamingManagerViewSource other)
	{
		if (other != null)
		{
			if (other.IsAlive)
			{
				IsAlive = other.IsAlive;
			}
			transformX_.Add(other.transformX_);
			transformY_.Add(other.transformY_);
			transformZ_.Add(other.transformZ_);
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
			case 8u:
				IsAlive = input.ReadBool();
				break;
			case 18u:
			case 21u:
				transformX_.AddEntriesFrom(input, _repeated_transformX_codec);
				break;
			case 26u:
			case 29u:
				transformY_.AddEntriesFrom(input, _repeated_transformY_codec);
				break;
			case 34u:
			case 37u:
				transformZ_.AddEntriesFrom(input, _repeated_transformZ_codec);
				break;
			}
		}
	}
}
