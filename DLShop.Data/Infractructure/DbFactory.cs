namespace DLShop.Data.Infractructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DLShopDbContext dbContext;

        public DLShopDbContext Init()
        {
            return dbContext ?? (dbContext = new DLShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
