using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class VersionGetPatchListRes : IMessage<VersionGetPatchListRes>, IMessage, IEquatable<VersionGetPatchListRes>, IDeepCloneable<VersionGetPatchListRes>
{
	private static readonly MessageParser<VersionGetPatchListRes> _parser = new MessageParser<VersionGetPatchListRes>(() => new VersionGetPatchListRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private static readonly FieldCodec<VersionPatchRec> _repeated_data_codec = FieldCodec.ForMessage(18u, VersionPatchRec.Parser);

	private readonly RepeatedField<VersionPatchRec> data_ = new RepeatedField<VersionPatchRec>();

	private static readonly FieldCodec<VersionPatchRecNew> _repeated_dataNew_codec = FieldCodec.ForMessage(26u, VersionPatchRecNew.Parser);

	private readonly RepeatedField<VersionPatchRecNew> dataNew_ = new RepeatedField<VersionPatchRecNew>();

	public static MessageParser<VersionGetPatchListRes> Parser => _parser;

	public GssdkRet Ret
	{
		get
		{
			return ret_;
		}
		set
		{
			ret_ = value;
		}
	}

	public RepeatedField<VersionPatchRec> Data => data_;

	public RepeatedField<VersionPatchRecNew> DataNew => dataNew_;

	public VersionGetPatchListRes()
	{
	}

	public VersionGetPatchListRes(VersionGetPatchListRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		data_ = other.data_.Clone();
		dataNew_ = other.dataNew_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionGetPatchListRes Clone()
	{
		return new VersionGetPatchListRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionGetPatchListRes);
	}

	public bool Equals(VersionGetPatchListRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Ret, other.Ret))
		{
			return false;
		}
		if (!data_.Equals(other.data_))
		{
			return false;
		}
		if (!dataNew_.Equals(other.dataNew_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ret_ != null)
		{
			num ^= Ret.GetHashCode();
		}
		num ^= data_.GetHashCode();
		num ^= dataNew_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ret_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Ret);
		}
		data_.WriteTo(output, _repeated_data_codec);
		dataNew_.WriteTo(output, _repeated_dataNew_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ret_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Ret);
		}
		num += data_.CalculateSize(_repeated_data_codec);
		num += dataNew_.CalculateSize(_repeated_dataNew_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionGetPatchListRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ret_ != null)
		{
			if (ret_ == null)
			{
				Ret = new GssdkRet();
			}
			Ret.MergeFrom(other.Ret);
		}
		data_.Add(other.data_);
		dataNew_.Add(other.dataNew_);
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
				if (ret_ == null)
				{
					Ret = new GssdkRet();
				}
				input.ReadMessage(Ret);
				break;
			case 18u:
				data_.AddEntriesFrom(input, _repeated_data_codec);
				break;
			case 26u:
				dataNew_.AddEntriesFrom(input, _repeated_dataNew_codec);
				break;
			}
		}
	}
}
