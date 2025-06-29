using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AIRequestBase")]
public class AIRequestBase : UObject
{
	public FVector SelectedPoint;

	public bool IsNeedSelectPoint;

	private static bool AIRequestType_IsValid;

	private static int AIRequestType_Offset;

	private static FFieldAddress AIRequestType_PropertyAddress;

	private static bool FeatureActor_IsValid;

	private static int FeatureActor_Offset;

	private static bool PointTestInfo_IsValid;

	private static int PointTestInfo_Offset;

	private static bool FeatureTestInfo_IsValid;

	private static int FeatureTestInfo_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIRequestBase:AIRequestType")]
	public EAIRequestType AIRequestType
	{
		get
		{
			CheckDestroyed();
			if (!AIRequestType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIRequestBase:AIRequestType");
				return EAIRequestType.MoveToLoc;
			}
			return EnumMarshaler<EAIRequestType>.FromNative(IntPtr.Add(base.Address, AIRequestType_Offset), 0, AIRequestType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AIRequestType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIRequestBase:AIRequestType");
			}
			else
			{
				EnumMarshaler<EAIRequestType>.ToNative(IntPtr.Add(base.Address, AIRequestType_Offset), 0, AIRequestType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIRequestBase:FeatureActor")]
	public AActor FeatureActor
	{
		get
		{
			CheckDestroyed();
			if (!FeatureActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIRequestBase:FeatureActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, FeatureActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FeatureActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIRequestBase:FeatureActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, FeatureActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIRequestBase:PointTestInfo")]
	public AIPointTestInfo PointTestInfo
	{
		get
		{
			CheckDestroyed();
			if (!PointTestInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIRequestBase:PointTestInfo");
				return null;
			}
			return UObjectMarshaler<AIPointTestInfo>.FromNative(IntPtr.Add(base.Address, PointTestInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointTestInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIRequestBase:PointTestInfo");
			}
			else
			{
				UObjectMarshaler<AIPointTestInfo>.ToNative(IntPtr.Add(base.Address, PointTestInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.AIRequestBase:FeatureTestInfo")]
	public AIFeatureTestInfo FeatureTestInfo
	{
		get
		{
			CheckDestroyed();
			if (!FeatureTestInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIRequestBase:FeatureTestInfo");
				return null;
			}
			return UObjectMarshaler<AIFeatureTestInfo>.FromNative(IntPtr.Add(base.Address, FeatureTestInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FeatureTestInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AIRequestBase:FeatureTestInfo");
			}
			else
			{
				UObjectMarshaler<AIFeatureTestInfo>.ToNative(IntPtr.Add(base.Address, FeatureTestInfo_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SelectedPoint = default(FVector);
	}

	public void InitTestInfo(AIPointTestInfo PointTestInfo, AIFeatureTestInfo FeatureTestInfo)
	{
		this.PointTestInfo = PointTestInfo;
		this.FeatureTestInfo = FeatureTestInfo;
	}

	public virtual bool IsFinish()
	{
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AIRequestBase");
		NativeReflection.GetPropertyRef(ref AIRequestType_PropertyAddress, unrealStruct, "AIRequestType");
		AIRequestType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AIRequestType");
		AIRequestType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AIRequestType", Classes.FEnumProperty);
		FeatureActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FeatureActor");
		FeatureActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FeatureActor", Classes.FObjectProperty);
		PointTestInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointTestInfo");
		PointTestInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointTestInfo", Classes.FObjectProperty);
		FeatureTestInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FeatureTestInfo");
		FeatureTestInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FeatureTestInfo", Classes.FObjectProperty);
	}

	static AIRequestBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AIRequestBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AIRequestBase));
	}
}
