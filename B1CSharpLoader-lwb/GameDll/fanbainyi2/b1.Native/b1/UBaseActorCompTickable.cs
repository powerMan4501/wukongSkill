using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BaseActorCompTickable", "b1", UnrealModuleType.Game)]
public class UBaseActorCompTickable : UBaseActorComp
{
	private static bool TickComponentInCS_IsValid;

	private IntPtr TickComponentInCS_InstanceFunctionAddress;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static FFieldAddress TickComponentInCS_DeltaTime_PropertyAddress;

	private static int TickComponentInCS_DeltaTime_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BaseActorCompTickable:TickComponentInCS")]
	public unsafe void TickComponentInCS(float DeltaTime)
	{
		CheckDestroyed();
		if (!TickComponentInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorCompTickable:TickComponentInCS");
			return;
		}
		if (TickComponentInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			TickComponentInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "TickComponentInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickComponentInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickComponentInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TickComponentInCS_DeltaTime_Offset), 0, TickComponentInCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, TickComponentInCS_InstanceFunctionAddress, intPtr, TickComponentInCS_ParamsSize);
	}

	protected unsafe virtual void TickComponentInCS_Implementation(float DeltaTime)
	{
		CheckDestroyed();
		if (!TickComponentInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorCompTickable:TickComponentInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickComponentInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickComponentInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TickComponentInCS_DeltaTime_Offset), 0, TickComponentInCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, TickComponentInCS_FunctionAddress, intPtr, TickComponentInCS_ParamsSize);
	}

	static UBaseActorCompTickable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBaseActorCompTickable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBaseActorCompTickable));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BaseActorCompTickable");
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TickComponentInCS_DeltaTime_PropertyAddress, TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorCompTickable:TickComponentInCS", TickComponentInCS_IsValid);
	}
}
