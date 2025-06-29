using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionOpServerJsonConfigReq : IMessage<VersionOpServerJsonConfigReq>, IMessage, IEquatable<VersionOpServerJsonConfigReq>, IDeepCloneable<VersionOpServerJsonConfigReq>
{
	private static readonly MessageParser<VersionOpServerJsonConfigReq> _parser = new MessageParser<VersionOpServerJsonConfigReq>(() => new VersionOpServerJsonConfigReq());

	private UnknownFieldSet _unknownFields;

	private OpServerJsonConfigType opType_;

	private GssdkCustomJsonConfig data_;

	private string filtEnv_ = "";

	private string filtBranch_ = "";

	public static MessageParser<VersionOpServerJsonConfigReq> Parser => _parser;

	public OpServerJsonConfigType OpType
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

	public VersionOpServerJsonConfigReq()
	{
	}

	public VersionOpServerJsonConfigReq(VersionOpServerJsonConfigReq other)
		: this()
	{
		opType_ = other.opType_;
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		filtEnv_ = other.filtEnv_;
		filtBranch_ = other.filtBranch_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionOpServerJsonConfigReq Clone()
	{
		return new VersionOpServerJsonConfigReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionOpServerJsonConfigReq);
	}

	public bool Equals(VersionOpServerJsonConfigReq other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (OpType != OpServerJsonConfigType.OsjctGet)
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
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (OpType != OpServerJsonConfigType.OsjctGet)
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
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (OpType != OpServerJsonConfigType.OsjctGet)
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionOpServerJsonConfigReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OpType != OpServerJsonConfigType.OsjctGet)
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
				OpType = (OpServerJsonConfigType)input.ReadEnum();
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
			}
		}
	}
}
