using System;
using System.Collections.Generic;

public class Poacher : TacticalRole {
    public Poacher() : base(
        roleName: "Poacher",
        roleNameShort: "P",
        roleDescription: "A Poacher is a tap-in merchant.", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.ST_Center 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Attack
            }
        )
    {
        // Contructor body

        // SetPersonalInstruction();
    }

    // void SetPersonalInstruction() 
    // {
    //     OnOppositionHasBall onOppositionHasBall = new OnOppositionHasBall();
    //     OnTeamHasBall onTeamHasBall = new OnTeamHasBall();
    //     OnPlayerHasBall onPlayerHasBall = new OnPlayerHasBall();
        
    //     PersonalInstruction = new PersonalInstruction(onOppositionHasBall, onTeamHasBall, onPlayerHasBall);
    // }

    public override Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption> GetAvailableZones(TacticalPositionOption position, TacticalDutyOption duty) 
    {
        // To be implemented later
        return null;    
    }
}
