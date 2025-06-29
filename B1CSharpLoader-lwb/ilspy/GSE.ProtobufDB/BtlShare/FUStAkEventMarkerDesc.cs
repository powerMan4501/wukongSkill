using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStAkEventMarkerDesc : IMessage<FUStAkEventMarkerDesc>, IMessage, IEquatable<FUStAkEventMarkerDesc>, IDeepCloneable<FUStAkEventMarkerDesc>
{
	private static readonly MessageParser<FUStAkEventMarkerDesc> _parser = new MessageParser<FUStAkEventMarkerDesc>(() => new FUStAkEventMarkerDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string akEventName_ = "";

	private string akSoundName_ = "";

	private static readonly FieldCodec<AKMarkerCulture> _repeated_culture_codec = FieldCodec.ForMessage(34u, AKMarkerCulture.Parser);

	private readonly RepeatedField<AKMarkerCulture> culture_ = new RepeatedField<AKMarkerCulture>();

	public static MessageParser<FUStAkEventMarkerDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public string AkEventName
	{
		get
		{
			return akEventName_;
		}
		set
		{
			akEventName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AkSoundName
	{
		get
		{
			return akSoundName_;
		}
		set
		{
			akSoundName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<AKMarkerCulture> Culture => culture_;

	public FUStAkEventMarkerDesc()
	{
	}

	public FUStAkEventMarkerDesc(FUStAkEventMarkerDesc other)
		: this()
	{
		iD_ = other.iD_;
		akEventName_ = other.akEventName_;
		akSoundName_ = other.akSoundName_;
		culture_ = other.culture_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAkEventMarkerDesc Clone()
	{
		return new FUStAkEventMarkerDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAkEventMarkerDesc);
	}

	public bool Equals(FUStAkEventMarkerDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (AkEventName != other.AkEventName)
		{
			return false;
		}
		if (AkSoundName != other.AkSoundName)
		{
			return false;
		}
		if (!culture_.Equals(other.culture_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (AkEventName.Length != 0)
		{
			num ^= AkEventName.GetHashCode();
		}
		if (AkSoundName.Length != 0)
		{
			num ^= AkSoundName.GetHashCode();
		}
		num ^= culture_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (AkEventName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AkEventName);
		}
		if (AkSoundName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AkSoundName);
		}
		culture_.WriteTo(output, _repeated_culture_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (AkEventName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AkEventName);
		}
		if (AkSoundName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AkSoundName);
		}
		num += culture_.CalculateSize(_repeated_culture_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAkEventMarkerDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.AkEventName.Length != 0)
			{
				AkEventName = other.AkEventName;
			}
			if (other.AkSoundName.Length != 0)
			{
				AkSoundName = other.AkSoundName;
			}
			culture_.Add(other.culture_);
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
				ID = input.ReadInt32();
				break;
			case 18u:
				AkEventName = input.ReadString();
				break;
			case 26u:
				AkSoundName = input.ReadString();
				break;
			case 34u:
				culture_.AddEntriesFrom(input, _repeated_culture_codec);
				break;
			}
		}
	}
}
