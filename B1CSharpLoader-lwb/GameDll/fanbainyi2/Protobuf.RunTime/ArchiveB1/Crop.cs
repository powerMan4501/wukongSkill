using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class Crop : IMessage<Crop>, IMessage, IEquatable<Crop>, IDeepCloneable<Crop>
{
	private static readonly MessageParser<Crop> _parser = new MessageParser<Crop>(() => new Crop());

	private UnknownFieldSet _unknownFields;

	private int seedId_;

	private static readonly FieldCodec<CropOutput> _repeated_outputList_codec = FieldCodec.ForMessage(42u, CropOutput.Parser);

	private readonly RepeatedField<CropOutput> outputList_ = new RepeatedField<CropOutput>();

	public static MessageParser<Crop> Parser => _parser;

	public int SeedId
	{
		get
		{
			return seedId_;
		}
		set
		{
			seedId_ = value;
		}
	}

	public RepeatedField<CropOutput> OutputList => outputList_;

	public Crop()
	{
	}

	public Crop(Crop other)
		: this()
	{
		seedId_ = other.seedId_;
		outputList_ = other.outputList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Crop Clone()
	{
		return new Crop(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Crop);
	}

	public bool Equals(Crop other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SeedId != other.SeedId)
		{
			return false;
		}
		if (!outputList_.Equals(other.outputList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SeedId != 0)
		{
			num ^= SeedId.GetHashCode();
		}
		num ^= outputList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SeedId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SeedId);
		}
		outputList_.WriteTo(output, _repeated_outputList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SeedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeedId);
		}
		num += outputList_.CalculateSize(_repeated_outputList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Crop other)
	{
		if (other != null)
		{
			if (other.SeedId != 0)
			{
				SeedId = other.SeedId;
			}
			outputList_.Add(other.outputList_);
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
			case 32u:
				SeedId = input.ReadInt32();
				break;
			case 42u:
				outputList_.AddEntriesFrom(input, _repeated_outputList_codec);
				break;
			}
		}
	}
}
