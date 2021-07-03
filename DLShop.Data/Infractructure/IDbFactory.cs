using System;

namespace DLShop.Data.Infractructure
{
    public interface IDbFactory : IDisposable
    {
        DLShopDbContext Init();
    }
}
