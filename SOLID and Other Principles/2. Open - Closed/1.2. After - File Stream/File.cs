namespace OpenClosedFileDownloadAfter
{
    using Contracts;

    public class File : IResult
    {
        public string Name { get; set; }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
