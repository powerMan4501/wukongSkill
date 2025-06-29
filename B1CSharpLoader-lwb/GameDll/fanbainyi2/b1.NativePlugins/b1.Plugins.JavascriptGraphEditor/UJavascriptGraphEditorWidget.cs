using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptGraphEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptGraphEditorWidget : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SingleNode__DelegateSignature")]
	public class FSingleNode : FDelegate<FSingleNode.Signature>
	{
		public delegate void Signature(UEdGraphNode Node);

		private static bool SingleNode__DelegateSignature_IsValid;

		private static IntPtr SingleNode__DelegateSignature_FunctionAddress;

		private static int SingleNode__DelegateSignature_ParamsSize;

		private static bool SingleNode__DelegateSignature_Node_IsValid;

		private static FFieldAddress SingleNode__DelegateSignature_Node_PropertyAddress;

		private static int SingleNode__DelegateSignature_Node_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FSingleNode()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			SingleNode__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SingleNode__DelegateSignature");
			SingleNode__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(SingleNode__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref SingleNode__DelegateSignature_Node_PropertyAddress, SingleNode__DelegateSignature_FunctionAddress, "Node");
			SingleNode__DelegateSignature_Node_Offset = NativeReflectionCached.GetPropertyOffset(SingleNode__DelegateSignature_FunctionAddress, "Node");
			SingleNode__DelegateSignature_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(SingleNode__DelegateSignature_FunctionAddress, "Node", Classes.FObjectProperty);
			SingleNode__DelegateSignature_IsValid = SingleNode__DelegateSignature_FunctionAddress != IntPtr.Zero && SingleNode__DelegateSignature_Node_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SingleNode__DelegateSignature", SingleNode__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UEdGraphNode Node)
		{
			if (!SingleNode__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SingleNode__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(SingleNode__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SingleNode__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, SingleNode__DelegateSignature_Node_Offset), 0, SingleNode__DelegateSignature_Node_PropertyAddress.Address, Node);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetNodes__DelegateSignature")]
	public class FSetNodes : FDelegate<FSetNodes.Signature>
	{
		public delegate void Signature(List<UObject> Set);

		private static bool SetNodes__DelegateSignature_IsValid;

		private static IntPtr SetNodes__DelegateSignature_FunctionAddress;

		private static int SetNodes__DelegateSignature_ParamsSize;

		private static bool SetNodes__DelegateSignature_Set_IsValid;

		private static FFieldAddress SetNodes__DelegateSignature_Set_PropertyAddress;

		private static int SetNodes__DelegateSignature_Set_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FSetNodes()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			SetNodes__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetNodes__DelegateSignature");
			SetNodes__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodes__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref SetNodes__DelegateSignature_Set_PropertyAddress, SetNodes__DelegateSignature_FunctionAddress, "Set");
			SetNodes__DelegateSignature_Set_Offset = NativeReflectionCached.GetPropertyOffset(SetNodes__DelegateSignature_FunctionAddress, "Set");
			SetNodes__DelegateSignature_Set_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodes__DelegateSignature_FunctionAddress, "Set", Classes.FArrayProperty);
			SetNodes__DelegateSignature_IsValid = SetNodes__DelegateSignature_FunctionAddress != IntPtr.Zero && SetNodes__DelegateSignature_Set_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetNodes__DelegateSignature", SetNodes__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(List<UObject> Set)
		{
			if (!SetNodes__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetNodes__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(SetNodes__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodes__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				new TArrayCopyMarshaler<UObject>(1, SetNodes__DelegateSignature_Set_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNodes__DelegateSignature_Set_Offset), Set);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(SetNodes__DelegateSignature_Set_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDropActor__DelegateSignature")]
	public class FOnDropActor : FDelegate<FOnDropActor.Signature>
	{
		public delegate void Signature(List<AActor> Actors, UEdGraph Graph, FVector2D Point);

		private static bool OnDropActor__DelegateSignature_IsValid;

		private static IntPtr OnDropActor__DelegateSignature_FunctionAddress;

		private static int OnDropActor__DelegateSignature_ParamsSize;

		private static bool OnDropActor__DelegateSignature_Actors_IsValid;

		private static FFieldAddress OnDropActor__DelegateSignature_Actors_PropertyAddress;

		private static int OnDropActor__DelegateSignature_Actors_Offset;

		private static bool OnDropActor__DelegateSignature_Graph_IsValid;

		private static FFieldAddress OnDropActor__DelegateSignature_Graph_PropertyAddress;

		private static int OnDropActor__DelegateSignature_Graph_Offset;

		private static bool OnDropActor__DelegateSignature_Point_IsValid;

		private static FFieldAddress OnDropActor__DelegateSignature_Point_PropertyAddress;

		private static int OnDropActor__DelegateSignature_Point_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnDropActor()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnDropActor__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDropActor__DelegateSignature");
			OnDropActor__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDropActor__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnDropActor__DelegateSignature_Actors_PropertyAddress, OnDropActor__DelegateSignature_FunctionAddress, "Actors");
			OnDropActor__DelegateSignature_Actors_Offset = NativeReflectionCached.GetPropertyOffset(OnDropActor__DelegateSignature_FunctionAddress, "Actors");
			OnDropActor__DelegateSignature_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDropActor__DelegateSignature_FunctionAddress, "Actors", Classes.FArrayProperty);
			NativeReflectionCached.GetPropertyRef(ref OnDropActor__DelegateSignature_Graph_PropertyAddress, OnDropActor__DelegateSignature_FunctionAddress, "Graph");
			OnDropActor__DelegateSignature_Graph_Offset = NativeReflectionCached.GetPropertyOffset(OnDropActor__DelegateSignature_FunctionAddress, "Graph");
			OnDropActor__DelegateSignature_Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDropActor__DelegateSignature_FunctionAddress, "Graph", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnDropActor__DelegateSignature_Point_PropertyAddress, OnDropActor__DelegateSignature_FunctionAddress, "Point");
			OnDropActor__DelegateSignature_Point_Offset = NativeReflectionCached.GetPropertyOffset(OnDropActor__DelegateSignature_FunctionAddress, "Point");
			OnDropActor__DelegateSignature_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDropActor__DelegateSignature_FunctionAddress, "Point", Classes.FStructProperty);
			OnDropActor__DelegateSignature_IsValid = OnDropActor__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDropActor__DelegateSignature_Actors_IsValid && OnDropActor__DelegateSignature_Graph_IsValid && OnDropActor__DelegateSignature_Point_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDropActor__DelegateSignature", OnDropActor__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(List<AActor> Actors, UEdGraph Graph, FVector2D Point)
		{
			if (!OnDropActor__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDropActor__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnDropActor__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDropActor__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				new TArrayCopyMarshaler<AActor>(1, OnDropActor__DelegateSignature_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, OnDropActor__DelegateSignature_Actors_Offset), Actors);
				UObjectMarshaler<UEdGraph>.ToNative(IntPtr.Add(intPtr, OnDropActor__DelegateSignature_Graph_Offset), 0, OnDropActor__DelegateSignature_Graph_PropertyAddress.Address, Graph);
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, OnDropActor__DelegateSignature_Point_Offset), 0, OnDropActor__DelegateSignature_Point_PropertyAddress.Address, Point);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnDropActor__DelegateSignature_Actors_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDisallowedPinConnection__DelegateSignature")]
	public class FOnDisallowedPinConnection : FDelegate<FOnDisallowedPinConnection.Signature>
	{
		public delegate void Signature(FJavascriptEdGraphPin A, FJavascriptEdGraphPin B);

		private static bool OnDisallowedPinConnection__DelegateSignature_IsValid;

		private static IntPtr OnDisallowedPinConnection__DelegateSignature_FunctionAddress;

		private static int OnDisallowedPinConnection__DelegateSignature_ParamsSize;

		private static bool OnDisallowedPinConnection__DelegateSignature_A_IsValid;

		private static FFieldAddress OnDisallowedPinConnection__DelegateSignature_A_PropertyAddress;

		private static int OnDisallowedPinConnection__DelegateSignature_A_Offset;

		private static bool OnDisallowedPinConnection__DelegateSignature_B_IsValid;

		private static FFieldAddress OnDisallowedPinConnection__DelegateSignature_B_PropertyAddress;

		private static int OnDisallowedPinConnection__DelegateSignature_B_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnDisallowedPinConnection()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnDisallowedPinConnection__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDisallowedPinConnection__DelegateSignature");
			OnDisallowedPinConnection__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDisallowedPinConnection__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnDisallowedPinConnection__DelegateSignature_A_PropertyAddress, OnDisallowedPinConnection__DelegateSignature_FunctionAddress, "A");
			OnDisallowedPinConnection__DelegateSignature_A_Offset = NativeReflectionCached.GetPropertyOffset(OnDisallowedPinConnection__DelegateSignature_FunctionAddress, "A");
			OnDisallowedPinConnection__DelegateSignature_A_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDisallowedPinConnection__DelegateSignature_FunctionAddress, "A", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnDisallowedPinConnection__DelegateSignature_B_PropertyAddress, OnDisallowedPinConnection__DelegateSignature_FunctionAddress, "B");
			OnDisallowedPinConnection__DelegateSignature_B_Offset = NativeReflectionCached.GetPropertyOffset(OnDisallowedPinConnection__DelegateSignature_FunctionAddress, "B");
			OnDisallowedPinConnection__DelegateSignature_B_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDisallowedPinConnection__DelegateSignature_FunctionAddress, "B", Classes.FStructProperty);
			OnDisallowedPinConnection__DelegateSignature_IsValid = OnDisallowedPinConnection__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDisallowedPinConnection__DelegateSignature_A_IsValid && OnDisallowedPinConnection__DelegateSignature_B_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDisallowedPinConnection__DelegateSignature", OnDisallowedPinConnection__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FJavascriptEdGraphPin A, FJavascriptEdGraphPin B)
		{
			if (!OnDisallowedPinConnection__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDisallowedPinConnection__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnDisallowedPinConnection__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDisallowedPinConnection__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnDisallowedPinConnection__DelegateSignature_A_PropertyAddress.Address, intPtr);
				FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, OnDisallowedPinConnection__DelegateSignature_A_Offset), 0, OnDisallowedPinConnection__DelegateSignature_A_PropertyAddress.Address, A);
				NativeReflection.InitializeValue_InContainer(OnDisallowedPinConnection__DelegateSignature_B_PropertyAddress.Address, intPtr);
				FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, OnDisallowedPinConnection__DelegateSignature_B_Offset), 0, OnDisallowedPinConnection__DelegateSignature_B_PropertyAddress.Address, B);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static IntPtr classAddress;

	private static bool OnNodeDoubleClicked_IsValid;

	private static int OnNodeDoubleClicked_Offset;

	private FSingleNode OnNodeDoubleClicked_DelegateCached;

	private static bool OnDropActor_IsValid;

	private static int OnDropActor_Offset;

	private FOnDropActor OnDropActor_DelegateCached;

	private static bool OnDisallowedPinConnection_IsValid;

	private static int OnDisallowedPinConnection_Offset;

	private FOnDisallowedPinConnection OnDisallowedPinConnection_DelegateCached;

	private static bool OnSelectedNodesChanged_IsValid;

	private static int OnSelectedNodesChanged_Offset;

	private FSetNodes OnSelectedNodesChanged_DelegateCached;

	private static bool SetViewLocation_IsValid;

	private static IntPtr SetViewLocation_FunctionAddress;

	private static int SetViewLocation_ParamsSize;

	private static bool SetViewLocation_Location_IsValid;

	private static FFieldAddress SetViewLocation_Location_PropertyAddress;

	private static int SetViewLocation_Location_Offset;

	private static bool SetViewLocation_ZoomAmount_IsValid;

	private static FFieldAddress SetViewLocation_ZoomAmount_PropertyAddress;

	private static int SetViewLocation_ZoomAmount_Offset;

	private static bool SetPinVisibility_IsValid;

	private static IntPtr SetPinVisibility_FunctionAddress;

	private static int SetPinVisibility_ParamsSize;

	private static bool SetPinVisibility_InVisibility_IsValid;

	private static FFieldAddress SetPinVisibility_InVisibility_PropertyAddress;

	private static int SetPinVisibility_InVisibility_Offset;

	private static bool SetNodeSelection_IsValid;

	private static IntPtr SetNodeSelection_FunctionAddress;

	private static int SetNodeSelection_ParamsSize;

	private static bool SetNodeSelection_Node_IsValid;

	private static FFieldAddress SetNodeSelection_Node_PropertyAddress;

	private static int SetNodeSelection_Node_Offset;

	private static bool SetNodeSelection_bSelect_IsValid;

	private static FFieldAddress SetNodeSelection_bSelect_PropertyAddress;

	private static int SetNodeSelection_bSelect_Offset;

	private static bool SetGraph_IsValid;

	private static IntPtr SetGraph_FunctionAddress;

	private static int SetGraph_ParamsSize;

	private static bool SetGraph_InEdGraph_IsValid;

	private static FFieldAddress SetGraph_InEdGraph_PropertyAddress;

	private static int SetGraph_InEdGraph_Offset;

	private static bool SelectAllNodes_IsValid;

	private static IntPtr SelectAllNodes_FunctionAddress;

	private static int SelectAllNodes_ParamsSize;

	private static bool NotifyGraphChanged_IsValid;

	private static IntPtr NotifyGraphChanged_FunctionAddress;

	private static int NotifyGraphChanged_ParamsSize;

	private static bool NewGraph_IsValid;

	private static IntPtr NewGraph_FunctionAddress;

	private static int NewGraph_ParamsSize;

	private static bool NewGraph_ParentScope_IsValid;

	private static FFieldAddress NewGraph_ParentScope_PropertyAddress;

	private static int NewGraph_ParentScope_Offset;

	private static bool NewGraph_ReturnValue_IsValid;

	private static FFieldAddress NewGraph_ReturnValue_PropertyAddress;

	private static int NewGraph_ReturnValue_Offset;

	private static bool JumpToPin_IsValid;

	private static IntPtr JumpToPin_FunctionAddress;

	private static int JumpToPin_ParamsSize;

	private static bool JumpToPin_JumpToMe_IsValid;

	private static FFieldAddress JumpToPin_JumpToMe_PropertyAddress;

	private static int JumpToPin_JumpToMe_Offset;

	private static bool JumpToNode_IsValid;

	private static IntPtr JumpToNode_FunctionAddress;

	private static int JumpToNode_ParamsSize;

	private static bool JumpToNode_JumpToMe_IsValid;

	private static FFieldAddress JumpToNode_JumpToMe_PropertyAddress;

	private static int JumpToNode_JumpToMe_Offset;

	private static bool JumpToNode_bRequestRename_IsValid;

	private static FFieldAddress JumpToNode_bRequestRename_PropertyAddress;

	private static int JumpToNode_bRequestRename_Offset;

	private static bool JumpToNode_bSelectNode_IsValid;

	private static FFieldAddress JumpToNode_bSelectNode_PropertyAddress;

	private static int JumpToNode_bSelectNode_Offset;

	private static bool GetViewLocation_IsValid;

	private static IntPtr GetViewLocation_FunctionAddress;

	private static int GetViewLocation_ParamsSize;

	private static bool GetViewLocation_OutLocation_IsValid;

	private static FFieldAddress GetViewLocation_OutLocation_PropertyAddress;

	private static int GetViewLocation_OutLocation_Offset;

	private static bool GetViewLocation_OutZoomAmount_IsValid;

	private static FFieldAddress GetViewLocation_OutZoomAmount_PropertyAddress;

	private static int GetViewLocation_OutZoomAmount_Offset;

	private static bool GetSelectedNodes_IsValid;

	private static IntPtr GetSelectedNodes_FunctionAddress;

	private static int GetSelectedNodes_ParamsSize;

	private static bool GetSelectedNodes_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedNodes_ReturnValue_PropertyAddress;

	private static int GetSelectedNodes_ReturnValue_Offset;

	private static bool GetPasteLocation_IsValid;

	private static IntPtr GetPasteLocation_FunctionAddress;

	private static int GetPasteLocation_ParamsSize;

	private static bool GetPasteLocation_ReturnValue_IsValid;

	private static FFieldAddress GetPasteLocation_ReturnValue_PropertyAddress;

	private static int GetPasteLocation_ReturnValue_Offset;

	private static bool ClearSelectionSet_IsValid;

	private static IntPtr ClearSelectionSet_FunctionAddress;

	private static int ClearSelectionSet_ParamsSize;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnNodeDoubleClicked")]
	public FSingleNode OnNodeDoubleClicked
	{
		get
		{
			CheckDestroyed();
			if (!OnNodeDoubleClicked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnNodeDoubleClicked");
				return new FSingleNode();
			}
			if (OnNodeDoubleClicked_DelegateCached == null)
			{
				OnNodeDoubleClicked_DelegateCached = new FSingleNode();
				OnNodeDoubleClicked_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnNodeDoubleClicked_Offset));
			}
			return OnNodeDoubleClicked_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDropActor")]
	public FOnDropActor OnDropActor
	{
		get
		{
			CheckDestroyed();
			if (!OnDropActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDropActor");
				return new FOnDropActor();
			}
			if (OnDropActor_DelegateCached == null)
			{
				OnDropActor_DelegateCached = new FOnDropActor();
				OnDropActor_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDropActor_Offset));
			}
			return OnDropActor_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDisallowedPinConnection")]
	public FOnDisallowedPinConnection OnDisallowedPinConnection
	{
		get
		{
			CheckDestroyed();
			if (!OnDisallowedPinConnection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnDisallowedPinConnection");
				return new FOnDisallowedPinConnection();
			}
			if (OnDisallowedPinConnection_DelegateCached == null)
			{
				OnDisallowedPinConnection_DelegateCached = new FOnDisallowedPinConnection();
				OnDisallowedPinConnection_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDisallowedPinConnection_Offset));
			}
			return OnDisallowedPinConnection_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnSelectedNodesChanged")]
	public FSetNodes OnSelectedNodesChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnSelectedNodesChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:OnSelectedNodesChanged");
				return new FSetNodes();
			}
			if (OnSelectedNodesChanged_DelegateCached == null)
			{
				OnSelectedNodesChanged_DelegateCached = new FSetNodes();
				OnSelectedNodesChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSelectedNodesChanged_Offset));
			}
			return OnSelectedNodesChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetViewLocation")]
	public unsafe void SetViewLocation(FVector2D Location, float ZoomAmount)
	{
		CheckDestroyed();
		if (!SetViewLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetViewLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetViewLocation_Location_Offset), 0, SetViewLocation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewLocation_ZoomAmount_Offset), 0, SetViewLocation_ZoomAmount_PropertyAddress.Address, ZoomAmount);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewLocation_FunctionAddress, intPtr, SetViewLocation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetPinVisibility")]
	public unsafe void SetPinVisibility(EPinVisibility InVisibility)
	{
		CheckDestroyed();
		if (!SetPinVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetPinVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPinVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPinVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EPinVisibility>.ToNative(IntPtr.Add(intPtr, SetPinVisibility_InVisibility_Offset), 0, SetPinVisibility_InVisibility_PropertyAddress.Address, InVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPinVisibility_FunctionAddress, intPtr, SetPinVisibility_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetNodeSelection")]
	public unsafe void SetNodeSelection(UEdGraphNode Node, bool bSelect)
	{
		CheckDestroyed();
		if (!SetNodeSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetNodeSelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, SetNodeSelection_Node_Offset), 0, SetNodeSelection_Node_PropertyAddress.Address, Node);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSelection_bSelect_Offset), 0, SetNodeSelection_bSelect_PropertyAddress.Address, bSelect);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeSelection_FunctionAddress, intPtr, SetNodeSelection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetGraph")]
	public unsafe void SetGraph(UJavascriptGraphEdGraph InEdGraph)
	{
		CheckDestroyed();
		if (!SetGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UJavascriptGraphEdGraph>.ToNative(IntPtr.Add(intPtr, SetGraph_InEdGraph_Offset), 0, SetGraph_InEdGraph_PropertyAddress.Address, InEdGraph);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGraph_FunctionAddress, intPtr, SetGraph_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SelectAllNodes")]
	public unsafe void SelectAllNodes()
	{
		CheckDestroyed();
		if (!SelectAllNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SelectAllNodes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectAllNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectAllNodes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SelectAllNodes_FunctionAddress, argsSize: SelectAllNodes_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:NotifyGraphChanged")]
	public unsafe void NotifyGraphChanged()
	{
		CheckDestroyed();
		if (!NotifyGraphChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:NotifyGraphChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyGraphChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyGraphChanged_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: NotifyGraphChanged_FunctionAddress, argsSize: NotifyGraphChanged_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:NewGraph")]
	public unsafe static UJavascriptGraphEdGraph NewGraph(UObject ParentScope)
	{
		if (!NewGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:NewGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NewGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NewGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, NewGraph_ParentScope_Offset), 0, NewGraph_ParentScope_PropertyAddress.Address, ParentScope);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NewGraph_FunctionAddress, intPtr, NewGraph_ParamsSize);
		return UObjectMarshaler<UJavascriptGraphEdGraph>.FromNative(IntPtr.Add(intPtr, NewGraph_ReturnValue_Offset), 0, NewGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:JumpToPin")]
	public unsafe void JumpToPin(FJavascriptEdGraphPin JumpToMe)
	{
		CheckDestroyed();
		if (!JumpToPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:JumpToPin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(JumpToPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JumpToPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(JumpToPin_JumpToMe_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, JumpToPin_JumpToMe_Offset), 0, JumpToPin_JumpToMe_PropertyAddress.Address, JumpToMe);
		NativeReflection.InvokeFunctionOptimized(base.Address, JumpToPin_FunctionAddress, intPtr, JumpToPin_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:JumpToNode")]
	public unsafe void JumpToNode(UEdGraphNode JumpToMe, bool bRequestRename = false, bool bSelectNode = true)
	{
		CheckDestroyed();
		if (!JumpToNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:JumpToNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(JumpToNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JumpToNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, JumpToNode_JumpToMe_Offset), 0, JumpToNode_JumpToMe_PropertyAddress.Address, JumpToMe);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, JumpToNode_bRequestRename_Offset), 0, JumpToNode_bRequestRename_PropertyAddress.Address, bRequestRename);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, JumpToNode_bSelectNode_Offset), 0, JumpToNode_bSelectNode_PropertyAddress.Address, bSelectNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, JumpToNode_FunctionAddress, intPtr, JumpToNode_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetViewLocation")]
	public unsafe void GetViewLocation(out FVector2D OutLocation, out float OutZoomAmount)
	{
		CheckDestroyed();
		if (!GetViewLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetViewLocation");
			OutLocation = default(FVector2D);
			OutZoomAmount = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewLocation_FunctionAddress, intPtr, GetViewLocation_ParamsSize);
		OutLocation = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetViewLocation_OutLocation_Offset), 0, GetViewLocation_OutLocation_PropertyAddress.Address);
		OutZoomAmount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewLocation_OutZoomAmount_Offset), 0, GetViewLocation_OutZoomAmount_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetSelectedNodes")]
	public unsafe List<UObject> GetSelectedNodes()
	{
		CheckDestroyed();
		if (!GetSelectedNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetSelectedNodes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedNodes_FunctionAddress, intPtr, GetSelectedNodes_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetSelectedNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedNodes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedNodes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetPasteLocation")]
	public unsafe FVector2D GetPasteLocation()
	{
		CheckDestroyed();
		if (!GetPasteLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetPasteLocation");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPasteLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPasteLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPasteLocation_FunctionAddress, intPtr, GetPasteLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPasteLocation_ReturnValue_Offset), 0, GetPasteLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:ClearSelectionSet")]
	public unsafe void ClearSelectionSet()
	{
		CheckDestroyed();
		if (!ClearSelectionSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:ClearSelectionSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSelectionSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSelectionSet_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearSelectionSet_FunctionAddress, argsSize: ClearSelectionSet_ParamsSize);
	}

	static UJavascriptGraphEditorWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptGraphEditorWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptGraphEditorWidget));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget");
		OnNodeDoubleClicked_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnNodeDoubleClicked");
		OnNodeDoubleClicked_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnNodeDoubleClicked", Classes.FDelegateProperty);
		OnDropActor_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnDropActor");
		OnDropActor_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnDropActor", Classes.FDelegateProperty);
		OnDisallowedPinConnection_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnDisallowedPinConnection");
		OnDisallowedPinConnection_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnDisallowedPinConnection", Classes.FDelegateProperty);
		OnSelectedNodesChanged_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnSelectedNodesChanged");
		OnSelectedNodesChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnSelectedNodesChanged", Classes.FDelegateProperty);
		SetViewLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewLocation");
		SetViewLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewLocation_Location_PropertyAddress, SetViewLocation_FunctionAddress, "Location");
		SetViewLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(SetViewLocation_FunctionAddress, "Location");
		SetViewLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewLocation_ZoomAmount_PropertyAddress, SetViewLocation_FunctionAddress, "ZoomAmount");
		SetViewLocation_ZoomAmount_Offset = NativeReflectionCached.GetPropertyOffset(SetViewLocation_FunctionAddress, "ZoomAmount");
		SetViewLocation_ZoomAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewLocation_FunctionAddress, "ZoomAmount", Classes.FFloatProperty);
		SetViewLocation_IsValid = SetViewLocation_FunctionAddress != IntPtr.Zero && SetViewLocation_Location_IsValid && SetViewLocation_ZoomAmount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetViewLocation", SetViewLocation_IsValid);
		SetPinVisibility_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPinVisibility");
		SetPinVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPinVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPinVisibility_InVisibility_PropertyAddress, SetPinVisibility_FunctionAddress, "InVisibility");
		SetPinVisibility_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetPinVisibility_FunctionAddress, "InVisibility");
		SetPinVisibility_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinVisibility_FunctionAddress, "InVisibility", Classes.FEnumProperty);
		SetPinVisibility_IsValid = SetPinVisibility_FunctionAddress != IntPtr.Zero && SetPinVisibility_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetPinVisibility", SetPinVisibility_IsValid);
		SetNodeSelection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNodeSelection");
		SetNodeSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSelection_Node_PropertyAddress, SetNodeSelection_FunctionAddress, "Node");
		SetNodeSelection_Node_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSelection_FunctionAddress, "Node");
		SetNodeSelection_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSelection_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSelection_bSelect_PropertyAddress, SetNodeSelection_FunctionAddress, "bSelect");
		SetNodeSelection_bSelect_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSelection_FunctionAddress, "bSelect");
		SetNodeSelection_bSelect_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSelection_FunctionAddress, "bSelect", Classes.FBoolProperty);
		SetNodeSelection_IsValid = SetNodeSelection_FunctionAddress != IntPtr.Zero && SetNodeSelection_Node_IsValid && SetNodeSelection_bSelect_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetNodeSelection", SetNodeSelection_IsValid);
		SetGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGraph");
		SetGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGraph_InEdGraph_PropertyAddress, SetGraph_FunctionAddress, "InEdGraph");
		SetGraph_InEdGraph_Offset = NativeReflectionCached.GetPropertyOffset(SetGraph_FunctionAddress, "InEdGraph");
		SetGraph_InEdGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGraph_FunctionAddress, "InEdGraph", Classes.FObjectProperty);
		SetGraph_IsValid = SetGraph_FunctionAddress != IntPtr.Zero && SetGraph_InEdGraph_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SetGraph", SetGraph_IsValid);
		SelectAllNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectAllNodes");
		SelectAllNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectAllNodes_FunctionAddress);
		SelectAllNodes_IsValid = SelectAllNodes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:SelectAllNodes", SelectAllNodes_IsValid);
		NotifyGraphChanged_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotifyGraphChanged");
		NotifyGraphChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyGraphChanged_FunctionAddress);
		NotifyGraphChanged_IsValid = NotifyGraphChanged_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:NotifyGraphChanged", NotifyGraphChanged_IsValid);
		NewGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NewGraph");
		NewGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(NewGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NewGraph_ParentScope_PropertyAddress, NewGraph_FunctionAddress, "ParentScope");
		NewGraph_ParentScope_Offset = NativeReflectionCached.GetPropertyOffset(NewGraph_FunctionAddress, "ParentScope");
		NewGraph_ParentScope_IsValid = NativeReflectionCached.ValidatePropertyClass(NewGraph_FunctionAddress, "ParentScope", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NewGraph_ReturnValue_PropertyAddress, NewGraph_FunctionAddress, "ReturnValue");
		NewGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NewGraph_FunctionAddress, "ReturnValue");
		NewGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NewGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		NewGraph_IsValid = NewGraph_FunctionAddress != IntPtr.Zero && NewGraph_ParentScope_IsValid && NewGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:NewGraph", NewGraph_IsValid);
		JumpToPin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "JumpToPin");
		JumpToPin_ParamsSize = NativeReflection.GetFunctionParamsSize(JumpToPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref JumpToPin_JumpToMe_PropertyAddress, JumpToPin_FunctionAddress, "JumpToMe");
		JumpToPin_JumpToMe_Offset = NativeReflectionCached.GetPropertyOffset(JumpToPin_FunctionAddress, "JumpToMe");
		JumpToPin_JumpToMe_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpToPin_FunctionAddress, "JumpToMe", Classes.FStructProperty);
		JumpToPin_IsValid = JumpToPin_FunctionAddress != IntPtr.Zero && JumpToPin_JumpToMe_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:JumpToPin", JumpToPin_IsValid);
		JumpToNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "JumpToNode");
		JumpToNode_ParamsSize = NativeReflection.GetFunctionParamsSize(JumpToNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref JumpToNode_JumpToMe_PropertyAddress, JumpToNode_FunctionAddress, "JumpToMe");
		JumpToNode_JumpToMe_Offset = NativeReflectionCached.GetPropertyOffset(JumpToNode_FunctionAddress, "JumpToMe");
		JumpToNode_JumpToMe_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpToNode_FunctionAddress, "JumpToMe", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref JumpToNode_bRequestRename_PropertyAddress, JumpToNode_FunctionAddress, "bRequestRename");
		JumpToNode_bRequestRename_Offset = NativeReflectionCached.GetPropertyOffset(JumpToNode_FunctionAddress, "bRequestRename");
		JumpToNode_bRequestRename_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpToNode_FunctionAddress, "bRequestRename", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref JumpToNode_bSelectNode_PropertyAddress, JumpToNode_FunctionAddress, "bSelectNode");
		JumpToNode_bSelectNode_Offset = NativeReflectionCached.GetPropertyOffset(JumpToNode_FunctionAddress, "bSelectNode");
		JumpToNode_bSelectNode_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpToNode_FunctionAddress, "bSelectNode", Classes.FBoolProperty);
		JumpToNode_IsValid = JumpToNode_FunctionAddress != IntPtr.Zero && JumpToNode_JumpToMe_IsValid && JumpToNode_bRequestRename_IsValid && JumpToNode_bSelectNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:JumpToNode", JumpToNode_IsValid);
		GetViewLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewLocation");
		GetViewLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewLocation_OutLocation_PropertyAddress, GetViewLocation_FunctionAddress, "OutLocation");
		GetViewLocation_OutLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetViewLocation_FunctionAddress, "OutLocation");
		GetViewLocation_OutLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewLocation_FunctionAddress, "OutLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewLocation_OutZoomAmount_PropertyAddress, GetViewLocation_FunctionAddress, "OutZoomAmount");
		GetViewLocation_OutZoomAmount_Offset = NativeReflectionCached.GetPropertyOffset(GetViewLocation_FunctionAddress, "OutZoomAmount");
		GetViewLocation_OutZoomAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewLocation_FunctionAddress, "OutZoomAmount", Classes.FFloatProperty);
		GetViewLocation_IsValid = GetViewLocation_FunctionAddress != IntPtr.Zero && GetViewLocation_OutLocation_IsValid && GetViewLocation_OutZoomAmount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetViewLocation", GetViewLocation_IsValid);
		GetSelectedNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedNodes");
		GetSelectedNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedNodes_ReturnValue_PropertyAddress, GetSelectedNodes_FunctionAddress, "ReturnValue");
		GetSelectedNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedNodes_FunctionAddress, "ReturnValue");
		GetSelectedNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedNodes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedNodes_IsValid = GetSelectedNodes_FunctionAddress != IntPtr.Zero && GetSelectedNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetSelectedNodes", GetSelectedNodes_IsValid);
		GetPasteLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPasteLocation");
		GetPasteLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPasteLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPasteLocation_ReturnValue_PropertyAddress, GetPasteLocation_FunctionAddress, "ReturnValue");
		GetPasteLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPasteLocation_FunctionAddress, "ReturnValue");
		GetPasteLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPasteLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPasteLocation_IsValid = GetPasteLocation_FunctionAddress != IntPtr.Zero && GetPasteLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:GetPasteLocation", GetPasteLocation_IsValid);
		ClearSelectionSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearSelectionSet");
		ClearSelectionSet_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSelectionSet_FunctionAddress);
		ClearSelectionSet_IsValid = ClearSelectionSet_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorWidget:ClearSelectionSet", ClearSelectionSet_IsValid);
	}
}
