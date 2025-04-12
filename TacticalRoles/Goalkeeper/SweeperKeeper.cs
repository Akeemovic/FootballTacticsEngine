using System;
using System.Collections.Generic;

public class SweeperKeeper : TacticalRole {
    public SweeperKeeper() : base(
        roleName: "SweeperKeeper",
        roleNameShort: "SK",
        roleDescription: "Sweeper Keeper can Sweep!", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.GK 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Defend, TacticalDutyOption.Attack, TacticalDutyOption.Support
            }
        )
    {
        // Contructor body
    }

    public override Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption> GetAvailableZones(TacticalPositionOption position, TacticalDutyOption duty) 
    {
        return null;    
    }
}
