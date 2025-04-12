using System;
using System.Collections.Generic;

public static class PositionGroupManager
{
    static Dictionary<TacticalPositionGroupOption, List<TacticalPositionOption>> groupToPositions = new Dictionary<TacticalPositionGroupOption, List<TacticalPositionOption>>
    {
        { TacticalPositionGroupOption.D_Center, new List<TacticalPositionOption> { TacticalPositionOption.DC, TacticalPositionOption.DCL, TacticalPositionOption.DCR } },
        { TacticalPositionGroupOption.D_Flank, new List<TacticalPositionOption> { TacticalPositionOption.DL, TacticalPositionOption.DR } },
        { TacticalPositionGroupOption.DM_Center, new List<TacticalPositionOption> { TacticalPositionOption.DMC, TacticalPositionOption.DMCL, TacticalPositionOption.DMCR } },
        { TacticalPositionGroupOption.DM_Flank, new List<TacticalPositionOption> { TacticalPositionOption.DML, TacticalPositionOption.DMR } },
        { TacticalPositionGroupOption.M_Center, new List<TacticalPositionOption> { TacticalPositionOption.MC, TacticalPositionOption.MCL, TacticalPositionOption.MCR } },
        { TacticalPositionGroupOption.M_Flank, new List<TacticalPositionOption> { TacticalPositionOption.ML, TacticalPositionOption.MR } },
        { TacticalPositionGroupOption.AM_Center, new List<TacticalPositionOption> { TacticalPositionOption.AMC, TacticalPositionOption.AMCL, TacticalPositionOption.AMCR } },
        { TacticalPositionGroupOption.AM_Flank, new List<TacticalPositionOption> { TacticalPositionOption.AML, TacticalPositionOption.AMR } },
        { TacticalPositionGroupOption.ST_Center, new List<TacticalPositionOption> { TacticalPositionOption.STC, TacticalPositionOption.STCL, TacticalPositionOption.STCR } }, 
        { TacticalPositionGroupOption.GK, new List<TacticalPositionOption> { TacticalPositionOption.GK } },
    };

    public static List<TacticalPositionOption> GetPositionOptionsForGroup(TacticalPositionGroupOption groupOption)
    {
        return groupToPositions[groupOption];
    }

    public static List<TacticalPositionOption> GetPositionOptionsForGroupAll(TacticalPositionGroupOption[] groupOptions)
    {
        List<TacticalPositionOption> allPositions = new List<TacticalPositionOption>();
        foreach (var groupOption in groupOptions)
        {
            allPositions.AddRange(GetPositionOptionsForGroup(groupOption));
        }
        return allPositions;
    }
}
