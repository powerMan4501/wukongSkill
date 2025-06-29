using System;
using System.Collections.Generic;
using System.Xml;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GM_OP_DIY")]
internal class BUI_GM_OP_DIY : BUI_Widget
{
	public string DataPath;

	public string CmdName;

	public List<string> CmdList = new List<string>();

	private UButton UseBtn;

	private const string USEBTN_NAME = "UseBtn";

	private UButton DeleteBtn;

	private const string DELETEBTN_NAME = "DeleteBtn";

	private UButton SaveBtn;

	private const string SAVEBTN_NAME = "SaveBtn";

	private UTextBlock UnitCmdName;

	private const string UNITCMDNAME_NAME = "UnitCmdName";

	private UMultiLineEditableTextBox UnitCmds;

	private const string UNITCMDS_NAME = "UnitCmds";

	private static bool OnClickDoCmds_IsValid;

	private static IntPtr OnClickDoCmds_FunctionAddress;

	private static int OnClickDoCmds_ParamsSize;

	private static bool OnClickDoSave_IsValid;

	private static IntPtr OnClickDoSave_FunctionAddress;

	private static int OnClickDoSave_ParamsSize;

	private static bool OnClickDoDelete_IsValid;

	private static IntPtr OnClickDoDelete_FunctionAddress;

	private static int OnClickDoDelete_ParamsSize;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UseBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UseBtn")) as UButton;
		if (UseBtn != null)
		{
			UseBtn.OnClicked.Bind(OnClickDoCmds);
		}
		DeleteBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DeleteBtn")) as UButton;
		if (DeleteBtn != null)
		{
			DeleteBtn.OnClicked.Bind(OnClickDoDelete);
		}
		SaveBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SaveBtn")) as UButton;
		if (SaveBtn != null)
		{
			SaveBtn.OnClicked.Bind(OnClickDoSave);
		}
		UnitCmdName = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UnitCmdName")) as UTextBlock;
		UnitCmds = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UnitCmds")) as UMultiLineEditableTextBox;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoCmds")]
	private void OnClickDoCmds()
	{
		foreach (string cmd in CmdList)
		{
			UGSE_EngineFuncLib.LogDbg(cmd, bPrintScreen: true);
			USystemLibrary.ExecuteConsoleCommand(this, cmd, null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoDelete")]
	private void OnClickDoDelete()
	{
		if (!UBGUFunctionLibrary.BGUIsExistFile(DataPath))
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(DataPath);
		UGSE_EngineFuncLib.LogDbg("Delete", bPrintScreen: true);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("CustomizeGM");
		if (xmlNode.HasChildNodes)
		{
			XmlNodeList childNodes = xmlNode.ChildNodes;
			for (int i = 0; i < childNodes.Count; i++)
			{
				if (((XmlElement)childNodes[i]).GetAttribute("Name") == CmdName)
				{
					xmlNode.RemoveChild(childNodes[i]);
				}
			}
		}
		xmlDocument.Save(DataPath);
		GetParent().RemoveChild(this);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoSave")]
	private void OnClickDoSave()
	{
		UGSE_EngineFuncLib.LogDbg("Save", bPrintScreen: true);
		if (!UBGUFunctionLibrary.BGUIsExistFile(DataPath))
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(DataPath);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("CustomizeGM");
		if (xmlNode.HasChildNodes)
		{
			XmlNodeList childNodes = xmlNode.ChildNodes;
			for (int i = 0; i < childNodes.Count; i++)
			{
				XmlElement xmlElement = (XmlElement)childNodes[i];
				if (!(xmlElement.GetAttribute("Name") == CmdName))
				{
					continue;
				}
				List<string> list = BGU_UMGUtil.StringtoListLinebyLine(UnitCmds.GetText());
				CmdList = new List<string>(list.ToArray());
				int num;
				for (num = 0; num < xmlElement.ChildNodes.Count; num++)
				{
					xmlElement.RemoveChild(xmlElement.ChildNodes[num]);
					num--;
				}
				foreach (string item in list)
				{
					XmlElement xmlElement2 = xmlDocument.CreateElement("GmCmd");
					xmlElement2.InnerText = item;
					xmlElement.AppendChild(xmlElement2);
				}
			}
		}
		xmlDocument.Save(DataPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoCmds")]
	private static void OnClickDoCmds__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GM_OP_DIY bUI_GM_OP_DIY = GCHelper.Find<b1.UI.BUI_GM_OP_DIY>(obj);
		bUI_GM_OP_DIY.OnClickDoCmds();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoSave")]
	private static void OnClickDoSave__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GM_OP_DIY bUI_GM_OP_DIY = GCHelper.Find<b1.UI.BUI_GM_OP_DIY>(obj);
		bUI_GM_OP_DIY.OnClickDoSave();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoDelete")]
	private static void OnClickDoDelete__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GM_OP_DIY bUI_GM_OP_DIY = GCHelper.Find<b1.UI.BUI_GM_OP_DIY>(obj);
		bUI_GM_OP_DIY.OnClickDoDelete();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_GM_OP_DIY");
		OnClickDoCmds_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickDoCmds");
		OnClickDoCmds_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoCmds_FunctionAddress);
		OnClickDoCmds_IsValid = OnClickDoCmds_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoCmds", OnClickDoCmds_IsValid);
		OnClickDoSave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickDoSave");
		OnClickDoSave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoSave_FunctionAddress);
		OnClickDoSave_IsValid = OnClickDoSave_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoSave", OnClickDoSave_IsValid);
		OnClickDoDelete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickDoDelete");
		OnClickDoDelete_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoDelete_FunctionAddress);
		OnClickDoDelete_IsValid = OnClickDoDelete_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_OP_DIY:OnClickDoDelete", OnClickDoDelete_IsValid);
	}

	static BUI_GM_OP_DIY()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GM_OP_DIY)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GM_OP_DIY));
	}
}
