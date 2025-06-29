using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ServerTranslateDesc : IMessage<ServerTranslateDesc>, IMessage, IEquatable<ServerTranslateDesc>, IDeepCloneable<ServerTranslateDesc>
{
	private static readonly MessageParser<ServerTranslateDesc> _parser = new MessageParser<ServerTranslateDesc>(() => new ServerTranslateDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string comment_ = "";

	private string key_ = "";

	private string enTh_ = "";

	private string frFr_ = "";

	private string deDe_ = "";

	private string jaJp_ = "";

	private string koKr_ = "";

	private string ruRu_ = "";

	private string zhTw_ = "";

	private string ptPt_ = "";

	private string itIt_ = "";

	private string esEs_ = "";

	private string arAr_ = "";

	private string thTh_ = "";

	public static MessageParser<ServerTranslateDesc> Parser => _parser;

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

	public ServerTranslateDesc()
	{
	}

	public ServerTranslateDesc(ServerTranslateDesc other)
		: this()
	{
		id_ = other.id_;
		comment_ = other.comment_;
		key_ = other.key_;
		enTh_ = other.enTh_;
		frFr_ = other.frFr_;
		deDe_ = other.deDe_;
		jaJp_ = other.jaJp_;
		koKr_ = other.koKr_;
		ruRu_ = other.ruRu_;
		zhTw_ = other.zhTw_;
		ptPt_ = other.ptPt_;
		itIt_ = other.itIt_;
		esEs_ = other.esEs_;
		arAr_ = other.arAr_;
		thTh_ = other.thTh_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ServerTranslateDesc Clone()
	{
		return new ServerTranslateDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ServerTranslateDesc);
	}

	public bool Equals(ServerTranslateDesc other)
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
		if (Comment != other.Comment)
		{
			return false;
		}
		if (Key != other.Key)
		{
			return false;
		}
		if (EnTh != other.EnTh)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Comment.Length != 0)
		{
			num ^= Comment.GetHashCode();
		}
		if (Key.Length != 0)
		{
			num ^= Key.GetHashCode();
		}
		if (EnTh.Length != 0)
		{
			num ^= EnTh.GetHashCode();
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
		if (Comment.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Comment);
		}
		if (Key.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Key);
		}
		if (EnTh.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(EnTh);
		}
		if (FrFr.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(FrFr);
		}
		if (DeDe.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DeDe);
		}
		if (JaJp.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(JaJp);
		}
		if (KoKr.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(KoKr);
		}
		if (RuRu.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(RuRu);
		}
		if (ZhTw.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(ZhTw);
		}
		if (PtPt.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(PtPt);
		}
		if (ItIt.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(ItIt);
		}
		if (EsEs.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(EsEs);
		}
		if (ArAr.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(ArAr);
		}
		if (ThTh.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(ThTh);
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
		if (Comment.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Comment);
		}
		if (Key.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Key);
		}
		if (EnTh.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnTh);
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
		if (PtPt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PtPt);
		}
		if (ItIt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ItIt);
		}
		if (EsEs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EsEs);
		}
		if (ArAr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArAr);
		}
		if (ThTh.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ThTh);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ServerTranslateDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Comment.Length != 0)
			{
				Comment = other.Comment;
			}
			if (other.Key.Length != 0)
			{
				Key = other.Key;
			}
			if (other.EnTh.Length != 0)
			{
				EnTh = other.EnTh;
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
				Comment = input.ReadString();
				break;
			case 26u:
				Key = input.ReadString();
				break;
			case 34u:
				EnTh = input.ReadString();
				break;
			case 42u:
				FrFr = input.ReadString();
				break;
			case 50u:
				DeDe = input.ReadString();
				break;
			case 58u:
				JaJp = input.ReadString();
				break;
			case 66u:
				KoKr = input.ReadString();
				break;
			case 74u:
				RuRu = input.ReadString();
				break;
			case 82u:
				ZhTw = input.ReadString();
				break;
			case 90u:
				PtPt = input.ReadString();
				break;
			case 98u:
				ItIt = input.ReadString();
				break;
			case 106u:
				EsEs = input.ReadString();
				break;
			case 114u:
				ArAr = input.ReadString();
				break;
			case 122u:
				ThTh = input.ReadString();
				break;
			}
		}
	}
}
