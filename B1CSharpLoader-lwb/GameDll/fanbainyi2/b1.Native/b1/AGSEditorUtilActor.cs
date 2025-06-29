using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Blutility;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSEditorUtilActor", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSEditorUtilActor : AEditorUtilityActor
{
	private static bool ContinuousTicking_IsValid;

	private static FFieldAddress ContinuousTicking_PropertyAddress;

	private static int ContinuousTicking_Offset;

	private static bool TickInterval_IsValid;

	private static int TickInterval_Offset;

	private static bool OnEditorTick_IsValid;

	private IntPtr OnEditorTick_InstanceFunctionAddress;

	private static IntPtr OnEditorTick_FunctionAddress;

	private static int OnEditorTick_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorUtilActor:bContinuousTicking")]
	public bool ContinuousTicking
	{
		get
		{
			CheckDestroyed();
			if (!ContinuousTicking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorUtilActor:bContinuousTicking");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ContinuousTicking_Offset), 0, ContinuousTicking_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ContinuousTicking_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorUtilActor:bContinuousTicking");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ContinuousTicking_Offset), 0, ContinuousTicking_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorUtilActor:TickInterval")]
	public float TickInterval
	{
		get
		{
			CheckDestroyed();
			if (!TickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorUtilActor:TickInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TickInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorUtilActor:TickInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TickInterval_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorUtilActor:OnEditorTick")]
	public unsafe void OnEditorTick()
	{
		CheckDestroyed();
		if (!OnEditorTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorUtilActor:OnEditorTick");
			return;
		}
		if (OnEditorTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEditorTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEditorTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEditorTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditorTick_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnEditorTick_InstanceFunctionAddress, argsSize: OnEditorTick_ParamsSize);
	}

	protected unsafe virtual void OnEditorTick_Implementation()
	{
		CheckDestroyed();
		if (!OnEditorTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorUtilActor:OnEditorTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEditorTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEditorTick_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnEditorTick_FunctionAddress, argsSize: OnEditorTick_ParamsSize);
	}

	static AGSEditorUtilActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSEditorUtilActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSEditorUtilActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorUtilActor");
		NativeReflectionCached.GetPropertyRef(ref ContinuousTicking_PropertyAddress, intPtr, "bContinuousTicking");
		ContinuousTicking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bContinuousTicking");
		ContinuousTicking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bContinuousTicking", Classes.FBoolProperty);
		TickInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TickInterval");
		TickInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TickInterval", Classes.FFloatProperty);
		OnEditorTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEditorTick");
		OnEditorTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEditorTick_FunctionAddress);
		OnEditorTick_IsValid = OnEditorTick_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorUtilActor:OnEditorTick", OnEditorTick_IsValid);
	}
}
