using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp")]
public class BUS_DestructibleDestroyEffectTriggerComp : UActorEditCompBase
{
	private static bool DestructibleTag_IsValid;

	private static int DestructibleTag_Offset;

	private static bool EffectIDs_IsValid;

	private static int EffectIDs_Offset;

	private static FFieldAddress EffectIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> EffectIDs_Marshaler;

	private static bool BuffIDs_IsValid;

	private static int BuffIDs_Offset;

	private static FFieldAddress BuffIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BuffIDs_Marshaler;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("破碎物Tag")]
	[Category("DestructibleDestroyConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp:DestructibleTag")]
	public FName DestructibleTag
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp:DestructibleTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DestructibleTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp:DestructibleTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DestructibleTag_Offset), value);
			}
		}
	}

	[Category("DestructibleDestroyConfig")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("破碎触发EffectID")]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp:EffectIDs")]
	public TArrayReadWrite<int> EffectIDs
	{
		get
		{
			CheckDestroyed();
			if (!EffectIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp:EffectIDs");
				return null;
			}
			if (EffectIDs_Marshaler == null)
			{
				EffectIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, EffectIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return EffectIDs_Marshaler.FromNative(IntPtr.Add(base.Address, EffectIDs_Offset));
		}
	}

	[DisplayName("破碎添加BuffID")]
	[Category("DestructibleDestroyConfig")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp:BuffIDs")]
	public TArrayReadWrite<int> BuffIDs
	{
		get
		{
			CheckDestroyed();
			if (!BuffIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp:BuffIDs");
				return null;
			}
			if (BuffIDs_Marshaler == null)
			{
				BuffIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, BuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BuffIDs_Marshaler.FromNative(IntPtr.Add(base.Address, BuffIDs_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_DestructibleDestroyEffectTriggerData bUC_DestructibleDestroyEffectTriggerData = RequireWritableData<BUC_DestructibleDestroyEffectTriggerData>();
		bUC_DestructibleDestroyEffectTriggerData.DestructibleTag = DestructibleTag;
		bUC_DestructibleDestroyEffectTriggerData.EffectIDs = EffectIDs.ToList();
		bUC_DestructibleDestroyEffectTriggerData.BuffIDs = BuffIDs.ToList();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_DestructibleDestroyEffectTriggerComp");
		DestructibleTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestructibleTag");
		DestructibleTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestructibleTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref EffectIDs_PropertyAddress, unrealStruct, "EffectIDs");
		EffectIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EffectIDs");
		EffectIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EffectIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BuffIDs_PropertyAddress, unrealStruct, "BuffIDs");
		BuffIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffIDs");
		BuffIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffIDs", Classes.FArrayProperty);
	}

	static BUS_DestructibleDestroyEffectTriggerComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DestructibleDestroyEffectTriggerComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DestructibleDestroyEffectTriggerComp));
	}
}
