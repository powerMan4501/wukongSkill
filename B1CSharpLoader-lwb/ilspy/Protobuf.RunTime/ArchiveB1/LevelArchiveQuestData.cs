using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelArchiveQuestData : IMessage<LevelArchiveQuestData>, IMessage, IEquatable<LevelArchiveQuestData>, IDeepCloneable<LevelArchiveQuestData>
{
	private static readonly MessageParser<LevelArchiveQuestData> _parser = new MessageParser<LevelArchiveQuestData>(() => new LevelArchiveQuestData());

	private UnknownFieldSet _unknownFields;

	private bool isDataValid_;

	private bool isRootGraph_;

	private string assetName_ = "";

	private string parentNodeGuid_ = "";

	private ActivationState activationState_;

	private static readonly FieldCodec<LevelArchiveQuestNodeData> _repeated_nodes_codec = FieldCodec.ForMessage(50u, LevelArchiveQuestNodeData.Parser);

	private readonly RepeatedField<LevelArchiveQuestNodeData> nodes_ = new RepeatedField<LevelArchiveQuestNodeData>();

	private static readonly FieldCodec<LevelArchiveQuestData> _repeated_subGraphData_codec = FieldCodec.ForMessage(58u, Parser);

	private readonly RepeatedField<LevelArchiveQuestData> subGraphData_ = new RepeatedField<LevelArchiveQuestData>();

	public static MessageParser<LevelArchiveQuestData> Parser => _parser;

	public bool IsDataValid
	{
		get
		{
			return isDataValid_;
		}
		set
		{
			isDataValid_ = value;
		}
	}

	public bool IsRootGraph
	{
		get
		{
			return isRootGraph_;
		}
		set
		{
			isRootGraph_ = value;
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

	public string ParentNodeGuid
	{
		get
		{
			return parentNodeGuid_;
		}
		set
		{
			parentNodeGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ActivationState ActivationState
	{
		get
		{
			return activationState_;
		}
		set
		{
			activationState_ = value;
		}
	}

	public RepeatedField<LevelArchiveQuestNodeData> Nodes => nodes_;

	public RepeatedField<LevelArchiveQuestData> SubGraphData => subGraphData_;

	public LevelArchiveQuestData()
	{
	}

	public LevelArchiveQuestData(LevelArchiveQuestData other)
		: this()
	{
		isDataValid_ = other.isDataValid_;
		isRootGraph_ = other.isRootGraph_;
		assetName_ = other.assetName_;
		parentNodeGuid_ = other.parentNodeGuid_;
		activationState_ = other.activationState_;
		nodes_ = other.nodes_.Clone();
		subGraphData_ = other.subGraphData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchiveQuestData Clone()
	{
		return new LevelArchiveQuestData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchiveQuestData);
	}

	public bool Equals(LevelArchiveQuestData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsDataValid != other.IsDataValid)
		{
			return false;
		}
		if (IsRootGraph != other.IsRootGraph)
		{
			return false;
		}
		if (AssetName != other.AssetName)
		{
			return false;
		}
		if (ParentNodeGuid != other.ParentNodeGuid)
		{
			return false;
		}
		if (ActivationState != other.ActivationState)
		{
			return false;
		}
		if (!nodes_.Equals(other.nodes_))
		{
			return false;
		}
		if (!subGraphData_.Equals(other.subGraphData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsDataValid)
		{
			num ^= IsDataValid.GetHashCode();
		}
		if (IsRootGraph)
		{
			num ^= IsRootGraph.GetHashCode();
		}
		if (AssetName.Length != 0)
		{
			num ^= AssetName.GetHashCode();
		}
		if (ParentNodeGuid.Length != 0)
		{
			num ^= ParentNodeGuid.GetHashCode();
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			num ^= ActivationState.GetHashCode();
		}
		num ^= nodes_.GetHashCode();
		num ^= subGraphData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsDataValid)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsDataValid);
		}
		if (IsRootGraph)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsRootGraph);
		}
		if (AssetName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AssetName);
		}
		if (ParentNodeGuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ParentNodeGuid);
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ActivationState);
		}
		nodes_.WriteTo(output, _repeated_nodes_codec);
		subGraphData_.WriteTo(output, _repeated_subGraphData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsDataValid)
		{
			num += 2;
		}
		if (IsRootGraph)
		{
			num += 2;
		}
		if (AssetName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AssetName);
		}
		if (ParentNodeGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParentNodeGuid);
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ActivationState);
		}
		num += nodes_.CalculateSize(_repeated_nodes_codec);
		num += subGraphData_.CalculateSize(_repeated_subGraphData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchiveQuestData other)
	{
		if (other != null)
		{
			if (other.IsDataValid)
			{
				IsDataValid = other.IsDataValid;
			}
			if (other.IsRootGraph)
			{
				IsRootGraph = other.IsRootGraph;
			}
			if (other.AssetName.Length != 0)
			{
				AssetName = other.AssetName;
			}
			if (other.ParentNodeGuid.Length != 0)
			{
				ParentNodeGuid = other.ParentNodeGuid;
			}
			if (other.ActivationState != ActivationState.NeverActivated)
			{
				ActivationState = other.ActivationState;
			}
			nodes_.Add(other.nodes_);
			subGraphData_.Add(other.subGraphData_);
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
				IsDataValid = input.ReadBool();
				break;
			case 16u:
				IsRootGraph = input.ReadBool();
				break;
			case 26u:
				AssetName = input.ReadString();
				break;
			case 34u:
				ParentNodeGuid = input.ReadString();
				break;
			case 40u:
				ActivationState = (ActivationState)input.ReadEnum();
				break;
			case 50u:
				nodes_.AddEntriesFrom(input, _repeated_nodes_codec);
				break;
			case 58u:
				subGraphData_.AddEntriesFrom(input, _repeated_subGraphData_codec);
				break;
			}
		}
	}
}
