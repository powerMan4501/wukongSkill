using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("设置连招套数（打多少次Combo）")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SetMaxComboValue")]
internal class BAIT_SetMaxComboValue : BAIT_Base
{
	private static bool ComboNumMin_IsValid;

	private static int ComboNumMin_Offset;

	private static bool ComboNumMax_IsValid;

	private static int ComboNumMax_Offset;

	private static bool bEnableDebugLog_IsValid;

	private static int bEnableDebugLog_Offset;

	private static FFieldAddress bEnableDebugLog_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_SetMaxComboValue:ComboNumMin")]
	public int ComboNumMin
	{
		get
		{
			CheckDestroyed();
			if (!ComboNumMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetMaxComboValue:ComboNumMin");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ComboNumMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ComboNumMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetMaxComboValue:ComboNumMin");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ComboNumMin_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SetMaxComboValue:ComboNumMax")]
	public int ComboNumMax
	{
		get
		{
			CheckDestroyed();
			if (!ComboNumMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetMaxComboValue:ComboNumMax");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ComboNumMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ComboNumMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetMaxComboValue:ComboNumMax");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ComboNumMax_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SetMaxComboValue:bEnableDebugLog")]
	public bool bEnableDebugLog
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetMaxComboValue:bEnableDebugLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebugLog_Offset), 0, bEnableDebugLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetMaxComboValue:bEnableDebugLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebugLog_Offset), 0, bEnableDebugLog_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			int num = MathLib.RandomIntInRange(ComboNumMin, ComboNumMax);
			FMath.Clamp(num, 0, num);
			BUS_EventCollectionCS.Get(actor).Evt_SetMaxComboNum.Invoke(num);
			_ = bEnableDebugLog;
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SetMaxComboValue");
		ComboNumMin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ComboNumMin");
		ComboNumMin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ComboNumMin", Classes.FIntProperty);
		ComboNumMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ComboNumMax");
		ComboNumMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ComboNumMax", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebugLog_PropertyAddress, unrealStruct, "bEnableDebugLog");
		bEnableDebugLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDebugLog");
		bEnableDebugLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDebugLog", Classes.FBoolProperty);
	}

	static BAIT_SetMaxComboValue()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_SetMaxComboValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_SetMaxComboValue));
	}
}
