using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthOpUserJsonConfigReq : IMessage<AuthOpUserJsonConfigReq>, IMessage, IEquatable<AuthOpUserJsonConfigReq>, IDeepCloneable<AuthOpUserJsonConfigReq>
{
	private static readonly MessageParser<AuthOpUserJsonConfigReq> _parser = new MessageParser<AuthOpUserJsonConfigReq>(() => new AuthOpUserJsonConfigReq());

	private UnknownFieldSet _unknownFields;

	private OpUserJsonConfigType opType_;

	private GssdkCustomJsonConfig data_;

	private string filtEnv_ = "";

	private string filtBranch_ = "";

	private string importData_ = "";

	private int isImportMerge_;

	private int useBranchEnv_;

	public static MessageParser<AuthOpUserJsonConfigReq> Parser => _parser;

	public OpUserJsonConfigType OpType
	{
		get
		{
			return opType_;
		}
		set
		{
			opType_ = value;
		}
	}

	public GssdkCustomJsonConfig Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	public string FiltEnv
	{
		get
		{
			return filtEnv_;
		}
		set
		{
			filtEnv_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string FiltBranch
	{
		get
		{
			return filtBranch_;
		}
		set
		{
			filtBranch_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ImportData
	{
		get
		{
			return importData_;
		}
		set
		{
			importData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int IsImportMerge
	{
		get
		{
			return isImportMerge_;
		}
		set
		{
			isImportMerge_ = value;
		}
	}

	public int UseBranchEnv
	{
		get
		{
			return useBranchEnv_;
		}
		set
		{
			useBranchEnv_ = value;
		}
	}

	public AuthOpUserJsonConfigReq()
	{
	}

	public AuthOpUserJsonConfigReq(AuthOpUserJsonConfigReq other)
		: this()
	{
		opType_ = other.opType_;
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		filtEnv_ = other.filtEnv_;
		filtBranch_ = other.filtBranch_;
		importData_ = other.importData_;
		isImportMerge_ = other.isImportMerge_;
		useBranchEnv_ = other.useBranchEnv_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthOpUserJsonConfigReq Clone()
	{
		return new AuthOpUserJsonConfigReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthOpUserJsonConfigReq);
	}

	public bool Equals(AuthOpUserJsonConfigReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OpType != other.OpType)
		{
			return false;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		if (FiltEnv != other.FiltEnv)
		{
			return false;
		}
		if (FiltBranch != other.FiltBranch)
		{
			return false;
		}
		if (ImportData != other.ImportData)
		{
			return false;
		}
		if (IsImportMerge != other.IsImportMerge)
		{
			return false;
		}
		if (UseBranchEnv != other.UseBranchEnv)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (OpType != OpUserJsonConfigType.OujctGet)
		{
			num ^= OpType.GetHashCode();
		}
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		if (FiltEnv.Length != 0)
		{
			num ^= FiltEnv.GetHashCode();
		}
		if (FiltBranch.Length != 0)
		{
			num ^= FiltBranch.GetHashCode();
		}
		if (ImportData.Length != 0)
		{
			num ^= ImportData.GetHashCode();
		}
		if (IsImportMerge != 0)
		{
			num ^= IsImportMerge.GetHashCode();
		}
		if (UseBranchEnv != 0)
		{
			num ^= UseBranchEnv.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (OpType != OpUserJsonConfigType.OujctGet)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)OpType);
		}
		if (data_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Data);
		}
		if (FiltEnv.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(FiltEnv);
		}
		if (FiltBranch.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(FiltBranch);
		}
		if (ImportData.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ImportData);
		}
		if (IsImportMerge != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(IsImportMerge);
		}
		if (UseBranchEnv != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(UseBranchEnv);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (OpType != OpUserJsonConfigType.OujctGet)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OpType);
		}
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (FiltEnv.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FiltEnv);
		}
		if (FiltBranch.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FiltBranch);
		}
		if (ImportData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ImportData);
		}
		if (IsImportMerge != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsImportMerge);
		}
		if (UseBranchEnv != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseBranchEnv);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthOpUserJsonConfigReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OpType != OpUserJsonConfigType.OujctGet)
		{
			OpType = other.OpType;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new GssdkCustomJsonConfig();
			}
			Data.MergeFrom(other.Data);
		}
		if (other.FiltEnv.Length != 0)
		{
			FiltEnv = other.FiltEnv;
		}
		if (other.FiltBranch.Length != 0)
		{
			FiltBranch = other.FiltBranch;
		}
		if (other.ImportData.Length != 0)
		{
			ImportData = other.ImportData;
		}
		if (other.IsImportMerge != 0)
		{
			IsImportMerge = other.IsImportMerge;
		}
		if (other.UseBranchEnv != 0)
		{
			UseBranchEnv = other.UseBranchEnv;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				OpType = (OpUserJsonConfigType)input.ReadEnum();
				break;
			case 18u:
				if (data_ == null)
				{
					Data = new GssdkCustomJsonConfig();
				}
				input.ReadMessage(Data);
				break;
			case 26u:
				FiltEnv = input.ReadString();
				break;
			case 34u:
				FiltBranch = input.ReadString();
				break;
			case 42u:
				ImportData = input.ReadString();
				break;
			case 48u:
				IsImportMerge = input.ReadInt32();
				break;
			case 56u:
				UseBranchEnv = input.ReadInt32();
				break;
			}
		}
	}
}
