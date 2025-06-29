using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary", "FunctionalTesting", UnrealModuleType.Engine)]
public class UAutomationLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TakeHighResScreenshot_IsValid;

	private static IntPtr TakeHighResScreenshot_FunctionAddress;

	private static int TakeHighResScreenshot_ParamsSize;

	private static bool TakeHighResScreenshot_ResX_IsValid;

	private static FFieldAddress TakeHighResScreenshot_ResX_PropertyAddress;

	private static int TakeHighResScreenshot_ResX_Offset;

	private static bool TakeHighResScreenshot_ResY_IsValid;

	private static FFieldAddress TakeHighResScreenshot_ResY_PropertyAddress;

	private static int TakeHighResScreenshot_ResY_Offset;

	private static bool TakeHighResScreenshot_Filename_IsValid;

	private static FFieldAddress TakeHighResScreenshot_Filename_PropertyAddress;

	private static int TakeHighResScreenshot_Filename_Offset;

	private static bool TakeHighResScreenshot_Camera_IsValid;

	private static FFieldAddress TakeHighResScreenshot_Camera_PropertyAddress;

	private static int TakeHighResScreenshot_Camera_Offset;

	private static bool TakeHighResScreenshot_bMaskEnabled_IsValid;

	private static FFieldAddress TakeHighResScreenshot_bMaskEnabled_PropertyAddress;

	private static int TakeHighResScreenshot_bMaskEnabled_Offset;

	private static bool TakeHighResScreenshot_bCaptureHDR_IsValid;

	private static FFieldAddress TakeHighResScreenshot_bCaptureHDR_PropertyAddress;

	private static int TakeHighResScreenshot_bCaptureHDR_Offset;

	private static bool TakeHighResScreenshot_ComparisonTolerance_IsValid;

	private static FFieldAddress TakeHighResScreenshot_ComparisonTolerance_PropertyAddress;

	private static int TakeHighResScreenshot_ComparisonTolerance_Offset;

	private static bool TakeHighResScreenshot_ComparisonNotes_IsValid;

	private static FFieldAddress TakeHighResScreenshot_ComparisonNotes_PropertyAddress;

	private static int TakeHighResScreenshot_ComparisonNotes_Offset;

	private static bool TakeHighResScreenshot_Delay_IsValid;

	private static FFieldAddress TakeHighResScreenshot_Delay_PropertyAddress;

	private static int TakeHighResScreenshot_Delay_Offset;

	private static bool TakeHighResScreenshot_ReturnValue_IsValid;

	private static FFieldAddress TakeHighResScreenshot_ReturnValue_PropertyAddress;

	private static int TakeHighResScreenshot_ReturnValue_Offset;

	private static bool TakeAutomationScreenshotOfUI_IsValid;

	private static IntPtr TakeAutomationScreenshotOfUI_FunctionAddress;

	private static int TakeAutomationScreenshotOfUI_ParamsSize;

	private static bool TakeAutomationScreenshotOfUI_WorldContextObject_IsValid;

	private static FFieldAddress TakeAutomationScreenshotOfUI_WorldContextObject_PropertyAddress;

	private static int TakeAutomationScreenshotOfUI_WorldContextObject_Offset;

	private static bool TakeAutomationScreenshotOfUI_LatentInfo_IsValid;

	private static FFieldAddress TakeAutomationScreenshotOfUI_LatentInfo_PropertyAddress;

	private static int TakeAutomationScreenshotOfUI_LatentInfo_Offset;

	private static bool TakeAutomationScreenshotOfUI_Name_IsValid;

	private static FFieldAddress TakeAutomationScreenshotOfUI_Name_PropertyAddress;

	private static int TakeAutomationScreenshotOfUI_Name_Offset;

	private static bool TakeAutomationScreenshotOfUI_Options_IsValid;

	private static FFieldAddress TakeAutomationScreenshotOfUI_Options_PropertyAddress;

	private static int TakeAutomationScreenshotOfUI_Options_Offset;

	private static bool TakeAutomationScreenshotAtCamera_IsValid;

	private static IntPtr TakeAutomationScreenshotAtCamera_FunctionAddress;

	private static int TakeAutomationScreenshotAtCamera_ParamsSize;

	private static bool TakeAutomationScreenshotAtCamera_WorldContextObject_IsValid;

	private static FFieldAddress TakeAutomationScreenshotAtCamera_WorldContextObject_PropertyAddress;

	private static int TakeAutomationScreenshotAtCamera_WorldContextObject_Offset;

	private static bool TakeAutomationScreenshotAtCamera_LatentInfo_IsValid;

	private static FFieldAddress TakeAutomationScreenshotAtCamera_LatentInfo_PropertyAddress;

	private static int TakeAutomationScreenshotAtCamera_LatentInfo_Offset;

	private static bool TakeAutomationScreenshotAtCamera_Camera_IsValid;

	private static FFieldAddress TakeAutomationScreenshotAtCamera_Camera_PropertyAddress;

	private static int TakeAutomationScreenshotAtCamera_Camera_Offset;

	private static bool TakeAutomationScreenshotAtCamera_NameOverride_IsValid;

	private static FFieldAddress TakeAutomationScreenshotAtCamera_NameOverride_PropertyAddress;

	private static int TakeAutomationScreenshotAtCamera_NameOverride_Offset;

	private static bool TakeAutomationScreenshotAtCamera_Notes_IsValid;

	private static FFieldAddress TakeAutomationScreenshotAtCamera_Notes_PropertyAddress;

	private static int TakeAutomationScreenshotAtCamera_Notes_Offset;

	private static bool TakeAutomationScreenshotAtCamera_Options_IsValid;

	private static FFieldAddress TakeAutomationScreenshotAtCamera_Options_PropertyAddress;

	private static int TakeAutomationScreenshotAtCamera_Options_Offset;

	private static bool TakeAutomationScreenshot_IsValid;

	private static IntPtr TakeAutomationScreenshot_FunctionAddress;

	private static int TakeAutomationScreenshot_ParamsSize;

	private static bool TakeAutomationScreenshot_WorldContextObject_IsValid;

	private static FFieldAddress TakeAutomationScreenshot_WorldContextObject_PropertyAddress;

	private static int TakeAutomationScreenshot_WorldContextObject_Offset;

	private static bool TakeAutomationScreenshot_LatentInfo_IsValid;

	private static FFieldAddress TakeAutomationScreenshot_LatentInfo_PropertyAddress;

	private static int TakeAutomationScreenshot_LatentInfo_Offset;

	private static bool TakeAutomationScreenshot_Name_IsValid;

	private static FFieldAddress TakeAutomationScreenshot_Name_PropertyAddress;

	private static int TakeAutomationScreenshot_Name_Offset;

	private static bool TakeAutomationScreenshot_Notes_IsValid;

	private static FFieldAddress TakeAutomationScreenshot_Notes_PropertyAddress;

	private static int TakeAutomationScreenshot_Notes_Offset;

	private static bool TakeAutomationScreenshot_Options_IsValid;

	private static FFieldAddress TakeAutomationScreenshot_Options_PropertyAddress;

	private static int TakeAutomationScreenshot_Options_Offset;

	private static bool SetTestTelemetryStorage_IsValid;

	private static IntPtr SetTestTelemetryStorage_FunctionAddress;

	private static int SetTestTelemetryStorage_ParamsSize;

	private static bool SetTestTelemetryStorage_StorageName_IsValid;

	private static FFieldAddress SetTestTelemetryStorage_StorageName_PropertyAddress;

	private static int SetTestTelemetryStorage_StorageName_Offset;

	private static bool SetScalabilityQualityToLow_IsValid;

	private static IntPtr SetScalabilityQualityToLow_FunctionAddress;

	private static int SetScalabilityQualityToLow_ParamsSize;

	private static bool SetScalabilityQualityToLow_WorldContextObject_IsValid;

	private static FFieldAddress SetScalabilityQualityToLow_WorldContextObject_PropertyAddress;

	private static int SetScalabilityQualityToLow_WorldContextObject_Offset;

	private static bool SetScalabilityQualityToEpic_IsValid;

	private static IntPtr SetScalabilityQualityToEpic_FunctionAddress;

	private static int SetScalabilityQualityToEpic_ParamsSize;

	private static bool SetScalabilityQualityToEpic_WorldContextObject_IsValid;

	private static FFieldAddress SetScalabilityQualityToEpic_WorldContextObject_PropertyAddress;

	private static int SetScalabilityQualityToEpic_WorldContextObject_Offset;

	private static bool SetScalabilityQualityLevelRelativeToMax_IsValid;

	private static IntPtr SetScalabilityQualityLevelRelativeToMax_FunctionAddress;

	private static int SetScalabilityQualityLevelRelativeToMax_ParamsSize;

	private static bool SetScalabilityQualityLevelRelativeToMax_WorldContextObject_IsValid;

	private static FFieldAddress SetScalabilityQualityLevelRelativeToMax_WorldContextObject_PropertyAddress;

	private static int SetScalabilityQualityLevelRelativeToMax_WorldContextObject_Offset;

	private static bool SetScalabilityQualityLevelRelativeToMax_Value_IsValid;

	private static FFieldAddress SetScalabilityQualityLevelRelativeToMax_Value_PropertyAddress;

	private static int SetScalabilityQualityLevelRelativeToMax_Value_Offset;

	private static bool GetStatIncMax_IsValid;

	private static IntPtr GetStatIncMax_FunctionAddress;

	private static int GetStatIncMax_ParamsSize;

	private static bool GetStatIncMax_StatName_IsValid;

	private static FFieldAddress GetStatIncMax_StatName_PropertyAddress;

	private static int GetStatIncMax_StatName_Offset;

	private static bool GetStatIncMax_ReturnValue_IsValid;

	private static FFieldAddress GetStatIncMax_ReturnValue_PropertyAddress;

	private static int GetStatIncMax_ReturnValue_Offset;

	private static bool GetStatIncAverage_IsValid;

	private static IntPtr GetStatIncAverage_FunctionAddress;

	private static int GetStatIncAverage_ParamsSize;

	private static bool GetStatIncAverage_StatName_IsValid;

	private static FFieldAddress GetStatIncAverage_StatName_PropertyAddress;

	private static int GetStatIncAverage_StatName_Offset;

	private static bool GetStatIncAverage_ReturnValue_IsValid;

	private static FFieldAddress GetStatIncAverage_ReturnValue_PropertyAddress;

	private static int GetStatIncAverage_ReturnValue_Offset;

	private static bool GetStatExcMax_IsValid;

	private static IntPtr GetStatExcMax_FunctionAddress;

	private static int GetStatExcMax_ParamsSize;

	private static bool GetStatExcMax_StatName_IsValid;

	private static FFieldAddress GetStatExcMax_StatName_PropertyAddress;

	private static int GetStatExcMax_StatName_Offset;

	private static bool GetStatExcMax_ReturnValue_IsValid;

	private static FFieldAddress GetStatExcMax_ReturnValue_PropertyAddress;

	private static int GetStatExcMax_ReturnValue_Offset;

	private static bool GetStatExcAverage_IsValid;

	private static IntPtr GetStatExcAverage_FunctionAddress;

	private static int GetStatExcAverage_ParamsSize;

	private static bool GetStatExcAverage_StatName_IsValid;

	private static FFieldAddress GetStatExcAverage_StatName_PropertyAddress;

	private static int GetStatExcAverage_StatName_Offset;

	private static bool GetStatExcAverage_ReturnValue_IsValid;

	private static FFieldAddress GetStatExcAverage_ReturnValue_PropertyAddress;

	private static int GetStatExcAverage_ReturnValue_Offset;

	private static bool GetStatCallCount_IsValid;

	private static IntPtr GetStatCallCount_FunctionAddress;

	private static int GetStatCallCount_ParamsSize;

	private static bool GetStatCallCount_StatName_IsValid;

	private static FFieldAddress GetStatCallCount_StatName_PropertyAddress;

	private static int GetStatCallCount_StatName_Offset;

	private static bool GetStatCallCount_ReturnValue_IsValid;

	private static FFieldAddress GetStatCallCount_ReturnValue_PropertyAddress;

	private static int GetStatCallCount_ReturnValue_Offset;

	private static bool GetDefaultScreenshotOptionsForRendering_IsValid;

	private static IntPtr GetDefaultScreenshotOptionsForRendering_FunctionAddress;

	private static int GetDefaultScreenshotOptionsForRendering_ParamsSize;

	private static bool GetDefaultScreenshotOptionsForRendering_Tolerance_IsValid;

	private static FFieldAddress GetDefaultScreenshotOptionsForRendering_Tolerance_PropertyAddress;

	private static int GetDefaultScreenshotOptionsForRendering_Tolerance_Offset;

	private static bool GetDefaultScreenshotOptionsForRendering_Delay_IsValid;

	private static FFieldAddress GetDefaultScreenshotOptionsForRendering_Delay_PropertyAddress;

	private static int GetDefaultScreenshotOptionsForRendering_Delay_Offset;

	private static bool GetDefaultScreenshotOptionsForRendering_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultScreenshotOptionsForRendering_ReturnValue_PropertyAddress;

	private static int GetDefaultScreenshotOptionsForRendering_ReturnValue_Offset;

	private static bool GetDefaultScreenshotOptionsForGameplay_IsValid;

	private static IntPtr GetDefaultScreenshotOptionsForGameplay_FunctionAddress;

	private static int GetDefaultScreenshotOptionsForGameplay_ParamsSize;

	private static bool GetDefaultScreenshotOptionsForGameplay_Tolerance_IsValid;

	private static FFieldAddress GetDefaultScreenshotOptionsForGameplay_Tolerance_PropertyAddress;

	private static int GetDefaultScreenshotOptionsForGameplay_Tolerance_Offset;

	private static bool GetDefaultScreenshotOptionsForGameplay_Delay_IsValid;

	private static FFieldAddress GetDefaultScreenshotOptionsForGameplay_Delay_PropertyAddress;

	private static int GetDefaultScreenshotOptionsForGameplay_Delay_Offset;

	private static bool GetDefaultScreenshotOptionsForGameplay_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultScreenshotOptionsForGameplay_ReturnValue_PropertyAddress;

	private static int GetDefaultScreenshotOptionsForGameplay_ReturnValue_Offset;

	private static bool FinishLoadingBeforeScreenshot_IsValid;

	private static IntPtr FinishLoadingBeforeScreenshot_FunctionAddress;

	private static int FinishLoadingBeforeScreenshot_ParamsSize;

	private static bool EnableStatGroup_IsValid;

	private static IntPtr EnableStatGroup_FunctionAddress;

	private static int EnableStatGroup_ParamsSize;

	private static bool EnableStatGroup_WorldContextObject_IsValid;

	private static FFieldAddress EnableStatGroup_WorldContextObject_PropertyAddress;

	private static int EnableStatGroup_WorldContextObject_Offset;

	private static bool EnableStatGroup_GroupName_IsValid;

	private static FFieldAddress EnableStatGroup_GroupName_PropertyAddress;

	private static int EnableStatGroup_GroupName_Offset;

	private static bool DisableStatGroup_IsValid;

	private static IntPtr DisableStatGroup_FunctionAddress;

	private static int DisableStatGroup_ParamsSize;

	private static bool DisableStatGroup_WorldContextObject_IsValid;

	private static FFieldAddress DisableStatGroup_WorldContextObject_PropertyAddress;

	private static int DisableStatGroup_WorldContextObject_Offset;

	private static bool DisableStatGroup_GroupName_IsValid;

	private static FFieldAddress DisableStatGroup_GroupName_PropertyAddress;

	private static int DisableStatGroup_GroupName_Offset;

	private static bool CompareImageAgainstReference_IsValid;

	private static IntPtr CompareImageAgainstReference_FunctionAddress;

	private static int CompareImageAgainstReference_ParamsSize;

	private static bool CompareImageAgainstReference_ImageFilePath_IsValid;

	private static FFieldAddress CompareImageAgainstReference_ImageFilePath_PropertyAddress;

	private static int CompareImageAgainstReference_ImageFilePath_Offset;

	private static bool CompareImageAgainstReference_ComparisonName_IsValid;

	private static FFieldAddress CompareImageAgainstReference_ComparisonName_PropertyAddress;

	private static int CompareImageAgainstReference_ComparisonName_Offset;

	private static bool CompareImageAgainstReference_ComparisonTolerance_IsValid;

	private static FFieldAddress CompareImageAgainstReference_ComparisonTolerance_PropertyAddress;

	private static int CompareImageAgainstReference_ComparisonTolerance_Offset;

	private static bool CompareImageAgainstReference_ComparisonNotes_IsValid;

	private static FFieldAddress CompareImageAgainstReference_ComparisonNotes_PropertyAddress;

	private static int CompareImageAgainstReference_ComparisonNotes_Offset;

	private static bool CompareImageAgainstReference_WorldContextObject_IsValid;

	private static FFieldAddress CompareImageAgainstReference_WorldContextObject_PropertyAddress;

	private static int CompareImageAgainstReference_WorldContextObject_Offset;

	private static bool CompareImageAgainstReference_ReturnValue_IsValid;

	private static FFieldAddress CompareImageAgainstReference_ReturnValue_PropertyAddress;

	private static int CompareImageAgainstReference_ReturnValue_Offset;

	private static bool AutomationWaitForLoading_IsValid;

	private static IntPtr AutomationWaitForLoading_FunctionAddress;

	private static int AutomationWaitForLoading_ParamsSize;

	private static bool AutomationWaitForLoading_WorldContextObject_IsValid;

	private static FFieldAddress AutomationWaitForLoading_WorldContextObject_PropertyAddress;

	private static int AutomationWaitForLoading_WorldContextObject_Offset;

	private static bool AutomationWaitForLoading_LatentInfo_IsValid;

	private static FFieldAddress AutomationWaitForLoading_LatentInfo_PropertyAddress;

	private static int AutomationWaitForLoading_LatentInfo_Offset;

	private static bool AutomationWaitForLoading_Options_IsValid;

	private static FFieldAddress AutomationWaitForLoading_Options_PropertyAddress;

	private static int AutomationWaitForLoading_Options_Offset;

	private static bool AreAutomatedTestsRunning_IsValid;

	private static IntPtr AreAutomatedTestsRunning_FunctionAddress;

	private static int AreAutomatedTestsRunning_ParamsSize;

	private static bool AreAutomatedTestsRunning_ReturnValue_IsValid;

	private static FFieldAddress AreAutomatedTestsRunning_ReturnValue_PropertyAddress;

	private static int AreAutomatedTestsRunning_ReturnValue_Offset;

	private static bool AddTestTelemetryData_IsValid;

	private static IntPtr AddTestTelemetryData_FunctionAddress;

	private static int AddTestTelemetryData_ParamsSize;

	private static bool AddTestTelemetryData_DataPoint_IsValid;

	private static FFieldAddress AddTestTelemetryData_DataPoint_PropertyAddress;

	private static int AddTestTelemetryData_DataPoint_Offset;

	private static bool AddTestTelemetryData_Measurement_IsValid;

	private static FFieldAddress AddTestTelemetryData_Measurement_PropertyAddress;

	private static int AddTestTelemetryData_Measurement_Offset;

	private static bool AddTestTelemetryData_Context_IsValid;

	private static FFieldAddress AddTestTelemetryData_Context_PropertyAddress;

	private static int AddTestTelemetryData_Context_Offset;

	private static bool AddExpectedLogError_IsValid;

	private static IntPtr AddExpectedLogError_FunctionAddress;

	private static int AddExpectedLogError_ParamsSize;

	private static bool AddExpectedLogError_ExpectedPatternString_IsValid;

	private static FFieldAddress AddExpectedLogError_ExpectedPatternString_PropertyAddress;

	private static int AddExpectedLogError_ExpectedPatternString_Offset;

	private static bool AddExpectedLogError_Occurrences_IsValid;

	private static FFieldAddress AddExpectedLogError_Occurrences_PropertyAddress;

	private static int AddExpectedLogError_Occurrences_Offset;

	private static bool AddExpectedLogError_ExactMatch_IsValid;

	private static FFieldAddress AddExpectedLogError_ExactMatch_PropertyAddress;

	private static int AddExpectedLogError_ExactMatch_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeHighResScreenshot")]
	public unsafe static UAutomationEditorTask TakeHighResScreenshot(int ResX, int ResY, string Filename, ACameraActor Camera, bool bMaskEnabled, bool bCaptureHDR, EComparisonTolerance ComparisonTolerance, string ComparisonNotes, float Delay)
	{
		if (!TakeHighResScreenshot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeHighResScreenshot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TakeHighResScreenshot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeHighResScreenshot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_ResX_Offset), 0, TakeHighResScreenshot_ResX_PropertyAddress.Address, ResX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_ResY_Offset), 0, TakeHighResScreenshot_ResY_PropertyAddress.Address, ResY);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_Filename_Offset), 0, TakeHighResScreenshot_Filename_PropertyAddress.Address, Filename);
		UObjectMarshaler<ACameraActor>.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_Camera_Offset), 0, TakeHighResScreenshot_Camera_PropertyAddress.Address, Camera);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_bMaskEnabled_Offset), 0, TakeHighResScreenshot_bMaskEnabled_PropertyAddress.Address, bMaskEnabled);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_bCaptureHDR_Offset), 0, TakeHighResScreenshot_bCaptureHDR_PropertyAddress.Address, bCaptureHDR);
		EnumMarshaler<EComparisonTolerance>.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_ComparisonTolerance_Offset), 0, TakeHighResScreenshot_ComparisonTolerance_PropertyAddress.Address, ComparisonTolerance);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_ComparisonNotes_Offset), 0, TakeHighResScreenshot_ComparisonNotes_PropertyAddress.Address, ComparisonNotes);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TakeHighResScreenshot_Delay_Offset), 0, TakeHighResScreenshot_Delay_PropertyAddress.Address, Delay);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TakeHighResScreenshot_FunctionAddress, intPtr, TakeHighResScreenshot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TakeHighResScreenshot_Filename_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TakeHighResScreenshot_ComparisonNotes_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAutomationEditorTask>.FromNative(IntPtr.Add(intPtr, TakeHighResScreenshot_ReturnValue_Offset), 0, TakeHighResScreenshot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshotOfUI")]
	public unsafe static void TakeAutomationScreenshotOfUI(UObject WorldContextObject, FLatentActionInfo LatentInfo, string Name, FAutomationScreenshotOptions Options)
	{
		if (!TakeAutomationScreenshotOfUI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshotOfUI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TakeAutomationScreenshotOfUI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeAutomationScreenshotOfUI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotOfUI_WorldContextObject_Offset), 0, TakeAutomationScreenshotOfUI_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(TakeAutomationScreenshotOfUI_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotOfUI_LatentInfo_Offset), 0, TakeAutomationScreenshotOfUI_LatentInfo_PropertyAddress.Address, LatentInfo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotOfUI_Name_Offset), 0, TakeAutomationScreenshotOfUI_Name_PropertyAddress.Address, Name);
		NativeReflection.InitializeValue_InContainer(TakeAutomationScreenshotOfUI_Options_PropertyAddress.Address, intPtr);
		FAutomationScreenshotOptions.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotOfUI_Options_Offset), 0, TakeAutomationScreenshotOfUI_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TakeAutomationScreenshotOfUI_FunctionAddress, intPtr, TakeAutomationScreenshotOfUI_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TakeAutomationScreenshotOfUI_Name_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshotAtCamera")]
	public unsafe static void TakeAutomationScreenshotAtCamera(UObject WorldContextObject, FLatentActionInfo LatentInfo, ACameraActor Camera, string NameOverride, string Notes, FAutomationScreenshotOptions Options)
	{
		if (!TakeAutomationScreenshotAtCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshotAtCamera");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TakeAutomationScreenshotAtCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeAutomationScreenshotAtCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotAtCamera_WorldContextObject_Offset), 0, TakeAutomationScreenshotAtCamera_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(TakeAutomationScreenshotAtCamera_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotAtCamera_LatentInfo_Offset), 0, TakeAutomationScreenshotAtCamera_LatentInfo_PropertyAddress.Address, LatentInfo);
		UObjectMarshaler<ACameraActor>.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotAtCamera_Camera_Offset), 0, TakeAutomationScreenshotAtCamera_Camera_PropertyAddress.Address, Camera);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotAtCamera_NameOverride_Offset), 0, TakeAutomationScreenshotAtCamera_NameOverride_PropertyAddress.Address, NameOverride);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotAtCamera_Notes_Offset), 0, TakeAutomationScreenshotAtCamera_Notes_PropertyAddress.Address, Notes);
		NativeReflection.InitializeValue_InContainer(TakeAutomationScreenshotAtCamera_Options_PropertyAddress.Address, intPtr);
		FAutomationScreenshotOptions.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshotAtCamera_Options_Offset), 0, TakeAutomationScreenshotAtCamera_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TakeAutomationScreenshotAtCamera_FunctionAddress, intPtr, TakeAutomationScreenshotAtCamera_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TakeAutomationScreenshotAtCamera_NameOverride_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TakeAutomationScreenshotAtCamera_Notes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshot")]
	public unsafe static void TakeAutomationScreenshot(UObject WorldContextObject, FLatentActionInfo LatentInfo, string Name, string Notes, FAutomationScreenshotOptions Options)
	{
		if (!TakeAutomationScreenshot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TakeAutomationScreenshot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeAutomationScreenshot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshot_WorldContextObject_Offset), 0, TakeAutomationScreenshot_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(TakeAutomationScreenshot_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshot_LatentInfo_Offset), 0, TakeAutomationScreenshot_LatentInfo_PropertyAddress.Address, LatentInfo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshot_Name_Offset), 0, TakeAutomationScreenshot_Name_PropertyAddress.Address, Name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshot_Notes_Offset), 0, TakeAutomationScreenshot_Notes_PropertyAddress.Address, Notes);
		NativeReflection.InitializeValue_InContainer(TakeAutomationScreenshot_Options_PropertyAddress.Address, intPtr);
		FAutomationScreenshotOptions.ToNative(IntPtr.Add(intPtr, TakeAutomationScreenshot_Options_Offset), 0, TakeAutomationScreenshot_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TakeAutomationScreenshot_FunctionAddress, intPtr, TakeAutomationScreenshot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TakeAutomationScreenshot_Name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TakeAutomationScreenshot_Notes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetTestTelemetryStorage")]
	public unsafe static void SetTestTelemetryStorage(string StorageName)
	{
		if (!SetTestTelemetryStorage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetTestTelemetryStorage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTestTelemetryStorage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTestTelemetryStorage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetTestTelemetryStorage_StorageName_Offset), 0, SetTestTelemetryStorage_StorageName_PropertyAddress.Address, StorageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTestTelemetryStorage_FunctionAddress, intPtr, SetTestTelemetryStorage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTestTelemetryStorage_StorageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityToLow")]
	public unsafe static void SetScalabilityQualityToLow(UObject WorldContextObject)
	{
		if (!SetScalabilityQualityToLow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityToLow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalabilityQualityToLow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalabilityQualityToLow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetScalabilityQualityToLow_WorldContextObject_Offset), 0, SetScalabilityQualityToLow_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetScalabilityQualityToLow_FunctionAddress, intPtr, SetScalabilityQualityToLow_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityToEpic")]
	public unsafe static void SetScalabilityQualityToEpic(UObject WorldContextObject)
	{
		if (!SetScalabilityQualityToEpic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityToEpic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalabilityQualityToEpic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalabilityQualityToEpic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetScalabilityQualityToEpic_WorldContextObject_Offset), 0, SetScalabilityQualityToEpic_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetScalabilityQualityToEpic_FunctionAddress, intPtr, SetScalabilityQualityToEpic_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityLevelRelativeToMax")]
	public unsafe static void SetScalabilityQualityLevelRelativeToMax(UObject WorldContextObject, int Value = 1)
	{
		if (!SetScalabilityQualityLevelRelativeToMax_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityLevelRelativeToMax");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalabilityQualityLevelRelativeToMax_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalabilityQualityLevelRelativeToMax_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetScalabilityQualityLevelRelativeToMax_WorldContextObject_Offset), 0, SetScalabilityQualityLevelRelativeToMax_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetScalabilityQualityLevelRelativeToMax_Value_Offset), 0, SetScalabilityQualityLevelRelativeToMax_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetScalabilityQualityLevelRelativeToMax_FunctionAddress, intPtr, SetScalabilityQualityLevelRelativeToMax_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatIncMax")]
	public unsafe static float GetStatIncMax(FName StatName)
	{
		if (!GetStatIncMax_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatIncMax");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatIncMax_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatIncMax_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetStatIncMax_StatName_Offset), 0, GetStatIncMax_StatName_PropertyAddress.Address, StatName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStatIncMax_FunctionAddress, intPtr, GetStatIncMax_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatIncMax_ReturnValue_Offset), 0, GetStatIncMax_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatIncAverage")]
	public unsafe static float GetStatIncAverage(FName StatName)
	{
		if (!GetStatIncAverage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatIncAverage");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatIncAverage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatIncAverage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetStatIncAverage_StatName_Offset), 0, GetStatIncAverage_StatName_PropertyAddress.Address, StatName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStatIncAverage_FunctionAddress, intPtr, GetStatIncAverage_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatIncAverage_ReturnValue_Offset), 0, GetStatIncAverage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatExcMax")]
	public unsafe static float GetStatExcMax(FName StatName)
	{
		if (!GetStatExcMax_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatExcMax");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatExcMax_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatExcMax_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetStatExcMax_StatName_Offset), 0, GetStatExcMax_StatName_PropertyAddress.Address, StatName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStatExcMax_FunctionAddress, intPtr, GetStatExcMax_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatExcMax_ReturnValue_Offset), 0, GetStatExcMax_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatExcAverage")]
	public unsafe static float GetStatExcAverage(FName StatName)
	{
		if (!GetStatExcAverage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatExcAverage");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatExcAverage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatExcAverage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetStatExcAverage_StatName_Offset), 0, GetStatExcAverage_StatName_PropertyAddress.Address, StatName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStatExcAverage_FunctionAddress, intPtr, GetStatExcAverage_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatExcAverage_ReturnValue_Offset), 0, GetStatExcAverage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatCallCount")]
	public unsafe static float GetStatCallCount(FName StatName)
	{
		if (!GetStatCallCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatCallCount");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatCallCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatCallCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetStatCallCount_StatName_Offset), 0, GetStatCallCount_StatName_PropertyAddress.Address, StatName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStatCallCount_FunctionAddress, intPtr, GetStatCallCount_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatCallCount_ReturnValue_Offset), 0, GetStatCallCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetDefaultScreenshotOptionsForRendering")]
	public unsafe static FAutomationScreenshotOptions GetDefaultScreenshotOptionsForRendering(EComparisonTolerance Tolerance = EComparisonTolerance.Low, float Delay = 0.2f)
	{
		if (!GetDefaultScreenshotOptionsForRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetDefaultScreenshotOptionsForRendering");
			return default(FAutomationScreenshotOptions);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultScreenshotOptionsForRendering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultScreenshotOptionsForRendering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EComparisonTolerance>.ToNative(IntPtr.Add(intPtr, GetDefaultScreenshotOptionsForRendering_Tolerance_Offset), 0, GetDefaultScreenshotOptionsForRendering_Tolerance_PropertyAddress.Address, Tolerance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDefaultScreenshotOptionsForRendering_Delay_Offset), 0, GetDefaultScreenshotOptionsForRendering_Delay_PropertyAddress.Address, Delay);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultScreenshotOptionsForRendering_FunctionAddress, intPtr, GetDefaultScreenshotOptionsForRendering_ParamsSize);
		return FAutomationScreenshotOptions.FromNative(IntPtr.Add(intPtr, GetDefaultScreenshotOptionsForRendering_ReturnValue_Offset), 0, GetDefaultScreenshotOptionsForRendering_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetDefaultScreenshotOptionsForGameplay")]
	public unsafe static FAutomationScreenshotOptions GetDefaultScreenshotOptionsForGameplay(EComparisonTolerance Tolerance = EComparisonTolerance.Low, float Delay = 0.2f)
	{
		if (!GetDefaultScreenshotOptionsForGameplay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetDefaultScreenshotOptionsForGameplay");
			return default(FAutomationScreenshotOptions);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultScreenshotOptionsForGameplay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultScreenshotOptionsForGameplay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EComparisonTolerance>.ToNative(IntPtr.Add(intPtr, GetDefaultScreenshotOptionsForGameplay_Tolerance_Offset), 0, GetDefaultScreenshotOptionsForGameplay_Tolerance_PropertyAddress.Address, Tolerance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDefaultScreenshotOptionsForGameplay_Delay_Offset), 0, GetDefaultScreenshotOptionsForGameplay_Delay_PropertyAddress.Address, Delay);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultScreenshotOptionsForGameplay_FunctionAddress, intPtr, GetDefaultScreenshotOptionsForGameplay_ParamsSize);
		return FAutomationScreenshotOptions.FromNative(IntPtr.Add(intPtr, GetDefaultScreenshotOptionsForGameplay_ReturnValue_Offset), 0, GetDefaultScreenshotOptionsForGameplay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:FinishLoadingBeforeScreenshot")]
	public unsafe static void FinishLoadingBeforeScreenshot()
	{
		if (!FinishLoadingBeforeScreenshot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:FinishLoadingBeforeScreenshot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishLoadingBeforeScreenshot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishLoadingBeforeScreenshot_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: FinishLoadingBeforeScreenshot_FunctionAddress, argsSize: FinishLoadingBeforeScreenshot_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:EnableStatGroup")]
	public unsafe static void EnableStatGroup(UObject WorldContextObject, FName GroupName)
	{
		if (!EnableStatGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:EnableStatGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableStatGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableStatGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, EnableStatGroup_WorldContextObject_Offset), 0, EnableStatGroup_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EnableStatGroup_GroupName_Offset), 0, EnableStatGroup_GroupName_PropertyAddress.Address, GroupName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableStatGroup_FunctionAddress, intPtr, EnableStatGroup_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:DisableStatGroup")]
	public unsafe static void DisableStatGroup(UObject WorldContextObject, FName GroupName)
	{
		if (!DisableStatGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:DisableStatGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableStatGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableStatGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DisableStatGroup_WorldContextObject_Offset), 0, DisableStatGroup_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DisableStatGroup_GroupName_Offset), 0, DisableStatGroup_GroupName_PropertyAddress.Address, GroupName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DisableStatGroup_FunctionAddress, intPtr, DisableStatGroup_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:CompareImageAgainstReference")]
	public unsafe static bool CompareImageAgainstReference(string ImageFilePath, string ComparisonName, EComparisonTolerance ComparisonTolerance, string ComparisonNotes, UObject WorldContextObject)
	{
		if (!CompareImageAgainstReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:CompareImageAgainstReference");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompareImageAgainstReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompareImageAgainstReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CompareImageAgainstReference_ImageFilePath_Offset), 0, CompareImageAgainstReference_ImageFilePath_PropertyAddress.Address, ImageFilePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CompareImageAgainstReference_ComparisonName_Offset), 0, CompareImageAgainstReference_ComparisonName_PropertyAddress.Address, ComparisonName);
		EnumMarshaler<EComparisonTolerance>.ToNative(IntPtr.Add(intPtr, CompareImageAgainstReference_ComparisonTolerance_Offset), 0, CompareImageAgainstReference_ComparisonTolerance_PropertyAddress.Address, ComparisonTolerance);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CompareImageAgainstReference_ComparisonNotes_Offset), 0, CompareImageAgainstReference_ComparisonNotes_PropertyAddress.Address, ComparisonNotes);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CompareImageAgainstReference_WorldContextObject_Offset), 0, CompareImageAgainstReference_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompareImageAgainstReference_FunctionAddress, intPtr, CompareImageAgainstReference_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CompareImageAgainstReference_ImageFilePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CompareImageAgainstReference_ComparisonName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CompareImageAgainstReference_ComparisonNotes_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CompareImageAgainstReference_ReturnValue_Offset), 0, CompareImageAgainstReference_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AutomationWaitForLoading")]
	public unsafe static void AutomationWaitForLoading(UObject WorldContextObject, FLatentActionInfo LatentInfo, FAutomationWaitForLoadingOptions Options)
	{
		if (!AutomationWaitForLoading_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AutomationWaitForLoading");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AutomationWaitForLoading_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AutomationWaitForLoading_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AutomationWaitForLoading_WorldContextObject_Offset), 0, AutomationWaitForLoading_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(AutomationWaitForLoading_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, AutomationWaitForLoading_LatentInfo_Offset), 0, AutomationWaitForLoading_LatentInfo_PropertyAddress.Address, LatentInfo);
		NativeReflection.InitializeValue_InContainer(AutomationWaitForLoading_Options_PropertyAddress.Address, intPtr);
		FAutomationWaitForLoadingOptions.ToNative(IntPtr.Add(intPtr, AutomationWaitForLoading_Options_Offset), 0, AutomationWaitForLoading_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AutomationWaitForLoading_FunctionAddress, intPtr, AutomationWaitForLoading_ParamsSize);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AreAutomatedTestsRunning")]
	public unsafe static bool AreAutomatedTestsRunning()
	{
		if (!AreAutomatedTestsRunning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AreAutomatedTestsRunning");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AreAutomatedTestsRunning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AreAutomatedTestsRunning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AreAutomatedTestsRunning_FunctionAddress, intPtr, AreAutomatedTestsRunning_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AreAutomatedTestsRunning_ReturnValue_Offset), 0, AreAutomatedTestsRunning_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AddTestTelemetryData")]
	public unsafe static void AddTestTelemetryData(string DataPoint, float Measurement, string Context)
	{
		if (!AddTestTelemetryData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AddTestTelemetryData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTestTelemetryData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTestTelemetryData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddTestTelemetryData_DataPoint_Offset), 0, AddTestTelemetryData_DataPoint_PropertyAddress.Address, DataPoint);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddTestTelemetryData_Measurement_Offset), 0, AddTestTelemetryData_Measurement_PropertyAddress.Address, Measurement);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddTestTelemetryData_Context_Offset), 0, AddTestTelemetryData_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddTestTelemetryData_FunctionAddress, intPtr, AddTestTelemetryData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddTestTelemetryData_DataPoint_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddTestTelemetryData_Context_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AddExpectedLogError")]
	public unsafe static void AddExpectedLogError(string ExpectedPatternString, int Occurrences = 1, bool ExactMatch = false)
	{
		if (!AddExpectedLogError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AddExpectedLogError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddExpectedLogError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddExpectedLogError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddExpectedLogError_ExpectedPatternString_Offset), 0, AddExpectedLogError_ExpectedPatternString_PropertyAddress.Address, ExpectedPatternString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddExpectedLogError_Occurrences_Offset), 0, AddExpectedLogError_Occurrences_PropertyAddress.Address, Occurrences);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddExpectedLogError_ExactMatch_Offset), 0, AddExpectedLogError_ExactMatch_PropertyAddress.Address, ExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddExpectedLogError_FunctionAddress, intPtr, AddExpectedLogError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddExpectedLogError_ExpectedPatternString_PropertyAddress.Address, intPtr);
	}

	static UAutomationLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutomationLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutomationLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary");
		TakeHighResScreenshot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TakeHighResScreenshot");
		TakeHighResScreenshot_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeHighResScreenshot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_ResX_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "ResX");
		TakeHighResScreenshot_ResX_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "ResX");
		TakeHighResScreenshot_ResX_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "ResX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_ResY_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "ResY");
		TakeHighResScreenshot_ResY_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "ResY");
		TakeHighResScreenshot_ResY_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "ResY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_Filename_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "Filename");
		TakeHighResScreenshot_Filename_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "Filename");
		TakeHighResScreenshot_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_Camera_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "Camera");
		TakeHighResScreenshot_Camera_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "Camera");
		TakeHighResScreenshot_Camera_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "Camera", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_bMaskEnabled_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "bMaskEnabled");
		TakeHighResScreenshot_bMaskEnabled_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "bMaskEnabled");
		TakeHighResScreenshot_bMaskEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "bMaskEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_bCaptureHDR_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "bCaptureHDR");
		TakeHighResScreenshot_bCaptureHDR_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "bCaptureHDR");
		TakeHighResScreenshot_bCaptureHDR_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "bCaptureHDR", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_ComparisonTolerance_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "ComparisonTolerance");
		TakeHighResScreenshot_ComparisonTolerance_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "ComparisonTolerance");
		TakeHighResScreenshot_ComparisonTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "ComparisonTolerance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_ComparisonNotes_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "ComparisonNotes");
		TakeHighResScreenshot_ComparisonNotes_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "ComparisonNotes");
		TakeHighResScreenshot_ComparisonNotes_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "ComparisonNotes", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_Delay_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "Delay");
		TakeHighResScreenshot_Delay_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "Delay");
		TakeHighResScreenshot_Delay_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "Delay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeHighResScreenshot_ReturnValue_PropertyAddress, TakeHighResScreenshot_FunctionAddress, "ReturnValue");
		TakeHighResScreenshot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TakeHighResScreenshot_FunctionAddress, "ReturnValue");
		TakeHighResScreenshot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeHighResScreenshot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TakeHighResScreenshot_IsValid = TakeHighResScreenshot_FunctionAddress != IntPtr.Zero && TakeHighResScreenshot_ResX_IsValid && TakeHighResScreenshot_ResY_IsValid && TakeHighResScreenshot_Filename_IsValid && TakeHighResScreenshot_Camera_IsValid && TakeHighResScreenshot_bMaskEnabled_IsValid && TakeHighResScreenshot_bCaptureHDR_IsValid && TakeHighResScreenshot_ComparisonTolerance_IsValid && TakeHighResScreenshot_ComparisonNotes_IsValid && TakeHighResScreenshot_Delay_IsValid && TakeHighResScreenshot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeHighResScreenshot", TakeHighResScreenshot_IsValid);
		TakeAutomationScreenshotOfUI_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TakeAutomationScreenshotOfUI");
		TakeAutomationScreenshotOfUI_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeAutomationScreenshotOfUI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotOfUI_WorldContextObject_PropertyAddress, TakeAutomationScreenshotOfUI_FunctionAddress, "WorldContextObject");
		TakeAutomationScreenshotOfUI_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotOfUI_FunctionAddress, "WorldContextObject");
		TakeAutomationScreenshotOfUI_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotOfUI_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotOfUI_LatentInfo_PropertyAddress, TakeAutomationScreenshotOfUI_FunctionAddress, "LatentInfo");
		TakeAutomationScreenshotOfUI_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotOfUI_FunctionAddress, "LatentInfo");
		TakeAutomationScreenshotOfUI_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotOfUI_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotOfUI_Name_PropertyAddress, TakeAutomationScreenshotOfUI_FunctionAddress, "Name");
		TakeAutomationScreenshotOfUI_Name_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotOfUI_FunctionAddress, "Name");
		TakeAutomationScreenshotOfUI_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotOfUI_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotOfUI_Options_PropertyAddress, TakeAutomationScreenshotOfUI_FunctionAddress, "Options");
		TakeAutomationScreenshotOfUI_Options_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotOfUI_FunctionAddress, "Options");
		TakeAutomationScreenshotOfUI_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotOfUI_FunctionAddress, "Options", Classes.FStructProperty);
		TakeAutomationScreenshotOfUI_IsValid = TakeAutomationScreenshotOfUI_FunctionAddress != IntPtr.Zero && TakeAutomationScreenshotOfUI_WorldContextObject_IsValid && TakeAutomationScreenshotOfUI_LatentInfo_IsValid && TakeAutomationScreenshotOfUI_Name_IsValid && TakeAutomationScreenshotOfUI_Options_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshotOfUI", TakeAutomationScreenshotOfUI_IsValid);
		TakeAutomationScreenshotAtCamera_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TakeAutomationScreenshotAtCamera");
		TakeAutomationScreenshotAtCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeAutomationScreenshotAtCamera_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotAtCamera_WorldContextObject_PropertyAddress, TakeAutomationScreenshotAtCamera_FunctionAddress, "WorldContextObject");
		TakeAutomationScreenshotAtCamera_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotAtCamera_FunctionAddress, "WorldContextObject");
		TakeAutomationScreenshotAtCamera_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotAtCamera_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotAtCamera_LatentInfo_PropertyAddress, TakeAutomationScreenshotAtCamera_FunctionAddress, "LatentInfo");
		TakeAutomationScreenshotAtCamera_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotAtCamera_FunctionAddress, "LatentInfo");
		TakeAutomationScreenshotAtCamera_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotAtCamera_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotAtCamera_Camera_PropertyAddress, TakeAutomationScreenshotAtCamera_FunctionAddress, "Camera");
		TakeAutomationScreenshotAtCamera_Camera_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotAtCamera_FunctionAddress, "Camera");
		TakeAutomationScreenshotAtCamera_Camera_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotAtCamera_FunctionAddress, "Camera", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotAtCamera_NameOverride_PropertyAddress, TakeAutomationScreenshotAtCamera_FunctionAddress, "NameOverride");
		TakeAutomationScreenshotAtCamera_NameOverride_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotAtCamera_FunctionAddress, "NameOverride");
		TakeAutomationScreenshotAtCamera_NameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotAtCamera_FunctionAddress, "NameOverride", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotAtCamera_Notes_PropertyAddress, TakeAutomationScreenshotAtCamera_FunctionAddress, "Notes");
		TakeAutomationScreenshotAtCamera_Notes_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotAtCamera_FunctionAddress, "Notes");
		TakeAutomationScreenshotAtCamera_Notes_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotAtCamera_FunctionAddress, "Notes", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshotAtCamera_Options_PropertyAddress, TakeAutomationScreenshotAtCamera_FunctionAddress, "Options");
		TakeAutomationScreenshotAtCamera_Options_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshotAtCamera_FunctionAddress, "Options");
		TakeAutomationScreenshotAtCamera_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshotAtCamera_FunctionAddress, "Options", Classes.FStructProperty);
		TakeAutomationScreenshotAtCamera_IsValid = TakeAutomationScreenshotAtCamera_FunctionAddress != IntPtr.Zero && TakeAutomationScreenshotAtCamera_WorldContextObject_IsValid && TakeAutomationScreenshotAtCamera_LatentInfo_IsValid && TakeAutomationScreenshotAtCamera_Camera_IsValid && TakeAutomationScreenshotAtCamera_NameOverride_IsValid && TakeAutomationScreenshotAtCamera_Notes_IsValid && TakeAutomationScreenshotAtCamera_Options_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshotAtCamera", TakeAutomationScreenshotAtCamera_IsValid);
		TakeAutomationScreenshot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TakeAutomationScreenshot");
		TakeAutomationScreenshot_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeAutomationScreenshot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshot_WorldContextObject_PropertyAddress, TakeAutomationScreenshot_FunctionAddress, "WorldContextObject");
		TakeAutomationScreenshot_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshot_FunctionAddress, "WorldContextObject");
		TakeAutomationScreenshot_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshot_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshot_LatentInfo_PropertyAddress, TakeAutomationScreenshot_FunctionAddress, "LatentInfo");
		TakeAutomationScreenshot_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshot_FunctionAddress, "LatentInfo");
		TakeAutomationScreenshot_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshot_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshot_Name_PropertyAddress, TakeAutomationScreenshot_FunctionAddress, "Name");
		TakeAutomationScreenshot_Name_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshot_FunctionAddress, "Name");
		TakeAutomationScreenshot_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshot_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshot_Notes_PropertyAddress, TakeAutomationScreenshot_FunctionAddress, "Notes");
		TakeAutomationScreenshot_Notes_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshot_FunctionAddress, "Notes");
		TakeAutomationScreenshot_Notes_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshot_FunctionAddress, "Notes", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAutomationScreenshot_Options_PropertyAddress, TakeAutomationScreenshot_FunctionAddress, "Options");
		TakeAutomationScreenshot_Options_Offset = NativeReflectionCached.GetPropertyOffset(TakeAutomationScreenshot_FunctionAddress, "Options");
		TakeAutomationScreenshot_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAutomationScreenshot_FunctionAddress, "Options", Classes.FStructProperty);
		TakeAutomationScreenshot_IsValid = TakeAutomationScreenshot_FunctionAddress != IntPtr.Zero && TakeAutomationScreenshot_WorldContextObject_IsValid && TakeAutomationScreenshot_LatentInfo_IsValid && TakeAutomationScreenshot_Name_IsValid && TakeAutomationScreenshot_Notes_IsValid && TakeAutomationScreenshot_Options_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:TakeAutomationScreenshot", TakeAutomationScreenshot_IsValid);
		SetTestTelemetryStorage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTestTelemetryStorage");
		SetTestTelemetryStorage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTestTelemetryStorage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTestTelemetryStorage_StorageName_PropertyAddress, SetTestTelemetryStorage_FunctionAddress, "StorageName");
		SetTestTelemetryStorage_StorageName_Offset = NativeReflectionCached.GetPropertyOffset(SetTestTelemetryStorage_FunctionAddress, "StorageName");
		SetTestTelemetryStorage_StorageName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTestTelemetryStorage_FunctionAddress, "StorageName", Classes.FStrProperty);
		SetTestTelemetryStorage_IsValid = SetTestTelemetryStorage_FunctionAddress != IntPtr.Zero && SetTestTelemetryStorage_StorageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetTestTelemetryStorage", SetTestTelemetryStorage_IsValid);
		SetScalabilityQualityToLow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetScalabilityQualityToLow");
		SetScalabilityQualityToLow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalabilityQualityToLow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalabilityQualityToLow_WorldContextObject_PropertyAddress, SetScalabilityQualityToLow_FunctionAddress, "WorldContextObject");
		SetScalabilityQualityToLow_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetScalabilityQualityToLow_FunctionAddress, "WorldContextObject");
		SetScalabilityQualityToLow_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalabilityQualityToLow_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		SetScalabilityQualityToLow_IsValid = SetScalabilityQualityToLow_FunctionAddress != IntPtr.Zero && SetScalabilityQualityToLow_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityToLow", SetScalabilityQualityToLow_IsValid);
		SetScalabilityQualityToEpic_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetScalabilityQualityToEpic");
		SetScalabilityQualityToEpic_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalabilityQualityToEpic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalabilityQualityToEpic_WorldContextObject_PropertyAddress, SetScalabilityQualityToEpic_FunctionAddress, "WorldContextObject");
		SetScalabilityQualityToEpic_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetScalabilityQualityToEpic_FunctionAddress, "WorldContextObject");
		SetScalabilityQualityToEpic_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalabilityQualityToEpic_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		SetScalabilityQualityToEpic_IsValid = SetScalabilityQualityToEpic_FunctionAddress != IntPtr.Zero && SetScalabilityQualityToEpic_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityToEpic", SetScalabilityQualityToEpic_IsValid);
		SetScalabilityQualityLevelRelativeToMax_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetScalabilityQualityLevelRelativeToMax");
		SetScalabilityQualityLevelRelativeToMax_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalabilityQualityLevelRelativeToMax_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalabilityQualityLevelRelativeToMax_WorldContextObject_PropertyAddress, SetScalabilityQualityLevelRelativeToMax_FunctionAddress, "WorldContextObject");
		SetScalabilityQualityLevelRelativeToMax_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetScalabilityQualityLevelRelativeToMax_FunctionAddress, "WorldContextObject");
		SetScalabilityQualityLevelRelativeToMax_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalabilityQualityLevelRelativeToMax_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalabilityQualityLevelRelativeToMax_Value_PropertyAddress, SetScalabilityQualityLevelRelativeToMax_FunctionAddress, "Value");
		SetScalabilityQualityLevelRelativeToMax_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetScalabilityQualityLevelRelativeToMax_FunctionAddress, "Value");
		SetScalabilityQualityLevelRelativeToMax_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalabilityQualityLevelRelativeToMax_FunctionAddress, "Value", Classes.FIntProperty);
		SetScalabilityQualityLevelRelativeToMax_IsValid = SetScalabilityQualityLevelRelativeToMax_FunctionAddress != IntPtr.Zero && SetScalabilityQualityLevelRelativeToMax_WorldContextObject_IsValid && SetScalabilityQualityLevelRelativeToMax_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:SetScalabilityQualityLevelRelativeToMax", SetScalabilityQualityLevelRelativeToMax_IsValid);
		GetStatIncMax_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStatIncMax");
		GetStatIncMax_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatIncMax_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatIncMax_StatName_PropertyAddress, GetStatIncMax_FunctionAddress, "StatName");
		GetStatIncMax_StatName_Offset = NativeReflectionCached.GetPropertyOffset(GetStatIncMax_FunctionAddress, "StatName");
		GetStatIncMax_StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatIncMax_FunctionAddress, "StatName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStatIncMax_ReturnValue_PropertyAddress, GetStatIncMax_FunctionAddress, "ReturnValue");
		GetStatIncMax_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatIncMax_FunctionAddress, "ReturnValue");
		GetStatIncMax_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatIncMax_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStatIncMax_IsValid = GetStatIncMax_FunctionAddress != IntPtr.Zero && GetStatIncMax_StatName_IsValid && GetStatIncMax_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatIncMax", GetStatIncMax_IsValid);
		GetStatIncAverage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStatIncAverage");
		GetStatIncAverage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatIncAverage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatIncAverage_StatName_PropertyAddress, GetStatIncAverage_FunctionAddress, "StatName");
		GetStatIncAverage_StatName_Offset = NativeReflectionCached.GetPropertyOffset(GetStatIncAverage_FunctionAddress, "StatName");
		GetStatIncAverage_StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatIncAverage_FunctionAddress, "StatName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStatIncAverage_ReturnValue_PropertyAddress, GetStatIncAverage_FunctionAddress, "ReturnValue");
		GetStatIncAverage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatIncAverage_FunctionAddress, "ReturnValue");
		GetStatIncAverage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatIncAverage_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStatIncAverage_IsValid = GetStatIncAverage_FunctionAddress != IntPtr.Zero && GetStatIncAverage_StatName_IsValid && GetStatIncAverage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatIncAverage", GetStatIncAverage_IsValid);
		GetStatExcMax_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStatExcMax");
		GetStatExcMax_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatExcMax_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatExcMax_StatName_PropertyAddress, GetStatExcMax_FunctionAddress, "StatName");
		GetStatExcMax_StatName_Offset = NativeReflectionCached.GetPropertyOffset(GetStatExcMax_FunctionAddress, "StatName");
		GetStatExcMax_StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatExcMax_FunctionAddress, "StatName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStatExcMax_ReturnValue_PropertyAddress, GetStatExcMax_FunctionAddress, "ReturnValue");
		GetStatExcMax_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatExcMax_FunctionAddress, "ReturnValue");
		GetStatExcMax_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatExcMax_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStatExcMax_IsValid = GetStatExcMax_FunctionAddress != IntPtr.Zero && GetStatExcMax_StatName_IsValid && GetStatExcMax_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatExcMax", GetStatExcMax_IsValid);
		GetStatExcAverage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStatExcAverage");
		GetStatExcAverage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatExcAverage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatExcAverage_StatName_PropertyAddress, GetStatExcAverage_FunctionAddress, "StatName");
		GetStatExcAverage_StatName_Offset = NativeReflectionCached.GetPropertyOffset(GetStatExcAverage_FunctionAddress, "StatName");
		GetStatExcAverage_StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatExcAverage_FunctionAddress, "StatName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStatExcAverage_ReturnValue_PropertyAddress, GetStatExcAverage_FunctionAddress, "ReturnValue");
		GetStatExcAverage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatExcAverage_FunctionAddress, "ReturnValue");
		GetStatExcAverage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatExcAverage_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStatExcAverage_IsValid = GetStatExcAverage_FunctionAddress != IntPtr.Zero && GetStatExcAverage_StatName_IsValid && GetStatExcAverage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatExcAverage", GetStatExcAverage_IsValid);
		GetStatCallCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStatCallCount");
		GetStatCallCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatCallCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatCallCount_StatName_PropertyAddress, GetStatCallCount_FunctionAddress, "StatName");
		GetStatCallCount_StatName_Offset = NativeReflectionCached.GetPropertyOffset(GetStatCallCount_FunctionAddress, "StatName");
		GetStatCallCount_StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatCallCount_FunctionAddress, "StatName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStatCallCount_ReturnValue_PropertyAddress, GetStatCallCount_FunctionAddress, "ReturnValue");
		GetStatCallCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatCallCount_FunctionAddress, "ReturnValue");
		GetStatCallCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatCallCount_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStatCallCount_IsValid = GetStatCallCount_FunctionAddress != IntPtr.Zero && GetStatCallCount_StatName_IsValid && GetStatCallCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetStatCallCount", GetStatCallCount_IsValid);
		GetDefaultScreenshotOptionsForRendering_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultScreenshotOptionsForRendering");
		GetDefaultScreenshotOptionsForRendering_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultScreenshotOptionsForRendering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultScreenshotOptionsForRendering_Tolerance_PropertyAddress, GetDefaultScreenshotOptionsForRendering_FunctionAddress, "Tolerance");
		GetDefaultScreenshotOptionsForRendering_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultScreenshotOptionsForRendering_FunctionAddress, "Tolerance");
		GetDefaultScreenshotOptionsForRendering_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultScreenshotOptionsForRendering_FunctionAddress, "Tolerance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultScreenshotOptionsForRendering_Delay_PropertyAddress, GetDefaultScreenshotOptionsForRendering_FunctionAddress, "Delay");
		GetDefaultScreenshotOptionsForRendering_Delay_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultScreenshotOptionsForRendering_FunctionAddress, "Delay");
		GetDefaultScreenshotOptionsForRendering_Delay_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultScreenshotOptionsForRendering_FunctionAddress, "Delay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultScreenshotOptionsForRendering_ReturnValue_PropertyAddress, GetDefaultScreenshotOptionsForRendering_FunctionAddress, "ReturnValue");
		GetDefaultScreenshotOptionsForRendering_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultScreenshotOptionsForRendering_FunctionAddress, "ReturnValue");
		GetDefaultScreenshotOptionsForRendering_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultScreenshotOptionsForRendering_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDefaultScreenshotOptionsForRendering_IsValid = GetDefaultScreenshotOptionsForRendering_FunctionAddress != IntPtr.Zero && GetDefaultScreenshotOptionsForRendering_Tolerance_IsValid && GetDefaultScreenshotOptionsForRendering_Delay_IsValid && GetDefaultScreenshotOptionsForRendering_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetDefaultScreenshotOptionsForRendering", GetDefaultScreenshotOptionsForRendering_IsValid);
		GetDefaultScreenshotOptionsForGameplay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultScreenshotOptionsForGameplay");
		GetDefaultScreenshotOptionsForGameplay_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultScreenshotOptionsForGameplay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultScreenshotOptionsForGameplay_Tolerance_PropertyAddress, GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "Tolerance");
		GetDefaultScreenshotOptionsForGameplay_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "Tolerance");
		GetDefaultScreenshotOptionsForGameplay_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "Tolerance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultScreenshotOptionsForGameplay_Delay_PropertyAddress, GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "Delay");
		GetDefaultScreenshotOptionsForGameplay_Delay_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "Delay");
		GetDefaultScreenshotOptionsForGameplay_Delay_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "Delay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultScreenshotOptionsForGameplay_ReturnValue_PropertyAddress, GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "ReturnValue");
		GetDefaultScreenshotOptionsForGameplay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "ReturnValue");
		GetDefaultScreenshotOptionsForGameplay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultScreenshotOptionsForGameplay_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDefaultScreenshotOptionsForGameplay_IsValid = GetDefaultScreenshotOptionsForGameplay_FunctionAddress != IntPtr.Zero && GetDefaultScreenshotOptionsForGameplay_Tolerance_IsValid && GetDefaultScreenshotOptionsForGameplay_Delay_IsValid && GetDefaultScreenshotOptionsForGameplay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:GetDefaultScreenshotOptionsForGameplay", GetDefaultScreenshotOptionsForGameplay_IsValid);
		FinishLoadingBeforeScreenshot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FinishLoadingBeforeScreenshot");
		FinishLoadingBeforeScreenshot_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishLoadingBeforeScreenshot_FunctionAddress);
		FinishLoadingBeforeScreenshot_IsValid = FinishLoadingBeforeScreenshot_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:FinishLoadingBeforeScreenshot", FinishLoadingBeforeScreenshot_IsValid);
		EnableStatGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableStatGroup");
		EnableStatGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableStatGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableStatGroup_WorldContextObject_PropertyAddress, EnableStatGroup_FunctionAddress, "WorldContextObject");
		EnableStatGroup_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(EnableStatGroup_FunctionAddress, "WorldContextObject");
		EnableStatGroup_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableStatGroup_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableStatGroup_GroupName_PropertyAddress, EnableStatGroup_FunctionAddress, "GroupName");
		EnableStatGroup_GroupName_Offset = NativeReflectionCached.GetPropertyOffset(EnableStatGroup_FunctionAddress, "GroupName");
		EnableStatGroup_GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableStatGroup_FunctionAddress, "GroupName", Classes.FNameProperty);
		EnableStatGroup_IsValid = EnableStatGroup_FunctionAddress != IntPtr.Zero && EnableStatGroup_WorldContextObject_IsValid && EnableStatGroup_GroupName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:EnableStatGroup", EnableStatGroup_IsValid);
		DisableStatGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableStatGroup");
		DisableStatGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableStatGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableStatGroup_WorldContextObject_PropertyAddress, DisableStatGroup_FunctionAddress, "WorldContextObject");
		DisableStatGroup_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(DisableStatGroup_FunctionAddress, "WorldContextObject");
		DisableStatGroup_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableStatGroup_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableStatGroup_GroupName_PropertyAddress, DisableStatGroup_FunctionAddress, "GroupName");
		DisableStatGroup_GroupName_Offset = NativeReflectionCached.GetPropertyOffset(DisableStatGroup_FunctionAddress, "GroupName");
		DisableStatGroup_GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableStatGroup_FunctionAddress, "GroupName", Classes.FNameProperty);
		DisableStatGroup_IsValid = DisableStatGroup_FunctionAddress != IntPtr.Zero && DisableStatGroup_WorldContextObject_IsValid && DisableStatGroup_GroupName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:DisableStatGroup", DisableStatGroup_IsValid);
		CompareImageAgainstReference_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompareImageAgainstReference");
		CompareImageAgainstReference_ParamsSize = NativeReflection.GetFunctionParamsSize(CompareImageAgainstReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompareImageAgainstReference_ImageFilePath_PropertyAddress, CompareImageAgainstReference_FunctionAddress, "ImageFilePath");
		CompareImageAgainstReference_ImageFilePath_Offset = NativeReflectionCached.GetPropertyOffset(CompareImageAgainstReference_FunctionAddress, "ImageFilePath");
		CompareImageAgainstReference_ImageFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareImageAgainstReference_FunctionAddress, "ImageFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareImageAgainstReference_ComparisonName_PropertyAddress, CompareImageAgainstReference_FunctionAddress, "ComparisonName");
		CompareImageAgainstReference_ComparisonName_Offset = NativeReflectionCached.GetPropertyOffset(CompareImageAgainstReference_FunctionAddress, "ComparisonName");
		CompareImageAgainstReference_ComparisonName_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareImageAgainstReference_FunctionAddress, "ComparisonName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareImageAgainstReference_ComparisonTolerance_PropertyAddress, CompareImageAgainstReference_FunctionAddress, "ComparisonTolerance");
		CompareImageAgainstReference_ComparisonTolerance_Offset = NativeReflectionCached.GetPropertyOffset(CompareImageAgainstReference_FunctionAddress, "ComparisonTolerance");
		CompareImageAgainstReference_ComparisonTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareImageAgainstReference_FunctionAddress, "ComparisonTolerance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareImageAgainstReference_ComparisonNotes_PropertyAddress, CompareImageAgainstReference_FunctionAddress, "ComparisonNotes");
		CompareImageAgainstReference_ComparisonNotes_Offset = NativeReflectionCached.GetPropertyOffset(CompareImageAgainstReference_FunctionAddress, "ComparisonNotes");
		CompareImageAgainstReference_ComparisonNotes_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareImageAgainstReference_FunctionAddress, "ComparisonNotes", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareImageAgainstReference_WorldContextObject_PropertyAddress, CompareImageAgainstReference_FunctionAddress, "WorldContextObject");
		CompareImageAgainstReference_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CompareImageAgainstReference_FunctionAddress, "WorldContextObject");
		CompareImageAgainstReference_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareImageAgainstReference_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareImageAgainstReference_ReturnValue_PropertyAddress, CompareImageAgainstReference_FunctionAddress, "ReturnValue");
		CompareImageAgainstReference_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CompareImageAgainstReference_FunctionAddress, "ReturnValue");
		CompareImageAgainstReference_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareImageAgainstReference_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CompareImageAgainstReference_IsValid = CompareImageAgainstReference_FunctionAddress != IntPtr.Zero && CompareImageAgainstReference_ImageFilePath_IsValid && CompareImageAgainstReference_ComparisonName_IsValid && CompareImageAgainstReference_ComparisonTolerance_IsValid && CompareImageAgainstReference_ComparisonNotes_IsValid && CompareImageAgainstReference_WorldContextObject_IsValid && CompareImageAgainstReference_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:CompareImageAgainstReference", CompareImageAgainstReference_IsValid);
		AutomationWaitForLoading_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AutomationWaitForLoading");
		AutomationWaitForLoading_ParamsSize = NativeReflection.GetFunctionParamsSize(AutomationWaitForLoading_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AutomationWaitForLoading_WorldContextObject_PropertyAddress, AutomationWaitForLoading_FunctionAddress, "WorldContextObject");
		AutomationWaitForLoading_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AutomationWaitForLoading_FunctionAddress, "WorldContextObject");
		AutomationWaitForLoading_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AutomationWaitForLoading_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutomationWaitForLoading_LatentInfo_PropertyAddress, AutomationWaitForLoading_FunctionAddress, "LatentInfo");
		AutomationWaitForLoading_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(AutomationWaitForLoading_FunctionAddress, "LatentInfo");
		AutomationWaitForLoading_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(AutomationWaitForLoading_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AutomationWaitForLoading_Options_PropertyAddress, AutomationWaitForLoading_FunctionAddress, "Options");
		AutomationWaitForLoading_Options_Offset = NativeReflectionCached.GetPropertyOffset(AutomationWaitForLoading_FunctionAddress, "Options");
		AutomationWaitForLoading_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(AutomationWaitForLoading_FunctionAddress, "Options", Classes.FStructProperty);
		AutomationWaitForLoading_IsValid = AutomationWaitForLoading_FunctionAddress != IntPtr.Zero && AutomationWaitForLoading_WorldContextObject_IsValid && AutomationWaitForLoading_LatentInfo_IsValid && AutomationWaitForLoading_Options_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AutomationWaitForLoading", AutomationWaitForLoading_IsValid);
		AreAutomatedTestsRunning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AreAutomatedTestsRunning");
		AreAutomatedTestsRunning_ParamsSize = NativeReflection.GetFunctionParamsSize(AreAutomatedTestsRunning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AreAutomatedTestsRunning_ReturnValue_PropertyAddress, AreAutomatedTestsRunning_FunctionAddress, "ReturnValue");
		AreAutomatedTestsRunning_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AreAutomatedTestsRunning_FunctionAddress, "ReturnValue");
		AreAutomatedTestsRunning_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AreAutomatedTestsRunning_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AreAutomatedTestsRunning_IsValid = AreAutomatedTestsRunning_FunctionAddress != IntPtr.Zero && AreAutomatedTestsRunning_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AreAutomatedTestsRunning", AreAutomatedTestsRunning_IsValid);
		AddTestTelemetryData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddTestTelemetryData");
		AddTestTelemetryData_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTestTelemetryData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTestTelemetryData_DataPoint_PropertyAddress, AddTestTelemetryData_FunctionAddress, "DataPoint");
		AddTestTelemetryData_DataPoint_Offset = NativeReflectionCached.GetPropertyOffset(AddTestTelemetryData_FunctionAddress, "DataPoint");
		AddTestTelemetryData_DataPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTestTelemetryData_FunctionAddress, "DataPoint", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTestTelemetryData_Measurement_PropertyAddress, AddTestTelemetryData_FunctionAddress, "Measurement");
		AddTestTelemetryData_Measurement_Offset = NativeReflectionCached.GetPropertyOffset(AddTestTelemetryData_FunctionAddress, "Measurement");
		AddTestTelemetryData_Measurement_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTestTelemetryData_FunctionAddress, "Measurement", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTestTelemetryData_Context_PropertyAddress, AddTestTelemetryData_FunctionAddress, "Context");
		AddTestTelemetryData_Context_Offset = NativeReflectionCached.GetPropertyOffset(AddTestTelemetryData_FunctionAddress, "Context");
		AddTestTelemetryData_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTestTelemetryData_FunctionAddress, "Context", Classes.FStrProperty);
		AddTestTelemetryData_IsValid = AddTestTelemetryData_FunctionAddress != IntPtr.Zero && AddTestTelemetryData_DataPoint_IsValid && AddTestTelemetryData_Measurement_IsValid && AddTestTelemetryData_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AddTestTelemetryData", AddTestTelemetryData_IsValid);
		AddExpectedLogError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddExpectedLogError");
		AddExpectedLogError_ParamsSize = NativeReflection.GetFunctionParamsSize(AddExpectedLogError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddExpectedLogError_ExpectedPatternString_PropertyAddress, AddExpectedLogError_FunctionAddress, "ExpectedPatternString");
		AddExpectedLogError_ExpectedPatternString_Offset = NativeReflectionCached.GetPropertyOffset(AddExpectedLogError_FunctionAddress, "ExpectedPatternString");
		AddExpectedLogError_ExpectedPatternString_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExpectedLogError_FunctionAddress, "ExpectedPatternString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExpectedLogError_Occurrences_PropertyAddress, AddExpectedLogError_FunctionAddress, "Occurrences");
		AddExpectedLogError_Occurrences_Offset = NativeReflectionCached.GetPropertyOffset(AddExpectedLogError_FunctionAddress, "Occurrences");
		AddExpectedLogError_Occurrences_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExpectedLogError_FunctionAddress, "Occurrences", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExpectedLogError_ExactMatch_PropertyAddress, AddExpectedLogError_FunctionAddress, "ExactMatch");
		AddExpectedLogError_ExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(AddExpectedLogError_FunctionAddress, "ExactMatch");
		AddExpectedLogError_ExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExpectedLogError_FunctionAddress, "ExactMatch", Classes.FBoolProperty);
		AddExpectedLogError_IsValid = AddExpectedLogError_FunctionAddress != IntPtr.Zero && AddExpectedLogError_ExpectedPatternString_IsValid && AddExpectedLogError_Occurrences_IsValid && AddExpectedLogError_ExactMatch_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary:AddExpectedLogError", AddExpectedLogError_IsValid);
	}
}
