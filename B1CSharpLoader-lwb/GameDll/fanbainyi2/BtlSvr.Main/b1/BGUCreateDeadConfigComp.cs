using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using b1.BGU.BUAnim;
using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.BGUCreateDeadConfigComp")]
internal class BGUCreateDeadConfigComp : UBaseActorComp
{
	private static bool SmallSizeUDDConfig_IsValid;

	private static int SmallSizeUDDConfig_Offset;

	private static bool MediumSizeUDDConfig_IsValid;

	private static int MediumSizeUDDConfig_Offset;

	private static bool MediumBigSizeUDDConfig_IsValid;

	private static int MediumBigSizeUDDConfig_Offset;

	private static bool BigSizeUDDConfig_IsValid;

	private static int BigSizeUDDConfig_Offset;

	private static bool HugeSizeUDDConfig_IsValid;

	private static int HugeSizeUDDConfig_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUCreateDeadConfigComp:SmallSizeUDDConfig")]
	public BGWDataAsset_UnitDeathDispConfig SmallSizeUDDConfig
	{
		get
		{
			CheckDestroyed();
			if (!SmallSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:SmallSizeUDDConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.FromNative(IntPtr.Add(base.Address, SmallSizeUDDConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmallSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:SmallSizeUDDConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.ToNative(IntPtr.Add(base.Address, SmallSizeUDDConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUCreateDeadConfigComp:MediumSizeUDDConfig")]
	public BGWDataAsset_UnitDeathDispConfig MediumSizeUDDConfig
	{
		get
		{
			CheckDestroyed();
			if (!MediumSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:MediumSizeUDDConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.FromNative(IntPtr.Add(base.Address, MediumSizeUDDConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediumSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:MediumSizeUDDConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.ToNative(IntPtr.Add(base.Address, MediumSizeUDDConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUCreateDeadConfigComp:MediumBigSizeUDDConfig")]
	public BGWDataAsset_UnitDeathDispConfig MediumBigSizeUDDConfig
	{
		get
		{
			CheckDestroyed();
			if (!MediumBigSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:MediumBigSizeUDDConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.FromNative(IntPtr.Add(base.Address, MediumBigSizeUDDConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediumBigSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:MediumBigSizeUDDConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.ToNative(IntPtr.Add(base.Address, MediumBigSizeUDDConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUCreateDeadConfigComp:BigSizeUDDConfig")]
	public BGWDataAsset_UnitDeathDispConfig BigSizeUDDConfig
	{
		get
		{
			CheckDestroyed();
			if (!BigSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:BigSizeUDDConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.FromNative(IntPtr.Add(base.Address, BigSizeUDDConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BigSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:BigSizeUDDConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.ToNative(IntPtr.Add(base.Address, BigSizeUDDConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUCreateDeadConfigComp:HugeSizeUDDConfig")]
	public BGWDataAsset_UnitDeathDispConfig HugeSizeUDDConfig
	{
		get
		{
			CheckDestroyed();
			if (!HugeSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:HugeSizeUDDConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.FromNative(IntPtr.Add(base.Address, HugeSizeUDDConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HugeSizeUDDConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCreateDeadConfigComp:HugeSizeUDDConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.ToNative(IntPtr.Add(base.Address, HugeSizeUDDConfig_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUCreateDeadConfigComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
	}

	[USharpPath("/Script/b1-Managed.BGUCreateDeadConfigComp:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		BeginCreateOP();
	}

	private void BeginCreateOP()
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			return;
		}
		SmallSizeUDDConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_UnitDeathDispConfig>("BGWDataAsset_UnitDeathDispConfig'/Game/00Main/Design/Units/DataAssetTemplates/UDDConfigTemplates/SmallSizeUDDConfig.SmallSizeUDDConfig'", ELoadResourceType.SyncLoadAndCache);
		MediumSizeUDDConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_UnitDeathDispConfig>("BGWDataAsset_UnitDeathDispConfig'/Game/00Main/Design/Units/DataAssetTemplates/UDDConfigTemplates/MediumSizeUDDConfig.MediumSizeUDDConfig'", ELoadResourceType.SyncLoadAndCache);
		MediumBigSizeUDDConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_UnitDeathDispConfig>("BGWDataAsset_UnitDeathDispConfig'/Game/00Main/Design/Units/DataAssetTemplates/UDDConfigTemplates/MediumBigSizeUDDConfig.MediumBigSizeUDDConfig'", ELoadResourceType.SyncLoadAndCache);
		BigSizeUDDConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_UnitDeathDispConfig>("BGWDataAsset_UnitDeathDispConfig'/Game/00Main/Design/Units/DataAssetTemplates/UDDConfigTemplates/BigSizeUDDConfig.BigSizeUDDConfig'", ELoadResourceType.SyncLoadAndCache);
		HugeSizeUDDConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_UnitDeathDispConfig>("BGWDataAsset_UnitDeathDispConfig'/Game/00Main/Design/Units/DataAssetTemplates/UDDConfigTemplates/HugeSizeUDDConfig.HugeSizeUDDConfig'", ELoadResourceType.SyncLoadAndCache);
		if (SmallSizeUDDConfig == null || MediumSizeUDDConfig == null || MediumBigSizeUDDConfig == null || BigSizeUDDConfig == null || HugeSizeUDDConfig == null)
		{
			return;
		}
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		List<int> list = new List<int>();
		foreach (BGUCharacterCS allActorsOfClass in UGameplayStatics.GetAllActorsOfClassList<BGUCharacterCS>(this))
		{
			IBUC_ConfigInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>(allActorsOfClass);
			if (readOnlyData == null)
			{
				continue;
			}
			int resID = readOnlyData.ResID;
			if (!list.Contains(resID))
			{
				list.Add(resID);
				if (CreateAndSaveDeathDispConfig(allActorsOfClass, out var ConfigPath))
				{
					dictionary.Add(resID, ConfigPath);
				}
			}
		}
		WriteCSV(dictionary);
	}

	private void CopyInfoFromDefaultDataAsset(ref BGWDataAsset_UnitDeathDispConfig Dest, EUnitBodyType UnitBodyType)
	{
		BGWDataAsset_UnitDeathDispConfig bGWDataAsset_UnitDeathDispConfig = null;
		switch (UnitBodyType)
		{
		case EUnitBodyType.Small:
			bGWDataAsset_UnitDeathDispConfig = SmallSizeUDDConfig;
			break;
		case EUnitBodyType.Medium:
			bGWDataAsset_UnitDeathDispConfig = MediumSizeUDDConfig;
			break;
		case EUnitBodyType.MediumBig:
			bGWDataAsset_UnitDeathDispConfig = MediumBigSizeUDDConfig;
			break;
		case EUnitBodyType.Big:
			bGWDataAsset_UnitDeathDispConfig = BigSizeUDDConfig;
			break;
		case EUnitBodyType.Huge:
			bGWDataAsset_UnitDeathDispConfig = HugeSizeUDDConfig;
			break;
		}
		if (!(bGWDataAsset_UnitDeathDispConfig != null) || !(Dest != null))
		{
			return;
		}
		Dest.NormalDeadAMInfoList.Clear();
		foreach (FNormalDeadAMInfo normalDeadAMInfo in bGWDataAsset_UnitDeathDispConfig.NormalDeadAMInfoList)
		{
			Dest.NormalDeadAMInfoList.Add(normalDeadAMInfo);
		}
	}

	private void WriteCSV(Dictionary<int, string> ID2ConfigPathDic)
	{
		string path = "D:\\deadinfo.csv";
		if (!File.Exists(path))
		{
			File.Delete(path);
		}
		FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
		StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("ID").Append(",").Append("路径");
		streamWriter.WriteLine(stringBuilder);
		stringBuilder.Clear();
		foreach (KeyValuePair<int, string> item in ID2ConfigPathDic)
		{
			stringBuilder.Append(item.Key).Append(",").Append("BGWDataAsset_UnitDeathDispConfig'" + item.Value + "'");
			streamWriter.WriteLine(stringBuilder);
			stringBuilder.Clear();
		}
		streamWriter.Flush();
		streamWriter.Close();
		fileStream.Close();
	}

	private string GetDeadInfoIDStr(int DeadInfoID)
	{
		int num = DeadInfoID % 100;
		if (num < 10)
		{
			return $"0{num.ToString()}";
		}
		return num.ToString();
	}

	private bool CreateAndSaveDeathDispConfig(BGUCharacterCS Character, out string ConfigPath)
	{
		ConfigPath = "";
		if (Character == null || Character.Mesh == null)
		{
			return false;
		}
		BUAnimHumanoidCS bUAnimHumanoidCS = Character.Mesh.GetAnimInstance() as BUAnimHumanoidCS;
		if (bUAnimHumanoidCS == null)
		{
			return false;
		}
		int actorResID = BGU_DataUtil.GetActorResID(Character);
		if (actorResID == 10)
		{
			return false;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(actorResID);
		if (unitCommDesc == null)
		{
			return false;
		}
		if (unitCommDesc.UnitBodyType == EUnitBodyType.None)
		{
			return false;
		}
		string pathName = bUAnimHumanoidCS.GetClass().GetOutermost().GetPathName();
		string text = pathName.Substring(pathName.LastIndexOf('/') + 1);
		string text2 = text.Substring(text.IndexOf('_') + 1);
		string path = pathName.Substring(0, pathName.LastIndexOf('/') + 1);
		bool flag = true;
		string name = "UDDConfig_" + text2 + "_dep01";
		UClass uClass = UClass.GetClass<BGWDataAsset_UnitDeathDispConfig>();
		BGWDataAsset_UnitDeathDispConfig Dest = UGSE_EngineFuncLib.CreateAsset(path, name, uClass) as BGWDataAsset_UnitDeathDispConfig;
		string text3 = text2.Split('_')[0];
		Dest.NormalDeadAMPath = "/Game/00Main/Animation/" + text3 + "/" + text2 + "/Montage/dead";
		Dest.UnitResName = text2;
		CopyInfoFromDefaultDataAsset(ref Dest, unitCommDesc.UnitBodyType);
		List<UPackage> packagesToSave = new List<UPackage> { Dest.GetOutermost() };
		flag &= UGSFuncLibForEditor.CheckoutAndSavePackage(packagesToSave, bCheckDirty: false, bPromptToSave: false, out var _);
		ConfigPath = Dest.GetPathName();
		return flag;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCreateDeadConfigComp:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUCreateDeadConfigComp bGUCreateDeadConfigComp = GCHelper.Find<b1.BGUCreateDeadConfigComp>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUCreateDeadConfigComp.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUCreateDeadConfigComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUCreateDeadConfigComp bGUCreateDeadConfigComp = GCHelper.Find<b1.BGUCreateDeadConfigComp>(obj);
		bGUCreateDeadConfigComp.BeginPlayInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUCreateDeadConfigComp");
		SmallSizeUDDConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmallSizeUDDConfig");
		SmallSizeUDDConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmallSizeUDDConfig", Classes.FObjectProperty);
		MediumSizeUDDConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "MediumSizeUDDConfig");
		MediumSizeUDDConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MediumSizeUDDConfig", Classes.FObjectProperty);
		MediumBigSizeUDDConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "MediumBigSizeUDDConfig");
		MediumBigSizeUDDConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MediumBigSizeUDDConfig", Classes.FObjectProperty);
		BigSizeUDDConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BigSizeUDDConfig");
		BigSizeUDDConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BigSizeUDDConfig", Classes.FObjectProperty);
		HugeSizeUDDConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "HugeSizeUDDConfig");
		HugeSizeUDDConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HugeSizeUDDConfig", Classes.FObjectProperty);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCreateDeadConfigComp:ReceiveTick", ReceiveTick_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUCreateDeadConfigComp:BeginPlayInCS", BeginPlayInCS_IsValid);
	}

	static BGUCreateDeadConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUCreateDeadConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUCreateDeadConfigComp));
	}
}
