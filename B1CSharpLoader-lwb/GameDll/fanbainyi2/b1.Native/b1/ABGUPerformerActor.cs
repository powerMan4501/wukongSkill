using System;
using System.Runtime.CompilerServices;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUPerformerActor", "b1", UnrealModuleType.Game)]
public class ABGUPerformerActor : ABGUActorBase, ICalliopeSequencePerformer, IInterface
{
	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	private static bool CapsuleComponent_IsValid;

	private static int CapsuleComponent_Offset;

	private static bool SetOptimizeEnabled_IsValid;

	private static IntPtr SetOptimizeEnabled_FunctionAddress;

	private static int SetOptimizeEnabled_ParamsSize;

	private static bool SetOptimizeEnabled_bEnable_IsValid;

	private static FFieldAddress SetOptimizeEnabled_bEnable_PropertyAddress;

	private static int SetOptimizeEnabled_bEnable_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/b1.BGUPerformerActor:Mesh")]
	public USkeletalMeshComponent Mesh
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPerformerActor:Mesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, Mesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPerformerActor:Mesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, Mesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/b1.BGUPerformerActor:CapsuleComponent")]
	public UCapsuleComponent CapsuleComponent
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPerformerActor:CapsuleComponent");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, CapsuleComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPerformerActor:CapsuleComponent");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, CapsuleComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUPerformerActor:SetOptimizeEnabled")]
	public unsafe void SetOptimizeEnabled(bool bEnable)
	{
		CheckDestroyed();
		if (!SetOptimizeEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPerformerActor:SetOptimizeEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOptimizeEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOptimizeEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOptimizeEnabled_bEnable_Offset), 0, SetOptimizeEnabled_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOptimizeEnabled_FunctionAddress, intPtr, SetOptimizeEnabled_ParamsSize);
	}

	static ABGUPerformerActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUPerformerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUPerformerActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUPerformerActor");
		Mesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		CapsuleComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapsuleComponent");
		CapsuleComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapsuleComponent", Classes.FObjectProperty);
		SetOptimizeEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOptimizeEnabled");
		SetOptimizeEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOptimizeEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOptimizeEnabled_bEnable_PropertyAddress, SetOptimizeEnabled_FunctionAddress, "bEnable");
		SetOptimizeEnabled_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetOptimizeEnabled_FunctionAddress, "bEnable");
		SetOptimizeEnabled_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOptimizeEnabled_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetOptimizeEnabled_IsValid = SetOptimizeEnabled_FunctionAddress != IntPtr.Zero && SetOptimizeEnabled_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPerformerActor:SetOptimizeEnabled", SetOptimizeEnabled_IsValid);
	}
}
