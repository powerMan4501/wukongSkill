using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.HealthSnapshotBlueprintLibrary", "Engine", UnrealModuleType.Engine)]
public class UHealthSnapshotBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StopPerformanceSnapshots_IsValid;

	private static IntPtr StopPerformanceSnapshots_FunctionAddress;

	private static int StopPerformanceSnapshots_ParamsSize;

	private static bool StartPerformanceSnapshots_IsValid;

	private static IntPtr StartPerformanceSnapshots_FunctionAddress;

	private static int StartPerformanceSnapshots_ParamsSize;

	private static bool LogPerformanceSnapshot_IsValid;

	private static IntPtr LogPerformanceSnapshot_FunctionAddress;

	private static int LogPerformanceSnapshot_ParamsSize;

	private static bool LogPerformanceSnapshot_SnapshotTitle_IsValid;

	private static FFieldAddress LogPerformanceSnapshot_SnapshotTitle_PropertyAddress;

	private static int LogPerformanceSnapshot_SnapshotTitle_Offset;

	private static bool LogPerformanceSnapshot_bResetStats_IsValid;

	private static FFieldAddress LogPerformanceSnapshot_bResetStats_PropertyAddress;

	private static int LogPerformanceSnapshot_bResetStats_Offset;

	[UFunction(Flags = 67249665u)]
	[UMetaPath("/Script/Engine.HealthSnapshotBlueprintLibrary:StopPerformanceSnapshots")]
	public unsafe static void StopPerformanceSnapshots()
	{
		if (!StopPerformanceSnapshots_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HealthSnapshotBlueprintLibrary:StopPerformanceSnapshots");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopPerformanceSnapshots_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopPerformanceSnapshots_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StopPerformanceSnapshots_FunctionAddress, argsSize: StopPerformanceSnapshots_ParamsSize);
	}

	[UFunction(Flags = 67249665u)]
	[UMetaPath("/Script/Engine.HealthSnapshotBlueprintLibrary:StartPerformanceSnapshots")]
	public unsafe static void StartPerformanceSnapshots()
	{
		if (!StartPerformanceSnapshots_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HealthSnapshotBlueprintLibrary:StartPerformanceSnapshots");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPerformanceSnapshots_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPerformanceSnapshots_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StartPerformanceSnapshots_FunctionAddress, argsSize: StartPerformanceSnapshots_ParamsSize);
	}

	[UFunction(Flags = 67249665u)]
	[UMetaPath("/Script/Engine.HealthSnapshotBlueprintLibrary:LogPerformanceSnapshot")]
	public unsafe static void LogPerformanceSnapshot(string SnapshotTitle, bool bResetStats = true)
	{
		if (!LogPerformanceSnapshot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HealthSnapshotBlueprintLibrary:LogPerformanceSnapshot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogPerformanceSnapshot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogPerformanceSnapshot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogPerformanceSnapshot_SnapshotTitle_Offset), 0, LogPerformanceSnapshot_SnapshotTitle_PropertyAddress.Address, SnapshotTitle);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LogPerformanceSnapshot_bResetStats_Offset), 0, LogPerformanceSnapshot_bResetStats_PropertyAddress.Address, bResetStats);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogPerformanceSnapshot_FunctionAddress, intPtr, LogPerformanceSnapshot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogPerformanceSnapshot_SnapshotTitle_PropertyAddress.Address, intPtr);
	}

	static UHealthSnapshotBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHealthSnapshotBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHealthSnapshotBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.HealthSnapshotBlueprintLibrary");
		StopPerformanceSnapshots_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopPerformanceSnapshots");
		StopPerformanceSnapshots_ParamsSize = NativeReflection.GetFunctionParamsSize(StopPerformanceSnapshots_FunctionAddress);
		StopPerformanceSnapshots_IsValid = StopPerformanceSnapshots_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HealthSnapshotBlueprintLibrary:StopPerformanceSnapshots", StopPerformanceSnapshots_IsValid);
		StartPerformanceSnapshots_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartPerformanceSnapshots");
		StartPerformanceSnapshots_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPerformanceSnapshots_FunctionAddress);
		StartPerformanceSnapshots_IsValid = StartPerformanceSnapshots_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HealthSnapshotBlueprintLibrary:StartPerformanceSnapshots", StartPerformanceSnapshots_IsValid);
		LogPerformanceSnapshot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogPerformanceSnapshot");
		LogPerformanceSnapshot_ParamsSize = NativeReflection.GetFunctionParamsSize(LogPerformanceSnapshot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogPerformanceSnapshot_SnapshotTitle_PropertyAddress, LogPerformanceSnapshot_FunctionAddress, "SnapshotTitle");
		LogPerformanceSnapshot_SnapshotTitle_Offset = NativeReflectionCached.GetPropertyOffset(LogPerformanceSnapshot_FunctionAddress, "SnapshotTitle");
		LogPerformanceSnapshot_SnapshotTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(LogPerformanceSnapshot_FunctionAddress, "SnapshotTitle", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LogPerformanceSnapshot_bResetStats_PropertyAddress, LogPerformanceSnapshot_FunctionAddress, "bResetStats");
		LogPerformanceSnapshot_bResetStats_Offset = NativeReflectionCached.GetPropertyOffset(LogPerformanceSnapshot_FunctionAddress, "bResetStats");
		LogPerformanceSnapshot_bResetStats_IsValid = NativeReflectionCached.ValidatePropertyClass(LogPerformanceSnapshot_FunctionAddress, "bResetStats", Classes.FBoolProperty);
		LogPerformanceSnapshot_IsValid = LogPerformanceSnapshot_FunctionAddress != IntPtr.Zero && LogPerformanceSnapshot_SnapshotTitle_IsValid && LogPerformanceSnapshot_bResetStats_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HealthSnapshotBlueprintLibrary:LogPerformanceSnapshot", LogPerformanceSnapshot_IsValid);
	}
}
