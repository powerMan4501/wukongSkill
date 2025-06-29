using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeNodeData : IMessage<CalliopeNodeData>, IMessage, IEquatable<CalliopeNodeData>, IDeepCloneable<CalliopeNodeData>
{
	private static readonly MessageParser<CalliopeNodeData> _parser = new MessageParser<CalliopeNodeData>(() => new CalliopeNodeData());

	private UnknownFieldSet _unknownFields;

	private int index_;

	private ByteString nodeGuid_ = ByteString.Empty;

	private string nodeClass_ = "";

	private uint versionId_;

	private ByteString customData_ = ByteString.Empty;

	private static readonly FieldCodec<int> _repeated_inputEdges_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> inputEdges_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_outputEdges_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> outputEdges_ = new RepeatedField<int>();

	public static MessageParser<CalliopeNodeData> Parser => _parser;

	public int Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	public ByteString NodeGuid
	{
		get
		{
			return nodeGuid_;
		}
		set
		{
			nodeGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NodeClass
	{
		get
		{
			return nodeClass_;
		}
		set
		{
			nodeClass_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint VersionId
	{
		get
		{
			return versionId_;
		}
		set
		{
			versionId_ = value;
		}
	}

	public ByteString CustomData
	{
		get
		{
			return customData_;
		}
		set
		{
			customData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> InputEdges => inputEdges_;

	public RepeatedField<int> OutputEdges => outputEdges_;

	public CalliopeNodeData()
	{
	}

	public CalliopeNodeData(CalliopeNodeData other)
		: this()
	{
		index_ = other.index_;
		nodeGuid_ = other.nodeGuid_;
		nodeClass_ = other.nodeClass_;
		versionId_ = other.versionId_;
		customData_ = other.customData_;
		inputEdges_ = other.inputEdges_.Clone();
		outputEdges_ = other.outputEdges_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeNodeData Clone()
	{
		return new CalliopeNodeData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeNodeData);
	}

	public bool Equals(CalliopeNodeData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (NodeGuid != other.NodeGuid)
		{
			return false;
		}
		if (NodeClass != other.NodeClass)
		{
			return false;
		}
		if (VersionId != other.VersionId)
		{
			return false;
		}
		if (CustomData != other.CustomData)
		{
			return false;
		}
		if (!inputEdges_.Equals(other.inputEdges_))
		{
			return false;
		}
		if (!outputEdges_.Equals(other.outputEdges_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (NodeGuid.Length != 0)
		{
			num ^= NodeGuid.GetHashCode();
		}
		if (NodeClass.Length != 0)
		{
			num ^= NodeClass.GetHashCode();
		}
		if (VersionId != 0)
		{
			num ^= VersionId.GetHashCode();
		}
		if (CustomData.Length != 0)
		{
			num ^= CustomData.GetHashCode();
		}
		num ^= inputEdges_.GetHashCode();
		num ^= outputEdges_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Index != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Index);
		}
		if (NodeGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(NodeGuid);
		}
		if (NodeClass.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(NodeClass);
		}
		if (VersionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(VersionId);
		}
		if (CustomData.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteBytes(CustomData);
		}
		inputEdges_.WriteTo(output, _repeated_inputEdges_codec);
		outputEdges_.WriteTo(output, _repeated_outputEdges_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Index);
		}
		if (NodeGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(NodeGuid);
		}
		if (NodeClass.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NodeClass);
		}
		if (VersionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(VersionId);
		}
		if (CustomData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(CustomData);
		}
		num += inputEdges_.CalculateSize(_repeated_inputEdges_codec);
		num += outputEdges_.CalculateSize(_repeated_outputEdges_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeNodeData other)
	{
		if (other != null)
		{
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.NodeGuid.Length != 0)
			{
				NodeGuid = other.NodeGuid;
			}
			if (other.NodeClass.Length != 0)
			{
				NodeClass = other.NodeClass;
			}
			if (other.VersionId != 0)
			{
				VersionId = other.VersionId;
			}
			if (other.CustomData.Length != 0)
			{
				CustomData = other.CustomData;
			}
			inputEdges_.Add(other.inputEdges_);
			outputEdges_.Add(other.outputEdges_);
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
				Index = input.ReadInt32();
				break;
			case 18u:
				NodeGuid = input.ReadBytes();
				break;
			case 26u:
				NodeClass = input.ReadString();
				break;
			case 32u:
				VersionId = input.ReadUInt32();
				break;
			case 42u:
				CustomData = input.ReadBytes();
				break;
			case 48u:
			case 50u:
				inputEdges_.AddEntriesFrom(input, _repeated_inputEdges_codec);
				break;
			case 56u:
			case 58u:
				outputEdges_.AddEntriesFrom(input, _repeated_outputEdges_codec);
				break;
			}
		}
	}
}
