using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMiscHeartBeatRes : IMessage<CSMsgMiscHeartBeatRes>, IMessage, IEquatable<CSMsgMiscHeartBeatRes>, IDeepCloneable<CSMsgMiscHeartBeatRes>
{
	private static readonly MessageParser<CSMsgMiscHeartBeatRes> _parser = new MessageParser<CSMsgMiscHeartBeatRes>(() => new CSMsgMiscHeartBeatRes());

	private UnknownFieldSet _unknownFields;

	private uint time_;

	private SyncServerTime serverTime_;

	public static MessageParser<CSMsgMiscHeartBeatRes> Parser => _parser;

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

	public SyncServerTime ServerTime
	{
		get
		{
			return serverTime_;
		}
		set
		{
			serverTime_ = value;
		}
	}

	public CSMsgMiscHeartBeatRes()
	{
	}

	public CSMsgMiscHeartBeatRes(CSMsgMiscHeartBeatRes other)
		: this()
	{
		time_ = other.time_;
		serverTime_ = ((other.serverTime_ != null) ? other.serverTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscHeartBeatRes Clone()
	{
		return new CSMsgMiscHeartBeatRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscHeartBeatRes);
	}

	public bool Equals(CSMsgMiscHeartBeatRes other)
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
		if (!object.Equals(ServerTime, other.ServerTime))
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
		if (serverTime_ != null)
		{
			num ^= ServerTime.GetHashCode();
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
		if (serverTime_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ServerTime);
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
		if (serverTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ServerTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMiscHeartBeatRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Time != 0)
		{
			Time = other.Time;
		}
		if (other.serverTime_ != null)
		{
			if (serverTime_ == null)
			{
				ServerTime = new SyncServerTime();
			}
			ServerTime.MergeFrom(other.ServerTime);
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
			case 8u:
				Time = input.ReadUInt32();
				break;
			case 18u:
				if (serverTime_ == null)
				{
					ServerTime = new SyncServerTime();
				}
				input.ReadMessage(ServerTime);
				break;
			}
		}
	}
}
