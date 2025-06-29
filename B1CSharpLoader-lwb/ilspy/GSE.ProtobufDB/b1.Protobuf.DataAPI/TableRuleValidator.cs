using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Protobuf.DataAPI;

public class TableRuleValidator
{
	private enum EVerificationRule
	{
		None,
		AnyChange,
		LineAdd,
		LineDelete,
		LineModify,
		ValueModify,
		ValueIncrease,
		ValueDecrease
	}

	private List<KeyValuePair<EVerificationRule, object>> VerRuleList = new List<KeyValuePair<EVerificationRule, object>>();

	private readonly string ProtobufDllPath = USystemLibrary.GetProjectDirectory().Replace("/", "\\") + "\\Binaries\\Managed\\Protobuf.RunTime.dll";

	public bool ExecValidation(string TableName, string OldTableDataPath, IMessage NewTableDataObj, string NewTableDataPath, Type TargetTableType, out string ErrorReason)
	{
		ErrorReason = "";
		if (TargetTableType == null)
		{
			BGW_LogUtil.LogError("[TableRuleValidator] ExecValidation TargetTableType == null!");
			return true;
		}
		if (!GenVerificationRule(TableName))
		{
			return true;
		}
		if (OldTableDataPath == null || !File.Exists(OldTableDataPath))
		{
			string[] files = Directory.GetFiles(Path.GetFullPath(FPaths.Combine(FPaths.ProjectDir, "GSDataTable", "ZTable_RuleVerification", "PBTable")), TableName + ".data", SearchOption.AllDirectories);
			if (files.Length != 0)
			{
				OldTableDataPath = files[0];
			}
		}
		else
		{
			try
			{
				if (UGSFunclibPerforceSourceControlModule.IsSourceControlEnabled() && UGSFunclibPerforceSourceControlModule.QueryFileState(out var inState, OldTableDataPath))
				{
					if (!inState.IsCheckedOut)
					{
						UGSFunclibPerforceSourceControlModule.GetLatestRevision(OldTableDataPath, IsForced: true);
					}
					else
					{
						UGSFunclibPerforceSourceControlModule.RevertFile(OldTableDataPath);
						UGSFunclibPerforceSourceControlModule.CheckOutOrAddFile(OldTableDataPath);
					}
				}
			}
			catch (Exception arg)
			{
				BGW_LogUtil.LogError($"[TableRuleValidator] {OldTableDataPath} GetLatestRevision Failed {arg}");
			}
		}
		if (OldTableDataPath == null || !File.Exists(OldTableDataPath))
		{
			BGW_LogUtil.LogError("[TableRuleValidator] ExecValidation Cant Get OldTableDataPath!");
			return true;
		}
		TableDataDiffHelper targetDataDiffHelper = new TableDataDiffHelper(OldTableDataPath, NewTableDataObj, NewTableDataPath, TargetTableType);
		foreach (KeyValuePair<EVerificationRule, object> verRule in VerRuleList)
		{
			if (!RuleValidation(verRule.Key, verRule.Value, targetDataDiffHelper, out ErrorReason))
			{
				return false;
			}
		}
		return true;
	}

	private bool GenVerificationRule(string TableName)
	{
		VerRuleList = new List<KeyValuePair<EVerificationRule, object>>();
		Dictionary<string, object> dictionary = ParseRuleFile();
		if (dictionary != null)
		{
			foreach (KeyValuePair<string, object> item in dictionary)
			{
				if (!(item.Key == TableName))
				{
					continue;
				}
				if (!(item.Value is List<object> list))
				{
					break;
				}
				foreach (object item2 in list)
				{
					if (item2 is Dictionary<string, object> { Count: >0 } dictionary2)
					{
						EVerificationRule verTypeFromString = GetVerTypeFromString(dictionary2.First().Key);
						if (verTypeFromString != EVerificationRule.None)
						{
							VerRuleList.Add(new KeyValuePair<EVerificationRule, object>(verTypeFromString, dictionary2.First().Value));
						}
					}
				}
				break;
			}
		}
		return VerRuleList.Count > 0;
	}

	private Dictionary<string, object> ParseRuleFile()
	{
		string path = FPaths.Combine(FPaths.ProjectDir, "GSDataTable", "ZTable_RuleVerification", "TableVerificationRule.json");
		if (!File.Exists(path))
		{
			return null;
		}
		return GSPathUtil.ParseJsonFromString(File.ReadAllText(path)) as Dictionary<string, object>;
	}

	private EVerificationRule GetVerTypeFromString(string InString)
	{
		return InString switch
		{
			"AnyChange" => EVerificationRule.AnyChange, 
			"LineAdd" => EVerificationRule.LineAdd, 
			"LineDelete" => EVerificationRule.LineDelete, 
			"LineModify" => EVerificationRule.LineModify, 
			"ValueModify" => EVerificationRule.ValueModify, 
			"ValueIncrease" => EVerificationRule.ValueIncrease, 
			"ValueDecrease" => EVerificationRule.ValueDecrease, 
			_ => EVerificationRule.None, 
		};
	}

	private bool RuleValidation(EVerificationRule VerType, object RuleParam, TableDataDiffHelper TargetDataDiffHelper, out string ErrorReason)
	{
		if (TargetDataDiffHelper == null)
		{
			ErrorReason = "";
			return true;
		}
		List<int> list = new List<int>();
		List<object> list2 = new List<object>();
		if (RuleParam != null && RuleParam is Dictionary<string, object> dictionary)
		{
			if (dictionary.TryGetValue("IdList", out var value) && value is IEnumerable<object> enumerable)
			{
				foreach (object item in enumerable)
				{
					if (item != null && item is string s && int.TryParse(s, out var result))
					{
						list.Add(result);
					}
				}
			}
			if (dictionary.TryGetValue("PropertyList", out var value2) && value2 is IEnumerable<object> enumerable2)
			{
				foreach (object item2 in enumerable2)
				{
					if (item2 != null)
					{
						list2.Add(item2);
					}
				}
			}
		}
		switch (VerType)
		{
		case EVerificationRule.AnyChange:
			return TargetDataDiffHelper.RuleValidation_AnyChange(out ErrorReason);
		case EVerificationRule.LineAdd:
			return TargetDataDiffHelper.RuleValidation_LineAdd(out ErrorReason);
		case EVerificationRule.LineDelete:
			return TargetDataDiffHelper.RuleValidation_LineDelete(out ErrorReason, list);
		case EVerificationRule.LineModify:
			return TargetDataDiffHelper.RuleValidation_LineModify(out ErrorReason, list);
		case EVerificationRule.ValueModify:
			return TargetDataDiffHelper.RuleValidation_ValueModify(out ErrorReason, list2, list);
		case EVerificationRule.ValueIncrease:
			return TargetDataDiffHelper.RuleValidation_ValueIncrease(out ErrorReason, list2, list);
		case EVerificationRule.ValueDecrease:
			return TargetDataDiffHelper.RuleValidation_ValueDecrease(out ErrorReason, list2, list);
		default:
			ErrorReason = "";
			return true;
		}
	}

	public void AllTableDataValidation(string OldDataFolderPath, string NewDataFolderPath)
	{
		if (!Directory.Exists(OldDataFolderPath) || !Directory.Exists(NewDataFolderPath))
		{
			return;
		}
		Dictionary<string, object> dictionary = ParseRuleFile();
		if (dictionary == null)
		{
			return;
		}
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			string[] files = Directory.GetFiles(OldDataFolderPath, item.Key + ".data", SearchOption.AllDirectories);
			string[] files2 = Directory.GetFiles(NewDataFolderPath, item.Key + ".data", SearchOption.AllDirectories);
			if (files.Length != 0 && files2.Length != 0)
			{
				if (BG_ProtobufDataLoader.Get().GetDatabaseType("TB" + item.Key) == null && UGSE_EngineFuncLib.IsEditor())
				{
					BG_ProtobufDataLoader.Get().LoadDLLForTableTool(in ProtobufDllPath);
				}
				string ErrorReason;
				bool flag = ExecValidation(item.Key, Path.GetFullPath(files[0]), null, Path.GetFullPath(files2[0]), BG_ProtobufDataLoader.Get().GetDatabaseType("TB" + item.Key), out ErrorReason);
				if (!flag)
				{
					BGW_LogUtil.LogError($"[TableRuleValidator] {item.Key} IsPass:{flag} ErrorReason:{ErrorReason}");
				}
			}
		}
	}
}
