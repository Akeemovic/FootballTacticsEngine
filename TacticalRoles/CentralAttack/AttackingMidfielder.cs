using System;
using System.Collections.Generic;

public class AttackingMidfielder : TacticalRole {
    public AttackingMidfielder() : base(
        roleName: "Attacking Midfielder",
        roleNameShort: "ATM",
        roleDescription: "An Attacking Midfielder bridges the gap between the midfield and attacking third", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.AM_Center 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Attack, TacticalDutyOption.Support 
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
