using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_DamageNumConfig")]
public class BGWDataAsset_DamageNumConfig : UBGWDataAsset
{
	private static bool AmplitudeMin_IsValid;

	private static int AmplitudeMin_Offset;

	private static bool AmplitudeMax_IsValid;

	private static int AmplitudeMax_Offset;

	private static bool AmplitudeRandomParam_IsValid;

	private static int AmplitudeRandomParam_Offset;

	private static bool DefaultDir_IsValid;

	private static int DefaultDir_Offset;

	private static bool DirRandomParam_IsValid;

	private static int DirRandomParam_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("最小幅度")]
	[Category("Amplitude")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeMin")]
	public float AmplitudeMin
	{
		get
		{
			CheckDestroyed();
			if (!AmplitudeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AmplitudeMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AmplitudeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AmplitudeMin_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("最大幅度")]
	[Category("Amplitude")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeMax")]
	public float AmplitudeMax
	{
		get
		{
			CheckDestroyed();
			if (!AmplitudeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AmplitudeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AmplitudeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AmplitudeMax_Offset), value);
			}
		}
	}

	[Category("Amplitude")]
	[DisplayName("幅度浮动参数")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeRandomParam")]
	public float AmplitudeRandomParam
	{
		get
		{
			CheckDestroyed();
			if (!AmplitudeRandomParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeRandomParam");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AmplitudeRandomParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AmplitudeRandomParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:AmplitudeRandomParam");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AmplitudeRandomParam_Offset), value);
			}
		}
	}

	[Category("Direction")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("默认方向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:DefaultDir")]
	public FVector2D DefaultDir
	{
		get
		{
			CheckDestroyed();
			if (!DefaultDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:DefaultDir");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, DefaultDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:DefaultDir");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, DefaultDir_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Direction")]
	[DisplayName("方向偏移随机参数")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:DirRandomParam")]
	public float DirRandomParam
	{
		get
		{
			CheckDestroyed();
			if (!DirRandomParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:DirRandomParam");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DirRandomParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirRandomParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DamageNumConfig:DirRandomParam");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DirRandomParam_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AmplitudeMin = 0f;
		AmplitudeMax = 1.5f;
		AmplitudeRandomParam = 0.5f;
		DefaultDir = new FVector2D(0.0, 1.0);
		DirRandomParam = 60f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_DamageNumConfig");
		AmplitudeMin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AmplitudeMin");
		AmplitudeMin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AmplitudeMin", Classes.FFloatProperty);
		AmplitudeMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AmplitudeMax");
		AmplitudeMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AmplitudeMax", Classes.FFloatProperty);
		AmplitudeRandomParam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AmplitudeRandomParam");
		AmplitudeRandomParam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AmplitudeRandomParam", Classes.FFloatProperty);
		DefaultDir_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultDir");
		DefaultDir_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultDir", Classes.FStructProperty);
		DirRandomParam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirRandomParam");
		DirRandomParam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirRandomParam", Classes.FFloatProperty);
	}

	static BGWDataAsset_DamageNumConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_DamageNumConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_DamageNumConfig));
	}
}
