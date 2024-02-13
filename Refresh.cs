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

    public class RefreshTrack
    {
        public uint Total { get; set; }
        public uint Current { get; set; }
    }
}