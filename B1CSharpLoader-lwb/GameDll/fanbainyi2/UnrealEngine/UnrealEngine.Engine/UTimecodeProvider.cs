using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[UMetaPath("/Script/Engine.TimecodeProvider", "Engine", UnrealModuleType.Engine)]
public class UTimecodeProvider : UObject
{
	private static bool GetTimecode_IsValid;

	private static IntPtr GetTimecode_FunctionAddress;

	private static int GetTimecode_ParamsSize;

	private static bool GetTimecode_ReturnValue_IsValid;

	private static FFieldAddress GetTimecode_ReturnValue_PropertyAddress;

	private static int GetTimecode_ReturnValue_Offset;

	private static bool GetSynchronizationState_IsValid;

	private static IntPtr GetSynchronizationState_FunctionAddress;

	private static int GetSynchronizationState_ParamsSize;

	private static bool GetSynchronizationState_ReturnValue_IsValid;

	private static FFieldAddress GetSynchronizationState_ReturnValue_PropertyAddress;

	private static int GetSynchronizationState_ReturnValue_Offset;

	private static bool GetQualifiedFrameTime_IsValid;

	private static IntPtr GetQualifiedFrameTime_FunctionAddress;

	private static int GetQualifiedFrameTime_ParamsSize;

	private static bool GetQualifiedFrameTime_ReturnValue_IsValid;

	private static FFieldAddress GetQualifiedFrameTime_ReturnValue_PropertyAddress;

	private static int GetQualifiedFrameTime_ReturnValue_Offset;

	private static bool GetFrameRate_IsValid;

	private static IntPtr GetFrameRate_FunctionAddress;

	private static int GetFrameRate_ParamsSize;

	private static bool GetFrameRate_ReturnValue_IsValid;

	private static FFieldAddress GetFrameRate_ReturnValue_PropertyAddress;

	private static int GetFrameRate_ReturnValue_Offset;

	private static bool GetDelayedTimecode_IsValid;

	private static IntPtr GetDelayedTimecode_FunctionAddress;

	private static int GetDelayedTimecode_ParamsSize;

	private static bool GetDelayedTimecode_ReturnValue_IsValid;

	private static FFieldAddress GetDelayedTimecode_ReturnValue_PropertyAddress;

	private static int GetDelayedTimecode_ReturnValue_Offset;

	private static bool GetDelayedQualifiedFrameTime_IsValid;

	private static IntPtr GetDelayedQualifiedFrameTime_FunctionAddress;

	private static int GetDelayedQualifiedFrameTime_ParamsSize;

	private static bool GetDelayedQualifiedFrameTime_ReturnValue_IsValid;

	private static FFieldAddress GetDelayedQualifiedFrameTime_ReturnValue_PropertyAddress;

	private static int GetDelayedQualifiedFrameTime_ReturnValue_Offset;

	private static bool FetchTimecode_IsValid;

	private static IntPtr FetchTimecode_FunctionAddress;

	private static int FetchTimecode_ParamsSize;

	private static bool FetchTimecode_OutFrameTime_IsValid;

	private static FFieldAddress FetchTimecode_OutFrameTime_PropertyAddress;

	private static int FetchTimecode_OutFrameTime_Offset;

	private static bool FetchTimecode_ReturnValue_IsValid;

	private static FFieldAddress FetchTimecode_ReturnValue_PropertyAddress;

	private static int FetchTimecode_ReturnValue_Offset;

	private static bool FetchAndUpdate_IsValid;

	private static IntPtr FetchAndUpdate_FunctionAddress;

	private static int FetchAndUpdate_ParamsSize;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.TimecodeProvider:GetTimecode")]
	public unsafe FTimecode GetTimecode()
	{
		CheckDestroyed();
		if (!GetTimecode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimecodeProvider:GetTimecode");
			return default(FTimecode);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimecode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimecode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTimecode_FunctionAddress, intPtr, GetTimecode_ParamsSize);
		return FTimecode.FromNative(IntPtr.Add(intPtr, GetTimecode_ReturnValue_Offset), 0, GetTimecode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.TimecodeProvider:GetSynchronizationState")]
	public unsafe ETimecodeProviderSynchronizationState GetSynchronizationState()
	{
		CheckDestroyed();
		if (!GetSynchronizationState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimecodeProvider:GetSynchronizationState");
			return ETimecodeProviderSynchronizationState.Closed;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSynchronizationState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSynchronizationState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSynchronizationState_FunctionAddress, intPtr, GetSynchronizationState_ParamsSize);
		return EnumMarshaler<ETimecodeProviderSynchronizationState>.FromNative(IntPtr.Add(intPtr, GetSynchronizationState_ReturnValue_Offset), 0, GetSynchronizationState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.TimecodeProvider:GetQualifiedFrameTime")]
	public unsafe FQualifiedTime GetQualifiedFrameTime()
	{
		CheckDestroyed();
		if (!GetQualifiedFrameTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimecodeProvider:GetQualifiedFrameTime");
			return default(FQualifiedTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQualifiedFrameTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQualifiedFrameTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQualifiedFrameTime_FunctionAddress, intPtr, GetQualifiedFrameTime_ParamsSize);
		return FQualifiedTime.FromNative(IntPtr.Add(intPtr, GetQualifiedFrameTime_ReturnValue_Offset), 0, GetQualifiedFrameTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.TimecodeProvider:GetFrameRate")]
	public unsafe FFrameRate GetFrameRate()
	{
		CheckDestroyed();
		if (!GetFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimecodeProvider:GetFrameRate");
			return default(FFrameRate);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFrameRate_FunctionAddress, intPtr, GetFrameRate_ParamsSize);
		return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(intPtr, GetFrameRate_ReturnValue_Offset), 0, GetFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.TimecodeProvider:GetDelayedTimecode")]
	public unsafe FTimecode GetDelayedTimecode()
	{
		CheckDestroyed();
		if (!GetDelayedTimecode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimecodeProvider:GetDelayedTimecode");
			return default(FTimecode);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDelayedTimecode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDelayedTimecode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDelayedTimecode_FunctionAddress, intPtr, GetDelayedTimecode_ParamsSize);
		return FTimecode.FromNative(IntPtr.Add(intPtr, GetDelayedTimecode_ReturnValue_Offset), 0, GetDelayedTimecode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.TimecodeProvider:GetDelayedQualifiedFrameTime")]
	public unsafe FQualifiedTime GetDelayedQualifiedFrameTime()
	{
		CheckDestroyed();
		if (!GetDelayedQualifiedFrameTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimecodeProvider:GetDelayedQualifiedFrameTime");
			return default(FQualifiedTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDelayedQualifiedFrameTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDelayedQualifiedFrameTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDelayedQualifiedFrameTime_FunctionAddress, intPtr, GetDelayedQualifiedFrameTime_ParamsSize);
		return FQualifiedTime.FromNative(IntPtr.Add(intPtr, GetDelayedQualifiedFrameTime_ReturnValue_Offset), 0, GetDelayedQualifiedFrameTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TimecodeProvider:FetchTimecode")]
	public unsafe bool FetchTimecode(out FQualifiedTime OutFrameTime)
	{
		CheckDestroyed();
		if (!FetchTimecode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimecodeProvider:FetchTimecode");
			OutFrameTime = default(FQualifiedTime);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FetchTimecode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FetchTimecode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FetchTimecode_OutFrameTime_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, FetchTimecode_FunctionAddress, intPtr, FetchTimecode_ParamsSize);
		OutFrameTime = FQualifiedTime.FromNative(IntPtr.Add(intPtr, FetchTimecode_OutFrameTime_Offset), 0, FetchTimecode_OutFrameTime_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FetchTimecode_ReturnValue_Offset), 0, FetchTimecode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.TimecodeProvider:FetchAndUpdate")]
	public unsafe void FetchAndUpdate()
	{
		CheckDestroyed();
		if (!FetchAndUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimecodeProvider:FetchAndUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FetchAndUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FetchAndUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FetchAndUpdate_FunctionAddress, argsSize: FetchAndUpdate_ParamsSize);
	}

	static UTimecodeProvider()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTimecodeProvider)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTimecodeProvider));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.TimecodeProvider");
		GetTimecode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTimecode");
		GetTimecode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimecode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimecode_ReturnValue_PropertyAddress, GetTimecode_FunctionAddress, "ReturnValue");
		GetTimecode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimecode_FunctionAddress, "ReturnValue");
		GetTimecode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimecode_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTimecode_IsValid = GetTimecode_FunctionAddress != IntPtr.Zero && GetTimecode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimecodeProvider:GetTimecode", GetTimecode_IsValid);
		GetSynchronizationState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSynchronizationState");
		GetSynchronizationState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSynchronizationState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSynchronizationState_ReturnValue_PropertyAddress, GetSynchronizationState_FunctionAddress, "ReturnValue");
		GetSynchronizationState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSynchronizationState_FunctionAddress, "ReturnValue");
		GetSynchronizationState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSynchronizationState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetSynchronizationState_IsValid = GetSynchronizationState_FunctionAddress != IntPtr.Zero && GetSynchronizationState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimecodeProvider:GetSynchronizationState", GetSynchronizationState_IsValid);
		GetQualifiedFrameTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetQualifiedFrameTime");
		GetQualifiedFrameTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQualifiedFrameTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQualifiedFrameTime_ReturnValue_PropertyAddress, GetQualifiedFrameTime_FunctionAddress, "ReturnValue");
		GetQualifiedFrameTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQualifiedFrameTime_FunctionAddress, "ReturnValue");
		GetQualifiedFrameTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQualifiedFrameTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetQualifiedFrameTime_IsValid = GetQualifiedFrameTime_FunctionAddress != IntPtr.Zero && GetQualifiedFrameTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimecodeProvider:GetQualifiedFrameTime", GetQualifiedFrameTime_IsValid);
		GetFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFrameRate");
		GetFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFrameRate_ReturnValue_PropertyAddress, GetFrameRate_FunctionAddress, "ReturnValue");
		GetFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameRate_FunctionAddress, "ReturnValue");
		GetFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFrameRate_IsValid = GetFrameRate_FunctionAddress != IntPtr.Zero && GetFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimecodeProvider:GetFrameRate", GetFrameRate_IsValid);
		GetDelayedTimecode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDelayedTimecode");
		GetDelayedTimecode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDelayedTimecode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDelayedTimecode_ReturnValue_PropertyAddress, GetDelayedTimecode_FunctionAddress, "ReturnValue");
		GetDelayedTimecode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDelayedTimecode_FunctionAddress, "ReturnValue");
		GetDelayedTimecode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDelayedTimecode_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDelayedTimecode_IsValid = GetDelayedTimecode_FunctionAddress != IntPtr.Zero && GetDelayedTimecode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimecodeProvider:GetDelayedTimecode", GetDelayedTimecode_IsValid);
		GetDelayedQualifiedFrameTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDelayedQualifiedFrameTime");
		GetDelayedQualifiedFrameTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDelayedQualifiedFrameTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDelayedQualifiedFrameTime_ReturnValue_PropertyAddress, GetDelayedQualifiedFrameTime_FunctionAddress, "ReturnValue");
		GetDelayedQualifiedFrameTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDelayedQualifiedFrameTime_FunctionAddress, "ReturnValue");
		GetDelayedQualifiedFrameTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDelayedQualifiedFrameTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDelayedQualifiedFrameTime_IsValid = GetDelayedQualifiedFrameTime_FunctionAddress != IntPtr.Zero && GetDelayedQualifiedFrameTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimecodeProvider:GetDelayedQualifiedFrameTime", GetDelayedQualifiedFrameTime_IsValid);
		FetchTimecode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FetchTimecode");
		FetchTimecode_ParamsSize = NativeReflection.GetFunctionParamsSize(FetchTimecode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FetchTimecode_OutFrameTime_PropertyAddress, FetchTimecode_FunctionAddress, "OutFrameTime");
		FetchTimecode_OutFrameTime_Offset = NativeReflectionCached.GetPropertyOffset(FetchTimecode_FunctionAddress, "OutFrameTime");
		FetchTimecode_OutFrameTime_IsValid = NativeReflectionCached.ValidatePropertyClass(FetchTimecode_FunctionAddress, "OutFrameTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FetchTimecode_ReturnValue_PropertyAddress, FetchTimecode_FunctionAddress, "ReturnValue");
		FetchTimecode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FetchTimecode_FunctionAddress, "ReturnValue");
		FetchTimecode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FetchTimecode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FetchTimecode_IsValid = FetchTimecode_FunctionAddress != IntPtr.Zero && FetchTimecode_OutFrameTime_IsValid && FetchTimecode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimecodeProvider:FetchTimecode", FetchTimecode_IsValid);
		FetchAndUpdate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FetchAndUpdate");
		FetchAndUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(FetchAndUpdate_FunctionAddress);
		FetchAndUpdate_IsValid = FetchAndUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimecodeProvider:FetchAndUpdate", FetchAndUpdate_IsValid);
	}
}
