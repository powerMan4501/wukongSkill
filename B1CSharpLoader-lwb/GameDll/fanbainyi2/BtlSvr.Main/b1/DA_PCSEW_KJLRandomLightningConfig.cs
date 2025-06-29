using System;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig")]
public class DA_PCSEW_KJLRandomLightningConfig : UBGWDataAsset
{
	private static bool BulletID_IsValid;

	private static int BulletID_Offset;

	private static bool PointGeneratorTag_IsValid;

	private static int PointGeneratorTag_Offset;

	private static bool LimitDistance_ToPlayer_IsValid;

	private static int LimitDistance_ToPlayer_Offset;

	private static bool DummyActiveDistance_IsValid;

	private static int DummyActiveDistance_Offset;

	private static bool DummyFXCompTag_IsValid;

	private static int DummyFXCompTag_Offset;

	private static bool LightningBeam_IsValid;

	private static int LightningBeam_Offset;

	private static bool LightningEndParamName_IsValid;

	private static int LightningEndParamName_Offset;

	private static bool SocketList_IsValid;

	private static int SocketList_Offset;

	private static FFieldAddress SocketList_PropertyAddress;

	private TArrayReadWriteMarshaler<string> SocketList_Marshaler;

	private static bool DummyBulletNum_IsValid;

	private static int DummyBulletNum_Offset;

	private static bool EndPos_Noise_IsValid;

	private static int EndPos_Noise_Offset;

	private static bool RandomInterval_IsValid;

	private static int RandomInterval_Offset;

	[UProperty]
	[DisplayName("子弹ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:BulletID")]
	public int BulletID
	{
		get
		{
			CheckDestroyed();
			if (!BulletID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:BulletID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BulletID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:BulletID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BulletID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("点集生成器ActorTag")]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:PointGeneratorTag")]
	public string PointGeneratorTag
	{
		get
		{
			CheckDestroyed();
			if (!PointGeneratorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:PointGeneratorTag");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PointGeneratorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointGeneratorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:PointGeneratorTag");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PointGeneratorTag_Offset), value);
			}
		}
	}

	[Tooltip("筛选距离玩家小于等于该值的点集合")]
	[DisplayName("点集距离筛选")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LimitDistance_ToPlayer")]
	public float LimitDistance_ToPlayer
	{
		get
		{
			CheckDestroyed();
			if (!LimitDistance_ToPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LimitDistance_ToPlayer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LimitDistance_ToPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LimitDistance_ToPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LimitDistance_ToPlayer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LimitDistance_ToPlayer_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("小于这个距离释放雷电子弹，大于等于这个距离播假特效示意")]
	[DisplayName("真假逻辑距离分界线")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyActiveDistance")]
	public float DummyActiveDistance
	{
		get
		{
			CheckDestroyed();
			if (!DummyActiveDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyActiveDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DummyActiveDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DummyActiveDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyActiveDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DummyActiveDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("远距离激活特效Tag")]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyFXCompTag")]
	public FName DummyFXCompTag
	{
		get
		{
			CheckDestroyed();
			if (!DummyFXCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyFXCompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DummyFXCompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DummyFXCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyFXCompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DummyFXCompTag_Offset), value);
			}
		}
	}

	[DisplayName("雷电Beam特效")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LightningBeam")]
	public UNiagaraSystem LightningBeam
	{
		get
		{
			CheckDestroyed();
			if (!LightningBeam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LightningBeam");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, LightningBeam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightningBeam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LightningBeam");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, LightningBeam_Offset), value);
			}
		}
	}

	[DisplayName("雷电Beam特效EndParam")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LightningEndParamName")]
	public string LightningEndParamName
	{
		get
		{
			CheckDestroyed();
			if (!LightningEndParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LightningEndParamName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, LightningEndParamName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightningEndParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:LightningEndParamName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, LightningEndParamName_Offset), value);
			}
		}
	}

	[DisplayName("雷电Beam发射点SocketList")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:SocketList")]
	public TArrayReadWrite<string> SocketList
	{
		get
		{
			CheckDestroyed();
			if (!SocketList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:SocketList");
				return null;
			}
			if (SocketList_Marshaler == null)
			{
				SocketList_Marshaler = new TArrayReadWriteMarshaler<string>(1, SocketList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return SocketList_Marshaler.FromNative(IntPtr.Add(base.Address, SocketList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("气氛组子弹数量")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyBulletNum")]
	public int DummyBulletNum
	{
		get
		{
			CheckDestroyed();
			if (!DummyBulletNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyBulletNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DummyBulletNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DummyBulletNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:DummyBulletNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DummyBulletNum_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("目标点Noise")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:EndPos_Noise")]
	public FVector EndPos_Noise
	{
		get
		{
			CheckDestroyed();
			if (!EndPos_Noise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:EndPos_Noise");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, EndPos_Noise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndPos_Noise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:EndPos_Noise");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, EndPos_Noise_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("间隔 Random [X, Y]")]
	[DisplayName("一波雷电随机间隔")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:RandomInterval")]
	public FVector2D RandomInterval
	{
		get
		{
			CheckDestroyed();
			if (!RandomInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:RandomInterval");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, RandomInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig:RandomInterval");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, RandomInterval_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.DA_PCSEW_KJLRandomLightningConfig");
		BulletID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BulletID");
		BulletID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BulletID", Classes.FIntProperty);
		PointGeneratorTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointGeneratorTag");
		PointGeneratorTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointGeneratorTag", Classes.FStrProperty);
		LimitDistance_ToPlayer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LimitDistance_ToPlayer");
		LimitDistance_ToPlayer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LimitDistance_ToPlayer", Classes.FFloatProperty);
		DummyActiveDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DummyActiveDistance");
		DummyActiveDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DummyActiveDistance", Classes.FFloatProperty);
		DummyFXCompTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DummyFXCompTag");
		DummyFXCompTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DummyFXCompTag", Classes.FNameProperty);
		LightningBeam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightningBeam");
		LightningBeam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightningBeam", Classes.FObjectProperty);
		LightningEndParamName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightningEndParamName");
		LightningEndParamName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightningEndParamName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref SocketList_PropertyAddress, unrealStruct, "SocketList");
		SocketList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SocketList");
		SocketList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SocketList", Classes.FArrayProperty);
		DummyBulletNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DummyBulletNum");
		DummyBulletNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DummyBulletNum", Classes.FIntProperty);
		EndPos_Noise_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndPos_Noise");
		EndPos_Noise_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndPos_Noise", Classes.FStructProperty);
		RandomInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RandomInterval");
		RandomInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RandomInterval", Classes.FStructProperty);
	}

	static DA_PCSEW_KJLRandomLightningConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DA_PCSEW_KJLRandomLightningConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DA_PCSEW_KJLRandomLightningConfig));
	}
}
