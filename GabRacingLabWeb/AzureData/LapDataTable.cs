using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GabRacingLabWeb.AzureData
{

    public class LapDataTable
    {
        private static CloudTableClient TableClient;


        static LapDataTable()
        {
            CloudStorageAccount account;

            StorageCredentials creds = new StorageCredentials(Settings.StorageAccountName, Settings.StorageAccountKey);
            account = new CloudStorageAccount(creds, true);

            TableClient = account.CreateCloudTableClient();

            // Create the tables
            CloudTable rankingsTable = TableClient.GetTableReference
                (Settings.RankingLapTimesTableName);

            rankingsTable.CreateIfNotExists();

            for (int track = 0; track < Settings.NumberOfTracks; track++)
            {
                CloudTable table = TableClient.GetTableReference(GetPlayerLapTableName(track));

                table.CreateIfNotExists();
            }

        }




        public List<LapData> GetTopLapTimes(int level, int number)
        {



            CloudTable table = TableClient.GetTableReference(Settings.RankingLapTimesTableName);

            IQueryable<DynamicTableEntity> query;


            query = (from q
                in table.CreateQuery<DynamicTableEntity>()
                     where q.PartitionKey.Equals(Settings.RankingLapTimesPartitionKeyPrefix + level)
                     select q).Take(number);


            List<LapData> topTimes = new List<LapData>();
            List<string> driverNames = new List<string>();

            int fastestTime = 0;
            int ranking = 1;

            foreach (DynamicTableEntity entity in query)
            {
               

                LapData lapData = new LapData(entity);
                if (ranking == 1)
                {
                    fastestTime = lapData.LapTimeMs;
                }
                lapData.LapDelta = lapData.LapTimeMs - fastestTime;
                lapData.Ranking = ranking;
                topTimes.Add(lapData);
                ranking++;

            }
            return topTimes;


        }

        private static string GetPlayerLapTableName(int level)
        {
            return Settings.PlayerLapTableNamePrefix + level;
        }








    }

}