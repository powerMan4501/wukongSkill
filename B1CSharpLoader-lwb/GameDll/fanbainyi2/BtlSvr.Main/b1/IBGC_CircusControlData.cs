using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBGC_CircusControlData
{
	List<CircusMember> CircusRootMembers { get; }

	Dictionary<string, CircusMember> CircusRootMemberMapping { get; }

	void TravelCircus(AActor Actor, Action<CircusMember> AnalyzeNodeFunc);

	void TravelCircus(AActor Actor, Action<CircusMember> AnalyzeNodeFunc, Predicate<CircusMember> PredicateNodeFunc);

	void TravelCircus(CircusMember Node, Action<CircusMember> AnalyzeNodeFunc);

	void TravelCircus(CircusMember Node, Action<CircusMember> AnalyzeNodeFunc, Predicate<CircusMember> PredicateNodeFunc);

	void TravelCircus(AActor Actor, Action<CircusMember> AnalyzeNodeFunc, ESocketMatchTamerType MatchType, string SocketName);

	void TravelCircus(AActor Actor, Action<CircusMember> AnalyzeNodeFunc, ESocketMatchTamerType MatchType, FName SocketName);

	CircusMember GetCircusRootMember(string GUID);

	CircusMember GetCircusRootMember(AActor Actor);

	CircusMember GetCircusMember(string GUID);

	List<string> GetAllMemberGUID(string GUID);

	List<string> GetChildrenGUID(string GUID, bool Recursively = true);

	string GetLastDeadUnit(string FamilyRootNodeGuid);

	bool IsInSameCircus(AActor LeftActor, AActor RightActor);

	bool IsRoot(AActor Actor);
}
