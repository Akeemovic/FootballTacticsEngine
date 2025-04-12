using System;
using System.Collections.Generic;

public class CompleteForward : TacticalRole {
    public CompleteForward() : base(
        roleName: "Complete Forward",
        roleNameShort: "CF",
        roleDescription: "A Complete Forward has the technicality of Deep-Lying Forward, the physicality of a Target Man and the finishing of a Poacher.", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.ST_Center 
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
        // To be implemented later
        return null;    
    }
}
