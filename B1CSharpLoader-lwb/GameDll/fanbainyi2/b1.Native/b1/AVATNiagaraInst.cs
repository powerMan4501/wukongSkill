using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.VATNiagaraInst", "UnrealExtent", UnrealModuleType.Game)]
public class AVATNiagaraInst : AActor
{
	private static bool UpdateVATAnim_IsValid;

	private IntPtr UpdateVATAnim_InstanceFunctionAddress;

	private static IntPtr UpdateVATAnim_FunctionAddress;

	private static int UpdateVATAnim_ParamsSize;

	private static bool UpdateNiagaraVectorVariable_IsValid;

	private static IntPtr UpdateNiagaraVectorVariable_FunctionAddress;

	private static int UpdateNiagaraVectorVariable_ParamsSize;

	private static bool UpdateNiagaraVectorVariable_VariableName_IsValid;

	private static FFieldAddress UpdateNiagaraVectorVariable_VariableName_PropertyAddress;

	private static int UpdateNiagaraVectorVariable_VariableName_Offset;

	private static bool UpdateNiagaraVectorVariable_TargetValue_IsValid;

	private static FFieldAddress UpdateNiagaraVectorVariable_TargetValue_PropertyAddress;

	private static int UpdateNiagaraVectorVariable_TargetValue_Offset;

	private static bool UpdateNiagaraVector2Variable_IsValid;

	private static IntPtr UpdateNiagaraVector2Variable_FunctionAddress;

	private static int UpdateNiagaraVector2Variable_ParamsSize;

	private static bool UpdateNiagaraVector2Variable_VariableName_IsValid;

	private static FFieldAddress UpdateNiagaraVector2Variable_VariableName_PropertyAddress;

	private static int UpdateNiagaraVector2Variable_VariableName_Offset;

	private static bool UpdateNiagaraVector2Variable_TargetValue_IsValid;

	private static FFieldAddress UpdateNiagaraVector2Variable_TargetValue_PropertyAddress;

	private static int UpdateNiagaraVector2Variable_TargetValue_Offset;

	private static bool UpdateNiagaraFloatVariable_IsValid;

	private static IntPtr UpdateNiagaraFloatVariable_FunctionAddress;

	private static int UpdateNiagaraFloatVariable_ParamsSize;

	private static bool UpdateNiagaraFloatVariable_VariableName_IsValid;

	private static FFieldAddress UpdateNiagaraFloatVariable_VariableName_PropertyAddress;

	private static int UpdateNiagaraFloatVariable_VariableName_Offset;

	private static bool UpdateNiagaraFloatVariable_TargetValue_IsValid;

	private static FFieldAddress UpdateNiagaraFloatVariable_TargetValue_PropertyAddress;

	private static int UpdateNiagaraFloatVariable_TargetValue_Offset;

	private static bool ResetVATAnim_IsValid;

	private IntPtr ResetVATAnim_InstanceFunctionAddress;

	private static IntPtr ResetVATAnim_FunctionAddress;

	private static int ResetVATAnim_ParamsSize;

	private static bool ResetNiagaraSystem_IsValid;

	private static IntPtr ResetNiagaraSystem_FunctionAddress;

	private static int ResetNiagaraSystem_ParamsSize;

	private static bool InitVATNiagaraInst_IsValid;

	private static IntPtr InitVATNiagaraInst_FunctionAddress;

	private static int InitVATNiagaraInst_ParamsSize;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealExtent.VATNiagaraInst:UpdateVATAnim")]
	public unsafe void UpdateVATAnim()
	{
		CheckDestroyed();
		if (!UpdateVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:UpdateVATAnim");
			return;
		}
		if (UpdateVATAnim_InstanceFunctionAddress == IntPtr.Zero)
		{
			UpdateVATAnim_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "UpdateVATAnim");
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateVATAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateVATAnim_InstanceFunctionAddress, argsSize: UpdateVATAnim_ParamsSize);
	}

	protected unsafe virtual void UpdateVATAnim_Implementation()
	{
		CheckDestroyed();
		if (!UpdateVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:UpdateVATAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateVATAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateVATAnim_FunctionAddress, argsSize: UpdateVATAnim_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraVectorVariable")]
	public unsafe void UpdateNiagaraVectorVariable(string VariableName, FVector TargetValue)
	{
		CheckDestroyed();
		if (!UpdateNiagaraVectorVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraVectorVariable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateNiagaraVectorVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateNiagaraVectorVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateNiagaraVectorVariable_VariableName_Offset), 0, UpdateNiagaraVectorVariable_VariableName_PropertyAddress.Address, VariableName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, UpdateNiagaraVectorVariable_TargetValue_Offset), 0, UpdateNiagaraVectorVariable_TargetValue_PropertyAddress.Address, TargetValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateNiagaraVectorVariable_FunctionAddress, intPtr, UpdateNiagaraVectorVariable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateNiagaraVectorVariable_VariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraVector2Variable")]
	public unsafe void UpdateNiagaraVector2Variable(string VariableName, FVector2D TargetValue)
	{
		CheckDestroyed();
		if (!UpdateNiagaraVector2Variable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraVector2Variable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateNiagaraVector2Variable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateNiagaraVector2Variable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateNiagaraVector2Variable_VariableName_Offset), 0, UpdateNiagaraVector2Variable_VariableName_PropertyAddress.Address, VariableName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, UpdateNiagaraVector2Variable_TargetValue_Offset), 0, UpdateNiagaraVector2Variable_TargetValue_PropertyAddress.Address, TargetValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateNiagaraVector2Variable_FunctionAddress, intPtr, UpdateNiagaraVector2Variable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateNiagaraVector2Variable_VariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraFloatVariable")]
	public unsafe void UpdateNiagaraFloatVariable(string VariableName, float TargetValue)
	{
		CheckDestroyed();
		if (!UpdateNiagaraFloatVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraFloatVariable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateNiagaraFloatVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateNiagaraFloatVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateNiagaraFloatVariable_VariableName_Offset), 0, UpdateNiagaraFloatVariable_VariableName_PropertyAddress.Address, VariableName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateNiagaraFloatVariable_TargetValue_Offset), 0, UpdateNiagaraFloatVariable_TargetValue_PropertyAddress.Address, TargetValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateNiagaraFloatVariable_FunctionAddress, intPtr, UpdateNiagaraFloatVariable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateNiagaraFloatVariable_VariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealExtent.VATNiagaraInst:ResetVATAnim")]
	public unsafe void ResetVATAnim()
	{
		CheckDestroyed();
		if (!ResetVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:ResetVATAnim");
			return;
		}
		if (ResetVATAnim_InstanceFunctionAddress == IntPtr.Zero)
		{
			ResetVATAnim_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ResetVATAnim");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetVATAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetVATAnim_InstanceFunctionAddress, argsSize: ResetVATAnim_ParamsSize);
	}

	protected unsafe virtual void ResetVATAnim_Implementation()
	{
		CheckDestroyed();
		if (!ResetVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:ResetVATAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetVATAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetVATAnim_FunctionAddress, argsSize: ResetVATAnim_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATNiagaraInst:ResetNiagaraSystem")]
	public unsafe void ResetNiagaraSystem()
	{
		CheckDestroyed();
		if (!ResetNiagaraSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:ResetNiagaraSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetNiagaraSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetNiagaraSystem_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetNiagaraSystem_FunctionAddress, argsSize: ResetNiagaraSystem_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATNiagaraInst:InitVATNiagaraInst")]
	public unsafe void InitVATNiagaraInst()
	{
		CheckDestroyed();
		if (!InitVATNiagaraInst_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATNiagaraInst:InitVATNiagaraInst");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitVATNiagaraInst_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitVATNiagaraInst_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitVATNiagaraInst_FunctionAddress, argsSize: InitVATNiagaraInst_ParamsSize);
	}

	static AVATNiagaraInst()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AVATNiagaraInst)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AVATNiagaraInst));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.VATNiagaraInst");
		UpdateVATAnim_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateVATAnim");
		UpdateVATAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateVATAnim_FunctionAddress);
		UpdateVATAnim_IsValid = UpdateVATAnim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATNiagaraInst:UpdateVATAnim", UpdateVATAnim_IsValid);
		UpdateNiagaraVectorVariable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateNiagaraVectorVariable");
		UpdateNiagaraVectorVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateNiagaraVectorVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateNiagaraVectorVariable_VariableName_PropertyAddress, UpdateNiagaraVectorVariable_FunctionAddress, "VariableName");
		UpdateNiagaraVectorVariable_VariableName_Offset = NativeReflectionCached.GetPropertyOffset(UpdateNiagaraVectorVariable_FunctionAddress, "VariableName");
		UpdateNiagaraVectorVariable_VariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateNiagaraVectorVariable_FunctionAddress, "VariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateNiagaraVectorVariable_TargetValue_PropertyAddress, UpdateNiagaraVectorVariable_FunctionAddress, "TargetValue");
		UpdateNiagaraVectorVariable_TargetValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateNiagaraVectorVariable_FunctionAddress, "TargetValue");
		UpdateNiagaraVectorVariable_TargetValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateNiagaraVectorVariable_FunctionAddress, "TargetValue", Classes.FStructProperty);
		UpdateNiagaraVectorVariable_IsValid = UpdateNiagaraVectorVariable_FunctionAddress != IntPtr.Zero && UpdateNiagaraVectorVariable_VariableName_IsValid && UpdateNiagaraVectorVariable_TargetValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraVectorVariable", UpdateNiagaraVectorVariable_IsValid);
		UpdateNiagaraVector2Variable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateNiagaraVector2Variable");
		UpdateNiagaraVector2Variable_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateNiagaraVector2Variable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateNiagaraVector2Variable_VariableName_PropertyAddress, UpdateNiagaraVector2Variable_FunctionAddress, "VariableName");
		UpdateNiagaraVector2Variable_VariableName_Offset = NativeReflectionCached.GetPropertyOffset(UpdateNiagaraVector2Variable_FunctionAddress, "VariableName");
		UpdateNiagaraVector2Variable_VariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateNiagaraVector2Variable_FunctionAddress, "VariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateNiagaraVector2Variable_TargetValue_PropertyAddress, UpdateNiagaraVector2Variable_FunctionAddress, "TargetValue");
		UpdateNiagaraVector2Variable_TargetValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateNiagaraVector2Variable_FunctionAddress, "TargetValue");
		UpdateNiagaraVector2Variable_TargetValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateNiagaraVector2Variable_FunctionAddress, "TargetValue", Classes.FStructProperty);
		UpdateNiagaraVector2Variable_IsValid = UpdateNiagaraVector2Variable_FunctionAddress != IntPtr.Zero && UpdateNiagaraVector2Variable_VariableName_IsValid && UpdateNiagaraVector2Variable_TargetValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraVector2Variable", UpdateNiagaraVector2Variable_IsValid);
		UpdateNiagaraFloatVariable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateNiagaraFloatVariable");
		UpdateNiagaraFloatVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateNiagaraFloatVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateNiagaraFloatVariable_VariableName_PropertyAddress, UpdateNiagaraFloatVariable_FunctionAddress, "VariableName");
		UpdateNiagaraFloatVariable_VariableName_Offset = NativeReflectionCached.GetPropertyOffset(UpdateNiagaraFloatVariable_FunctionAddress, "VariableName");
		UpdateNiagaraFloatVariable_VariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateNiagaraFloatVariable_FunctionAddress, "VariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateNiagaraFloatVariable_TargetValue_PropertyAddress, UpdateNiagaraFloatVariable_FunctionAddress, "TargetValue");
		UpdateNiagaraFloatVariable_TargetValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateNiagaraFloatVariable_FunctionAddress, "TargetValue");
		UpdateNiagaraFloatVariable_TargetValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateNiagaraFloatVariable_FunctionAddress, "TargetValue", Classes.FFloatProperty);
		UpdateNiagaraFloatVariable_IsValid = UpdateNiagaraFloatVariable_FunctionAddress != IntPtr.Zero && UpdateNiagaraFloatVariable_VariableName_IsValid && UpdateNiagaraFloatVariable_TargetValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATNiagaraInst:UpdateNiagaraFloatVariable", UpdateNiagaraFloatVariable_IsValid);
		ResetVATAnim_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetVATAnim");
		ResetVATAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetVATAnim_FunctionAddress);
		ResetVATAnim_IsValid = ResetVATAnim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATNiagaraInst:ResetVATAnim", ResetVATAnim_IsValid);
		ResetNiagaraSystem_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetNiagaraSystem");
		ResetNiagaraSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetNiagaraSystem_FunctionAddress);
		ResetNiagaraSystem_IsValid = ResetNiagaraSystem_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATNiagaraInst:ResetNiagaraSystem", ResetNiagaraSystem_IsValid);
		InitVATNiagaraInst_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitVATNiagaraInst");
		InitVATNiagaraInst_ParamsSize = NativeReflection.GetFunctionParamsSize(InitVATNiagaraInst_FunctionAddress);
		InitVATNiagaraInst_IsValid = InitVATNiagaraInst_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATNiagaraInst:InitVATNiagaraInst", InitVATNiagaraInst_IsValid);
	}
}
