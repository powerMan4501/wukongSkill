using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class AKMarkerCulture : IMessage<AKMarkerCulture>, IMessage, IEquatable<AKMarkerCulture>, IDeepCloneable<AKMarkerCulture>
{
	private static readonly MessageParser<AKMarkerCulture> _parser = new MessageParser<AKMarkerCulture>(() => new AKMarkerCulture());

	private UnknownFieldSet _unknownFields;

	private string name_ = "";

	private static readonly FieldCodec<AKMarkerInfo> _repeated_markers_codec = FieldCodec.ForMessage(18u, AKMarkerInfo.Parser);

	private readonly RepeatedField<AKMarkerInfo> markers_ = new RepeatedField<AKMarkerInfo>();

	public static MessageParser<AKMarkerCulture> Parser => _parser;

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<AKMarkerInfo> Markers => markers_;

	public AKMarkerCulture()
	{
	}

	public AKMarkerCulture(AKMarkerCulture other)
		: this()
	{
		name_ = other.name_;
		markers_ = other.markers_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AKMarkerCulture Clone()
	{
		return new AKMarkerCulture(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AKMarkerCulture);
	}

	public bool Equals(AKMarkerCulture other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!markers_.Equals(other.markers_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		num ^= markers_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		markers_.WriteTo(output, _repeated_markers_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		num += markers_.CalculateSize(_repeated_markers_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AKMarkerCulture other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			markers_.Add(other.markers_);
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
				Name = input.ReadString();
				break;
			case 18u:
				markers_.AddEntriesFrom(input, _repeated_markers_codec);
				break;
			}
		}
	}
}
