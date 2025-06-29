using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGPPlayerReverseReplicator", "b1", UnrealModuleType.Game)]
public class ABGPPlayerReverseReplicator : AActor
{
	private static bool SetOwnerBGUChr_IsValid;

	private static IntPtr SetOwnerBGUChr_FunctionAddress;

	private static int SetOwnerBGUChr_ParamsSize;

	private static bool SetOwnerBGUChr_BGUOwner_IsValid;

	private static FFieldAddress SetOwnerBGUChr_BGUOwner_PropertyAddress;

	private static int SetOwnerBGUChr_BGUOwner_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGPPlayerReverseReplicator:SetOwnerBGUChr")]
	public unsafe void SetOwnerBGUChr(ABGUCharacter BGUOwner)
	{
		CheckDestroyed();
		if (!SetOwnerBGUChr_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerReverseReplicator:SetOwnerBGUChr");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOwnerBGUChr_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOwnerBGUChr_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, SetOwnerBGUChr_BGUOwner_Offset), 0, SetOwnerBGUChr_BGUOwner_PropertyAddress.Address, BGUOwner);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOwnerBGUChr_FunctionAddress, intPtr, SetOwnerBGUChr_ParamsSize);
	}

	static ABGPPlayerReverseReplicator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGPPlayerReverseReplicator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGPPlayerReverseReplicator));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGPPlayerReverseReplicator");
		SetOwnerBGUChr_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetOwnerBGUChr");
		SetOwnerBGUChr_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOwnerBGUChr_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOwnerBGUChr_BGUOwner_PropertyAddress, SetOwnerBGUChr_FunctionAddress, "BGUOwner");
		SetOwnerBGUChr_BGUOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetOwnerBGUChr_FunctionAddress, "BGUOwner");
		SetOwnerBGUChr_BGUOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOwnerBGUChr_FunctionAddress, "BGUOwner", Classes.FObjectProperty);
		SetOwnerBGUChr_IsValid = SetOwnerBGUChr_FunctionAddress != IntPtr.Zero && SetOwnerBGUChr_BGUOwner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerReverseReplicator:SetOwnerBGUChr", SetOwnerBGUChr_IsValid);
	}
}
