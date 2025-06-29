using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_ActivateOrDeactivateStreamingSource : IMessage<MovieCustom_ActivateOrDeactivateStreamingSource>, IMessage, IEquatable<MovieCustom_ActivateOrDeactivateStreamingSource>, IDeepCloneable<MovieCustom_ActivateOrDeactivateStreamingSource>
{
	private static readonly MessageParser<MovieCustom_ActivateOrDeactivateStreamingSource> _parser = new MessageParser<MovieCustom_ActivateOrDeactivateStreamingSource>(() => new MovieCustom_ActivateOrDeactivateStreamingSource());

	private UnknownFieldSet _unknownFields;

	private bool isEnable_;

	private static readonly FieldCodec<float> _repeated_transformX_codec = FieldCodec.ForFloat(18u);

	private readonly RepeatedField<float> transformX_ = new RepeatedField<float>();

	private static readonly FieldCodec<float> _repeated_transformY_codec = FieldCodec.ForFloat(26u);

	private readonly RepeatedField<float> transformY_ = new RepeatedField<float>();

	private static readonly FieldCodec<float> _repeated_transformZ_codec = FieldCodec.ForFloat(34u);

	private readonly RepeatedField<float> transformZ_ = new RepeatedField<float>();

	public static MessageParser<MovieCustom_ActivateOrDeactivateStreamingSource> Parser => _parser;

	public bool IsEnable
	{
		get
		{
			return isEnable_;
		}
		set
		{
			isEnable_ = value;
		}
	}

	public RepeatedField<float> TransformX => transformX_;

	public RepeatedField<float> TransformY => transformY_;

	public RepeatedField<float> TransformZ => transformZ_;

	public MovieCustom_ActivateOrDeactivateStreamingSource()
	{
	}

	public MovieCustom_ActivateOrDeactivateStreamingSource(MovieCustom_ActivateOrDeactivateStreamingSource other)
		: this()
	{
		isEnable_ = other.isEnable_;
		transformX_ = other.transformX_.Clone();
		transformY_ = other.transformY_.Clone();
		transformZ_ = other.transformZ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_ActivateOrDeactivateStreamingSource Clone()
	{
		return new MovieCustom_ActivateOrDeactivateStreamingSource(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_ActivateOrDeactivateStreamingSource);
	}

	public bool Equals(MovieCustom_ActivateOrDeactivateStreamingSource other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsEnable != other.IsEnable)
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
		if (IsEnable)
		{
			num ^= IsEnable.GetHashCode();
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
		if (IsEnable)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsEnable);
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
		if (IsEnable)
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

	public void MergeFrom(MovieCustom_ActivateOrDeactivateStreamingSource other)
	{
		if (other != null)
		{
			if (other.IsEnable)
			{
				IsEnable = other.IsEnable;
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
				IsEnable = input.ReadBool();
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
