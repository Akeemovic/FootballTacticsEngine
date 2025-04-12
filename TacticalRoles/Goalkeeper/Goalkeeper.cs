using System;
using System.Collections.Generic;

public class Goalkeeper : TacticalRole {
    public Goalkeeper() : base(
        roleName: "Goalkeeper",
        roleNameShort: "GK",
        roleDescription: "A Goalkeeper is a Goalkeeper.", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.GK 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Defend 
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
