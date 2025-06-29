using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using Diana.Common;

namespace b1;

public class BUS_BattleInfoComp : UActorCompBaseCS
{
	public class BGUBattleInfoLog
	{
		public EBGULogVerbosity LogVerbosityType;

		public EBattleInfoType BattleInfoType;

		public string TimeStr;

		public string SelectedUnitName;

		public string BattleInfoLogStr;

		public int BattleInfoLogOptions;

		public bool IsSend { get; set; }

		public void SetIsSend()
		{
			IsSend = true;
		}

		public BGUBattleInfoLog(EBattleInfoType _BattleInfoType, string _TimeStr, string _SelectedUnitName, string _BattleInfoLogStr, int _BattleInfoLogOptions, EBGULogVerbosity _LogVerbosity)
		{
			LogVerbosityType = _LogVerbosity;
			BattleInfoType = _BattleInfoType;
			TimeStr = _TimeStr;
			SelectedUnitName = _SelectedUnitName;
			string text = "TAMER";
			int num;
			for (num = 0; num < _BattleInfoLogStr.Length; num += text.Length)
			{
				num = _BattleInfoLogStr.IndexOf(text, num);
				if (num == -1)
				{
					break;
				}
				int num2 = _BattleInfoLogStr.IndexOf("<character>");
				_BattleInfoLogStr = _BattleInfoLogStr.Substring(0, num2 + 11) + _BattleInfoLogStr.Substring(num);
			}
			BattleInfoLogStr = _BattleInfoLogStr;
			BattleInfoLogOptions = _BattleInfoLogOptions;
			IsSend = false;
		}

		public string GetBattleInfoLogStr()
		{
			return TimeStr + " " + BattleInfoLogStr;
		}

		public bool IsCalledInTick()
		{
			return (BattleInfoLogOptions & 1) > 0;
		}
	}

	private int AddBuffCasterID;

	private float DamageValue;

	private readonly string FilePath = "GSBattleInfoLog";

	private float LastHp = float.MinValue;

	public static List<BGUBattleInfoLog> sBattleInfoLogList = new List<BGUBattleInfoLog>();

	private IBUC_TickRateData TickRateData;

	public override void OnAttach()
	{
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		base.BUSEventCollection.Evt_AddBattleInfoLog += new Del_AddBattleInfoLog(OnAddBattleInfoLog);
	}

	private void OnAddBattleInfoLog(EBattleInfoType BattleInfoType, string BattleInfoLog, int BattleInfoLogOptions, EBGULogVerbosity BGULogVerbosity)
	{
		sBattleInfoLogList.Add(new BGUBattleInfoLog(BattleInfoType, GetGameTimer(), GetUnitName(), BattleInfoLog, BattleInfoLogOptions, BGULogVerbosity));
	}

	public static void QAAddArchiveInfo(EBattleInfoType BattleInfoType, string BattleInfoLog, int BattleInfoLogOptions, EBGULogVerbosity BGULogVerbosity = EBGULogVerbosity.Log)
	{
		sBattleInfoLogList.Add(new BGUBattleInfoLog(BattleInfoType, $"<time>[{DateTime.Now:hh:mm:ss.fff}]</>", "ArchiveInfo", BattleInfoLog, BattleInfoLogOptions, BGULogVerbosity));
	}

	private string GetGameTimer()
	{
		return "<time>[" + DateTime.Now.ToString("hh:mm:ss.fff") + "]</>";
	}

	private string GetUnitName()
	{
		string name = GetOwner().GetName();
		int num = name.IndexOf("TAMER");
		if (num == -1)
		{
			return name;
		}
		return name.Substring(num);
	}
}
