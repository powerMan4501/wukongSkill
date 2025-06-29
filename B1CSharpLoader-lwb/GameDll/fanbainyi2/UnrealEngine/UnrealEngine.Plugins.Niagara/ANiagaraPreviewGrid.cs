using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraPreviewGrid", "Niagara", UnrealModuleType.EnginePlugin)]
public class ANiagaraPreviewGrid : AActor
{
	private static bool SetPaused_IsValid;

	private static IntPtr SetPaused_FunctionAddress;

	private static int SetPaused_ParamsSize;

	private static bool SetPaused_bPaused_IsValid;

	private static FFieldAddress SetPaused_bPaused_PropertyAddress;

	private static int SetPaused_bPaused_Offset;

	private static bool GetPreviews_IsValid;

	private static IntPtr GetPreviews_FunctionAddress;

	private static int GetPreviews_ParamsSize;

	private static bool GetPreviews_OutPreviews_IsValid;

	private static FFieldAddress GetPreviews_OutPreviews_PropertyAddress;

	private static int GetPreviews_OutPreviews_Offset;

	private static bool DeactivatePreviews_IsValid;

	private static IntPtr DeactivatePreviews_FunctionAddress;

	private static int DeactivatePreviews_ParamsSize;

	private static bool ActivatePreviews_IsValid;

	private static IntPtr ActivatePreviews_FunctionAddress;

	private static int ActivatePreviews_ParamsSize;

	private static bool ActivatePreviews_bReset_IsValid;

	private static FFieldAddress ActivatePreviews_bReset_PropertyAddress;

	private static int ActivatePreviews_bReset_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraPreviewGrid:SetPaused")]
	public unsafe void SetPaused(bool bPaused)
	{
		CheckDestroyed();
		if (!SetPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewGrid:SetPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPaused_bPaused_Offset), 0, SetPaused_bPaused_PropertyAddress.Address, bPaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPaused_FunctionAddress, intPtr, SetPaused_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Niagara.NiagaraPreviewGrid:GetPreviews")]
	public unsafe void GetPreviews(out List<UNiagaraComponent> OutPreviews)
	{
		CheckDestroyed();
		if (!GetPreviews_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewGrid:GetPreviews");
			OutPreviews = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviews_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviews_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviews_FunctionAddress, intPtr, GetPreviews_ParamsSize);
		OutPreviews = new TArrayCopyMarshaler<UNiagaraComponent>(1, GetPreviews_OutPreviews_PropertyAddress, CachedMarshalingDelegates<UNiagaraComponent, UObjectMarshaler<UNiagaraComponent>>.FromNative, CachedMarshalingDelegates<UNiagaraComponent, UObjectMarshaler<UNiagaraComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPreviews_OutPreviews_Offset));
		NativeReflection.DestroyValue_InContainer(GetPreviews_OutPreviews_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraPreviewGrid:DeactivatePreviews")]
	public unsafe void DeactivatePreviews()
	{
		CheckDestroyed();
		if (!DeactivatePreviews_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewGrid:DeactivatePreviews");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeactivatePreviews_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeactivatePreviews_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DeactivatePreviews_FunctionAddress, argsSize: DeactivatePreviews_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraPreviewGrid:ActivatePreviews")]
	public unsafe void ActivatePreviews(bool bReset)
	{
		CheckDestroyed();
		if (!ActivatePreviews_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewGrid:ActivatePreviews");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActivatePreviews_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActivatePreviews_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ActivatePreviews_bReset_Offset), 0, ActivatePreviews_bReset_PropertyAddress.Address, bReset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActivatePreviews_FunctionAddress, intPtr, ActivatePreviews_ParamsSize);
	}

	static ANiagaraPreviewGrid()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ANiagaraPreviewGrid)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ANiagaraPreviewGrid));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Niagara.NiagaraPreviewGrid");
		SetPaused_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPaused");
		SetPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPaused_bPaused_PropertyAddress, SetPaused_FunctionAddress, "bPaused");
		SetPaused_bPaused_Offset = NativeReflectionCached.GetPropertyOffset(SetPaused_FunctionAddress, "bPaused");
		SetPaused_bPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPaused_FunctionAddress, "bPaused", Classes.FBoolProperty);
		SetPaused_IsValid = SetPaused_FunctionAddress != IntPtr.Zero && SetPaused_bPaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraPreviewGrid:SetPaused", SetPaused_IsValid);
		GetPreviews_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPreviews");
		GetPreviews_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviews_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviews_OutPreviews_PropertyAddress, GetPreviews_FunctionAddress, "OutPreviews");
		GetPreviews_OutPreviews_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviews_FunctionAddress, "OutPreviews");
		GetPreviews_OutPreviews_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviews_FunctionAddress, "OutPreviews", Classes.FArrayProperty);
		GetPreviews_IsValid = GetPreviews_FunctionAddress != IntPtr.Zero && GetPreviews_OutPreviews_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraPreviewGrid:GetPreviews", GetPreviews_IsValid);
		DeactivatePreviews_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeactivatePreviews");
		DeactivatePreviews_ParamsSize = NativeReflection.GetFunctionParamsSize(DeactivatePreviews_FunctionAddress);
		DeactivatePreviews_IsValid = DeactivatePreviews_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraPreviewGrid:DeactivatePreviews", DeactivatePreviews_IsValid);
		ActivatePreviews_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ActivatePreviews");
		ActivatePreviews_ParamsSize = NativeReflection.GetFunctionParamsSize(ActivatePreviews_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActivatePreviews_bReset_PropertyAddress, ActivatePreviews_FunctionAddress, "bReset");
		ActivatePreviews_bReset_Offset = NativeReflectionCached.GetPropertyOffset(ActivatePreviews_FunctionAddress, "bReset");
		ActivatePreviews_bReset_IsValid = NativeReflectionCached.ValidatePropertyClass(ActivatePreviews_FunctionAddress, "bReset", Classes.FBoolProperty);
		ActivatePreviews_IsValid = ActivatePreviews_FunctionAddress != IntPtr.Zero && ActivatePreviews_bReset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraPreviewGrid:ActivatePreviews", ActivatePreviews_IsValid);
	}
}
