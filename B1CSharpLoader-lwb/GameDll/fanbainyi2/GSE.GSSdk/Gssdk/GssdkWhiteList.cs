using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkWhiteList : IMessage<GssdkWhiteList>, IMessage, IEquatable<GssdkWhiteList>, IDeepCloneable<GssdkWhiteList>
{
	private static readonly MessageParser<GssdkWhiteList> _parser = new MessageParser<GssdkWhiteList>(() => new GssdkWhiteList());

	private UnknownFieldSet _unknownFields;

	private long id_;

	private GssdkWhiteListType type_;

	private string deviceId_ = "";

	private string channelUid_ = "";

	private ulong aid_;

	public static MessageParser<GssdkWhiteList> Parser => _parser;

	public long Id
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

	public GssdkWhiteListType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public string DeviceId
	{
		get
		{
			return deviceId_;
		}
		set
		{
			deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ChannelUid
	{
		get
		{
			return channelUid_;
		}
		set
		{
			channelUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ulong Aid
	{
		get
		{
			return aid_;
		}
		set
		{
			aid_ = value;
		}
	}

	public GssdkWhiteList()
	{
	}

	public GssdkWhiteList(GssdkWhiteList other)
		: this()
	{
		id_ = other.id_;
		type_ = other.type_;
		deviceId_ = other.deviceId_;
		channelUid_ = other.channelUid_;
		aid_ = other.aid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkWhiteList Clone()
	{
		return new GssdkWhiteList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkWhiteList);
	}

	public bool Equals(GssdkWhiteList other)
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
		if (Type != other.Type)
		{
			return false;
		}
		if (DeviceId != other.DeviceId)
		{
			return false;
		}
		if (ChannelUid != other.ChannelUid)
		{
			return false;
		}
		if (Aid != other.Aid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
		}
		if (Type != GssdkWhiteListType.Logindir)
		{
			num ^= Type.GetHashCode();
		}
		if (DeviceId.Length != 0)
		{
			num ^= DeviceId.GetHashCode();
		}
		if (ChannelUid.Length != 0)
		{
			num ^= ChannelUid.GetHashCode();
		}
		if (Aid != 0L)
		{
			num ^= Aid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Id);
		}
		if (Type != GssdkWhiteListType.Logindir)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (DeviceId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DeviceId);
		}
		if (ChannelUid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ChannelUid);
		}
		if (Aid != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(Aid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Id);
		}
		if (Type != GssdkWhiteListType.Logindir)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (DeviceId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
		}
		if (ChannelUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChannelUid);
		}
		if (Aid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Aid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkWhiteList other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
			{
				Id = other.Id;
			}
			if (other.Type != GssdkWhiteListType.Logindir)
			{
				Type = other.Type;
			}
			if (other.DeviceId.Length != 0)
			{
				DeviceId = other.DeviceId;
			}
			if (other.ChannelUid.Length != 0)
			{
				ChannelUid = other.ChannelUid;
			}
			if (other.Aid != 0L)
			{
				Aid = other.Aid;
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
				Id = input.ReadInt64();
				break;
			case 16u:
				Type = (GssdkWhiteListType)input.ReadEnum();
				break;
			case 26u:
				DeviceId = input.ReadString();
				break;
			case 34u:
				ChannelUid = input.ReadString();
				break;
			case 40u:
				Aid = input.ReadUInt64();
				break;
			}
		}
	}
}
