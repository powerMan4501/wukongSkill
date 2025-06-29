using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting")]
public class BGWDataAsset_ScaleTimeSetting : UBGWDataAsset
{
	private static bool TimeScale_IsValid;

	private static int TimeScale_Offset;

	private static bool TotalTime_IsValid;

	private static int TotalTime_Offset;

	private static bool BlendInRealTime_IsValid;

	private static int BlendInRealTime_Offset;

	private static bool BlendInType_IsValid;

	private static int BlendInType_Offset;

	private static FFieldAddress BlendInType_PropertyAddress;

	private static bool BlendInExp_IsValid;

	private static int BlendInExp_Offset;

	private static bool BlendOutRealTime_IsValid;

	private static int BlendOutRealTime_Offset;

	private static bool BlendOutType_IsValid;

	private static int BlendOutType_Offset;

	private static FFieldAddress BlendOutType_PropertyAddress;

	private static bool BlendOutExp_IsValid;

	private static int BlendOutExp_Offset;

	[Category("ScaleTimeSetting")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:TimeScale")]
	public float TimeScale
	{
		get
		{
			CheckDestroyed();
			if (!TimeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:TimeScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TimeScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:TimeScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TimeScale_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("ScaleTimeSetting")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:TotalTime")]
	public float TotalTime
	{
		get
		{
			CheckDestroyed();
			if (!TotalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:TotalTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TotalTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TotalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:TotalTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TotalTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("ScaleTimeSetting|BlendIn")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInRealTime")]
	public float BlendInRealTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInRealTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInRealTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInRealTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInRealTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInRealTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInRealTime_Offset), value);
			}
		}
	}

	[Category("ScaleTimeSetting|BlendIn")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInType")]
	public EGSBlendTypeG BlendInType
	{
		get
		{
			CheckDestroyed();
			if (!BlendInType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInType");
				return EGSBlendTypeG.GSNone;
			}
			return EnumMarshaler<EGSBlendTypeG>.FromNative(IntPtr.Add(base.Address, BlendInType_Offset), 0, BlendInType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendInType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInType");
			}
			else
			{
				EnumMarshaler<EGSBlendTypeG>.ToNative(IntPtr.Add(base.Address, BlendInType_Offset), 0, BlendInType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("ScaleTimeSetting|BlendIn")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInExp")]
	public float BlendInExp
	{
		get
		{
			CheckDestroyed();
			if (!BlendInExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendInExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInExp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("ScaleTimeSetting|BlendOut")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutRealTime")]
	public float BlendOutRealTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutRealTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutRealTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutRealTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutRealTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutRealTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutRealTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("ScaleTimeSetting|BlendOut")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutType")]
	public EGSBlendTypeG BlendOutType
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutType");
				return EGSBlendTypeG.GSNone;
			}
			return EnumMarshaler<EGSBlendTypeG>.FromNative(IntPtr.Add(base.Address, BlendOutType_Offset), 0, BlendOutType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutType");
			}
			else
			{
				EnumMarshaler<EGSBlendTypeG>.ToNative(IntPtr.Add(base.Address, BlendOutType_Offset), 0, BlendOutType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("ScaleTimeSetting|BlendOut")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutExp")]
	public float BlendOutExp
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting:BlendOutExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutExp_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_ScaleTimeSetting");
		TimeScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TimeScale");
		TimeScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TimeScale", Classes.FFloatProperty);
		TotalTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TotalTime");
		TotalTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TotalTime", Classes.FFloatProperty);
		BlendInRealTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendInRealTime");
		BlendInRealTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendInRealTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BlendInType_PropertyAddress, unrealStruct, "BlendInType");
		BlendInType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendInType");
		BlendInType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendInType", Classes.FEnumProperty);
		BlendInExp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendInExp");
		BlendInExp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendInExp", Classes.FFloatProperty);
		BlendOutRealTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendOutRealTime");
		BlendOutRealTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendOutRealTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BlendOutType_PropertyAddress, unrealStruct, "BlendOutType");
		BlendOutType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendOutType");
		BlendOutType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendOutType", Classes.FEnumProperty);
		BlendOutExp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendOutExp");
		BlendOutExp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendOutExp", Classes.FFloatProperty);
	}

	static BGWDataAsset_ScaleTimeSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_ScaleTimeSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_ScaleTimeSetting));
	}
}
