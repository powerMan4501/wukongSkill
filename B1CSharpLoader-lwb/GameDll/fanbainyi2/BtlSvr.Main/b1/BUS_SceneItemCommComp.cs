using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SceneItemCommComp")]
public class BUS_SceneItemCommComp : UActorEditCompBase
{
	private static bool TeleportTransform_IsValid;

	private static int TeleportTransform_Offset;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool NeedClosePhysicWhenReset_IsValid;

	private static int NeedClosePhysicWhenReset_Offset;

	private static FFieldAddress NeedClosePhysicWhenReset_PropertyAddress;

	[EditAnywhere]
	[Tooltip("只有Location有用；是当前SceneItem位置额外加上一个值")]
	[Category("Teleport Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SceneItemCommComp:TeleportTransform")]
	public FTransform TeleportTransform
	{
		get
		{
			CheckDestroyed();
			if (!TeleportTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneItemCommComp:TeleportTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, TeleportTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeleportTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneItemCommComp:TeleportTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, TeleportTransform_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Skill Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SceneItemCommComp:SkillID")]
	public int SkillID
	{
		get
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneItemCommComp:SkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneItemCommComp:SkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillID_Offset), value);
			}
		}
	}

	[Category("Skill Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SceneItemCommComp:NeedClosePhysicWhenReset")]
	public bool NeedClosePhysicWhenReset
	{
		get
		{
			CheckDestroyed();
			if (!NeedClosePhysicWhenReset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneItemCommComp:NeedClosePhysicWhenReset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedClosePhysicWhenReset_Offset), 0, NeedClosePhysicWhenReset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedClosePhysicWhenReset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneItemCommComp:NeedClosePhysicWhenReset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedClosePhysicWhenReset_Offset), 0, NeedClosePhysicWhenReset_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_SceneItemCommData bUC_SceneItemCommData = RequireWritableData<BUC_SceneItemCommData>();
		bUC_SceneItemCommData.Init();
		bUC_SceneItemCommData.CopyBPDataToData(TeleportTransform, BGUFuncLibActorTransformCS.BGUGetActorTransform(GetOwner()), SkillID, NeedClosePhysicWhenReset);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SceneItemCommComp");
		TeleportTransform_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TeleportTransform");
		TeleportTransform_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TeleportTransform", Classes.FStructProperty);
		SkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NeedClosePhysicWhenReset_PropertyAddress, unrealStruct, "NeedClosePhysicWhenReset");
		NeedClosePhysicWhenReset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedClosePhysicWhenReset");
		NeedClosePhysicWhenReset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedClosePhysicWhenReset", Classes.FBoolProperty);
	}

	static BUS_SceneItemCommComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SceneItemCommComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SceneItemCommComp));
	}
}
