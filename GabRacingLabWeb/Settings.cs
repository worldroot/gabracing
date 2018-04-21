using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GabRacingLabWeb
{
public static class Settings
{
    public static string LocationName = "France - Centre";

    // Enter the password that your attendees can use to access the storage account keys.
    // You can share this password with your attendees.
    public static string Password = "RTY-YHR-WIN";

    // Enter the name and primary key for the storage account you will be using for the lab.
    public static string StorageAccountName = "tunisiegab";
    public static string StorageAccountKey = "a2zU5K2mQ2qbCVHnNP4lukgn9Mvgs7avHqa+GPV1Xo/31/EzB9AR4I1CfdJLqbouOOngBaD3EHXmmzWTGesd1Q==";


    // Do not modify these settings.
    public static int NumberOfTracks = 3;
    public static string RankingLapTimesTableName = "RankingLapTimes";
    public static string PlayerLapTableNamePrefix = "PlayerLapTimes";
    public static string RankingLapTimesPartitionKeyPrefix = "Track";

}
}