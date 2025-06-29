using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckStalemateMoveTimeAbove")]
internal class BAID_CheckStalemateMoveTimeAbove : BAID_Base
{
	private static bool TimeValue_IsValid;

	private static int TimeValue_Offset;

	private static bool bShowDebugLog_IsValid;

	private static int bShowDebugLog_Offset;

	private static FFieldAddress bShowDebugLog_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckStalemateMoveTimeAbove:TimeValue")]
	public float TimeValue
	{
		get
		{
			CheckDestroyed();
			if (!TimeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckStalemateMoveTimeAbove:TimeValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TimeValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckStalemateMoveTimeAbove:TimeValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TimeValue_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckStalemateMoveTimeAbove:bShowDebugLog")]
	public bool bShowDebugLog
	{
		get
		{
			CheckDestroyed();
			if (!bShowDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckStalemateMoveTimeAbove:bShowDebugLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowDebugLog_Offset), 0, bShowDebugLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckStalemateMoveTimeAbove:bShowDebugLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowDebugLog_Offset), 0, bShowDebugLog_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(OwnerActor);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		return unPersistentReadOnlyData.GetStalemateMoveTime() >= TimeValue;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckStalemateMoveTimeAbove");
		TimeValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TimeValue");
		TimeValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TimeValue", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bShowDebugLog_PropertyAddress, unrealStruct, "bShowDebugLog");
		bShowDebugLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bShowDebugLog");
		bShowDebugLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bShowDebugLog", Classes.FBoolProperty);
	}

	static BAID_CheckStalemateMoveTimeAbove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckStalemateMoveTimeAbove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckStalemateMoveTimeAbove));
	}
}
