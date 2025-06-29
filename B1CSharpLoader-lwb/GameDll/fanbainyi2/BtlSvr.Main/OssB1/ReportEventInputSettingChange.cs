using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventInputSettingChange : IMessage<ReportEventInputSettingChange>, IMessage, IEquatable<ReportEventInputSettingChange>, IDeepCloneable<ReportEventInputSettingChange>
{
	private static readonly MessageParser<ReportEventInputSettingChange> _parser = new MessageParser<ReportEventInputSettingChange>(() => new ReportEventInputSettingChange());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private string oldGamepadInputType_ = "";

	private string newGamepadInputType_ = "";

	private static readonly FieldCodec<ChangedMappableKey> _repeated_changedMappableKeys_codec = FieldCodec.ForMessage(34u, ChangedMappableKey.Parser);

	private readonly RepeatedField<ChangedMappableKey> changedMappableKeys_ = new RepeatedField<ChangedMappableKey>();

	public static MessageParser<ReportEventInputSettingChange> Parser => _parser;

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

	public string OldGamepadInputType
	{
		get
		{
			return oldGamepadInputType_;
		}
		set
		{
			oldGamepadInputType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NewGamepadInputType
	{
		get
		{
			return newGamepadInputType_;
		}
		set
		{
			newGamepadInputType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<ChangedMappableKey> ChangedMappableKeys => changedMappableKeys_;

	public ReportEventInputSettingChange()
	{
	}

	public ReportEventInputSettingChange(ReportEventInputSettingChange other)
		: this()
	{
		roleId_ = other.roleId_;
		oldGamepadInputType_ = other.oldGamepadInputType_;
		newGamepadInputType_ = other.newGamepadInputType_;
		changedMappableKeys_ = other.changedMappableKeys_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventInputSettingChange Clone()
	{
		return new ReportEventInputSettingChange(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventInputSettingChange);
	}

	public bool Equals(ReportEventInputSettingChange other)
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
		if (OldGamepadInputType != other.OldGamepadInputType)
		{
			return false;
		}
		if (NewGamepadInputType != other.NewGamepadInputType)
		{
			return false;
		}
		if (!changedMappableKeys_.Equals(other.changedMappableKeys_))
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
		if (OldGamepadInputType.Length != 0)
		{
			num ^= OldGamepadInputType.GetHashCode();
		}
		if (NewGamepadInputType.Length != 0)
		{
			num ^= NewGamepadInputType.GetHashCode();
		}
		num ^= changedMappableKeys_.GetHashCode();
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
		if (OldGamepadInputType.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(OldGamepadInputType);
		}
		if (NewGamepadInputType.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(NewGamepadInputType);
		}
		changedMappableKeys_.WriteTo(output, _repeated_changedMappableKeys_codec);
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
		if (OldGamepadInputType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OldGamepadInputType);
		}
		if (NewGamepadInputType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NewGamepadInputType);
		}
		num += changedMappableKeys_.CalculateSize(_repeated_changedMappableKeys_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventInputSettingChange other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.OldGamepadInputType.Length != 0)
			{
				OldGamepadInputType = other.OldGamepadInputType;
			}
			if (other.NewGamepadInputType.Length != 0)
			{
				NewGamepadInputType = other.NewGamepadInputType;
			}
			changedMappableKeys_.Add(other.changedMappableKeys_);
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				OldGamepadInputType = input.ReadString();
				break;
			case 26u:
				NewGamepadInputType = input.ReadString();
				break;
			case 34u:
				changedMappableKeys_.AddEntriesFrom(input, _repeated_changedMappableKeys_codec);
				break;
			}
		}
	}
}
