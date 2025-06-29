using System.Collections.Generic;
using b1.Plugins.DonAINavigation;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_FlyMoveToData
{
	public FDoNNavigationQueryParams QueryParams { get; set; }

	public FDonNavigationDynamicCollisionDelegate DynamicCollisionListener { get; set; }

	public int SolutionTraversalIndex { get; set; }

	public FDoNNavigationQueryData QueryResults { get; set; }

	public bool bSolutionInvalidatedByDynamicObstacle { get; set; }

	public bool bIsANavigator { get; set; }

	public FVector TargetLocation { get; set; }

	public bool bTargetLocationChanged { get; set; }

	public ADonNavigationManager DonNavManager { get; set; }

	public bool bFlightResult { get; set; }

	public bool bFlipFlopWhenTaskExits { get; set; }

	public FDoNNavigationDebugParams DebugParams { get; set; }

	public BUC_FlyMoveToData()
	{
		Reset();
	}

	public void Reset()
	{
		SolutionTraversalIndex = 0;
		QueryParams = default(FDoNNavigationQueryParams);
		DynamicCollisionListener = new FDonNavigationDynamicCollisionDelegate();
		DebugParams = default(FDoNNavigationDebugParams);
		bSolutionInvalidatedByDynamicObstacle = false;
		bTargetLocationChanged = false;
		FDoNNavigationQueryData queryResults = new FDoNNavigationQueryData
		{
			PathSolutionOptimized = new List<FVector>()
		};
		QueryResults = queryResults;
	}
}
