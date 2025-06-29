using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)819986596uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGURootMotionFollowMovementComponent", "b1", UnrealModuleType.Game)]
public class UBGURootMotionFollowMovementComponent : UBGUCharacterMovementComponent
{
	private static bool GetMasterMoveComp_IsValid;

	private static IntPtr GetMasterMoveComp_FunctionAddress;

	private static int GetMasterMoveComp_ParamsSize;

	private static bool GetMasterMoveComp_ReturnValue_IsValid;

	private static FFieldAddress GetMasterMoveComp_ReturnValue_PropertyAddress;

	private static int GetMasterMoveComp_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGURootMotionFollowMovementComponent:GetMasterMoveComp")]
	public unsafe UBGUCharacterMovementComponent GetMasterMoveComp()
	{
		CheckDestroyed();
		if (!GetMasterMoveComp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGURootMotionFollowMovementComponent:GetMasterMoveComp");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMasterMoveComp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMasterMoveComp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMasterMoveComp_FunctionAddress, intPtr, GetMasterMoveComp_ParamsSize);
		return UObjectMarshaler<UBGUCharacterMovementComponent>.FromNative(IntPtr.Add(intPtr, GetMasterMoveComp_ReturnValue_Offset), 0, GetMasterMoveComp_ReturnValue_PropertyAddress.Address);
	}

	static UBGURootMotionFollowMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGURootMotionFollowMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGURootMotionFollowMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGURootMotionFollowMovementComponent");
		GetMasterMoveComp_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMasterMoveComp");
		GetMasterMoveComp_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMasterMoveComp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMasterMoveComp_ReturnValue_PropertyAddress, GetMasterMoveComp_FunctionAddress, "ReturnValue");
		GetMasterMoveComp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMasterMoveComp_FunctionAddress, "ReturnValue");
		GetMasterMoveComp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMasterMoveComp_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMasterMoveComp_IsValid = GetMasterMoveComp_FunctionAddress != IntPtr.Zero && GetMasterMoveComp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGURootMotionFollowMovementComponent:GetMasterMoveComp", GetMasterMoveComp_IsValid);
	}
}
