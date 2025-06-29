using System;
using System.Collections.Generic;

namespace b1.Protobuf.BG_ParserManager;

public class BG_ParserStatusManager
{
	private static BG_ParserStatusManager _instance;

	public readonly List<string> ProcessLogs;

	public readonly Dictionary<string, FILE_PROCESS_STATUS> ProcessStatusDict;

	public readonly Dictionary<string, bool> LocalProcessModesDict;

	public readonly string StatusLog = "CoversionLog.txt";

	public string FailureBriefDescription = "";

	public static BG_ParserStatusManager Get()
	{
		if (_instance == null)
		{
			_instance = new BG_ParserStatusManager();
		}
		return _instance;
	}

	private BG_ParserStatusManager()
	{
		ProcessLogs = new List<string>();
		ProcessStatusDict = new Dictionary<string, FILE_PROCESS_STATUS>();
		LocalProcessModesDict = new Dictionary<string, bool>();
	}

	public void AddLog(string log, ParserManagerLogVerbosity Verbosity = ParserManagerLogVerbosity.Log)
	{
		string text = "Log_Normal";
		switch (Verbosity)
		{
		case ParserManagerLogVerbosity.Debug:
			text = "Log_Gray";
			break;
		case ParserManagerLogVerbosity.Log:
			text = "Log_Normal";
			break;
		case ParserManagerLogVerbosity.Warning:
			text = "Log_Yellow";
			break;
		case ParserManagerLogVerbosity.Error:
			text = "Log_Red";
			break;
		case ParserManagerLogVerbosity.Success:
			text = "Log_Green";
			break;
		}
		ProcessLogs.Add(string.Format("<Log_Gray>{0} ></> \n<{1}>{2}</>", DateTime.Now, text, log.Replace("\n", "</>\n<" + text + ">")));
	}
}
