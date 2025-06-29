using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionAddPatchReq : IMessage<VersionAddPatchReq>, IMessage, IEquatable<VersionAddPatchReq>, IDeepCloneable<VersionAddPatchReq>
{
	private static readonly MessageParser<VersionAddPatchReq> _parser = new MessageParser<VersionAddPatchReq>(() => new VersionAddPatchReq());

	private UnknownFieldSet _unknownFields;

	private VersionPatchCfg patchConfig_;

	private string env_ = "";

	private string plist_ = "";

	public static MessageParser<VersionAddPatchReq> Parser => _parser;

	public VersionPatchCfg PatchConfig
	{
		get
		{
			return patchConfig_;
		}
		set
		{
			patchConfig_ = value;
		}
	}

	public string Env
	{
		get
		{
			return env_;
		}
		set
		{
			env_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Plist
	{
		get
		{
			return plist_;
		}
		set
		{
			plist_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public VersionAddPatchReq()
	{
	}

	public VersionAddPatchReq(VersionAddPatchReq other)
		: this()
	{
		patchConfig_ = ((other.patchConfig_ != null) ? other.patchConfig_.Clone() : null);
		env_ = other.env_;
		plist_ = other.plist_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionAddPatchReq Clone()
	{
		return new VersionAddPatchReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionAddPatchReq);
	}

	public bool Equals(VersionAddPatchReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PatchConfig, other.PatchConfig))
		{
			return false;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (Plist != other.Plist)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (patchConfig_ != null)
		{
			num ^= PatchConfig.GetHashCode();
		}
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (Plist.Length != 0)
		{
			num ^= Plist.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (patchConfig_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PatchConfig);
		}
		if (Env.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Env);
		}
		if (Plist.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Plist);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (patchConfig_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PatchConfig);
		}
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (Plist.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Plist);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionAddPatchReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.patchConfig_ != null)
		{
			if (patchConfig_ == null)
			{
				PatchConfig = new VersionPatchCfg();
			}
			PatchConfig.MergeFrom(other.PatchConfig);
		}
		if (other.Env.Length != 0)
		{
			Env = other.Env;
		}
		if (other.Plist.Length != 0)
		{
			Plist = other.Plist;
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
			case 10u:
				if (patchConfig_ == null)
				{
					PatchConfig = new VersionPatchCfg();
				}
				input.ReadMessage(PatchConfig);
				break;
			case 18u:
				Env = input.ReadString();
				break;
			case 26u:
				Plist = input.ReadString();
				break;
			}
		}
	}
}
