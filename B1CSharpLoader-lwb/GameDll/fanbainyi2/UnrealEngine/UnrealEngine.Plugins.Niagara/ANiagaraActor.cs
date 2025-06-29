using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraActor", "Niagara", UnrealModuleType.EnginePlugin)]
public class ANiagaraActor : AActor
{
	private static bool NiagaraComponent_IsValid;

	private static int NiagaraComponent_Offset;

	private static bool SetDestroyOnSystemFinish_IsValid;

	private static IntPtr SetDestroyOnSystemFinish_FunctionAddress;

	private static int SetDestroyOnSystemFinish_ParamsSize;

	private static bool SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_IsValid;

	private static FFieldAddress SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_PropertyAddress;

	private static int SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Niagara.NiagaraActor:NiagaraComponent")]
	public UNiagaraComponent NiagaraComponent
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraActor:NiagaraComponent");
				return null;
			}
			return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(base.Address, NiagaraComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NiagaraComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraActor:NiagaraComponent");
			}
			else
			{
				UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(base.Address, NiagaraComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraActor:SetDestroyOnSystemFinish")]
	public unsafe void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish)
	{
		CheckDestroyed();
		if (!SetDestroyOnSystemFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraActor:SetDestroyOnSystemFinish");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDestroyOnSystemFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDestroyOnSystemFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_Offset), 0, SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_PropertyAddress.Address, bShouldDestroyOnSystemFinish);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDestroyOnSystemFinish_FunctionAddress, intPtr, SetDestroyOnSystemFinish_ParamsSize);
	}

	static ANiagaraActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ANiagaraActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ANiagaraActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Niagara.NiagaraActor");
		NiagaraComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NiagaraComponent");
		NiagaraComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NiagaraComponent", Classes.FObjectProperty);
		SetDestroyOnSystemFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDestroyOnSystemFinish");
		SetDestroyOnSystemFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDestroyOnSystemFinish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_PropertyAddress, SetDestroyOnSystemFinish_FunctionAddress, "bShouldDestroyOnSystemFinish");
		SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_Offset = NativeReflectionCached.GetPropertyOffset(SetDestroyOnSystemFinish_FunctionAddress, "bShouldDestroyOnSystemFinish");
		SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDestroyOnSystemFinish_FunctionAddress, "bShouldDestroyOnSystemFinish", Classes.FBoolProperty);
		SetDestroyOnSystemFinish_IsValid = SetDestroyOnSystemFinish_FunctionAddress != IntPtr.Zero && SetDestroyOnSystemFinish_bShouldDestroyOnSystemFinish_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraActor:SetDestroyOnSystemFinish", SetDestroyOnSystemFinish_IsValid);
	}
}
