using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventInitSettingFinish : IMessage<ReportEventInitSettingFinish>, IMessage, IEquatable<ReportEventInitSettingFinish>, IDeepCloneable<ReportEventInitSettingFinish>
{
	private static readonly MessageParser<ReportEventInitSettingFinish> _parser = new MessageParser<ReportEventInitSettingFinish>(() => new ReportEventInitSettingFinish());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private string textLang_ = "";

	private string voiceLang_ = "";

	private string frameQualityLang_ = "";

	public static MessageParser<ReportEventInitSettingFinish> Parser => _parser;

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

	public string TextLang
	{
		get
		{
			return textLang_;
		}
		set
		{
			textLang_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string VoiceLang
	{
		get
		{
			return voiceLang_;
		}
		set
		{
			voiceLang_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string FrameQualityLang
	{
		get
		{
			return frameQualityLang_;
		}
		set
		{
			frameQualityLang_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventInitSettingFinish()
	{
	}

	public ReportEventInitSettingFinish(ReportEventInitSettingFinish other)
		: this()
	{
		roleId_ = other.roleId_;
		textLang_ = other.textLang_;
		voiceLang_ = other.voiceLang_;
		frameQualityLang_ = other.frameQualityLang_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventInitSettingFinish Clone()
	{
		return new ReportEventInitSettingFinish(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventInitSettingFinish);
	}

	public bool Equals(ReportEventInitSettingFinish other)
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
		if (TextLang != other.TextLang)
		{
			return false;
		}
		if (VoiceLang != other.VoiceLang)
		{
			return false;
		}
		if (FrameQualityLang != other.FrameQualityLang)
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
		if (TextLang.Length != 0)
		{
			num ^= TextLang.GetHashCode();
		}
		if (VoiceLang.Length != 0)
		{
			num ^= VoiceLang.GetHashCode();
		}
		if (FrameQualityLang.Length != 0)
		{
			num ^= FrameQualityLang.GetHashCode();
		}
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
		if (TextLang.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(TextLang);
		}
		if (VoiceLang.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(VoiceLang);
		}
		if (FrameQualityLang.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(FrameQualityLang);
		}
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
		if (TextLang.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TextLang);
		}
		if (VoiceLang.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VoiceLang);
		}
		if (FrameQualityLang.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FrameQualityLang);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventInitSettingFinish other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.TextLang.Length != 0)
			{
				TextLang = other.TextLang;
			}
			if (other.VoiceLang.Length != 0)
			{
				VoiceLang = other.VoiceLang;
			}
			if (other.FrameQualityLang.Length != 0)
			{
				FrameQualityLang = other.FrameQualityLang;
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				TextLang = input.ReadString();
				break;
			case 26u:
				VoiceLang = input.ReadString();
				break;
			case 34u:
				FrameQualityLang = input.ReadString();
				break;
			}
		}
	}
}
