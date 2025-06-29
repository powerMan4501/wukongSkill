using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportMonitorReq : IMessage<ReportMonitorReq>, IMessage, IEquatable<ReportMonitorReq>, IDeepCloneable<ReportMonitorReq>
{
	private static readonly MessageParser<ReportMonitorReq> _parser = new MessageParser<ReportMonitorReq>(() => new ReportMonitorReq());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ReportMonitorKeyVal> _repeated_envKvs_codec = FieldCodec.ForMessage(10u, ReportMonitorKeyVal.Parser);

	private readonly RepeatedField<ReportMonitorKeyVal> envKvs_ = new RepeatedField<ReportMonitorKeyVal>();

	private static readonly FieldCodec<ReportMonitorAdd> _repeated_addList_codec = FieldCodec.ForMessage(18u, ReportMonitorAdd.Parser);

	private readonly RepeatedField<ReportMonitorAdd> addList_ = new RepeatedField<ReportMonitorAdd>();

	private static readonly FieldCodec<ReportMonitorSet> _repeated_setList_codec = FieldCodec.ForMessage(26u, ReportMonitorSet.Parser);

	private readonly RepeatedField<ReportMonitorSet> setList_ = new RepeatedField<ReportMonitorSet>();

	public static MessageParser<ReportMonitorReq> Parser => _parser;

	public RepeatedField<ReportMonitorKeyVal> EnvKvs => envKvs_;

	public RepeatedField<ReportMonitorAdd> AddList => addList_;

	public RepeatedField<ReportMonitorSet> SetList => setList_;

	public ReportMonitorReq()
	{
	}

	public ReportMonitorReq(ReportMonitorReq other)
		: this()
	{
		envKvs_ = other.envKvs_.Clone();
		addList_ = other.addList_.Clone();
		setList_ = other.setList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportMonitorReq Clone()
	{
		return new ReportMonitorReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportMonitorReq);
	}

	public bool Equals(ReportMonitorReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!envKvs_.Equals(other.envKvs_))
		{
			return false;
		}
		if (!addList_.Equals(other.addList_))
		{
			return false;
		}
		if (!setList_.Equals(other.setList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= envKvs_.GetHashCode();
		num ^= addList_.GetHashCode();
		num ^= setList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		envKvs_.WriteTo(output, _repeated_envKvs_codec);
		addList_.WriteTo(output, _repeated_addList_codec);
		setList_.WriteTo(output, _repeated_setList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += envKvs_.CalculateSize(_repeated_envKvs_codec);
		num += addList_.CalculateSize(_repeated_addList_codec);
		num += setList_.CalculateSize(_repeated_setList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportMonitorReq other)
	{
		if (other != null)
		{
			envKvs_.Add(other.envKvs_);
			addList_.Add(other.addList_);
			setList_.Add(other.setList_);
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
				envKvs_.AddEntriesFrom(input, _repeated_envKvs_codec);
				break;
			case 18u:
				addList_.AddEntriesFrom(input, _repeated_addList_codec);
				break;
			case 26u:
				setList_.AddEntriesFrom(input, _repeated_setList_codec);
				break;
			}
		}
	}
}
