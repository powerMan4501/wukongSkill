using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckBuffLayersFromBuffGroup")]
internal class BAID_CheckBuffLayersFromBuffGroup : BAID_Base
{
	private static bool BuffGroupID_IsValid;

	private static int BuffGroupID_Offset;

	private static bool TotalLayerCount_IsValid;

	private static int TotalLayerCount_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckBuffLayersFromBuffGroup:BuffGroupID")]
	public int BuffGroupID
	{
		get
		{
			CheckDestroyed();
			if (!BuffGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayersFromBuffGroup:BuffGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayersFromBuffGroup:BuffGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffGroupID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckBuffLayersFromBuffGroup:TotalLayerCount")]
	public int TotalLayerCount
	{
		get
		{
			CheckDestroyed();
			if (!TotalLayerCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayersFromBuffGroup:TotalLayerCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TotalLayerCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TotalLayerCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayersFromBuffGroup:TotalLayerCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TotalLayerCount_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor == null)
		{
			return false;
		}
		int ActiveBuffCount = 0;
		return BGUFunctionLibraryCS.BGUGetTotalBuffLayersFromBuffGroup(OwnerActor, BuffGroupID, ref ActiveBuffCount) >= TotalLayerCount;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckBuffLayersFromBuffGroup");
		BuffGroupID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffGroupID");
		BuffGroupID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffGroupID", Classes.FIntProperty);
		TotalLayerCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TotalLayerCount");
		TotalLayerCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TotalLayerCount", Classes.FIntProperty);
	}

	static BAID_CheckBuffLayersFromBuffGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckBuffLayersFromBuffGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckBuffLayersFromBuffGroup));
	}
}
