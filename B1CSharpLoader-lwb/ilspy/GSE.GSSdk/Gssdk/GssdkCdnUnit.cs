using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class GssdkCdnUnit : IMessage<GssdkCdnUnit>, IMessage, IEquatable<GssdkCdnUnit>, IDeepCloneable<GssdkCdnUnit>
{
	private static readonly MessageParser<GssdkCdnUnit> _parser = new MessageParser<GssdkCdnUnit>(() => new GssdkCdnUnit());

	private UnknownFieldSet _unknownFields;

	private string name_ = "";

	private static readonly FieldCodec<string> _repeated_url_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> url_ = new RepeatedField<string>();

	private string patchUrl_ = "";

	private string verjsonUrl_ = "";

	private string verjsonUrlNew_ = "";

	public static MessageParser<GssdkCdnUnit> Parser => _parser;

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> Url => url_;

	public string PatchUrl
	{
		get
		{
			return patchUrl_;
		}
		set
		{
			patchUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string VerjsonUrl
	{
		get
		{
			return verjsonUrl_;
		}
		set
		{
			verjsonUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string VerjsonUrlNew
	{
		get
		{
			return verjsonUrlNew_;
		}
		set
		{
			verjsonUrlNew_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkCdnUnit()
	{
	}

	public GssdkCdnUnit(GssdkCdnUnit other)
		: this()
	{
		name_ = other.name_;
		url_ = other.url_.Clone();
		patchUrl_ = other.patchUrl_;
		verjsonUrl_ = other.verjsonUrl_;
		verjsonUrlNew_ = other.verjsonUrlNew_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkCdnUnit Clone()
	{
		return new GssdkCdnUnit(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkCdnUnit);
	}

	public bool Equals(GssdkCdnUnit other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!url_.Equals(other.url_))
		{
			return false;
		}
		if (PatchUrl != other.PatchUrl)
		{
			return false;
		}
		if (VerjsonUrl != other.VerjsonUrl)
		{
			return false;
		}
		if (VerjsonUrlNew != other.VerjsonUrlNew)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		num ^= url_.GetHashCode();
		if (PatchUrl.Length != 0)
		{
			num ^= PatchUrl.GetHashCode();
		}
		if (VerjsonUrl.Length != 0)
		{
			num ^= VerjsonUrl.GetHashCode();
		}
		if (VerjsonUrlNew.Length != 0)
		{
			num ^= VerjsonUrlNew.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		url_.WriteTo(output, _repeated_url_codec);
		if (PatchUrl.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PatchUrl);
		}
		if (VerjsonUrl.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(VerjsonUrl);
		}
		if (VerjsonUrlNew.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(VerjsonUrlNew);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		num += url_.CalculateSize(_repeated_url_codec);
		if (PatchUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PatchUrl);
		}
		if (VerjsonUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerjsonUrl);
		}
		if (VerjsonUrlNew.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerjsonUrlNew);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkCdnUnit other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			url_.Add(other.url_);
			if (other.PatchUrl.Length != 0)
			{
				PatchUrl = other.PatchUrl;
			}
			if (other.VerjsonUrl.Length != 0)
			{
				VerjsonUrl = other.VerjsonUrl;
			}
			if (other.VerjsonUrlNew.Length != 0)
			{
				VerjsonUrlNew = other.VerjsonUrlNew;
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
				Name = input.ReadString();
				break;
			case 18u:
				url_.AddEntriesFrom(input, _repeated_url_codec);
				break;
			case 26u:
				PatchUrl = input.ReadString();
				break;
			case 34u:
				VerjsonUrl = input.ReadString();
				break;
			case 42u:
				VerjsonUrlNew = input.ReadString();
				break;
			}
		}
	}
}
