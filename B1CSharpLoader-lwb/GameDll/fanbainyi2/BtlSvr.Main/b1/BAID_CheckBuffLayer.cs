using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckBuffLayer")]
internal class BAID_CheckBuffLayer : BAID_Base
{
	private static bool isUpper_IsValid;

	private static int isUpper_Offset;

	private static FFieldAddress isUpper_PropertyAddress;

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool CheckTargetType_IsValid;

	private static int CheckTargetType_Offset;

	[EditAnywhere]
	[Tooltip("true:大于； false:小于")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("True大于 / False小于")]
	[USharpPath("/Script/b1-Managed.BAID_CheckBuffLayer:isUpper")]
	public bool isUpper
	{
		get
		{
			CheckDestroyed();
			if (!isUpper_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayer:isUpper");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, isUpper_Offset), 0, isUpper_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!isUpper_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayer:isUpper");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, isUpper_Offset), 0, isUpper_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckBuffLayer:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayer:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayer:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckBuffLayer:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayer:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayer:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("检测目标类型")]
	[Tooltip("自身：1, 敌人：4")]
	[USharpPath("/Script/b1-Managed.BAID_CheckBuffLayer:CheckTargetType")]
	public int CheckTargetType
	{
		get
		{
			CheckDestroyed();
			if (!CheckTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayer:CheckTargetType");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CheckTargetType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckBuffLayer:CheckTargetType");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CheckTargetType_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		AActor actor = null;
		switch (CheckTargetType)
		{
		case 1:
			actor = bGUCharacterCS;
			break;
		case 4:
			actor = BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS);
			break;
		}
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(actor);
		if (readOnlyData == null)
		{
			return false;
		}
		int buffLayer = readOnlyData.GetBuffLayer(BuffID);
		if (isUpper)
		{
			if (buffLayer > BuffLayer)
			{
				return true;
			}
			return false;
		}
		if (buffLayer < BuffLayer)
		{
			return true;
		}
		return false;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		CheckTargetType = 1;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckBuffLayer");
		NativeReflection.GetPropertyRef(ref isUpper_PropertyAddress, unrealStruct, "isUpper");
		isUpper_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "isUpper");
		isUpper_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "isUpper", Classes.FBoolProperty);
		BuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffLayer", Classes.FIntProperty);
		CheckTargetType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckTargetType");
		CheckTargetType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckTargetType", Classes.FIntProperty);
	}

	static BAID_CheckBuffLayer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckBuffLayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckBuffLayer));
	}
}
