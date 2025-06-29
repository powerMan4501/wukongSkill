using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset")]
public class BGWCricketBattleDataAsset : UBGWDataAsset
{
	private static bool BuffId_IsValid;

	private static int BuffId_Offset;

	private static bool CameraWaitTime_IsValid;

	private static int CameraWaitTime_Offset;

	private static bool CameraBlendTime_IsValid;

	private static int CameraBlendTime_Offset;

	private static bool NameShowTime_IsValid;

	private static int NameShowTime_Offset;

	private static bool DelayShowName_IsValid;

	private static int DelayShowName_Offset;

	private static bool CricketUnitIndexList_IsValid;

	private static int CricketUnitIndexList_Offset;

	private static FFieldAddress CricketUnitIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> CricketUnitIndexList_Marshaler;

	private static bool PressStartGameTime_IsValid;

	private static int PressStartGameTime_Offset;

	private static bool PressBlackTime_IsValid;

	private static int PressBlackTime_Offset;

	private static bool BaodiKillTime_IsValid;

	private static int BaodiKillTime_Offset;

	[DisplayName("随机增强BuffId")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:BuffId")]
	public int BuffId
	{
		get
		{
			CheckDestroyed();
			if (!BuffId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:BuffId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:BuffId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("预热单位镜头停留时间")]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:CameraWaitTime")]
	public float CameraWaitTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:CameraWaitTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraWaitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:CameraWaitTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraWaitTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("预热单位镜头BlendTime")]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:CameraBlendTime")]
	public float CameraBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:CameraBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:CameraBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendTime_Offset), value);
			}
		}
	}

	[DisplayName("铭牌展示时间")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:NameShowTime")]
	public float NameShowTime
	{
		get
		{
			CheckDestroyed();
			if (!NameShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:NameShowTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NameShowTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NameShowTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:NameShowTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NameShowTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("切镜后延迟显示铭牌时间")]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:DelayShowName")]
	public float DelayShowName
	{
		get
		{
			CheckDestroyed();
			if (!DelayShowName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:DelayShowName");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayShowName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayShowName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:DelayShowName");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayShowName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("本地测试单位数据")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:CricketUnitIndexList")]
	public TArrayReadWrite<int> CricketUnitIndexList
	{
		get
		{
			CheckDestroyed();
			if (!CricketUnitIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:CricketUnitIndexList");
				return null;
			}
			if (CricketUnitIndexList_Marshaler == null)
			{
				CricketUnitIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, CricketUnitIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return CricketUnitIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, CricketUnitIndexList_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("长按开启战斗时间")]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:PressStartGameTime")]
	public float PressStartGameTime
	{
		get
		{
			CheckDestroyed();
			if (!PressStartGameTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:PressStartGameTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PressStartGameTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressStartGameTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:PressStartGameTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PressStartGameTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("长按开关黑屏时间")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:PressBlackTime")]
	public float PressBlackTime
	{
		get
		{
			CheckDestroyed();
			if (!PressBlackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:PressBlackTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PressBlackTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressBlackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:PressBlackTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PressBlackTime_Offset), value);
			}
		}
	}

	[DisplayName("保底击杀单位时间间隔")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWCricketBattleDataAsset:BaodiKillTime")]
	public float BaodiKillTime
	{
		get
		{
			CheckDestroyed();
			if (!BaodiKillTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:BaodiKillTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BaodiKillTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaodiKillTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCricketBattleDataAsset:BaodiKillTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BaodiKillTime_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWCricketBattleDataAsset");
		BuffId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffId");
		BuffId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffId", Classes.FIntProperty);
		CameraWaitTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraWaitTime");
		CameraWaitTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraWaitTime", Classes.FFloatProperty);
		CameraBlendTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBlendTime");
		CameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBlendTime", Classes.FFloatProperty);
		NameShowTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NameShowTime");
		NameShowTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NameShowTime", Classes.FFloatProperty);
		DelayShowName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DelayShowName");
		DelayShowName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DelayShowName", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CricketUnitIndexList_PropertyAddress, unrealStruct, "CricketUnitIndexList");
		CricketUnitIndexList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CricketUnitIndexList");
		CricketUnitIndexList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CricketUnitIndexList", Classes.FArrayProperty);
		PressStartGameTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PressStartGameTime");
		PressStartGameTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PressStartGameTime", Classes.FFloatProperty);
		PressBlackTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PressBlackTime");
		PressBlackTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PressBlackTime", Classes.FFloatProperty);
		BaodiKillTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BaodiKillTime");
		BaodiKillTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BaodiKillTime", Classes.FFloatProperty);
	}

	static BGWCricketBattleDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWCricketBattleDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWCricketBattleDataAsset));
	}
}
