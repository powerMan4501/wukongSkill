using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUTeleportPoint", "b1", UnrealModuleType.Game)]
public class ABGUTeleportPoint : AActor
{
	private static bool GetGSActorLablel_IsValid;

	private static IntPtr GetGSActorLablel_FunctionAddress;

	private static int GetGSActorLablel_ParamsSize;

	private static bool GetGSActorLablel_ReturnValue_IsValid;

	private static FFieldAddress GetGSActorLablel_ReturnValue_PropertyAddress;

	private static int GetGSActorLablel_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUTeleportPoint:GetGSActorLablel")]
	public unsafe string GetGSActorLablel()
	{
		CheckDestroyed();
		if (!GetGSActorLablel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTeleportPoint:GetGSActorLablel");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGSActorLablel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGSActorLablel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGSActorLablel_FunctionAddress, intPtr, GetGSActorLablel_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGSActorLablel_ReturnValue_Offset), 0, GetGSActorLablel_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGSActorLablel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static ABGUTeleportPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUTeleportPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUTeleportPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGUTeleportPoint");
		GetGSActorLablel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGSActorLablel");
		GetGSActorLablel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGSActorLablel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGSActorLablel_ReturnValue_PropertyAddress, GetGSActorLablel_FunctionAddress, "ReturnValue");
		GetGSActorLablel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGSActorLablel_FunctionAddress, "ReturnValue");
		GetGSActorLablel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSActorLablel_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGSActorLablel_IsValid = GetGSActorLablel_FunctionAddress != IntPtr.Zero && GetGSActorLablel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTeleportPoint:GetGSActorLablel", GetGSActorLablel_IsValid);
	}
}
