using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_BulletNumCheck")]
internal class BAID_BulletNumCheck : BAID_Base
{
	private static bool ProjectileIDFilter_IsValid;

	private static int ProjectileIDFilter_Offset;

	private static bool UperNumber_IsValid;

	private static int UperNumber_Offset;

	private static bool DestroyTimeFilter_IsValid;

	private static int DestroyTimeFilter_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("填 ‘0’ 代表所有子弹")]
	[USharpPath("/Script/b1-Managed.BAID_BulletNumCheck:ProjectileIDFilter")]
	public int ProjectileIDFilter
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileIDFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_BulletNumCheck:ProjectileIDFilter");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ProjectileIDFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileIDFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_BulletNumCheck:ProjectileIDFilter");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ProjectileIDFilter_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("子弹数大于等于上限值的时候")]
	[USharpPath("/Script/b1-Managed.BAID_BulletNumCheck:UperNumber")]
	public float UperNumber
	{
		get
		{
			CheckDestroyed();
			if (!UperNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_BulletNumCheck:UperNumber");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UperNumber_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UperNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_BulletNumCheck:UperNumber");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UperNumber_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("过滤生命时间小于该值的子弹")]
	[USharpPath("/Script/b1-Managed.BAID_BulletNumCheck:DestroyTimeFilter")]
	public float DestroyTimeFilter
	{
		get
		{
			CheckDestroyed();
			if (!DestroyTimeFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_BulletNumCheck:DestroyTimeFilter");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestroyTimeFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestroyTimeFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_BulletNumCheck:DestroyTimeFilter");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestroyTimeFilter_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		b1.BUC_ProjectileCtrData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.BUC_ProjectileCtrData>(bGUCharacterCS);
		if (readOnlyData == null)
		{
			return false;
		}
		int num = 0;
		if (readOnlyData.ProjectileList != null)
		{
			foreach (BGUProjectileBaseActor projectile in readOnlyData.ProjectileList)
			{
				BUC_ProjectileLifeData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileLifeData>(projectile);
				if (readOnlyData2 != null && (readOnlyData2.ProjectileLifeTimer == -1f || readOnlyData2.ProjectileLifeTimer > DestroyTimeFilter))
				{
					if (ProjectileIDFilter != 0 && projectile.GetProjectileID() == ProjectileIDFilter)
					{
						num++;
					}
					else if (ProjectileIDFilter == 0)
					{
						num++;
					}
				}
			}
		}
		if ((float)num >= UperNumber)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_BulletNumCheck");
		ProjectileIDFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProjectileIDFilter");
		ProjectileIDFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProjectileIDFilter", Classes.FIntProperty);
		UperNumber_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UperNumber");
		UperNumber_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UperNumber", Classes.FFloatProperty);
		DestroyTimeFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestroyTimeFilter");
		DestroyTimeFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestroyTimeFilter", Classes.FFloatProperty);
	}

	static BAID_BulletNumCheck()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_BulletNumCheck)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_BulletNumCheck));
	}
}
