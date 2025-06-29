using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using b1.BGU.Util;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ZBBPanel")]
internal class BUI_ZBBPanel : BUI_Widget
{
	private UTextBlock SkillIDValue;

	private const string SKILLIDVALUE_NAME = "SkillIDValue";

	private UTextBlock EffectiveHitValue;

	private const string EFFECTIVEHITVALUE_NAME = "EffectiveHitValue";

	private UTextBlock AllHitValue;

	private const string ALLHITVALUE_NAME = "AllHitValue";

	private UTextBlock HitRateValue;

	private const string HITRATEVALUE_NAME = "HitRateValue";

	private UTextBlock AverageHitTimeValue;

	private const string AVERAGEHITTIMEVALUE_NAME = "AverageHitTimeValue";

	private UTextBlock LongestHitDistValue;

	private const string LONGESTHITDISTVALUE_NAME = "LongestHitDistValue";

	private UTextBlock LogValue;

	private const string LOGVALUE_NAME = "LogValue";

	private UImage ZBBImage;

	private const string ZBBIMAGE_NAME = "ZBBImage";

	private UComboBoxString SkillIDList;

	private const string SKILLIDLIST_NAME = "SkillIDList";

	private UTextBlock EffectIDTextBlock;

	private const string EFFECTIDTEXTBLOCK_NAME = "EffectID";

	private UComboBoxString EffectIDList;

	private const string EFFECTIDLIST_NAME = "EffectIDList";

	private UButton SearchBtn;

	private const string SEARCHBTN_NAME = "SearchBtn";

	private UComboBoxString SectorSelector;

	private const string SECTORSELECTOR_NAME = "SectorSelector";

	private UEditableTextBox DrawDistValue_Left;

	private const string DRAWDISTVALUELEFT_NAME = "DrawDistValue_Left";

	private UEditableTextBox DrawDistValue_Right;

	private const string DRAWDISTVALUERIGHT_NAME = "DrawDistValue_Right";

	private UButton DrawDistBtn;

	private const string DRAWDISTBTN_NAME = "DrawDistBtn";

	private UImage DistCircle_In;

	private const string DISTCIRCLE_IN_NAME = "DistCircle_In";

	private UImage DistCircle_Out;

	private const string DISTCIRCLE_OUT_NAME = "DistCircle_Out";

	private int MapSize;

	private float MapRealRadius_Left;

	private float MapRealRadius_Right;

	private int CurSectorNum;

	private List<UnitZBBInfo> ZBBInfos;

	private Dictionary<int, List<UnitZBBInfo>> ZBBSectorSaver;

	private Dictionary<string, int> ZBBSectorMap;

	private int x;

	private static bool ShowZBBInfo_IsValid;

	private static IntPtr ShowZBBInfo_FunctionAddress;

	private static int ShowZBBInfo_ParamsSize;

	private static bool GenerateReport_IsValid;

	private static IntPtr GenerateReport_FunctionAddress;

	private static int GenerateReport_ParamsSize;

	private static bool GenerateReport_SelectedItem_IsValid;

	private static int GenerateReport_SelectedItem_Offset;

	private static FFieldAddress GenerateReport_SelectedItem_PropertyAddress;

	private static bool GenerateReport_SelectionType_IsValid;

	private static int GenerateReport_SelectionType_Offset;

	private static FFieldAddress GenerateReport_SelectionType_PropertyAddress;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		SkillIDList = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SkillIDList")) as UComboBoxString;
		SkillIDList.OnSelectionChanged.Bind(OnSkillIDListSelectionChanged);
		EffectIDTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("EffectID")) as UTextBlock;
		EffectIDTextBlock.SetVisibility(ESlateVisibility.Hidden);
		EffectIDList = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("EffectIDList")) as UComboBoxString;
		EffectIDList.OnSelectionChanged.Bind(OnEffectIDListSelectionChanged);
		EffectIDList.SetVisibility(ESlateVisibility.Hidden);
		SearchBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SearchBtn")) as UButton;
		if (SearchBtn != null)
		{
			SearchBtn.OnClicked.Bind(ShowZBBInfo);
		}
		SearchBtn.SetVisibility(ESlateVisibility.Hidden);
		SkillIDValue = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SkillIDValue")) as UTextBlock;
		EffectiveHitValue = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("EffectiveHitValue")) as UTextBlock;
		AllHitValue = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("AllHitValue")) as UTextBlock;
		HitRateValue = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("HitRateValue")) as UTextBlock;
		AverageHitTimeValue = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("AverageHitTimeValue")) as UTextBlock;
		LongestHitDistValue = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("LongestHitDistValue")) as UTextBlock;
		LogValue = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("LogValue")) as UTextBlock;
		if (SkillIDValue == null || HitRateValue == null || AverageHitTimeValue == null || LongestHitDistValue == null || LogValue == null)
		{
			return;
		}
		SectorSelector = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SectorSelector")) as UComboBoxString;
		if (SectorSelector == null)
		{
			return;
		}
		SectorSelector.OnSelectionChanged.Bind(GenerateReport);
		ZBBImage = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ZBBImage")) as UImage;
		if (!(ZBBImage == null))
		{
			ZBBImage.SetVisibility(ESlateVisibility.Hidden);
			DistCircle_Out = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DistCircle_Out")) as UImage;
			DistCircle_In = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DistCircle_In")) as UImage;
			DrawDistValue_Left = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DrawDistValue_Left")) as UEditableTextBox;
			DrawDistValue_Right = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DrawDistValue_Right")) as UEditableTextBox;
			DrawDistBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DrawDistBtn")) as UButton;
			if (DrawDistValue_Left != null && DrawDistValue_Right != null && DrawDistBtn != null)
			{
				DrawDistBtn.OnClicked.Bind(RefreshReport);
			}
			ZBBSectorSaver = new Dictionary<int, List<UnitZBBInfo>>();
			InitZBBSectorMap();
			SearchSkillIDList();
		}
	}

	private void ReSetZBBTexture()
	{
		UTexture2D uTexture2D = GenerateTexture();
		if (uTexture2D != null)
		{
			ZBBImage.SetBrushResourceObject(uTexture2D);
			ZBBImage.SetVisibility(ESlateVisibility.Visible);
		}
		else
		{
			ZBBImage.SetVisibility(ESlateVisibility.Hidden);
		}
	}

	private void OnSkillIDListSelectionChanged(string Whatever, ESelectInfo Whocares)
	{
		CleanReport();
		ReadDataFromXml();
		ReSetZBBTexture();
	}

	private void OnEffectIDListSelectionChanged(string Whatever, ESelectInfo Whocares)
	{
		ReSetZBBTexture();
		RefreshReport();
	}

	private void SearchSkillIDList()
	{
		string path = USystemLibrary.GetProjectDirectory().Replace("/", "\\") + "ZBBConfigs\\";
		if (!Directory.Exists(path) && UGSE_EngineFuncLib.IsEditor())
		{
			Directory.CreateDirectory(path);
		}
		string[] files = Directory.GetFiles(path, "*.xml");
		for (int i = 0; i < files.Length; i++)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[i]);
			SkillIDList.AddOption(fileNameWithoutExtension);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ZBBPanel:ShowZBBInfo")]
	private void ShowZBBInfo()
	{
		CleanReport();
		ReadDataFromXml();
		ReSetZBBTexture();
	}

	private void CleanReport()
	{
		if (ZBBSectorSaver == null)
		{
			ZBBSectorSaver = new Dictionary<int, List<UnitZBBInfo>>();
		}
		else
		{
			ZBBSectorSaver.Clear();
		}
		EffectiveHitValue.SetText(FText.FromString(""));
		AllHitValue.SetText(FText.FromString(""));
		HitRateValue.SetText(FText.FromString(""));
		AverageHitTimeValue.SetText(FText.FromString(""));
		LongestHitDistValue.SetText(FText.FromString(""));
		LogValue.SetText(FText.FromString(""));
	}

	private void InitZBBSectorMap()
	{
		ZBBSectorMap = new Dictionary<string, int>();
		ZBBSectorMap.Add("0~45", 0);
		ZBBSectorMap.Add("45~90", 1);
		ZBBSectorMap.Add("90~135", 2);
		ZBBSectorMap.Add("135~180", 3);
		ZBBSectorMap.Add("-135~-180", 4);
		ZBBSectorMap.Add("-90~-135", 5);
		ZBBSectorMap.Add("-45~-90", 6);
		ZBBSectorMap.Add("0~-45", 7);
	}

	private void ReadDataFromXml()
	{
		string selectedOption = SkillIDList.GetSelectedOption();
		string path = FPaths.ProjectDir + "\\ZBBConfigs\\" + selectedOption + ".xml";
		if (!UBGUFunctionLibrary.BGUIsExistFile(path))
		{
			LogValue.SetText(FText.FromString("Error:未找到该技能对应的本地测试文件"));
			if (ZBBInfos != null)
			{
				ZBBInfos.Clear();
			}
			return;
		}
		SkillIDValue.SetText(FText.FromString(selectedOption));
		OneZBBConfig oneZBBConfig = default(OneZBBConfig);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(OneZBBConfig));
		StreamReader streamReader = new StreamReader(path);
		oneZBBConfig = (OneZBBConfig)xmlSerializer.Deserialize(streamReader);
		streamReader.Close();
		ZBBInfos = oneZBBConfig.AllZBBInfos;
		MapSize = oneZBBConfig.MapSize;
		MapRealRadius_Left = oneZBBConfig.MapRealRadius_Left;
		MapRealRadius_Right = oneZBBConfig.MapRealRadius_Right;
		DrawDistValue_Left.SetText(FText.FromString(MapRealRadius_Left.ToString()));
		DrawDistValue_Right.SetText(FText.FromString(MapRealRadius_Right.ToString()));
		SortedSet<string> sortedSet = new SortedSet<string>();
		foreach (UnitZBBInfo zBBInfo in ZBBInfos)
		{
			foreach (string item in zBBInfo.NotifyBeginTime)
			{
				sortedSet.Add(item);
			}
		}
		EffectIDList.ClearOptions();
		EffectIDList.AddOption("All");
		foreach (string item2 in sortedSet)
		{
			EffectIDList.AddOption(item2);
		}
		EffectIDList.SetSelectedOption("All");
		EffectIDList.SetVisibility(ESlateVisibility.Visible);
		EffectIDTextBlock.SetVisibility(ESlateVisibility.Visible);
	}

	public UTexture2D GenerateTexture()
	{
		if (ZBBInfos == null)
		{
			return null;
		}
		if (ZBBInfos.Count == 0)
		{
			return null;
		}
		if ((int)FMath.Sqrt(ZBBInfos.Count) < 2)
		{
			return null;
		}
		FColor[] array = new FColor[MapSize * MapSize];
		foreach (UnitZBBInfo zBBInfo in ZBBInfos)
		{
			FVector position = zBBInfo.Position;
			int num = FMath.RoundToInt(position.X + (float)(MapSize / 2));
			position = zBBInfo.Position;
			int num2 = FMath.RoundToInt(position.Y + (float)(MapSize / 2));
			int num3 = MapSize - num2 + num * MapSize;
			num3 = array.Length - 1 - num3;
			FColor fColor = default(FColor);
			if (!zBBInfo.NeedTest)
			{
				fColor = new FColor(byte.MaxValue, 0, 0);
			}
			if (zBBInfo.NeedTest && zBBInfo.Effective && (EffectIDList.GetSelectedOption() == "All" || zBBInfo.NotifyBeginTime.Contains(EffectIDList.GetSelectedOption())))
			{
				fColor = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue);
			}
			array[num3] = fColor;
		}
		UTexture2D uTexture2D = BGU_TextureUtil.CreateTexture2D(MapSize, MapSize, "ZBB" + x);
		x++;
		BGU_TextureUtil.WriteToTexture_GameThread(uTexture2D, array);
		return uTexture2D;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ZBBPanel:GenerateReport")]
	public void GenerateReport(string SelectedItem, ESelectInfo SelectionType)
	{
		RefreshReport();
	}

	private void RefreshReport()
	{
		string selectedOption = SectorSelector.GetSelectedOption();
		if (!ZBBSectorMap.ContainsKey(selectedOption) || ZBBInfos == null)
		{
			return;
		}
		CleanReport();
		ZBBSectorSaver.Clear();
		ZBBSectorSaver = BGUSkillPreviewHelper.ZBBSectorCollector(ZBBInfos);
		if (ZBBSectorSaver == null || DistCircle_Out == null || DistCircle_In == null)
		{
			return;
		}
		if (float.TryParse(DrawDistValue_Left.GetText(), out var result))
		{
			result = ((result < MapRealRadius_Left) ? MapRealRadius_Left : result);
			float num = result / MapRealRadius_Right;
			DistCircle_In.SetRenderScale(new FVector2D(num, num));
		}
		else
		{
			DrawDistValue_Left.SetText(FText.FromString("Value Error"));
		}
		if (float.TryParse(DrawDistValue_Right.GetText(), out var result2))
		{
			result2 = ((result2 > MapRealRadius_Right) ? MapRealRadius_Right : result2);
			float num2 = result2 / MapRealRadius_Right;
			DistCircle_Out.SetRenderScale(new FVector2D(num2, num2));
		}
		else
		{
			DrawDistValue_Right.SetText(FText.FromString("Value Error"));
		}
		DrawDistValue_Left.SetText(FText.FromString(result.ToString()));
		DrawDistValue_Right.SetText(FText.FromString(result2.ToString()));
		int key = (CurSectorNum = ZBBSectorMap[selectedOption]);
		int num3 = 0;
		float num4 = 0f;
		int num5 = 0;
		float num6 = 0f;
		if (!ZBBSectorSaver.ContainsKey(key))
		{
			LogValue.SetText(FText.FromString("该区域没有记录到技能释放信息"));
			return;
		}
		foreach (UnitZBBInfo item in ZBBSectorSaver[key])
		{
			if (!(item.Distance >= result) || !(item.Distance <= result2))
			{
				continue;
			}
			num3++;
			if (item.Effective && (EffectIDList.GetSelectedOption() == "All" || item.NotifyBeginTime.Contains(EffectIDList.GetSelectedOption())))
			{
				if (item.Distance > num4)
				{
					num4 = item.Distance;
				}
				num5++;
				num6 += item.HitTimer;
			}
		}
		EffectiveHitValue.SetText(FText.FromString(num5.ToString()));
		AllHitValue.SetText(FText.FromString(num3.ToString()));
		float num7 = ((num5 == 0) ? 0f : ((float)num5 / (float)num3));
		float num8 = ((num5 == 0) ? 0f : (num6 / (float)num5));
		HitRateValue.SetText(FText.FromString(num7.ToString("0.00")));
		AverageHitTimeValue.SetText(FText.FromString(num8.ToString("0.00")));
		LongestHitDistValue.SetText(FText.FromString(num4.ToString("0.00")));
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ZBBPanel:ShowZBBInfo")]
	private static void ShowZBBInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_ZBBPanel bUI_ZBBPanel = GCHelper.Find<b1.UI.BUI_ZBBPanel>(obj);
		bUI_ZBBPanel.ShowZBBInfo();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ZBBPanel:GenerateReport")]
	private static void GenerateReport__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_ZBBPanel bUI_ZBBPanel = GCHelper.Find<b1.UI.BUI_ZBBPanel>(obj);
		string selectedItem = FStringMarshaler.FromNative(IntPtr.Add(buffer, GenerateReport_SelectedItem_Offset));
		ESelectInfo selectionType = EnumMarshaler<ESelectInfo>.FromNative(IntPtr.Add(buffer, GenerateReport_SelectionType_Offset), 0, GenerateReport_SelectionType_PropertyAddress.Address);
		bUI_ZBBPanel.GenerateReport(selectedItem, selectionType);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_ZBBPanel");
		ShowZBBInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ShowZBBInfo");
		ShowZBBInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowZBBInfo_FunctionAddress);
		ShowZBBInfo_IsValid = ShowZBBInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ZBBPanel:ShowZBBInfo", ShowZBBInfo_IsValid);
		GenerateReport_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateReport");
		GenerateReport_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateReport_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GenerateReport_SelectedItem_PropertyAddress, GenerateReport_FunctionAddress, "SelectedItem");
		GenerateReport_SelectedItem_Offset = NativeReflection.GetPropertyOffset(GenerateReport_FunctionAddress, "SelectedItem");
		GenerateReport_SelectedItem_IsValid = NativeReflection.ValidatePropertyClass(GenerateReport_FunctionAddress, "SelectedItem", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GenerateReport_SelectionType_PropertyAddress, GenerateReport_FunctionAddress, "SelectionType");
		GenerateReport_SelectionType_Offset = NativeReflection.GetPropertyOffset(GenerateReport_FunctionAddress, "SelectionType");
		GenerateReport_SelectionType_IsValid = NativeReflection.ValidatePropertyClass(GenerateReport_FunctionAddress, "SelectionType", Classes.FEnumProperty);
		GenerateReport_IsValid = GenerateReport_FunctionAddress != IntPtr.Zero && GenerateReport_SelectedItem_IsValid && GenerateReport_SelectionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ZBBPanel:GenerateReport", GenerateReport_IsValid);
	}

	static BUI_ZBBPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_ZBBPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_ZBBPanel));
	}
}
