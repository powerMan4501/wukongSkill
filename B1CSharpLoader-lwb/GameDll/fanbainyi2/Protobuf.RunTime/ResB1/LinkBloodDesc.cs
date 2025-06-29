using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class LinkBloodDesc : IMessage<LinkBloodDesc>, IMessage, IEquatable<LinkBloodDesc>, IDeepCloneable<LinkBloodDesc>
{
	private static readonly MessageParser<LinkBloodDesc> _parser = new MessageParser<LinkBloodDesc>(() => new LinkBloodDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<string> _repeated_guid_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> guid_ = new RepeatedField<string>();

	private string groupName_ = "";

	private int localizationTag_;

	public static MessageParser<LinkBloodDesc> Parser => _parser;

	public int Id
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

	public RepeatedField<string> Guid => guid_;

	public string GroupName
	{
		get
		{
			return groupName_;
		}
		set
		{
			groupName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public LinkBloodDesc()
	{
	}

	public LinkBloodDesc(LinkBloodDesc other)
		: this()
	{
		id_ = other.id_;
		guid_ = other.guid_.Clone();
		groupName_ = other.groupName_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LinkBloodDesc Clone()
	{
		return new LinkBloodDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LinkBloodDesc);
	}

	public bool Equals(LinkBloodDesc other)
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
		if (!guid_.Equals(other.guid_))
		{
			return false;
		}
		if (GroupName != other.GroupName)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= guid_.GetHashCode();
		if (GroupName.Length != 0)
		{
			num ^= GroupName.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		guid_.WriteTo(output, _repeated_guid_codec);
		if (GroupName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(GroupName);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += guid_.CalculateSize(_repeated_guid_codec);
		if (GroupName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GroupName);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LinkBloodDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			guid_.Add(other.guid_);
			if (other.GroupName.Length != 0)
			{
				GroupName = other.GroupName;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				guid_.AddEntriesFrom(input, _repeated_guid_codec);
				break;
			case 26u:
				GroupName = input.ReadString();
				break;
			case 32u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
