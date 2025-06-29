using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.SceneComponentTickable", "b1", UnrealModuleType.Game)]
public class USceneComponentTickable : USceneComponent
{
	private static bool TickComponentGS_IsValid;

	private IntPtr TickComponentGS_InstanceFunctionAddress;

	private static IntPtr TickComponentGS_FunctionAddress;

	private static int TickComponentGS_ParamsSize;

	private static bool TickComponentGS_DeltaTime_IsValid;

	private static FFieldAddress TickComponentGS_DeltaTime_PropertyAddress;

	private static int TickComponentGS_DeltaTime_Offset;

	private static bool EndPlayGS_IsValid;

	private IntPtr EndPlayGS_InstanceFunctionAddress;

	private static IntPtr EndPlayGS_FunctionAddress;

	private static int EndPlayGS_ParamsSize;

	private static bool EndPlayGS_EndPlayReason_IsValid;

	private static FFieldAddress EndPlayGS_EndPlayReason_PropertyAddress;

	private static int EndPlayGS_EndPlayReason_Offset;

	private static bool BeginPlayGS_IsValid;

	private IntPtr BeginPlayGS_InstanceFunctionAddress;

	private static IntPtr BeginPlayGS_FunctionAddress;

	private static int BeginPlayGS_ParamsSize;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.SceneComponentTickable:TickComponentGS")]
	public unsafe void TickComponentGS(float DeltaTime)
	{
		CheckDestroyed();
		if (!TickComponentGS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SceneComponentTickable:TickComponentGS");
			return;
		}
		if (TickComponentGS_InstanceFunctionAddress == IntPtr.Zero)
		{
			TickComponentGS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "TickComponentGS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickComponentGS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickComponentGS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TickComponentGS_DeltaTime_Offset), 0, TickComponentGS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, TickComponentGS_InstanceFunctionAddress, intPtr, TickComponentGS_ParamsSize);
	}

	protected unsafe virtual void TickComponentGS_Implementation(float DeltaTime)
	{
		CheckDestroyed();
		if (!TickComponentGS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SceneComponentTickable:TickComponentGS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickComponentGS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickComponentGS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TickComponentGS_DeltaTime_Offset), 0, TickComponentGS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, TickComponentGS_FunctionAddress, intPtr, TickComponentGS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.SceneComponentTickable:EndPlayGS")]
	public unsafe void EndPlayGS(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!EndPlayGS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SceneComponentTickable:EndPlayGS");
			return;
		}
		if (EndPlayGS_InstanceFunctionAddress == IntPtr.Zero)
		{
			EndPlayGS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "EndPlayGS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndPlayGS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndPlayGS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, EndPlayGS_EndPlayReason_Offset), 0, EndPlayGS_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, EndPlayGS_InstanceFunctionAddress, intPtr, EndPlayGS_ParamsSize);
	}

	protected unsafe virtual void EndPlayGS_Implementation(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!EndPlayGS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SceneComponentTickable:EndPlayGS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndPlayGS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndPlayGS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, EndPlayGS_EndPlayReason_Offset), 0, EndPlayGS_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, EndPlayGS_FunctionAddress, intPtr, EndPlayGS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.SceneComponentTickable:BeginPlayGS")]
	public unsafe void BeginPlayGS()
	{
		CheckDestroyed();
		if (!BeginPlayGS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SceneComponentTickable:BeginPlayGS");
			return;
		}
		if (BeginPlayGS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginPlayGS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginPlayGS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayGS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayGS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayGS_InstanceFunctionAddress, argsSize: BeginPlayGS_ParamsSize);
	}

	protected unsafe virtual void BeginPlayGS_Implementation()
	{
		CheckDestroyed();
		if (!BeginPlayGS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SceneComponentTickable:BeginPlayGS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayGS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayGS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayGS_FunctionAddress, argsSize: BeginPlayGS_ParamsSize);
	}

	static USceneComponentTickable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USceneComponentTickable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USceneComponentTickable));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.SceneComponentTickable");
		TickComponentGS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TickComponentGS");
		TickComponentGS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentGS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TickComponentGS_DeltaTime_PropertyAddress, TickComponentGS_FunctionAddress, "DeltaTime");
		TickComponentGS_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(TickComponentGS_FunctionAddress, "DeltaTime");
		TickComponentGS_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(TickComponentGS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentGS_IsValid = TickComponentGS_FunctionAddress != IntPtr.Zero && TickComponentGS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.SceneComponentTickable:TickComponentGS", TickComponentGS_IsValid);
		EndPlayGS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndPlayGS");
		EndPlayGS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayGS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndPlayGS_EndPlayReason_PropertyAddress, EndPlayGS_FunctionAddress, "EndPlayReason");
		EndPlayGS_EndPlayReason_Offset = NativeReflectionCached.GetPropertyOffset(EndPlayGS_FunctionAddress, "EndPlayReason");
		EndPlayGS_EndPlayReason_IsValid = NativeReflectionCached.ValidatePropertyClass(EndPlayGS_FunctionAddress, "EndPlayReason", Classes.FByteProperty);
		EndPlayGS_IsValid = EndPlayGS_FunctionAddress != IntPtr.Zero && EndPlayGS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.SceneComponentTickable:EndPlayGS", EndPlayGS_IsValid);
		BeginPlayGS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayGS");
		BeginPlayGS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayGS_FunctionAddress);
		BeginPlayGS_IsValid = BeginPlayGS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.SceneComponentTickable:BeginPlayGS", BeginPlayGS_IsValid);
	}
}
