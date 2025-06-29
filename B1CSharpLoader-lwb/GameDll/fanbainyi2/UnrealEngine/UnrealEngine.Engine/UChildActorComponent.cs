using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ChildActorComponent", "Engine", UnrealModuleType.Engine)]
public class UChildActorComponent : USceneComponent
{
	private static bool ChildActorClass_IsValid;

	private static int ChildActorClass_Offset;

	private static bool ChildActor_IsValid;

	private static int ChildActor_Offset;

	private static bool SetChildActorClass_IsValid;

	private static IntPtr SetChildActorClass_FunctionAddress;

	private static int SetChildActorClass_ParamsSize;

	private static bool SetChildActorClass_InClass_IsValid;

	private static FFieldAddress SetChildActorClass_InClass_PropertyAddress;

	private static int SetChildActorClass_InClass_Offset;

	[UProperty(Flags = (PropFlags)21392168023228949uL)]
	[UMetaPath("/Script/Engine.ChildActorComponent:ChildActorClass")]
	public TSubclassOf<AActor> ChildActorClass
	{
		get
		{
			CheckDestroyed();
			if (!ChildActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ChildActorComponent:ChildActorClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ChildActorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChildActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ChildActorComponent:ChildActorClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ChildActorClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21603274255761972uL)]
	[UMetaPath("/Script/Engine.ChildActorComponent:ChildActor")]
	public AActor ChildActor
	{
		get
		{
			CheckDestroyed();
			if (!ChildActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ChildActorComponent:ChildActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ChildActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChildActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ChildActorComponent:ChildActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ChildActor_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ChildActorComponent:SetChildActorClass")]
	public unsafe void SetChildActorClass(TSubclassOf<AActor> InClass)
	{
		CheckDestroyed();
		if (!SetChildActorClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ChildActorComponent:SetChildActorClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChildActorClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChildActorClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetChildActorClass_InClass_Offset), 0, SetChildActorClass_InClass_PropertyAddress.Address, InClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetChildActorClass_FunctionAddress, intPtr, SetChildActorClass_ParamsSize);
	}

	static UChildActorComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UChildActorComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UChildActorComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.ChildActorComponent");
		ChildActorClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChildActorClass");
		ChildActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChildActorClass", Classes.FClassProperty);
		ChildActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChildActor");
		ChildActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChildActor", Classes.FObjectProperty);
		SetChildActorClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetChildActorClass");
		SetChildActorClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChildActorClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChildActorClass_InClass_PropertyAddress, SetChildActorClass_FunctionAddress, "InClass");
		SetChildActorClass_InClass_Offset = NativeReflectionCached.GetPropertyOffset(SetChildActorClass_FunctionAddress, "InClass");
		SetChildActorClass_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChildActorClass_FunctionAddress, "InClass", Classes.FClassProperty);
		SetChildActorClass_IsValid = SetChildActorClass_FunctionAddress != IntPtr.Zero && SetChildActorClass_InClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ChildActorComponent:SetChildActorClass", SetChildActorClass_IsValid);
	}
}
