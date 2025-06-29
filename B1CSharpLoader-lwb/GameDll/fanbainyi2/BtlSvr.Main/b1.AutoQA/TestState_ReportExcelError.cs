using System.Collections.Generic;
using System.IO;
using System.Net;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class TestState_ReportExcelError : AutoTestNodeLib.TestState_Node
{
	public TestState_ReportExcelError(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "获取ExcelError并上报";
		if (!UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext)))
		{
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		string text = "";
		string text2 = "";
		foreach (KeyValuePair<string, string> item in BGW_ValiDateMgr.ValidateLog)
		{
			string key = item.Key;
			string value = item.Value;
			if (key != "null")
			{
				text = text + "@" + key + ":\n";
				text2 = text2 + "\"" + key + "\",";
			}
			else
			{
				text += "@非特定策划:\n";
			}
			text += value;
		}
		text2.TrimEnd(',');
		if (!text.Equals(""))
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=8d223c54-ba50-4fa5-9470-78e51f66fb6f");
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "POST";
			using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string text3 = "{\r\n                     \"msgtype\": \"text\",\r\n                     \"text\": {\r\n                      \"content\": \"" + text + "\",\r\n                            \"mentioned_list\":[" + text2 + "]\r\n                        }\r\n                    }";
				AutoTestHelperLib.QALog(WorldContext, text3);
				streamWriter.Write(text3);
			}
			using StreamReader streamReader = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream());
			string inString = streamReader.ReadToEnd();
			AutoTestHelperLib.QALog(WorldContext, inString);
		}
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
