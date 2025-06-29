using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821039264uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget", "UnrealExtent", UnrealModuleType.Game)]
public class UStatInfoBaseWidget : UUserWidget
{
	private static bool StatGroupThresholdConfig_IsValid;

	private static int StatGroupThresholdConfig_Offset;

	private static bool FetchStatInfoInterval_IsValid;

	private static int FetchStatInfoInterval_Offset;

	private static bool SimulatedGraphicsCard_IsValid;

	private static FFieldAddress SimulatedGraphicsCard_PropertyAddress;

	private static int SimulatedGraphicsCard_Offset;

	private static bool SelfGraphicsCard_IsValid;

	private static FFieldAddress SelfGraphicsCard_PropertyAddress;

	private static int SelfGraphicsCard_Offset;

	private static bool EnableRecordPerformanceData_IsValid;

	private static FFieldAddress EnableRecordPerformanceData_PropertyAddress;

	private static int EnableRecordPerformanceData_Offset;

	private static bool RecordFileName_IsValid;

	private static int RecordFileName_Offset;

	private static bool StartRecord_IsValid;

	private static IntPtr StartRecord_FunctionAddress;

	private static int StartRecord_ParamsSize;

	private static bool StartRecord_FXConfig_IsValid;

	private static FFieldAddress StartRecord_FXConfig_PropertyAddress;

	private static int StartRecord_FXConfig_Offset;

	private static bool StartRecord_UnitName_IsValid;

	private static FFieldAddress StartRecord_UnitName_PropertyAddress;

	private static int StartRecord_UnitName_Offset;

	private static bool StartRecord_SkillName_IsValid;

	private static FFieldAddress StartRecord_SkillName_PropertyAddress;

	private static int StartRecord_SkillName_Offset;

	private static bool StartRecord_AssetPath_IsValid;

	private static FFieldAddress StartRecord_AssetPath_PropertyAddress;

	private static int StartRecord_AssetPath_Offset;

	private static bool StartRecord_MontageLength_IsValid;

	private static FFieldAddress StartRecord_MontageLength_PropertyAddress;

	private static int StartRecord_MontageLength_Offset;

	private static bool SaveRecordsToFiles_IsValid;

	private static IntPtr SaveRecordsToFiles_FunctionAddress;

	private static int SaveRecordsToFiles_ParamsSize;

	private static bool SaveRecordsToFiles_NeedCleanup_IsValid;

	private static FFieldAddress SaveRecordsToFiles_NeedCleanup_PropertyAddress;

	private static int SaveRecordsToFiles_NeedCleanup_Offset;

	private static bool GetSimulatedGraphicsCardScaleFactor_IsValid;

	private static IntPtr GetSimulatedGraphicsCardScaleFactor_FunctionAddress;

	private static int GetSimulatedGraphicsCardScaleFactor_ParamsSize;

	private static bool GetSimulatedGraphicsCardScaleFactor_InStatName_IsValid;

	private static FFieldAddress GetSimulatedGraphicsCardScaleFactor_InStatName_PropertyAddress;

	private static int GetSimulatedGraphicsCardScaleFactor_InStatName_Offset;

	private static bool GetSimulatedGraphicsCardScaleFactor_ReturnValue_IsValid;

	private static FFieldAddress GetSimulatedGraphicsCardScaleFactor_ReturnValue_PropertyAddress;

	private static int GetSimulatedGraphicsCardScaleFactor_ReturnValue_Offset;

	private static bool GetGPUBrand_IsValid;

	private static IntPtr GetGPUBrand_FunctionAddress;

	private static int GetGPUBrand_ParamsSize;

	private static bool GetGPUBrand_ReturnValue_IsValid;

	private static FFieldAddress GetGPUBrand_ReturnValue_PropertyAddress;

	private static int GetGPUBrand_ReturnValue_Offset;

	private static bool EndRecord_IsValid;

	private static IntPtr EndRecord_FunctionAddress;

	private static int EndRecord_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:StatGroupThresholdConfig")]
	public UStatGroupInfoThresholdConfig StatGroupThresholdConfig
	{
		get
		{
			CheckDestroyed();
			if (!StatGroupThresholdConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:StatGroupThresholdConfig");
				return null;
			}
			return UObjectMarshaler<UStatGroupInfoThresholdConfig>.FromNative(IntPtr.Add(base.Address, StatGroupThresholdConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StatGroupThresholdConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:StatGroupThresholdConfig");
			}
			else
			{
				UObjectMarshaler<UStatGroupInfoThresholdConfig>.ToNative(IntPtr.Add(base.Address, StatGroupThresholdConfig_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:FetchStatInfoInterval")]
	public float FetchStatInfoInterval
	{
		get
		{
			CheckDestroyed();
			if (!FetchStatInfoInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:FetchStatInfoInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FetchStatInfoInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FetchStatInfoInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:FetchStatInfoInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FetchStatInfoInterval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:SimulatedGraphicsCard")]
	public EStatUISimulatedGraphicsCard SimulatedGraphicsCard
	{
		get
		{
			CheckDestroyed();
			if (!SimulatedGraphicsCard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:SimulatedGraphicsCard");
				return EStatUISimulatedGraphicsCard.GTX_1050Ti;
			}
			return EnumMarshaler<EStatUISimulatedGraphicsCard>.FromNative(IntPtr.Add(base.Address, SimulatedGraphicsCard_Offset), 0, SimulatedGraphicsCard_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimulatedGraphicsCard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:SimulatedGraphicsCard");
			}
			else
			{
				EnumMarshaler<EStatUISimulatedGraphicsCard>.ToNative(IntPtr.Add(base.Address, SimulatedGraphicsCard_Offset), 0, SimulatedGraphicsCard_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:SelfGraphicsCard")]
	public EStatUISimulatedGraphicsCard SelfGraphicsCard
	{
		get
		{
			CheckDestroyed();
			if (!SelfGraphicsCard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:SelfGraphicsCard");
				return EStatUISimulatedGraphicsCard.GTX_1050Ti;
			}
			return EnumMarshaler<EStatUISimulatedGraphicsCard>.FromNative(IntPtr.Add(base.Address, SelfGraphicsCard_Offset), 0, SelfGraphicsCard_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SelfGraphicsCard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:SelfGraphicsCard");
			}
			else
			{
				EnumMarshaler<EStatUISimulatedGraphicsCard>.ToNative(IntPtr.Add(base.Address, SelfGraphicsCard_Offset), 0, SelfGraphicsCard_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:bEnableRecordPerformanceData")]
	public bool EnableRecordPerformanceData
	{
		get
		{
			CheckDestroyed();
			if (!EnableRecordPerformanceData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:bEnableRecordPerformanceData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRecordPerformanceData_Offset), 0, EnableRecordPerformanceData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRecordPerformanceData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:bEnableRecordPerformanceData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRecordPerformanceData_Offset), 0, EnableRecordPerformanceData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:RecordFileName")]
	public string RecordFileName
	{
		get
		{
			CheckDestroyed();
			if (!RecordFileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:RecordFileName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, RecordFileName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RecordFileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatInfoBaseWidget:RecordFileName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, RecordFileName_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:StartRecord")]
	public unsafe void StartRecord(string FXConfig, string UnitName, string SkillName, string AssetPath, float MontageLength = 0f)
	{
		CheckDestroyed();
		if (!StartRecord_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.StatInfoBaseWidget:StartRecord");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartRecord_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartRecord_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartRecord_FXConfig_Offset), 0, StartRecord_FXConfig_PropertyAddress.Address, FXConfig);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartRecord_UnitName_Offset), 0, StartRecord_UnitName_PropertyAddress.Address, UnitName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartRecord_SkillName_Offset), 0, StartRecord_SkillName_PropertyAddress.Address, SkillName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartRecord_AssetPath_Offset), 0, StartRecord_AssetPath_PropertyAddress.Address, AssetPath);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartRecord_MontageLength_Offset), 0, StartRecord_MontageLength_PropertyAddress.Address, MontageLength);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartRecord_FunctionAddress, intPtr, StartRecord_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartRecord_FXConfig_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartRecord_UnitName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartRecord_SkillName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartRecord_AssetPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:SaveRecordsToFiles")]
	public unsafe void SaveRecordsToFiles(int NeedCleanup)
	{
		CheckDestroyed();
		if (!SaveRecordsToFiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.StatInfoBaseWidget:SaveRecordsToFiles");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveRecordsToFiles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveRecordsToFiles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SaveRecordsToFiles_NeedCleanup_Offset), 0, SaveRecordsToFiles_NeedCleanup_PropertyAddress.Address, NeedCleanup);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveRecordsToFiles_FunctionAddress, intPtr, SaveRecordsToFiles_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:GetSimulatedGraphicsCardScaleFactor")]
	public unsafe float GetSimulatedGraphicsCardScaleFactor(string InStatName)
	{
		CheckDestroyed();
		if (!GetSimulatedGraphicsCardScaleFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.StatInfoBaseWidget:GetSimulatedGraphicsCardScaleFactor");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSimulatedGraphicsCardScaleFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSimulatedGraphicsCardScaleFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSimulatedGraphicsCardScaleFactor_InStatName_Offset), 0, GetSimulatedGraphicsCardScaleFactor_InStatName_PropertyAddress.Address, InStatName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSimulatedGraphicsCardScaleFactor_FunctionAddress, intPtr, GetSimulatedGraphicsCardScaleFactor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSimulatedGraphicsCardScaleFactor_InStatName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSimulatedGraphicsCardScaleFactor_ReturnValue_Offset), 0, GetSimulatedGraphicsCardScaleFactor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:GetGPUBrand")]
	public unsafe string GetGPUBrand()
	{
		CheckDestroyed();
		if (!GetGPUBrand_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.StatInfoBaseWidget:GetGPUBrand");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGPUBrand_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGPUBrand_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGPUBrand_FunctionAddress, intPtr, GetGPUBrand_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGPUBrand_ReturnValue_Offset), 0, GetGPUBrand_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGPUBrand_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.StatInfoBaseWidget:EndRecord")]
	public unsafe void EndRecord()
	{
		CheckDestroyed();
		if (!EndRecord_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.StatInfoBaseWidget:EndRecord");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndRecord_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndRecord_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndRecord_FunctionAddress, argsSize: EndRecord_ParamsSize);
	}

	static UStatInfoBaseWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStatInfoBaseWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStatInfoBaseWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.StatInfoBaseWidget");
		StatGroupThresholdConfig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatGroupThresholdConfig");
		StatGroupThresholdConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatGroupThresholdConfig", Classes.FObjectProperty);
		FetchStatInfoInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FetchStatInfoInterval");
		FetchStatInfoInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FetchStatInfoInterval", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SimulatedGraphicsCard_PropertyAddress, intPtr, "SimulatedGraphicsCard");
		SimulatedGraphicsCard_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimulatedGraphicsCard");
		SimulatedGraphicsCard_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimulatedGraphicsCard", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SelfGraphicsCard_PropertyAddress, intPtr, "SelfGraphicsCard");
		SelfGraphicsCard_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelfGraphicsCard");
		SelfGraphicsCard_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelfGraphicsCard", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRecordPerformanceData_PropertyAddress, intPtr, "bEnableRecordPerformanceData");
		EnableRecordPerformanceData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableRecordPerformanceData");
		EnableRecordPerformanceData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableRecordPerformanceData", Classes.FBoolProperty);
		RecordFileName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RecordFileName");
		RecordFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RecordFileName", Classes.FStrProperty);
		StartRecord_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartRecord");
		StartRecord_ParamsSize = NativeReflection.GetFunctionParamsSize(StartRecord_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartRecord_FXConfig_PropertyAddress, StartRecord_FunctionAddress, "FXConfig");
		StartRecord_FXConfig_Offset = NativeReflectionCached.GetPropertyOffset(StartRecord_FunctionAddress, "FXConfig");
		StartRecord_FXConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecord_FunctionAddress, "FXConfig", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecord_UnitName_PropertyAddress, StartRecord_FunctionAddress, "UnitName");
		StartRecord_UnitName_Offset = NativeReflectionCached.GetPropertyOffset(StartRecord_FunctionAddress, "UnitName");
		StartRecord_UnitName_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecord_FunctionAddress, "UnitName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecord_SkillName_PropertyAddress, StartRecord_FunctionAddress, "SkillName");
		StartRecord_SkillName_Offset = NativeReflectionCached.GetPropertyOffset(StartRecord_FunctionAddress, "SkillName");
		StartRecord_SkillName_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecord_FunctionAddress, "SkillName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecord_AssetPath_PropertyAddress, StartRecord_FunctionAddress, "AssetPath");
		StartRecord_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(StartRecord_FunctionAddress, "AssetPath");
		StartRecord_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecord_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecord_MontageLength_PropertyAddress, StartRecord_FunctionAddress, "MontageLength");
		StartRecord_MontageLength_Offset = NativeReflectionCached.GetPropertyOffset(StartRecord_FunctionAddress, "MontageLength");
		StartRecord_MontageLength_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecord_FunctionAddress, "MontageLength", Classes.FFloatProperty);
		StartRecord_IsValid = StartRecord_FunctionAddress != IntPtr.Zero && StartRecord_FXConfig_IsValid && StartRecord_UnitName_IsValid && StartRecord_SkillName_IsValid && StartRecord_AssetPath_IsValid && StartRecord_MontageLength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.StatInfoBaseWidget:StartRecord", StartRecord_IsValid);
		SaveRecordsToFiles_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SaveRecordsToFiles");
		SaveRecordsToFiles_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveRecordsToFiles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveRecordsToFiles_NeedCleanup_PropertyAddress, SaveRecordsToFiles_FunctionAddress, "NeedCleanup");
		SaveRecordsToFiles_NeedCleanup_Offset = NativeReflectionCached.GetPropertyOffset(SaveRecordsToFiles_FunctionAddress, "NeedCleanup");
		SaveRecordsToFiles_NeedCleanup_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveRecordsToFiles_FunctionAddress, "NeedCleanup", Classes.FIntProperty);
		SaveRecordsToFiles_IsValid = SaveRecordsToFiles_FunctionAddress != IntPtr.Zero && SaveRecordsToFiles_NeedCleanup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.StatInfoBaseWidget:SaveRecordsToFiles", SaveRecordsToFiles_IsValid);
		GetSimulatedGraphicsCardScaleFactor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSimulatedGraphicsCardScaleFactor");
		GetSimulatedGraphicsCardScaleFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSimulatedGraphicsCardScaleFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSimulatedGraphicsCardScaleFactor_InStatName_PropertyAddress, GetSimulatedGraphicsCardScaleFactor_FunctionAddress, "InStatName");
		GetSimulatedGraphicsCardScaleFactor_InStatName_Offset = NativeReflectionCached.GetPropertyOffset(GetSimulatedGraphicsCardScaleFactor_FunctionAddress, "InStatName");
		GetSimulatedGraphicsCardScaleFactor_InStatName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSimulatedGraphicsCardScaleFactor_FunctionAddress, "InStatName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSimulatedGraphicsCardScaleFactor_ReturnValue_PropertyAddress, GetSimulatedGraphicsCardScaleFactor_FunctionAddress, "ReturnValue");
		GetSimulatedGraphicsCardScaleFactor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSimulatedGraphicsCardScaleFactor_FunctionAddress, "ReturnValue");
		GetSimulatedGraphicsCardScaleFactor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSimulatedGraphicsCardScaleFactor_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSimulatedGraphicsCardScaleFactor_IsValid = GetSimulatedGraphicsCardScaleFactor_FunctionAddress != IntPtr.Zero && GetSimulatedGraphicsCardScaleFactor_InStatName_IsValid && GetSimulatedGraphicsCardScaleFactor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.StatInfoBaseWidget:GetSimulatedGraphicsCardScaleFactor", GetSimulatedGraphicsCardScaleFactor_IsValid);
		GetGPUBrand_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGPUBrand");
		GetGPUBrand_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGPUBrand_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGPUBrand_ReturnValue_PropertyAddress, GetGPUBrand_FunctionAddress, "ReturnValue");
		GetGPUBrand_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGPUBrand_FunctionAddress, "ReturnValue");
		GetGPUBrand_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGPUBrand_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGPUBrand_IsValid = GetGPUBrand_FunctionAddress != IntPtr.Zero && GetGPUBrand_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.StatInfoBaseWidget:GetGPUBrand", GetGPUBrand_IsValid);
		EndRecord_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndRecord");
		EndRecord_ParamsSize = NativeReflection.GetFunctionParamsSize(EndRecord_FunctionAddress);
		EndRecord_IsValid = EndRecord_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.StatInfoBaseWidget:EndRecord", EndRecord_IsValid);
	}
}
