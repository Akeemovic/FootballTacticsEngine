using System.Collections.Generic;

public static class TacticalPositionManager
{
    private static List<TacticalRole> AllAvailableRoles { get; } = RoleManager.GetAllAvailableRoles();

    public static TacticalPosition GK { get; } = new TacticalPosition(
        TacticalPositionGroupOption.GK, TacticalPositionOption.GK, AllAvailableRoles
    );

    public static TacticalPosition DL { get; } = new TacticalPosition(
        TacticalPositionGroupOption.D_Flank, TacticalPositionOption.DL, AllAvailableRoles
    );

    public static TacticalPosition DCL { get; } = new TacticalPosition(
        TacticalPositionGroupOption.D_Center, TacticalPositionOption.DCL, AllAvailableRoles
    );

    public static TacticalPosition DC { get; } = new TacticalPosition(
        TacticalPositionGroupOption.D_Center, TacticalPositionOption.DC, AllAvailableRoles
    );

    public static TacticalPosition DCR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.D_Center, TacticalPositionOption.DCR, AllAvailableRoles
    );

    public static TacticalPosition DR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.D_Flank, TacticalPositionOption.DR, AllAvailableRoles
    );

    public static TacticalPosition DML { get; } = new TacticalPosition(
        TacticalPositionGroupOption.DM_Flank, TacticalPositionOption.DML, AllAvailableRoles
    );

    public static TacticalPosition DMCL { get; } = new TacticalPosition(
        TacticalPositionGroupOption.DM_Center, TacticalPositionOption.DMCL, AllAvailableRoles
    );

    public static TacticalPosition DMC { get; } = new TacticalPosition(
        TacticalPositionGroupOption.DM_Center, TacticalPositionOption.DMC, AllAvailableRoles
    );

    public static TacticalPosition DMCR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.DM_Center, TacticalPositionOption.DMCR, AllAvailableRoles
    );

    public static TacticalPosition DMR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.DM_Flank, TacticalPositionOption.DMR, AllAvailableRoles
    );

    public static TacticalPosition ML { get; } = new TacticalPosition(
        TacticalPositionGroupOption.M_Flank, TacticalPositionOption.ML, AllAvailableRoles
    );

    public static TacticalPosition MCL { get; } = new TacticalPosition(
        TacticalPositionGroupOption.M_Center, TacticalPositionOption.MCL, AllAvailableRoles
    );

    public static TacticalPosition MC { get; } = new TacticalPosition(
        TacticalPositionGroupOption.M_Center, TacticalPositionOption.MC, AllAvailableRoles
    );

    public static TacticalPosition MCR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.M_Center, TacticalPositionOption.MCR, AllAvailableRoles
    );

    public static TacticalPosition MR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.M_Flank, TacticalPositionOption.MR, AllAvailableRoles
    );

    public static TacticalPosition AML { get; } = new TacticalPosition(
        TacticalPositionGroupOption.AM_Flank, TacticalPositionOption.AML, AllAvailableRoles
    );

    public static TacticalPosition AMCL { get; } = new TacticalPosition(
        TacticalPositionGroupOption.AM_Center, TacticalPositionOption.AMCL, AllAvailableRoles
    );

    public static TacticalPosition AMC { get; } = new TacticalPosition(
        TacticalPositionGroupOption.AM_Center, TacticalPositionOption.AMC, AllAvailableRoles
    );

    public static TacticalPosition AMCR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.AM_Center, TacticalPositionOption.AMCR, AllAvailableRoles
    );

    public static TacticalPosition AMR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.AM_Flank, TacticalPositionOption.AMR, AllAvailableRoles
    );

    public static TacticalPosition STCL { get; } = new TacticalPosition(
        TacticalPositionGroupOption.ST_Center, TacticalPositionOption.STCL, AllAvailableRoles
    );

    public static TacticalPosition STC { get; } = new TacticalPosition(
        TacticalPositionGroupOption.ST_Center, TacticalPositionOption.STC, AllAvailableRoles
    );

    public static TacticalPosition STCR { get; } = new TacticalPosition(
        TacticalPositionGroupOption.ST_Center, TacticalPositionOption.STCR, AllAvailableRoles
    );
}
