using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MusicSettingData : IMessage<MusicSettingData>, IMessage, IEquatable<MusicSettingData>, IDeepCloneable<MusicSettingData>
{
	private static readonly MessageParser<MusicSettingData> _parser = new MessageParser<MusicSettingData>(() => new MusicSettingData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float mainVolume_;

	private float musicVolume_;

	private float effectVolume_;

	private float voiceVolume_;

	public static MessageParser<MusicSettingData> Parser => _parser;

	public float MainVolume
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return mainVolume_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			mainVolume_ = value;
		}
	}

	public bool HasMainVolume => (_hasBits0 & 1) != 0;

	public float MusicVolume
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return musicVolume_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			musicVolume_ = value;
		}
	}

	public bool HasMusicVolume => (_hasBits0 & 2) != 0;

	public float EffectVolume
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return effectVolume_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 4;
			effectVolume_ = value;
		}
	}

	public bool HasEffectVolume => (_hasBits0 & 4) != 0;

	public float VoiceVolume
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return voiceVolume_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 8;
			voiceVolume_ = value;
		}
	}

	public bool HasVoiceVolume => (_hasBits0 & 8) != 0;

	public MusicSettingData()
	{
	}

	public MusicSettingData(MusicSettingData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		mainVolume_ = other.mainVolume_;
		musicVolume_ = other.musicVolume_;
		effectVolume_ = other.effectVolume_;
		voiceVolume_ = other.voiceVolume_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MusicSettingData Clone()
	{
		return new MusicSettingData(this);
	}

	public void ClearMainVolume()
	{
		_hasBits0 &= -2;
	}

	public void ClearMusicVolume()
	{
		_hasBits0 &= -3;
	}

	public void ClearEffectVolume()
	{
		_hasBits0 &= -5;
	}

	public void ClearVoiceVolume()
	{
		_hasBits0 &= -9;
	}

	public override bool Equals(object other)
	{
		return Equals(other as MusicSettingData);
	}

	public bool Equals(MusicSettingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MainVolume, other.MainVolume))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MusicVolume, other.MusicVolume))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EffectVolume, other.EffectVolume))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(VoiceVolume, other.VoiceVolume))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasMainVolume)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MainVolume);
		}
		if (HasMusicVolume)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MusicVolume);
		}
		if (HasEffectVolume)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EffectVolume);
		}
		if (HasVoiceVolume)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(VoiceVolume);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasMainVolume)
		{
			output.WriteRawTag(13);
			output.WriteFloat(MainVolume);
		}
		if (HasMusicVolume)
		{
			output.WriteRawTag(21);
			output.WriteFloat(MusicVolume);
		}
		if (HasEffectVolume)
		{
			output.WriteRawTag(29);
			output.WriteFloat(EffectVolume);
		}
		if (HasVoiceVolume)
		{
			output.WriteRawTag(37);
			output.WriteFloat(VoiceVolume);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasMainVolume)
		{
			num += 5;
		}
		if (HasMusicVolume)
		{
			num += 5;
		}
		if (HasEffectVolume)
		{
			num += 5;
		}
		if (HasVoiceVolume)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MusicSettingData other)
	{
		if (other != null)
		{
			if (other.HasMainVolume)
			{
				MainVolume = other.MainVolume;
			}
			if (other.HasMusicVolume)
			{
				MusicVolume = other.MusicVolume;
			}
			if (other.HasEffectVolume)
			{
				EffectVolume = other.EffectVolume;
			}
			if (other.HasVoiceVolume)
			{
				VoiceVolume = other.VoiceVolume;
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
			case 13u:
				MainVolume = input.ReadFloat();
				break;
			case 21u:
				MusicVolume = input.ReadFloat();
				break;
			case 29u:
				EffectVolume = input.ReadFloat();
				break;
			case 37u:
				VoiceVolume = input.ReadFloat();
				break;
			}
		}
	}
}
