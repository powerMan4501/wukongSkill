using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStCustomStateMachineDesc : IMessage<FUStCustomStateMachineDesc>, IMessage, IEquatable<FUStCustomStateMachineDesc>, IDeepCloneable<FUStCustomStateMachineDesc>
{
	private static readonly MessageParser<FUStCustomStateMachineDesc> _parser = new MessageParser<FUStCustomStateMachineDesc>(() => new FUStCustomStateMachineDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EProcessUsage processType_;

	private EGSYesNo isEnableByDefault_;

	private string graphPath_ = "";

	private string dataAssetPath_ = "";

	public static MessageParser<FUStCustomStateMachineDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EProcessUsage ProcessType
	{
		get
		{
			return processType_;
		}
		set
		{
			processType_ = value;
		}
	}

	public EGSYesNo IsEnableByDefault
	{
		get
		{
			return isEnableByDefault_;
		}
		set
		{
			isEnableByDefault_ = value;
		}
	}

	public string GraphPath
	{
		get
		{
			return graphPath_;
		}
		set
		{
			graphPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DataAssetPath
	{
		get
		{
			return dataAssetPath_;
		}
		set
		{
			dataAssetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStCustomStateMachineDesc()
	{
	}

	public FUStCustomStateMachineDesc(FUStCustomStateMachineDesc other)
		: this()
	{
		iD_ = other.iD_;
		processType_ = other.processType_;
		isEnableByDefault_ = other.isEnableByDefault_;
		graphPath_ = other.graphPath_;
		dataAssetPath_ = other.dataAssetPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCustomStateMachineDesc Clone()
	{
		return new FUStCustomStateMachineDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCustomStateMachineDesc);
	}

	public bool Equals(FUStCustomStateMachineDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (ProcessType != other.ProcessType)
		{
			return false;
		}
		if (IsEnableByDefault != other.IsEnableByDefault)
		{
			return false;
		}
		if (GraphPath != other.GraphPath)
		{
			return false;
		}
		if (DataAssetPath != other.DataAssetPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (ProcessType != EProcessUsage.None)
		{
			num ^= ProcessType.GetHashCode();
		}
		if (IsEnableByDefault != EGSYesNo.No)
		{
			num ^= IsEnableByDefault.GetHashCode();
		}
		if (GraphPath.Length != 0)
		{
			num ^= GraphPath.GetHashCode();
		}
		if (DataAssetPath.Length != 0)
		{
			num ^= DataAssetPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (ProcessType != EProcessUsage.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ProcessType);
		}
		if (IsEnableByDefault != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsEnableByDefault);
		}
		if (GraphPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(GraphPath);
		}
		if (DataAssetPath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(DataAssetPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (ProcessType != EProcessUsage.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProcessType);
		}
		if (IsEnableByDefault != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsEnableByDefault);
		}
		if (GraphPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GraphPath);
		}
		if (DataAssetPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DataAssetPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStCustomStateMachineDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ProcessType != EProcessUsage.None)
			{
				ProcessType = other.ProcessType;
			}
			if (other.IsEnableByDefault != EGSYesNo.No)
			{
				IsEnableByDefault = other.IsEnableByDefault;
			}
			if (other.GraphPath.Length != 0)
			{
				GraphPath = other.GraphPath;
			}
			if (other.DataAssetPath.Length != 0)
			{
				DataAssetPath = other.DataAssetPath;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				ProcessType = (EProcessUsage)input.ReadEnum();
				break;
			case 24u:
				IsEnableByDefault = (EGSYesNo)input.ReadEnum();
				break;
			case 34u:
				GraphPath = input.ReadString();
				break;
			case 42u:
				DataAssetPath = input.ReadString();
				break;
			}
		}
	}
}
