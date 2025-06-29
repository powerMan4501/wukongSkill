using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class PsmArchiveGraphData : IMessage<PsmArchiveGraphData>, IMessage, IEquatable<PsmArchiveGraphData>, IDeepCloneable<PsmArchiveGraphData>
{
	private static readonly MessageParser<PsmArchiveGraphData> _parser = new MessageParser<PsmArchiveGraphData>(() => new PsmArchiveGraphData());

	private UnknownFieldSet _unknownFields;

	private string psmId_ = "";

	private string assetName_ = "";

	private static readonly FieldCodec<PsmArchiveNodeData> _repeated_nodeData_codec = FieldCodec.ForMessage(26u, PsmArchiveNodeData.Parser);

	private readonly RepeatedField<PsmArchiveNodeData> nodeData_ = new RepeatedField<PsmArchiveNodeData>();

	public static MessageParser<PsmArchiveGraphData> Parser => _parser;

	public string PsmId
	{
		get
		{
			return psmId_;
		}
		set
		{
			psmId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AssetName
	{
		get
		{
			return assetName_;
		}
		set
		{
			assetName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<PsmArchiveNodeData> NodeData => nodeData_;

	public PsmArchiveGraphData()
	{
	}

	public PsmArchiveGraphData(PsmArchiveGraphData other)
		: this()
	{
		psmId_ = other.psmId_;
		assetName_ = other.assetName_;
		nodeData_ = other.nodeData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PsmArchiveGraphData Clone()
	{
		return new PsmArchiveGraphData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PsmArchiveGraphData);
	}

	public bool Equals(PsmArchiveGraphData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PsmId != other.PsmId)
		{
			return false;
		}
		if (AssetName != other.AssetName)
		{
			return false;
		}
		if (!nodeData_.Equals(other.nodeData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PsmId.Length != 0)
		{
			num ^= PsmId.GetHashCode();
		}
		if (AssetName.Length != 0)
		{
			num ^= AssetName.GetHashCode();
		}
		num ^= nodeData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PsmId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PsmId);
		}
		if (AssetName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AssetName);
		}
		nodeData_.WriteTo(output, _repeated_nodeData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PsmId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PsmId);
		}
		if (AssetName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AssetName);
		}
		num += nodeData_.CalculateSize(_repeated_nodeData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PsmArchiveGraphData other)
	{
		if (other != null)
		{
			if (other.PsmId.Length != 0)
			{
				PsmId = other.PsmId;
			}
			if (other.AssetName.Length != 0)
			{
				AssetName = other.AssetName;
			}
			nodeData_.Add(other.nodeData_);
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
				PsmId = input.ReadString();
				break;
			case 18u:
				AssetName = input.ReadString();
				break;
			case 26u:
				nodeData_.AddEntriesFrom(input, _repeated_nodeData_codec);
				break;
			}
		}
	}
}
