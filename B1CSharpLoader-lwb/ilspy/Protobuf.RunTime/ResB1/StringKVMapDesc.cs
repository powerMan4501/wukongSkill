using System;
using Google.Protobuf;

namespace ResB1;

public sealed class StringKVMapDesc : IMessage<StringKVMapDesc>, IMessage, IEquatable<StringKVMapDesc>, IDeepCloneable<StringKVMapDesc>
{
	private static readonly MessageParser<StringKVMapDesc> _parser = new MessageParser<StringKVMapDesc>(() => new StringKVMapDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string file_ = "";

	private string key_ = "";

	private string comment_ = "";

	private string enTh_ = "";

	private string index_ = "";

	private string frFr_ = "";

	private string deDe_ = "";

	private string jaJp_ = "";

	private string koKr_ = "";

	private string ruRu_ = "";

	private string zhTw_ = "";

	private string row_ = "";

	private string last_ = "";

	private string ptPt_ = "";

	private string itIt_ = "";

	private string esEs_ = "";

	private string arAr_ = "";

	private string thTh_ = "";

	private string unique_ = "";

	private int valid_;

	public static MessageParser<StringKVMapDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string File
	{
		get
		{
			return file_;
		}
		set
		{
			file_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Comment
	{
		get
		{
			return comment_;
		}
		set
		{
			comment_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string EnTh
	{
		get
		{
			return enTh_;
		}
		set
		{
			enTh_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string FrFr
	{
		get
		{
			return frFr_;
		}
		set
		{
			frFr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeDe
	{
		get
		{
			return deDe_;
		}
		set
		{
			deDe_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string JaJp
	{
		get
		{
			return jaJp_;
		}
		set
		{
			jaJp_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string KoKr
	{
		get
		{
			return koKr_;
		}
		set
		{
			koKr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RuRu
	{
		get
		{
			return ruRu_;
		}
		set
		{
			ruRu_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ZhTw
	{
		get
		{
			return zhTw_;
		}
		set
		{
			zhTw_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Row
	{
		get
		{
			return row_;
		}
		set
		{
			row_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Last
	{
		get
		{
			return last_;
		}
		set
		{
			last_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PtPt
	{
		get
		{
			return ptPt_;
		}
		set
		{
			ptPt_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ItIt
	{
		get
		{
			return itIt_;
		}
		set
		{
			itIt_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string EsEs
	{
		get
		{
			return esEs_;
		}
		set
		{
			esEs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ArAr
	{
		get
		{
			return arAr_;
		}
		set
		{
			arAr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ThTh
	{
		get
		{
			return thTh_;
		}
		set
		{
			thTh_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Unique
	{
		get
		{
			return unique_;
		}
		set
		{
			unique_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Valid
	{
		get
		{
			return valid_;
		}
		set
		{
			valid_ = value;
		}
	}

	public StringKVMapDesc()
	{
	}

	public StringKVMapDesc(StringKVMapDesc other)
		: this()
	{
		id_ = other.id_;
		file_ = other.file_;
		key_ = other.key_;
		comment_ = other.comment_;
		enTh_ = other.enTh_;
		index_ = other.index_;
		frFr_ = other.frFr_;
		deDe_ = other.deDe_;
		jaJp_ = other.jaJp_;
		koKr_ = other.koKr_;
		ruRu_ = other.ruRu_;
		zhTw_ = other.zhTw_;
		row_ = other.row_;
		last_ = other.last_;
		ptPt_ = other.ptPt_;
		itIt_ = other.itIt_;
		esEs_ = other.esEs_;
		arAr_ = other.arAr_;
		thTh_ = other.thTh_;
		unique_ = other.unique_;
		valid_ = other.valid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public StringKVMapDesc Clone()
	{
		return new StringKVMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as StringKVMapDesc);
	}

	public bool Equals(StringKVMapDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (File != other.File)
		{
			return false;
		}
		if (Key != other.Key)
		{
			return false;
		}
		if (Comment != other.Comment)
		{
			return false;
		}
		if (EnTh != other.EnTh)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (FrFr != other.FrFr)
		{
			return false;
		}
		if (DeDe != other.DeDe)
		{
			return false;
		}
		if (JaJp != other.JaJp)
		{
			return false;
		}
		if (KoKr != other.KoKr)
		{
			return false;
		}
		if (RuRu != other.RuRu)
		{
			return false;
		}
		if (ZhTw != other.ZhTw)
		{
			return false;
		}
		if (Row != other.Row)
		{
			return false;
		}
		if (Last != other.Last)
		{
			return false;
		}
		if (PtPt != other.PtPt)
		{
			return false;
		}
		if (ItIt != other.ItIt)
		{
			return false;
		}
		if (EsEs != other.EsEs)
		{
			return false;
		}
		if (ArAr != other.ArAr)
		{
			return false;
		}
		if (ThTh != other.ThTh)
		{
			return false;
		}
		if (Unique != other.Unique)
		{
			return false;
		}
		if (Valid != other.Valid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (File.Length != 0)
		{
			num ^= File.GetHashCode();
		}
		if (Key.Length != 0)
		{
			num ^= Key.GetHashCode();
		}
		if (Comment.Length != 0)
		{
			num ^= Comment.GetHashCode();
		}
		if (EnTh.Length != 0)
		{
			num ^= EnTh.GetHashCode();
		}
		if (Index.Length != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (FrFr.Length != 0)
		{
			num ^= FrFr.GetHashCode();
		}
		if (DeDe.Length != 0)
		{
			num ^= DeDe.GetHashCode();
		}
		if (JaJp.Length != 0)
		{
			num ^= JaJp.GetHashCode();
		}
		if (KoKr.Length != 0)
		{
			num ^= KoKr.GetHashCode();
		}
		if (RuRu.Length != 0)
		{
			num ^= RuRu.GetHashCode();
		}
		if (ZhTw.Length != 0)
		{
			num ^= ZhTw.GetHashCode();
		}
		if (Row.Length != 0)
		{
			num ^= Row.GetHashCode();
		}
		if (Last.Length != 0)
		{
			num ^= Last.GetHashCode();
		}
		if (PtPt.Length != 0)
		{
			num ^= PtPt.GetHashCode();
		}
		if (ItIt.Length != 0)
		{
			num ^= ItIt.GetHashCode();
		}
		if (EsEs.Length != 0)
		{
			num ^= EsEs.GetHashCode();
		}
		if (ArAr.Length != 0)
		{
			num ^= ArAr.GetHashCode();
		}
		if (ThTh.Length != 0)
		{
			num ^= ThTh.GetHashCode();
		}
		if (Unique.Length != 0)
		{
			num ^= Unique.GetHashCode();
		}
		if (Valid != 0)
		{
			num ^= Valid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (File.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(File);
		}
		if (Key.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Key);
		}
		if (Comment.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Comment);
		}
		if (EnTh.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(EnTh);
		}
		if (Index.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Index);
		}
		if (FrFr.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(FrFr);
		}
		if (DeDe.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(DeDe);
		}
		if (JaJp.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(JaJp);
		}
		if (KoKr.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(KoKr);
		}
		if (RuRu.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(RuRu);
		}
		if (ZhTw.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(ZhTw);
		}
		if (Row.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(Row);
		}
		if (Last.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(Last);
		}
		if (PtPt.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(PtPt);
		}
		if (ItIt.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(ItIt);
		}
		if (EsEs.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(EsEs);
		}
		if (ArAr.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(ArAr);
		}
		if (ThTh.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(ThTh);
		}
		if (Unique.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(Unique);
		}
		if (Valid != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(Valid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (File.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(File);
		}
		if (Key.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Key);
		}
		if (Comment.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Comment);
		}
		if (EnTh.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnTh);
		}
		if (Index.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Index);
		}
		if (FrFr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FrFr);
		}
		if (DeDe.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeDe);
		}
		if (JaJp.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JaJp);
		}
		if (KoKr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(KoKr);
		}
		if (RuRu.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RuRu);
		}
		if (ZhTw.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ZhTw);
		}
		if (Row.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Row);
		}
		if (Last.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Last);
		}
		if (PtPt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PtPt);
		}
		if (ItIt.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ItIt);
		}
		if (EsEs.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(EsEs);
		}
		if (ArAr.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ArAr);
		}
		if (ThTh.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ThTh);
		}
		if (Unique.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Unique);
		}
		if (Valid != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Valid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(StringKVMapDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.File.Length != 0)
			{
				File = other.File;
			}
			if (other.Key.Length != 0)
			{
				Key = other.Key;
			}
			if (other.Comment.Length != 0)
			{
				Comment = other.Comment;
			}
			if (other.EnTh.Length != 0)
			{
				EnTh = other.EnTh;
			}
			if (other.Index.Length != 0)
			{
				Index = other.Index;
			}
			if (other.FrFr.Length != 0)
			{
				FrFr = other.FrFr;
			}
			if (other.DeDe.Length != 0)
			{
				DeDe = other.DeDe;
			}
			if (other.JaJp.Length != 0)
			{
				JaJp = other.JaJp;
			}
			if (other.KoKr.Length != 0)
			{
				KoKr = other.KoKr;
			}
			if (other.RuRu.Length != 0)
			{
				RuRu = other.RuRu;
			}
			if (other.ZhTw.Length != 0)
			{
				ZhTw = other.ZhTw;
			}
			if (other.Row.Length != 0)
			{
				Row = other.Row;
			}
			if (other.Last.Length != 0)
			{
				Last = other.Last;
			}
			if (other.PtPt.Length != 0)
			{
				PtPt = other.PtPt;
			}
			if (other.ItIt.Length != 0)
			{
				ItIt = other.ItIt;
			}
			if (other.EsEs.Length != 0)
			{
				EsEs = other.EsEs;
			}
			if (other.ArAr.Length != 0)
			{
				ArAr = other.ArAr;
			}
			if (other.ThTh.Length != 0)
			{
				ThTh = other.ThTh;
			}
			if (other.Unique.Length != 0)
			{
				Unique = other.Unique;
			}
			if (other.Valid != 0)
			{
				Valid = other.Valid;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				File = input.ReadString();
				break;
			case 26u:
				Key = input.ReadString();
				break;
			case 34u:
				Comment = input.ReadString();
				break;
			case 42u:
				EnTh = input.ReadString();
				break;
			case 50u:
				Index = input.ReadString();
				break;
			case 58u:
				FrFr = input.ReadString();
				break;
			case 66u:
				DeDe = input.ReadString();
				break;
			case 74u:
				JaJp = input.ReadString();
				break;
			case 82u:
				KoKr = input.ReadString();
				break;
			case 90u:
				RuRu = input.ReadString();
				break;
			case 98u:
				ZhTw = input.ReadString();
				break;
			case 106u:
				Row = input.ReadString();
				break;
			case 114u:
				Last = input.ReadString();
				break;
			case 122u:
				PtPt = input.ReadString();
				break;
			case 130u:
				ItIt = input.ReadString();
				break;
			case 138u:
				EsEs = input.ReadString();
				break;
			case 146u:
				ArAr = input.ReadString();
				break;
			case 154u:
				ThTh = input.ReadString();
				break;
			case 162u:
				Unique = input.ReadString();
				break;
			case 168u:
				Valid = input.ReadInt32();
				break;
			}
		}
	}
}
