using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation")]
public class BGWDataAsset_RebirthPointNavigation : UBGWDataAsset
{
	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool EFXNodeOffsetAll_IsValid;

	private static int EFXNodeOffsetAll_Offset;

	private static bool EFXNodeOffsetFirst_IsValid;

	private static int EFXNodeOffsetFirst_Offset;

	private static bool EFXNodeMaxNum_IsValid;

	private static int EFXNodeMaxNum_Offset;

	private static bool EFXMinDir_IsValid;

	private static int EFXMinDir_Offset;

	private static bool RefreshInterval_IsValid;

	private static int RefreshInterval_Offset;

	private static bool RefreshInterval_ResidentSound_IsValid;

	private static int RefreshInterval_ResidentSound_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:Template")]
	public TSubclassOf<AActor> Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:Template");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:Template");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[DisplayName("特效的位置偏移(每个路径点)")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeOffsetAll")]
	public FVector EFXNodeOffsetAll
	{
		get
		{
			CheckDestroyed();
			if (!EFXNodeOffsetAll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeOffsetAll");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, EFXNodeOffsetAll_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EFXNodeOffsetAll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeOffsetAll");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, EFXNodeOffsetAll_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("特效的位置偏移(第一个路径点)")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeOffsetFirst")]
	public FVector EFXNodeOffsetFirst
	{
		get
		{
			CheckDestroyed();
			if (!EFXNodeOffsetFirst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeOffsetFirst");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, EFXNodeOffsetFirst_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EFXNodeOffsetFirst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeOffsetFirst");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, EFXNodeOffsetFirst_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("特效的最大路径点数量")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeMaxNum")]
	public int EFXNodeMaxNum
	{
		get
		{
			CheckDestroyed();
			if (!EFXNodeMaxNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeMaxNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EFXNodeMaxNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EFXNodeMaxNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXNodeMaxNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EFXNodeMaxNum_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("特效的最小生成距离")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXMinDir")]
	public int EFXMinDir
	{
		get
		{
			CheckDestroyed();
			if (!EFXMinDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXMinDir");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EFXMinDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EFXMinDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:EFXMinDir");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EFXMinDir_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("刷新间隔")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:RefreshInterval")]
	public float RefreshInterval
	{
		get
		{
			CheckDestroyed();
			if (!RefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:RefreshInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RefreshInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:RefreshInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RefreshInterval_Offset), value);
			}
		}
	}

	[DisplayName("刷新间隔(土地庙常驻音效)")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:RefreshInterval_ResidentSound")]
	public float RefreshInterval_ResidentSound
	{
		get
		{
			CheckDestroyed();
			if (!RefreshInterval_ResidentSound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:RefreshInterval_ResidentSound");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RefreshInterval_ResidentSound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RefreshInterval_ResidentSound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation:RefreshInterval_ResidentSound");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RefreshInterval_ResidentSound_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_RebirthPointNavigation");
		Template_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Template", Classes.FClassProperty);
		EFXNodeOffsetAll_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EFXNodeOffsetAll");
		EFXNodeOffsetAll_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EFXNodeOffsetAll", Classes.FStructProperty);
		EFXNodeOffsetFirst_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EFXNodeOffsetFirst");
		EFXNodeOffsetFirst_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EFXNodeOffsetFirst", Classes.FStructProperty);
		EFXNodeMaxNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EFXNodeMaxNum");
		EFXNodeMaxNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EFXNodeMaxNum", Classes.FIntProperty);
		EFXMinDir_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EFXMinDir");
		EFXMinDir_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EFXMinDir", Classes.FIntProperty);
		RefreshInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RefreshInterval");
		RefreshInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RefreshInterval", Classes.FFloatProperty);
		RefreshInterval_ResidentSound_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RefreshInterval_ResidentSound");
		RefreshInterval_ResidentSound_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RefreshInterval_ResidentSound", Classes.FFloatProperty);
	}

	static BGWDataAsset_RebirthPointNavigation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_RebirthPointNavigation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_RebirthPointNavigation));
	}
}
