using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[DisplayName("BossRushPlayerStart")]
[USharpPath("/Script/b1-Managed.BossRushPlayerStart")]
public class ABossRushPlayerStart : AActor
{
	private static bool bModifyLevelTag_IsValid;

	private static int bModifyLevelTag_Offset;

	private static FFieldAddress bModifyLevelTag_PropertyAddress;

	private static bool LevelTag_IsValid;

	private static int LevelTag_Offset;

	private static bool UseType_IsValid;

	private static int UseType_Offset;

	private static FFieldAddress UseType_PropertyAddress;

	private static bool SceneComponent_IsValid;

	private static int SceneComponent_Offset;

	private static bool ArrowComponent_IsValid;

	private static int ArrowComponent_Offset;

	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否允许修改关卡标记")]
	[USharpPath("/Script/b1-Managed.BossRushPlayerStart:bModifyLevelTag")]
	public bool bModifyLevelTag
	{
		get
		{
			CheckDestroyed();
			if (!bModifyLevelTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:bModifyLevelTag");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bModifyLevelTag_Offset), 0, bModifyLevelTag_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bModifyLevelTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:bModifyLevelTag");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bModifyLevelTag_Offset), 0, bModifyLevelTag_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("关卡标记")]
	[UMeta(MDProp.EditCondition, "bModifyLevelTag")]
	[USharpPath("/Script/b1-Managed.BossRushPlayerStart:LevelTag")]
	public FName LevelTag
	{
		get
		{
			CheckDestroyed();
			if (!LevelTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:LevelTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LevelTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:LevelTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LevelTag_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[DisplayName("出生点用途")]
	[USharpPath("/Script/b1-Managed.BossRushPlayerStart:UseType")]
	public EBossRushPlayerStartType UseType
	{
		get
		{
			CheckDestroyed();
			if (!UseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:UseType");
				return EBossRushPlayerStartType.None;
			}
			return EnumMarshaler<EBossRushPlayerStartType>.FromNative(IntPtr.Add(base.Address, UseType_Offset), 0, UseType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:UseType");
			}
			else
			{
				EnumMarshaler<EBossRushPlayerStartType>.ToNative(IntPtr.Add(base.Address, UseType_Offset), 0, UseType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushPlayerStart:SceneComponent")]
	public USceneComponent SceneComponent
	{
		get
		{
			CheckDestroyed();
			if (!SceneComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:SceneComponent");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, SceneComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:SceneComponent");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, SceneComponent_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BossRushPlayerStart:ArrowComponent")]
	public UArrowComponent ArrowComponent
	{
		get
		{
			CheckDestroyed();
			if (!ArrowComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:ArrowComponent");
				return null;
			}
			return UObjectMarshaler<UArrowComponent>.FromNative(IntPtr.Add(base.Address, ArrowComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArrowComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushPlayerStart:ArrowComponent");
			}
			else
			{
				UObjectMarshaler<UArrowComponent>.ToNative(IntPtr.Add(base.Address, ArrowComponent_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SceneComponent = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.SceneRoot);
		base.RootComponent = SceneComponent;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BossRushPlayerStart");
		NativeReflection.GetPropertyRef(ref bModifyLevelTag_PropertyAddress, unrealStruct, "bModifyLevelTag");
		bModifyLevelTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bModifyLevelTag");
		bModifyLevelTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bModifyLevelTag", Classes.FBoolProperty);
		LevelTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LevelTag");
		LevelTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LevelTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref UseType_PropertyAddress, unrealStruct, "UseType");
		UseType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseType");
		UseType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseType", Classes.FEnumProperty);
		SceneComponent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneComponent");
		SceneComponent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneComponent", Classes.FObjectProperty);
		ArrowComponent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ArrowComponent");
		ArrowComponent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ArrowComponent", Classes.FObjectProperty);
	}

	static ABossRushPlayerStart()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ABossRushPlayerStart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABossRushPlayerStart));
	}
}
