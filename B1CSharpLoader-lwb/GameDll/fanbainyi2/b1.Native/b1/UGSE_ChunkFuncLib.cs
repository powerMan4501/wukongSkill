using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_ChunkFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_ChunkFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TryGetPlayGoInfo_IsValid;

	private static IntPtr TryGetPlayGoInfo_FunctionAddress;

	private static int TryGetPlayGoInfo_ParamsSize;

	private static bool TryGetPlayGoInfo_ProgressSize_IsValid;

	private static FFieldAddress TryGetPlayGoInfo_ProgressSize_PropertyAddress;

	private static int TryGetPlayGoInfo_ProgressSize_Offset;

	private static bool TryGetPlayGoInfo_TotalSize_IsValid;

	private static FFieldAddress TryGetPlayGoInfo_TotalSize_PropertyAddress;

	private static int TryGetPlayGoInfo_TotalSize_Offset;

	private static bool TryGetPlayGoInfo_CurrentTime_IsValid;

	private static FFieldAddress TryGetPlayGoInfo_CurrentTime_PropertyAddress;

	private static int TryGetPlayGoInfo_CurrentTime_Offset;

	private static bool TryGetPlayGoInfo_ReturnValue_IsValid;

	private static FFieldAddress TryGetPlayGoInfo_ReturnValue_PropertyAddress;

	private static int TryGetPlayGoInfo_ReturnValue_Offset;

	private static bool IsPlayGoInstalling_IsValid;

	private static IntPtr IsPlayGoInstalling_FunctionAddress;

	private static int IsPlayGoInstalling_ParamsSize;

	private static bool IsPlayGoInstalling_ReturnValue_IsValid;

	private static FFieldAddress IsPlayGoInstalling_ReturnValue_PropertyAddress;

	private static int IsPlayGoInstalling_ReturnValue_Offset;

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ChunkFuncLib:TryGetPlayGoInfo")]
	public unsafe static bool TryGetPlayGoInfo(out long ProgressSize, out long TotalSize, out double CurrentTime)
	{
		if (!TryGetPlayGoInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ChunkFuncLib:TryGetPlayGoInfo");
			ProgressSize = 0L;
			TotalSize = 0L;
			CurrentTime = 0.0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetPlayGoInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetPlayGoInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TryGetPlayGoInfo_FunctionAddress, intPtr, TryGetPlayGoInfo_ParamsSize);
		ProgressSize = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, TryGetPlayGoInfo_ProgressSize_Offset), 0, TryGetPlayGoInfo_ProgressSize_PropertyAddress.Address);
		TotalSize = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, TryGetPlayGoInfo_TotalSize_Offset), 0, TryGetPlayGoInfo_TotalSize_PropertyAddress.Address);
		CurrentTime = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, TryGetPlayGoInfo_CurrentTime_Offset), 0, TryGetPlayGoInfo_CurrentTime_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryGetPlayGoInfo_ReturnValue_Offset), 0, TryGetPlayGoInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ChunkFuncLib:IsPlayGoInstalling")]
	public unsafe static bool IsPlayGoInstalling()
	{
		if (!IsPlayGoInstalling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ChunkFuncLib:IsPlayGoInstalling");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayGoInstalling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayGoInstalling_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPlayGoInstalling_FunctionAddress, intPtr, IsPlayGoInstalling_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayGoInstalling_ReturnValue_Offset), 0, IsPlayGoInstalling_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_ChunkFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_ChunkFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_ChunkFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_ChunkFuncLib");
		TryGetPlayGoInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TryGetPlayGoInfo");
		TryGetPlayGoInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetPlayGoInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetPlayGoInfo_ProgressSize_PropertyAddress, TryGetPlayGoInfo_FunctionAddress, "ProgressSize");
		TryGetPlayGoInfo_ProgressSize_Offset = NativeReflectionCached.GetPropertyOffset(TryGetPlayGoInfo_FunctionAddress, "ProgressSize");
		TryGetPlayGoInfo_ProgressSize_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetPlayGoInfo_FunctionAddress, "ProgressSize", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref TryGetPlayGoInfo_TotalSize_PropertyAddress, TryGetPlayGoInfo_FunctionAddress, "TotalSize");
		TryGetPlayGoInfo_TotalSize_Offset = NativeReflectionCached.GetPropertyOffset(TryGetPlayGoInfo_FunctionAddress, "TotalSize");
		TryGetPlayGoInfo_TotalSize_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetPlayGoInfo_FunctionAddress, "TotalSize", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref TryGetPlayGoInfo_CurrentTime_PropertyAddress, TryGetPlayGoInfo_FunctionAddress, "CurrentTime");
		TryGetPlayGoInfo_CurrentTime_Offset = NativeReflectionCached.GetPropertyOffset(TryGetPlayGoInfo_FunctionAddress, "CurrentTime");
		TryGetPlayGoInfo_CurrentTime_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetPlayGoInfo_FunctionAddress, "CurrentTime", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetPlayGoInfo_ReturnValue_PropertyAddress, TryGetPlayGoInfo_FunctionAddress, "ReturnValue");
		TryGetPlayGoInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetPlayGoInfo_FunctionAddress, "ReturnValue");
		TryGetPlayGoInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetPlayGoInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryGetPlayGoInfo_IsValid = TryGetPlayGoInfo_FunctionAddress != IntPtr.Zero && TryGetPlayGoInfo_ProgressSize_IsValid && TryGetPlayGoInfo_TotalSize_IsValid && TryGetPlayGoInfo_CurrentTime_IsValid && TryGetPlayGoInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ChunkFuncLib:TryGetPlayGoInfo", TryGetPlayGoInfo_IsValid);
		IsPlayGoInstalling_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPlayGoInstalling");
		IsPlayGoInstalling_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayGoInstalling_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayGoInstalling_ReturnValue_PropertyAddress, IsPlayGoInstalling_FunctionAddress, "ReturnValue");
		IsPlayGoInstalling_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayGoInstalling_FunctionAddress, "ReturnValue");
		IsPlayGoInstalling_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayGoInstalling_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayGoInstalling_IsValid = IsPlayGoInstalling_FunctionAddress != IntPtr.Zero && IsPlayGoInstalling_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ChunkFuncLib:IsPlayGoInstalling", IsPlayGoInstalling_IsValid);
	}
}
