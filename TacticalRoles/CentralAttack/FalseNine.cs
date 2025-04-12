using System;
using System.Collections.Generic;

public class FalseNine : TacticalRole {
    public FalseNine() : base(
        roleName: "False Nine",
        roleNameShort: "F9",
        roleDescription: "A fake striker.", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.ST_Center 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Support, TacticalDutyOption.Attack
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
