using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("演员: 同步位置/旋转")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj")]
internal class BED_MovieNode_PerformerSyncTransformToRefObj : b1.BED_MovieNode_PerformerAction
{
	private static bool RefObj_IsValid;

	private static int RefObj_Offset;

	private static bool LocalOffset_InRefObjSpace_IsValid;

	private static int LocalOffset_InRefObjSpace_Offset;

	private static bool PerformerTag_IsValid;

	private static int PerformerTag_Offset;

	private static bool bPlayerAsPerformer_IsValid;

	private static int bPlayerAsPerformer_Offset;

	private static FFieldAddress bPlayerAsPerformer_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("参照物")]
	[Category("Movie")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:RefObj")]
	public FGameplayTag RefObj
	{
		get
		{
			CheckDestroyed();
			if (!RefObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:RefObj");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, RefObj_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RefObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:RefObj");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, RefObj_Offset), value);
			}
		}
	}

	[Category("Movie")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("参照物空间下的Offset")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:LocalOffset_InRefObjSpace")]
	public FVector LocalOffset_InRefObjSpace
	{
		get
		{
			CheckDestroyed();
			if (!LocalOffset_InRefObjSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:LocalOffset_InRefObjSpace");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LocalOffset_InRefObjSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocalOffset_InRefObjSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:LocalOffset_InRefObjSpace");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LocalOffset_InRefObjSpace_Offset), value);
			}
		}
	}

	[Category("Movie")]
	[DisplayName("演员Tag(ActorTag)")]
	[Tooltip("有GUID的时候优先使用GUID")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:PerformerTag")]
	public string PerformerTag
	{
		get
		{
			CheckDestroyed();
			if (!PerformerTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:PerformerTag");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PerformerTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformerTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:PerformerTag");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PerformerTag_Offset), value);
			}
		}
	}

	[DisplayName("Player作为演员")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Movie")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:bPlayerAsPerformer")]
	public bool bPlayerAsPerformer
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:bPlayerAsPerformer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerAsPerformer_Offset), 0, bPlayerAsPerformer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerAsPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:bPlayerAsPerformer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPlayerAsPerformer_Offset), 0, bPlayerAsPerformer_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		LocalOffset_InRefObjSpace = FVector.ZeroVector;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PerformerSyncTransformToRefObj;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PerformerSyncTransformToRefObj
		{
			PerformerGuid = base.Performer.TagName.PlainName,
			RefObjGuid = RefObj.TagName.PlainName,
			LocalOffsetX = LocalOffset_InRefObjSpace.X,
			LocalOffsetY = LocalOffset_InRefObjSpace.Y,
			LocalOffsetZ = LocalOffset_InRefObjSpace.Z,
			PerformerTag = PerformerTag,
			IsPlayerAsPerformer = bPlayerAsPerformer
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("演员： " + base.Performer.TagName.PlainName);
		stringBuilder.Append("参照物： " + RefObj.TagName.PlainName);
		stringBuilder.Append("Offset： \n" + LocalOffset_InRefObjSpace.ToString());
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PerformerSyncTransformToRefObj bED_MovieNode_PerformerSyncTransformToRefObj = GCHelper.Find<b1.BED_MovieNode_PerformerSyncTransformToRefObj>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PerformerSyncTransformToRefObj.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj");
		RefObj_Offset = NativeReflection.GetPropertyOffset(intPtr, "RefObj");
		RefObj_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RefObj", Classes.FStructProperty);
		LocalOffset_InRefObjSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocalOffset_InRefObjSpace");
		LocalOffset_InRefObjSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocalOffset_InRefObjSpace", Classes.FStructProperty);
		PerformerTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerformerTag");
		PerformerTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerformerTag", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref bPlayerAsPerformer_PropertyAddress, intPtr, "bPlayerAsPerformer");
		bPlayerAsPerformer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerAsPerformer");
		bPlayerAsPerformer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerAsPerformer", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PerformerSyncTransformToRefObj:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PerformerSyncTransformToRefObj()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PerformerSyncTransformToRefObj)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PerformerSyncTransformToRefObj));
	}
}
