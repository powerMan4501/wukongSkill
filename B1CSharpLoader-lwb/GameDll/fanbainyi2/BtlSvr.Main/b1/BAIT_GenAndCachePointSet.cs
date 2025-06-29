using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_GenAndCachePointSet")]
internal class BAIT_GenAndCachePointSet : BAIT_Base
{
	private static bool GenType_IsValid;

	private static int GenType_Offset;

	private static FFieldAddress GenType_PropertyAddress;

	private static bool GenExtParam_IsValid;

	private static int GenExtParam_Offset;

	private static bool RegisterID_IsValid;

	private static int RegisterID_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_GenAndCachePointSet:GenType")]
	public PointsGenType GenType
	{
		get
		{
			CheckDestroyed();
			if (!GenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_GenAndCachePointSet:GenType");
				return PointsGenType.ByEQS_Async;
			}
			return EnumMarshaler<PointsGenType>.FromNative(IntPtr.Add(base.Address, GenType_Offset), 0, GenType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_GenAndCachePointSet:GenType");
			}
			else
			{
				EnumMarshaler<PointsGenType>.ToNative(IntPtr.Add(base.Address, GenType_Offset), 0, GenType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_GenAndCachePointSet:GenExtParam")]
	public PointsGenExtParam GenExtParam
	{
		get
		{
			CheckDestroyed();
			if (!GenExtParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_GenAndCachePointSet:GenExtParam");
				return default(PointsGenExtParam);
			}
			return PointsGenExtParam.FromNative(IntPtr.Add(base.Address, GenExtParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GenExtParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_GenAndCachePointSet:GenExtParam");
			}
			else
			{
				PointsGenExtParam.ToNative(IntPtr.Add(base.Address, GenExtParam_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_GenAndCachePointSet:RegisterID")]
	public int RegisterID
	{
		get
		{
			CheckDestroyed();
			if (!RegisterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_GenAndCachePointSet:RegisterID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RegisterID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RegisterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_GenAndCachePointSet:RegisterID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RegisterID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		GenType = PointsGenType.ByEQS_Async;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter == null)
		{
			FinishExecute(bSuccess: false);
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_CallPointsRegister.Invoke(RegisterID, GenType, GenExtParam);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_GenAndCachePointSet");
		NativeReflection.GetPropertyRef(ref GenType_PropertyAddress, unrealStruct, "GenType");
		GenType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GenType");
		GenType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GenType", Classes.FEnumProperty);
		GenExtParam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GenExtParam");
		GenExtParam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GenExtParam", Classes.FStructProperty);
		RegisterID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RegisterID");
		RegisterID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RegisterID", Classes.FIntProperty);
	}

	static BAIT_GenAndCachePointSet()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_GenAndCachePointSet)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_GenAndCachePointSet));
	}
}
