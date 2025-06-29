using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class PredictionTestData : IMessage<PredictionTestData>, IMessage, IEquatable<PredictionTestData>, IDeepCloneable<PredictionTestData>
{
	private static readonly MessageParser<PredictionTestData> _parser = new MessageParser<PredictionTestData>(() => new PredictionTestData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private uint testEntity1_;

	private static readonly FieldCodec<ListDeltaMsgEntity> _repeated_testEntityList1_codec = FieldCodec.ForMessage(18u, ListDeltaMsgEntity.Parser);

	private readonly RepeatedField<ListDeltaMsgEntity> testEntityList1_ = new RepeatedField<ListDeltaMsgEntity>();

	private static readonly FieldCodec<ListWNRDeltaMsgEntity> _repeated_testEntityListWithNetRole_codec = FieldCodec.ForMessage(26u, ListWNRDeltaMsgEntity.Parser);

	private readonly RepeatedField<ListWNRDeltaMsgEntity> testEntityListWithNetRole_ = new RepeatedField<ListWNRDeltaMsgEntity>();

	private static readonly FieldCodec<DictDeltaMsgInt_Entity> _repeated_testEntityDic_codec = FieldCodec.ForMessage(34u, DictDeltaMsgInt_Entity.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_Entity> testEntityDic_ = new RepeatedField<DictDeltaMsgInt_Entity>();

	public static MessageParser<PredictionTestData> Parser => _parser;

	public uint TestEntity1
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return testEntity1_;
			}
			return 0u;
		}
		set
		{
			_hasBits0 |= 1;
			testEntity1_ = value;
		}
	}

	public bool HasTestEntity1 => (_hasBits0 & 1) != 0;

	public RepeatedField<ListDeltaMsgEntity> TestEntityList1 => testEntityList1_;

	public RepeatedField<ListWNRDeltaMsgEntity> TestEntityListWithNetRole => testEntityListWithNetRole_;

	public RepeatedField<DictDeltaMsgInt_Entity> TestEntityDic => testEntityDic_;

	public PredictionTestData()
	{
	}

	public PredictionTestData(PredictionTestData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		testEntity1_ = other.testEntity1_;
		testEntityList1_ = other.testEntityList1_.Clone();
		testEntityListWithNetRole_ = other.testEntityListWithNetRole_.Clone();
		testEntityDic_ = other.testEntityDic_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PredictionTestData Clone()
	{
		return new PredictionTestData(this);
	}

	public void ClearTestEntity1()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as PredictionTestData);
	}

	public bool Equals(PredictionTestData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TestEntity1 != other.TestEntity1)
		{
			return false;
		}
		if (!testEntityList1_.Equals(other.testEntityList1_))
		{
			return false;
		}
		if (!testEntityListWithNetRole_.Equals(other.testEntityListWithNetRole_))
		{
			return false;
		}
		if (!testEntityDic_.Equals(other.testEntityDic_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasTestEntity1)
		{
			num ^= TestEntity1.GetHashCode();
		}
		num ^= testEntityList1_.GetHashCode();
		num ^= testEntityListWithNetRole_.GetHashCode();
		num ^= testEntityDic_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasTestEntity1)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TestEntity1);
		}
		testEntityList1_.WriteTo(output, _repeated_testEntityList1_codec);
		testEntityListWithNetRole_.WriteTo(output, _repeated_testEntityListWithNetRole_codec);
		testEntityDic_.WriteTo(output, _repeated_testEntityDic_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasTestEntity1)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TestEntity1);
		}
		num += testEntityList1_.CalculateSize(_repeated_testEntityList1_codec);
		num += testEntityListWithNetRole_.CalculateSize(_repeated_testEntityListWithNetRole_codec);
		num += testEntityDic_.CalculateSize(_repeated_testEntityDic_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PredictionTestData other)
	{
		if (other != null)
		{
			if (other.HasTestEntity1)
			{
				TestEntity1 = other.TestEntity1;
			}
			testEntityList1_.Add(other.testEntityList1_);
			testEntityListWithNetRole_.Add(other.testEntityListWithNetRole_);
			testEntityDic_.Add(other.testEntityDic_);
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
				TestEntity1 = input.ReadUInt32();
				break;
			case 18u:
				testEntityList1_.AddEntriesFrom(input, _repeated_testEntityList1_codec);
				break;
			case 26u:
				testEntityListWithNetRole_.AddEntriesFrom(input, _repeated_testEntityListWithNetRole_codec);
				break;
			case 34u:
				testEntityDic_.AddEntriesFrom(input, _repeated_testEntityDic_codec);
				break;
			}
		}
	}
}
