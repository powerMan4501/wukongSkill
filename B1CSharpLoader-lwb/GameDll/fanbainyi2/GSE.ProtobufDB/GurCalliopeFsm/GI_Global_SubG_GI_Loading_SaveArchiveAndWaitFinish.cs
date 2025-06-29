using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish : IMessage<GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish>, IMessage, IEquatable<GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish>, IDeepCloneable<GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish>
{
	private static readonly MessageParser<GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish> _parser = new MessageParser<GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish>(() => new GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish());

	private UnknownFieldSet _unknownFields;

	private string subGraphAsset_ = "";

	private int archiveSaveSource_;

	public static MessageParser<GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish> Parser => _parser;

	public string SubGraphAsset
	{
		get
		{
			return subGraphAsset_;
		}
		set
		{
			subGraphAsset_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ArchiveSaveSource
	{
		get
		{
			return archiveSaveSource_;
		}
		set
		{
			archiveSaveSource_ = value;
		}
	}

	public GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish()
	{
	}

	public GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish(GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish other)
		: this()
	{
		subGraphAsset_ = other.subGraphAsset_;
		archiveSaveSource_ = other.archiveSaveSource_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish Clone()
	{
		return new GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish);
	}

	public bool Equals(GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SubGraphAsset != other.SubGraphAsset)
		{
			return false;
		}
		if (ArchiveSaveSource != other.ArchiveSaveSource)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SubGraphAsset.Length != 0)
		{
			num ^= SubGraphAsset.GetHashCode();
		}
		if (ArchiveSaveSource != 0)
		{
			num ^= ArchiveSaveSource.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SubGraphAsset.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(SubGraphAsset);
		}
		if (ArchiveSaveSource != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ArchiveSaveSource);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SubGraphAsset.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SubGraphAsset);
		}
		if (ArchiveSaveSource != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ArchiveSaveSource);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish other)
	{
		if (other != null)
		{
			if (other.SubGraphAsset.Length != 0)
			{
				SubGraphAsset = other.SubGraphAsset;
			}
			if (other.ArchiveSaveSource != 0)
			{
				ArchiveSaveSource = other.ArchiveSaveSource;
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
				SubGraphAsset = input.ReadString();
				break;
			case 16u:
				ArchiveSaveSource = input.ReadInt32();
				break;
			}
		}
	}
}
