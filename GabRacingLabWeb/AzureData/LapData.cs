using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GabRacingLabWeb.AzureData
{
    public class LapData
    {
        public string PlayerName { get; set; }

        public int Level { get; set; }

        public int CarType { get; set; }

        public string LapId { get; set; }

        public DateTime GameStartTime { get; set; }

        public int LapTimeMs { get; set; }

        public int Dammage { get; set; }

        public List<int> SectorTimesMs { get; set; }

        public int LapDelta { get; set; }

        public int Ranking { get; set; }

        public string WebLapTime
        {
            get { return TimeSpan.FromMilliseconds(LapTimeMs).ToString("mm\\:ss\\.fff"); }
        }

        public string WebDelta
        {
            get { return TimeSpan.FromMilliseconds(LapDelta).ToString("ss\\.fff"); }
        }

        public List<string> WebSectorTimes
        {
            get
            {
                List<string> webSectorTimes = new List<string>();
                foreach (int sectorTime in SectorTimesMs)
                {
                    webSectorTimes.Add(TimeSpan.FromMilliseconds(sectorTime).ToString("mm\\:ss\\.fff"));
                }

                return webSectorTimes;
            }
        }

        public LapData()
        {
            SectorTimesMs = new List<int>();
            GameStartTime = DateTime.UtcNow;
        }


        public LapData(DynamicTableEntity lapDataEntity)
        {
            PlayerName = lapDataEntity.Properties["PlayerName"].StringValue;
            Level = (int)lapDataEntity.Properties["Level"].Int32Value;

            try { CarType = (int)lapDataEntity.Properties["CarType"].Int32Value; }
            catch { }
            try { Dammage = (int)lapDataEntity.Properties["Dammage"].Int32Value; }
            catch { }

            LapId = lapDataEntity.Properties["LapId"].StringValue;
            LapTimeMs = (int)lapDataEntity.Properties["LapTimeMs"].Int32Value;

            // Set the sector times
            SectorTimesMs = new List<int>();
            for (int sector = 1; sector < int.MaxValue; sector++)
            {
                if (lapDataEntity.Properties.ContainsKey("Sector" +
                    sector.ToString().PadLeft(2, '0')))
                {
                    SectorTimesMs.Add((int)lapDataEntity.Properties
                        ["Sector" + sector.ToString().PadLeft(2, '0')].Int32Value);
                }
                else
                {
                    break;
                }
            }


        }





    }
}