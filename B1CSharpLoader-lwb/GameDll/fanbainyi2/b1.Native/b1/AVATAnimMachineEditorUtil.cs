using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Blutility;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.VATAnimMachineEditorUtil", "FuncLibEditor", UnrealModuleType.Game)]
public class AVATAnimMachineEditorUtil : AEditorUtilityActor
{
	private static bool UpdateVATAnim_IsValid;

	private static IntPtr UpdateVATAnim_FunctionAddress;

	private static int UpdateVATAnim_ParamsSize;

	private static bool UpdateVATAnim_InDeltaTime_IsValid;

	private static FFieldAddress UpdateVATAnim_InDeltaTime_PropertyAddress;

	private static int UpdateVATAnim_InDeltaTime_Offset;

	private static bool StopPreviewingVATAnim_IsValid;

	private static IntPtr StopPreviewingVATAnim_FunctionAddress;

	private static int StopPreviewingVATAnim_ParamsSize;

	private static bool StartPreviewingVATAnim_IsValid;

	private static IntPtr StartPreviewingVATAnim_FunctionAddress;

	private static int StartPreviewingVATAnim_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.VATAnimMachineEditorUtil:UpdateVATAnim")]
	public unsafe void UpdateVATAnim(float InDeltaTime)
	{
		CheckDestroyed();
		if (!UpdateVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.VATAnimMachineEditorUtil:UpdateVATAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateVATAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateVATAnim_InDeltaTime_Offset), 0, UpdateVATAnim_InDeltaTime_PropertyAddress.Address, InDeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateVATAnim_FunctionAddress, intPtr, UpdateVATAnim_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.VATAnimMachineEditorUtil:StopPreviewingVATAnim")]
	public unsafe void StopPreviewingVATAnim()
	{
		CheckDestroyed();
		if (!StopPreviewingVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.VATAnimMachineEditorUtil:StopPreviewingVATAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopPreviewingVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopPreviewingVATAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopPreviewingVATAnim_FunctionAddress, argsSize: StopPreviewingVATAnim_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.VATAnimMachineEditorUtil:StartPreviewingVATAnim")]
	public unsafe void StartPreviewingVATAnim()
	{
		CheckDestroyed();
		if (!StartPreviewingVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.VATAnimMachineEditorUtil:StartPreviewingVATAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPreviewingVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPreviewingVATAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartPreviewingVATAnim_FunctionAddress, argsSize: StartPreviewingVATAnim_ParamsSize);
	}

	static AVATAnimMachineEditorUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AVATAnimMachineEditorUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AVATAnimMachineEditorUtil));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FuncLibEditor.VATAnimMachineEditorUtil");
		UpdateVATAnim_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateVATAnim");
		UpdateVATAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateVATAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateVATAnim_InDeltaTime_PropertyAddress, UpdateVATAnim_FunctionAddress, "InDeltaTime");
		UpdateVATAnim_InDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(UpdateVATAnim_FunctionAddress, "InDeltaTime");
		UpdateVATAnim_InDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateVATAnim_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		UpdateVATAnim_IsValid = UpdateVATAnim_FunctionAddress != IntPtr.Zero && UpdateVATAnim_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.VATAnimMachineEditorUtil:UpdateVATAnim", UpdateVATAnim_IsValid);
		StopPreviewingVATAnim_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopPreviewingVATAnim");
		StopPreviewingVATAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(StopPreviewingVATAnim_FunctionAddress);
		StopPreviewingVATAnim_IsValid = StopPreviewingVATAnim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.VATAnimMachineEditorUtil:StopPreviewingVATAnim", StopPreviewingVATAnim_IsValid);
		StartPreviewingVATAnim_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartPreviewingVATAnim");
		StartPreviewingVATAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPreviewingVATAnim_FunctionAddress);
		StartPreviewingVATAnim_IsValid = StartPreviewingVATAnim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.VATAnimMachineEditorUtil:StartPreviewingVATAnim", StartPreviewingVATAnim_IsValid);
	}
}
