using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_InteractComp")]
public class BUS_InteractComp : UActorEditCompBase
{
	private static bool InteractiveUnitID_IsValid;

	private static int InteractiveUnitID_Offset;

	private static bool DefalutInteractiveGroupID_IsValid;

	private static int DefalutInteractiveGroupID_Offset;

	private static bool ShopID_IsValid;

	private static int ShopID_Offset;

	private static bool RewardDropID_IsValid;

	private static int RewardDropID_Offset;

	private static bool InteractAnchorOverride_IsValid;

	private static int InteractAnchorOverride_Offset;

	private static bool ObjectMaterial_IsValid;

	private static int ObjectMaterial_Offset;

	private static FFieldAddress ObjectMaterial_PropertyAddress;

	private static bool ActivableDistance_IsValid;

	private static int ActivableDistance_Offset;

	[DisplayName("单位交互ID")]
	[Category("InteractConfig")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_InteractComp:InteractiveUnitID")]
	public int InteractiveUnitID
	{
		get
		{
			CheckDestroyed();
			if (!InteractiveUnitID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:InteractiveUnitID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InteractiveUnitID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractiveUnitID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:InteractiveUnitID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InteractiveUnitID_Offset), value);
			}
		}
	}

	[DisplayName("默认单位交互组ID")]
	[Tooltip("为-1则使用表格数据")]
	[UProperty]
	[EditAnywhere]
	[Category("InteractConfig")]
	[USharpPath("/Script/b1-Managed.BUS_InteractComp:DefalutInteractiveGroupID")]
	public int DefalutInteractiveGroupID
	{
		get
		{
			CheckDestroyed();
			if (!DefalutInteractiveGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:DefalutInteractiveGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefalutInteractiveGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefalutInteractiveGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:DefalutInteractiveGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefalutInteractiveGroupID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("InteractConfig")]
	[DisplayName("商店ID")]
	[USharpPath("/Script/b1-Managed.BUS_InteractComp:ShopID")]
	public int ShopID
	{
		get
		{
			CheckDestroyed();
			if (!ShopID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:ShopID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ShopID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShopID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:ShopID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ShopID_Offset), value);
			}
		}
	}

	[DisplayName("交互奖励掉落组ID")]
	[Category("InteractConfig")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_InteractComp:RewardDropID")]
	public int RewardDropID
	{
		get
		{
			CheckDestroyed();
			if (!RewardDropID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:RewardDropID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RewardDropID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RewardDropID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:RewardDropID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RewardDropID_Offset), value);
			}
		}
	}

	[DisplayName("交互锚点Override")]
	[UProperty]
	[EditAnywhere]
	[Category("InteractConfig")]
	[USharpPath("/Script/b1-Managed.BUS_InteractComp:InteractAnchorOverride")]
	public FName InteractAnchorOverride
	{
		get
		{
			CheckDestroyed();
			if (!InteractAnchorOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:InteractAnchorOverride");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, InteractAnchorOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractAnchorOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:InteractAnchorOverride");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, InteractAnchorOverride_Offset), value);
			}
		}
	}

	[DisplayName("材料(声音相关)")]
	[EditAnywhere]
	[Category("InteractConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_InteractComp:ObjectMaterial")]
	public InteractiveObjectMaterial ObjectMaterial
	{
		get
		{
			CheckDestroyed();
			if (!ObjectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:ObjectMaterial");
				return InteractiveObjectMaterial.Default;
			}
			return EnumMarshaler<InteractiveObjectMaterial>.FromNative(IntPtr.Add(base.Address, ObjectMaterial_Offset), 0, ObjectMaterial_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ObjectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:ObjectMaterial");
			}
			else
			{
				EnumMarshaler<InteractiveObjectMaterial>.ToNative(IntPtr.Add(base.Address, ObjectMaterial_Offset), 0, ObjectMaterial_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("提示距离")]
	[UProperty]
	[EditAnywhere]
	[Category("InteractConfig")]
	[Tooltip("为-1则使用表格数据")]
	[USharpPath("/Script/b1-Managed.BUS_InteractComp:ActivableDistance")]
	public float ActivableDistance
	{
		get
		{
			CheckDestroyed();
			if (!ActivableDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:ActivableDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ActivableDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActivableDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractComp:ActivableDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ActivableDistance_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		DefalutInteractiveGroupID = -1;
		RewardDropID = -1;
		ActivableDistance = -1f;
	}

	public override void OnDataConvert(AActor Owner)
	{
		if (!(GetOwner() is BGUCharacterCS))
		{
			BUC_InteractData bUC_InteractData = RequireWritableData<BUC_InteractData>();
			bUC_InteractData.InteractiveUnitID = InteractiveUnitID;
			bUC_InteractData.InstOverrideInteractiveGroupID = DefalutInteractiveGroupID;
			bUC_InteractData.ShopID = ShopID;
			bUC_InteractData.RewardDropID = RewardDropID;
			bUC_InteractData.InteractAnchorOverride = InteractAnchorOverride;
			bUC_InteractData.ObjectMaterial = ObjectMaterial;
			bUC_InteractData.InstOverrideActivableDistance = ActivableDistance;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_InteractComp");
		InteractiveUnitID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractiveUnitID");
		InteractiveUnitID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractiveUnitID", Classes.FIntProperty);
		DefalutInteractiveGroupID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefalutInteractiveGroupID");
		DefalutInteractiveGroupID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefalutInteractiveGroupID", Classes.FIntProperty);
		ShopID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShopID");
		ShopID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShopID", Classes.FIntProperty);
		RewardDropID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RewardDropID");
		RewardDropID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RewardDropID", Classes.FIntProperty);
		InteractAnchorOverride_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractAnchorOverride");
		InteractAnchorOverride_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractAnchorOverride", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref ObjectMaterial_PropertyAddress, unrealStruct, "ObjectMaterial");
		ObjectMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObjectMaterial");
		ObjectMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObjectMaterial", Classes.FEnumProperty);
		ActivableDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ActivableDistance");
		ActivableDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ActivableDistance", Classes.FFloatProperty);
	}

	static BUS_InteractComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_InteractComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_InteractComp));
	}
}
