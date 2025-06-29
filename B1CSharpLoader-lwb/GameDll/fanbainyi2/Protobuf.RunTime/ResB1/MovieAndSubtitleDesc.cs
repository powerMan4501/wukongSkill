using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MovieAndSubtitleDesc : IMessage<MovieAndSubtitleDesc>, IMessage, IEquatable<MovieAndSubtitleDesc>, IDeepCloneable<MovieAndSubtitleDesc>
{
	private static readonly MessageParser<MovieAndSubtitleDesc> _parser = new MessageParser<MovieAndSubtitleDesc>(() => new MovieAndSubtitleDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string moviePath_ = "";

	private int resolutionX_;

	private int resolutionY_;

	private string audioVoice_ = "";

	private string audioMusic_ = "";

	private string audioOther_ = "";

	public static MessageParser<MovieAndSubtitleDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string MoviePath
	{
		get
		{
			return moviePath_;
		}
		set
		{
			moviePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ResolutionX
	{
		get
		{
			return resolutionX_;
		}
		set
		{
			resolutionX_ = value;
		}
	}

	public int ResolutionY
	{
		get
		{
			return resolutionY_;
		}
		set
		{
			resolutionY_ = value;
		}
	}

	public string AudioVoice
	{
		get
		{
			return audioVoice_;
		}
		set
		{
			audioVoice_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AudioMusic
	{
		get
		{
			return audioMusic_;
		}
		set
		{
			audioMusic_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AudioOther
	{
		get
		{
			return audioOther_;
		}
		set
		{
			audioOther_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MovieAndSubtitleDesc()
	{
	}

	public MovieAndSubtitleDesc(MovieAndSubtitleDesc other)
		: this()
	{
		id_ = other.id_;
		moviePath_ = other.moviePath_;
		resolutionX_ = other.resolutionX_;
		resolutionY_ = other.resolutionY_;
		audioVoice_ = other.audioVoice_;
		audioMusic_ = other.audioMusic_;
		audioOther_ = other.audioOther_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieAndSubtitleDesc Clone()
	{
		return new MovieAndSubtitleDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieAndSubtitleDesc);
	}

	public bool Equals(MovieAndSubtitleDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (MoviePath != other.MoviePath)
		{
			return false;
		}
		if (ResolutionX != other.ResolutionX)
		{
			return false;
		}
		if (ResolutionY != other.ResolutionY)
		{
			return false;
		}
		if (AudioVoice != other.AudioVoice)
		{
			return false;
		}
		if (AudioMusic != other.AudioMusic)
		{
			return false;
		}
		if (AudioOther != other.AudioOther)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MoviePath.Length != 0)
		{
			num ^= MoviePath.GetHashCode();
		}
		if (ResolutionX != 0)
		{
			num ^= ResolutionX.GetHashCode();
		}
		if (ResolutionY != 0)
		{
			num ^= ResolutionY.GetHashCode();
		}
		if (AudioVoice.Length != 0)
		{
			num ^= AudioVoice.GetHashCode();
		}
		if (AudioMusic.Length != 0)
		{
			num ^= AudioMusic.GetHashCode();
		}
		if (AudioOther.Length != 0)
		{
			num ^= AudioOther.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (MoviePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MoviePath);
		}
		if (ResolutionX != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ResolutionX);
		}
		if (ResolutionY != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ResolutionY);
		}
		if (AudioVoice.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(AudioVoice);
		}
		if (AudioMusic.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(AudioMusic);
		}
		if (AudioOther.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(AudioOther);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MoviePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MoviePath);
		}
		if (ResolutionX != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResolutionX);
		}
		if (ResolutionY != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResolutionY);
		}
		if (AudioVoice.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AudioVoice);
		}
		if (AudioMusic.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AudioMusic);
		}
		if (AudioOther.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AudioOther);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieAndSubtitleDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MoviePath.Length != 0)
			{
				MoviePath = other.MoviePath;
			}
			if (other.ResolutionX != 0)
			{
				ResolutionX = other.ResolutionX;
			}
			if (other.ResolutionY != 0)
			{
				ResolutionY = other.ResolutionY;
			}
			if (other.AudioVoice.Length != 0)
			{
				AudioVoice = other.AudioVoice;
			}
			if (other.AudioMusic.Length != 0)
			{
				AudioMusic = other.AudioMusic;
			}
			if (other.AudioOther.Length != 0)
			{
				AudioOther = other.AudioOther;
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
			case 8u:
				Id = input.ReadInt32();
				break;
			case 18u:
				MoviePath = input.ReadString();
				break;
			case 24u:
				ResolutionX = input.ReadInt32();
				break;
			case 32u:
				ResolutionY = input.ReadInt32();
				break;
			case 42u:
				AudioVoice = input.ReadString();
				break;
			case 50u:
				AudioMusic = input.ReadString();
				break;
			case 58u:
				AudioOther = input.ReadString();
				break;
			}
		}
	}
}
