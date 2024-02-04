﻿namespace PartitionOffsetsHelperTool.GPT
{
    public class GPTPartition
    {
        public Guid TypeGUID
        {
            get; set;
        }

        public Guid UID
        {
            get; set;
        }

        public ulong FirstLBA
        {
            get; set;
        }

        public ulong LastLBA
        {
            get; set;
        }

        public ulong Attributes
        {
            get; set;
        }

        public required string Name
        {
            get; set;
        }
    }
}