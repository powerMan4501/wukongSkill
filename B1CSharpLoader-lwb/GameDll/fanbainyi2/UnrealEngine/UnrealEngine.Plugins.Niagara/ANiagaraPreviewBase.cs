using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[Abstract]
[UClass(Flags = (ClassFlags)817889453uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraPreviewBase", "Niagara", UnrealModuleType.EnginePlugin)]
public class ANiagaraPreviewBase : AActor
{
	private static bool SetSystem_IsValid;

	private IntPtr SetSystem_InstanceFunctionAddress;

	private static IntPtr SetSystem_FunctionAddress;

	private static int SetSystem_ParamsSize;

	private static bool SetSystem_InSystem_IsValid;

	private static FFieldAddress SetSystem_InSystem_PropertyAddress;

	private static int SetSystem_InSystem_Offset;

	private static bool SetLabelText_IsValid;

	private IntPtr SetLabelText_InstanceFunctionAddress;

	private static IntPtr SetLabelText_FunctionAddress;

	private static int SetLabelText_ParamsSize;

	private static bool SetLabelText_InXAxisText_IsValid;

	private static FFieldAddress SetLabelText_InXAxisText_PropertyAddress;

	private static int SetLabelText_InXAxisText_Offset;

	private static bool SetLabelText_InYAxisText_IsValid;

	private static FFieldAddress SetLabelText_InYAxisText_PropertyAddress;

	private static int SetLabelText_InYAxisText_Offset;

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/Niagara.NiagaraPreviewBase:SetSystem")]
	public unsafe void SetSystem(UNiagaraSystem InSystem)
	{
		CheckDestroyed();
		if (!SetSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewBase:SetSystem");
			return;
		}
		if (SetSystem_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetSystem_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetSystem");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, SetSystem_InSystem_Offset), 0, SetSystem_InSystem_PropertyAddress.Address, InSystem);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSystem_InstanceFunctionAddress, intPtr, SetSystem_ParamsSize);
	}

	protected unsafe virtual void SetSystem_Implementation(UNiagaraSystem InSystem)
	{
		CheckDestroyed();
		if (!SetSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewBase:SetSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, SetSystem_InSystem_Offset), 0, SetSystem_InSystem_PropertyAddress.Address, InSystem);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSystem_FunctionAddress, intPtr, SetSystem_ParamsSize);
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/Niagara.NiagaraPreviewBase:SetLabelText")]
	public unsafe void SetLabelText(FText InXAxisText, FText InYAxisText)
	{
		CheckDestroyed();
		if (!SetLabelText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewBase:SetLabelText");
			return;
		}
		if (SetLabelText_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetLabelText_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetLabelText");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLabelText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLabelText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLabelText_InXAxisText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetLabelText_InXAxisText_Offset), 0, SetLabelText_InXAxisText_PropertyAddress.Address, InXAxisText);
		NativeReflection.InitializeValue_InContainer(SetLabelText_InYAxisText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetLabelText_InYAxisText_Offset), 0, SetLabelText_InYAxisText_PropertyAddress.Address, InYAxisText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLabelText_InstanceFunctionAddress, intPtr, SetLabelText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLabelText_InXAxisText_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetLabelText_InYAxisText_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void SetLabelText_Implementation(FText InXAxisText, FText InYAxisText)
	{
		CheckDestroyed();
		if (!SetLabelText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewBase:SetLabelText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLabelText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLabelText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLabelText_InXAxisText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetLabelText_InXAxisText_Offset), 0, SetLabelText_InXAxisText_PropertyAddress.Address, InXAxisText);
		NativeReflection.InitializeValue_InContainer(SetLabelText_InYAxisText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetLabelText_InYAxisText_Offset), 0, SetLabelText_InYAxisText_PropertyAddress.Address, InYAxisText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLabelText_FunctionAddress, intPtr, SetLabelText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLabelText_InXAxisText_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetLabelText_InYAxisText_PropertyAddress.Address, intPtr);
	}

	static ANiagaraPreviewBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ANiagaraPreviewBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ANiagaraPreviewBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Niagara.NiagaraPreviewBase");
		SetSystem_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSystem");
		SetSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSystem_InSystem_PropertyAddress, SetSystem_FunctionAddress, "InSystem");
		SetSystem_InSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetSystem_FunctionAddress, "InSystem");
		SetSystem_InSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSystem_FunctionAddress, "InSystem", Classes.FObjectProperty);
		SetSystem_IsValid = SetSystem_FunctionAddress != IntPtr.Zero && SetSystem_InSystem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraPreviewBase:SetSystem", SetSystem_IsValid);
		SetLabelText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLabelText");
		SetLabelText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLabelText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLabelText_InXAxisText_PropertyAddress, SetLabelText_FunctionAddress, "InXAxisText");
		SetLabelText_InXAxisText_Offset = NativeReflectionCached.GetPropertyOffset(SetLabelText_FunctionAddress, "InXAxisText");
		SetLabelText_InXAxisText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLabelText_FunctionAddress, "InXAxisText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLabelText_InYAxisText_PropertyAddress, SetLabelText_FunctionAddress, "InYAxisText");
		SetLabelText_InYAxisText_Offset = NativeReflectionCached.GetPropertyOffset(SetLabelText_FunctionAddress, "InYAxisText");
		SetLabelText_InYAxisText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLabelText_FunctionAddress, "InYAxisText", Classes.FTextProperty);
		SetLabelText_IsValid = SetLabelText_FunctionAddress != IntPtr.Zero && SetLabelText_InXAxisText_IsValid && SetLabelText_InYAxisText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraPreviewBase:SetLabelText", SetLabelText_IsValid);
	}
}
