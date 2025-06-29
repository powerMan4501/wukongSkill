using System;
using Google.Protobuf;

namespace CsB1;

public sealed class SyncServerTime : IMessage<SyncServerTime>, IMessage, IEquatable<SyncServerTime>, IDeepCloneable<SyncServerTime>
{
	private static readonly MessageParser<SyncServerTime> _parser = new MessageParser<SyncServerTime>(() => new SyncServerTime());

	private UnknownFieldSet _unknownFields;

	private uint time_;

	private int gmtoff_;

	private int dsttime_;

	private string timezone_ = "";

	private int dayStartHour_;

	public static MessageParser<SyncServerTime> Parser => _parser;

	public uint Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	public int Gmtoff
	{
		get
		{
			return gmtoff_;
		}
		set
		{
			gmtoff_ = value;
		}
	}

	public int Dsttime
	{
		get
		{
			return dsttime_;
		}
		set
		{
			dsttime_ = value;
		}
	}

	public string Timezone
	{
		get
		{
			return timezone_;
		}
		set
		{
			timezone_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DayStartHour
	{
		get
		{
			return dayStartHour_;
		}
		set
		{
			dayStartHour_ = value;
		}
	}

	public SyncServerTime()
	{
	}

	public SyncServerTime(SyncServerTime other)
		: this()
	{
		time_ = other.time_;
		gmtoff_ = other.gmtoff_;
		dsttime_ = other.dsttime_;
		timezone_ = other.timezone_;
		dayStartHour_ = other.dayStartHour_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SyncServerTime Clone()
	{
		return new SyncServerTime(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SyncServerTime);
	}

	public bool Equals(SyncServerTime other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (Gmtoff != other.Gmtoff)
		{
			return false;
		}
		if (Dsttime != other.Dsttime)
		{
			return false;
		}
		if (Timezone != other.Timezone)
		{
			return false;
		}
		if (DayStartHour != other.DayStartHour)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (Gmtoff != 0)
		{
			num ^= Gmtoff.GetHashCode();
		}
		if (Dsttime != 0)
		{
			num ^= Dsttime.GetHashCode();
		}
		if (Timezone.Length != 0)
		{
			num ^= Timezone.GetHashCode();
		}
		if (DayStartHour != 0)
		{
			num ^= DayStartHour.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Time != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Time);
		}
		if (Gmtoff != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Gmtoff);
		}
		if (Dsttime != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Dsttime);
		}
		if (Timezone.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Timezone);
		}
		if (DayStartHour != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DayStartHour);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (Gmtoff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Gmtoff);
		}
		if (Dsttime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dsttime);
		}
		if (Timezone.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Timezone);
		}
		if (DayStartHour != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DayStartHour);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SyncServerTime other)
	{
		if (other != null)
		{
			if (other.Time != 0)
			{
				Time = other.Time;
			}
			if (other.Gmtoff != 0)
			{
				Gmtoff = other.Gmtoff;
			}
			if (other.Dsttime != 0)
			{
				Dsttime = other.Dsttime;
			}
			if (other.Timezone.Length != 0)
			{
				Timezone = other.Timezone;
			}
			if (other.DayStartHour != 0)
			{
				DayStartHour = other.DayStartHour;
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
				Time = input.ReadUInt32();
				break;
			case 16u:
				Gmtoff = input.ReadInt32();
				break;
			case 24u:
				Dsttime = input.ReadInt32();
				break;
			case 34u:
				Timezone = input.ReadString();
				break;
			case 40u:
				DayStartHour = input.ReadInt32();
				break;
			}
		}
	}
}
