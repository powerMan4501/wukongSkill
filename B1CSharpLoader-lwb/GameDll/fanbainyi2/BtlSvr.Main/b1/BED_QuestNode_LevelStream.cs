using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[DisplayName("LevelStream")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_LevelStream")]
public class BED_QuestNode_LevelStream : BED_QuestNode
{
	private static bool LoadStreamingVolumes_IsValid;

	private static int LoadStreamingVolumes_Offset;

	private static FFieldAddress LoadStreamingVolumes_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<ABGWLevelStreamingVolume>> LoadStreamingVolumes_Marshaler;

	private static bool UnloadStreamingVolumes_IsValid;

	private static int UnloadStreamingVolumes_Offset;

	private static FFieldAddress UnloadStreamingVolumes_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<ABGWLevelStreamingVolume>> UnloadStreamingVolumes_Marshaler;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Quest")]
	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_LevelStream:LoadStreamingVolumes")]
	public TArrayReadWrite<TSoftObject<ABGWLevelStreamingVolume>> LoadStreamingVolumes
	{
		get
		{
			CheckDestroyed();
			if (!LoadStreamingVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_LevelStream:LoadStreamingVolumes");
				return null;
			}
			if (LoadStreamingVolumes_Marshaler == null)
			{
				LoadStreamingVolumes_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<ABGWLevelStreamingVolume>>(1, LoadStreamingVolumes_PropertyAddress, CachedMarshalingDelegates<TSoftObject<ABGWLevelStreamingVolume>, TSoftObjectMarshaler<ABGWLevelStreamingVolume>>.FromNative, CachedMarshalingDelegates<TSoftObject<ABGWLevelStreamingVolume>, TSoftObjectMarshaler<ABGWLevelStreamingVolume>>.ToNative);
			}
			return LoadStreamingVolumes_Marshaler.FromNative(IntPtr.Add(base.Address, LoadStreamingVolumes_Offset));
		}
	}

	[EditDefaultsOnly]
	[Category("Quest")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_LevelStream:UnloadStreamingVolumes")]
	public TArrayReadWrite<TSoftObject<ABGWLevelStreamingVolume>> UnloadStreamingVolumes
	{
		get
		{
			CheckDestroyed();
			if (!UnloadStreamingVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_LevelStream:UnloadStreamingVolumes");
				return null;
			}
			if (UnloadStreamingVolumes_Marshaler == null)
			{
				UnloadStreamingVolumes_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<ABGWLevelStreamingVolume>>(1, UnloadStreamingVolumes_PropertyAddress, CachedMarshalingDelegates<TSoftObject<ABGWLevelStreamingVolume>, TSoftObjectMarshaler<ABGWLevelStreamingVolume>>.FromNative, CachedMarshalingDelegates<TSoftObject<ABGWLevelStreamingVolume>, TSoftObjectMarshaler<ABGWLevelStreamingVolume>>.ToNative);
			}
			return UnloadStreamingVolumes_Marshaler.FromNative(IntPtr.Add(base.Address, UnloadStreamingVolumes_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_LevelStream:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "LevelStream";
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_LevelStream questCustom_LevelStream = new QuestCustom_LevelStream();
		if (LoadStreamingVolumes.Count > 0)
		{
			string[] array = new string[LoadStreamingVolumes.Count];
			for (int i = 0; i < LoadStreamingVolumes.Count; i++)
			{
				TSoftObject<ABGWLevelStreamingVolume> tSoftObject = LoadStreamingVolumes[i];
				if (tSoftObject.IsValid)
				{
					array[i] = tSoftObject.Value.GetName();
				}
			}
			questCustom_LevelStream.LoadStreamingVolumes.AddRange(array);
		}
		if (UnloadStreamingVolumes.Count > 0)
		{
			string[] array2 = new string[UnloadStreamingVolumes.Count];
			for (int j = 0; j < UnloadStreamingVolumes.Count; j++)
			{
				TSoftObject<ABGWLevelStreamingVolume> tSoftObject2 = UnloadStreamingVolumes[j];
				if (tSoftObject2.IsValid)
				{
					array2[j] = tSoftObject2.Value.GetName();
				}
			}
			questCustom_LevelStream.UnloadStreamingVolumes.AddRange(array2);
		}
		return questCustom_LevelStream.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.LevelStream;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_LevelStream:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_LevelStream bED_QuestNode_LevelStream = GCHelper.Find<BED_QuestNode_LevelStream>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_LevelStream.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_LevelStream");
		NativeReflection.GetPropertyRef(ref LoadStreamingVolumes_PropertyAddress, intPtr, "LoadStreamingVolumes");
		LoadStreamingVolumes_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoadStreamingVolumes");
		LoadStreamingVolumes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoadStreamingVolumes", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UnloadStreamingVolumes_PropertyAddress, intPtr, "UnloadStreamingVolumes");
		UnloadStreamingVolumes_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnloadStreamingVolumes");
		UnloadStreamingVolumes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnloadStreamingVolumes", Classes.FArrayProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_LevelStream:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_LevelStream()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_LevelStream)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_LevelStream));
	}
}
