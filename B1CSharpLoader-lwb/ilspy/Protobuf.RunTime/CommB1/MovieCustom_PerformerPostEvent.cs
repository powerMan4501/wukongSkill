using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PerformerPostEvent : IMessage<MovieCustom_PerformerPostEvent>, IMessage, IEquatable<MovieCustom_PerformerPostEvent>, IDeepCloneable<MovieCustom_PerformerPostEvent>
{
	private static readonly MessageParser<MovieCustom_PerformerPostEvent> _parser = new MessageParser<MovieCustom_PerformerPostEvent>(() => new MovieCustom_PerformerPostEvent());

	private UnknownFieldSet _unknownFields;

	private string performerGuid_ = "";

	private string akEventPath_ = "";

	private string attachPointName_ = "";

	private bool isFollow_;

	public static MessageParser<MovieCustom_PerformerPostEvent> Parser => _parser;

	public string PerformerGuid
	{
		get
		{
			return performerGuid_;
		}
		set
		{
			performerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AkEventPath
	{
		get
		{
			return akEventPath_;
		}
		set
		{
			akEventPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AttachPointName
	{
		get
		{
			return attachPointName_;
		}
		set
		{
			attachPointName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsFollow
	{
		get
		{
			return isFollow_;
		}
		set
		{
			isFollow_ = value;
		}
	}

	public MovieCustom_PerformerPostEvent()
	{
	}

	public MovieCustom_PerformerPostEvent(MovieCustom_PerformerPostEvent other)
		: this()
	{
		performerGuid_ = other.performerGuid_;
		akEventPath_ = other.akEventPath_;
		attachPointName_ = other.attachPointName_;
		isFollow_ = other.isFollow_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PerformerPostEvent Clone()
	{
		return new MovieCustom_PerformerPostEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PerformerPostEvent);
	}

	public bool Equals(MovieCustom_PerformerPostEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformerGuid != other.PerformerGuid)
		{
			return false;
		}
		if (AkEventPath != other.AkEventPath)
		{
			return false;
		}
		if (AttachPointName != other.AttachPointName)
		{
			return false;
		}
		if (IsFollow != other.IsFollow)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PerformerGuid.Length != 0)
		{
			num ^= PerformerGuid.GetHashCode();
		}
		if (AkEventPath.Length != 0)
		{
			num ^= AkEventPath.GetHashCode();
		}
		if (AttachPointName.Length != 0)
		{
			num ^= AttachPointName.GetHashCode();
		}
		if (IsFollow)
		{
			num ^= IsFollow.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PerformerGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PerformerGuid);
		}
		if (AkEventPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AkEventPath);
		}
		if (AttachPointName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AttachPointName);
		}
		if (IsFollow)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsFollow);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PerformerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PerformerGuid);
		}
		if (AkEventPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AkEventPath);
		}
		if (AttachPointName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AttachPointName);
		}
		if (IsFollow)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PerformerPostEvent other)
	{
		if (other != null)
		{
			if (other.PerformerGuid.Length != 0)
			{
				PerformerGuid = other.PerformerGuid;
			}
			if (other.AkEventPath.Length != 0)
			{
				AkEventPath = other.AkEventPath;
			}
			if (other.AttachPointName.Length != 0)
			{
				AttachPointName = other.AttachPointName;
			}
			if (other.IsFollow)
			{
				IsFollow = other.IsFollow;
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
				PerformerGuid = input.ReadString();
				break;
			case 18u:
				AkEventPath = input.ReadString();
				break;
			case 26u:
				AttachPointName = input.ReadString();
				break;
			case 32u:
				IsFollow = input.ReadBool();
				break;
			}
		}
	}
}
