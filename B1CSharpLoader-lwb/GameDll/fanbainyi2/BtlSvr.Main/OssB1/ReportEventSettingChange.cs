using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventSettingChange : IMessage<ReportEventSettingChange>, IMessage, IEquatable<ReportEventSettingChange>, IDeepCloneable<ReportEventSettingChange>
{
	private static readonly MessageParser<ReportEventSettingChange> _parser = new MessageParser<ReportEventSettingChange>(() => new ReportEventSettingChange());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private static readonly FieldCodec<OSSSettingInfo> _repeated_settingInfoList_codec = FieldCodec.ForMessage(18u, OSSSettingInfo.Parser);

	private readonly RepeatedField<OSSSettingInfo> settingInfoList_ = new RepeatedField<OSSSettingInfo>();

	public static MessageParser<ReportEventSettingChange> Parser => _parser;

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

	public RepeatedField<OSSSettingInfo> SettingInfoList => settingInfoList_;

	public ReportEventSettingChange()
	{
	}

	public ReportEventSettingChange(ReportEventSettingChange other)
		: this()
	{
		roleId_ = other.roleId_;
		settingInfoList_ = other.settingInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventSettingChange Clone()
	{
		return new ReportEventSettingChange(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventSettingChange);
	}

	public bool Equals(ReportEventSettingChange other)
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
		if (!settingInfoList_.Equals(other.settingInfoList_))
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
		num ^= settingInfoList_.GetHashCode();
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
		settingInfoList_.WriteTo(output, _repeated_settingInfoList_codec);
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
		num += settingInfoList_.CalculateSize(_repeated_settingInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventSettingChange other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			settingInfoList_.Add(other.settingInfoList_);
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
				settingInfoList_.AddEntriesFrom(input, _repeated_settingInfoList_codec);
				break;
			}
		}
	}
}
