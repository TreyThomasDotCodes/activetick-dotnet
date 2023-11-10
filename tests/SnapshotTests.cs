namespace TreyThomasCodes.ActiveTickDotNet.Tests
{
    public class SnapshotTests
    {
        [Fact]
        public void SnapshotBuildsCorrectlyFromResponseRow()
        {
            var row = new SnapshotResponseRow()
            {
                Status = "ok",
                Symbol = "SPXW_231120C437500C_O U",
                Data = new List<SnapshotResponseRowData>
                {
                    new SnapshotResponseRowData("b", "ok", "52.80"),
                    new SnapshotResponseRowData("bsz", "ok", "5"),
                    new SnapshotResponseRowData("a", "ok", "53.10"),
                    new SnapshotResponseRowData("asz", "ok", "4"),
                    new SnapshotResponseRowData("l", "ok", "54.15"),
                    new SnapshotResponseRowData("lsz", "ok", "10"),
                    new SnapshotResponseRowData("tc", "ok", "12"),
                    new SnapshotResponseRowData("v", "ok", "42"),
                }
            };

            var expected = new Snapshot()
            {
                Ask = 53.10F,
                AskSize = 4,
                Bid = 52.80F,
                BidSize = 5,
                Last = 54.15F,
                LastSize = 10,
                Symbol = "SPXW_231120C437500C_O U",
                TradeCount = 12,
                Volume = 42
            };

            var actual = new Snapshot(row);

            Assert.Equal(expected, actual);
        }
    }
}