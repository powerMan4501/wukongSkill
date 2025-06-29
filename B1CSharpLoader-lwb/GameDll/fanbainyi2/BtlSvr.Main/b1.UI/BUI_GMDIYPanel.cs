using System;
using System.Collections.Generic;
using System.Xml;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMDIYPanel")]
internal class BUI_GMDIYPanel : BUI_Widget
{
	private List<b1.UI.CustomizeGmCmds> customizeGm = new List<b1.UI.CustomizeGmCmds>();

	private string XmlPath;

	private UEditableTextBox EditCmdName;

	private const string EDITCMDNAME_NAME = "EditCmdName";

	private UMultiLineEditableTextBox EditCmdValue;

	private const string EDITCMDVALUE_NAME = "EditCmdValue";

	private UButton SaveBtn;

	private const string SAVEBTN_NAME = "SaveBtn";

	private UButton ReturnBtn;

	private const string RETURNBTN_NAME = "ReturnBtn";

	private UMultiLineEditableTextBox CmdStudy;

	private const string CMDSTUDY_NAME = "CmdStudy";

	private UScrollBox GmScrBox;

	private const string GMSCRBOX_NAME = "GmScrBox";

	private const string UNITCMDNAME_NAME = "UnitCmdName";

	private const string UNITCMDS_NAME = "UnitCmds";

	private static bool CmdGroupTemp_IsValid;

	private static int CmdGroupTemp_Offset;

	private static bool OnClickDoSaveCmds_IsValid;

	private static IntPtr OnClickDoSaveCmds_FunctionAddress;

	private static int OnClickDoSaveCmds_ParamsSize;

	private static bool OnClickDoReturnCmdList_IsValid;

	private static IntPtr OnClickDoReturnCmdList_FunctionAddress;

	private static int OnClickDoReturnCmdList_ParamsSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_GMDIYPanel:CmdGroupTemp")]
	public TSubclassOf<UUserWidget> CmdGroupTemp
	{
		get
		{
			CheckDestroyed();
			if (!CmdGroupTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMDIYPanel:CmdGroupTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, CmdGroupTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CmdGroupTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMDIYPanel:CmdGroupTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, CmdGroupTemp_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		XmlPath = FPaths.ProjectDir;
		XmlPath += "\\";
		XmlPath += "GmData.xml";
		EditCmdName = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("EditCmdName")) as UEditableTextBox;
		EditCmdValue = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("EditCmdValue")) as UMultiLineEditableTextBox;
		CmdStudy = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CmdStudy")) as UMultiLineEditableTextBox;
		if (EditCmdName == null || EditCmdValue == null || CmdStudy == null)
		{
			return;
		}
		GmScrBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("GmScrBox")) as UScrollBox;
		if (!(GmScrBox == null))
		{
			SaveBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SaveBtn")) as UButton;
			if (SaveBtn != null)
			{
				SaveBtn.OnClicked.Bind(OnClickDoSaveCmds);
			}
			ReturnBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ReturnBtn")) as UButton;
			if (ReturnBtn != null)
			{
				ReturnBtn.OnClicked.Bind(OnClickDoReturnCmdList);
			}
			SetCmdStudyText();
			DoLoad();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMDIYPanel:OnClickDoSaveCmds")]
	private void OnClickDoSaveCmds()
	{
		b1.UI.CustomizeGmCmds gmunit = new b1.UI.CustomizeGmCmds(EditCmdName.GetText(), BGU_UMGUtil.StringtoListLinebyLine(EditCmdValue.GetText()));
		if (gmunit.Cmds.Count != 0 && !(gmunit.CmdName == ""))
		{
			AddConfigToXml(gmunit);
			DoLoad();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMDIYPanel:OnClickDoReturnCmdList")]
	private void OnClickDoReturnCmdList()
	{
		SetCmdStudyText();
	}

	private void DoLoad()
	{
		customizeGm = LoadConfigFromXml();
		if (customizeGm == null)
		{
			UGSE_EngineFuncLib.LogDbg("未获取到GM数据信息", bPrintScreen: true);
			return;
		}
		foreach (UWidget allChild in GmScrBox.GetAllChildren())
		{
			GmScrBox.RemoveChild(allChild);
		}
		foreach (b1.UI.CustomizeGmCmds item in customizeGm)
		{
			AddCmdUnitToScrBox(GmScrBox, item);
		}
	}

	private void AddCmdUnitToScrBox(UScrollBox GmScrBox, b1.UI.CustomizeGmCmds gmunit)
	{
		if (CmdGroupTemp == null)
		{
			return;
		}
		b1.UI.BUI_GM_OP_DIY bUI_GM_OP_DIY = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, CmdGroupTemp.Value) as b1.UI.BUI_GM_OP_DIY;
		UTextBlock obj = UGSE_UMGFuncLib.GetWidgetFromName(bUI_GM_OP_DIY, new FName("UnitCmdName")) as UTextBlock;
		UMultiLineEditableTextBox uMultiLineEditableTextBox = UGSE_UMGFuncLib.GetWidgetFromName(bUI_GM_OP_DIY, new FName("UnitCmds")) as UMultiLineEditableTextBox;
		bUI_GM_OP_DIY.CmdName = gmunit.CmdName;
		bUI_GM_OP_DIY.DataPath = XmlPath;
		obj.SetText(FText.FromString(gmunit.CmdName));
		string text = "";
		foreach (string cmd in gmunit.Cmds)
		{
			bUI_GM_OP_DIY.CmdList.Add(cmd);
			text += cmd;
			text += "\n";
		}
		uMultiLineEditableTextBox.SetText(FText.FromString(text));
		GmScrBox.AddChild(bUI_GM_OP_DIY);
	}

	private void AddConfigToXml(b1.UI.CustomizeGmCmds gmunit)
	{
		if (gmunit.CmdName == null)
		{
			return;
		}
		if (!UBGUFunctionLibrary.BGUIsExistFile(XmlPath))
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlDeclaration newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", "yes");
			xmlDocument.AppendChild(newChild);
			XmlElement xmlElement = xmlDocument.CreateElement("CustomizeGM");
			xmlDocument.AppendChild(xmlElement);
			XmlElement xmlElement2 = xmlDocument.CreateElement("GmUnit");
			xmlElement2.SetAttribute("Name", gmunit.CmdName);
			xmlElement.AppendChild(xmlElement2);
			foreach (string cmd in gmunit.Cmds)
			{
				XmlElement xmlElement3 = xmlDocument.CreateElement("GmCmd");
				xmlElement3.InnerText = cmd;
				xmlElement2.AppendChild(xmlElement3);
			}
			xmlDocument.Save(XmlPath);
			return;
		}
		XmlDocument xmlDocument2 = new XmlDocument();
		xmlDocument2.Load(XmlPath);
		XmlNode xmlNode = xmlDocument2.SelectSingleNode("CustomizeGM");
		if (xmlNode.HasChildNodes)
		{
			foreach (XmlElement childNode in xmlNode.ChildNodes)
			{
				if (childNode.GetAttribute("Name") == gmunit.CmdName)
				{
					UGSE_EngineFuncLib.LogDbg("错误：命名冲突！", bPrintScreen: true);
					return;
				}
			}
		}
		XmlElement xmlElement4 = xmlDocument2.CreateElement("GmUnit");
		xmlElement4.SetAttribute("Name", gmunit.CmdName);
		xmlNode.AppendChild(xmlElement4);
		foreach (string cmd2 in gmunit.Cmds)
		{
			XmlElement xmlElement5 = xmlDocument2.CreateElement("GmCmd");
			xmlElement5.InnerText = cmd2;
			xmlElement4.AppendChild(xmlElement5);
		}
		xmlDocument2.Save(XmlPath);
	}

	private List<b1.UI.CustomizeGmCmds> LoadConfigFromXml()
	{
		if (!UBGUFunctionLibrary.BGUIsExistFile(XmlPath))
		{
			return null;
		}
		List<b1.UI.CustomizeGmCmds> list = new List<b1.UI.CustomizeGmCmds>();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(XmlPath);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("CustomizeGM");
		if (xmlNode.HasChildNodes)
		{
			XmlNodeList childNodes = xmlNode.ChildNodes;
			for (int i = 0; i < childNodes.Count; i++)
			{
				XmlElement obj = (XmlElement)childNodes[i];
				string attribute = obj.GetAttribute("Name");
				List<string> list2 = new List<string>();
				foreach (XmlElement childNode in obj.ChildNodes)
				{
					list2.Add(childNode.InnerText);
				}
				b1.UI.CustomizeGmCmds item = new b1.UI.CustomizeGmCmds(attribute, list2);
				list.Add(item);
			}
		}
		return list;
	}

	private void RemoveConfigInXml(string itemname)
	{
		if (!UBGUFunctionLibrary.BGUIsExistFile(XmlPath))
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(XmlPath);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("CustomizeGM");
		if (xmlNode.HasChildNodes)
		{
			XmlNodeList childNodes = xmlNode.ChildNodes;
			for (int i = 0; i < childNodes.Count; i++)
			{
				if (((XmlElement)childNodes[i]).GetAttribute("Name") == itemname)
				{
					xmlNode.RemoveChild(childNodes[i]);
				}
			}
		}
		xmlDocument.Save(XmlPath);
	}

	private void SetCmdStudyText()
	{
		string str = "GM指令参考：(可复制)\n回血: b.fullHP\n回蓝: b.fullMP\n锁血: b.LockHP\n解除锁血: b.LockHPb.UnlockHP\n无敌: b.Invincible\n解除无敌: b.UnInvincible\n锁体力: b.LockStamina\n解除锁体力: b.UnLockStamina\n设置最大血量: b.SetMaxHP 1000\n设置最大血量: b.SetMaxMP 1000\n设置攻击力: b.SetATK 1000\n设置全局速度缩放: b.ChangeGlobalSpd 0.5\n设置角色速度缩放: b.ChangeCharacterSpd 0.5\n设置角色速度缩放: b.ChangeEnemySpd 0.5\n添加指定Buff: b.AddBuff 100\n移除所有Buff: b.RemoveAllBuff\n设置镜头远近: b.SetCamArmMode 1\n设置血瓶数量：b.SetBloodBottle 999\n设置回满血瓶数量：b.FullBloodBottle";
		CmdStudy.SetText(FText.FromString(str));
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMDIYPanel:OnClickDoSaveCmds")]
	private static void OnClickDoSaveCmds__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMDIYPanel bUI_GMDIYPanel = GCHelper.Find<b1.UI.BUI_GMDIYPanel>(obj);
		bUI_GMDIYPanel.OnClickDoSaveCmds();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMDIYPanel:OnClickDoReturnCmdList")]
	private static void OnClickDoReturnCmdList__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMDIYPanel bUI_GMDIYPanel = GCHelper.Find<b1.UI.BUI_GMDIYPanel>(obj);
		bUI_GMDIYPanel.OnClickDoReturnCmdList();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMDIYPanel");
		CmdGroupTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CmdGroupTemp");
		CmdGroupTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CmdGroupTemp", Classes.FClassProperty);
		OnClickDoSaveCmds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoSaveCmds");
		OnClickDoSaveCmds_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoSaveCmds_FunctionAddress);
		OnClickDoSaveCmds_IsValid = OnClickDoSaveCmds_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMDIYPanel:OnClickDoSaveCmds", OnClickDoSaveCmds_IsValid);
		OnClickDoReturnCmdList_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoReturnCmdList");
		OnClickDoReturnCmdList_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoReturnCmdList_FunctionAddress);
		OnClickDoReturnCmdList_IsValid = OnClickDoReturnCmdList_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMDIYPanel:OnClickDoReturnCmdList", OnClickDoReturnCmdList_IsValid);
	}

	static BUI_GMDIYPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMDIYPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMDIYPanel));
	}
}
