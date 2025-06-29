using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig")]
public class BGWDataAsset_AIPerceptionConfig : UBGWDataAsset
{
	private static bool HearRange_IsValid;

	private static int HearRange_Offset;

	private static bool SightRange_IsValid;

	private static int SightRange_Offset;

	private static bool LoseSightRange_IsValid;

	private static int LoseSightRange_Offset;

	private static bool VisionAngleDegrees_IsValid;

	private static int VisionAngleDegrees_Offset;

	private static bool ASRangeFromLastSeenLoc_IsValid;

	private static int ASRangeFromLastSeenLoc_Offset;

	private static bool IsSightDominantSense_IsValid;

	private static int IsSightDominantSense_Offset;

	private static FFieldAddress IsSightDominantSense_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("听力范围")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:HearRange")]
	public float HearRange
	{
		get
		{
			CheckDestroyed();
			if (!HearRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:HearRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HearRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HearRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:HearRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HearRange_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("视野范围")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:SightRange")]
	public float SightRange
	{
		get
		{
			CheckDestroyed();
			if (!SightRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:SightRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SightRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SightRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:SightRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SightRange_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("丢失视野范围")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:LoseSightRange")]
	public float LoseSightRange
	{
		get
		{
			CheckDestroyed();
			if (!LoseSightRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:LoseSightRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LoseSightRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoseSightRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:LoseSightRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LoseSightRange_Offset), value);
			}
		}
	}

	[DisplayName("视野夹角")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:VisionAngleDegrees")]
	public float VisionAngleDegrees
	{
		get
		{
			CheckDestroyed();
			if (!VisionAngleDegrees_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:VisionAngleDegrees");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VisionAngleDegrees_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VisionAngleDegrees_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:VisionAngleDegrees");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VisionAngleDegrees_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("距离上次发现点假装再次发现的距离")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:ASRangeFromLastSeenLoc")]
	public float ASRangeFromLastSeenLoc
	{
		get
		{
			CheckDestroyed();
			if (!ASRangeFromLastSeenLoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:ASRangeFromLastSeenLoc");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ASRangeFromLastSeenLoc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASRangeFromLastSeenLoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:ASRangeFromLastSeenLoc");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ASRangeFromLastSeenLoc_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否设置视野为主导意识")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:IsSightDominantSense")]
	public bool IsSightDominantSense
	{
		get
		{
			CheckDestroyed();
			if (!IsSightDominantSense_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:IsSightDominantSense");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSightDominantSense_Offset), 0, IsSightDominantSense_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSightDominantSense_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig:IsSightDominantSense");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSightDominantSense_Offset), 0, IsSightDominantSense_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AIPerceptionConfig");
		HearRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HearRange");
		HearRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HearRange", Classes.FFloatProperty);
		SightRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SightRange");
		SightRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SightRange", Classes.FFloatProperty);
		LoseSightRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LoseSightRange");
		LoseSightRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LoseSightRange", Classes.FFloatProperty);
		VisionAngleDegrees_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VisionAngleDegrees");
		VisionAngleDegrees_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VisionAngleDegrees", Classes.FFloatProperty);
		ASRangeFromLastSeenLoc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ASRangeFromLastSeenLoc");
		ASRangeFromLastSeenLoc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ASRangeFromLastSeenLoc", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsSightDominantSense_PropertyAddress, unrealStruct, "IsSightDominantSense");
		IsSightDominantSense_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsSightDominantSense");
		IsSightDominantSense_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsSightDominantSense", Classes.FBoolProperty);
	}

	static BGWDataAsset_AIPerceptionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AIPerceptionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AIPerceptionConfig));
	}
}
