using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ConfigTabInfoEx : IMessage<ConfigTabInfoEx>, IMessage, IEquatable<ConfigTabInfoEx>, IDeepCloneable<ConfigTabInfoEx>
{
	private static readonly MessageParser<ConfigTabInfoEx> _parser = new MessageParser<ConfigTabInfoEx>(() => new ConfigTabInfoEx());

	private UnknownFieldSet _unknownFields;

	private EUIConfigTab configTab_;

	private int sortId_;

	public static MessageParser<ConfigTabInfoEx> Parser => _parser;

	public EUIConfigTab ConfigTab
	{
		get
		{
			return configTab_;
		}
		set
		{
			configTab_ = value;
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public ConfigTabInfoEx()
	{
	}

	public ConfigTabInfoEx(ConfigTabInfoEx other)
		: this()
	{
		configTab_ = other.configTab_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ConfigTabInfoEx Clone()
	{
		return new ConfigTabInfoEx(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ConfigTabInfoEx);
	}

	public bool Equals(ConfigTabInfoEx other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConfigTab != other.ConfigTab)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConfigTab != EUIConfigTab.Gamepad)
		{
			num ^= ConfigTab.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConfigTab != EUIConfigTab.Gamepad)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ConfigTab);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SortId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConfigTab != EUIConfigTab.Gamepad)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConfigTab);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ConfigTabInfoEx other)
	{
		if (other != null)
		{
			if (other.ConfigTab != EUIConfigTab.Gamepad)
			{
				ConfigTab = other.ConfigTab;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
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
				ConfigTab = (EUIConfigTab)input.ReadEnum();
				break;
			case 16u:
				SortId = input.ReadInt32();
				break;
			}
		}
	}
}
