using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.AutoMovementUtil", "UnrealExtent", UnrealModuleType.Game)]
public class UAutoMovementUtil : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetVfxAutoPlayerRootFolderPath_IsValid;

	private static IntPtr SetVfxAutoPlayerRootFolderPath_FunctionAddress;

	private static int SetVfxAutoPlayerRootFolderPath_ParamsSize;

	private static bool SetVfxAutoPlayerRootFolderPath_InRootFolderPath_IsValid;

	private static FFieldAddress SetVfxAutoPlayerRootFolderPath_InRootFolderPath_PropertyAddress;

	private static int SetVfxAutoPlayerRootFolderPath_InRootFolderPath_Offset;

	private static bool SaveOfflinePathPoints_IsValid;

	private static IntPtr SaveOfflinePathPoints_FunctionAddress;

	private static int SaveOfflinePathPoints_ParamsSize;

	private static bool SaveOfflinePathPoints_InPoints_IsValid;

	private static FFieldAddress SaveOfflinePathPoints_InPoints_PropertyAddress;

	private static int SaveOfflinePathPoints_InPoints_Offset;

	private static bool SaveOfflinePathPoints_InFilePathUnderProjFolder_IsValid;

	private static FFieldAddress SaveOfflinePathPoints_InFilePathUnderProjFolder_PropertyAddress;

	private static int SaveOfflinePathPoints_InFilePathUnderProjFolder_Offset;

	private static bool MergeMultiTextureMipReports_IsValid;

	private static IntPtr MergeMultiTextureMipReports_FunctionAddress;

	private static int MergeMultiTextureMipReports_ParamsSize;

	private static bool MergeMultiTextureMipReports_InReportFilePaths_IsValid;

	private static FFieldAddress MergeMultiTextureMipReports_InReportFilePaths_PropertyAddress;

	private static int MergeMultiTextureMipReports_InReportFilePaths_Offset;

	private static bool MergeMultiTextureMipReports_OutputMergedFileName_IsValid;

	private static FFieldAddress MergeMultiTextureMipReports_OutputMergedFileName_PropertyAddress;

	private static int MergeMultiTextureMipReports_OutputMergedFileName_Offset;

	private static bool MergeMultiTextureMipReports_ReturnValue_IsValid;

	private static FFieldAddress MergeMultiTextureMipReports_ReturnValue_PropertyAddress;

	private static int MergeMultiTextureMipReports_ReturnValue_Offset;

	private static bool MergeMipReportsWithFileNameKeyword_IsValid;

	private static IntPtr MergeMipReportsWithFileNameKeyword_FunctionAddress;

	private static int MergeMipReportsWithFileNameKeyword_ParamsSize;

	private static bool MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_IsValid;

	private static FFieldAddress MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_PropertyAddress;

	private static int MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_Offset;

	private static bool MergeMipReportsWithFileNameKeyword_InFileNameKeyword_IsValid;

	private static FFieldAddress MergeMipReportsWithFileNameKeyword_InFileNameKeyword_PropertyAddress;

	private static int MergeMipReportsWithFileNameKeyword_InFileNameKeyword_Offset;

	private static bool MergeMipReportsWithFileNameKeyword_OutputMergedFileName_IsValid;

	private static FFieldAddress MergeMipReportsWithFileNameKeyword_OutputMergedFileName_PropertyAddress;

	private static int MergeMipReportsWithFileNameKeyword_OutputMergedFileName_Offset;

	private static bool MergeMipReportsWithFileNameKeyword_ReturnValue_IsValid;

	private static FFieldAddress MergeMipReportsWithFileNameKeyword_ReturnValue_PropertyAddress;

	private static int MergeMipReportsWithFileNameKeyword_ReturnValue_Offset;

	private static bool LoadStatsCapturerReport_IsValid;

	private static IntPtr LoadStatsCapturerReport_FunctionAddress;

	private static int LoadStatsCapturerReport_ParamsSize;

	private static bool LoadStatsCapturerReport_InFileNameUnderProjFolder_IsValid;

	private static FFieldAddress LoadStatsCapturerReport_InFileNameUnderProjFolder_PropertyAddress;

	private static int LoadStatsCapturerReport_InFileNameUnderProjFolder_Offset;

	private static bool LoadStatsCapturerReport_AllPathPointStatInfo_IsValid;

	private static FFieldAddress LoadStatsCapturerReport_AllPathPointStatInfo_PropertyAddress;

	private static int LoadStatsCapturerReport_AllPathPointStatInfo_Offset;

	private static bool LoadStatsCapturerReport_PointNum_IsValid;

	private static FFieldAddress LoadStatsCapturerReport_PointNum_PropertyAddress;

	private static int LoadStatsCapturerReport_PointNum_Offset;

	private static bool LoadStatsCapturerReport_ReturnValue_IsValid;

	private static FFieldAddress LoadStatsCapturerReport_ReturnValue_PropertyAddress;

	private static int LoadStatsCapturerReport_ReturnValue_Offset;

	private static bool InsertIntoCapturedInfoArrayPerPoint_IsValid;

	private static IntPtr InsertIntoCapturedInfoArrayPerPoint_FunctionAddress;

	private static int InsertIntoCapturedInfoArrayPerPoint_ParamsSize;

	private static bool InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_IsValid;

	private static FFieldAddress InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_PropertyAddress;

	private static int InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_Offset;

	private static bool InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_IsValid;

	private static FFieldAddress InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_PropertyAddress;

	private static int InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_Offset;

	private static bool InsertIntoCapturedInfoArrayPerPoint_ReturnValue_IsValid;

	private static FFieldAddress InsertIntoCapturedInfoArrayPerPoint_ReturnValue_PropertyAddress;

	private static int InsertIntoCapturedInfoArrayPerPoint_ReturnValue_Offset;

	private static bool GetVfxAutoPlayerRootFolderPath_IsValid;

	private static IntPtr GetVfxAutoPlayerRootFolderPath_FunctionAddress;

	private static int GetVfxAutoPlayerRootFolderPath_ParamsSize;

	private static bool GetVfxAutoPlayerRootFolderPath_ReturnValue_IsValid;

	private static FFieldAddress GetVfxAutoPlayerRootFolderPath_ReturnValue_PropertyAddress;

	private static int GetVfxAutoPlayerRootFolderPath_ReturnValue_Offset;

	private static bool GetOfflinePathPoints_IsValid;

	private static IntPtr GetOfflinePathPoints_FunctionAddress;

	private static int GetOfflinePathPoints_ParamsSize;

	private static bool GetOfflinePathPoints_InFilePathUnderProjDir_IsValid;

	private static FFieldAddress GetOfflinePathPoints_InFilePathUnderProjDir_PropertyAddress;

	private static int GetOfflinePathPoints_InFilePathUnderProjDir_Offset;

	private static bool GetOfflinePathPoints_bUseSparsePoints_IsValid;

	private static FFieldAddress GetOfflinePathPoints_bUseSparsePoints_PropertyAddress;

	private static int GetOfflinePathPoints_bUseSparsePoints_Offset;

	private static bool GetOfflinePathPoints_ReturnValue_IsValid;

	private static FFieldAddress GetOfflinePathPoints_ReturnValue_PropertyAddress;

	private static int GetOfflinePathPoints_ReturnValue_Offset;

	private static bool GetNowTimestamp_IsValid;

	private static IntPtr GetNowTimestamp_FunctionAddress;

	private static int GetNowTimestamp_ParamsSize;

	private static bool GetNowTimestamp_ReturnValue_IsValid;

	private static FFieldAddress GetNowTimestamp_ReturnValue_PropertyAddress;

	private static int GetNowTimestamp_ReturnValue_Offset;

	private static bool GetCurPointProcessedMetricsMap_IsValid;

	private static IntPtr GetCurPointProcessedMetricsMap_FunctionAddress;

	private static int GetCurPointProcessedMetricsMap_ParamsSize;

	private static bool GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_IsValid;

	private static FFieldAddress GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_PropertyAddress;

	private static int GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_Offset;

	private static bool GetCurPointProcessedMetricsMap_ReturnValue_IsValid;

	private static FFieldAddress GetCurPointProcessedMetricsMap_ReturnValue_PropertyAddress;

	private static int GetCurPointProcessedMetricsMap_ReturnValue_Offset;

	private static bool FromTimestamp_IsValid;

	private static IntPtr FromTimestamp_FunctionAddress;

	private static int FromTimestamp_ParamsSize;

	private static bool FromTimestamp_Time_IsValid;

	private static FFieldAddress FromTimestamp_Time_PropertyAddress;

	private static int FromTimestamp_Time_Offset;

	private static bool FromTimestamp_ReturnValue_IsValid;

	private static FFieldAddress FromTimestamp_ReturnValue_PropertyAddress;

	private static int FromTimestamp_ReturnValue_Offset;

	private static bool FormatTimeSeconds_IsValid;

	private static IntPtr FormatTimeSeconds_FunctionAddress;

	private static int FormatTimeSeconds_ParamsSize;

	private static bool FormatTimeSeconds_InDuration_IsValid;

	private static FFieldAddress FormatTimeSeconds_InDuration_PropertyAddress;

	private static int FormatTimeSeconds_InDuration_Offset;

	private static bool FormatTimeSeconds_ReturnValue_IsValid;

	private static FFieldAddress FormatTimeSeconds_ReturnValue_PropertyAddress;

	private static int FormatTimeSeconds_ReturnValue_Offset;

	private static bool FormatTimeAuto_IsValid;

	private static IntPtr FormatTimeAuto_FunctionAddress;

	private static int FormatTimeAuto_ParamsSize;

	private static bool FormatTimeAuto_InDuration_IsValid;

	private static FFieldAddress FormatTimeAuto_InDuration_PropertyAddress;

	private static int FormatTimeAuto_InDuration_Offset;

	private static bool FormatTimeAuto_NumDigits_IsValid;

	private static FFieldAddress FormatTimeAuto_NumDigits_PropertyAddress;

	private static int FormatTimeAuto_NumDigits_Offset;

	private static bool FormatTimeAuto_ReturnValue_IsValid;

	private static FFieldAddress FormatTimeAuto_ReturnValue_PropertyAddress;

	private static int FormatTimeAuto_ReturnValue_Offset;

	private static bool ExtractDateTimeInfo_IsValid;

	private static IntPtr ExtractDateTimeInfo_FunctionAddress;

	private static int ExtractDateTimeInfo_ParamsSize;

	private static bool ExtractDateTimeInfo_InString_IsValid;

	private static FFieldAddress ExtractDateTimeInfo_InString_PropertyAddress;

	private static int ExtractDateTimeInfo_InString_Offset;

	private static bool ExtractDateTimeInfo_ReturnValue_IsValid;

	private static FFieldAddress ExtractDateTimeInfo_ReturnValue_PropertyAddress;

	private static int ExtractDateTimeInfo_ReturnValue_Offset;

	private static bool ExportStatsCapturedReport_IsValid;

	private static IntPtr ExportStatsCapturedReport_FunctionAddress;

	private static int ExportStatsCapturedReport_ParamsSize;

	private static bool ExportStatsCapturedReport_InPathPointStatsInfo_IsValid;

	private static FFieldAddress ExportStatsCapturedReport_InPathPointStatsInfo_PropertyAddress;

	private static int ExportStatsCapturedReport_InPathPointStatsInfo_Offset;

	private static bool ExportStatsCapturedReport_InFileName_IsValid;

	private static FFieldAddress ExportStatsCapturedReport_InFileName_PropertyAddress;

	private static int ExportStatsCapturedReport_InFileName_Offset;

	private static bool ExportStatsCapturedReport_bAppend_IsValid;

	private static FFieldAddress ExportStatsCapturedReport_bAppend_PropertyAddress;

	private static int ExportStatsCapturedReport_bAppend_Offset;

	private static bool ExportStatsCapturedReport_bOutputHeader_IsValid;

	private static FFieldAddress ExportStatsCapturedReport_bOutputHeader_PropertyAddress;

	private static int ExportStatsCapturedReport_bOutputHeader_Offset;

	private static bool ExportCapturedInfoBatch_IsValid;

	private static IntPtr ExportCapturedInfoBatch_FunctionAddress;

	private static int ExportCapturedInfoBatch_ParamsSize;

	private static bool ExportCapturedInfoBatch_BatchSize_IsValid;

	private static FFieldAddress ExportCapturedInfoBatch_BatchSize_PropertyAddress;

	private static int ExportCapturedInfoBatch_BatchSize_Offset;

	private static bool ExportCapturedInfoBatch_TotalPointNum_IsValid;

	private static FFieldAddress ExportCapturedInfoBatch_TotalPointNum_PropertyAddress;

	private static int ExportCapturedInfoBatch_TotalPointNum_Offset;

	private static bool ExportCapturedInfoBatch_InPathPointStatsInfo_IsValid;

	private static FFieldAddress ExportCapturedInfoBatch_InPathPointStatsInfo_PropertyAddress;

	private static int ExportCapturedInfoBatch_InPathPointStatsInfo_Offset;

	private static bool ExportCapturedInfoBatch_InFileName_IsValid;

	private static FFieldAddress ExportCapturedInfoBatch_InFileName_PropertyAddress;

	private static int ExportCapturedInfoBatch_InFileName_Offset;

	private static bool ExportCapturedInfoBatch_bLastBatch_IsValid;

	private static FFieldAddress ExportCapturedInfoBatch_bLastBatch_PropertyAddress;

	private static int ExportCapturedInfoBatch_bLastBatch_Offset;

	private static bool ExportCapturedInfoBatch_bOutputHeader_IsValid;

	private static FFieldAddress ExportCapturedInfoBatch_bOutputHeader_PropertyAddress;

	private static int ExportCapturedInfoBatch_bOutputHeader_Offset;

	private static bool ExportCapturedInfoBatch_ReturnValue_IsValid;

	private static FFieldAddress ExportCapturedInfoBatch_ReturnValue_PropertyAddress;

	private static int ExportCapturedInfoBatch_ReturnValue_Offset;

	private static bool AppendOfflinePathPoints_IsValid;

	private static IntPtr AppendOfflinePathPoints_FunctionAddress;

	private static int AppendOfflinePathPoints_ParamsSize;

	private static bool AppendOfflinePathPoints_InPoints_IsValid;

	private static FFieldAddress AppendOfflinePathPoints_InPoints_PropertyAddress;

	private static int AppendOfflinePathPoints_InPoints_Offset;

	private static bool AppendOfflinePathPoints_InFilePathUnderProjFolder_IsValid;

	private static FFieldAddress AppendOfflinePathPoints_InFilePathUnderProjFolder_PropertyAddress;

	private static int AppendOfflinePathPoints_InFilePathUnderProjFolder_Offset;

	private static bool AppendHeaderToCapturedReport_IsValid;

	private static IntPtr AppendHeaderToCapturedReport_FunctionAddress;

	private static int AppendHeaderToCapturedReport_ParamsSize;

	private static bool AppendHeaderToCapturedReport_CapturedInfoNameList_IsValid;

	private static FFieldAddress AppendHeaderToCapturedReport_CapturedInfoNameList_PropertyAddress;

	private static int AppendHeaderToCapturedReport_CapturedInfoNameList_Offset;

	private static bool AppendHeaderToCapturedReport_InFileName_IsValid;

	private static FFieldAddress AppendHeaderToCapturedReport_InFileName_PropertyAddress;

	private static int AppendHeaderToCapturedReport_InFileName_Offset;

	private static bool AppendGeneralStatisticsToCapturedReport_IsValid;

	private static IntPtr AppendGeneralStatisticsToCapturedReport_FunctionAddress;

	private static int AppendGeneralStatisticsToCapturedReport_ParamsSize;

	private static bool AppendGeneralStatisticsToCapturedReport_InFileName_IsValid;

	private static FFieldAddress AppendGeneralStatisticsToCapturedReport_InFileName_PropertyAddress;

	private static int AppendGeneralStatisticsToCapturedReport_InFileName_Offset;

	private static bool AppendGeneralStatisticsToCapturedReport_MetricsNum_IsValid;

	private static FFieldAddress AppendGeneralStatisticsToCapturedReport_MetricsNum_PropertyAddress;

	private static int AppendGeneralStatisticsToCapturedReport_MetricsNum_Offset;

	private static bool AppendGeneralStatisticsToCapturedReport_PointNum_IsValid;

	private static FFieldAddress AppendGeneralStatisticsToCapturedReport_PointNum_PropertyAddress;

	private static int AppendGeneralStatisticsToCapturedReport_PointNum_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:SetVfxAutoPlayerRootFolderPath")]
	public unsafe static void SetVfxAutoPlayerRootFolderPath(string InRootFolderPath)
	{
		if (!SetVfxAutoPlayerRootFolderPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:SetVfxAutoPlayerRootFolderPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVfxAutoPlayerRootFolderPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVfxAutoPlayerRootFolderPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVfxAutoPlayerRootFolderPath_InRootFolderPath_Offset), 0, SetVfxAutoPlayerRootFolderPath_InRootFolderPath_PropertyAddress.Address, InRootFolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVfxAutoPlayerRootFolderPath_FunctionAddress, intPtr, SetVfxAutoPlayerRootFolderPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVfxAutoPlayerRootFolderPath_InRootFolderPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:SaveOfflinePathPoints")]
	public unsafe static void SaveOfflinePathPoints(List<FVector> InPoints, string InFilePathUnderProjFolder)
	{
		if (!SaveOfflinePathPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:SaveOfflinePathPoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveOfflinePathPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveOfflinePathPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, SaveOfflinePathPoints_InPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SaveOfflinePathPoints_InPoints_Offset), InPoints);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveOfflinePathPoints_InFilePathUnderProjFolder_Offset), 0, SaveOfflinePathPoints_InFilePathUnderProjFolder_PropertyAddress.Address, InFilePathUnderProjFolder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveOfflinePathPoints_FunctionAddress, intPtr, SaveOfflinePathPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveOfflinePathPoints_InPoints_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveOfflinePathPoints_InFilePathUnderProjFolder_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:MergeMultiTextureMipReports")]
	public unsafe static bool MergeMultiTextureMipReports(List<string> InReportFilePaths, string OutputMergedFileName)
	{
		if (!MergeMultiTextureMipReports_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:MergeMultiTextureMipReports");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeMultiTextureMipReports_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeMultiTextureMipReports_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, MergeMultiTextureMipReports_InReportFilePaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, MergeMultiTextureMipReports_InReportFilePaths_Offset), InReportFilePaths);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MergeMultiTextureMipReports_OutputMergedFileName_Offset), 0, MergeMultiTextureMipReports_OutputMergedFileName_PropertyAddress.Address, OutputMergedFileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MergeMultiTextureMipReports_FunctionAddress, intPtr, MergeMultiTextureMipReports_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MergeMultiTextureMipReports_InReportFilePaths_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MergeMultiTextureMipReports_OutputMergedFileName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MergeMultiTextureMipReports_ReturnValue_Offset), 0, MergeMultiTextureMipReports_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:MergeMipReportsWithFileNameKeyword")]
	public unsafe static bool MergeMipReportsWithFileNameKeyword(string InDirectoryUnderProjDir, string InFileNameKeyword, string OutputMergedFileName)
	{
		if (!MergeMipReportsWithFileNameKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:MergeMipReportsWithFileNameKeyword");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeMipReportsWithFileNameKeyword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeMipReportsWithFileNameKeyword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_Offset), 0, MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_PropertyAddress.Address, InDirectoryUnderProjDir);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MergeMipReportsWithFileNameKeyword_InFileNameKeyword_Offset), 0, MergeMipReportsWithFileNameKeyword_InFileNameKeyword_PropertyAddress.Address, InFileNameKeyword);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MergeMipReportsWithFileNameKeyword_OutputMergedFileName_Offset), 0, MergeMipReportsWithFileNameKeyword_OutputMergedFileName_PropertyAddress.Address, OutputMergedFileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MergeMipReportsWithFileNameKeyword_FunctionAddress, intPtr, MergeMipReportsWithFileNameKeyword_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MergeMipReportsWithFileNameKeyword_InFileNameKeyword_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MergeMipReportsWithFileNameKeyword_OutputMergedFileName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MergeMipReportsWithFileNameKeyword_ReturnValue_Offset), 0, MergeMipReportsWithFileNameKeyword_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:LoadStatsCapturerReport")]
	public unsafe static bool LoadStatsCapturerReport(string InFileNameUnderProjFolder, out List<FGSPathPointStatInfo> AllPathPointStatInfo, int PointNum)
	{
		if (!LoadStatsCapturerReport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:LoadStatsCapturerReport");
			AllPathPointStatInfo = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadStatsCapturerReport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadStatsCapturerReport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadStatsCapturerReport_InFileNameUnderProjFolder_Offset), 0, LoadStatsCapturerReport_InFileNameUnderProjFolder_PropertyAddress.Address, InFileNameUnderProjFolder);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LoadStatsCapturerReport_PointNum_Offset), 0, LoadStatsCapturerReport_PointNum_PropertyAddress.Address, PointNum);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadStatsCapturerReport_FunctionAddress, intPtr, LoadStatsCapturerReport_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadStatsCapturerReport_InFileNameUnderProjFolder_PropertyAddress.Address, intPtr);
		AllPathPointStatInfo = new TArrayCopyMarshaler<FGSPathPointStatInfo>(1, LoadStatsCapturerReport_AllPathPointStatInfo_PropertyAddress, CachedMarshalingDelegates<FGSPathPointStatInfo, FGSPathPointStatInfo>.FromNative, CachedMarshalingDelegates<FGSPathPointStatInfo, FGSPathPointStatInfo>.ToNative).FromNative(IntPtr.Add(intPtr, LoadStatsCapturerReport_AllPathPointStatInfo_Offset));
		NativeReflection.DestroyValue_InContainer(LoadStatsCapturerReport_AllPathPointStatInfo_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadStatsCapturerReport_ReturnValue_Offset), 0, LoadStatsCapturerReport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:InsertIntoCapturedInfoArrayPerPoint")]
	public unsafe static FCapturedInfoArrayPerPoint InsertIntoCapturedInfoArrayPerPoint(List<FGSCapturedStatResult> RawCapturedData, FCapturedInfoArrayPerPoint CapturedInfoArrayPerPoint)
	{
		if (!InsertIntoCapturedInfoArrayPerPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:InsertIntoCapturedInfoArrayPerPoint");
			return default(FCapturedInfoArrayPerPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(InsertIntoCapturedInfoArrayPerPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InsertIntoCapturedInfoArrayPerPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FGSCapturedStatResult>(1, InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_PropertyAddress, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.FromNative, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.ToNative).ToNative(IntPtr.Add(intPtr, InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_Offset), RawCapturedData);
		NativeReflection.InitializeValue_InContainer(InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_PropertyAddress.Address, intPtr);
		FCapturedInfoArrayPerPoint.ToNative(IntPtr.Add(intPtr, InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_Offset), 0, InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_PropertyAddress.Address, CapturedInfoArrayPerPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, intPtr, InsertIntoCapturedInfoArrayPerPoint_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_PropertyAddress.Address, intPtr);
		FCapturedInfoArrayPerPoint result = FCapturedInfoArrayPerPoint.FromNative(IntPtr.Add(intPtr, InsertIntoCapturedInfoArrayPerPoint_ReturnValue_Offset), 0, InsertIntoCapturedInfoArrayPerPoint_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(InsertIntoCapturedInfoArrayPerPoint_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:GetVfxAutoPlayerRootFolderPath")]
	public unsafe static string GetVfxAutoPlayerRootFolderPath()
	{
		if (!GetVfxAutoPlayerRootFolderPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:GetVfxAutoPlayerRootFolderPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVfxAutoPlayerRootFolderPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVfxAutoPlayerRootFolderPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVfxAutoPlayerRootFolderPath_FunctionAddress, intPtr, GetVfxAutoPlayerRootFolderPath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetVfxAutoPlayerRootFolderPath_ReturnValue_Offset), 0, GetVfxAutoPlayerRootFolderPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetVfxAutoPlayerRootFolderPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:GetOfflinePathPoints")]
	public unsafe static List<FVector> GetOfflinePathPoints(string InFilePathUnderProjDir, bool bUseSparsePoints = false)
	{
		if (!GetOfflinePathPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:GetOfflinePathPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOfflinePathPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOfflinePathPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetOfflinePathPoints_InFilePathUnderProjDir_Offset), 0, GetOfflinePathPoints_InFilePathUnderProjDir_PropertyAddress.Address, InFilePathUnderProjDir);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetOfflinePathPoints_bUseSparsePoints_Offset), 0, GetOfflinePathPoints_bUseSparsePoints_PropertyAddress.Address, bUseSparsePoints);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOfflinePathPoints_FunctionAddress, intPtr, GetOfflinePathPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOfflinePathPoints_InFilePathUnderProjDir_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetOfflinePathPoints_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetOfflinePathPoints_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetOfflinePathPoints_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:GetNowTimestamp")]
	public unsafe static long GetNowTimestamp()
	{
		if (!GetNowTimestamp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:GetNowTimestamp");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNowTimestamp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNowTimestamp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNowTimestamp_FunctionAddress, intPtr, GetNowTimestamp_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetNowTimestamp_ReturnValue_Offset), 0, GetNowTimestamp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:GetCurPointProcessedMetricsMap")]
	public unsafe static Dictionary<string, float> GetCurPointProcessedMetricsMap(FCapturedInfoArrayPerPoint InCapturedInfoPerPoint)
	{
		if (!GetCurPointProcessedMetricsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:GetCurPointProcessedMetricsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurPointProcessedMetricsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurPointProcessedMetricsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_PropertyAddress.Address, intPtr);
		FCapturedInfoArrayPerPoint.ToNative(IntPtr.Add(intPtr, GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_Offset), 0, GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_PropertyAddress.Address, InCapturedInfoPerPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurPointProcessedMetricsMap_FunctionAddress, intPtr, GetCurPointProcessedMetricsMap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_PropertyAddress.Address, intPtr);
		Dictionary<string, float> result = new TMapCopyMarshaler<string, float>(1, GetCurPointProcessedMetricsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurPointProcessedMetricsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurPointProcessedMetricsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:FromTimestamp")]
	public unsafe static FDateTime FromTimestamp(long Time)
	{
		if (!FromTimestamp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:FromTimestamp");
			return default(FDateTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FromTimestamp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FromTimestamp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, FromTimestamp_Time_Offset), 0, FromTimestamp_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FromTimestamp_FunctionAddress, intPtr, FromTimestamp_ParamsSize);
		return FDateTime.FromNative(IntPtr.Add(intPtr, FromTimestamp_ReturnValue_Offset), 0, FromTimestamp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:FormatTimeSeconds")]
	public unsafe static string FormatTimeSeconds(float InDuration)
	{
		if (!FormatTimeSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:FormatTimeSeconds");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FormatTimeSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FormatTimeSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FormatTimeSeconds_InDuration_Offset), 0, FormatTimeSeconds_InDuration_PropertyAddress.Address, InDuration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FormatTimeSeconds_FunctionAddress, intPtr, FormatTimeSeconds_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, FormatTimeSeconds_ReturnValue_Offset), 0, FormatTimeSeconds_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FormatTimeSeconds_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:FormatTimeAuto")]
	public unsafe static string FormatTimeAuto(double InDuration, int NumDigits)
	{
		if (!FormatTimeAuto_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:FormatTimeAuto");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FormatTimeAuto_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FormatTimeAuto_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, FormatTimeAuto_InDuration_Offset), 0, FormatTimeAuto_InDuration_PropertyAddress.Address, InDuration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, FormatTimeAuto_NumDigits_Offset), 0, FormatTimeAuto_NumDigits_PropertyAddress.Address, NumDigits);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FormatTimeAuto_FunctionAddress, intPtr, FormatTimeAuto_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, FormatTimeAuto_ReturnValue_Offset), 0, FormatTimeAuto_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FormatTimeAuto_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:ExtractDateTimeInfo")]
	public unsafe static string ExtractDateTimeInfo(string InString)
	{
		if (!ExtractDateTimeInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:ExtractDateTimeInfo");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractDateTimeInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractDateTimeInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExtractDateTimeInfo_InString_Offset), 0, ExtractDateTimeInfo_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExtractDateTimeInfo_FunctionAddress, intPtr, ExtractDateTimeInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExtractDateTimeInfo_InString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ExtractDateTimeInfo_ReturnValue_Offset), 0, ExtractDateTimeInfo_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExtractDateTimeInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:ExportStatsCapturedReport")]
	public unsafe static void ExportStatsCapturedReport(List<FGSPathPointStatInfo> InPathPointStatsInfo, string InFileName, bool bAppend, bool bOutputHeader)
	{
		if (!ExportStatsCapturedReport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:ExportStatsCapturedReport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportStatsCapturedReport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportStatsCapturedReport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FGSPathPointStatInfo>(1, ExportStatsCapturedReport_InPathPointStatsInfo_PropertyAddress, CachedMarshalingDelegates<FGSPathPointStatInfo, FGSPathPointStatInfo>.FromNative, CachedMarshalingDelegates<FGSPathPointStatInfo, FGSPathPointStatInfo>.ToNative).ToNative(IntPtr.Add(intPtr, ExportStatsCapturedReport_InPathPointStatsInfo_Offset), InPathPointStatsInfo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportStatsCapturedReport_InFileName_Offset), 0, ExportStatsCapturedReport_InFileName_PropertyAddress.Address, InFileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportStatsCapturedReport_bAppend_Offset), 0, ExportStatsCapturedReport_bAppend_PropertyAddress.Address, bAppend);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportStatsCapturedReport_bOutputHeader_Offset), 0, ExportStatsCapturedReport_bOutputHeader_PropertyAddress.Address, bOutputHeader);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportStatsCapturedReport_FunctionAddress, intPtr, ExportStatsCapturedReport_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportStatsCapturedReport_InPathPointStatsInfo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportStatsCapturedReport_InFileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:ExportCapturedInfoBatch")]
	public unsafe static bool ExportCapturedInfoBatch(int BatchSize, int TotalPointNum, List<FGSPathPointStatInfo> InPathPointStatsInfo, string InFileName, bool bLastBatch, bool bOutputHeader)
	{
		if (!ExportCapturedInfoBatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:ExportCapturedInfoBatch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportCapturedInfoBatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportCapturedInfoBatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExportCapturedInfoBatch_BatchSize_Offset), 0, ExportCapturedInfoBatch_BatchSize_PropertyAddress.Address, BatchSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExportCapturedInfoBatch_TotalPointNum_Offset), 0, ExportCapturedInfoBatch_TotalPointNum_PropertyAddress.Address, TotalPointNum);
		new TArrayCopyMarshaler<FGSPathPointStatInfo>(1, ExportCapturedInfoBatch_InPathPointStatsInfo_PropertyAddress, CachedMarshalingDelegates<FGSPathPointStatInfo, FGSPathPointStatInfo>.FromNative, CachedMarshalingDelegates<FGSPathPointStatInfo, FGSPathPointStatInfo>.ToNative).ToNative(IntPtr.Add(intPtr, ExportCapturedInfoBatch_InPathPointStatsInfo_Offset), InPathPointStatsInfo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportCapturedInfoBatch_InFileName_Offset), 0, ExportCapturedInfoBatch_InFileName_PropertyAddress.Address, InFileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportCapturedInfoBatch_bLastBatch_Offset), 0, ExportCapturedInfoBatch_bLastBatch_PropertyAddress.Address, bLastBatch);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportCapturedInfoBatch_bOutputHeader_Offset), 0, ExportCapturedInfoBatch_bOutputHeader_PropertyAddress.Address, bOutputHeader);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportCapturedInfoBatch_FunctionAddress, intPtr, ExportCapturedInfoBatch_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportCapturedInfoBatch_InPathPointStatsInfo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportCapturedInfoBatch_InFileName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportCapturedInfoBatch_ReturnValue_Offset), 0, ExportCapturedInfoBatch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:AppendOfflinePathPoints")]
	public unsafe static void AppendOfflinePathPoints(List<FVector> InPoints, string InFilePathUnderProjFolder)
	{
		if (!AppendOfflinePathPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:AppendOfflinePathPoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendOfflinePathPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendOfflinePathPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, AppendOfflinePathPoints_InPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, AppendOfflinePathPoints_InPoints_Offset), InPoints);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AppendOfflinePathPoints_InFilePathUnderProjFolder_Offset), 0, AppendOfflinePathPoints_InFilePathUnderProjFolder_PropertyAddress.Address, InFilePathUnderProjFolder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendOfflinePathPoints_FunctionAddress, intPtr, AppendOfflinePathPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendOfflinePathPoints_InPoints_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AppendOfflinePathPoints_InFilePathUnderProjFolder_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:AppendHeaderToCapturedReport")]
	public unsafe static void AppendHeaderToCapturedReport(List<string> CapturedInfoNameList, string InFileName)
	{
		if (!AppendHeaderToCapturedReport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:AppendHeaderToCapturedReport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendHeaderToCapturedReport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendHeaderToCapturedReport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, AppendHeaderToCapturedReport_CapturedInfoNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AppendHeaderToCapturedReport_CapturedInfoNameList_Offset), CapturedInfoNameList);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AppendHeaderToCapturedReport_InFileName_Offset), 0, AppendHeaderToCapturedReport_InFileName_PropertyAddress.Address, InFileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendHeaderToCapturedReport_FunctionAddress, intPtr, AppendHeaderToCapturedReport_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendHeaderToCapturedReport_CapturedInfoNameList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AppendHeaderToCapturedReport_InFileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementUtil:AppendGeneralStatisticsToCapturedReport")]
	public unsafe static void AppendGeneralStatisticsToCapturedReport(string InFileName, int MetricsNum, int PointNum)
	{
		if (!AppendGeneralStatisticsToCapturedReport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementUtil:AppendGeneralStatisticsToCapturedReport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendGeneralStatisticsToCapturedReport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendGeneralStatisticsToCapturedReport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AppendGeneralStatisticsToCapturedReport_InFileName_Offset), 0, AppendGeneralStatisticsToCapturedReport_InFileName_PropertyAddress.Address, InFileName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendGeneralStatisticsToCapturedReport_MetricsNum_Offset), 0, AppendGeneralStatisticsToCapturedReport_MetricsNum_PropertyAddress.Address, MetricsNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendGeneralStatisticsToCapturedReport_PointNum_Offset), 0, AppendGeneralStatisticsToCapturedReport_PointNum_PropertyAddress.Address, PointNum);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendGeneralStatisticsToCapturedReport_FunctionAddress, intPtr, AppendGeneralStatisticsToCapturedReport_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendGeneralStatisticsToCapturedReport_InFileName_PropertyAddress.Address, intPtr);
	}

	static UAutoMovementUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutoMovementUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutoMovementUtil));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.AutoMovementUtil");
		SetVfxAutoPlayerRootFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVfxAutoPlayerRootFolderPath");
		SetVfxAutoPlayerRootFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVfxAutoPlayerRootFolderPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVfxAutoPlayerRootFolderPath_InRootFolderPath_PropertyAddress, SetVfxAutoPlayerRootFolderPath_FunctionAddress, "InRootFolderPath");
		SetVfxAutoPlayerRootFolderPath_InRootFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(SetVfxAutoPlayerRootFolderPath_FunctionAddress, "InRootFolderPath");
		SetVfxAutoPlayerRootFolderPath_InRootFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVfxAutoPlayerRootFolderPath_FunctionAddress, "InRootFolderPath", Classes.FStrProperty);
		SetVfxAutoPlayerRootFolderPath_IsValid = SetVfxAutoPlayerRootFolderPath_FunctionAddress != IntPtr.Zero && SetVfxAutoPlayerRootFolderPath_InRootFolderPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:SetVfxAutoPlayerRootFolderPath", SetVfxAutoPlayerRootFolderPath_IsValid);
		SaveOfflinePathPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveOfflinePathPoints");
		SaveOfflinePathPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveOfflinePathPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveOfflinePathPoints_InPoints_PropertyAddress, SaveOfflinePathPoints_FunctionAddress, "InPoints");
		SaveOfflinePathPoints_InPoints_Offset = NativeReflectionCached.GetPropertyOffset(SaveOfflinePathPoints_FunctionAddress, "InPoints");
		SaveOfflinePathPoints_InPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveOfflinePathPoints_FunctionAddress, "InPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveOfflinePathPoints_InFilePathUnderProjFolder_PropertyAddress, SaveOfflinePathPoints_FunctionAddress, "InFilePathUnderProjFolder");
		SaveOfflinePathPoints_InFilePathUnderProjFolder_Offset = NativeReflectionCached.GetPropertyOffset(SaveOfflinePathPoints_FunctionAddress, "InFilePathUnderProjFolder");
		SaveOfflinePathPoints_InFilePathUnderProjFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveOfflinePathPoints_FunctionAddress, "InFilePathUnderProjFolder", Classes.FStrProperty);
		SaveOfflinePathPoints_IsValid = SaveOfflinePathPoints_FunctionAddress != IntPtr.Zero && SaveOfflinePathPoints_InPoints_IsValid && SaveOfflinePathPoints_InFilePathUnderProjFolder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:SaveOfflinePathPoints", SaveOfflinePathPoints_IsValid);
		MergeMultiTextureMipReports_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MergeMultiTextureMipReports");
		MergeMultiTextureMipReports_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeMultiTextureMipReports_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeMultiTextureMipReports_InReportFilePaths_PropertyAddress, MergeMultiTextureMipReports_FunctionAddress, "InReportFilePaths");
		MergeMultiTextureMipReports_InReportFilePaths_Offset = NativeReflectionCached.GetPropertyOffset(MergeMultiTextureMipReports_FunctionAddress, "InReportFilePaths");
		MergeMultiTextureMipReports_InReportFilePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMultiTextureMipReports_FunctionAddress, "InReportFilePaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeMultiTextureMipReports_OutputMergedFileName_PropertyAddress, MergeMultiTextureMipReports_FunctionAddress, "OutputMergedFileName");
		MergeMultiTextureMipReports_OutputMergedFileName_Offset = NativeReflectionCached.GetPropertyOffset(MergeMultiTextureMipReports_FunctionAddress, "OutputMergedFileName");
		MergeMultiTextureMipReports_OutputMergedFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMultiTextureMipReports_FunctionAddress, "OutputMergedFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeMultiTextureMipReports_ReturnValue_PropertyAddress, MergeMultiTextureMipReports_FunctionAddress, "ReturnValue");
		MergeMultiTextureMipReports_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MergeMultiTextureMipReports_FunctionAddress, "ReturnValue");
		MergeMultiTextureMipReports_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMultiTextureMipReports_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MergeMultiTextureMipReports_IsValid = MergeMultiTextureMipReports_FunctionAddress != IntPtr.Zero && MergeMultiTextureMipReports_InReportFilePaths_IsValid && MergeMultiTextureMipReports_OutputMergedFileName_IsValid && MergeMultiTextureMipReports_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:MergeMultiTextureMipReports", MergeMultiTextureMipReports_IsValid);
		MergeMipReportsWithFileNameKeyword_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MergeMipReportsWithFileNameKeyword");
		MergeMipReportsWithFileNameKeyword_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeMipReportsWithFileNameKeyword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_PropertyAddress, MergeMipReportsWithFileNameKeyword_FunctionAddress, "InDirectoryUnderProjDir");
		MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_Offset = NativeReflectionCached.GetPropertyOffset(MergeMipReportsWithFileNameKeyword_FunctionAddress, "InDirectoryUnderProjDir");
		MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMipReportsWithFileNameKeyword_FunctionAddress, "InDirectoryUnderProjDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeMipReportsWithFileNameKeyword_InFileNameKeyword_PropertyAddress, MergeMipReportsWithFileNameKeyword_FunctionAddress, "InFileNameKeyword");
		MergeMipReportsWithFileNameKeyword_InFileNameKeyword_Offset = NativeReflectionCached.GetPropertyOffset(MergeMipReportsWithFileNameKeyword_FunctionAddress, "InFileNameKeyword");
		MergeMipReportsWithFileNameKeyword_InFileNameKeyword_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMipReportsWithFileNameKeyword_FunctionAddress, "InFileNameKeyword", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeMipReportsWithFileNameKeyword_OutputMergedFileName_PropertyAddress, MergeMipReportsWithFileNameKeyword_FunctionAddress, "OutputMergedFileName");
		MergeMipReportsWithFileNameKeyword_OutputMergedFileName_Offset = NativeReflectionCached.GetPropertyOffset(MergeMipReportsWithFileNameKeyword_FunctionAddress, "OutputMergedFileName");
		MergeMipReportsWithFileNameKeyword_OutputMergedFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMipReportsWithFileNameKeyword_FunctionAddress, "OutputMergedFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeMipReportsWithFileNameKeyword_ReturnValue_PropertyAddress, MergeMipReportsWithFileNameKeyword_FunctionAddress, "ReturnValue");
		MergeMipReportsWithFileNameKeyword_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MergeMipReportsWithFileNameKeyword_FunctionAddress, "ReturnValue");
		MergeMipReportsWithFileNameKeyword_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMipReportsWithFileNameKeyword_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MergeMipReportsWithFileNameKeyword_IsValid = MergeMipReportsWithFileNameKeyword_FunctionAddress != IntPtr.Zero && MergeMipReportsWithFileNameKeyword_InDirectoryUnderProjDir_IsValid && MergeMipReportsWithFileNameKeyword_InFileNameKeyword_IsValid && MergeMipReportsWithFileNameKeyword_OutputMergedFileName_IsValid && MergeMipReportsWithFileNameKeyword_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:MergeMipReportsWithFileNameKeyword", MergeMipReportsWithFileNameKeyword_IsValid);
		LoadStatsCapturerReport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadStatsCapturerReport");
		LoadStatsCapturerReport_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadStatsCapturerReport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadStatsCapturerReport_InFileNameUnderProjFolder_PropertyAddress, LoadStatsCapturerReport_FunctionAddress, "InFileNameUnderProjFolder");
		LoadStatsCapturerReport_InFileNameUnderProjFolder_Offset = NativeReflectionCached.GetPropertyOffset(LoadStatsCapturerReport_FunctionAddress, "InFileNameUnderProjFolder");
		LoadStatsCapturerReport_InFileNameUnderProjFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadStatsCapturerReport_FunctionAddress, "InFileNameUnderProjFolder", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadStatsCapturerReport_AllPathPointStatInfo_PropertyAddress, LoadStatsCapturerReport_FunctionAddress, "AllPathPointStatInfo");
		LoadStatsCapturerReport_AllPathPointStatInfo_Offset = NativeReflectionCached.GetPropertyOffset(LoadStatsCapturerReport_FunctionAddress, "AllPathPointStatInfo");
		LoadStatsCapturerReport_AllPathPointStatInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadStatsCapturerReport_FunctionAddress, "AllPathPointStatInfo", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadStatsCapturerReport_PointNum_PropertyAddress, LoadStatsCapturerReport_FunctionAddress, "PointNum");
		LoadStatsCapturerReport_PointNum_Offset = NativeReflectionCached.GetPropertyOffset(LoadStatsCapturerReport_FunctionAddress, "PointNum");
		LoadStatsCapturerReport_PointNum_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadStatsCapturerReport_FunctionAddress, "PointNum", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadStatsCapturerReport_ReturnValue_PropertyAddress, LoadStatsCapturerReport_FunctionAddress, "ReturnValue");
		LoadStatsCapturerReport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadStatsCapturerReport_FunctionAddress, "ReturnValue");
		LoadStatsCapturerReport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadStatsCapturerReport_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LoadStatsCapturerReport_IsValid = LoadStatsCapturerReport_FunctionAddress != IntPtr.Zero && LoadStatsCapturerReport_InFileNameUnderProjFolder_IsValid && LoadStatsCapturerReport_AllPathPointStatInfo_IsValid && LoadStatsCapturerReport_PointNum_IsValid && LoadStatsCapturerReport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:LoadStatsCapturerReport", LoadStatsCapturerReport_IsValid);
		InsertIntoCapturedInfoArrayPerPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InsertIntoCapturedInfoArrayPerPoint");
		InsertIntoCapturedInfoArrayPerPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(InsertIntoCapturedInfoArrayPerPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_PropertyAddress, InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "RawCapturedData");
		InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_Offset = NativeReflectionCached.GetPropertyOffset(InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "RawCapturedData");
		InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "RawCapturedData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_PropertyAddress, InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "CapturedInfoArrayPerPoint");
		InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_Offset = NativeReflectionCached.GetPropertyOffset(InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "CapturedInfoArrayPerPoint");
		InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "CapturedInfoArrayPerPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertIntoCapturedInfoArrayPerPoint_ReturnValue_PropertyAddress, InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "ReturnValue");
		InsertIntoCapturedInfoArrayPerPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "ReturnValue");
		InsertIntoCapturedInfoArrayPerPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertIntoCapturedInfoArrayPerPoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		InsertIntoCapturedInfoArrayPerPoint_IsValid = InsertIntoCapturedInfoArrayPerPoint_FunctionAddress != IntPtr.Zero && InsertIntoCapturedInfoArrayPerPoint_RawCapturedData_IsValid && InsertIntoCapturedInfoArrayPerPoint_CapturedInfoArrayPerPoint_IsValid && InsertIntoCapturedInfoArrayPerPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:InsertIntoCapturedInfoArrayPerPoint", InsertIntoCapturedInfoArrayPerPoint_IsValid);
		GetVfxAutoPlayerRootFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVfxAutoPlayerRootFolderPath");
		GetVfxAutoPlayerRootFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVfxAutoPlayerRootFolderPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVfxAutoPlayerRootFolderPath_ReturnValue_PropertyAddress, GetVfxAutoPlayerRootFolderPath_FunctionAddress, "ReturnValue");
		GetVfxAutoPlayerRootFolderPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVfxAutoPlayerRootFolderPath_FunctionAddress, "ReturnValue");
		GetVfxAutoPlayerRootFolderPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVfxAutoPlayerRootFolderPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetVfxAutoPlayerRootFolderPath_IsValid = GetVfxAutoPlayerRootFolderPath_FunctionAddress != IntPtr.Zero && GetVfxAutoPlayerRootFolderPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:GetVfxAutoPlayerRootFolderPath", GetVfxAutoPlayerRootFolderPath_IsValid);
		GetOfflinePathPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOfflinePathPoints");
		GetOfflinePathPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOfflinePathPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOfflinePathPoints_InFilePathUnderProjDir_PropertyAddress, GetOfflinePathPoints_FunctionAddress, "InFilePathUnderProjDir");
		GetOfflinePathPoints_InFilePathUnderProjDir_Offset = NativeReflectionCached.GetPropertyOffset(GetOfflinePathPoints_FunctionAddress, "InFilePathUnderProjDir");
		GetOfflinePathPoints_InFilePathUnderProjDir_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOfflinePathPoints_FunctionAddress, "InFilePathUnderProjDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOfflinePathPoints_bUseSparsePoints_PropertyAddress, GetOfflinePathPoints_FunctionAddress, "bUseSparsePoints");
		GetOfflinePathPoints_bUseSparsePoints_Offset = NativeReflectionCached.GetPropertyOffset(GetOfflinePathPoints_FunctionAddress, "bUseSparsePoints");
		GetOfflinePathPoints_bUseSparsePoints_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOfflinePathPoints_FunctionAddress, "bUseSparsePoints", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOfflinePathPoints_ReturnValue_PropertyAddress, GetOfflinePathPoints_FunctionAddress, "ReturnValue");
		GetOfflinePathPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOfflinePathPoints_FunctionAddress, "ReturnValue");
		GetOfflinePathPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOfflinePathPoints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetOfflinePathPoints_IsValid = GetOfflinePathPoints_FunctionAddress != IntPtr.Zero && GetOfflinePathPoints_InFilePathUnderProjDir_IsValid && GetOfflinePathPoints_bUseSparsePoints_IsValid && GetOfflinePathPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:GetOfflinePathPoints", GetOfflinePathPoints_IsValid);
		GetNowTimestamp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNowTimestamp");
		GetNowTimestamp_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNowTimestamp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNowTimestamp_ReturnValue_PropertyAddress, GetNowTimestamp_FunctionAddress, "ReturnValue");
		GetNowTimestamp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNowTimestamp_FunctionAddress, "ReturnValue");
		GetNowTimestamp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNowTimestamp_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetNowTimestamp_IsValid = GetNowTimestamp_FunctionAddress != IntPtr.Zero && GetNowTimestamp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:GetNowTimestamp", GetNowTimestamp_IsValid);
		GetCurPointProcessedMetricsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurPointProcessedMetricsMap");
		GetCurPointProcessedMetricsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurPointProcessedMetricsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_PropertyAddress, GetCurPointProcessedMetricsMap_FunctionAddress, "InCapturedInfoPerPoint");
		GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetCurPointProcessedMetricsMap_FunctionAddress, "InCapturedInfoPerPoint");
		GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurPointProcessedMetricsMap_FunctionAddress, "InCapturedInfoPerPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurPointProcessedMetricsMap_ReturnValue_PropertyAddress, GetCurPointProcessedMetricsMap_FunctionAddress, "ReturnValue");
		GetCurPointProcessedMetricsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurPointProcessedMetricsMap_FunctionAddress, "ReturnValue");
		GetCurPointProcessedMetricsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurPointProcessedMetricsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetCurPointProcessedMetricsMap_IsValid = GetCurPointProcessedMetricsMap_FunctionAddress != IntPtr.Zero && GetCurPointProcessedMetricsMap_InCapturedInfoPerPoint_IsValid && GetCurPointProcessedMetricsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:GetCurPointProcessedMetricsMap", GetCurPointProcessedMetricsMap_IsValid);
		FromTimestamp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FromTimestamp");
		FromTimestamp_ParamsSize = NativeReflection.GetFunctionParamsSize(FromTimestamp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FromTimestamp_Time_PropertyAddress, FromTimestamp_FunctionAddress, "Time");
		FromTimestamp_Time_Offset = NativeReflectionCached.GetPropertyOffset(FromTimestamp_FunctionAddress, "Time");
		FromTimestamp_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(FromTimestamp_FunctionAddress, "Time", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref FromTimestamp_ReturnValue_PropertyAddress, FromTimestamp_FunctionAddress, "ReturnValue");
		FromTimestamp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FromTimestamp_FunctionAddress, "ReturnValue");
		FromTimestamp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FromTimestamp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FromTimestamp_IsValid = FromTimestamp_FunctionAddress != IntPtr.Zero && FromTimestamp_Time_IsValid && FromTimestamp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:FromTimestamp", FromTimestamp_IsValid);
		FormatTimeSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FormatTimeSeconds");
		FormatTimeSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(FormatTimeSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FormatTimeSeconds_InDuration_PropertyAddress, FormatTimeSeconds_FunctionAddress, "InDuration");
		FormatTimeSeconds_InDuration_Offset = NativeReflectionCached.GetPropertyOffset(FormatTimeSeconds_FunctionAddress, "InDuration");
		FormatTimeSeconds_InDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(FormatTimeSeconds_FunctionAddress, "InDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FormatTimeSeconds_ReturnValue_PropertyAddress, FormatTimeSeconds_FunctionAddress, "ReturnValue");
		FormatTimeSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FormatTimeSeconds_FunctionAddress, "ReturnValue");
		FormatTimeSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FormatTimeSeconds_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		FormatTimeSeconds_IsValid = FormatTimeSeconds_FunctionAddress != IntPtr.Zero && FormatTimeSeconds_InDuration_IsValid && FormatTimeSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:FormatTimeSeconds", FormatTimeSeconds_IsValid);
		FormatTimeAuto_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FormatTimeAuto");
		FormatTimeAuto_ParamsSize = NativeReflection.GetFunctionParamsSize(FormatTimeAuto_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FormatTimeAuto_InDuration_PropertyAddress, FormatTimeAuto_FunctionAddress, "InDuration");
		FormatTimeAuto_InDuration_Offset = NativeReflectionCached.GetPropertyOffset(FormatTimeAuto_FunctionAddress, "InDuration");
		FormatTimeAuto_InDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(FormatTimeAuto_FunctionAddress, "InDuration", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref FormatTimeAuto_NumDigits_PropertyAddress, FormatTimeAuto_FunctionAddress, "NumDigits");
		FormatTimeAuto_NumDigits_Offset = NativeReflectionCached.GetPropertyOffset(FormatTimeAuto_FunctionAddress, "NumDigits");
		FormatTimeAuto_NumDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(FormatTimeAuto_FunctionAddress, "NumDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FormatTimeAuto_ReturnValue_PropertyAddress, FormatTimeAuto_FunctionAddress, "ReturnValue");
		FormatTimeAuto_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FormatTimeAuto_FunctionAddress, "ReturnValue");
		FormatTimeAuto_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FormatTimeAuto_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		FormatTimeAuto_IsValid = FormatTimeAuto_FunctionAddress != IntPtr.Zero && FormatTimeAuto_InDuration_IsValid && FormatTimeAuto_NumDigits_IsValid && FormatTimeAuto_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:FormatTimeAuto", FormatTimeAuto_IsValid);
		ExtractDateTimeInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExtractDateTimeInfo");
		ExtractDateTimeInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractDateTimeInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractDateTimeInfo_InString_PropertyAddress, ExtractDateTimeInfo_FunctionAddress, "InString");
		ExtractDateTimeInfo_InString_Offset = NativeReflectionCached.GetPropertyOffset(ExtractDateTimeInfo_FunctionAddress, "InString");
		ExtractDateTimeInfo_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractDateTimeInfo_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractDateTimeInfo_ReturnValue_PropertyAddress, ExtractDateTimeInfo_FunctionAddress, "ReturnValue");
		ExtractDateTimeInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExtractDateTimeInfo_FunctionAddress, "ReturnValue");
		ExtractDateTimeInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractDateTimeInfo_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ExtractDateTimeInfo_IsValid = ExtractDateTimeInfo_FunctionAddress != IntPtr.Zero && ExtractDateTimeInfo_InString_IsValid && ExtractDateTimeInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:ExtractDateTimeInfo", ExtractDateTimeInfo_IsValid);
		ExportStatsCapturedReport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportStatsCapturedReport");
		ExportStatsCapturedReport_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportStatsCapturedReport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportStatsCapturedReport_InPathPointStatsInfo_PropertyAddress, ExportStatsCapturedReport_FunctionAddress, "InPathPointStatsInfo");
		ExportStatsCapturedReport_InPathPointStatsInfo_Offset = NativeReflectionCached.GetPropertyOffset(ExportStatsCapturedReport_FunctionAddress, "InPathPointStatsInfo");
		ExportStatsCapturedReport_InPathPointStatsInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportStatsCapturedReport_FunctionAddress, "InPathPointStatsInfo", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportStatsCapturedReport_InFileName_PropertyAddress, ExportStatsCapturedReport_FunctionAddress, "InFileName");
		ExportStatsCapturedReport_InFileName_Offset = NativeReflectionCached.GetPropertyOffset(ExportStatsCapturedReport_FunctionAddress, "InFileName");
		ExportStatsCapturedReport_InFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportStatsCapturedReport_FunctionAddress, "InFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportStatsCapturedReport_bAppend_PropertyAddress, ExportStatsCapturedReport_FunctionAddress, "bAppend");
		ExportStatsCapturedReport_bAppend_Offset = NativeReflectionCached.GetPropertyOffset(ExportStatsCapturedReport_FunctionAddress, "bAppend");
		ExportStatsCapturedReport_bAppend_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportStatsCapturedReport_FunctionAddress, "bAppend", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportStatsCapturedReport_bOutputHeader_PropertyAddress, ExportStatsCapturedReport_FunctionAddress, "bOutputHeader");
		ExportStatsCapturedReport_bOutputHeader_Offset = NativeReflectionCached.GetPropertyOffset(ExportStatsCapturedReport_FunctionAddress, "bOutputHeader");
		ExportStatsCapturedReport_bOutputHeader_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportStatsCapturedReport_FunctionAddress, "bOutputHeader", Classes.FBoolProperty);
		ExportStatsCapturedReport_IsValid = ExportStatsCapturedReport_FunctionAddress != IntPtr.Zero && ExportStatsCapturedReport_InPathPointStatsInfo_IsValid && ExportStatsCapturedReport_InFileName_IsValid && ExportStatsCapturedReport_bAppend_IsValid && ExportStatsCapturedReport_bOutputHeader_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:ExportStatsCapturedReport", ExportStatsCapturedReport_IsValid);
		ExportCapturedInfoBatch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportCapturedInfoBatch");
		ExportCapturedInfoBatch_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportCapturedInfoBatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportCapturedInfoBatch_BatchSize_PropertyAddress, ExportCapturedInfoBatch_FunctionAddress, "BatchSize");
		ExportCapturedInfoBatch_BatchSize_Offset = NativeReflectionCached.GetPropertyOffset(ExportCapturedInfoBatch_FunctionAddress, "BatchSize");
		ExportCapturedInfoBatch_BatchSize_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportCapturedInfoBatch_FunctionAddress, "BatchSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportCapturedInfoBatch_TotalPointNum_PropertyAddress, ExportCapturedInfoBatch_FunctionAddress, "TotalPointNum");
		ExportCapturedInfoBatch_TotalPointNum_Offset = NativeReflectionCached.GetPropertyOffset(ExportCapturedInfoBatch_FunctionAddress, "TotalPointNum");
		ExportCapturedInfoBatch_TotalPointNum_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportCapturedInfoBatch_FunctionAddress, "TotalPointNum", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportCapturedInfoBatch_InPathPointStatsInfo_PropertyAddress, ExportCapturedInfoBatch_FunctionAddress, "InPathPointStatsInfo");
		ExportCapturedInfoBatch_InPathPointStatsInfo_Offset = NativeReflectionCached.GetPropertyOffset(ExportCapturedInfoBatch_FunctionAddress, "InPathPointStatsInfo");
		ExportCapturedInfoBatch_InPathPointStatsInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportCapturedInfoBatch_FunctionAddress, "InPathPointStatsInfo", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportCapturedInfoBatch_InFileName_PropertyAddress, ExportCapturedInfoBatch_FunctionAddress, "InFileName");
		ExportCapturedInfoBatch_InFileName_Offset = NativeReflectionCached.GetPropertyOffset(ExportCapturedInfoBatch_FunctionAddress, "InFileName");
		ExportCapturedInfoBatch_InFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportCapturedInfoBatch_FunctionAddress, "InFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportCapturedInfoBatch_bLastBatch_PropertyAddress, ExportCapturedInfoBatch_FunctionAddress, "bLastBatch");
		ExportCapturedInfoBatch_bLastBatch_Offset = NativeReflectionCached.GetPropertyOffset(ExportCapturedInfoBatch_FunctionAddress, "bLastBatch");
		ExportCapturedInfoBatch_bLastBatch_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportCapturedInfoBatch_FunctionAddress, "bLastBatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportCapturedInfoBatch_bOutputHeader_PropertyAddress, ExportCapturedInfoBatch_FunctionAddress, "bOutputHeader");
		ExportCapturedInfoBatch_bOutputHeader_Offset = NativeReflectionCached.GetPropertyOffset(ExportCapturedInfoBatch_FunctionAddress, "bOutputHeader");
		ExportCapturedInfoBatch_bOutputHeader_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportCapturedInfoBatch_FunctionAddress, "bOutputHeader", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportCapturedInfoBatch_ReturnValue_PropertyAddress, ExportCapturedInfoBatch_FunctionAddress, "ReturnValue");
		ExportCapturedInfoBatch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportCapturedInfoBatch_FunctionAddress, "ReturnValue");
		ExportCapturedInfoBatch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportCapturedInfoBatch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportCapturedInfoBatch_IsValid = ExportCapturedInfoBatch_FunctionAddress != IntPtr.Zero && ExportCapturedInfoBatch_BatchSize_IsValid && ExportCapturedInfoBatch_TotalPointNum_IsValid && ExportCapturedInfoBatch_InPathPointStatsInfo_IsValid && ExportCapturedInfoBatch_InFileName_IsValid && ExportCapturedInfoBatch_bLastBatch_IsValid && ExportCapturedInfoBatch_bOutputHeader_IsValid && ExportCapturedInfoBatch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:ExportCapturedInfoBatch", ExportCapturedInfoBatch_IsValid);
		AppendOfflinePathPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendOfflinePathPoints");
		AppendOfflinePathPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendOfflinePathPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendOfflinePathPoints_InPoints_PropertyAddress, AppendOfflinePathPoints_FunctionAddress, "InPoints");
		AppendOfflinePathPoints_InPoints_Offset = NativeReflectionCached.GetPropertyOffset(AppendOfflinePathPoints_FunctionAddress, "InPoints");
		AppendOfflinePathPoints_InPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendOfflinePathPoints_FunctionAddress, "InPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendOfflinePathPoints_InFilePathUnderProjFolder_PropertyAddress, AppendOfflinePathPoints_FunctionAddress, "InFilePathUnderProjFolder");
		AppendOfflinePathPoints_InFilePathUnderProjFolder_Offset = NativeReflectionCached.GetPropertyOffset(AppendOfflinePathPoints_FunctionAddress, "InFilePathUnderProjFolder");
		AppendOfflinePathPoints_InFilePathUnderProjFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendOfflinePathPoints_FunctionAddress, "InFilePathUnderProjFolder", Classes.FStrProperty);
		AppendOfflinePathPoints_IsValid = AppendOfflinePathPoints_FunctionAddress != IntPtr.Zero && AppendOfflinePathPoints_InPoints_IsValid && AppendOfflinePathPoints_InFilePathUnderProjFolder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:AppendOfflinePathPoints", AppendOfflinePathPoints_IsValid);
		AppendHeaderToCapturedReport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendHeaderToCapturedReport");
		AppendHeaderToCapturedReport_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendHeaderToCapturedReport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendHeaderToCapturedReport_CapturedInfoNameList_PropertyAddress, AppendHeaderToCapturedReport_FunctionAddress, "CapturedInfoNameList");
		AppendHeaderToCapturedReport_CapturedInfoNameList_Offset = NativeReflectionCached.GetPropertyOffset(AppendHeaderToCapturedReport_FunctionAddress, "CapturedInfoNameList");
		AppendHeaderToCapturedReport_CapturedInfoNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendHeaderToCapturedReport_FunctionAddress, "CapturedInfoNameList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendHeaderToCapturedReport_InFileName_PropertyAddress, AppendHeaderToCapturedReport_FunctionAddress, "InFileName");
		AppendHeaderToCapturedReport_InFileName_Offset = NativeReflectionCached.GetPropertyOffset(AppendHeaderToCapturedReport_FunctionAddress, "InFileName");
		AppendHeaderToCapturedReport_InFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendHeaderToCapturedReport_FunctionAddress, "InFileName", Classes.FStrProperty);
		AppendHeaderToCapturedReport_IsValid = AppendHeaderToCapturedReport_FunctionAddress != IntPtr.Zero && AppendHeaderToCapturedReport_CapturedInfoNameList_IsValid && AppendHeaderToCapturedReport_InFileName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:AppendHeaderToCapturedReport", AppendHeaderToCapturedReport_IsValid);
		AppendGeneralStatisticsToCapturedReport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendGeneralStatisticsToCapturedReport");
		AppendGeneralStatisticsToCapturedReport_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendGeneralStatisticsToCapturedReport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendGeneralStatisticsToCapturedReport_InFileName_PropertyAddress, AppendGeneralStatisticsToCapturedReport_FunctionAddress, "InFileName");
		AppendGeneralStatisticsToCapturedReport_InFileName_Offset = NativeReflectionCached.GetPropertyOffset(AppendGeneralStatisticsToCapturedReport_FunctionAddress, "InFileName");
		AppendGeneralStatisticsToCapturedReport_InFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendGeneralStatisticsToCapturedReport_FunctionAddress, "InFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendGeneralStatisticsToCapturedReport_MetricsNum_PropertyAddress, AppendGeneralStatisticsToCapturedReport_FunctionAddress, "MetricsNum");
		AppendGeneralStatisticsToCapturedReport_MetricsNum_Offset = NativeReflectionCached.GetPropertyOffset(AppendGeneralStatisticsToCapturedReport_FunctionAddress, "MetricsNum");
		AppendGeneralStatisticsToCapturedReport_MetricsNum_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendGeneralStatisticsToCapturedReport_FunctionAddress, "MetricsNum", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendGeneralStatisticsToCapturedReport_PointNum_PropertyAddress, AppendGeneralStatisticsToCapturedReport_FunctionAddress, "PointNum");
		AppendGeneralStatisticsToCapturedReport_PointNum_Offset = NativeReflectionCached.GetPropertyOffset(AppendGeneralStatisticsToCapturedReport_FunctionAddress, "PointNum");
		AppendGeneralStatisticsToCapturedReport_PointNum_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendGeneralStatisticsToCapturedReport_FunctionAddress, "PointNum", Classes.FIntProperty);
		AppendGeneralStatisticsToCapturedReport_IsValid = AppendGeneralStatisticsToCapturedReport_FunctionAddress != IntPtr.Zero && AppendGeneralStatisticsToCapturedReport_InFileName_IsValid && AppendGeneralStatisticsToCapturedReport_MetricsNum_IsValid && AppendGeneralStatisticsToCapturedReport_PointNum_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementUtil:AppendGeneralStatisticsToCapturedReport", AppendGeneralStatisticsToCapturedReport_IsValid);
	}
}
