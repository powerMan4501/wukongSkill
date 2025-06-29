using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAIT_RegisterAIElem")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_RegisterAIElem")]
internal class BAIT_RegisterAIElem : BAIT_Base
{
	private static bool ElemID_IsValid;

	private static int ElemID_Offset;

	private static bool ElemType_IsValid;

	private static int ElemType_Offset;

	private static FFieldAddress ElemType_PropertyAddress;

	private static bool Score_IsValid;

	private static int Score_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_RegisterAIElem:ElemID")]
	public int ElemID
	{
		get
		{
			CheckDestroyed();
			if (!ElemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RegisterAIElem:ElemID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ElemID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ElemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RegisterAIElem:ElemID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ElemID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_RegisterAIElem:ElemType")]
	public EAIElemType ElemType
	{
		get
		{
			CheckDestroyed();
			if (!ElemType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RegisterAIElem:ElemType");
				return EAIElemType.Think;
			}
			return EnumMarshaler<EAIElemType>.FromNative(IntPtr.Add(base.Address, ElemType_Offset), 0, ElemType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ElemType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RegisterAIElem:ElemType");
			}
			else
			{
				EnumMarshaler<EAIElemType>.ToNative(IntPtr.Add(base.Address, ElemType_Offset), 0, ElemType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_RegisterAIElem:Score")]
	public int Score
	{
		get
		{
			CheckDestroyed();
			if (!Score_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RegisterAIElem:Score");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Score_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Score_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RegisterAIElem:Score");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Score_Offset), value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_EventCollectionCS.Get(OwnerActor).Evt_RegisterAIElem.Invoke(ElemID, ElemType, Score);
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_RegisterAIElem");
		ElemID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ElemID");
		ElemID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ElemID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ElemType_PropertyAddress, unrealStruct, "ElemType");
		ElemType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ElemType");
		ElemType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ElemType", Classes.FEnumProperty);
		Score_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Score");
		Score_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Score", Classes.FIntProperty);
	}

	static BAIT_RegisterAIElem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_RegisterAIElem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_RegisterAIElem));
	}
}
