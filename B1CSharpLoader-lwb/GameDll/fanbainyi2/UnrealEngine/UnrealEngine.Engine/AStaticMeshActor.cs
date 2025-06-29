using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.StaticMeshActor", "Engine", UnrealModuleType.Engine)]
public class AStaticMeshActor : AActor
{
	private static bool StaticMeshComponent_IsValid;

	private static int StaticMeshComponent_Offset;

	private static bool SetMobility_IsValid;

	private static IntPtr SetMobility_FunctionAddress;

	private static int SetMobility_ParamsSize;

	private static bool SetMobility_InMobility_IsValid;

	private static FFieldAddress SetMobility_InMobility_PropertyAddress;

	private static int SetMobility_InMobility_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.StaticMeshActor:StaticMeshComponent")]
	public UStaticMeshComponent StaticMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshActor:StaticMeshComponent");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, StaticMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshActor:StaticMeshComponent");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, StaticMeshComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StaticMeshActor:SetMobility")]
	public unsafe void SetMobility(EComponentMobility InMobility)
	{
		CheckDestroyed();
		if (!SetMobility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMeshActor:SetMobility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMobility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMobility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EComponentMobility>.ToNative(IntPtr.Add(intPtr, SetMobility_InMobility_Offset), 0, SetMobility_InMobility_PropertyAddress.Address, InMobility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMobility_FunctionAddress, intPtr, SetMobility_ParamsSize);
	}

	static AStaticMeshActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AStaticMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AStaticMeshActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.StaticMeshActor");
		StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticMeshComponent");
		StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticMeshComponent", Classes.FObjectProperty);
		SetMobility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMobility");
		SetMobility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMobility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMobility_InMobility_PropertyAddress, SetMobility_FunctionAddress, "InMobility");
		SetMobility_InMobility_Offset = NativeReflectionCached.GetPropertyOffset(SetMobility_FunctionAddress, "InMobility");
		SetMobility_InMobility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMobility_FunctionAddress, "InMobility", Classes.FByteProperty);
		SetMobility_IsValid = SetMobility_FunctionAddress != IntPtr.Zero && SetMobility_InMobility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMeshActor:SetMobility", SetMobility_IsValid);
	}
}
