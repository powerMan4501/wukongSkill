using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_CppExport", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_CppExport : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetUMGFuncAsMap_IsValid;

	private static IntPtr GetUMGFuncAsMap_FunctionAddress;

	private static int GetUMGFuncAsMap_ParamsSize;

	private static bool GetUMGFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetUMGFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetUMGFuncAsMap_ReturnValue_Offset;

	private static bool GetTaskGraphFuncAsMap_IsValid;

	private static IntPtr GetTaskGraphFuncAsMap_FunctionAddress;

	private static int GetTaskGraphFuncAsMap_ParamsSize;

	private static bool GetTaskGraphFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetTaskGraphFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetTaskGraphFuncAsMap_ReturnValue_Offset;

	private static bool GetSplineComponentFuncAsMap_IsValid;

	private static IntPtr GetSplineComponentFuncAsMap_FunctionAddress;

	private static int GetSplineComponentFuncAsMap_ParamsSize;

	private static bool GetSplineComponentFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetSplineComponentFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetSplineComponentFuncAsMap_ReturnValue_Offset;

	private static bool GetSceneComponentFuncAsMap_IsValid;

	private static IntPtr GetSceneComponentFuncAsMap_FunctionAddress;

	private static int GetSceneComponentFuncAsMap_ParamsSize;

	private static bool GetSceneComponentFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetSceneComponentFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetSceneComponentFuncAsMap_ReturnValue_Offset;

	private static bool GetRenderFuncAsMap_IsValid;

	private static IntPtr GetRenderFuncAsMap_FunctionAddress;

	private static int GetRenderFuncAsMap_ParamsSize;

	private static bool GetRenderFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetRenderFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetRenderFuncAsMap_ReturnValue_Offset;

	private static bool GetProfilerFuncAsMap_IsValid;

	private static IntPtr GetProfilerFuncAsMap_FunctionAddress;

	private static int GetProfilerFuncAsMap_ParamsSize;

	private static bool GetProfilerFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetProfilerFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetProfilerFuncAsMap_ReturnValue_Offset;

	private static bool GetNiagaraFuncAsMap_IsValid;

	private static IntPtr GetNiagaraFuncAsMap_FunctionAddress;

	private static int GetNiagaraFuncAsMap_ParamsSize;

	private static bool GetNiagaraFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetNiagaraFuncAsMap_ReturnValue_Offset;

	private static bool GetMathFuncAsMap_IsValid;

	private static IntPtr GetMathFuncAsMap_FunctionAddress;

	private static int GetMathFuncAsMap_ParamsSize;

	private static bool GetMathFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetMathFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetMathFuncAsMap_ReturnValue_Offset;

	private static bool GetLineTraceFuncAsMap_IsValid;

	private static IntPtr GetLineTraceFuncAsMap_FunctionAddress;

	private static int GetLineTraceFuncAsMap_ParamsSize;

	private static bool GetLineTraceFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetLineTraceFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetLineTraceFuncAsMap_ReturnValue_Offset;

	private static bool GetInputFuncAsMap_IsValid;

	private static IntPtr GetInputFuncAsMap_FunctionAddress;

	private static int GetInputFuncAsMap_ParamsSize;

	private static bool GetInputFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetInputFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetInputFuncAsMap_ReturnValue_Offset;

	private static bool GetGSCVarFuncAsMap_IsValid;

	private static IntPtr GetGSCVarFuncAsMap_FunctionAddress;

	private static int GetGSCVarFuncAsMap_ParamsSize;

	private static bool GetGSCVarFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetGSCVarFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetGSCVarFuncAsMap_ReturnValue_Offset;

	private static bool GetGameplayTagFuncAsMap_IsValid;

	private static IntPtr GetGameplayTagFuncAsMap_FunctionAddress;

	private static int GetGameplayTagFuncAsMap_ParamsSize;

	private static bool GetGameplayTagFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetGameplayTagFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetGameplayTagFuncAsMap_ReturnValue_Offset;

	private static bool GetCVarFuncAsMap_IsValid;

	private static IntPtr GetCVarFuncAsMap_FunctionAddress;

	private static int GetCVarFuncAsMap_ParamsSize;

	private static bool GetCVarFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetCVarFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetCVarFuncAsMap_ReturnValue_Offset;

	private static bool GetAsyncLineTraceReqFuncAsMap_IsValid;

	private static IntPtr GetAsyncLineTraceReqFuncAsMap_FunctionAddress;

	private static int GetAsyncLineTraceReqFuncAsMap_ParamsSize;

	private static bool GetAsyncLineTraceReqFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetAsyncLineTraceReqFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetAsyncLineTraceReqFuncAsMap_ReturnValue_Offset;

	private static bool GetAnimFuncAsMap_IsValid;

	private static IntPtr GetAnimFuncAsMap_FunctionAddress;

	private static int GetAnimFuncAsMap_ParamsSize;

	private static bool GetAnimFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetAnimFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetAnimFuncAsMap_ReturnValue_Offset;

	private static bool GetAIFuncAsMap_IsValid;

	private static IntPtr GetAIFuncAsMap_FunctionAddress;

	private static int GetAIFuncAsMap_ParamsSize;

	private static bool GetAIFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetAIFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetAIFuncAsMap_ReturnValue_Offset;

	private static bool GetActorFuncAsMap_IsValid;

	private static IntPtr GetActorFuncAsMap_FunctionAddress;

	private static int GetActorFuncAsMap_ParamsSize;

	private static bool GetActorFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetActorFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetActorFuncAsMap_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetUMGFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetUMGFuncAsMap()
	{
		if (!GetUMGFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetUMGFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUMGFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUMGFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUMGFuncAsMap_FunctionAddress, intPtr, GetUMGFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetUMGFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetUMGFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetUMGFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetTaskGraphFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetTaskGraphFuncAsMap()
	{
		if (!GetTaskGraphFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetTaskGraphFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTaskGraphFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTaskGraphFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTaskGraphFuncAsMap_FunctionAddress, intPtr, GetTaskGraphFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetTaskGraphFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTaskGraphFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTaskGraphFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetSplineComponentFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetSplineComponentFuncAsMap()
	{
		if (!GetSplineComponentFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetSplineComponentFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineComponentFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineComponentFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSplineComponentFuncAsMap_FunctionAddress, intPtr, GetSplineComponentFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetSplineComponentFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSplineComponentFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSplineComponentFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetSceneComponentFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetSceneComponentFuncAsMap()
	{
		if (!GetSceneComponentFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetSceneComponentFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSceneComponentFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSceneComponentFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSceneComponentFuncAsMap_FunctionAddress, intPtr, GetSceneComponentFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetSceneComponentFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSceneComponentFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSceneComponentFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetRenderFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetRenderFuncAsMap()
	{
		if (!GetRenderFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetRenderFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRenderFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRenderFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRenderFuncAsMap_FunctionAddress, intPtr, GetRenderFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetRenderFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRenderFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetRenderFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetProfilerFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetProfilerFuncAsMap()
	{
		if (!GetProfilerFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetProfilerFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProfilerFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProfilerFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProfilerFuncAsMap_FunctionAddress, intPtr, GetProfilerFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetProfilerFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetProfilerFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetProfilerFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetNiagaraFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetNiagaraFuncAsMap()
	{
		if (!GetNiagaraFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetNiagaraFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraFuncAsMap_FunctionAddress, intPtr, GetNiagaraFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetNiagaraFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetMathFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetMathFuncAsMap()
	{
		if (!GetMathFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetMathFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMathFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMathFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMathFuncAsMap_FunctionAddress, intPtr, GetMathFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetMathFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMathFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMathFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetLineTraceFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetLineTraceFuncAsMap()
	{
		if (!GetLineTraceFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetLineTraceFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLineTraceFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLineTraceFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLineTraceFuncAsMap_FunctionAddress, intPtr, GetLineTraceFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetLineTraceFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLineTraceFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLineTraceFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetInputFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetInputFuncAsMap()
	{
		if (!GetInputFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetInputFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputFuncAsMap_FunctionAddress, intPtr, GetInputFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetInputFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetGSCVarFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetGSCVarFuncAsMap()
	{
		if (!GetGSCVarFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetGSCVarFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGSCVarFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGSCVarFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGSCVarFuncAsMap_FunctionAddress, intPtr, GetGSCVarFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetGSCVarFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetGSCVarFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetGSCVarFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetGameplayTagFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetGameplayTagFuncAsMap()
	{
		if (!GetGameplayTagFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetGameplayTagFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameplayTagFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameplayTagFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGameplayTagFuncAsMap_FunctionAddress, intPtr, GetGameplayTagFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetGameplayTagFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetGameplayTagFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetGameplayTagFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetCVarFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetCVarFuncAsMap()
	{
		if (!GetCVarFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetCVarFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCVarFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCVarFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCVarFuncAsMap_FunctionAddress, intPtr, GetCVarFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetCVarFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCVarFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCVarFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetAsyncLineTraceReqFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetAsyncLineTraceReqFuncAsMap()
	{
		if (!GetAsyncLineTraceReqFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetAsyncLineTraceReqFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAsyncLineTraceReqFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAsyncLineTraceReqFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAsyncLineTraceReqFuncAsMap_FunctionAddress, intPtr, GetAsyncLineTraceReqFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetAsyncLineTraceReqFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAsyncLineTraceReqFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAsyncLineTraceReqFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetAnimFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetAnimFuncAsMap()
	{
		if (!GetAnimFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetAnimFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimFuncAsMap_FunctionAddress, intPtr, GetAnimFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetAnimFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetAIFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetAIFuncAsMap()
	{
		if (!GetAIFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetAIFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAIFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAIFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAIFuncAsMap_FunctionAddress, intPtr, GetAIFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetAIFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAIFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAIFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CppExport:GetActorFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetActorFuncAsMap()
	{
		if (!GetActorFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CppExport:GetActorFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorFuncAsMap_FunctionAddress, intPtr, GetActorFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetActorFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetActorFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSE_CppExport()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_CppExport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_CppExport));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_CppExport");
		GetUMGFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUMGFuncAsMap");
		GetUMGFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUMGFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUMGFuncAsMap_ReturnValue_PropertyAddress, GetUMGFuncAsMap_FunctionAddress, "ReturnValue");
		GetUMGFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUMGFuncAsMap_FunctionAddress, "ReturnValue");
		GetUMGFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUMGFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetUMGFuncAsMap_IsValid = GetUMGFuncAsMap_FunctionAddress != IntPtr.Zero && GetUMGFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetUMGFuncAsMap", GetUMGFuncAsMap_IsValid);
		GetTaskGraphFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTaskGraphFuncAsMap");
		GetTaskGraphFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTaskGraphFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTaskGraphFuncAsMap_ReturnValue_PropertyAddress, GetTaskGraphFuncAsMap_FunctionAddress, "ReturnValue");
		GetTaskGraphFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTaskGraphFuncAsMap_FunctionAddress, "ReturnValue");
		GetTaskGraphFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTaskGraphFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetTaskGraphFuncAsMap_IsValid = GetTaskGraphFuncAsMap_FunctionAddress != IntPtr.Zero && GetTaskGraphFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetTaskGraphFuncAsMap", GetTaskGraphFuncAsMap_IsValid);
		GetSplineComponentFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSplineComponentFuncAsMap");
		GetSplineComponentFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineComponentFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineComponentFuncAsMap_ReturnValue_PropertyAddress, GetSplineComponentFuncAsMap_FunctionAddress, "ReturnValue");
		GetSplineComponentFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineComponentFuncAsMap_FunctionAddress, "ReturnValue");
		GetSplineComponentFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineComponentFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetSplineComponentFuncAsMap_IsValid = GetSplineComponentFuncAsMap_FunctionAddress != IntPtr.Zero && GetSplineComponentFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetSplineComponentFuncAsMap", GetSplineComponentFuncAsMap_IsValid);
		GetSceneComponentFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSceneComponentFuncAsMap");
		GetSceneComponentFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneComponentFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSceneComponentFuncAsMap_ReturnValue_PropertyAddress, GetSceneComponentFuncAsMap_FunctionAddress, "ReturnValue");
		GetSceneComponentFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneComponentFuncAsMap_FunctionAddress, "ReturnValue");
		GetSceneComponentFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneComponentFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetSceneComponentFuncAsMap_IsValid = GetSceneComponentFuncAsMap_FunctionAddress != IntPtr.Zero && GetSceneComponentFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetSceneComponentFuncAsMap", GetSceneComponentFuncAsMap_IsValid);
		GetRenderFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRenderFuncAsMap");
		GetRenderFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRenderFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRenderFuncAsMap_ReturnValue_PropertyAddress, GetRenderFuncAsMap_FunctionAddress, "ReturnValue");
		GetRenderFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRenderFuncAsMap_FunctionAddress, "ReturnValue");
		GetRenderFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRenderFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetRenderFuncAsMap_IsValid = GetRenderFuncAsMap_FunctionAddress != IntPtr.Zero && GetRenderFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetRenderFuncAsMap", GetRenderFuncAsMap_IsValid);
		GetProfilerFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProfilerFuncAsMap");
		GetProfilerFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProfilerFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProfilerFuncAsMap_ReturnValue_PropertyAddress, GetProfilerFuncAsMap_FunctionAddress, "ReturnValue");
		GetProfilerFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProfilerFuncAsMap_FunctionAddress, "ReturnValue");
		GetProfilerFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProfilerFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetProfilerFuncAsMap_IsValid = GetProfilerFuncAsMap_FunctionAddress != IntPtr.Zero && GetProfilerFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetProfilerFuncAsMap", GetProfilerFuncAsMap_IsValid);
		GetNiagaraFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraFuncAsMap");
		GetNiagaraFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraFuncAsMap_ReturnValue_PropertyAddress, GetNiagaraFuncAsMap_FunctionAddress, "ReturnValue");
		GetNiagaraFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraFuncAsMap_FunctionAddress, "ReturnValue");
		GetNiagaraFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetNiagaraFuncAsMap_IsValid = GetNiagaraFuncAsMap_FunctionAddress != IntPtr.Zero && GetNiagaraFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetNiagaraFuncAsMap", GetNiagaraFuncAsMap_IsValid);
		GetMathFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMathFuncAsMap");
		GetMathFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMathFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMathFuncAsMap_ReturnValue_PropertyAddress, GetMathFuncAsMap_FunctionAddress, "ReturnValue");
		GetMathFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMathFuncAsMap_FunctionAddress, "ReturnValue");
		GetMathFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMathFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetMathFuncAsMap_IsValid = GetMathFuncAsMap_FunctionAddress != IntPtr.Zero && GetMathFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetMathFuncAsMap", GetMathFuncAsMap_IsValid);
		GetLineTraceFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLineTraceFuncAsMap");
		GetLineTraceFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLineTraceFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLineTraceFuncAsMap_ReturnValue_PropertyAddress, GetLineTraceFuncAsMap_FunctionAddress, "ReturnValue");
		GetLineTraceFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLineTraceFuncAsMap_FunctionAddress, "ReturnValue");
		GetLineTraceFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLineTraceFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetLineTraceFuncAsMap_IsValid = GetLineTraceFuncAsMap_FunctionAddress != IntPtr.Zero && GetLineTraceFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetLineTraceFuncAsMap", GetLineTraceFuncAsMap_IsValid);
		GetInputFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputFuncAsMap");
		GetInputFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputFuncAsMap_ReturnValue_PropertyAddress, GetInputFuncAsMap_FunctionAddress, "ReturnValue");
		GetInputFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputFuncAsMap_FunctionAddress, "ReturnValue");
		GetInputFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetInputFuncAsMap_IsValid = GetInputFuncAsMap_FunctionAddress != IntPtr.Zero && GetInputFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetInputFuncAsMap", GetInputFuncAsMap_IsValid);
		GetGSCVarFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGSCVarFuncAsMap");
		GetGSCVarFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGSCVarFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGSCVarFuncAsMap_ReturnValue_PropertyAddress, GetGSCVarFuncAsMap_FunctionAddress, "ReturnValue");
		GetGSCVarFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGSCVarFuncAsMap_FunctionAddress, "ReturnValue");
		GetGSCVarFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSCVarFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetGSCVarFuncAsMap_IsValid = GetGSCVarFuncAsMap_FunctionAddress != IntPtr.Zero && GetGSCVarFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetGSCVarFuncAsMap", GetGSCVarFuncAsMap_IsValid);
		GetGameplayTagFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGameplayTagFuncAsMap");
		GetGameplayTagFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameplayTagFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameplayTagFuncAsMap_ReturnValue_PropertyAddress, GetGameplayTagFuncAsMap_FunctionAddress, "ReturnValue");
		GetGameplayTagFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameplayTagFuncAsMap_FunctionAddress, "ReturnValue");
		GetGameplayTagFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameplayTagFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetGameplayTagFuncAsMap_IsValid = GetGameplayTagFuncAsMap_FunctionAddress != IntPtr.Zero && GetGameplayTagFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetGameplayTagFuncAsMap", GetGameplayTagFuncAsMap_IsValid);
		GetCVarFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCVarFuncAsMap");
		GetCVarFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCVarFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCVarFuncAsMap_ReturnValue_PropertyAddress, GetCVarFuncAsMap_FunctionAddress, "ReturnValue");
		GetCVarFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCVarFuncAsMap_FunctionAddress, "ReturnValue");
		GetCVarFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCVarFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetCVarFuncAsMap_IsValid = GetCVarFuncAsMap_FunctionAddress != IntPtr.Zero && GetCVarFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetCVarFuncAsMap", GetCVarFuncAsMap_IsValid);
		GetAsyncLineTraceReqFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAsyncLineTraceReqFuncAsMap");
		GetAsyncLineTraceReqFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAsyncLineTraceReqFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAsyncLineTraceReqFuncAsMap_ReturnValue_PropertyAddress, GetAsyncLineTraceReqFuncAsMap_FunctionAddress, "ReturnValue");
		GetAsyncLineTraceReqFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAsyncLineTraceReqFuncAsMap_FunctionAddress, "ReturnValue");
		GetAsyncLineTraceReqFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsyncLineTraceReqFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetAsyncLineTraceReqFuncAsMap_IsValid = GetAsyncLineTraceReqFuncAsMap_FunctionAddress != IntPtr.Zero && GetAsyncLineTraceReqFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetAsyncLineTraceReqFuncAsMap", GetAsyncLineTraceReqFuncAsMap_IsValid);
		GetAnimFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimFuncAsMap");
		GetAnimFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimFuncAsMap_ReturnValue_PropertyAddress, GetAnimFuncAsMap_FunctionAddress, "ReturnValue");
		GetAnimFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimFuncAsMap_FunctionAddress, "ReturnValue");
		GetAnimFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetAnimFuncAsMap_IsValid = GetAnimFuncAsMap_FunctionAddress != IntPtr.Zero && GetAnimFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetAnimFuncAsMap", GetAnimFuncAsMap_IsValid);
		GetAIFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAIFuncAsMap");
		GetAIFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAIFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAIFuncAsMap_ReturnValue_PropertyAddress, GetAIFuncAsMap_FunctionAddress, "ReturnValue");
		GetAIFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAIFuncAsMap_FunctionAddress, "ReturnValue");
		GetAIFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAIFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetAIFuncAsMap_IsValid = GetAIFuncAsMap_FunctionAddress != IntPtr.Zero && GetAIFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetAIFuncAsMap", GetAIFuncAsMap_IsValid);
		GetActorFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorFuncAsMap");
		GetActorFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorFuncAsMap_ReturnValue_PropertyAddress, GetActorFuncAsMap_FunctionAddress, "ReturnValue");
		GetActorFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorFuncAsMap_FunctionAddress, "ReturnValue");
		GetActorFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetActorFuncAsMap_IsValid = GetActorFuncAsMap_FunctionAddress != IntPtr.Zero && GetActorFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CppExport:GetActorFuncAsMap", GetActorFuncAsMap_IsValid);
	}
}
