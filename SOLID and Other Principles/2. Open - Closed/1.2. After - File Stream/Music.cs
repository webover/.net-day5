namespace OpenClosedFileDownloadAfter
{
    using Contracts;

    public class Music : IResult
    {
        public string Artist { get; set; }

        public string Album { get; set; }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
