using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationSharing;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AnimationSharing.AnimSharingStateInstance", "AnimationSharing", UnrealModuleType.EnginePlugin)]
public class UAnimSharingStateInstance : UAnimInstance
{
	private static bool AnimationToPlay_IsValid;

	private static int AnimationToPlay_Offset;

	private static bool PermutationTimeOffset_IsValid;

	private static int PermutationTimeOffset_Offset;

	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	private static bool StateBool_IsValid;

	private static FFieldAddress StateBool_PropertyAddress;

	private static int StateBool_Offset;

	private static bool GetInstancedActors_IsValid;

	private static IntPtr GetInstancedActors_FunctionAddress;

	private static int GetInstancedActors_ParamsSize;

	private static bool GetInstancedActors_Actors_IsValid;

	private static FFieldAddress GetInstancedActors_Actors_PropertyAddress;

	private static int GetInstancedActors_Actors_Offset;

	[UProperty(Flags = (PropFlags)12393764861583893uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingStateInstance:AnimationToPlay")]
	protected UAnimSequence AnimationToPlay
	{
		get
		{
			CheckDestroyed();
			if (!AnimationToPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingStateInstance:AnimationToPlay");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimationToPlay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimationToPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingStateInstance:AnimationToPlay");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimationToPlay_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954741269uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingStateInstance:PermutationTimeOffset")]
	protected float PermutationTimeOffset
	{
		get
		{
			CheckDestroyed();
			if (!PermutationTimeOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingStateInstance:PermutationTimeOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PermutationTimeOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PermutationTimeOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingStateInstance:PermutationTimeOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PermutationTimeOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954741269uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingStateInstance:PlayRate")]
	protected float PlayRate
	{
		get
		{
			CheckDestroyed();
			if (!PlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingStateInstance:PlayRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlayRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingStateInstance:PlayRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlayRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954741269uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingStateInstance:bStateBool")]
	protected bool StateBool
	{
		get
		{
			CheckDestroyed();
			if (!StateBool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingStateInstance:bStateBool");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StateBool_Offset), 0, StateBool_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StateBool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingStateInstance:bStateBool");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StateBool_Offset), 0, StateBool_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingStateInstance:GetInstancedActors")]
	protected unsafe void GetInstancedActors(out List<AActor> Actors)
	{
		CheckDestroyed();
		if (!GetInstancedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationSharing.AnimSharingStateInstance:GetInstancedActors");
			Actors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstancedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstancedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstancedActors_FunctionAddress, intPtr, GetInstancedActors_ParamsSize);
		Actors = new TArrayCopyMarshaler<AActor>(1, GetInstancedActors_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetInstancedActors_Actors_Offset));
		NativeReflection.DestroyValue_InContainer(GetInstancedActors_Actors_PropertyAddress.Address, intPtr);
	}

	static UAnimSharingStateInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimSharingStateInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimSharingStateInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AnimationSharing.AnimSharingStateInstance");
		AnimationToPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationToPlay");
		AnimationToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationToPlay", Classes.FObjectProperty);
		PermutationTimeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PermutationTimeOffset");
		PermutationTimeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PermutationTimeOffset", Classes.FFloatProperty);
		PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayRate");
		PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StateBool_PropertyAddress, intPtr, "bStateBool");
		StateBool_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStateBool");
		StateBool_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStateBool", Classes.FBoolProperty);
		GetInstancedActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInstancedActors");
		GetInstancedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstancedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstancedActors_Actors_PropertyAddress, GetInstancedActors_FunctionAddress, "Actors");
		GetInstancedActors_Actors_Offset = NativeReflectionCached.GetPropertyOffset(GetInstancedActors_FunctionAddress, "Actors");
		GetInstancedActors_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstancedActors_FunctionAddress, "Actors", Classes.FArrayProperty);
		GetInstancedActors_IsValid = GetInstancedActors_FunctionAddress != IntPtr.Zero && GetInstancedActors_Actors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationSharing.AnimSharingStateInstance:GetInstancedActors", GetInstancedActors_IsValid);
	}
}
