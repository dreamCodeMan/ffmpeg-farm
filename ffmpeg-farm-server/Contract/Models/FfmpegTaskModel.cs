using System;

namespace Contract.Models
{
    public class FfmpegTaskModel
    {
        public decimal Progress { get; set; }
        public decimal? VerifyProgres { get; set; }

        public TranscodingJobState State { get; set; }

        public DateTimeOffset? Heartbeat { get; set; }

        public string HeartbeatMachine { get; set; }

        public string[] DestinationFilenames { get; set; }
        public DateTimeOffset? Started { get; set; }
        public string LogPath { get; set; } 
    }
}