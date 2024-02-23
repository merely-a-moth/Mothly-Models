namespace Mothly_Models
{
    public interface IRefreshTrack
    {
        /// <summary>
        /// The total refresh available
        /// </summary>
        uint Total {  get; }

        /// <summary>
        /// Currently available amount of refresh
        /// </summary>
        uint Current { get; }
    }

    public class RefreshTrack : IRefreshTrack
    {
        public uint Total { get; set; } = 0;
        public uint Current { get; set; } = 0;
    }
}