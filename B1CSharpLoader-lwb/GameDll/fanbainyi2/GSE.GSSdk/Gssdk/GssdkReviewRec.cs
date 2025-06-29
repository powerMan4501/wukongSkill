using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkReviewRec : IMessage<GssdkReviewRec>, IMessage, IEquatable<GssdkReviewRec>, IDeepCloneable<GssdkReviewRec>
{
	private static readonly MessageParser<GssdkReviewRec> _parser = new MessageParser<GssdkReviewRec>(() => new GssdkReviewRec());

	private UnknownFieldSet _unknownFields;

	private string appChannel_ = "";

	private string subChannel_ = "";

	private string version_ = "";

	private GssdkReviewStatus status_;

	private string desc_ = "";

	public static MessageParser<GssdkReviewRec> Parser => _parser;

	public string AppChannel
	{
		get
		{
			return appChannel_;
		}
		set
		{
			appChannel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SubChannel
	{
		get
		{
			return subChannel_;
		}
		set
		{
			subChannel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkReviewStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	public string Desc
	{
		get
		{
			return desc_;
		}
		set
		{
			desc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkReviewRec()
	{
	}

	public GssdkReviewRec(GssdkReviewRec other)
		: this()
	{
		appChannel_ = other.appChannel_;
		subChannel_ = other.subChannel_;
		version_ = other.version_;
		status_ = other.status_;
		desc_ = other.desc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkReviewRec Clone()
	{
		return new GssdkReviewRec(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkReviewRec);
	}

	public bool Equals(GssdkReviewRec other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AppChannel != other.AppChannel)
		{
			return false;
		}
		if (SubChannel != other.SubChannel)
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AppChannel.Length != 0)
		{
			num ^= AppChannel.GetHashCode();
		}
		if (SubChannel.Length != 0)
		{
			num ^= SubChannel.GetHashCode();
		}
		if (Version.Length != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (Status != GssdkReviewStatus.Normal)
		{
			num ^= Status.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AppChannel.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AppChannel);
		}
		if (SubChannel.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SubChannel);
		}
		if (Version.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Version);
		}
		if (Status != GssdkReviewStatus.Normal)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Status);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Desc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AppChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AppChannel);
		}
		if (SubChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SubChannel);
		}
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (Status != GssdkReviewStatus.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkReviewRec other)
	{
		if (other != null)
		{
			if (other.AppChannel.Length != 0)
			{
				AppChannel = other.AppChannel;
			}
			if (other.SubChannel.Length != 0)
			{
				SubChannel = other.SubChannel;
			}
			if (other.Version.Length != 0)
			{
				Version = other.Version;
			}
			if (other.Status != GssdkReviewStatus.Normal)
			{
				Status = other.Status;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
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
				AppChannel = input.ReadString();
				break;
			case 18u:
				SubChannel = input.ReadString();
				break;
			case 26u:
				Version = input.ReadString();
				break;
			case 32u:
				Status = (GssdkReviewStatus)input.ReadEnum();
				break;
			case 42u:
				Desc = input.ReadString();
				break;
			}
		}
	}
}
