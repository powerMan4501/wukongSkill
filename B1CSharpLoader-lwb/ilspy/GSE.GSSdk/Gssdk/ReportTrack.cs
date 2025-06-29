using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportTrack : IMessage<ReportTrack>, IMessage, IEquatable<ReportTrack>, IDeepCloneable<ReportTrack>
{
	private static readonly MessageParser<ReportTrack> _parser = new MessageParser<ReportTrack>(() => new ReportTrack());

	private UnknownFieldSet _unknownFields;

	private string evtName_ = "";

	private uint time_;

	private string evtContent_ = "";

	private static readonly FieldCodec<ReportTrackMisc> _repeated_roleEx_codec = FieldCodec.ForMessage(34u, ReportTrackMisc.Parser);

	private readonly RepeatedField<ReportTrackMisc> roleEx_ = new RepeatedField<ReportTrackMisc>();

	private string baseInfos_ = "";

	public static MessageParser<ReportTrack> Parser => _parser;

	public string EvtName
	{
		get
		{
			return evtName_;
		}
		set
		{
			evtName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public string EvtContent
	{
		get
		{
			return evtContent_;
		}
		set
		{
			evtContent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<ReportTrackMisc> RoleEx => roleEx_;

	public string BaseInfos
	{
		get
		{
			return baseInfos_;
		}
		set
		{
			baseInfos_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportTrack()
	{
	}

	public ReportTrack(ReportTrack other)
		: this()
	{
		evtName_ = other.evtName_;
		time_ = other.time_;
		evtContent_ = other.evtContent_;
		roleEx_ = other.roleEx_.Clone();
		baseInfos_ = other.baseInfos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportTrack Clone()
	{
		return new ReportTrack(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportTrack);
	}

	public bool Equals(ReportTrack other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EvtName != other.EvtName)
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (EvtContent != other.EvtContent)
		{
			return false;
		}
		if (!roleEx_.Equals(other.roleEx_))
		{
			return false;
		}
		if (BaseInfos != other.BaseInfos)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EvtName.Length != 0)
		{
			num ^= EvtName.GetHashCode();
		}
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (EvtContent.Length != 0)
		{
			num ^= EvtContent.GetHashCode();
		}
		num ^= roleEx_.GetHashCode();
		if (BaseInfos.Length != 0)
		{
			num ^= BaseInfos.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EvtName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(EvtName);
		}
		if (Time != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Time);
		}
		if (EvtContent.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(EvtContent);
		}
		roleEx_.WriteTo(output, _repeated_roleEx_codec);
		if (BaseInfos.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(BaseInfos);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EvtName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EvtName);
		}
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (EvtContent.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EvtContent);
		}
		num += roleEx_.CalculateSize(_repeated_roleEx_codec);
		if (BaseInfos.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BaseInfos);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportTrack other)
	{
		if (other != null)
		{
			if (other.EvtName.Length != 0)
			{
				EvtName = other.EvtName;
			}
			if (other.Time != 0)
			{
				Time = other.Time;
			}
			if (other.EvtContent.Length != 0)
			{
				EvtContent = other.EvtContent;
			}
			roleEx_.Add(other.roleEx_);
			if (other.BaseInfos.Length != 0)
			{
				BaseInfos = other.BaseInfos;
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
			case 10u:
				EvtName = input.ReadString();
				break;
			case 16u:
				Time = input.ReadUInt32();
				break;
			case 26u:
				EvtContent = input.ReadString();
				break;
			case 34u:
				roleEx_.AddEntriesFrom(input, _repeated_roleEx_codec);
				break;
			case 42u:
				BaseInfos = input.ReadString();
				break;
			}
		}
	}
}
