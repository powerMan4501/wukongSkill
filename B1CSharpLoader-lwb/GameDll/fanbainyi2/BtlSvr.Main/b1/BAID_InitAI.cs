using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_InitAI")]
internal class BAID_InitAI : BAID_Base
{
	private static bool IsLoaded_IsValid;

	private static int IsLoaded_Offset;

	private static FFieldAddress IsLoaded_PropertyAddress;

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_InitAI:IsLoaded")]
	public bool IsLoaded
	{
		get
		{
			CheckDestroyed();
			if (!IsLoaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_InitAI:IsLoaded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsLoaded_Offset), 0, IsLoaded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsLoaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_InitAI:IsLoaded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsLoaded_Offset), 0, IsLoaded_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (IsLoaded)
		{
			return false;
		}
		IsLoaded = true;
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_InitAI");
		NativeReflection.GetPropertyRef(ref IsLoaded_PropertyAddress, unrealStruct, "IsLoaded");
		IsLoaded_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsLoaded");
		IsLoaded_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsLoaded", Classes.FBoolProperty);
	}

	static BAID_InitAI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_InitAI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_InitAI));
	}
}
