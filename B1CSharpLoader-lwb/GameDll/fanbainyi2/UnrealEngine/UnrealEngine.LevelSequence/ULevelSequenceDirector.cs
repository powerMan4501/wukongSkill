using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/LevelSequence.LevelSequenceDirector", "LevelSequence", UnrealModuleType.Engine)]
public class ULevelSequenceDirector : UObject
{
	private static bool Player_IsValid;

	private static int Player_Offset;

	private static bool OnCreated_IsValid;

	private IntPtr OnCreated_InstanceFunctionAddress;

	private static IntPtr OnCreated_FunctionAddress;

	private static int OnCreated_ParamsSize;

	private static bool GetSequence_IsValid;

	private static IntPtr GetSequence_FunctionAddress;

	private static int GetSequence_ParamsSize;

	private static bool GetSequence_ReturnValue_IsValid;

	private static FFieldAddress GetSequence_ReturnValue_PropertyAddress;

	private static int GetSequence_ReturnValue_Offset;

	private static bool GetBoundObjects_IsValid;

	private static IntPtr GetBoundObjects_FunctionAddress;

	private static int GetBoundObjects_ParamsSize;

	private static bool GetBoundObjects_ObjectBinding_IsValid;

	private static FFieldAddress GetBoundObjects_ObjectBinding_PropertyAddress;

	private static int GetBoundObjects_ObjectBinding_Offset;

	private static bool GetBoundObjects_ReturnValue_IsValid;

	private static FFieldAddress GetBoundObjects_ReturnValue_PropertyAddress;

	private static int GetBoundObjects_ReturnValue_Offset;

	private static bool GetBoundObject_IsValid;

	private static IntPtr GetBoundObject_FunctionAddress;

	private static int GetBoundObject_ParamsSize;

	private static bool GetBoundObject_ObjectBinding_IsValid;

	private static FFieldAddress GetBoundObject_ObjectBinding_PropertyAddress;

	private static int GetBoundObject_ObjectBinding_Offset;

	private static bool GetBoundObject_ReturnValue_IsValid;

	private static FFieldAddress GetBoundObject_ReturnValue_PropertyAddress;

	private static int GetBoundObject_ReturnValue_Offset;

	private static bool GetBoundActors_IsValid;

	private static IntPtr GetBoundActors_FunctionAddress;

	private static int GetBoundActors_ParamsSize;

	private static bool GetBoundActors_ObjectBinding_IsValid;

	private static FFieldAddress GetBoundActors_ObjectBinding_PropertyAddress;

	private static int GetBoundActors_ObjectBinding_Offset;

	private static bool GetBoundActors_ReturnValue_IsValid;

	private static FFieldAddress GetBoundActors_ReturnValue_PropertyAddress;

	private static int GetBoundActors_ReturnValue_Offset;

	private static bool GetBoundActor_IsValid;

	private static IntPtr GetBoundActor_FunctionAddress;

	private static int GetBoundActor_ParamsSize;

	private static bool GetBoundActor_ObjectBinding_IsValid;

	private static FFieldAddress GetBoundActor_ObjectBinding_PropertyAddress;

	private static int GetBoundActor_ObjectBinding_Offset;

	private static bool GetBoundActor_ReturnValue_IsValid;

	private static FFieldAddress GetBoundActor_ReturnValue_PropertyAddress;

	private static int GetBoundActor_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceDirector:Player")]
	public ULevelSequencePlayer Player
	{
		get
		{
			CheckDestroyed();
			if (!Player_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceDirector:Player");
				return null;
			}
			return UObjectMarshaler<ULevelSequencePlayer>.FromNative(IntPtr.Add(base.Address, Player_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Player_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.LevelSequenceDirector:Player");
			}
			else
			{
				UObjectMarshaler<ULevelSequencePlayer>.ToNative(IntPtr.Add(base.Address, Player_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceDirector:OnCreated")]
	public unsafe void OnCreated()
	{
		CheckDestroyed();
		if (!OnCreated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceDirector:OnCreated");
			return;
		}
		if (OnCreated_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnCreated_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnCreated");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCreated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCreated_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnCreated_InstanceFunctionAddress, argsSize: OnCreated_ParamsSize);
	}

	protected unsafe virtual void OnCreated_Implementation()
	{
		CheckDestroyed();
		if (!OnCreated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceDirector:OnCreated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCreated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCreated_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnCreated_FunctionAddress, argsSize: OnCreated_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceDirector:GetSequence")]
	public unsafe UMovieSceneSequence GetSequence()
	{
		CheckDestroyed();
		if (!GetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceDirector:GetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequence_FunctionAddress, intPtr, GetSequence_ParamsSize);
		return UObjectMarshaler<UMovieSceneSequence>.FromNative(IntPtr.Add(intPtr, GetSequence_ReturnValue_Offset), 0, GetSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceDirector:GetBoundObjects")]
	public unsafe List<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
	{
		CheckDestroyed();
		if (!GetBoundObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceDirector:GetBoundObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoundObjects_ObjectBinding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, GetBoundObjects_ObjectBinding_Offset), 0, GetBoundObjects_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundObjects_FunctionAddress, intPtr, GetBoundObjects_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetBoundObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoundObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoundObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceDirector:GetBoundObject")]
	public unsafe UObject GetBoundObject(FMovieSceneObjectBindingID ObjectBinding)
	{
		CheckDestroyed();
		if (!GetBoundObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceDirector:GetBoundObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoundObject_ObjectBinding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, GetBoundObject_ObjectBinding_Offset), 0, GetBoundObject_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundObject_FunctionAddress, intPtr, GetBoundObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetBoundObject_ReturnValue_Offset), 0, GetBoundObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceDirector:GetBoundActors")]
	public unsafe List<AActor> GetBoundActors(FMovieSceneObjectBindingID ObjectBinding)
	{
		CheckDestroyed();
		if (!GetBoundActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceDirector:GetBoundActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoundActors_ObjectBinding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, GetBoundActors_ObjectBinding_Offset), 0, GetBoundActors_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundActors_FunctionAddress, intPtr, GetBoundActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetBoundActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoundActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoundActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequence.LevelSequenceDirector:GetBoundActor")]
	public unsafe AActor GetBoundActor(FMovieSceneObjectBindingID ObjectBinding)
	{
		CheckDestroyed();
		if (!GetBoundActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequence.LevelSequenceDirector:GetBoundActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoundActor_ObjectBinding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, GetBoundActor_ObjectBinding_Offset), 0, GetBoundActor_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundActor_FunctionAddress, intPtr, GetBoundActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetBoundActor_ReturnValue_Offset), 0, GetBoundActor_ReturnValue_PropertyAddress.Address);
	}

	static ULevelSequenceDirector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelSequenceDirector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelSequenceDirector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/LevelSequence.LevelSequenceDirector");
		Player_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Player");
		Player_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Player", Classes.FObjectProperty);
		OnCreated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCreated");
		OnCreated_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCreated_FunctionAddress);
		OnCreated_IsValid = OnCreated_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceDirector:OnCreated", OnCreated_IsValid);
		GetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequence");
		GetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequence_ReturnValue_PropertyAddress, GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequence_IsValid = GetSequence_FunctionAddress != IntPtr.Zero && GetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceDirector:GetSequence", GetSequence_IsValid);
		GetBoundObjects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoundObjects");
		GetBoundObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_ObjectBinding_PropertyAddress, GetBoundObjects_FunctionAddress, "ObjectBinding");
		GetBoundObjects_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "ObjectBinding");
		GetBoundObjects_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_ReturnValue_PropertyAddress, GetBoundObjects_FunctionAddress, "ReturnValue");
		GetBoundObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "ReturnValue");
		GetBoundObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoundObjects_IsValid = GetBoundObjects_FunctionAddress != IntPtr.Zero && GetBoundObjects_ObjectBinding_IsValid && GetBoundObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceDirector:GetBoundObjects", GetBoundObjects_IsValid);
		GetBoundObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoundObject");
		GetBoundObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObject_ObjectBinding_PropertyAddress, GetBoundObject_FunctionAddress, "ObjectBinding");
		GetBoundObject_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObject_FunctionAddress, "ObjectBinding");
		GetBoundObject_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObject_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObject_ReturnValue_PropertyAddress, GetBoundObject_FunctionAddress, "ReturnValue");
		GetBoundObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObject_FunctionAddress, "ReturnValue");
		GetBoundObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBoundObject_IsValid = GetBoundObject_FunctionAddress != IntPtr.Zero && GetBoundObject_ObjectBinding_IsValid && GetBoundObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceDirector:GetBoundObject", GetBoundObject_IsValid);
		GetBoundActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoundActors");
		GetBoundActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundActors_ObjectBinding_PropertyAddress, GetBoundActors_FunctionAddress, "ObjectBinding");
		GetBoundActors_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundActors_FunctionAddress, "ObjectBinding");
		GetBoundActors_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundActors_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundActors_ReturnValue_PropertyAddress, GetBoundActors_FunctionAddress, "ReturnValue");
		GetBoundActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundActors_FunctionAddress, "ReturnValue");
		GetBoundActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoundActors_IsValid = GetBoundActors_FunctionAddress != IntPtr.Zero && GetBoundActors_ObjectBinding_IsValid && GetBoundActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceDirector:GetBoundActors", GetBoundActors_IsValid);
		GetBoundActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoundActor");
		GetBoundActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundActor_ObjectBinding_PropertyAddress, GetBoundActor_FunctionAddress, "ObjectBinding");
		GetBoundActor_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundActor_FunctionAddress, "ObjectBinding");
		GetBoundActor_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundActor_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundActor_ReturnValue_PropertyAddress, GetBoundActor_FunctionAddress, "ReturnValue");
		GetBoundActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundActor_FunctionAddress, "ReturnValue");
		GetBoundActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBoundActor_IsValid = GetBoundActor_FunctionAddress != IntPtr.Zero && GetBoundActor_ObjectBinding_IsValid && GetBoundActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequence.LevelSequenceDirector:GetBoundActor", GetBoundActor_IsValid);
	}
}
