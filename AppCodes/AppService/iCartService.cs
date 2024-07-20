namespace escale.Models
{
  public static class CartService
  {
    public static string LotNo { get; set; }

    public static void NewLotNo()
    {
      // 生成新的 LotNo, 這裡假設使用 Guid 來生成唯一值
      LotNo = Guid.NewGuid().ToString();
    }
  }
}
