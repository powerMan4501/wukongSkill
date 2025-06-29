using System;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckSurfaceType")]
public class BAID_CheckSurfaceType : BAID_Base
{
	private static bool SurfaceType_IsValid;

	private static int SurfaceType_Offset;

	private static FFieldAddress SurfaceType_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckSurfaceType:SurfaceType")]
	public ESceneItemSurfaceType SurfaceType
	{
		get
		{
			CheckDestroyed();
			if (!SurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSurfaceType:SurfaceType");
				return ESceneItemSurfaceType.DefaultSurface;
			}
			return EnumMarshaler<ESceneItemSurfaceType>.FromNative(IntPtr.Add(base.Address, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSurfaceType:SurfaceType");
			}
			else
			{
				EnumMarshaler<ESceneItemSurfaceType>.ToNative(IntPtr.Add(base.Address, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor.IsNullOrDestroyed())
		{
			return false;
		}
		IBUC_EnvironmentInteractionMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(OwnerActor);
		if (readOnlyData == null)
		{
			return false;
		}
		return readOnlyData.ResultSurfaceType == SurfaceType;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckSurfaceType");
		NativeReflection.GetPropertyRef(ref SurfaceType_PropertyAddress, unrealStruct, "SurfaceType");
		SurfaceType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SurfaceType");
		SurfaceType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SurfaceType", Classes.FEnumProperty);
	}

	static BAID_CheckSurfaceType()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckSurfaceType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckSurfaceType));
	}
}
