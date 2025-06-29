using System;
using Google.Protobuf;

namespace CommB1;

public sealed class FUStLocalSetting : IMessage<FUStLocalSetting>, IMessage, IEquatable<FUStLocalSetting>, IDeepCloneable<FUStLocalSetting>
{
	private static readonly MessageParser<FUStLocalSetting> _parser = new MessageParser<FUStLocalSetting>(() => new FUStLocalSetting());

	private UnknownFieldSet _unknownFields;

	private ScreenSettingData screen_;

	private MusicSettingData volume_;

	public static MessageParser<FUStLocalSetting> Parser => _parser;

	public ScreenSettingData Screen
	{
		get
		{
			return screen_;
		}
		set
		{
			screen_ = value;
		}
	}

	public MusicSettingData Volume
	{
		get
		{
			return volume_;
		}
		set
		{
			volume_ = value;
		}
	}

	public FUStLocalSetting()
	{
	}

	public FUStLocalSetting(FUStLocalSetting other)
		: this()
	{
		screen_ = ((other.screen_ != null) ? other.screen_.Clone() : null);
		volume_ = ((other.volume_ != null) ? other.volume_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStLocalSetting Clone()
	{
		return new FUStLocalSetting(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStLocalSetting);
	}

	public bool Equals(FUStLocalSetting other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Screen, other.Screen))
		{
			return false;
		}
		if (!object.Equals(Volume, other.Volume))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (screen_ != null)
		{
			num ^= Screen.GetHashCode();
		}
		if (volume_ != null)
		{
			num ^= Volume.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (screen_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Screen);
		}
		if (volume_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Volume);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (screen_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Screen);
		}
		if (volume_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Volume);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStLocalSetting other)
	{
		if (other == null)
		{
			return;
		}
		if (other.screen_ != null)
		{
			if (screen_ == null)
			{
				Screen = new ScreenSettingData();
			}
			Screen.MergeFrom(other.Screen);
		}
		if (other.volume_ != null)
		{
			if (volume_ == null)
			{
				Volume = new MusicSettingData();
			}
			Volume.MergeFrom(other.Volume);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (screen_ == null)
				{
					Screen = new ScreenSettingData();
				}
				input.ReadMessage(Screen);
				break;
			case 18u:
				if (volume_ == null)
				{
					Volume = new MusicSettingData();
				}
				input.ReadMessage(Volume);
				break;
			}
		}
	}
}
