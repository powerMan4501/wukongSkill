using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGURootMotionSourceObject_Base", "b1", UnrealModuleType.Game)]
public class UBGURootMotionSourceObject_Base : UObject
{
	private static bool RemoveRootMotionSource_IsValid;

	private static IntPtr RemoveRootMotionSource_FunctionAddress;

	private static int RemoveRootMotionSource_ParamsSize;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_MoveComp_IsValid;

	private static FFieldAddress Init_MoveComp_PropertyAddress;

	private static int Init_MoveComp_Offset;

	private static bool Init_InInstanceName_IsValid;

	private static FFieldAddress Init_InInstanceName_PropertyAddress;

	private static int Init_InInstanceName_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGURootMotionSourceObject_Base:RemoveRootMotionSource")]
	public unsafe void RemoveRootMotionSource()
	{
		CheckDestroyed();
		if (!RemoveRootMotionSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGURootMotionSourceObject_Base:RemoveRootMotionSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveRootMotionSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveRootMotionSource_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemoveRootMotionSource_FunctionAddress, argsSize: RemoveRootMotionSource_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGURootMotionSourceObject_Base:Init")]
	public unsafe void Init(UCharacterMovementComponent MoveComp, FName InInstanceName)
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGURootMotionSourceObject_Base:Init");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCharacterMovementComponent>.ToNative(IntPtr.Add(intPtr, Init_MoveComp_Offset), 0, Init_MoveComp_PropertyAddress.Address, MoveComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Init_InInstanceName_Offset), 0, Init_InInstanceName_PropertyAddress.Address, InInstanceName);
		NativeReflection.InvokeFunctionOptimized(base.Address, Init_FunctionAddress, intPtr, Init_ParamsSize);
	}

	static UBGURootMotionSourceObject_Base()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGURootMotionSourceObject_Base)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGURootMotionSourceObject_Base));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGURootMotionSourceObject_Base");
		RemoveRootMotionSource_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveRootMotionSource");
		RemoveRootMotionSource_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveRootMotionSource_FunctionAddress);
		RemoveRootMotionSource_IsValid = RemoveRootMotionSource_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGURootMotionSourceObject_Base:RemoveRootMotionSource", RemoveRootMotionSource_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_MoveComp_PropertyAddress, Init_FunctionAddress, "MoveComp");
		Init_MoveComp_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "MoveComp");
		Init_MoveComp_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "MoveComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Init_InInstanceName_PropertyAddress, Init_FunctionAddress, "InInstanceName");
		Init_InInstanceName_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "InInstanceName");
		Init_InInstanceName_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "InInstanceName", Classes.FNameProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_MoveComp_IsValid && Init_InInstanceName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGURootMotionSourceObject_Base:Init", Init_IsValid);
	}
}
