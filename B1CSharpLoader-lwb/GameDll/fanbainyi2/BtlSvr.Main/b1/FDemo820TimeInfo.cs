using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.Demo820TimeInfo")]
public struct FDemo820TimeInfo
{
	[BlueprintReadWrite]
	[DisplayName("剩余时间(秒)时显示时间Tips(小)(常驻)")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.Demo820TimeInfo:SmallTipsTimeDur")]
	public float SmallTipsTimeDur;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("剩余时间(秒)时显示时间Tips(常驻)")]
	[USharpPath("/Script/b1-Managed.Demo820TimeInfo:TipsTimeDur")]
	public float TipsTimeDur;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("剩余时间(秒)时显示时间Tips(提示)")]
	[USharpPath("/Script/b1-Managed.Demo820TimeInfo:TipsTime")]
	public List<int> TipsTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("最大游玩时间(秒)")]
	[USharpPath("/Script/b1-Managed.Demo820TimeInfo:GameplayTimeMax")]
	public float GameplayTimeMax;

	private static int Demo820TimeInfo_StructSize;

	private static int Demo820TimeInfo_IsValid;

	private static bool SmallTipsTimeDur_IsValid;

	private static int SmallTipsTimeDur_Offset;

	private static bool TipsTimeDur_IsValid;

	private static int TipsTimeDur_Offset;

	private static bool TipsTime_IsValid;

	private static int TipsTime_Offset;

	private static FFieldAddress TipsTime_PropertyAddress;

	private static bool GameplayTimeMax_IsValid;

	private static int GameplayTimeMax_Offset;

	public FDemo820TimeInfo Copy()
	{
		FDemo820TimeInfo result = this;
		if (TipsTime != null)
		{
			result.TipsTime = new List<int>(TipsTime);
		}
		return result;
	}

	public static FDemo820TimeInfo FromNative(IntPtr nativeBuffer)
	{
		return new FDemo820TimeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDemo820TimeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDemo820TimeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDemo820TimeInfo(IntPtr.Add(nativeBuffer, arrayIndex * Demo820TimeInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDemo820TimeInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * Demo820TimeInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (Demo820TimeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.Demo820TimeInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SmallTipsTimeDur_Offset), SmallTipsTimeDur);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TipsTimeDur_Offset), TipsTimeDur);
		new TArrayCopyMarshaler<int>(1, TipsTime_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TipsTime_Offset), TipsTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GameplayTimeMax_Offset), GameplayTimeMax);
	}

	public FDemo820TimeInfo(IntPtr nativeStruct)
	{
		if (Demo820TimeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.Demo820TimeInfo");
			SmallTipsTimeDur = 0f;
			TipsTimeDur = 0f;
			TipsTime = null;
			GameplayTimeMax = 0f;
		}
		else
		{
			SmallTipsTimeDur = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SmallTipsTimeDur_Offset));
			TipsTimeDur = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TipsTimeDur_Offset));
			TipsTime = new TArrayCopyMarshaler<int>(1, TipsTime_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TipsTime_Offset));
			GameplayTimeMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GameplayTimeMax_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.Demo820TimeInfo");
		Demo820TimeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		SmallTipsTimeDur_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmallTipsTimeDur");
		SmallTipsTimeDur_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmallTipsTimeDur", Classes.FFloatProperty);
		TipsTimeDur_Offset = NativeReflection.GetPropertyOffset(intPtr, "TipsTimeDur");
		TipsTimeDur_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TipsTimeDur", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TipsTime_PropertyAddress, intPtr, "TipsTime");
		TipsTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "TipsTime");
		TipsTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TipsTime", Classes.FArrayProperty);
		GameplayTimeMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "GameplayTimeMax");
		GameplayTimeMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GameplayTimeMax", Classes.FFloatProperty);
		Demo820TimeInfo_IsValid = ((intPtr != IntPtr.Zero && SmallTipsTimeDur_IsValid && TipsTimeDur_IsValid && TipsTime_IsValid && GameplayTimeMax_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.Demo820TimeInfo", (byte)Demo820TimeInfo_IsValid != 0);
	}

	static FDemo820TimeInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDemo820TimeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDemo820TimeInfo));
	}
}
