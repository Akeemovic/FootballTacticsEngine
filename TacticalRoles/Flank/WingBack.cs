using System;
using System.Collections.Generic;

public class WingBack : TacticalRole {
    public WingBack() : base(
        roleName: "Wing Back",
        roleNameShort: "WB",
        roleDescription: "The Wing Back fulfills both the attacking duties of a winger and the defensive duties of a full back.", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.D_Flank, TacticalPositionGroupOption.DM_Flank 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Automatic, TacticalDutyOption.Attack, TacticalDutyOption.Support, TacticalDutyOption.Defend 
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
