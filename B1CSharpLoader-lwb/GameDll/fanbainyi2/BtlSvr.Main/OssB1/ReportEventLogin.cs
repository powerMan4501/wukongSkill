using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventLogin : IMessage<ReportEventLogin>, IMessage, IEquatable<ReportEventLogin>, IDeepCloneable<ReportEventLogin>
{
	private static readonly MessageParser<ReportEventLogin> _parser = new MessageParser<ReportEventLogin>(() => new ReportEventLogin());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private DeviceInfo device_;

	private PlayerInfo player_;

	private static readonly FieldCodec<RecLen> _repeated_allRecs_codec = FieldCodec.ForMessage(34u, RecLen.Parser);

	private readonly RepeatedField<RecLen> allRecs_ = new RepeatedField<RecLen>();

	public static MessageParser<ReportEventLogin> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public DeviceInfo Device
	{
		get
		{
			return device_;
		}
		set
		{
			device_ = value;
		}
	}

	public PlayerInfo Player
	{
		get
		{
			return player_;
		}
		set
		{
			player_ = value;
		}
	}

	public RepeatedField<RecLen> AllRecs => allRecs_;

	public ReportEventLogin()
	{
	}

	public ReportEventLogin(ReportEventLogin other)
		: this()
	{
		roleId_ = other.roleId_;
		device_ = ((other.device_ != null) ? other.device_.Clone() : null);
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		allRecs_ = other.allRecs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventLogin Clone()
	{
		return new ReportEventLogin(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventLogin);
	}

	public bool Equals(ReportEventLogin other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!object.Equals(Device, other.Device))
		{
			return false;
		}
		if (!object.Equals(Player, other.Player))
		{
			return false;
		}
		if (!allRecs_.Equals(other.allRecs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (device_ != null)
		{
			num ^= Device.GetHashCode();
		}
		if (player_ != null)
		{
			num ^= Player.GetHashCode();
		}
		num ^= allRecs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (device_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Device);
		}
		if (player_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Player);
		}
		allRecs_.WriteTo(output, _repeated_allRecs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (device_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Device);
		}
		if (player_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Player);
		}
		num += allRecs_.CalculateSize(_repeated_allRecs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventLogin other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoleId != 0L)
		{
			RoleId = other.RoleId;
		}
		if (other.device_ != null)
		{
			if (device_ == null)
			{
				Device = new DeviceInfo();
			}
			Device.MergeFrom(other.Device);
		}
		if (other.player_ != null)
		{
			if (player_ == null)
			{
				Player = new PlayerInfo();
			}
			Player.MergeFrom(other.Player);
		}
		allRecs_.Add(other.allRecs_);
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				if (device_ == null)
				{
					Device = new DeviceInfo();
				}
				input.ReadMessage(Device);
				break;
			case 26u:
				if (player_ == null)
				{
					Player = new PlayerInfo();
				}
				input.ReadMessage(Player);
				break;
			case 34u:
				allRecs_.AddEntriesFrom(input, _repeated_allRecs_codec);
				break;
			}
		}
	}
}
