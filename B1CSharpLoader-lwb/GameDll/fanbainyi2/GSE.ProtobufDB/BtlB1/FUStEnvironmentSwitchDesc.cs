using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStEnvironmentSwitchDesc : IMessage<FUStEnvironmentSwitchDesc>, IMessage, IEquatable<FUStEnvironmentSwitchDesc>, IDeepCloneable<FUStEnvironmentSwitchDesc>
{
	private static readonly MessageParser<FUStEnvironmentSwitchDesc> _parser = new MessageParser<FUStEnvironmentSwitchDesc>(() => new FUStEnvironmentSwitchDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EBGUEnvObjSelector envObjSelector_;

	private string envDataPath_ = "";

	private static readonly FieldCodec<int> _repeated_envSwitchIntParams_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> envSwitchIntParams_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_envSwitchFloatParams_codec = FieldCodec.ForFloat(42u);

	private readonly RepeatedField<float> envSwitchFloatParams_ = new RepeatedField<float>();

	public static MessageParser<FUStEnvironmentSwitchDesc> Parser => _parser;

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

	public EBGUEnvObjSelector EnvObjSelector
	{
		get
		{
			return envObjSelector_;
		}
		set
		{
			envObjSelector_ = value;
		}
	}

	public string EnvDataPath
	{
		get
		{
			return envDataPath_;
		}
		set
		{
			envDataPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> EnvSwitchIntParams => envSwitchIntParams_;

	public RepeatedField<float> EnvSwitchFloatParams => envSwitchFloatParams_;

	public FUStEnvironmentSwitchDesc()
	{
	}

	public FUStEnvironmentSwitchDesc(FUStEnvironmentSwitchDesc other)
		: this()
	{
		iD_ = other.iD_;
		envObjSelector_ = other.envObjSelector_;
		envDataPath_ = other.envDataPath_;
		envSwitchIntParams_ = other.envSwitchIntParams_.Clone();
		envSwitchFloatParams_ = other.envSwitchFloatParams_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStEnvironmentSwitchDesc Clone()
	{
		return new FUStEnvironmentSwitchDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStEnvironmentSwitchDesc);
	}

	public bool Equals(FUStEnvironmentSwitchDesc other)
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
		if (EnvObjSelector != other.EnvObjSelector)
		{
			return false;
		}
		if (EnvDataPath != other.EnvDataPath)
		{
			return false;
		}
		if (!envSwitchIntParams_.Equals(other.envSwitchIntParams_))
		{
			return false;
		}
		if (!envSwitchFloatParams_.Equals(other.envSwitchFloatParams_))
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
		if (EnvObjSelector != EBGUEnvObjSelector.None)
		{
			num ^= EnvObjSelector.GetHashCode();
		}
		if (EnvDataPath.Length != 0)
		{
			num ^= EnvDataPath.GetHashCode();
		}
		num ^= envSwitchIntParams_.GetHashCode();
		num ^= envSwitchFloatParams_.GetHashCode();
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
		if (EnvObjSelector != EBGUEnvObjSelector.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EnvObjSelector);
		}
		if (EnvDataPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(EnvDataPath);
		}
		envSwitchIntParams_.WriteTo(output, _repeated_envSwitchIntParams_codec);
		envSwitchFloatParams_.WriteTo(output, _repeated_envSwitchFloatParams_codec);
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
		if (EnvObjSelector != EBGUEnvObjSelector.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EnvObjSelector);
		}
		if (EnvDataPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnvDataPath);
		}
		num += envSwitchIntParams_.CalculateSize(_repeated_envSwitchIntParams_codec);
		num += envSwitchFloatParams_.CalculateSize(_repeated_envSwitchFloatParams_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStEnvironmentSwitchDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.EnvObjSelector != EBGUEnvObjSelector.None)
			{
				EnvObjSelector = other.EnvObjSelector;
			}
			if (other.EnvDataPath.Length != 0)
			{
				EnvDataPath = other.EnvDataPath;
			}
			envSwitchIntParams_.Add(other.envSwitchIntParams_);
			envSwitchFloatParams_.Add(other.envSwitchFloatParams_);
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
				EnvObjSelector = (EBGUEnvObjSelector)input.ReadEnum();
				break;
			case 26u:
				EnvDataPath = input.ReadString();
				break;
			case 32u:
			case 34u:
				envSwitchIntParams_.AddEntriesFrom(input, _repeated_envSwitchIntParams_codec);
				break;
			case 42u:
			case 45u:
				envSwitchFloatParams_.AddEntriesFrom(input, _repeated_envSwitchFloatParams_codec);
				break;
			}
		}
	}
}
