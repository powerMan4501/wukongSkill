using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Global_SubG_GI_Loading_ServerLogin : IMessage<GI_Global_SubG_GI_Loading_ServerLogin>, IMessage, IEquatable<GI_Global_SubG_GI_Loading_ServerLogin>, IDeepCloneable<GI_Global_SubG_GI_Loading_ServerLogin>
{
	private static readonly MessageParser<GI_Global_SubG_GI_Loading_ServerLogin> _parser = new MessageParser<GI_Global_SubG_GI_Loading_ServerLogin>(() => new GI_Global_SubG_GI_Loading_ServerLogin());

	private UnknownFieldSet _unknownFields;

	private string subGraphAsset_ = "";

	public static MessageParser<GI_Global_SubG_GI_Loading_ServerLogin> Parser => _parser;

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

	public GI_Global_SubG_GI_Loading_ServerLogin()
	{
	}

	public GI_Global_SubG_GI_Loading_ServerLogin(GI_Global_SubG_GI_Loading_ServerLogin other)
		: this()
	{
		subGraphAsset_ = other.subGraphAsset_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Global_SubG_GI_Loading_ServerLogin Clone()
	{
		return new GI_Global_SubG_GI_Loading_ServerLogin(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Global_SubG_GI_Loading_ServerLogin);
	}

	public bool Equals(GI_Global_SubG_GI_Loading_ServerLogin other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SubGraphAsset.Length != 0)
		{
			num ^= SubGraphAsset.GetHashCode();
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Global_SubG_GI_Loading_ServerLogin other)
	{
		if (other != null)
		{
			if (other.SubGraphAsset.Length != 0)
			{
				SubGraphAsset = other.SubGraphAsset;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				SubGraphAsset = input.ReadString();
			}
		}
	}
}
