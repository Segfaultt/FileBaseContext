namespace FileDb
{
    public class Messurement : Base
    {
        public TimeSpan TimeRead { get; set; }

        public TimeSpan TimeWrite { get; set; }

        public int EntryCount { get; set; }
    }
}
